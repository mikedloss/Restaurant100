Public Class waiter

    Dim arraySend() As String

    Private Sub waiter_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub clearButton_Click(sender As System.Object, e As System.EventArgs) Handles clearButton.Click
        orderTextBox.Text = ""
    End Sub

    Private Sub submitOrderButton_Click(sender As System.Object, e As System.EventArgs) Handles submitOrderButton.Click
        'send items to queue
    End Sub
End Class