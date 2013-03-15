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

    Dim keyboardLastFocus As String = "name"

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
            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(2).Width = 198
            keyboardLastFocus = "name"
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
        errorLabel.Visible = False
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
                    If sizeTextbox.Text = "" Or nameTextbox.Text = "" Then
                        errorLabel.Text = "You need to enter a name AND table size!"
                        errorLabel.Visible = True
                        Exit Try
                    ElseIf IsNumeric(sizeTextbox.Text) = False Then
                        errorLabel.Text = "Table size cannot include letters"
                        errorLabel.Visible = True
                        Exit Try
                    End If
                    connection.Open()
                    Command.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
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
        Dim holdn As String = "" 'this is where the value in column n is stored in the table
        Dim queryN As String = "SELECT n FROM restaurant.tablewaitlist LIMIT " + Convert.ToString(DataGridView1.CurrentCell.RowIndex) + ",1;"
        '^^looks at column n in table and selects the value from the row
        'id of whatever is selected in the datagridview in the application

        Dim queryDropN As String = "ALTER TABLE restaurant.tablewaitlist DROP n;"   'first step in renumbering the column n
        Using connection As New MySqlConnection(connStr)
            Dim getcmd As New MySqlCommand(queryN, connection)
            connection.Open()
            Try
                holdn = Convert.ToString(getcmd.ExecuteScalar())                'puts whatever was found from column n into a local variable
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            Dim queryDelete As String = "DELETE FROM restaurant.tablewaitlist WHERE n=" + holdn + ";"                   'this is deleting the entry that was selected in the datagridview
            Dim delcmd As New MySqlCommand(queryDelete, connection)
            Try
                delcmd.ExecuteNonQuery()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            Dim dropcoln As New MySqlCommand(queryDropN, connection)
            Dim renumbercmd As New MySqlCommand()
            With renumbercmd
                .CommandText = "ALTER TABLE restaurant.tablewaitlist" & vbCrLf & "ADD n INT UNSIGNED NOT NULL AUTO_INCREMENT FIRST," & vbCrLf & "ADD PRIMARY KEY (n);"
                .Connection = connection
                .CommandType = CommandType.Text
            End With
            Try
                dropcoln.ExecuteNonQuery()
                renumbercmd.ExecuteNonQuery()
            Finally
                connection.Close()
                retrieveWaitlistData()
            End Try
        End Using
        sizeTextbox.Text = ""
        nameTextbox.Text = ""
    End Sub

    Private Sub nameTextBox_Focus(sender As Object, e As EventArgs) Handles nameTextbox.Enter
        keyboardLastFocus = "name"
    End Sub
    Private Sub sizeTextBox_Focus(sender As Object, e As EventArgs) Handles sizeTextbox.Enter
        keyboardLastFocus = "size"
    End Sub
    Private Sub oneButton_Click(sender As Object, e As EventArgs) Handles oneButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "1"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "1"
        End If
    End Sub
    Private Sub twoButton_Click(sender As Object, e As EventArgs) Handles twoButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "2"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "2"
        End If
    End Sub
    Private Sub threeButton_Click(sender As Object, e As EventArgs) Handles threeButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "3"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "3"
        End If
    End Sub
    Private Sub fourButton_Click(sender As Object, e As EventArgs) Handles fourButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "4"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "4"
        End If
    End Sub
    Private Sub fiveButton_Click(sender As Object, e As EventArgs) Handles fiveButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "5"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "5"
        End If
    End Sub
    Private Sub sixButton_Click(sender As Object, e As EventArgs) Handles sixButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "6"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "6"
        End If
    End Sub
    Private Sub sevenButton_Click(sender As Object, e As EventArgs) Handles sevenButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "7"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "7"
        End If
    End Sub
    Private Sub eightButton_Click(sender As Object, e As EventArgs) Handles eightButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "8"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "8"
        End If
    End Sub
    Private Sub nineButton_Click(sender As Object, e As EventArgs) Handles nineButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "9"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "9"
        End If
    End Sub
    Private Sub zeroButton_Click(sender As Object, e As EventArgs) Handles zeroButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "0"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "0"
        End If
    End Sub
    Private Sub qButton_Click(sender As Object, e As EventArgs) Handles qButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "Q"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "Q"
        End If
    End Sub
    Private Sub wButton_Click(sender As Object, e As EventArgs) Handles wButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "W"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "W"
        End If
    End Sub
    Private Sub eButton_Click(sender As Object, e As EventArgs) Handles eButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "E"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "E"
        End If
    End Sub
    Private Sub rButton_Click(sender As Object, e As EventArgs) Handles rButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "R"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "R"
        End If
    End Sub
    Private Sub tButton_Click(sender As Object, e As EventArgs) Handles tButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "T"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "T"
        End If
    End Sub
    Private Sub yButton_Click(sender As Object, e As EventArgs) Handles yButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "Y"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "Y"
        End If
    End Sub
    Private Sub uButton_Click(sender As Object, e As EventArgs) Handles uButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "U"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "U"
        End If
    End Sub
    Private Sub iButton_Click(sender As Object, e As EventArgs) Handles iButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "I"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "I"
        End If
    End Sub
    Private Sub oButton_Click(sender As Object, e As EventArgs) Handles oButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "O"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "O"
        End If
    End Sub
    Private Sub pButton_Click(sender As Object, e As EventArgs) Handles pButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "P"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "P"
        End If
    End Sub
    Private Sub aButton_Click(sender As Object, e As EventArgs) Handles aButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "A"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "A"
        End If
    End Sub
    Private Sub sButton_Click(sender As Object, e As EventArgs) Handles sButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "S"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "S"
        End If
    End Sub
    Private Sub dButton_Click(sender As Object, e As EventArgs) Handles dButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "D"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "D"
        End If
    End Sub
    Private Sub fButton_Click(sender As Object, e As EventArgs) Handles fButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "F"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "F"
        End If
    End Sub
    Private Sub gButton_Click(sender As Object, e As EventArgs) Handles gButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "G"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "G"
        End If
    End Sub
    Private Sub hButton_Click(sender As Object, e As EventArgs) Handles hButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "H"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "H"
        End If
    End Sub
    Private Sub jButton_Click(sender As Object, e As EventArgs) Handles jButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "J"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "J"
        End If
    End Sub
    Private Sub kButton_Click(sender As Object, e As EventArgs) Handles kButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "K"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "K"
        End If
    End Sub
    Private Sub lButton_Click(sender As Object, e As EventArgs) Handles lButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "L"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "L"
        End If
    End Sub
    Private Sub zButton_Click(sender As Object, e As EventArgs) Handles zButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "Z"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "Z"
        End If
    End Sub
    Private Sub xButton_Click(sender As Object, e As EventArgs) Handles xButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "X"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "X"
        End If
    End Sub
    Private Sub cButton_Click(sender As Object, e As EventArgs) Handles cButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "C"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "C"
        End If
    End Sub
    Private Sub vButton_Click(sender As Object, e As EventArgs) Handles vButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "V"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "V"
        End If
    End Sub
    Private Sub bButton_Click(sender As Object, e As EventArgs) Handles bButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "B"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "B"
        End If
    End Sub
    Private Sub nButton_Click(sender As Object, e As EventArgs) Handles nButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "N"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "N"
        End If
    End Sub
    Private Sub mButton_Click(sender As Object, e As EventArgs) Handles mButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += "M"
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += "M"
        End If
    End Sub
    Private Sub spaceButton_Click(sender As Object, e As EventArgs) Handles spaceButton.Click
        If keyboardLastFocus = "name" Then
            nameTextbox.Text += " "
        ElseIf keyboardLastFocus = "size" Then
            sizeTextbox.Text += " "
        End If
    End Sub
    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        nameTextbox.Text = ""
        sizeTextbox.Text = ""
    End Sub
    Private Sub deleteKey_Click(sender As Object, e As EventArgs) Handles deleteKey.Click
        If keyboardLastFocus = "name" Then
            If nameTextbox.Text.Length > 0 Then
                nameTextbox.Text = nameTextbox.Text.Remove(nameTextbox.Text.Length - 1, 1)
            End If
        ElseIf keyboardLastFocus = "size" Then
            If sizeTextbox.Text.Length > 0 Then
                sizeTextbox.Text = sizeTextbox.Text.Remove(sizeTextbox.Text.Length - 1, 1)
            End If
        End If
    End Sub
End Class