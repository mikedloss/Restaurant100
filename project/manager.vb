Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlClient

Public Class manager
    '1 = host
    '2 = waiter
    '3 = cook/qa
    '4 = manager
    '5 = the best person in the world
    Public connStr As String
    Dim employeeID As String
    Dim dName As String
    Dim holdnforedit As String

    Public Sub New(ByVal connection As String, ByVal ID As String, ByVal displayName As String)
        InitializeComponent()
        connStr = connection
        employeeID = ID
        dName = displayName
    End Sub

    Private Sub manager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        fillEmployeeTables()

        welcomeLabel.Text = "Welcome, " + dName + "!"
        timeLabel.Text = String.Format("{0:hh:mm:ss tt}", Date.Now)
        dateLabel.Text = Now.Date

        'don't view these tabs immediately
        'they get added back in with buttons
        TabControl2.TabPages.Remove(addTab)
        TabControl2.TabPages.Remove(editTab)

        'loop to make columns not sortable
        Dim colnum As Integer = DataGridView1.DisplayedColumnCount(True)
        Dim i As Integer
        For i = 0 To (colnum - 1)
            DataGridView1.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
            i += 1
        Next
    End Sub

    Private Sub timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        'every tick updates time
        timeLabel.Text = String.Format("{0:hh:mm:ss tt}", Date.Now)
    End Sub

    Public Sub fillEmployeeTables()
        Try
            Dim query As String = "SELECT * FROM restaurant.employeeinfo;"
            Dim connection As New MySqlConnection(connStr)
            Dim da As New MySqlDataAdapter(query, connection)
            Dim ds As New DataSet()

            connection.Open()
            If da.Fill(ds) Then
                DataGridView1.DataSource = ds.Tables(0)
            End If
            connection.Close()
            'DataGridView1.Columns(0).Visible = False
            'DataGridView2.Columns(0).Visible = False
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub logoutButton_Click(sender As Object, e As EventArgs) Handles logoutButton.Click
        Dim query As String = "UPDATE restaurant.employeeinfo SET `isLoggedIn`='n' WHERE `un`='" + employeeID + "';"
        Dim connection As New MySqlConnection(connStr)
        Dim command As New MySqlCommand(query, connection)
        Try
            connection.Open()
            command.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            connection.Close()
        End Try
        Me.Close()
        login.Show()
    End Sub

    Private Sub addEmployeeButton_Click(sender As Object, e As EventArgs) Handles addEmployeeButton.Click
        Dim flag As Boolean = True
        Dim firstName As String = firstNameTextbox.Text
        Dim lastName As String = lastNameTextbox.Text
        Dim displayName As String = UCase(displayNameTextbox.Text)
        Dim employeeType As String = "0"
        Dim username As String = usernameTextbox.Text
        Dim password As String = passwordTextbox.Text
        Dim note As String = noteTextBox.Text

        errorFirstNameLabel.Visible = False
        errorLastNameLabel.Visible = False
        errorDisplayNameLabel.Visible = False
        errorUsernameLabel.Visible = False
        errorPasswordLabel.Visible = False

        If (hostButton.Checked = True) Then
            employeeType = "1"
        ElseIf (waiterButton.Checked = True Or bartenderButton.Checked = True) Then
            employeeType = "2"
        ElseIf (QAButton.Checked = True Or cookButton.Checked = True) Then
            employeeType = "3"
        ElseIf (managerButton.Checked = True) Then
            employeeType = "4"
        Else
            flag = False
        End If

        If (Len(firstName) = 0) Then
            errorFirstNameLabel.Text = "You need a correct first name"
            errorFirstNameLabel.Visible = True
            flag = False
        ElseIf (Len(lastName) = 0) Then
            errorLastNameLabel.Text = "You need a correct last name"
            errorLastNameLabel.Visible = True
            flag = False
        ElseIf (Len(displayName) = 0) Then
            errorDisplayNameLabel.Text = "You need a correct display name"
            errorDisplayNameLabel.Visible = True
            flag = False
        ElseIf (Len(username) = 0) Then
            errorUsernameLabel.Text = "You need a correct username PIN (4 digits)"
            errorUsernameLabel.Visible = True
            flag = False
        ElseIf (Len(password) = 0) Then
            errorPasswordLabel.Text = "You need a correct password PIN (4 digits)"
            errorPasswordLabel.Visible = True
            flag = False
        End If

        Dim query As String = "INSERT INTO restaurant.employeeinfo (`un`, `pw`, `type`, `firstname`, `lastname`, `displayname`, `isLoggedIn`, `note`) VALUES ('" + username + "', '" + password + "', '" + employeeType + "', '" + firstName + "', '" + lastName + "', '" + displayName + "', 'n', '" + note + "');"
        Using connection As New MySqlConnection(connStr)
            Dim command As New MySqlCommand(query, connection)
            Try
                If flag = False Then
                    Exit Try
                End If
                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Using
        'debug
        'TextBox1.Text = holdn
        restructureTable()
        TabControl2.TabPages.Add(listTab)
        TabControl2.SelectedTab = listTab
        TabControl2.TabPages.Remove(addTab)
    End Sub

    Public Sub restructureTable()
        Dim queryDropN As String = "ALTER TABLE restaurant.employeeinfo DROP n;"   'first step in renumbering the column n
        Using connection As New MySqlConnection(connStr)
            Dim dropcoln As New MySqlCommand(queryDropN, connection)
            Dim renumbercmd As New MySqlCommand()
            With renumbercmd
                .CommandText = "ALTER TABLE restaurant.employeeinfo" & vbCrLf & "ADD n INT UNSIGNED NOT NULL AUTO_INCREMENT FIRST," & vbCrLf & "ADD PRIMARY KEY (n);"
                .Connection = connection
                .CommandType = CommandType.Text
            End With
            Try
                connection.Open()
                dropcoln.ExecuteNonQuery()
                renumbercmd.ExecuteNonQuery()
            Finally
                connection.Close()
                fillEmployeeTables()
            End Try
        End Using
    End Sub

    Private Sub deleteButton_Click_1(sender As Object, e As EventArgs) Handles deleteButton.Click
        Dim holdn As String = ""
        Dim queryN As String = "SELECT n FROM restaurant.employeeinfo LIMIT " + Convert.ToString(DataGridView1.CurrentCell.RowIndex) + ",1;"
        Using connection As New MySqlConnection(connStr)
            Dim getcmd As New MySqlCommand(queryN, connection)
            connection.Open()
            Try
                holdn = Convert.ToString(getcmd.ExecuteScalar())
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            Dim queryDelete As String = "DELETE FROM restaurant.employeeinfo WHERE n=" + holdn + ";"
            Dim delcmd As New MySqlCommand(queryDelete, connection)
            Try
                delcmd.ExecuteNonQuery()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
        restructureTable()
    End Sub

    Private Sub addEmployeeButtonDGV_Click(sender As Object, e As EventArgs) Handles addEmployeeButtonDGV.Click
        TabControl2.TabPages.Add(addTab)
        TabControl2.TabPages.Remove(listTab)
        TabControl2.SelectedTab = addTab
    End Sub

    Private Sub editEmployeeButtonDGV_Click(sender As Object, e As EventArgs) Handles editEmployeeButtonDGV.Click
        'Dim flag As Boolean = False
        Dim firstName As String
        Dim lastName As String
        Dim employeeType As String
        Dim displayName As String
        Dim username As String
        Dim password As String
        Dim note As String
        Dim holdn As String = ""
        Dim queryN As String = "SELECT n FROM restaurant.employeeinfo LIMIT " + Convert.ToString(DataGridView1.CurrentCell.RowIndex) + ",1;"
        Using connection As New MySqlConnection(connStr)
            Dim command As New MySqlCommand(queryN, connection)
            Try
                connection.Open()
                holdnforedit = Convert.ToString(command.ExecuteScalar())
                holdn = holdnforedit
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            Dim queryUN As String = "SELECT un FROM restaurant.employeeinfo WHERE n=" + holdn + ";"
            command = New MySqlCommand(queryUN, connection)
            Try
                username = Convert.ToString(command.ExecuteScalar())
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            Dim queryPW As String = "SELECT pw FROM restaurant.employeeinfo WHERE n=" + holdn + ";"
            command = New MySqlCommand(queryPW, connection)
            Try
                password = Convert.ToString(command.ExecuteScalar())
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            Dim queryTY As String = "SELECT type FROM restaurant.employeeinfo WHERE n=" + holdn + ";"
            command = New MySqlCommand(queryTY, connection)
            Try
                employeeType = Convert.ToString(command.ExecuteScalar())
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            Dim queryFN As String = "SELECT firstname FROM restaurant.employeeinfo WHERE n=" + holdn + ";"
            command = New MySqlCommand(queryFN, connection)
            Try
                firstName = Convert.ToString(command.ExecuteScalar())
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            Dim queryLN As String = "SELECT lastname FROM restaurant.employeeinfo WHERE n=" + holdn + ";"
            command = New MySqlCommand(queryLN, connection)
            Try
                lastName = Convert.ToString(command.ExecuteScalar())
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            Dim queryDN As String = "SELECT displayname FROM restaurant.employeeinfo WHERE n=" + holdn + ";"
            command = New MySqlCommand(queryDN, connection)
            Try
                displayName = Convert.ToString(command.ExecuteScalar())
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            Dim queryNO As String = "SELECT note FROM restaurant.employeeinfo WHERE n=" + holdn + ";"
            command = New MySqlCommand(queryNO, connection)
            Try
                note = Convert.ToString(command.ExecuteScalar())
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Using
        firstNameTextBoxE.Text = firstName
        lastNameTextBoxE.Text = lastName
        displayNameTextBoxE.Text = displayName
        usernameTextBoxE.Text = username
        passwordTextBoxE.Text = password
        noteTextBoxE.Text = note

        If employeeType = 1 Then
            hostButtonE.Checked = True
        ElseIf employeeType = 2 Then
            waiterButtonE.Checked = True
        ElseIf employeeType = 3 Then
            cookQAButtonE.Checked = True
        ElseIf employeeType = 4 Then
            managerButtonE.Checked = True
        Else
            MsgBox("kys jelly w/ some salt BRAH")
        End If

        TabControl2.TabPages.Add(editTab)
        TabControl2.TabPages.Remove(listTab)
        TabControl2.SelectedTab = editTab
    End Sub

    Private Sub submitChangesButton_Click(sender As Object, e As EventArgs) Handles submitChangesButton.Click
        Dim flag As Boolean = True
        Dim firstName As String = firstNameTextBoxE.Text
        Dim lastName As String = lastNameTextBoxE.Text
        Dim displayName As String = UCase(displayNameTextBoxE.Text)
        Dim employeeType As String
        Dim username As String = usernameTextBoxE.Text
        Dim password As String = passwordTextBoxE.Text
        Dim note As String = noteTextBoxE.Text
        Dim holdn As String = holdnforedit

        errorFirstNameLabelE.Visible = False
        errorLastNameLabelE.Visible = False
        errorDisplayNameLabelE.Visible = False
        errorUsernameLabelE.Visible = False
        errorPasswordLabelE.Visible = False

        'error checking
        If (hostButtonE.Checked = True) Then
            employeeType = "1"
        ElseIf (waiterButtonE.Checked = True) Then
            employeeType = "2"
        ElseIf (cookQAButtonE.Checked = True) Then
            employeeType = "3"
        ElseIf (managerButton.Checked = True) Then
            employeeType = "4"
        Else
            flag = False
        End If
        'error checking
        If (Len(firstName) = 0) Then
            errorFirstNameLabelE.Text = "You need a correct first name"
            errorFirstNameLabelE.Visible = True
            flag = False
        ElseIf (Len(lastName) = 0) Then
            errorLastNameLabelE.Text = "You need a correct last name"
            errorLastNameLabelE.Visible = True
            flag = False
        ElseIf (Len(displayName) = 0) Then
            errorDisplayNameLabelE.Text = "You need a correct display name"
            errorDisplayNameLabelE.Visible = True
            flag = False
        ElseIf (Len(username) = 0) Then
            errorUsernameLabelE.Text = "You need a correct username PIN (4 digits)"
            errorUsernameLabelE.Visible = True
            flag = False
        ElseIf (Len(password) = 0) Then
            errorPasswordLabelE.Text = "You need a correct password PIN (4 digits)"
            errorPasswordLabelE.Visible = True
            flag = False
        End If

        'nascar time
        'UPDATE restaurant.employeeinfo SET un='3342', pw='3466', type='3', firstname='Geogria', lastname='Blue', displayname='GEORGIA B', note='SOME NOTES' WHERE n='9';

        Dim updateQuery As String = "UPDATE restaurant.employeeinfo SET `un`='" + username + "', `pw`='" + password + "', `type`='" + employeeType + "', `firstname`='" + firstName + "', `lastname`='" + lastName + "', `displayname`='" + displayName + "', `note`='" + note + "' WHERE `n`='" + holdn + "';"
        Using connection As New MySqlConnection(connStr)
            Dim command As New MySqlCommand(updateQuery, connection)
            Try
                connection.Open()
                command.ExecuteNonQuery()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Using
        restructureTable()
        holdnforedit = ""
        TabControl2.TabPages.Add(listTab)
        TabControl2.SelectedTab = listTab
        TabControl2.TabPages.Remove(editTab)
    End Sub

    Private Sub closeTabButton_Click(sender As Object, e As EventArgs) Handles closeTabButton.Click
        TabControl2.TabPages.Add(listTab)
        TabControl2.SelectedTab = listTab
        TabControl2.TabPages.Remove(addTab)
        firstNameTextbox.Text = ""
        lastNameTextbox.Text = ""
        displayNameTextbox.Text = ""
        usernameTextbox.Text = ""
        passwordTextbox.Text = ""
    End Sub

    Private Sub closeTabButtonE_Click(sender As Object, e As EventArgs) Handles closeTabButtonE.Click
        TabControl2.TabPages.Add(listTab)
        TabControl2.SelectedTab = listTab
        TabControl2.TabPages.Remove(editTab)
        firstNameTextBoxE.Text = ""
        lastNameTextBoxE.Text = ""
        displayNameTextBoxE.Text = ""
        usernameTextBoxE.Text = ""
        passwordTextBoxE.Text = ""
    End Sub
End Class