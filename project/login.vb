Public Class login

    Private Sub login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        timeLoginStatusStrip.Text = String.Format("{0:hh:mm:ss tt}", Date.Now)
        dateLoginStatusStrip.Text = Now.Date
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized



    End Sub

    Private Sub timer_Tick(sender As System.Object, e As System.EventArgs) Handles timer.Tick
        timeLoginStatusStrip.Text = String.Format("{0:hh:mm:ss tt}", Date.Now)
    End Sub

    Private Sub loginSubmitButton_Click(sender As System.Object, e As System.EventArgs) Handles loginSubmitButton.Click
        tables.Show()
        Me.Hide()
    End Sub
End Class
