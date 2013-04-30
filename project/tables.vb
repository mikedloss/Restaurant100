Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlClient

Public Class tables

    Dim employeeType As Integer
    '1 = host
    '2 = waiter
    '3 = cook/qa
    '4 = manager
    '5 = bartender??

    Dim displayName As String
    Public connStr As String
    Dim unID As String
    Dim tablenum(0 To 24) As String
    Dim dbRowCount As String
    Dim count As String

    Dim keyboardLastFocus As String = "name"

    Public Sub New(ByVal type As Int32, ByVal name As String, ByVal connection As String, ByVal id As String)
        InitializeComponent()
        connStr = connection
        employeeType = type
        displayName = name
        unID = id
    End Sub

    Private Sub tables_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        fillWaiterLabel()   'waiter list on side

        If employeeType = 2 Then
            'putting waitlist on front tab and eliminating the keyboard and waitlist tab
            waiterModifications()
        End If
        If employeeType = 1 Then
            retrieveWaitlistData()
        End If
        retrieveOccupancyData()
        retrieveNote()

        welcomeLabel.Text = "Welcome, " + displayName + "!"
        timeLabel.Text = String.Format("{0:hh:mm:ss tt}", Date.Now)
        dateLabel.Text = Now.Date

        'making datagridview unsortable for all columns
        Dim colnum As Integer = DataGridView1.ColumnCount
        Dim i As Integer
        For i = 0 To (colnum - 1)
            DataGridView1.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    Private Sub timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer.Tick
        'every tick updates time
        timeLabel.Text = String.Format("{0:hh:mm:ss tt}", Date.Now)
        count += 1
        If count = 10 Then
            retrieveOccupancyData()
            retrieveWaitlistData()
            count = 0
        End If
    End Sub

    '---------------------table buttons, look at table1 for comments
    Private Sub table1Button_Click(sender As Object, e As EventArgs) Handles table1Button.Click
        Dim tableNum As Integer = 1
        'if employee is a waiter, then bring up waiter form
        'else, continue w/ host stuff
        If (employeeType = 2) Then
            If checkFlag(1) = True Then
                Dim waiterform As New waiter(tableNum, connStr)
                waiterform.Show()
            Else
                MsgBox("you can't do that ;)")
            End If
        Else
            'update db if host to reflect changes
            Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
            Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

            If (table1Button.BackColor = Color.PaleGreen) Then
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryY, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                table1Button.BackColor = Color.LightSalmon
            Else
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryN, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                table1Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub table2Button_Click(sender As Object, e As EventArgs) Handles table2Button.Click
        Dim tableNum As Integer = 2
        If (employeeType = 2) Then
            If checkFlag(2) = True Then
                Dim waiterform As New waiter(tableNum, connStr)
                waiterform.Show()
            Else
                MsgBox("you can't do that ;)")
            End If
        Else
            Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
            Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

            If (table2Button.BackColor = Color.PaleGreen) Then
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryY, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                table2Button.BackColor = Color.LightSalmon
            Else
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryN, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                table2Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub table3Button_Click(sender As Object, e As EventArgs) Handles table3Button.Click
        Dim tableNum As Integer = 3
        If (employeeType = 2) Then
            If checkFlag(3) = True Then
                Dim waiterform As New waiter(tableNum, connStr)
                waiterform.Show()
            Else
                MsgBox("you can't do that ;)")
            End If
        Else
            Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
            Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

            If (table3Button.BackColor = Color.PaleGreen) Then
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryY, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                table3Button.BackColor = Color.LightSalmon
            Else
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryN, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                table3Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub table4Button_Click(sender As Object, e As EventArgs) Handles table4Button.Click
        Dim tableNum As Integer = 4
        If (employeeType = 2) Then
            If checkFlag(4) = True Then
                Dim waiterform As New waiter(tableNum, connStr)
                waiterform.Show()
            Else
                MsgBox("you can't do that ;)")
            End If
        Else
            Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
            Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

            If (table4Button.BackColor = Color.PaleGreen) Then
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryY, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                table4Button.BackColor = Color.LightSalmon
            Else
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryN, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                table4Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub table5Button_Click(sender As Object, e As EventArgs) Handles table5Button.Click
        Dim tableNum As Integer = 5
        If (employeeType = 2) Then
            If checkFlag(5) = True Then
                Dim waiterform As New waiter(tableNum, connStr)
                waiterform.Show()
            Else
                MsgBox("you can't do that ;)")
            End If
        Else
            Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
            Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

            If (table5Button.BackColor = Color.PaleGreen) Then
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryY, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                table5Button.BackColor = Color.LightSalmon
            Else
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryN, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                table5Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub table6Button_Click(sender As Object, e As EventArgs) Handles table6Button.Click
        Dim tableNum As Integer = 6
        If (employeeType = 2) Then
            If checkFlag(6) = True Then
                Dim waiterform As New waiter(tableNum, connStr)
                waiterform.Show()
            Else
                MsgBox("you can't do that ;)")
            End If
        Else
            Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
            Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

            If (table6Button.BackColor = Color.PaleGreen) Then
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryY, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                table6Button.BackColor = Color.LightSalmon
            Else
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryN, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                table6Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub table7Button_Click(sender As Object, e As EventArgs) Handles table7Button.Click
        Dim tableNum As Integer = 7
        If (employeeType = 2) Then
            If checkFlag(7) = True Then
                Dim waiterform As New waiter(tableNum, connStr)
                waiterform.Show()
            Else
                MsgBox("you can't do that ;)")
            End If
        Else
            Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
            Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

            If (table7Button.BackColor = Color.PaleGreen) Then
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryY, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                table7Button.BackColor = Color.LightSalmon
            Else
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryN, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                table7Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub table8Button_Click(sender As Object, e As EventArgs) Handles table8Button.Click
        Dim tableNum As Integer = 8
        If (employeeType = 2) Then
            If checkFlag(8) = True Then
                Dim waiterform As New waiter(tableNum, connStr)
                waiterform.Show()
            Else
                MsgBox("you can't do that ;)")
            End If
        Else
            Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
            Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

            If (table8Button.BackColor = Color.PaleGreen) Then
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryY, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                table8Button.BackColor = Color.LightSalmon
            Else
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryN, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                table8Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub table9Button_Click(sender As Object, e As EventArgs) Handles table9Button.Click
        Dim tableNum As Integer = 9
        If (employeeType = 2) Then
            If checkFlag(9) = True Then
                Dim waiterform As New waiter(tableNum, connStr)
                waiterform.Show()
            Else
                MsgBox("you can't do that ;)")
            End If
        Else
            Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
            Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

            If (table9Button.BackColor = Color.PaleGreen) Then
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryY, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                table9Button.BackColor = Color.LightSalmon
            Else
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryN, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                table9Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub table10Button_Click(sender As Object, e As EventArgs) Handles table10Button.Click
        Dim tableNum As Integer = 10
        If (employeeType = 2) Then
            If checkFlag(10) = True Then
                Dim waiterform As New waiter(tableNum, connStr)
                waiterform.Show()
            Else
                MsgBox("you can't do that ;)")
            End If
        Else
            Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
            Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

            If (table10Button.BackColor = Color.PaleGreen) Then
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryY, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                table10Button.BackColor = Color.LightSalmon
            Else
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryN, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                table10Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub table11Button_Click(sender As Object, e As EventArgs) Handles table11Button.Click
        Dim tableNum As Integer = 11
        If (employeeType = 2) Then
            If checkFlag(11) = True Then
                Dim waiterform As New waiter(tableNum, connStr)
                waiterform.Show()
            Else
                MsgBox("you can't do that ;)")
            End If
        Else
            Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
            Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

            If (table11Button.BackColor = Color.PaleGreen) Then
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryY, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                table11Button.BackColor = Color.LightSalmon
            Else
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryN, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                table11Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub table12Button_Click(sender As Object, e As EventArgs) Handles table12Button.Click
        Dim tableNum As Integer = 12
        If (employeeType = 2) Then
            If checkFlag(12) = True Then
                Dim waiterform As New waiter(tableNum, connStr)
                waiterform.Show()
            Else
                MsgBox("you can't do that ;)")
            End If
        Else
            Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
            Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

            If (table12Button.BackColor = Color.PaleGreen) Then
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryY, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                table12Button.BackColor = Color.LightSalmon
            Else
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryN, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                table12Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub table13Button_Click(sender As Object, e As EventArgs) Handles table13Button.Click
        Dim tableNum As Integer = 13
        If (employeeType = 2) Then
            If checkFlag(13) = True Then
                Dim waiterform As New waiter(tableNum, connStr)
                waiterform.Show()
            Else
                MsgBox("you can't do that ;)")
            End If
        Else
            Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
            Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

            If (table13Button.BackColor = Color.PaleGreen) Then
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryY, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                table13Button.BackColor = Color.LightSalmon
            Else
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryN, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                table13Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub table14Button_Click(sender As Object, e As EventArgs) Handles table14Button.Click
        Dim tableNum As Integer = 14
        If (employeeType = 2) Then
            If checkFlag(14) = True Then
                Dim waiterform As New waiter(tableNum, connStr)
                waiterform.Show()
            Else
                MsgBox("you can't do that ;)")
            End If
        Else
            Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
            Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

            If (table14Button.BackColor = Color.PaleGreen) Then
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryY, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                table14Button.BackColor = Color.LightSalmon
            Else
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryN, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                table14Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub table15Button_Click(sender As Object, e As EventArgs) Handles table15Button.Click
        Dim tableNum As Integer = 15
        If (employeeType = 2) Then
            If checkFlag(15) = True Then
                Dim waiterform As New waiter(tableNum, connStr)
                waiterform.Show()
            Else
                MsgBox("you can't do that ;)")
            End If
        Else
            Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
            Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

            If (table15Button.BackColor = Color.PaleGreen) Then
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryY, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                table15Button.BackColor = Color.LightSalmon
            Else
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryN, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                table15Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub barSeat1Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat1Button.Click
        Dim tableNum As Integer = 16
        If (employeeType = 2) Then
            If checkFlag(16) = True Then
                Dim waiterform As New waiter(tableNum, connStr)
                waiterform.Show()
            Else
                MsgBox("you can't do that ;)")
            End If
        Else
            Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
            Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

            If (barSeat1Button.BackColor = Color.PaleGreen) Then
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryY, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                barSeat1Button.BackColor = Color.LightSalmon
            Else
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryN, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                barSeat1Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub barSeat2Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat2Button.Click
        Dim tableNum As Integer = 17
        If (employeeType = 2) Then
            If checkFlag(17) = True Then
                Dim waiterform As New waiter(tableNum, connStr)
                waiterform.Show()
            Else
                MsgBox("you can't do that ;)")
            End If
        Else
            Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
            Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

            If (barSeat2Button.BackColor = Color.PaleGreen) Then
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryY, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                barSeat2Button.BackColor = Color.LightSalmon
            Else
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryN, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                barSeat2Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub barSeat3Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat3Button.Click
        Dim tableNum As Integer = 18
        If (employeeType = 2) Then
            If checkFlag(18) = True Then
                Dim waiterform As New waiter(tableNum, connStr)
                waiterform.Show()
            Else
                MsgBox("you can't do that ;)")
            End If
        Else
            Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
            Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

            If (barSeat3Button.BackColor = Color.PaleGreen) Then
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryY, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                barSeat3Button.BackColor = Color.LightSalmon
            Else
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryN, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                barSeat3Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub barSeat4Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat4Button.Click
        Dim tableNum As Integer = 19
        If (employeeType = 2) Then
            If checkFlag(19) = True Then
                Dim waiterform As New waiter(tableNum, connStr)
                waiterform.Show()
            Else
                MsgBox("you can't do that ;)")
            End If
        Else
            Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
            Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

            If (barSeat4Button.BackColor = Color.PaleGreen) Then
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryY, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                barSeat4Button.BackColor = Color.LightSalmon
            Else
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryN, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                barSeat4Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub barSeat5Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat5Button.Click
        Dim tableNum As Integer = 20
        If (employeeType = 2) Then
            If checkFlag(20) = True Then
                Dim waiterform As New waiter(tableNum, connStr)
                waiterform.Show()
            Else
                MsgBox("you can't do that ;)")
            End If
        Else
            Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
            Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

            If (barSeat5Button.BackColor = Color.PaleGreen) Then
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryY, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                barSeat5Button.BackColor = Color.LightSalmon
            Else
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryN, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                barSeat5Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub barSeat6Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat6Button.Click
        Dim tableNum As Integer = 21
        If (employeeType = 2) Then
            If checkFlag(21) = True Then
                Dim waiterform As New waiter(tableNum, connStr)
                waiterform.Show()
            Else
                MsgBox("you can't do that ;)")
            End If
        Else
            Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
            Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

            If (barSeat6Button.BackColor = Color.PaleGreen) Then
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryY, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                barSeat6Button.BackColor = Color.LightSalmon
            Else
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryN, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                barSeat6Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub barSeat7Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat7Button.Click
        Dim tableNum As Integer = 22
        If (employeeType = 2) Then
            If checkFlag(22) = True Then
                Dim waiterform As New waiter(tableNum, connStr)
                waiterform.Show()
            Else
                MsgBox("you can't do that ;)")
            End If
        Else
            Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
            Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

            If (barSeat7Button.BackColor = Color.PaleGreen) Then
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryY, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                barSeat7Button.BackColor = Color.LightSalmon
            Else
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryN, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                barSeat7Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub barSeat8Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat8Button.Click
        Dim tableNum As Integer = 23
        If (employeeType = 2) Then
            If checkFlag(23) = True Then
                Dim waiterform As New waiter(tableNum, connStr)
                waiterform.Show()
            Else
                MsgBox("you can't do that ;)")
            End If
        Else
            Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
            Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

            If (barSeat8Button.BackColor = Color.PaleGreen) Then
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryY, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                barSeat8Button.BackColor = Color.LightSalmon
            Else
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryN, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                barSeat8Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub barSeat9Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat9Button.Click
        Dim tableNum As Integer = 24
        If (employeeType = 2) Then
            If checkFlag(24) = True Then
                Dim waiterform As New waiter(tableNum, connStr)
                waiterform.Show()
            Else
                MsgBox("you can't do that ;)")
            End If
        Else
            Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
            Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

            If (barSeat9Button.BackColor = Color.PaleGreen) Then
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryY, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                barSeat9Button.BackColor = Color.LightSalmon
            Else
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryN, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                barSeat9Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub
    Private Sub barSeat10Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat10Button.Click
        Dim tableNum As Integer = 25
        If (employeeType = 2) Then
            If checkFlag(25) = True Then
                Dim waiterform As New waiter(tableNum, connStr)
                waiterform.Show()
            Else
                MsgBox("you can't do that ;)")
            End If
        Else
            Dim queryY As String = "UPDATE restaurant.tableoccupancy SET `occupied`='y' WHERE `n`='" + Convert.ToString(tableNum) + "';"
            Dim queryN As String = "UPDATE restaurant.tableoccupancy SET `occupied`='n' WHERE `n`='" + Convert.ToString(tableNum) + "';"

            If (barSeat10Button.BackColor = Color.PaleGreen) Then
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryY, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                barSeat10Button.BackColor = Color.LightSalmon
            Else
                Using connection As New MySqlConnection(connStr)
                    Dim command As New MySqlCommand(queryN, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
                barSeat10Button.BackColor = Color.PaleGreen
            End If
        End If
    End Sub

    Private Sub logoutButton_Click(sender As System.Object, e As System.EventArgs) Handles logoutButton.Click
        login.Update()
        Me.Close()
        login.Show()
    End Sub

    Private Sub clockOutButton_Click_1(sender As Object, e As EventArgs) Handles clockOutButton.Click
        'update db to reflect if user is logged in or not
        Dim query As String = "UPDATE restaurant.employeeinfo SET `isLoggedIn`='n' WHERE `un`='" + unID + "';"
        Dim connection As New MySqlConnection(connStr)
        Dim command As New MySqlCommand(query, connection)
        Try
            connection.Open()
            command.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            connection.Close()
        End Try

        'sending clock out time to db
        login.timeLogout = Date.Parse(Date.Now)
        login.sendTime(unID)

        login.Update()
        Me.Close()
        login.Show()
    End Sub

    Public Sub waiterModifications()
        DataGridView2.Visible = True
        waitlistLabelW.Visible = True
        'nameLabelW.Visible = True
        'tableLabelW.Visible = True
        TabControl1.TabPages.Remove(waitlistTab)
        Try
            Dim query As String = "SELECT * FROM restaurant.tablewaitlist;"
            Dim connection As New MySqlConnection(connStr)
            Dim da As New MySqlDataAdapter(query, connection)
            Dim ds As New DataSet()

            connection.Open()
            If da.Fill(ds) Then
                DataGridView2.DataSource = ds.Tables(0)
            End If
            connection.Close()
            DataGridView2.Columns(0).Visible = False
            DataGridView2.Columns(1).Width = 190
            DataGridView2.Columns(2).Width = 188
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Dim colnum As Integer = DataGridView2.ColumnCount
        Dim i As Integer
        For i = 0 To (colnum - 1)
            DataGridView2.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    Public Function checkFlag(ByVal table As Integer)
        Dim flag As Boolean = False
        Dim numberInArray As Integer = table - 1
        If numberInArray < 0 Then
            Return False
        ElseIf Me.tablenum(numberInArray) = "y" Then
            flag = True
        End If
        Return flag
    End Function

    Public Sub retrieveOccupancyData()
        Dim i As Integer = 1
        Dim j As Integer = 0
        Dim istring As String = Convert.ToString(i)
        Dim query As String = "SELECT occupied FROM restaurant.tableoccupancy WHERE n=" + istring + ";"

        Using connection As New MySqlConnection(connStr)
            Dim command As New MySqlCommand(query, connection)
            Try
                connection.Open()
                Do While (i <= 25)
                    command.CommandText = "SELECT occupied FROM restaurant.tableoccupancy WHERE n=" + istring + ";"
                    Me.tablenum(j) = Convert.ToString(command.ExecuteScalar())
                    i += 1
                    j += 1
                    istring = Convert.ToString(i)
                Loop
                connection.Close()
            Catch ex As Exception
                Console.Write(ex.Message)
            End Try
        End Using

        i = 0
        j = 0
        Do While (i <= 24)
            If i = 0 Then
                If tablenum(i) = "n" Then
                    table1Button.BackColor = Color.PaleGreen
                Else
                    table1Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 1 Then
                If tablenum(i) = "n" Then
                    table2Button.BackColor = Color.PaleGreen
                Else
                    table2Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 2 Then
                If tablenum(i) = "n" Then
                    table3Button.BackColor = Color.PaleGreen
                Else
                    table3Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 3 Then
                If tablenum(i) = "n" Then
                    table4Button.BackColor = Color.PaleGreen
                Else
                    table4Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 4 Then
                If tablenum(i) = "n" Then
                    table5Button.BackColor = Color.PaleGreen
                Else
                    table5Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 5 Then
                If tablenum(i) = "n" Then
                    table6Button.BackColor = Color.PaleGreen
                Else
                    table6Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 6 Then
                If tablenum(i) = "n" Then
                    table7Button.BackColor = Color.PaleGreen
                Else
                    table7Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 7 Then
                If tablenum(i) = "n" Then
                    table8Button.BackColor = Color.PaleGreen
                Else
                    table8Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 8 Then
                If tablenum(i) = "n" Then
                    table9Button.BackColor = Color.PaleGreen
                Else
                    table9Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 9 Then
                If tablenum(i) = "n" Then
                    table10Button.BackColor = Color.PaleGreen
                Else
                    table10Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 10 Then
                If tablenum(i) = "n" Then
                    table11Button.BackColor = Color.PaleGreen
                Else
                    table11Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 11 Then
                If tablenum(i) = "n" Then
                    table12Button.BackColor = Color.PaleGreen
                Else
                    table12Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 12 Then
                If tablenum(i) = "n" Then
                    table13Button.BackColor = Color.PaleGreen
                Else
                    table13Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 13 Then
                If tablenum(i) = "n" Then
                    table14Button.BackColor = Color.PaleGreen
                Else
                    table14Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 14 Then
                If tablenum(i) = "n" Then
                    table15Button.BackColor = Color.PaleGreen
                Else
                    table15Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 15 Then
                If tablenum(i) = "n" Then
                    barSeat1Button.BackColor = Color.PaleGreen
                Else
                    barSeat1Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 16 Then
                If tablenum(i) = "n" Then
                    barSeat2Button.BackColor = Color.PaleGreen
                Else
                    barSeat2Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 17 Then
                If tablenum(i) = "n" Then
                    barSeat3Button.BackColor = Color.PaleGreen
                Else
                    barSeat3Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 18 Then
                If tablenum(i) = "n" Then
                    barSeat4Button.BackColor = Color.PaleGreen
                Else
                    barSeat4Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 19 Then
                If tablenum(i) = "n" Then
                    barSeat5Button.BackColor = Color.PaleGreen
                Else
                    barSeat5Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 20 Then
                If tablenum(i) = "n" Then
                    barSeat6Button.BackColor = Color.PaleGreen
                Else
                    barSeat6Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 21 Then
                If tablenum(i) = "n" Then
                    barSeat7Button.BackColor = Color.PaleGreen
                Else
                    barSeat7Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 22 Then
                If tablenum(i) = "n" Then
                    barSeat8Button.BackColor = Color.PaleGreen
                Else
                    barSeat8Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 23 Then
                If tablenum(i) = "n" Then
                    barSeat9Button.BackColor = Color.PaleGreen
                Else
                    barSeat9Button.BackColor = Color.LightSalmon
                End If
            ElseIf i = 24 Then
                If tablenum(i) = "n" Then
                    barSeat10Button.BackColor = Color.PaleGreen
                Else
                    barSeat10Button.BackColor = Color.LightSalmon
                End If
            End If
            i += 1
        Loop
    End Sub

    Public Sub retrieveNote()
        Dim query As String = "SELECT note FROM restaurant.employeeinfo WHERE un='" + unID + "';"
        Using connection As New MySqlConnection(connStr)
            Dim command As New MySqlCommand(query, connection)
            Try
                connection.Open()
                noteLabel.Text = Convert.ToString(command.ExecuteScalar())
                connection.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Using
    End Sub

    Public Function getDBCount()
        Dim query As String = "SELECT COUNT(un) FROM restaurant.employeeinfo WHERE type='2' AND isLoggedIn='y';"
        Dim dbRowCount As String
        Dim connection As New MySqlConnection(connStr)
        Dim command As New MySqlCommand(query, connection)
        Try
            connection.Open()
            dbRowCount = Convert.ToString(command.ExecuteScalar)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            connection.Close()
        End Try
        Return dbRowCount
    End Function

    Public Sub fillWaiterLabel()
        Dim query As String = "SELECT displayName,areaNumber FROM restaurant.employeeinfo WHERE type='2' AND isLoggedIn='y';"
        Dim waitersName(0 To 4) As String
        Dim waitersZone(0 To 4) As String
        Dim i As Integer = 0
        Dim j As Integer = 0

        Using connection As New MySqlConnection(connStr)
            Dim command As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader
            Try
                connection.Open()
                reader = command.ExecuteReader()
                While (reader.Read())
                    waitersName(i) = reader.GetString(0)
                    waitersZone(i) = reader.GetString(1)
                    i += 1
                End While
                connection.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Using

        waiter1Label.Text = ""
        waiter2Label.Text = ""
        waiter3Label.Text = ""
        waiter4Label.Text = ""
        bartenderLabel.Text = ""

        For i = 0 To 4
            If waitersZone(i) = 1 Then
                waiter1Label.Text = waitersName(i)
            ElseIf waitersZone(i) = 2 Then
                waiter2Label.Text = waitersName(i)
            ElseIf waitersZone(i) = 3 Then
                waiter3Label.Text = waitersName(i)
            ElseIf waitersZone(i) = 4 Then
                waiter4Label.Text = waitersName(i)
            ElseIf waitersZone(i) = 5 Then
                bartenderLabel.Text = waitersName(i)
            End If
        Next
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
    'keyboard buttons
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