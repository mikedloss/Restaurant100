Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlClient

Public Class tables

    Dim employeeType As Integer
    '1 = host
    '2 = waiter
    '3 = cook/qa
    '4 = manager
    '5 = the best person in the world

    Dim displayName As String

    Public connStr As String = "Database=restaurant;" & _
                    "Data Source=192.168.1.2;" & _
                    "User Id=root;"

    Public Sub New(ByVal type As Int32, ByVal name As String)
        InitializeComponent()
        employeeType = type
        displayName = name
    End Sub


    Private Sub tables_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        waiter1Label.Text = ""
        waiter2Label.Text = ""
        waiter3Label.Text = ""
        waiter4Label.Text = ""
        bartenderLabel.Text = ""
        waiter1Label.Text = Convert.ToString(displayName)
        retrieveWaitlistData()
    End Sub

    Private Sub table1Button_Click(sender As Object, e As EventArgs) Handles table1Button.Click
        If (employeeType = 2) Then
            Dim tableNum As Integer = 1
            Dim waiterform As New waiter(tableNum)
            waiterform.Show()
        Else
            If (table1Button.BackColor = Color.PaleGreen) Then
                table1Button.BackColor = Color.LightSalmon
            Else
                table1Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub table2Button_Click(sender As Object, e As EventArgs) Handles table2Button.Click
        If (employeeType = 2) Then
            Dim tableNum As Integer = 2
            Dim waiterform As New waiter(tableNum)
            waiterform.Show()
        Else
            If (table2Button.BackColor = Color.PaleGreen) Then
                table2Button.BackColor = Color.LightSalmon
            Else
                table2Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub table3Button_Click(sender As Object, e As EventArgs) Handles table3Button.Click
        If (employeeType = 2) Then
            Dim tableNum As Integer = 3
            Dim waiterform As New waiter(tableNum)

        Else
            If (table3Button.BackColor = Color.PaleGreen) Then
                table3Button.BackColor = Color.LightSalmon
            Else
                table3Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub table4Button_Click(sender As Object, e As EventArgs) Handles table4Button.Click
        If (employeeType = 2) Then
            Dim tableNum As Integer = 4
            Dim waiterform As New waiter(tableNum)
            waiterform.Show()
        Else
            If (table4Button.BackColor = Color.PaleGreen) Then
                table4Button.BackColor = Color.LightSalmon
            Else
                table4Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub table5Button_Click(sender As Object, e As EventArgs) Handles table5Button.Click
        If (employeeType = 2) Then
            Dim tableNum As Integer = 5
            Dim waiterform As New waiter(tableNum)
            waiterform.Show()
        Else
            If (table5Button.BackColor = Color.PaleGreen) Then
                table5Button.BackColor = Color.LightSalmon
            Else
                table5Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub table6Button_Click(sender As Object, e As EventArgs) Handles table6Button.Click
        If (employeeType = 2) Then
            Dim tableNum As Integer = 6
            Dim waiterform As New waiter(tableNum)
            waiterform.Show()
        Else
            If (table6Button.BackColor = Color.PaleGreen) Then
                table6Button.BackColor = Color.LightSalmon
            Else
                table6Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub table7Button_Click(sender As Object, e As EventArgs) Handles table7Button.Click
        If (employeeType = 2) Then
            Dim tableNum As Integer = 7
            Dim waiterform As New waiter(tableNum)
            waiterform.Show()
        Else
            If (table7Button.BackColor = Color.PaleGreen) Then
                table7Button.BackColor = Color.LightSalmon
            Else
                table7Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub table8Button_Click(sender As Object, e As EventArgs) Handles table8Button.Click
        If (employeeType = 2) Then
            Dim tableNum As Integer = 8
            Dim waiterform As New waiter(tableNum)
            waiterform.Show()
        Else
            If (table8Button.BackColor = Color.PaleGreen) Then
                table8Button.BackColor = Color.LightSalmon
            Else
                table8Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub table9Button_Click(sender As Object, e As EventArgs) Handles table9Button.Click
        If (employeeType = 2) Then
            Dim tableNum As Integer = 9
            Dim waiterform As New waiter(tableNum)
            waiterform.Show()
        Else
            If (table9Button.BackColor = Color.PaleGreen) Then
                table9Button.BackColor = Color.LightSalmon
            Else
                table9Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub table10Button_Click(sender As Object, e As EventArgs) Handles table10Button.Click
        If (employeeType = 2) Then
            Dim tableNum As Integer = 10
            Dim waiterform As New waiter(tableNum)
            waiterform.Show()
        Else
            If (table10Button.BackColor = Color.PaleGreen) Then
                table10Button.BackColor = Color.LightSalmon
            Else
                table10Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub table11Button_Click(sender As Object, e As EventArgs) Handles table11Button.Click
        If (employeeType = 2) Then
            Dim tableNum As Integer = 11
            Dim waiterform As New waiter(tableNum)
            waiterform.Show()
        Else
            If (table11Button.BackColor = Color.PaleGreen) Then
                table11Button.BackColor = Color.LightSalmon
            Else
                table11Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub table12Button_Click(sender As Object, e As EventArgs) Handles table12Button.Click
        If (employeeType = 2) Then
            Dim tableNum As Integer = 12
            Dim waiterform As New waiter(tableNum)
            waiterform.Show()
        Else
            If (table12Button.BackColor = Color.PaleGreen) Then
                table12Button.BackColor = Color.LightSalmon
            Else
                table12Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub table13Button_Click(sender As Object, e As EventArgs) Handles table13Button.Click
        If (employeeType = 2) Then
            Dim tableNum As Integer = 13
            Dim waiterform As New waiter(tableNum)
            waiterform.Show()
        Else
            If (table13Button.BackColor = Color.PaleGreen) Then
                table13Button.BackColor = Color.LightSalmon
            Else
                table13Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub table14Button_Click(sender As Object, e As EventArgs) Handles table14Button.Click
        If (employeeType = 2) Then
            Dim tableNum As Integer = 14
            Dim waiterform As New waiter(tableNum)
            waiterform.Show()
        Else
            If (table14Button.BackColor = Color.PaleGreen) Then
                table14Button.BackColor = Color.LightSalmon
            Else
                table14Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub table15Button_Click(sender As Object, e As EventArgs) Handles table15Button.Click
        If (employeeType = 2) Then
            Dim tableNum As Integer = 15
            Dim waiterform As New waiter(tableNum)
            waiterform.Show()
        Else
            If (table15Button.BackColor = Color.PaleGreen) Then
                table15Button.BackColor = Color.LightSalmon
            Else
                table15Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub barSeat1Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat1Button.Click
        If (barSeat1Button.BackColor = Color.PaleGreen) Then
            barSeat1Button.BackColor = Color.LightSalmon
        Else
            barSeat1Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub barSeat2Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat2Button.Click
        If (barSeat2Button.BackColor = Color.PaleGreen) Then
            barSeat2Button.BackColor = Color.LightSalmon
        Else
            barSeat2Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub barSeat3Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat3Button.Click
        If (barSeat3Button.BackColor = Color.PaleGreen) Then
            barSeat3Button.BackColor = Color.LightSalmon
        Else
            barSeat3Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub barSeat4Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat4Button.Click
        If (barSeat4Button.BackColor = Color.PaleGreen) Then
            barSeat4Button.BackColor = Color.LightSalmon
        Else
            barSeat4Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub barSeat5Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat5Button.Click
        If (barSeat5Button.BackColor = Color.PaleGreen) Then
            barSeat5Button.BackColor = Color.LightSalmon
        Else
            barSeat5Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub barSeat6Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat6Button.Click
        If (barSeat6Button.BackColor = Color.PaleGreen) Then
            barSeat6Button.BackColor = Color.LightSalmon
        Else
            barSeat6Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub barSeat7Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat7Button.Click
        If (barSeat7Button.BackColor = Color.PaleGreen) Then
            barSeat7Button.BackColor = Color.LightSalmon
        Else
            barSeat7Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub barSeat8Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat8Button.Click
        If (barSeat8Button.BackColor = Color.PaleGreen) Then
            barSeat8Button.BackColor = Color.LightSalmon
        Else
            barSeat8Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub barSeat9Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat9Button.Click
        If (barSeat9Button.BackColor = Color.PaleGreen) Then
            barSeat9Button.BackColor = Color.LightSalmon
        Else
            barSeat9Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub barSeat10Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat10Button.Click
        If (barSeat10Button.BackColor = Color.PaleGreen) Then
            barSeat10Button.BackColor = Color.LightSalmon
        Else
            barSeat10Button.BackColor = Color.PaleGreen
        End If
    End Sub

    Private Sub logoutButton_Click(sender As System.Object, e As System.EventArgs) Handles logoutButton.Click
        'login.Show()
        Me.Close()
        login.Show()
    End Sub

    Public Sub retrieveWaitlistData()
        Try
            Dim query As String = "SELECT * FROM restaurant.tablewaitlist;"
            Dim connection As New MySqlConnection(connStr)
            Dim da As New MySqlDataAdapter(query, connection)
            Dim ds As New DataSet()

            connection.Open()
            If da.Fill(ds) Then
                DataGridView1.DataSource = ds.Tables(0)
            End If
            connection.Close()
            'DataGridView1.Columns(0).Visible = False
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Public Sub retrieveInfoData()
        Try
            Dim query1 As String = "SELECT * FROM restaurant.schedule;"
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
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
                    connection.Open()
                    Command.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                    'MsgBox ex.Message.ToString
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
        'Dim holdname As String = ""
        'Dim holdsize As String = ""
        Dim maths As Integer = 0
        'Dim queryName As String = "SELECT name FROM restaurant.tablewaitlist LIMIT " + Convert.ToString(DataGridView1.CurrentCell.RowIndex) + ",1;"
        'Dim querySize As String = "SELECT size FROM restaurant.tablewaitlist LIMIT " + Convert.ToString(DataGridView1.CurrentCell.RowIndex) + ",1;"
        ''Dim queryDelete As String = "DELETE FROM restaurant.tablewaitlist WHERE name='" + Convert.ToString(holdname) + "' AND size=" + Convert.ToString(holdsize) + ";"
        maths = DataGridView1.CurrentCell.RowIndex + 1
        sizeTextbox.Text = ""
        Using connection As New MySqlConnection(connStr)
            'Dim cmd As New MySqlCommand(queryName, connection)
            'connection.Open()
            'Try
            'holdname = Convert.ToString(cmd.ExecuteScalar())
            'Catch ex As Exception
            'Console.WriteLine(ex.Message)
            'End Try
            'cmd = New MySqlCommand(querySize, connection)
            'Try
            'holdsize = Convert.ToString(cmd.ExecuteScalar())
            'Catch ex As Exception
            'Console.WriteLine(ex.Message)
            'Finally
            'connection.Close()
            'End Try
            Using deleteCommand As New MySqlCommand()
                With deleteCommand
                    '.CommandText = "DELETE FROM restaurant.tablewaitlist WHERE name=@name AND size=@size;"
                    .CommandText = "DELETE FROM restaurant.tablewaitlist WHERE n=@id;"
                    .Connection = connection
                    .CommandType = CommandType.Text
                    '.Parameters.AddWithValue("@name", Convert.ToString(holdname))
                    '.Parameters.AddWithValue("@size", Convert.ToString(holdsize))
                    .Parameters.AddWithValue("@id", Convert.ToString(maths))
                End With
                Try
                    connection.Open()
                    deleteCommand.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                Finally
                    connection.Close()
                    retrieveWaitlistData()
                End Try
            End Using
        End Using
    End Sub
End Class