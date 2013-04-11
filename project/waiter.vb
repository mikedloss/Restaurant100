Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlClient
Imports project.inventory

Public Class waiter

    Public connStr As String

    Dim array() As String
    Dim tableNumber As String
    Dim blah As String

    Public Sub New(ByVal table As String, ByVal connection As String)
        InitializeComponent()
        connStr = connection
        tableNumber = table
        tableNumLabel.Text += table
    End Sub

    Private Sub waiter_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        'blah = inventory.shit.poop
        orderTextBox.Text = blah
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

    Public Sub addToArray(ByVal input As String, ByVal item As String)
        'will add to array and display on screen
        'Dim whatever As String

    End Sub

    Private Sub alcohol1Button_Click(sender As Object, e As EventArgs) Handles alcohol1Button.Click
        Dim text As String
        text = "1 BEER" & vbCrLf
        addToArray(text, 1)
    End Sub
End Class