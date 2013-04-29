Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Text

Public Class login

    Public connstr As String = "Database=restaurant;" + vbCrLf + "Data Source=localhost;" + vbCrLf + "User Id=root;Password=root;"
    Dim connFlag As Boolean = False
    Dim returnAnswer As Boolean = False
    Dim queryResult As Int32
    Dim queryTypeResult As Int32
    Dim queryDisplayName As String
    Dim username As String
    Friend FTstring1 As String
    Friend FTflag1 As Boolean
    Friend CEFlag As Boolean    'true = localhost, false = ip

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'tests the connection to make sure it works
        'connectionevents()
        'ftevents()
        TestConnection()

        'date/time display
        timeLoginLabel.Text = String.Format("{0:hh:mm:ss tt}", Date.Now)
        dateLoginLabel.Text = Now.Date

        'status message below un/pw input
        If (connFlag = True) Then
            checkmarkPicture.Visible = True
            statusLabel.Text = "connected"
            statusLabel.ForeColor = Color.Green
        Else
            statusLabel.Text = "not connected"
            statusLabel.ForeColor = Color.Red
        End If

        'forces fullscreen
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Public Sub TestConnection()
        Try
            Dim connection As New MySqlConnection(connStr)
            connection.Open()
            connection.Close()
            MsgBox("Connection is okay.")
            connFlag = True

        Catch ex As Exception
            MsgBox("Connection cannot be made!")
            Stop
        End Try
    End Sub

    Private Sub ftevents()
        Dim path As String = Application.StartupPath + "\r100ft.sr"

        'first read file to see if it is first time or not
        't3El38cK5dl2glhsgMJ0 - first time
        'xkLpuzVEvdEWSbfcuX3J - returning user
        Try
            Using sr As New StreamReader(path)
                FTstring1 = sr.ReadToEnd()
                Console.WriteLine(FTstring1)
                sr.Close()
            End Using
        Catch e As Exception
            Dim fs As FileStream = File.Create(path)
            Dim input As Byte() = New UTF8Encoding(True).GetBytes("t3El38cK5dl2glhsgMJ0")
            fs.Write(input, 0, input.Length)
            fs.Close()
        End Try

        'test to see if its a first time user
        If FTstring1 = "t3El38cK5dl2glhsgMJ0" Then
            FTflag1 = True
        Else
            FTflag1 = False
        End If
    End Sub

    Private Sub connectionevents()
        Dim path As String = Application.StartupPath + "\r100cs.sr"

        'read file for connection info
        Dim read As New System.IO.StreamReader(path)
        Dim alllines As List(Of String) = New List(Of String)
        Do While Not read.EndOfStream
            alllines.Add(read.ReadLine())
        Loop
        read.Close()

        'check to see if localhost is already there
        If (alllines(2).Contains("Data Source=localhost;")) Then
            Dim fs As FileStream = File.Create(path)
            Dim input As Byte() = New UTF8Encoding(True).GetBytes(connstr)
            fs.Write(input, 0, input.Length)
            fs.Close()
            CEFlag = True
        Else
            'IP is there instead of localhost
            'change connStr to the IP
            CEFlag = False
            connstr = (alllines(0) + alllines(1) + alllines(2))
        End If

    End Sub


    Private Sub timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer.Tick
        'every tick updates time
        timeLoginLabel.Text = String.Format("{0:hh:mm:ss tt}", Date.Now)
    End Sub

    Private Sub loginSubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loginSubmitButton.Click

        '1) checks if it is connected
        '       -not connected = error
        '2) checks if the username and password entered are less than 4 characters, then checks if retrieveTest() is false
        '       -username or password < 4 characters, error
        '       -retrieveTest() = false, error
        '3) if both above are true, then it 
        '       -sends off queryTypeResult to tables.vb
        '       -shows tables.vb
        '       -clears both input boxes
        '       -hides login.vb
        If (connFlag = False) Then

            errorLabel.Text = "ERROR: NOT CONNECTED"
            errorLabel.Visible = True
            usernameLogin.Text = ""
            passwordLogin.Text = ""
            'ElseIf (FTflag1 = True) Then
            '    Dim un As String = usernameLogin.Text
            '    Dim pw As String = passwordLogin.Text
            '    Dim firsttimeForm As New firsttime(connStr, un, pw)
            '    firsttimeForm.Show()
        ElseIf (usernameLogin.Text.Length < 4 Or passwordLogin.Text.Length < 4 Or retrieveTest() = False) Then
            errorLabel.Text = "ERROR: WRONG ID/PW"
            errorLabel.Visible = True
            usernameLogin.Text = ""
            passwordLogin.Text = ""
        Else
            loggingIn()
            If (queryTypeResult = 1 Or queryTypeResult = 2 Or queryTypeResult = 5) Then
                Dim tablesForm As New tables(queryTypeResult, queryDisplayName, connStr, username)
                tablesForm.Show()
                'captureTime()
                'Me.Hide()
            ElseIf (queryTypeResult = 3) Then
                Dim cookForm As New cook(connStr, username, queryDisplayName)
                cookForm.Show()
            ElseIf (queryTypeResult = 4) Then
                Dim managerForm As New manager(connStr, username, queryDisplayName)
                managerForm.Show()
            End If
            usernameLogin.Text = ""
            passwordLogin.Text = ""
            errorLabel.Visible = False
        End If
        usernameLogin.Text = ""
        passwordLogin.Text = ""
        'queryResult = Nothing
        'queryTypeResult = Nothing
        'queryDisplayName = Nothing
        'username = Nothing
        'FTstring1 = Nothing
    End Sub

    Public Sub captureTime()
        Dim timeLogin As System.DateTime = Date.Parse(Date.Now)
        Dim timeLoginCapture As New System.DateTime
        Dim timeLogout As System.DateTime
        Dim timeLogoutCapture As New System.DateTime

    End Sub

    Public Sub loggingIn()
        username = Convert.ToString(usernameLogin.Text)
        Dim query As String = "UPDATE restaurant.employeeinfo SET `isLoggedIn`='y' WHERE `un`='" + username + "';"
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
    End Sub

    Public Function retrieveTest()
        Try
            'these strings are the commands send to the mySQL command line
            Dim queryUsername As String = "SELECT pw FROM restaurant.employeeinfo WHERE un IN('" + usernameLogin.Text + "');"
            Dim queryType As String = "SELECT type FROM restaurant.employeeinfo WHERE un IN ('" + usernameLogin.Text + "');"
            Dim queryName As String = "SELECT displayname FROM restaurant.employeeinfo WHERE un IN ('" + usernameLogin.Text + "');"
            Dim pLoginHold As Int32 = Convert.ToInt32(passwordLogin.Text) 'holding the user password

            'opens connection to mySQL server
            Using connection As New MySqlConnection(connStr)
                Dim cmd As New MySqlCommand(queryUsername, connection)  'creates a command based off of query onto stated connection
                connection.Open()                                       'open connection

                Try
                    queryResult = Convert.ToInt32(cmd.ExecuteScalar())  'takes column1 row1 of returned result
                    'if nothing is found, queryResult = 0

                Catch ex As Exception
                    Console.WriteLine(ex.Message)                       'error message onto console line if something bad happens                       
                End Try
                connection.Close()                                      'closes connection
            End Using

            If queryResult <> 0 Then                                    'checks if something was RETURNED (since 0 = nothing found)
                If pLoginHold = queryResult Then                        'checks user password input to what was found in database

                    Using connection As New MySqlConnection(connStr)    'same as before but this time will be getting the type of employee
                        Dim cmd As New MySqlCommand(queryType, connection)
                        connection.Open()
                        Try
                            queryTypeResult = Convert.ToInt32(cmd.ExecuteScalar())
                        Catch ex As Exception
                            Console.WriteLine(ex.Message)
                        End Try
                        cmd = New MySqlCommand(queryName, connection)
                        Try
                            queryDisplayName = Convert.ToString(cmd.ExecuteScalar())
                        Catch ex As Exception
                            Console.WriteLine(ex.Message)
                        End Try
                        'cmd = New MySqlCommand(
                        connection.Close()
                        returnAnswer = True                             'flag to say everything is good to go!
                    End Using
                End If
            End If


        Catch ex As Exception
            Console.WriteLine(ex.Message)                           'error message to console
        End Try
        Return returnAnswer
    End Function

    Public Sub retriveDataToDataGrid()
        'THIS SUB IS FOR DEBUGGING
        'it will display what was found from user input in a datagrid (unhide the tab control over restaurant picture)

        Try
            Dim query As String = "SELECT * FROM restaurant.employeeinfo WHERE un=" + usernameLogin.Text

            Dim connection As New MySqlConnection(connStr)
            Dim da As New MySqlDataAdapter(query, connection)
            Dim ds As New DataSet()

            If da.Fill(ds) Then
                DataGridView1.DataSource = ds.Tables(0)
            End If

            connection.Close()

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub login1KeyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login1KeyButton.Click
        If passwordLogin.Text.Length = 4 Then
            loginSubmitButton.Focus()
        ElseIf usernameLogin.Text.Length = 4 Then
            passwordLogin.Text += "1"
            errorLabel.Visible = False
        ElseIf usernameLogin.Text.Length <> 4 Then
            usernameLogin.Text += "1"
        End If
    End Sub
    Private Sub login2KeyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login2KeyButton.Click
        If passwordLogin.Text.Length = 4 Then
            loginSubmitButton.Focus()
        ElseIf usernameLogin.Text.Length = 4 Then
            passwordLogin.Text += "2"
            errorLabel.Visible = False
        ElseIf usernameLogin.Text.Length <> 4 Then
            usernameLogin.Text += "2"
        End If
    End Sub
    Private Sub login3KeyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login3KeyButton.Click
        If passwordLogin.Text.Length = 4 Then
            loginSubmitButton.Focus()
        ElseIf usernameLogin.Text.Length = 4 Then
            passwordLogin.Text += "3"
            errorLabel.Visible = False
        ElseIf usernameLogin.Text.Length <> 4 Then
            usernameLogin.Text += "3"
        End If
    End Sub
    Private Sub login4KeyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login4KeyButton.Click
        If passwordLogin.Text.Length = 4 Then
            loginSubmitButton.Focus()
        ElseIf usernameLogin.Text.Length = 4 Then
            passwordLogin.Text += "4"
            errorLabel.Visible = False
        ElseIf usernameLogin.Text.Length <> 4 Then
            usernameLogin.Text += "4"
        End If
    End Sub
    Private Sub login5KeyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login5KeyButton.Click
        If passwordLogin.Text.Length = 4 Then
            loginSubmitButton.Focus()
        ElseIf usernameLogin.Text.Length = 4 Then
            passwordLogin.Text += "5"
            errorLabel.Visible = False
        ElseIf usernameLogin.Text.Length <> 4 Then
            usernameLogin.Text += "5"
        End If
    End Sub
    Private Sub login6KeyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login6KeyButton.Click
        If passwordLogin.Text.Length = 4 Then
            loginSubmitButton.Focus()
        ElseIf usernameLogin.Text.Length = 4 Then
            passwordLogin.Text += "6"
            errorLabel.Visible = False
        ElseIf usernameLogin.Text.Length <> 4 Then
            usernameLogin.Text += "6"
        End If
    End Sub
    Private Sub login7KeyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login7KeyButton.Click
        If passwordLogin.Text.Length = 4 Then
            loginSubmitButton.Focus()
        ElseIf usernameLogin.Text.Length = 4 Then
            passwordLogin.Text += "7"
            errorLabel.Visible = False
        ElseIf usernameLogin.Text.Length <> 4 Then
            usernameLogin.Text += "7"
        End If
    End Sub
    Private Sub login8KeyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login8KeyButton.Click
        If passwordLogin.Text.Length = 4 Then
            loginSubmitButton.Focus()
        ElseIf usernameLogin.Text.Length = 4 Then
            passwordLogin.Text += "8"
            errorLabel.Visible = False
        ElseIf usernameLogin.Text.Length <> 4 Then
            usernameLogin.Text += "8"
        End If
    End Sub
    Private Sub login9KeyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login9KeyButton.Click
        If passwordLogin.Text.Length = 4 Then
            loginSubmitButton.Focus()
        ElseIf usernameLogin.Text.Length = 4 Then
            passwordLogin.Text += "9"
            errorLabel.Visible = False
        ElseIf usernameLogin.Text.Length <> 4 Then
            usernameLogin.Text += "9"
        End If
    End Sub
    Private Sub login0KeyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login0KeyButton.Click
        If passwordLogin.Text.Length = 4 Then
            loginSubmitButton.Focus()
        ElseIf usernameLogin.Text.Length = 4 Then
            passwordLogin.Text += "0"
            errorLabel.Visible = False
        ElseIf usernameLogin.Text.Length <> 4 Then
            usernameLogin.Text += "0"
        End If
    End Sub

    Private Sub loginClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loginClearButton.Click
        'BELOW CODE IS FOR DEBUGGING
        'retriveDataToDataGrid()
        'retrieveTest()
        'TextBox1.Text = queryResult
        'ABOVE CODE IS FOR DEBUGGING, COMMENT OUT NEXT 2 LINES
        usernameLogin.Text = ""
        passwordLogin.Text = ""
        'get rid of below code
        Me.Close()
    End Sub

    'Private Sub reconnectButton_Click(sender As Object, e As EventArgs)
    '    Try
    '        Dim connection As New MySqlConnection(connStr)
    '        connection.Open()
    '        connection.Close()
    '        connFlag = True
    '        checkmarkPicture.Visible = True
    '        statusLabel.Text = "connected"
    '        statusLabel.ForeColor = Color.Green
    '    Catch ex As Exception
    '        checkmarkPicture.Visible = False
    '        statusLabel.Text = "not connected"
    '        statusLabel.ForeColor = Color.Red
    '    End Try
    'End Sub

    Private Sub reconnectButton_Click(sender As Object, e As EventArgs) Handles reconnectButton.Click

    End Sub
End Class
