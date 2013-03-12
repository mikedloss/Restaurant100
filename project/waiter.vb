Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlClient

Public Class waiter

    Dim arraySend() As String
    Dim tableNumber As Integer

    Private Sub waiter_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Public Sub New(ByVal table As Integer)
        InitializeComponent()
        tableNumber = table

    End Sub

    Private Sub clearButton_Click(sender As System.Object, e As System.EventArgs) Handles clearButton.Click
        orderTextBox.Text = ""
    End Sub

    Private Sub submitOrderButton_Click(sender As System.Object, e As System.EventArgs) Handles submitOrderButton.Click
        'send items to queue
        Me.Close()

    End Sub

    Private Sub modifier86Button_Click(sender As Object, e As EventArgs) Handles modifier86Button.Click
        tabControlWaiter.Visible = False
    End Sub
End Class