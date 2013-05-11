Option Explicit On

Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlClient

Public Class manager
    '1 = host
    '2 = waiter
    '3 = cook/qa
    '4 = manager
    Public connStr As String
    Dim unID As String
    Dim displayName As String
    Dim holdnforedit As String
    Dim holdnforinv As String
    Dim tablenum(0 To 24) As String
    Dim count As Integer

    '---------------------creation stuff // these populate things when the form loads
    Public Sub New(ByVal connection As String, ByVal ID As String, ByVal name As String)
        InitializeComponent()
        connStr = connection
        unID = ID
        displayName = name
    End Sub

    Private Sub manager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        fillEmployeeTables()
        fillWaiterLabel()
        retrieveWaitlistData()
        retrieveOccupancyData()
        getInventoryData()

        welcomeLabel.Text = "Welcome, " + displayName + "!"
        timeLabel.Text = String.Format("{0:hh:mm:ss tt}", Date.Now)
        dateLabel.Text = Now.Date

        'don't view these tabs immediately
        'they get added back in with buttons
        TabControl2.TabPages.Remove(addTab)
        TabControl2.TabPages.Remove(editTab)

        'loop to make columns not sortable
        'Dim colnum As Integer = DataGridView1.DisplayedColumnCount(True)
        Dim colnumdgv1 As Integer = DataGridView1.ColumnCount
        Dim colnumdgv3 As Integer = DataGridView3.ColumnCount
        Dim i As Integer
        For i = 0 To (colnumdgv1 - 1)
            DataGridView1.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        For i = 0 To (colnumdgv3 - 1)
            DataGridView3.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    '---------------------universal stuff // things seen on every tab go here
    Private Sub timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer.Tick
        'every tick updates time
        timeLabel.Text = String.Format("{0:hh:mm:ss tt}", Date.Now)
        count += 1
        If count = 10 Then
            retrieveWaitlistData()
            retrieveOccupancyData()
            count = 0
        End If
    End Sub

    Private Sub logoutButton_Click(sender As System.Object, e As System.EventArgs) Handles logoutButton.Click
        login.Update()
        Me.Close()
        login.Show()
    End Sub

    Private Sub clockOutButton_Click(sender As Object, e As EventArgs) Handles clockOutButton.Click
        Dim query As String = "UPDATE restaurant.employeeinfo SET `isLoggedIn`='n' WHERE `un`='" + unID + "';"
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
        login.timeLogout = Date.Parse(Date.Now)
        login.sendTime(unID)

        login.Update()
        Me.Close()
        login.Show()
    End Sub

    '---------------------employee tab // these subs deal with all of the employee functionality of this form
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
            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(7).Visible = False
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
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
        Dim zone As String = "0"
        Dim timeworked As String = "0.00"

        errorFirstNameLabel.Visible = False
        errorLastNameLabel.Visible = False
        errorDisplayNameLabel.Visible = False
        errorUsernameLabel.Visible = False
        errorPasswordLabel.Visible = False

        If (hostButton.Checked = True) Then
            employeeType = "1"
        ElseIf (waiterButton.Checked = True) Then
            employeeType = "2"
            If (zone1Button.Checked = True And waiterButton.Checked = True) Then
                zone = "1"
            ElseIf (zone2Button.Checked = True And waiterButton.Checked = True) Then
                zone = "2"
            ElseIf (zone3Button.Checked = True And waiterButton.Checked = True) Then
                zone = "3"
            ElseIf (zone4Button.Checked = True And waiterButton.Checked = True) Then
                zone = "4"
            Else
                zoneErrorLabel.Text = "You need a zone"
                zoneErrorLabel.Visible = True
                flag = False
            End If
        ElseIf (bartenderButton.Checked = True) Then
            employeeType = "2"
            zone = "5"
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

        Dim query As String = "INSERT INTO restaurant.employeeinfo (`un`, `pw`, `type`, `firstname`, `lastname`, `displayname`, `isLoggedIn`, `note`, `areaNumber`, `timeworked`) VALUES ('" + username + "', '" + password + "', '" + employeeType + "', '" + firstName + "', '" + lastName + "', '" + displayName + "', 'n', '" + note + "', '" + zone + "', '" + timeworked + "');"
        Using connection As New MySqlConnection(connStr)
            Dim command As New MySqlCommand(query, connection)
            Try
                If flag = False Then
                    Exit Try
                End If
                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
                flag = True
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Using
        'debug
        'TextBox1.Text = holdn
        If flag = True Then
            restructureTable()
            TabControl2.TabPages.Add(listTab)
            TabControl2.SelectedTab = listTab
            TabControl2.TabPages.Remove(addTab)
            firstNameTextbox.Text = ""
            lastNameTextbox.Text = ""
            displayNameTextbox.Text = ""
            usernameTextbox.Text = ""
            passwordTextbox.Text = ""
            noteTextBox.Text = ""
        End If
    End Sub

    Private Sub waiterButton_CheckedChanged(sender As Object, e As EventArgs) Handles waiterButton.CheckedChanged
        zoneGroupBox.Visible = True
        zone1Button.Visible = True
        zone2Button.Visible = True
        zone3Button.Visible = True
        zone4Button.Visible = True
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
        Dim zone As String
        Dim timeworked As String
        Dim imAWaiter As Boolean
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
            Dim queryZO As String = "SELECT areaNumber FROM restaurant.employeeinfo WHERE n=" + holdn + ";"
            command = New MySqlCommand(queryZO, connection)
            Try
                zone = Convert.ToString(command.ExecuteScalar())
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            Dim queryTW As String = "SELECT timeworked FROM restaurant.employeeinfo WHERE n='" + holdn + "';"
            command = New MySqlCommand(queryTW, connection)
            Try
                timeworked = Convert.ToString(command.ExecuteScalar())
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            connection.Close()
        End Using

        firstNameTextBoxE.Text = firstName
        lastNameTextBoxE.Text = lastName
        displayNameTextBoxE.Text = displayName
        usernameTextBoxE.Text = username
        passwordTextBoxE.Text = password
        noteTextBoxE.Text = note
        timeWorkedTextBox.Text = timeworked

        If employeeType = "1" Then
            hostButtonE.Checked = True
        ElseIf employeeType = "2" Then
            waiterButtonE.Checked = True
        ElseIf employeeType = "3" Then
            cookQAButtonE.Checked = True
        ElseIf employeeType = "4" Then
            managerButtonE.Checked = True
        Else
            MsgBox("kys jelly w/ some salt BRAH")
        End If

        If waiterButtonE.Checked = True Then
            If zone = "1" Then
                zone1ButtonE.Checked = True
            ElseIf zone = "2" Then
                zone2ButtonE.Checked = True
            ElseIf zone = "3" Then
                zone3ButtonE.Checked = True
            ElseIf zone = "4" Then
                zone4ButtonE.Checked = True
            ElseIf zone = "5" Then
                zoneBarButtonE.Checked = True
            Else
                MsgBox("BROKEN")
            End If
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
        Dim zone As String = "0"
        Dim timeworked As String = timeWorkedTextBox.Text

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
            If (zone1ButtonE.Checked = True And waiterButtonE.Checked = True) Then
                zone = "1"
            ElseIf (zone2ButtonE.Checked = True And waiterButtonE.Checked = True) Then
                zone = "2"
            ElseIf (zone3ButtonE.Checked = True And waiterButtonE.Checked = True) Then
                zone = "3"
            ElseIf (zone4ButtonE.Checked = True And waiterButtonE.Checked = True) Then
                zone = "4"
            Else
                zoneErrorLabelE.Text = "You need a zone"
                zoneErrorLabelE.Visible = True
                flag = False
            End If
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
        ElseIf (timeworked Like "*[a-z]*" Or timeworked Like "*[A-Z]*") Then
            timeWorkedErrorLabel.Text = "Incorrect format"
            timeWorkedErrorLabel.Visible = True
            flag = False
        End If

        'nascar time
        Dim updateQuery As String = "UPDATE restaurant.employeeinfo SET `un`='" + username + "', `pw`='" + password + "', `type`='" + employeeType + "', `firstname`='" + firstName + "', `lastname`='" + lastName + "', `displayname`='" + displayName + "', `note`='" + note + "', `areaNumber`='" + zone + "', `timeworked`='" + timeworked + "' WHERE `n`='" + holdn + "';"
        Using connection As New MySqlConnection(connStr)
            Dim command As New MySqlCommand(updateQuery, connection)
            Try
                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
                flag = True
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Using

        If flag = True Then
            restructureTable()
            holdnforedit = ""
            TabControl2.TabPages.Add(listTab)
            TabControl2.SelectedTab = listTab
            TabControl2.TabPages.Remove(editTab)
        End If
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

    Private Sub resetTimeWorkedButton_Click(sender As Object, e As EventArgs) Handles resetTimeWorkedButton.Click
        Dim dropcol As String = "ALTER TABLE `restaurant`.`employeeinfo` DROP COLUMN `timeworked` ;"
        Dim addcol As String = "ALTER TABLE `restaurant`.`employeeinfo` ADD COLUMN `timeworked` DECIMAL(5,2) NOT NULL  AFTER `areaNumber` ;"
        Using connection As New MySqlConnection(connStr)
            Dim command1 As New MySqlCommand(dropcol, connection)
            Dim command2 As New MySqlCommand(addcol, connection)
            Try
                connection.Open()
                command1.ExecuteNonQuery()
                command2.ExecuteNonQuery()
                connection.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Using
        'restructureTable()
        fillEmployeeTables()
    End Sub

    '---------------------inventory tab // things dealing with the inventory tab go here
    Public Sub getInventoryData()
        Try
            Dim query As String = "SELECT * FROM restaurant.inventory;"
            Dim connection As New MySqlConnection(connStr)
            Dim da As New MySqlDataAdapter(query, connection)
            Dim ds As New DataSet()

            connection.Open()
            If da.Fill(ds) Then
                DataGridView3.DataSource = ds.Tables(0)
            End If
            connection.Close()
            DataGridView3.Columns(0).Visible = False
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        DataGridView3.Columns(1).Width = 200
        DataGridView3.Columns(2).Width = 198
    End Sub

    Private Sub DataGridView3_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        Dim value As Integer = DataGridView3.CurrentCell.RowIndex
        Dim test As String = Convert.ToString(DataGridView3.CurrentCell.Value)
        If test = Nothing Then
            addItem(value)
        End If
        fillBoxes(value)
    End Sub

    Private Sub addItem(ByVal row As Integer)
        itemNameTextBox.Visible = True
        itemNameTextBox.ReadOnly = False
        newCountLabel.Visible = True
        newCountTextBox.Visible = True
        updateInventoryButton.Visible = True
        inventoryNoteLabel.Visible = True
    End Sub

    Private Sub fillBoxes(ByVal row As Integer)
        Dim queryN As String = "SELECT n FROM restaurant.inventory LIMIT " + Convert.ToString(row) + ",1;"
        Dim itemName As String
        Dim currentCount As String
        Using connection As New MySqlConnection(connStr)
            Dim command As New MySqlCommand(queryN, connection)
            Try
                connection.Open()
                holdnforinv = Convert.ToString(command.ExecuteScalar())
                'connection.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            Dim queryItem As String = "SELECT item FROM restaurant.inventory WHERE n='" + holdnforinv + "';"
            command = New MySqlCommand(queryItem, connection)
            Try
                itemName = command.ExecuteScalar()
                itemNameTextBox.Text = itemName
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            Dim queryCurrentCount As String = "SELECT count FROM restaurant.inventory WHERE n='" + holdnforinv + "';"
            command = New MySqlCommand(queryCurrentCount, connection)
            Try
                currentCount = command.ExecuteScalar()
                currentCountTextBox.Text = currentCount
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            connection.Close()
        End Using

        itemNameTextBox.Visible = True
        itemNameLabel.Visible = True
        currentCountLabel.Visible = True
        currentCountTextBox.Visible = True
        newCountLabel.Visible = True
        newCountTextBox.Visible = True
        updateInventoryButton.Visible = True
        inventoryNoteLabel.Visible = True
    End Sub

    Private Sub updateInventoryButton_Click(sender As Object, e As EventArgs) Handles updateInventoryButton.Click
        Dim newCount As String = newCountTextBox.Text
        If (IsNumeric(newCount) = False) Then
            inventoryErrorLabel.Visible = True
            inventoryErrorLabel.Text = "#'s only"
            Exit Sub
        End If
        Dim query As String = "UPDATE restaurant.inventory SET count='" + newCount + "' WHERE n='" + holdnforinv + "';"

        If itemNameTextBox.ReadOnly = False Then
            Dim newItem As String = itemNameTextBox.Text
            If newItem Like "*[a-z]*" Or newItem Like "*[A-Z]*" Then
                query = "INSERT INTO restaurant.inventory (`item`, `count`) VALUES ('" + newItem + "', '" + newCount + "');"
            Else
                inventoryErrorLabel.Visible = True
                inventoryErrorLabel.Text = "#'s only"
                Exit Sub
            End If
        End If

        Using connection As New MySqlConnection(connStr)
            Dim command As New MySqlCommand(query, connection)
            Try
                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Using

        Dim queryDropN As String = "ALTER TABLE restaurant.inventory DROP n;"   'first step in renumbering the column n
        Using connection As New MySqlConnection(connStr)
            Dim dropcoln As New MySqlCommand(queryDropN, connection)
            Dim renumbercmd As New MySqlCommand()
            With renumbercmd
                .CommandText = "ALTER TABLE restaurant.inventory" & vbCrLf & "ADD n INT UNSIGNED NOT NULL AUTO_INCREMENT FIRST," & vbCrLf & "ADD PRIMARY KEY (n);"
                .Connection = connection
                .CommandType = CommandType.Text
            End With
            Try
                connection.Open()
                dropcoln.ExecuteNonQuery()
                renumbercmd.ExecuteNonQuery()
                connection.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Using

        newCountTextBox.Text = ""
        itemNameTextBox.Visible = False
        itemNameTextBox.ReadOnly = True
        itemNameLabel.Visible = False
        currentCountLabel.Visible = False
        currentCountTextBox.Visible = False
        newCountLabel.Visible = False
        newCountTextBox.Visible = False
        updateInventoryButton.Visible = False
        inventoryNoteLabel.Visible = False
        inventoryErrorLabel.Visible = False
        getInventoryData()
    End Sub

    '---------------------tables tab // subs that make the tables tab function properly
    Public Sub retrieveWaitlistData()
        Try
            Dim query As String = "SELECT * FROM restaurant.tablewaitlist;"
            Dim connection As New MySqlConnection(connStr)
            Dim da As New MySqlDataAdapter(query, connection)
            Dim ds As New DataSet()

            connection.Open()
            If da.Fill(ds) Then
                DataGridView2.DataSource = ds.Tables(0)
            End If
            connection.Close()
            DataGridView2.Columns(0).Visible = False
            DataGridView2.Columns(1).Width = 190
            DataGridView2.Columns(2).Width = 188
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Public Sub retrieveOccupancyData()
        Dim i As Integer = 1
        Dim j As Integer = 0
        Dim istring As String = Convert.ToString(i)
        Dim query As String = "SELECT occupied FROM restaurant.tableoccupancy WHERE n=" + istring + ";"

        Using connection As New MySqlConnection(connStr)
            Dim command As New MySqlCommand(query, connection)
            Try
                connection.Open()
                Do While (i <= 25)
                    command.CommandText = "SELECT occupied FROM restaurant.tableoccupancy WHERE n=" + istring + ";"
                    Me.tablenum(j) = Convert.ToString(command.ExecuteScalar())
                    i += 1
                    j += 1
                    istring = Convert.ToString(i)
                Loop
                connection.Close()
            Catch ex As Exception
                Console.Write(ex.Message)
            End Try
        End Using

        i = 0
        j = 0
        Do While (i <= 24)
            If i = 0 Then
                If tablenum(i) = "n" Then
                    table1Button.BackColor = Color.PaleGreen
                Else
                    table1Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 1 Then
                If tablenum(i) = "n" Then
                    table2Button.BackColor = Color.PaleGreen
                Else
                    table2Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 2 Then
                If tablenum(i) = "n" Then
                    table3Button.BackColor = Color.PaleGreen
                Else
                    table3Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 3 Then
                If tablenum(i) = "n" Then
                    table4Button.BackColor = Color.PaleGreen
                Else
                    table4Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 4 Then
                If tablenum(i) = "n" Then
                    table5Button.BackColor = Color.PaleGreen
                Else
                    table5Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 5 Then
                If tablenum(i) = "n" Then
                    table6Button.BackColor = Color.PaleGreen
                Else
                    table6Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 6 Then
                If tablenum(i) = "n" Then
                    table7Button.BackColor = Color.PaleGreen
                Else
                    table7Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 7 Then
                If tablenum(i) = "n" Then
                    table8Button.BackColor = Color.PaleGreen
                Else
                    table8Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 8 Then
                If tablenum(i) = "n" Then
                    table9Button.BackColor = Color.PaleGreen
                Else
                    table9Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 9 Then
                If tablenum(i) = "n" Then
                    table10Button.BackColor = Color.PaleGreen
                Else
                    table10Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 10 Then
                If tablenum(i) = "n" Then
                    table11Button.BackColor = Color.PaleGreen
                Else
                    table11Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 11 Then
                If tablenum(i) = "n" Then
                    table12Button.BackColor = Color.PaleGreen
                Else
                    table12Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 12 Then
                If tablenum(i) = "n" Then
                    table13Button.BackColor = Color.PaleGreen
                Else
                    table13Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 13 Then
                If tablenum(i) = "n" Then
                    table14Button.BackColor = Color.PaleGreen
                Else
                    table14Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 14 Then
                If tablenum(i) = "n" Then
                    table15Button.BackColor = Color.PaleGreen
                Else
                    table15Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 15 Then
                If tablenum(i) = "n" Then
                    barSeat1Button.BackColor = Color.PaleGreen
                Else
                    barSeat1Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 16 Then
                If tablenum(i) = "n" Then
                    barSeat2Button.BackColor = Color.PaleGreen
                Else
                    barSeat2Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 17 Then
                If tablenum(i) = "n" Then
                    barSeat3Button.BackColor = Color.PaleGreen
                Else
                    barSeat3Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 18 Then
                If tablenum(i) = "n" Then
                    barSeat4Button.BackColor = Color.PaleGreen
                Else
                    barSeat4Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 19 Then
                If tablenum(i) = "n" Then
                    barSeat5Button.BackColor = Color.PaleGreen
                Else
                    barSeat5Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 20 Then
                If tablenum(i) = "n" Then
                    barSeat6Button.BackColor = Color.PaleGreen
                Else
                    barSeat6Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 21 Then
                If tablenum(i) = "n" Then
                    barSeat7Button.BackColor = Color.PaleGreen
                Else
                    barSeat7Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 22 Then
                If tablenum(i) = "n" Then
                    barSeat8Button.BackColor = Color.PaleGreen
                Else
                    barSeat8Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 23 Then
                If tablenum(i) = "n" Then
                    barSeat9Button.BackColor = Color.PaleGreen
                Else
                    barSeat9Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 24 Then
                If tablenum(i) = "n" Then
                    barSeat10Button.BackColor = Color.PaleGreen
                Else
                    barSeat10Button.BackColor = Color.LightSalmon
                End If
            End If
            i += 1
        Loop
    End Sub

    Public Sub fillWaiterLabel()
        Dim query As String = "SELECT displayName,areaNumber FROM restaurant.employeeinfo WHERE type='2' AND isLoggedIn='y';"
        Dim waitersName(0 To 4) As String
        Dim waitersZone(0 To 4) As String
        Dim i As Integer = 0
        Dim j As Integer = 0

        Using connection As New MySqlConnection(connStr)
            Dim command As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader
            Try
                connection.Open()
                reader = command.ExecuteReader()
                While (reader.Read())
                    waitersName(i) = reader.GetString(0)
                    waitersZone(i) = reader.GetString(1)
                    i += 1
                End While
                connection.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Using

        waiter1Label.Text = ""
        waiter2Label.Text = ""
        waiter3Label.Text = ""
        waiter4Label.Text = ""
        bartenderLabel.Text = ""

        For i = 0 To 4
            If waitersZone(i) = 1 Then
                waiter1Label.Text = waitersName(i)
            ElseIf waitersZone(i) = 2 Then
                waiter2Label.Text = waitersName(i)
            ElseIf waitersZone(i) = 3 Then
                waiter3Label.Text = waitersName(i)
            ElseIf waitersZone(i) = 4 Then
                waiter4Label.Text = waitersName(i)
            ElseIf waitersZone(i) = 5 Then
                bartenderLabel.Text = waitersName(i)
            End If
        Next
    End Sub

    Private Sub addToWaitlistButton_Click(sender As Object, e As EventArgs) Handles addToWaitlistButton.Click

        Using connection As New MySqlConnection(connStr)
            Using Command As New MySqlCommand()
                With Command
                    .CommandText = "INSERT INTO restaurant.tablewaitlist (`name`, `size`) VALUES (@name,@size);"
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@name", nameTextbox.Text)
                    .Parameters.AddWithValue("@size", sizeTextbox.Text)
                End With
                Try
                    If sizeTextbox.Text = "" Or nameTextbox.Text = "" Then
                        errorLabel.Text = "You need to enter a name AND table size!"
                        errorLabel.Visible = True
                        Exit Try
                    ElseIf IsNumeric(sizeTextbox.Text) = False Then
                        errorLabel.Text = "Table size cannot include letters"
                        errorLabel.Visible = True
                        Exit Try
                    End If
                    connection.Open()
                    Command.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                Finally
                    connection.Close()
                    retrieveWaitlistData()
                End Try
            End Using
        End Using
        sizeTextbox.Text = ""
        nameTextbox.Text = ""
    End Sub

    Private Sub deleteFromWaitlistButton_Click(sender As Object, e As EventArgs) Handles deleteFromWaitlistButton.Click
        Dim holdn As String = "" 'this is where the value in column n is stored in the table
        Dim queryN As String = "SELECT n FROM restaurant.tablewaitlist LIMIT " + Convert.ToString(DataGridView2.CurrentCell.RowIndex) + ",1;"
        '^^looks at column n in table and selects the value from the row
        'id of whatever is selected in the datagridview in the application

        Dim queryDropN As String = "ALTER TABLE restaurant.tablewaitlist DROP n;"   'first step in renumbering the column n
        Using connection As New MySqlConnection(connStr)
            Dim getcmd As New MySqlCommand(queryN, connection)
            connection.Open()
            Try
                holdn = Convert.ToString(getcmd.ExecuteScalar())                'puts whatever was found from column n into a local variable
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            Dim queryDelete As String = "DELETE FROM restaurant.tablewaitlist WHERE n=" + holdn + ";"                   'this is deleting the entry that was selected in the datagridview
            Dim delcmd As New MySqlCommand(queryDelete, connection)
            Try
                delcmd.ExecuteNonQuery()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            Dim dropcoln As New MySqlCommand(queryDropN, connection)
            Dim renumbercmd As New MySqlCommand()
            With renumbercmd
                .CommandText = "ALTER TABLE restaurant.tablewaitlist" & vbCrLf & "ADD n INT UNSIGNED NOT NULL AUTO_INCREMENT FIRST," & vbCrLf & "ADD PRIMARY KEY (n);"
                .Connection = connection
                .CommandType = CommandType.Text
            End With
            Try
                dropcoln.ExecuteNonQuery()
                renumbercmd.ExecuteNonQuery()
            Finally
                connection.Close()
                retrieveWaitlistData()
            End Try
        End Using
        sizeTextbox.Text = ""
        nameTextbox.Text = ""
    End Sub

    Private Sub editTableCheckButton_Click(sender As Object, e As EventArgs) Handles editTableCheckButton.Click
        Dim tableNumber As String = tableNumTextBox.Text
        Dim numberOfTables As String = Convert.ToString(tablenum.GetUpperBound(0))

        If IsNumeric(tableNumber) = False Then
            errorLabel.Text = "Table # cannot must " & vbCrLf & "include numbers"
            errorLabel.Visible = True
        ElseIf Convert.ToInt32(tableNumber) > Convert.ToInt32(numberOfTables) Then
            errorLabel.Text = "Table # needs to be less " & vbCrLf & "than " + numberOfTables
            errorLabel.Visible = True
        Else
            Dim waiterForm As New waiter(tableNumber, connStr)
            waiterForm.Show()
        End If
    End Sub

    '--------all of the tables // these are all under the tables tab
    Private Sub table1Button_Click(sender As Object, e As EventArgs) Handles table1Button.Click
        Dim tableNum As Integer = 1
        Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
        Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

        If (table1Button.BackColor = Color.PaleGreen) Then
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryY, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            table1Button.BackColor = Color.LightSalmon
        Else
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryN, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            table1Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table2Button_Click(sender As Object, e As EventArgs) Handles table2Button.Click
        Dim tableNum As Integer = 2
        Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
        Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

        If (table2Button.BackColor = Color.PaleGreen) Then
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryY, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            table2Button.BackColor = Color.LightSalmon
        Else
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryN, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            table2Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table3Button_Click(sender As Object, e As EventArgs) Handles table3Button.Click
        Dim tableNum As Integer = 3
        Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
        Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

        If (table3Button.BackColor = Color.PaleGreen) Then
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryY, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            table3Button.BackColor = Color.LightSalmon
        Else
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryN, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            table3Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table4Button_Click(sender As Object, e As EventArgs) Handles table4Button.Click
        Dim tableNum As Integer = 4
        Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
        Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

        If (table4Button.BackColor = Color.PaleGreen) Then
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryY, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            table4Button.BackColor = Color.LightSalmon
        Else
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryN, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            table4Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table5Button_Click(sender As Object, e As EventArgs) Handles table5Button.Click
        Dim tableNum As Integer = 5
        Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
        Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

        If (table5Button.BackColor = Color.PaleGreen) Then
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryY, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            table5Button.BackColor = Color.LightSalmon
        Else
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryN, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            table5Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table6Button_Click(sender As Object, e As EventArgs) Handles table6Button.Click
        Dim tableNum As Integer = 6
        Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
        Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

        If (table6Button.BackColor = Color.PaleGreen) Then
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryY, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            table6Button.BackColor = Color.LightSalmon
        Else
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryN, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            table6Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table7Button_Click(sender As Object, e As EventArgs) Handles table7Button.Click
        Dim tableNum As Integer = 7
        Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
        Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

        If (table7Button.BackColor = Color.PaleGreen) Then
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryY, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            table7Button.BackColor = Color.LightSalmon
        Else
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryN, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            table7Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table8Button_Click(sender As Object, e As EventArgs) Handles table8Button.Click
        Dim tableNum As Integer = 8
        Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
        Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

        If (table8Button.BackColor = Color.PaleGreen) Then
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryY, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            table8Button.BackColor = Color.LightSalmon
        Else
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryN, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            table8Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table9Button_Click(sender As Object, e As EventArgs) Handles table9Button.Click
        Dim tableNum As Integer = 9
        Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
        Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

        If (table9Button.BackColor = Color.PaleGreen) Then
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryY, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            table9Button.BackColor = Color.LightSalmon
        Else
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryN, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            table9Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table10Button_Click(sender As Object, e As EventArgs) Handles table10Button.Click
        Dim tableNum As Integer = 10
        Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
        Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

        If (table10Button.BackColor = Color.PaleGreen) Then
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryY, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            table10Button.BackColor = Color.LightSalmon
        Else
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryN, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            table10Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table11Button_Click(sender As Object, e As EventArgs) Handles table11Button.Click
        Dim tableNum As Integer = 11
        Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
        Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

        If (table11Button.BackColor = Color.PaleGreen) Then
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryY, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            table11Button.BackColor = Color.LightSalmon
        Else
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryN, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            table11Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table12Button_Click(sender As Object, e As EventArgs) Handles table12Button.Click
        Dim tableNum As Integer = 12
        Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
        Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

        If (table12Button.BackColor = Color.PaleGreen) Then
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryY, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            table12Button.BackColor = Color.LightSalmon
        Else
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryN, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            table12Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table13Button_Click(sender As Object, e As EventArgs) Handles table13Button.Click
        Dim tableNum As Integer = 13
        Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
        Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

        If (table13Button.BackColor = Color.PaleGreen) Then
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryY, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            table13Button.BackColor = Color.LightSalmon
        Else
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryN, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            table13Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table14Button_Click(sender As Object, e As EventArgs) Handles table14Button.Click
        Dim tableNum As Integer = 14
        Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
        Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

        If (table14Button.BackColor = Color.PaleGreen) Then
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryY, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            table14Button.BackColor = Color.LightSalmon
        Else
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryN, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            table14Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table15Button_Click(sender As Object, e As EventArgs) Handles table15Button.Click
        Dim tableNum As Integer = 15
        Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
        Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

        If (table15Button.BackColor = Color.PaleGreen) Then
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryY, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            table15Button.BackColor = Color.LightSalmon
        Else
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryN, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            table15Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub barSeat1Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat1Button.Click
        Dim tableNum As Integer = 16
        Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
        Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

        If (barSeat1Button.BackColor = Color.PaleGreen) Then
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryY, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            barSeat1Button.BackColor = Color.LightSalmon
        Else
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryN, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            barSeat1Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub barSeat2Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat2Button.Click
        Dim tableNum As Integer = 17
        Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
        Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

        If (barSeat2Button.BackColor = Color.PaleGreen) Then
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryY, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            barSeat2Button.BackColor = Color.LightSalmon
        Else
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryN, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            barSeat2Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub barSeat3Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat3Button.Click
        Dim tableNum As Integer = 18
        Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
        Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

        If (barSeat3Button.BackColor = Color.PaleGreen) Then
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryY, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            barSeat3Button.BackColor = Color.LightSalmon
        Else
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryN, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            barSeat3Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub barSeat4Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat4Button.Click
        Dim tableNum As Integer = 19
        Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
        Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

        If (barSeat4Button.BackColor = Color.PaleGreen) Then
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryY, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            barSeat4Button.BackColor = Color.LightSalmon
        Else
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryN, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            barSeat4Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub barSeat5Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat5Button.Click
        Dim tableNum As Integer = 20
        Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
        Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

        If (barSeat5Button.BackColor = Color.PaleGreen) Then
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryY, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            barSeat5Button.BackColor = Color.LightSalmon
        Else
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryN, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            barSeat5Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub barSeat6Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat6Button.Click
        Dim tableNum As Integer = 21
        Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
        Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

        If (barSeat6Button.BackColor = Color.PaleGreen) Then
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryY, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            barSeat6Button.BackColor = Color.LightSalmon
        Else
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryN, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            barSeat6Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub barSeat7Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat7Button.Click
        Dim tableNum As Integer = 22
        Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
        Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

        If (barSeat7Button.BackColor = Color.PaleGreen) Then
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryY, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            barSeat7Button.BackColor = Color.LightSalmon
        Else
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryN, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            barSeat7Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub barSeat8Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat8Button.Click
        Dim tableNum As Integer = 23
        Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
        Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

        If (barSeat8Button.BackColor = Color.PaleGreen) Then
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryY, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            barSeat8Button.BackColor = Color.LightSalmon
        Else
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryN, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            barSeat8Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub barSeat9Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat9Button.Click
        Dim tableNum As Integer = 24
        Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
        Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

        If (barSeat9Button.BackColor = Color.PaleGreen) Then
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryY, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            barSeat9Button.BackColor = Color.LightSalmon
        Else
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryN, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            barSeat9Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub barSeat10Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat10Button.Click
        Dim tableNum As Integer = 25
        Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
        Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

        If (barSeat10Button.BackColor = Color.PaleGreen) Then
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryY, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            barSeat10Button.BackColor = Color.LightSalmon
        Else
            Using connection As New MySqlConnection(connStr)
                Dim command As New MySqlCommand(queryN, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            barSeat10Button.BackColor = Color.PaleGreen
        End If
    End Sub
End Class