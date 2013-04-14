Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlClient
Imports Restaurant100.inventory

Public Class waiter

    Public connStr As String

    Dim check() As String
    Dim tableNumber As String
    Dim checkTotal As Integer

    Public Sub New(ByVal table As String, ByVal connection As String)
        InitializeComponent()
        connStr = connection
        tableNumber = table
        tableNumLabel.Text += table
    End Sub

    Private Sub waiter_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        getTableTotal()
    End Sub

    Private Sub clearButton_Click(sender As System.Object, e As System.EventArgs) Handles clearButton.Click
        orderTextBox.Text = ""
    End Sub

    Private Sub submitOrderButton_Click(sender As System.Object, e As System.EventArgs) Handles submitOrderButton.Click

        'this is where code would go to send the order to the machine
        'that prints tickets

        Me.Close()

    End Sub

    Public Sub displayCheck(ByVal text As String, ByVal itemOrder As String)
        'will add to array and display on screen


    End Sub

    Private Sub getTableTotal()
        Dim queryTT As String = "SELECT total FROM restaurant.tablechecks WHERE tablenum='" + tableNumber + "';"
        'need to get check as well

        Using connection As New MySqlConnection(connStr)
            Dim command As New MySqlCommand(queryTT, connection)
            Try
                connection.Open()
                checkTotal = command.ExecuteScalar()
                connection.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Using

        totalTextBox.Text = FormatCurrency(checkTotal, , , , )
    End Sub

    '------------food buttons
    'item order: 1 = alcohol, 2 = drinks, 3 = appetizers, 4 = entrees, 5 = desserts
    Private Sub alcohol1Button_Click(sender As Object, e As EventArgs) Handles alcohol1Button.Click
        Dim text As String = inventory.alcohol1s + vbCrLf
        Dim price As Integer = inventory.alcohol1.price
        Dim itemNames() As String
        Dim itemValues As Array
        itemNames = System.Enum.GetNames(GetType(alcohol1))
        itemValues = System.Enum.GetValues(GetType(alcohol1))

        checkTotal += price
        totalTextBox.Text = FormatCurrency(checkTotal, , , , )

        Dim query As String = "UPDATE restaurant.tablechecks SET items='" + text + "', total='" + Convert.ToString(checkTotal) + "' WHERE tablenum='" + tableNumber + "';"
        Using connection As New MySqlConnection(connStr)
            Dim command As New MySqlCommand(query, connection)
            Try
                connection.Open()
                connection.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Using

        displayCheck(text, 1)

    End Sub
    Private Sub drink1Button_Click(sender As Object, e As EventArgs) Handles drink1Button.Click
        Dim text As String = inventory.drink1s
    End Sub
    Private Sub drink2Button_Click(sender As Object, e As EventArgs) Handles drink2Button.Click
        Dim text As String = inventory.drink2s
    End Sub
    Private Sub drink3Button_Click(sender As Object, e As EventArgs) Handles drink3Button.Click
        Dim text As String = inventory.drink2s
    End Sub
    Private Sub drink4Button_Click(sender As Object, e As EventArgs) Handles drink4Button.Click
        Dim text As String = inventory.drink1s
    End Sub
    Private Sub app1Button_Click(sender As Object, e As EventArgs) Handles app1Button.Click
        Dim text As String = inventory.drink1s
    End Sub
    Private Sub app2Button_Click(sender As Object, e As EventArgs) Handles app2Button.Click
        Dim text As String = inventory.drink1s
    End Sub
    Private Sub app3Button_Click(sender As Object, e As EventArgs) Handles app3Button.Click
        Dim text As String = inventory.drink1s
    End Sub
    Private Sub entree1Button_Click(sender As Object, e As EventArgs) Handles entree1Button.Click
        Dim text As String = inventory.entree1s
    End Sub
    Private Sub entree2Button_Click(sender As Object, e As EventArgs) Handles entree2Button.Click
        Dim text As String = inventory.entree2s
    End Sub
    Private Sub entree3Button_Click(sender As Object, e As EventArgs) Handles entree3Button.Click
        Dim text As String = inventory.entree3s
    End Sub
    Private Sub dessert1Button_Click(sender As Object, e As EventArgs) Handles dessert1Button.Click
        Dim text As String = inventory.dessert1s
    End Sub

    '------------modifier buttons
    Private Sub modifier86Button_Click(sender As Object, e As EventArgs) Handles modifier86Button.Click
        tabControlWaiter.Visible = False
    End Sub

    Private Sub onsideModifierButton_Click(sender As Object, e As EventArgs) Handles onsideModifierButton.Click

    End Sub

    Private Sub sideofModifierButton_Click(sender As Object, e As EventArgs) Handles sideofModifierButton.Click

    End Sub

    Private Sub extraModifierButton_Click(sender As Object, e As EventArgs) Handles extraModifierButton.Click

    End Sub
End Class