Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlClient
Imports Restaurant100.inventory
Imports System

Public Class waiter

    Public connStr As String

    Dim checkAlc(0 To 0) As String
    Dim checkDrinks(0 To 0) As String
    Dim checkApps(0 To 0) As String
    Dim checkEntrees(0 To 0) As String
    Dim checkDesserts(0 To 0) As String
    Dim checkSides(0 To 0) As String
    Dim check() As String
    Dim tableNumber As String
    Dim checkTotal As Integer
    Dim checkString As String
    Dim inventoryValues(0 To 0) As String
    Dim eightySixStuff(0 To 0) As String
    Dim getItems As String

    '---------------------on load functions
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
        getTableCheck()

        tabControlWaiter.TabPages.Remove(eightySixTab)
        tabControlWaiter.TabPages.Remove(sideOfTab)
    End Sub

    Private Sub getTableCheck()
        Dim queryGET As String = "SELECT items FROM restaurant.tablechecks WHERE tablenum='" + tableNumber + "';"
        'Dim getItems As String
        Using connection As New MySqlConnection(connStr)
            Dim command As New MySqlCommand(queryGET, connection)
            Try
                connection.Open()
                getItems = Convert.ToString(command.ExecuteScalar())
                connection.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Using
        orderTextBox.Text = getItems
        checkString = getItems
        '       $5  -  BEER        '$5  -  BEER        '$5  -  BEER        '$5  -  BEER        '$2  -  MILK        '$4  -  POTATO SKINS        '$2  -  CHIPS & SALSA        '$7  -  TURKEY BLT        '$8  -  HONEY BBQ        '$7  -  BACON BURGER        '$3  -  ICE CREAM        '$3  -  ICE CREAM
        '$5  -  BEER\r\n$5  -  BEER\r\n$5  -  BEER\r\n$5  -  BEER\r\n$2  -  MILK\r\n$4  -  POTATO SKINS\r\n$2  -  CHIPS & SALSA\r\n$7  -  TURKEY BLT\r\n$8  -  HONEY BBQ\r\n$7  -  BACON BURGER\r\n$3  -  ICE CREAM\r\n$3  -  ICE CREAM\r\n', '56'
        Dim temparray() As String
        Dim i As Integer = 0
        temparray = Split(getItems, vbCrLf)
        For i = 0 To (temparray.Length - 1)
            If temparray(i) = "" Then

            ElseIf temparray(i) + vbCrLf = alcohol1s Then
                If checkAlc.Length = 1 Then
                    checkAlc(0) += temparray(i) + vbCrLf
                Else
                    ReDim Preserve checkAlc(0 To (UBound(checkAlc) + 1))
                    checkAlc(UBound(checkAlc)) += temparray(i) + vbCrLf
                End If
            ElseIf temparray(i) + vbCrLf = drink1s Then
                If checkDrinks.Length = 1 Then
                    checkDrinks(0) += temparray(i) + vbCrLf
                Else
                    ReDim Preserve checkDrinks(0 To (UBound(checkDrinks) + 1))
                    checkDrinks(UBound(checkDrinks)) += temparray(i) + vbCrLf
                End If
            ElseIf temparray(i) + vbCrLf = drink2s Then
                If checkDrinks.Length = 1 Then
                    checkDrinks(0) += temparray(i) + vbCrLf
                Else
                    ReDim Preserve checkDrinks(0 To (UBound(checkDrinks) + 1))
                    checkDrinks(UBound(checkDrinks)) += temparray(i) + vbCrLf
                End If
            ElseIf temparray(i) + vbCrLf = drink3s Then
                If checkDrinks.Length = 1 Then
                    checkDrinks(0) += temparray(i) + vbCrLf
                Else
                    ReDim Preserve checkDrinks(0 To (UBound(checkDrinks) + 1))
                    checkDrinks(UBound(checkDrinks)) += temparray(i) + vbCrLf
                End If
            ElseIf temparray(i) + vbCrLf = drink4s Then
                If checkDrinks.Length = 1 Then
                    checkDrinks(0) += temparray(i) + vbCrLf
                Else
                    ReDim Preserve checkDrinks(0 To (UBound(checkDrinks) + 1))
                    checkDrinks(UBound(checkDrinks)) += temparray(i) + vbCrLf
                End If
            ElseIf temparray(i) + vbCrLf = appetizer1s Then
                If checkApps.Length = 1 Then
                    checkApps(0) += temparray(i) + vbCrLf
                Else
                    ReDim Preserve checkApps(0 To (UBound(checkApps) + 1))
                    checkApps(UBound(checkApps)) += temparray(i) + vbCrLf
                End If
            ElseIf temparray(i) + vbCrLf = appetizer2s Then
                If checkApps.Length = 1 Then
                    checkApps(0) += temparray(i) + vbCrLf
                Else
                    ReDim Preserve checkApps(0 To (UBound(checkApps) + 1))
                    checkApps(UBound(checkApps)) += temparray(i) + vbCrLf
                End If
            ElseIf temparray(i) + vbCrLf = appetizer3s Then
                If checkApps.Length = 1 Then
                    checkApps(0) += temparray(i) + vbCrLf
                Else
                    ReDim Preserve checkApps(0 To (UBound(checkApps) + 1))
                    checkApps(UBound(checkApps)) += temparray(i) + vbCrLf
                End If
            ElseIf temparray(i) + vbCrLf = entree1s Then
                If checkEntrees.Length = 1 Then
                    checkEntrees(0) += temparray(i) + vbCrLf
                Else
                    ReDim Preserve checkEntrees(0 To (UBound(checkEntrees) + 1))
                    checkEntrees(UBound(checkEntrees)) += temparray(i) + vbCrLf
                End If
            ElseIf temparray(i) + vbCrLf = entree2s Then
                If checkEntrees.Length = 1 Then
                    checkEntrees(0) += temparray(i) + vbCrLf
                Else
                    ReDim Preserve checkEntrees(0 To (UBound(checkEntrees) + 1))
                    checkEntrees(UBound(checkEntrees)) += temparray(i) + vbCrLf
                End If
            ElseIf temparray(i) + vbCrLf = entree3s Then
                If checkEntrees.Length = 1 Then
                    checkEntrees(0) += temparray(i) + vbCrLf
                Else
                    ReDim Preserve checkEntrees(0 To (UBound(checkEntrees) + 1))
                    checkEntrees(UBound(checkEntrees)) += temparray(i) + vbCrLf
                End If
            ElseIf temparray(i) + vbCrLf = dessert1s Then
                If checkDesserts.Length = 1 Then
                    checkDesserts(0) += temparray(i) + vbCrLf
                Else
                    ReDim Preserve checkDesserts(0 To (UBound(checkDesserts) + 1))
                    checkDesserts(UBound(checkDesserts)) += temparray(i) + vbCrLf
                End If
            ElseIf temparray(i) + vbCrLf = side1s Then
                If checkSides.Length = 1 Then
                    checkSides(0) += temparray(i) + vbCrLf
                Else
                    ReDim Preserve checkSides(0 To (UBound(checkSides) + 1))
                    checkSides(UBound(checkSides)) += temparray(i) + vbCrLf
                End If
            ElseIf temparray(i) + vbCrLf = side2s Then
                If checkSides.Length = 1 Then
                    checkSides(0) += temparray(i) + vbCrLf
                Else
                    ReDim Preserve checkSides(0 To (UBound(checkSides) + 1))
                    checkSides(UBound(checkSides)) += temparray(i) + vbCrLf
                End If
            ElseIf temparray(i) + vbCrLf = side3s Then
                If checkSides.Length = 1 Then
                    checkSides(0) += temparray(i) + vbCrLf
                Else
                    ReDim Preserve checkSides(0 To (UBound(checkSides) + 1))
                    checkSides(UBound(checkSides)) += temparray(i) + vbCrLf
                End If
            ElseIf temparray(i) + vbCrLf = side4s Then
                If checkSides.Length = 1 Then
                    checkSides(0) += temparray(i) + vbCrLf
                Else
                    ReDim Preserve checkSides(0 To (UBound(checkSides) + 1))
                    checkSides(UBound(checkSides)) += temparray(i) + vbCrLf
                End If
            End If
        Next
    End Sub

    Private Sub getTableTotal()
        Dim queryTT As String = "SELECT total FROM restaurant.tablechecks WHERE tablenum='" + tableNumber + "';"

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

    Private Sub clearButton_Click(sender As System.Object, e As System.EventArgs) Handles clearButton.Click
        areYouSureLabel.Visible = True
        yesButton.Visible = True
        noButton.Visible = True
        clearButton.Visible = False
    End Sub

    Private Sub yesButton_Click(sender As Object, e As EventArgs) Handles yesButton.Click
        Dim queryErase As String = "UPDATE restaurant.tablechecks SET items=NULL, total='0' WHERE tablenum='" + tableNumber + "';"
        Using connection As New MySqlConnection(connStr)
            Dim command As New MySqlCommand(queryErase, connection)
            Try
                connection.Open()
                Command.ExecuteNonQuery()
                connection.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Using

        orderTextBox.Text = ""
        checkTotal = 0
        Erase checkAlc, checkDrinks, checkApps, checkEntrees, checkDesserts, check, checkSides, inventoryValues, eightySixStuff
        ReDim checkAlc(0 To 0), checkDrinks(0 To 0), checkApps(0 To 0), checkEntrees(0 To 0), checkDesserts(0 To 0), check(0 To 0), checkSides(0 To 0), inventoryValues(0 To 0), eightySixStuff(0 To 0)
        totalTextBox.Text = FormatCurrency(checkTotal, , , , )

        areYouSureLabel.Visible = False
        yesButton.Visible = False
        noButton.Visible = False
        clearButton.Visible = True
    End Sub

    Private Sub noButton_Click(sender As Object, e As EventArgs) Handles noButton.Click
        areYouSureLabel.Visible = False
        yesButton.Visible = False
        noButton.Visible = False
        clearButton.Visible = True
    End Sub

    Private Sub closeTableButton_Click(sender As Object, e As EventArgs) Handles closeTableButton.Click

    End Sub


    '---------------------submit functions
    Private Sub submitOrderButton_Click(sender As System.Object, e As System.EventArgs) Handles submitOrderButton.Click

        'this is where code would go to send the order to the machine
        'that prints tickets
        updateCheck()
        updateInventory()
        Me.Close()

    End Sub

    Private Sub updateCheck()
        Dim queryGET As String
        Using connection As New MySqlConnection(connStr)
            Dim command As New MySqlCommand(queryGET, connection)
            Dim querySEND As String = "UPDATE restaurant.tablechecks SET items='" + checkString + "', total='" + Convert.ToString(checkTotal) + "' WHERE tablenum='" + tableNumber + "';"
            command = New MySqlCommand(querySEND, connection)
            Try
                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub updateInventory()
        Dim item As String = ""
        Dim count As Integer
        Dim i As Integer = 0
        Dim j As Integer = 0
        Using connection As New MySqlConnection(connStr)
            Dim queryGETNUM As String = "SELECT count FROM restaurant.inventory WHERE item='" + item + "';"
            Dim queryUPDATE As String = "UPDATE restaurant.inventory SET count='" + Convert.ToString(count) + "' WHERE item='" + item + "';"
            Dim command1 As New MySqlCommand(queryGETNUM, connection)
            Dim command2 As New MySqlCommand(queryUPDATE, connection)
            Try
                connection.Open()
                While (i < (UBound(eightySixStuff)))
                    item = eightySixStuff(i)
                    j = 0
                    While (j < (UBound(inventoryValues)))
                        If inventoryValues(j) = item Then
                            inventoryValues(j) = ""
                            Exit While
                        End If
                        j += 1
                    End While
                    i += 1
                End While
                i = 0
                j = 0
                item = ""
                While (i < (UBound(inventoryValues)))
                    item = inventoryValues(i)
                    queryGETNUM = "SELECT count FROM restaurant.inventory WHERE item='" + item + "';"
                    command1 = New MySqlCommand(queryGETNUM, connection)
                    count = Convert.ToInt32(command1.ExecuteScalar())
                    count = count - 1
                    queryUPDATE = "UPDATE restaurant.inventory SET count='" + Convert.ToString(count) + "' WHERE item='" + item + "';"
                    command2 = New MySqlCommand(queryUPDATE, connection)
                    command2.ExecuteNonQuery()
                    i += 1
                End While
                connection.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Using

    End Sub

    '---------------------food buttons // displayCheck is ran every time a button is pressed to display the items on screen
    Public Sub displayCheck(ByVal text As String, ByVal itemOrder As Integer)
        If itemOrder = 0 Then
            If checkAlc.Length = 1 Then
                checkAlc(0) += text
            Else
                ReDim Preserve checkAlc(0 To (UBound(checkAlc) + 1))
                checkAlc(UBound(checkAlc)) += text
            End If
        ElseIf itemOrder = 1 Then
            If checkDrinks.Length = 1 Then
                checkDrinks(0) += text
            Else
                ReDim Preserve checkDrinks(0 To (UBound(checkDrinks) + 1))
                checkDrinks(UBound(checkDrinks)) += text
            End If
        ElseIf itemOrder = 2 Then
            If checkApps.Length = 1 Then
                checkApps(0) += text
            Else
                ReDim Preserve checkApps(0 To (UBound(checkApps) + 1))
                checkApps(UBound(checkApps)) += text
            End If
        ElseIf itemOrder = 3 Then
            If checkEntrees.Length = 1 Then
                checkEntrees(0) += text
            Else
                ReDim Preserve checkEntrees(0 To (UBound(checkEntrees) + 1))
                checkEntrees(UBound(checkEntrees)) += text
            End If
        ElseIf itemOrder = 4 Then
            If checkDesserts.Length = 1 Then
                checkDesserts(0) += text
            Else
                ReDim Preserve checkDesserts(0 To (UBound(checkDesserts) + 1))
                checkDesserts(UBound(checkDesserts)) += text
            End If
        ElseIf itemOrder = 5 Then
            If checkSides.Length = 1 Then
                checkSides(0) += text
            Else
                ReDim Preserve checkSides(0 To (UBound(checkSides) + 1))
                checkSides(UBound(checkSides)) += text
            End If
        End If

        'checkString = getItems
        checkString = ""
        checkString += Join(checkAlc)
        checkString += Join(checkDrinks)
        checkString += Join(checkApps)
        checkString += Join(checkEntrees)
        checkString += Join(checkDesserts)
        checkString += Join(checkSides)

        orderTextBox.Text = ""
        orderTextBox.Text = checkString

        check = Split(checkString, vbCrLf)
    End Sub

    '------------food buttons // item order: 0 = alcohol, 1 = drinks, 2 = appetizers, 3 = entrees, 4 = desserts, 5 = sides
    Private Sub alcohol1Button_Click(sender As Object, e As EventArgs) Handles alcohol1Button.Click
        Dim text As String = inventory.alcohol1s
        Dim price As Integer = inventory.alcohol1.price
        Dim i As Integer = 0
        Dim itemName() As String
        Dim itemValues As Array
        Dim size As Integer = inventoryValues.Length

        itemName = System.Enum.GetNames(GetType(alcohol1))
        itemValues = System.Enum.GetValues(GetType(alcohol1))

        checkTotal += price
        totalTextBox.Text = FormatCurrency(checkTotal, , , , )

        displayCheck(text, 0)

        While (i < UBound(itemValues))
            size = inventoryValues.Length
            inventoryValues(size - 1) = itemName(i)
            ReDim Preserve inventoryValues(0 To (UBound(inventoryValues) + 1))

            i += 1
        End While

    End Sub
    Private Sub drink1Button_Click(sender As Object, e As EventArgs) Handles drink1Button.Click
        Dim text As String = inventory.drink1s
        Dim price As Integer = inventory.drink1.price
        Dim i As Integer = 0
        Dim itemName() As String
        Dim itemValues As Array
        Dim size As Integer = inventoryValues.Length

        itemName = System.Enum.GetNames(GetType(drink1))
        itemValues = System.Enum.GetValues(GetType(drink1))

        checkTotal += price
        totalTextBox.Text = FormatCurrency(checkTotal, , , , )

        displayCheck(text, 1)

        While (i < UBound(itemValues))
            size = inventoryValues.Length
            inventoryValues(size - 1) = itemName(i)
            ReDim Preserve inventoryValues(0 To (UBound(inventoryValues) + 1))

            i += 1
        End While
    End Sub
    Private Sub drink2Button_Click(sender As Object, e As EventArgs) Handles drink2Button.Click
        Dim text As String = inventory.drink2s
        Dim price As Integer = inventory.drink2.price
        Dim i As Integer = 0
        Dim itemName() As String
        Dim itemValues As Array
        Dim size As Integer = inventoryValues.Length

        itemName = System.Enum.GetNames(GetType(drink2))
        itemValues = System.Enum.GetValues(GetType(drink2))

        checkTotal += price
        totalTextBox.Text = FormatCurrency(checkTotal, , , , )

        displayCheck(text, 1)

        While (i < UBound(itemValues))
            size = inventoryValues.Length
            inventoryValues(size - 1) = itemName(i)
            ReDim Preserve inventoryValues(0 To (UBound(inventoryValues) + 1))

            i += 1
        End While
    End Sub
    Private Sub drink3Button_Click(sender As Object, e As EventArgs) Handles drink3Button.Click
        Dim text As String = inventory.drink3s
        Dim price As Integer = inventory.drink3.price
        Dim i As Integer = 0
        Dim itemName() As String
        Dim itemValues As Array
        Dim size As Integer = inventoryValues.Length

        itemName = System.Enum.GetNames(GetType(drink3))
        itemValues = System.Enum.GetValues(GetType(drink3))

        checkTotal += price
        totalTextBox.Text = FormatCurrency(checkTotal, , , , )

        displayCheck(text, 1)

        While (i < UBound(itemValues))
            size = inventoryValues.Length
            inventoryValues(size - 1) = itemName(i)
            ReDim Preserve inventoryValues(0 To (UBound(inventoryValues) + 1))

            i += 1
        End While
    End Sub
    Private Sub drink4Button_Click(sender As Object, e As EventArgs) Handles drink4Button.Click
        Dim text As String = inventory.drink4s
        Dim price As Integer = inventory.drink4.price
        Dim i As Integer = 0
        Dim itemName() As String
        Dim itemValues As Array
        Dim size As Integer = inventoryValues.Length

        itemName = System.Enum.GetNames(GetType(drink4))
        itemValues = System.Enum.GetValues(GetType(drink4))

        checkTotal += price
        totalTextBox.Text = FormatCurrency(checkTotal, , , , )

        displayCheck(text, 1)

        While (i < UBound(itemValues))
            size = inventoryValues.Length
            inventoryValues(size - 1) = itemName(i)
            ReDim Preserve inventoryValues(0 To (UBound(inventoryValues) + 1))

            i += 1
        End While
    End Sub
    Private Sub app1Button_Click(sender As Object, e As EventArgs) Handles app1Button.Click
        Dim text As String = inventory.appetizer1s
        Dim price As Integer = inventory.appetizer1.price
        Dim i As Integer = 0
        Dim itemName() As String
        Dim itemValues As Array
        Dim size As Integer = inventoryValues.Length

        itemName = System.Enum.GetNames(GetType(appetizer1))
        itemValues = System.Enum.GetValues(GetType(appetizer1))

        checkTotal += price
        totalTextBox.Text = FormatCurrency(checkTotal, , , , )

        displayCheck(text, 2)

        While (i < UBound(itemValues))
            size = inventoryValues.Length
            inventoryValues(size - 1) = itemName(i)
            ReDim Preserve inventoryValues(0 To (UBound(inventoryValues) + 1))

            i += 1
        End While
    End Sub
    Private Sub app2Button_Click(sender As Object, e As EventArgs) Handles app2Button.Click
        Dim text As String = inventory.appetizer2s
        Dim price As Integer = inventory.appetizer2.price
        Dim i As Integer = 0
        Dim itemName() As String
        Dim itemValues As Array
        Dim size As Integer = inventoryValues.Length

        itemName = System.Enum.GetNames(GetType(appetizer2))
        itemValues = System.Enum.GetValues(GetType(appetizer2))

        checkTotal += price
        totalTextBox.Text = FormatCurrency(checkTotal, , , , )

        displayCheck(text, 2)

        While (i < UBound(itemValues))
            size = inventoryValues.Length
            inventoryValues(size - 1) = itemName(i)
            ReDim Preserve inventoryValues(0 To (UBound(inventoryValues) + 1))

            i += 1
        End While
    End Sub
    Private Sub app3Button_Click(sender As Object, e As EventArgs) Handles app3Button.Click
        Dim text As String = inventory.appetizer3s
        Dim price As Integer = inventory.appetizer3.price
        Dim i As Integer = 0
        Dim itemName() As String
        Dim itemValues As Array
        Dim size As Integer = inventoryValues.Length

        itemName = System.Enum.GetNames(GetType(appetizer3))
        itemValues = System.Enum.GetValues(GetType(appetizer3))

        checkTotal += price
        totalTextBox.Text = FormatCurrency(checkTotal, , , , )

        displayCheck(text, 2)

        While (i < UBound(itemValues))
            size = inventoryValues.Length
            inventoryValues(size - 1) = itemName(i)
            ReDim Preserve inventoryValues(0 To (UBound(inventoryValues) + 1))

            i += 1
        End While
    End Sub
    Private Sub entree1Button_Click(sender As Object, e As EventArgs) Handles entree1Button.Click
        Dim text As String = inventory.entree1s
        Dim price As Integer = inventory.entree1.price
        Dim i As Integer = 0
        Dim itemName() As String
        Dim itemValues As Array
        Dim size As Integer = inventoryValues.Length

        itemName = System.Enum.GetNames(GetType(entree1))
        itemValues = System.Enum.GetValues(GetType(entree1))

        checkTotal += price
        totalTextBox.Text = FormatCurrency(checkTotal, , , , )

        displayCheck(text, 3)

        While (i < UBound(itemValues))
            size = inventoryValues.Length
            inventoryValues(size - 1) = itemName(i)
            ReDim Preserve inventoryValues(0 To (UBound(inventoryValues) + 1))

            i += 1
        End While
    End Sub
    Private Sub entree2Button_Click(sender As Object, e As EventArgs) Handles entree2Button.Click
        Dim text As String = inventory.entree2s
        Dim price As Integer = inventory.entree2.price
        Dim i As Integer = 0
        Dim itemName() As String
        Dim itemValues As Array
        Dim size As Integer = inventoryValues.Length

        itemName = System.Enum.GetNames(GetType(entree2))
        itemValues = System.Enum.GetValues(GetType(entree2))

        checkTotal += price
        totalTextBox.Text = FormatCurrency(checkTotal, , , , )

        displayCheck(text, 3)

        While (i < UBound(itemValues))
            size = inventoryValues.Length
            inventoryValues(size - 1) = itemName(i)
            ReDim Preserve inventoryValues(0 To (UBound(inventoryValues) + 1))

            i += 1
        End While
    End Sub
    Private Sub entree3Button_Click(sender As Object, e As EventArgs) Handles entree3Button.Click
        Dim text As String = inventory.entree3s
        Dim price As Integer = inventory.entree3.price
        Dim i As Integer = 0
        Dim itemName() As String
        Dim itemValues As Array
        Dim size As Integer = inventoryValues.Length

        itemName = System.Enum.GetNames(GetType(entree3))
        itemValues = System.Enum.GetValues(GetType(entree3))

        checkTotal += price
        totalTextBox.Text = FormatCurrency(checkTotal, , , , )

        displayCheck(text, 3)

        While (i < UBound(itemValues))
            size = inventoryValues.Length
            inventoryValues(size - 1) = itemName(i)
            ReDim Preserve inventoryValues(0 To (UBound(inventoryValues) + 1))

            i += 1
        End While
    End Sub
    Private Sub dessert1Button_Click(sender As Object, e As EventArgs) Handles dessert1Button.Click
        Dim text As String = inventory.dessert1s
        Dim price As Integer = inventory.dessert1.price
        Dim i As Integer = 0
        Dim itemName() As String
        Dim itemValues As Array
        Dim size As Integer = inventoryValues.Length

        itemName = System.Enum.GetNames(GetType(dessert1))
        itemValues = System.Enum.GetValues(GetType(dessert1))

        checkTotal += price
        totalTextBox.Text = FormatCurrency(checkTotal, , , , )

        displayCheck(text, 4)

        While (i < UBound(itemValues))
            size = inventoryValues.Length
            inventoryValues(size - 1) = itemName(i)
            ReDim Preserve inventoryValues(0 To (UBound(inventoryValues) + 1))

            i += 1
        End While
    End Sub

    '---------------------modifier buttons
    Private Sub tabMods(ByVal input As Integer)
        If input = 0 Then   'click 86 button, show only 86 tab
            tabControlWaiter.TabPages.Remove(alcoholTab)
            tabControlWaiter.TabPages.Remove(drinksTab)
            tabControlWaiter.TabPages.Remove(appTab)
            tabControlWaiter.TabPages.Remove(entreeTab)
            tabControlWaiter.TabPages.Remove(dessertTab)
            tabControlWaiter.TabPages.Remove(sideOfTab)
            tabControlWaiter.TabPages.Add(eightySixTab)
        ElseIf input = 1 Then   'button clicks under 86 category, show default tabs
            tabControlWaiter.TabPages.Add(alcoholTab)
            tabControlWaiter.TabPages.Add(drinksTab)
            tabControlWaiter.TabPages.Add(appTab)
            tabControlWaiter.TabPages.Add(entreeTab)
            tabControlWaiter.TabPages.Add(dessertTab)
            tabControlWaiter.TabPages.Remove(eightySixTab)
        ElseIf input = 2 Then   'click side of button, show only side of tab
            tabControlWaiter.TabPages.Remove(alcoholTab)
            tabControlWaiter.TabPages.Remove(drinksTab)
            tabControlWaiter.TabPages.Remove(appTab)
            tabControlWaiter.TabPages.Remove(entreeTab)
            tabControlWaiter.TabPages.Remove(dessertTab)
            tabControlWaiter.TabPages.Remove(sideOfTab)
            tabControlWaiter.TabPages.Add(sideOfTab)
        End If
    End Sub

    '---------------------86 mod button
    Public Sub modifier86Button_Click(sender As Object, e As EventArgs) Handles modifier86Button.Click
        tabMods(0)
    End Sub

    Private Sub bacon86Button_Click(sender As Object, e As EventArgs) Handles bacon86Button.Click
        eightySixStuff(UBound(eightySixStuff)) = "bacon"
        ReDim Preserve eightySixStuff(0 To (UBound(eightySixStuff) + 1))
        tabMods(1)
    End Sub

    Private Sub cheese86Button_Click(sender As Object, e As EventArgs) Handles cheese86Button.Click
        eightySixStuff(UBound(eightySixStuff)) = "cheese"
        ReDim Preserve eightySixStuff(0 To (UBound(eightySixStuff) + 1))
        tabMods(1)
    End Sub

    Private Sub lettuce86Button_Click(sender As Object, e As EventArgs) Handles lettuce86Button.Click
        eightySixStuff(UBound(eightySixStuff)) = "lettuce"
        ReDim Preserve eightySixStuff(0 To (UBound(eightySixStuff) + 1))
        tabMods(1)
    End Sub

    Private Sub tomato86Button_Click(sender As Object, e As EventArgs) Handles tomato86Button.Click
        eightySixStuff(UBound(eightySixStuff)) = "tomato"
        ReDim Preserve eightySixStuff(0 To (UBound(eightySixStuff) + 1))
        tabMods(1)

    End Sub

    Private Sub onion86Button_Click(sender As Object, e As EventArgs) Handles onion86Button.Click
        eightySixStuff(UBound(eightySixStuff)) = "onion"
        ReDim Preserve eightySixStuff(0 To (UBound(eightySixStuff) + 1))
        tabMods(1)

    End Sub

    Private Sub close86Button_Click(sender As Object, e As EventArgs) Handles close86Button.Click
        tabControlWaiter.TabPages.Add(alcoholTab)
        tabControlWaiter.TabPages.Add(drinksTab)
        tabControlWaiter.TabPages.Add(appTab)
        tabControlWaiter.TabPages.Add(entreeTab)
        tabControlWaiter.TabPages.Add(dessertTab)
        tabControlWaiter.TabPages.Remove(eightySixTab)
    End Sub

    '--------------------sides
    Private Sub sideofModifierButton_Click(sender As Object, e As EventArgs) Handles sideofModifierButton.Click
        tabMods(2)
    End Sub

    Private Sub friesSideButton_Click(sender As Object, e As EventArgs) Handles friesSideButton.Click
        Dim text As String = inventory.side1s
        Dim price As Integer = inventory.side1.price
        Dim i As Integer = 0
        Dim itemName() As String
        Dim itemValues As Array
        Dim size As Integer = inventoryValues.Length

        itemName = System.Enum.GetNames(GetType(side1))
        itemValues = System.Enum.GetValues(GetType(side1))

        checkTotal += price
        totalTextBox.Text = FormatCurrency(checkTotal, , , , )

        displayCheck(text, 5)

        While (i < UBound(itemValues))
            size = inventoryValues.Length
            inventoryValues(size - 1) = itemName(i)
            ReDim Preserve inventoryValues(0 To (UBound(inventoryValues) + 1))

            i += 1
        End While

        tabMods(2)
    End Sub

    Private Sub chipsSideButton_Click(sender As Object, e As EventArgs) Handles chipsSideButton.Click
        Dim text As String = inventory.side2s
        Dim price As Integer = inventory.side2.price
        Dim i As Integer = 0
        Dim itemName() As String
        Dim itemValues As Array
        Dim size As Integer = inventoryValues.Length

        itemName = System.Enum.GetNames(GetType(side2))
        itemValues = System.Enum.GetValues(GetType(side2))

        checkTotal += price
        totalTextBox.Text = FormatCurrency(checkTotal, , , , )

        displayCheck(text, 5)

        While (i < UBound(itemValues))
            size = inventoryValues.Length
            inventoryValues(size - 1) = itemName(i)
            ReDim Preserve inventoryValues(0 To (UBound(inventoryValues) + 1))

            i += 1
        End While

        tabMods(2)
    End Sub

    Private Sub salsaSideButton_Click(sender As Object, e As EventArgs) Handles salsaSideButton.Click
        Dim text As String = inventory.side3s
        Dim price As Integer = inventory.side3.price
        Dim i As Integer = 0
        Dim itemName() As String
        Dim itemValues As Array
        Dim size As Integer = inventoryValues.Length

        itemName = System.Enum.GetNames(GetType(side3))
        itemValues = System.Enum.GetValues(GetType(side3))

        checkTotal += price
        totalTextBox.Text = FormatCurrency(checkTotal, , , , )

        displayCheck(text, 5)

        While (i < UBound(itemValues))
            size = inventoryValues.Length
            inventoryValues(size - 1) = itemName(i)
            ReDim Preserve inventoryValues(0 To (UBound(inventoryValues) + 1))

            i += 1
        End While

        tabMods(2)
    End Sub

    Private Sub baconSideButton_Click(sender As Object, e As EventArgs) Handles baconSideButton.Click
        Dim text As String = inventory.side4s
        Dim price As Integer = inventory.side4.price
        Dim i As Integer = 0
        Dim itemName() As String
        Dim itemValues As Array
        Dim size As Integer = inventoryValues.Length

        itemName = System.Enum.GetNames(GetType(side4))
        itemValues = System.Enum.GetValues(GetType(side4))

        checkTotal += price
        totalTextBox.Text = FormatCurrency(checkTotal, , , , )

        displayCheck(text, 5)

        While (i < UBound(itemValues))
            size = inventoryValues.Length
            inventoryValues(size - 1) = itemName(i)
            ReDim Preserve inventoryValues(0 To (UBound(inventoryValues) + 1))

            i += 1
        End While

        tabMods(2)
    End Sub

    Private Sub closeSidesButton_Click(sender As Object, e As EventArgs) Handles closeSidesButton.Click
        tabControlWaiter.TabPages.Add(alcoholTab)
        tabControlWaiter.TabPages.Add(drinksTab)
        tabControlWaiter.TabPages.Add(appTab)
        tabControlWaiter.TabPages.Add(entreeTab)
        tabControlWaiter.TabPages.Add(dessertTab)
        tabControlWaiter.TabPages.Remove(sideOfTab)
    End Sub
End Class