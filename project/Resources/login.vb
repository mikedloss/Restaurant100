Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlClient

Public Class login

    Public connStr As String = "Database=test;" & _
                    "Data Source=localhost;" & _
                    "User Id=root;Password=starwars"
    Dim connflag As Boolean = False
    Dim returnanswer As Boolean = False
    Dim queryresultusername As Int32

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'tests the connection to make sure it works
        TestConnection()

        'test display of table data
        retriveDataToDataGrid()

        'date/time display
        timeLoginLabel.Text = String.Format("{0:hh:mm:ss tt}", Date.Now)
        dateLoginLabel.Text = Now.Date

        'status message below un/pw input
        If (connflag = True) Then
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
            connflag = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        'every tick updates time
        timeLoginLabel.Text = String.Format("{0:hh:mm:ss tt}", Date.Now)
    End Sub

    Private Sub loginSubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loginSubmitButton.Click

        'retriveDataToDataGrid()
        Dim uinput As Int32
        Dim pinput As Int32
        If (connflag = False) Then
            errorLabel.Text = "ERROR: NOT CONNECTED"
            errorLabel.Visible = True
            usernameLogin.Text = ""
            passwordLogin.Text = ""
        ElseIf (usernameLogin.Text.Length < 4 Or passwordLogin.Text.Length < 4) Then
            errorLabel.Text = "ERROR: WRONG ID/PW"
            errorLabel.Visible = True
            usernameLogin.Text = ""
            passwordLogin.Text = ""
        Else
            uinput = Convert.ToInt32(usernameLogin.Text)
            pinput = Convert.ToInt32(passwordLogin.Text)
            'check mysql to see if user is in db
            'retrieveTest(uinput, pinput)
            Dim tablesForm As New tables(usernameLogin.Text, passwordLogin.Text)
            tablesForm.Show()
            usernameLogin.Text = ""
            passwordLogin.Text = ""
            errorLabel.Visible = False
            Me.Hide()
        End If
    End Sub

    Public Function retrieveTest()
        'ByVal queryinput1 As Int32, ByVal queryinput2 As Int32
        Try
            Dim query1 As String = "SELECT * FROM test.employee WHERE un=" + usernameLogin.Text
            Dim query2 As String = "SELECT * FROM test.employee WHERE pw=" + passwordLogin.Text

            'Dim connection As New MySqlConnection(connStr)
            'Dim cmd1 As MySqlCommand = New MySqlCommand(query1, connection)
            'Dim cmd2 As MySqlCommand = New MySqlCommand(query2, connection)

            Dim reader2 As MySqlDataReader
            Using connection As New MySqlConnection(connStr)
                Dim cmd1 As New MySqlCommand(query1, connection)
                connection.Open()
                Try
                    queryresultusername = Convert.ToInt32(cmd1.ExecuteScalar())
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
                connection.Close()
            End Using



            'Dim reader1 As MySqlDataReader = cmd1.ExecuteReader()
            'While reader1.Read()
            'Console.WriteLine(reader1.GetInt32(0))
            'End While
            'reader1.Close()

            'reader2 = cmd2.ExecuteReader()
            'While reader1.Read()
            '   Console.WriteLine(reader2.GetInt32(0))
            'End While
            'reader2.Close()

            'connection.Close()

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Return returnanswer
    End Function

    Public Sub retriveDataToDataGrid()
        Try
            Dim query As String = "SELECT * FROM employee WHERE un=" + usernameLogin.Text

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

    Public Sub retriveData()
        Try
            Dim query As String = "SELECT * FROM Country"
            Dim connection As New MySqlConnection(connStr)
            Dim cmd As New MySqlCommand(query, connection)

            connection.Open()

            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()

            While reader.Read()
                Console.WriteLine((reader.GetString(0) & ", " & _
                   reader.GetString(2)))
            End While

            reader.Close()
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
        'usernameLogin.Text = ""
        'passwordLogin.Text = ""
        retriveDataToDataGrid()
        retrieveTest()
        TextBox1.Text = queryresultusername
        'blah
        'blah
        'blah
        'blah
        'blah
        'blah
        'blah
        'blah
        'blah
        'blah
        'blah
        'blah
        'blah
        'blah
        'blah
        'blah
        'blah
        'blah
        'blah
        'blah
        'blah
        'blah

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
