Public Class login

    Private Sub login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'date/time display
        timeLoginLabel.Text = String.Format("{0:hh:mm:ss tt}", Date.Now)
        dateLoginLabel.Text = Now.Date

        'forces fullscreen
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub timer_Tick(sender As System.Object, e As System.EventArgs) Handles timer.Tick
        'every tick updates time
        timeLoginLabel.Text = String.Format("{0:hh:mm:ss tt}", Date.Now)

    End Sub

    Private Sub loginSubmitButton_Click(sender As System.Object, e As System.EventArgs) Handles loginSubmitButton.Click
        'send data to server and check return values here

        'If usernameLogin.Text = "1234" Then
        'If passwordLogin.Text = "4321" Then


        'connects login form to tables form
        tables.Show()
        Me.Hide()
        'End If
        'End If

    End Sub

    Private Sub login1KeyButton_Click(sender As System.Object, e As System.EventArgs) Handles login1KeyButton.Click
        If usernameLogin.Text.Length < 4 Then
            usernameLogin.Text += "1"
            If usernameLogin.Text.Length = 4 Then
                passwordLogin.Focus()
            End If
        End If



    End Sub

    Private Sub login2KeyButton_Click(sender As System.Object, e As System.EventArgs) Handles login2KeyButton.Click

    End Sub

    Private Sub login3KeyButton_Click(sender As System.Object, e As System.EventArgs) Handles login3KeyButton.Click

    End Sub

    Private Sub login4KeyButton_Click(sender As System.Object, e As System.EventArgs) Handles login4KeyButton.Click

    End Sub

    Private Sub login5KeyButton_Click(sender As System.Object, e As System.EventArgs) Handles login5KeyButton.Click

    End Sub

    Private Sub login6KeyButton_Click(sender As System.Object, e As System.EventArgs) Handles login6KeyButton.Click

    End Sub

    Private Sub login7KeyButton_Click(sender As System.Object, e As System.EventArgs) Handles login7KeyButton.Click

    End Sub

    Private Sub login8KeyButton_Click(sender As System.Object, e As System.EventArgs) Handles login8KeyButton.Click

    End Sub

    Private Sub login9KeyButton_Click(sender As System.Object, e As System.EventArgs) Handles login9KeyButton.Click

    End Sub

    Private Sub login0KeyButton_Click(sender As System.Object, e As System.EventArgs) Handles login0KeyButton.Click

    End Sub

    Private Sub loginClearButton_Click(sender As System.Object, e As System.EventArgs) Handles loginClearButton.Click
        usernameLogin.Text = ""
        passwordLogin.Text = ""
    End Sub
End Class
