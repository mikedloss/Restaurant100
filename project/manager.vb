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

    Public Sub New(ByVal connection As String, ByVal ID As String)
        InitializeComponent()
        connStr = connection

    End Sub

    Private Sub manager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        fillEmployeeTables()
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
                DataGridView2.DataSource = ds.Tables(0)
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
        Dim firstName As String = firstNameTextbox.Text
        Dim lastName As String = lastNameTextbox.Text
        Dim displayName As String = UCase(displayNameTextbox.Text)
        Dim employeeType As String = "0"
        Dim username As String = usernameTextbox.Text
        Dim password As String = passwordTextbox.Text
        Dim flag As Boolean = True

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

        Dim query As String = "INSERT INTO restaurant.employeeinfo (`un`, `pw`, `type`, `firstname`, `lastname`, `displayname`, `isLoggedIn`) VALUES ('" + username + "', '" + password + "', '" + employeeType + "', '" + firstName + "', '" + lastName + "', '" + displayName + "', 'n');"
        Dim connection As New MySqlConnection(connStr)
        Dim command As New MySqlCommand(query, connection)
        Try
            If (flag = False) Then
                Exit Try
            End If
            connection.Open()
            command.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            connection.Close()
            If (flag = True) Then
                firstNameTextbox.Text = ""
                lastNameTextbox.Text = ""
                displayNameTextbox.Text = ""
                usernameTextbox.Text = ""
                passwordTextbox.Text = ""
                restructureTable()
            End If
        End Try
        'debug
        'TextBox1.Text = employeeType
    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
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
        firstNameTextbox.Text = ""
        lastNameTextbox.Text = ""
        displayNameTextbox.Text = ""
        usernameTextbox.Text = ""
        passwordTextbox.Text = ""
        'fillEmployeeTables()
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

End Class