Imports MySql.Data.MySqlClient

Public Class login

    Dim connStr As String = "Database=test;" & _
                    "Data Source=192.168.1.10:3306;" & _
                    "User Id=mike;Password=root"

    Private Sub login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TestConnection()
        retriveData()


        'date/time display
        timeLoginLabel.Text = String.Format("{0:hh:mm:ss tt}", Date.Now)
        dateLoginLabel.Text = Now.Date

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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub timer_Tick(sender As System.Object, e As System.EventArgs) Handles timer.Tick
        'every tick updates time
        timeLoginLabel.Text = String.Format("{0:hh:mm:ss tt}", Date.Now)

    End Sub

    Private Sub loginSubmitButton_Click(sender As System.Object, e As System.EventArgs) Handles loginSubmitButton.Click

        If (usernameLogin.Text.Length < 4 Or passwordLogin.Text.Length < 4) Then
            errorLabel.Text = ""
            errorLabel.Text = "ERROR: WRONG ID/PW"
            errorLabel.Visible = True
            usernameLogin.Text = ""
            passwordLogin.Text = ""
        Else
            'check mysql to see if user is in db
            tables.Show()
            Me.Hide()
            usernameLogin.Text = ""
            passwordLogin.Text = ""
            errorLabel.Text = ""
            errorLabel.Visible = False
        End If

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
                   reader.GetString(1)))
            End While

            reader.Close()
            connection.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub login1KeyButton_Click(sender As System.Object, e As System.EventArgs) Handles login1KeyButton.Click
        If passwordLogin.Text.Length = 4 Then
            loginSubmitButton.Focus()
        ElseIf usernameLogin.Text.Length = 4 Then
            passwordLogin.Text += "1"
            errorLabel.Visible = False
        ElseIf usernameLogin.Text.Length <> 4 Then
            usernameLogin.Text += "1"
        End If
    End Sub

    Private Sub login2KeyButton_Click(sender As System.Object, e As System.EventArgs) Handles login2KeyButton.Click
        If passwordLogin.Text.Length = 4 Then
            loginSubmitButton.Focus()
        ElseIf usernameLogin.Text.Length = 4 Then
            passwordLogin.Text += "2"
            errorLabel.Visible = False
        ElseIf usernameLogin.Text.Length <> 4 Then
            usernameLogin.Text += "2"
        End If
    End Sub

    Private Sub login3KeyButton_Click(sender As System.Object, e As System.EventArgs) Handles login3KeyButton.Click
        If passwordLogin.Text.Length = 4 Then
            loginSubmitButton.Focus()
        ElseIf usernameLogin.Text.Length = 4 Then
            passwordLogin.Text += "3"
            errorLabel.Visible = False
        ElseIf usernameLogin.Text.Length <> 4 Then
            usernameLogin.Text += "3"
        End If
    End Sub

    Private Sub login4KeyButton_Click(sender As System.Object, e As System.EventArgs) Handles login4KeyButton.Click
        If passwordLogin.Text.Length = 4 Then
            loginSubmitButton.Focus()
        ElseIf usernameLogin.Text.Length = 4 Then
            passwordLogin.Text += "4"
            errorLabel.Visible = False
        ElseIf usernameLogin.Text.Length <> 4 Then
            usernameLogin.Text += "4"
        End If
    End Sub

    Private Sub login5KeyButton_Click(sender As System.Object, e As System.EventArgs) Handles login5KeyButton.Click
        If passwordLogin.Text.Length = 4 Then
            loginSubmitButton.Focus()
        ElseIf usernameLogin.Text.Length = 4 Then
            passwordLogin.Text += "5"
            errorLabel.Visible = False
        ElseIf usernameLogin.Text.Length <> 4 Then
            usernameLogin.Text += "5"
        End If
    End Sub

    Private Sub login6KeyButton_Click(sender As System.Object, e As System.EventArgs) Handles login6KeyButton.Click
        If passwordLogin.Text.Length = 4 Then
            loginSubmitButton.Focus()
        ElseIf usernameLogin.Text.Length = 4 Then
            passwordLogin.Text += "6"
            errorLabel.Visible = False
        ElseIf usernameLogin.Text.Length <> 4 Then
            usernameLogin.Text += "6"
        End If
    End Sub

    Private Sub login7KeyButton_Click(sender As System.Object, e As System.EventArgs) Handles login7KeyButton.Click
        If passwordLogin.Text.Length = 4 Then
            loginSubmitButton.Focus()
        ElseIf usernameLogin.Text.Length = 4 Then
            passwordLogin.Text += "7"
            errorLabel.Visible = False
        ElseIf usernameLogin.Text.Length <> 4 Then
            usernameLogin.Text += "7"
        End If
    End Sub

    Private Sub login8KeyButton_Click(sender As System.Object, e As System.EventArgs) Handles login8KeyButton.Click
        If passwordLogin.Text.Length = 4 Then
            loginSubmitButton.Focus()
        ElseIf usernameLogin.Text.Length = 4 Then
            passwordLogin.Text += "8"
            errorLabel.Visible = False
        ElseIf usernameLogin.Text.Length <> 4 Then
            usernameLogin.Text += "8"
        End If
    End Sub

    Private Sub login9KeyButton_Click(sender As System.Object, e As System.EventArgs) Handles login9KeyButton.Click
        If passwordLogin.Text.Length = 4 Then
            loginSubmitButton.Focus()
        ElseIf usernameLogin.Text.Length = 4 Then
            passwordLogin.Text += "9"
            errorLabel.Visible = False
        ElseIf usernameLogin.Text.Length <> 4 Then
            usernameLogin.Text += "9"
        End If
    End Sub

    Private Sub login0KeyButton_Click(sender As System.Object, e As System.EventArgs) Handles login0KeyButton.Click
        If passwordLogin.Text.Length = 4 Then
            loginSubmitButton.Focus()
        ElseIf usernameLogin.Text.Length = 4 Then
            passwordLogin.Text += "0"
            errorLabel.Visible = False
        ElseIf usernameLogin.Text.Length <> 4 Then
            usernameLogin.Text += "0"
        End If
    End Sub

    Private Sub loginClearButton_Click(sender As System.Object, e As System.EventArgs) Handles loginClearButton.Click
        usernameLogin.Text = ""
        passwordLogin.Text = ""
    End Sub
End Class
