Public Class tables

    Dim userType As Integer
    '1 = host
    '2 = waiter
    '3 = manager

    Dim username As String
    Dim password As String
    Dim namee As String
    Dim address As String

    'Public Sub New(ByVal username As String, ByVal password As String)
    Public Sub New(ByVal userType As Integer)
        InitializeComponent()
        'Me.namee = username
        'InitializeComponent()
        waiter1Label.Text = Convert.ToString(userType)
    End Sub


    Private Sub tables_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub table1seat1Button_Click(sender As System.Object, e As System.EventArgs) Handles table1seat1Button.Click
        If (userType = 1) Then
            If (table1seat1Button.BackColor = Color.PaleGreen) Then
                table1seat1Button.BackColor = Color.LightSalmon
            Else
                table1seat1Button.BackColor = Color.PaleGreen
            End If
        ElseIf (userType = 2) Then
            waiter.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub table1seat2Button_Click(sender As System.Object, e As System.EventArgs) Handles table1seat2Button.Click
        If (table1seat2Button.BackColor = Color.PaleGreen) Then
            table1seat2Button.BackColor = Color.LightSalmon
        Else
            table1seat2Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table1seat3Button_Click(sender As System.Object, e As System.EventArgs) Handles table1seat3Button.Click
        If (table1seat3Button.BackColor = Color.PaleGreen) Then
            table1seat3Button.BackColor = Color.LightSalmon
        Else
            table1seat3Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table1seat4Button_Click(sender As System.Object, e As System.EventArgs) Handles table1seat4Button.Click
        If (table1seat4Button.BackColor = Color.PaleGreen) Then
            table1seat4Button.BackColor = Color.LightSalmon
        Else
            table1seat4Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table2seat1Button_Click(sender As System.Object, e As System.EventArgs) Handles table2seat1Button.Click
        If (table2seat1Button.BackColor = Color.PaleGreen) Then
            table2seat1Button.BackColor = Color.LightSalmon
        Else
            table2seat1Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table2seat2Button_Click(sender As System.Object, e As System.EventArgs) Handles table2seat2Button.Click
        If (table2seat2Button.BackColor = Color.PaleGreen) Then
            table2seat2Button.BackColor = Color.LightSalmon
        Else
            table2seat2Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table2seat3Button_Click(sender As System.Object, e As System.EventArgs) Handles table2seat3Button.Click
        If (table2seat3Button.BackColor = Color.PaleGreen) Then
            table2seat3Button.BackColor = Color.LightSalmon
        Else
            table2seat3Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table2seat4Button_Click(sender As System.Object, e As System.EventArgs) Handles table2seat4Button.Click
        If (table2seat4Button.BackColor = Color.PaleGreen) Then
            table2seat4Button.BackColor = Color.LightSalmon
        Else
            table2seat4Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table3seat1Button_Click(sender As System.Object, e As System.EventArgs) Handles table3seat1Button.Click
        If (table3seat1Button.BackColor = Color.PaleGreen) Then
            table3seat1Button.BackColor = Color.LightSalmon
        Else
            table3seat1Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table3seat2Button_Click(sender As System.Object, e As System.EventArgs) Handles table3seat2Button.Click
        If (table3seat2Button.BackColor = Color.PaleGreen) Then
            table3seat2Button.BackColor = Color.LightSalmon
        Else
            table3seat2Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table3seat3Button_Click(sender As System.Object, e As System.EventArgs) Handles table3seat3Button.Click
        If (table3seat3Button.BackColor = Color.PaleGreen) Then
            table3seat3Button.BackColor = Color.LightSalmon
        Else
            table3seat3Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table3seat4Button_Click(sender As System.Object, e As System.EventArgs) Handles table3seat4Button.Click
        If (table3seat4Button.BackColor = Color.PaleGreen) Then
            table3seat4Button.BackColor = Color.LightSalmon
        Else
            table3seat4Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table4seat1Button_Click(sender As System.Object, e As System.EventArgs) Handles table4seat1Button.Click
        If (table4seat1Button.BackColor = Color.PaleGreen) Then
            table4seat1Button.BackColor = Color.LightSalmon
        Else
            table4seat1Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table4seat2Button_Click(sender As System.Object, e As System.EventArgs) Handles table4seat2Button.Click
        If (table4seat2Button.BackColor = Color.PaleGreen) Then
            table4seat2Button.BackColor = Color.LightSalmon
        Else
            table4seat2Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table4seat3Button_Click(sender As System.Object, e As System.EventArgs) Handles table4seat3Button.Click
        If (table4seat3Button.BackColor = Color.PaleGreen) Then
            table4seat3Button.BackColor = Color.LightSalmon
        Else
            table4seat3Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table4seat4Button_Click(sender As System.Object, e As System.EventArgs) Handles table4seat4Button.Click
        If (table4seat4Button.BackColor = Color.PaleGreen) Then
            table4seat4Button.BackColor = Color.LightSalmon
        Else
            table4seat4Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table5seat1Button_Click(sender As System.Object, e As System.EventArgs) Handles table5seat1Button.Click
        If (table5seat1Button.BackColor = Color.PaleGreen) Then
            table5seat1Button.BackColor = Color.LightSalmon
        Else
            table5seat1Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table5seat2Button_Click(sender As System.Object, e As System.EventArgs) Handles table5seat2Button.Click
        If (table5seat2Button.BackColor = Color.PaleGreen) Then
            table5seat2Button.BackColor = Color.LightSalmon
        Else
            table5seat2Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table5seat3Button_Click(sender As System.Object, e As System.EventArgs) Handles table5seat3Button.Click
        If (table5seat3Button.BackColor = Color.PaleGreen) Then
            table5seat3Button.BackColor = Color.LightSalmon
        Else
            table5seat3Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table5seat4Button_Click(sender As System.Object, e As System.EventArgs) Handles table5seat4Button.Click
        If (table5seat4Button.BackColor = Color.PaleGreen) Then
            table5seat4Button.BackColor = Color.LightSalmon
        Else
            table5seat4Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table6seat1Button_Click(sender As System.Object, e As System.EventArgs) Handles table6seat1Button.Click
        If (table6seat1Button.BackColor = Color.PaleGreen) Then
            table6seat1Button.BackColor = Color.LightSalmon
        Else
            table6seat1Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table6seat2Button_Click(sender As System.Object, e As System.EventArgs) Handles table6seat2Button.Click
        If (table6seat2Button.BackColor = Color.PaleGreen) Then
            table6seat2Button.BackColor = Color.LightSalmon
        Else
            table6seat2Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table6seat3Button_Click(sender As System.Object, e As System.EventArgs) Handles table6seat3Button.Click
        If (table6seat3Button.BackColor = Color.PaleGreen) Then
            table6seat3Button.BackColor = Color.LightSalmon
        Else
            table6seat3Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table6seat4Button_Click(sender As System.Object, e As System.EventArgs) Handles table6seat4Button.Click
        If (table6seat4Button.BackColor = Color.PaleGreen) Then
            table6seat4Button.BackColor = Color.LightSalmon
        Else
            table6seat4Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table7seat1Button_Click(sender As System.Object, e As System.EventArgs) Handles table7seat1Button.Click
        If (table7seat1Button.BackColor = Color.PaleGreen) Then
            table7seat1Button.BackColor = Color.LightSalmon
        Else
            table7seat1Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table7seat2Button_Click(sender As System.Object, e As System.EventArgs) Handles table7seat2Button.Click
        If (table7seat2Button.BackColor = Color.PaleGreen) Then
            table7seat2Button.BackColor = Color.LightSalmon
        Else
            table7seat2Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table7seat3Button_Click(sender As System.Object, e As System.EventArgs) Handles table7seat3Button.Click
        If (table7seat3Button.BackColor = Color.PaleGreen) Then
            table7seat3Button.BackColor = Color.LightSalmon
        Else
            table7seat3Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table7seat4Button_Click(sender As System.Object, e As System.EventArgs) Handles table7seat4Button.Click
        If (table7seat4Button.BackColor = Color.PaleGreen) Then
            table7seat4Button.BackColor = Color.LightSalmon
        Else
            table7seat4Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table7seat5Button_Click(sender As System.Object, e As System.EventArgs) Handles table7seat5Button.Click
        If (table7seat5Button.BackColor = Color.PaleGreen) Then
            table7seat5Button.BackColor = Color.LightSalmon
        Else
            table7seat5Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table7seat6Button_Click(sender As System.Object, e As System.EventArgs) Handles table7seat6Button.Click
        If (table7seat6Button.BackColor = Color.PaleGreen) Then
            table7seat6Button.BackColor = Color.LightSalmon
        Else
            table7seat6Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table7seat7Button_Click(sender As System.Object, e As System.EventArgs) Handles table7seat7Button.Click
        If (table7seat7Button.BackColor = Color.PaleGreen) Then
            table7seat7Button.BackColor = Color.LightSalmon
        Else
            table7seat7Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table7seat8Button_Click(sender As System.Object, e As System.EventArgs) Handles table7seat8Button.Click
        If (table7seat8Button.BackColor = Color.PaleGreen) Then
            table7seat8Button.BackColor = Color.LightSalmon
        Else
            table7seat8Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table7seat9Button_Click(sender As System.Object, e As System.EventArgs) Handles table7seat9Button.Click
        If (table7seat9Button.BackColor = Color.PaleGreen) Then
            table7seat9Button.BackColor = Color.LightSalmon
        Else
            table7seat9Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table7seat10Button_Click(sender As System.Object, e As System.EventArgs) Handles table7seat10Button.Click
        If (table7seat10Button.BackColor = Color.PaleGreen) Then
            table7seat10Button.BackColor = Color.LightSalmon
        Else
            table7seat10Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table8seat1Button_Click(sender As System.Object, e As System.EventArgs) Handles table8seat1Button.Click
        If (table8seat1Button.BackColor = Color.PaleGreen) Then
            table8seat1Button.BackColor = Color.LightSalmon
        Else
            table8seat1Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table8seat2Button_Click(sender As System.Object, e As System.EventArgs) Handles table8seat2Button.Click
        If (table8seat2Button.BackColor = Color.PaleGreen) Then
            table8seat2Button.BackColor = Color.LightSalmon
        Else
            table8seat2Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table8seat3Button_Click(sender As System.Object, e As System.EventArgs) Handles table8seat3Button.Click
        If (table8seat3Button.BackColor = Color.PaleGreen) Then
            table8seat3Button.BackColor = Color.LightSalmon
        Else
            table8seat3Button.BackColor = Color.PaleGreen
        End If
    End Sub
    Private Sub table8seat4Button_Click(sender As System.Object, e As System.EventArgs) Handles table8seat4Button.Click
        If (table8seat4Button.BackColor = Color.PaleGreen) Then
            table8seat4Button.BackColor = Color.LightSalmon
        Else
            table8seat4Button.BackColor = Color.PaleGreen
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
End Class