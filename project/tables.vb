Public Class tables

    Dim userType As Integer
    '1 = host
    '2 = waiter
    '3 = manager

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

    End Sub
    Private Sub table4seat2Button_Click(sender As System.Object, e As System.EventArgs) Handles table4seat2Button.Click

    End Sub
    Private Sub table4seat3Button_Click(sender As System.Object, e As System.EventArgs) Handles table4seat3Button.Click

    End Sub
    Private Sub table4seat4Button_Click(sender As System.Object, e As System.EventArgs) Handles table4seat4Button.Click

    End Sub
    Private Sub table5seat1Button_Click(sender As System.Object, e As System.EventArgs) Handles table5seat1Button.Click

    End Sub
    Private Sub table5seat2Button_Click(sender As System.Object, e As System.EventArgs) Handles table5seat2Button.Click

    End Sub
    Private Sub table5seat3Button_Click(sender As System.Object, e As System.EventArgs) Handles table5seat3Button.Click

    End Sub
    Private Sub table5seat4Button_Click(sender As System.Object, e As System.EventArgs) Handles table5seat4Button.Click

    End Sub
    Private Sub table6seat1Button_Click(sender As System.Object, e As System.EventArgs) Handles table6seat1Button.Click

    End Sub
    Private Sub table6seat2Button_Click(sender As System.Object, e As System.EventArgs) Handles table6seat2Button.Click

    End Sub
    Private Sub table6seat3Button_Click(sender As System.Object, e As System.EventArgs) Handles table6seat3Button.Click

    End Sub
    Private Sub table6seat4Button_Click(sender As System.Object, e As System.EventArgs) Handles table6seat4Button.Click

    End Sub
    Private Sub table7seat1Button_Click(sender As System.Object, e As System.EventArgs) Handles table7seat1Button.Click

    End Sub
    Private Sub table7seat2Button_Click(sender As System.Object, e As System.EventArgs) Handles table7seat2Button.Click

    End Sub
    Private Sub table7seat3Button_Click(sender As System.Object, e As System.EventArgs) Handles table7seat3Button.Click

    End Sub
    Private Sub table7seat4Button_Click(sender As System.Object, e As System.EventArgs) Handles table7seat4Button.Click

    End Sub
    Private Sub table7seat5Button_Click(sender As System.Object, e As System.EventArgs) Handles table7seat5Button.Click

    End Sub
    Private Sub table7seat6Button_Click(sender As System.Object, e As System.EventArgs) Handles table7seat6Button.Click

    End Sub
    Private Sub table7seat7Button_Click(sender As System.Object, e As System.EventArgs) Handles table7seat7Button.Click

    End Sub
    Private Sub table7seat8Button_Click(sender As System.Object, e As System.EventArgs) Handles table7seat8Button.Click

    End Sub
    Private Sub table7seat9Button_Click(sender As System.Object, e As System.EventArgs) Handles table7seat9Button.Click

    End Sub
    Private Sub table7seat10Button_Click(sender As System.Object, e As System.EventArgs) Handles table7seat10Button.Click

    End Sub
    Private Sub table8seat1Button_Click(sender As System.Object, e As System.EventArgs) Handles table8seat1Button.Click

    End Sub
    Private Sub table8seat2Button_Click(sender As System.Object, e As System.EventArgs) Handles table8seat2Button.Click

    End Sub
    Private Sub table8seat3Button_Click(sender As System.Object, e As System.EventArgs) Handles table8seat3Button.Click

    End Sub
    Private Sub table8seat4Button_Click(sender As System.Object, e As System.EventArgs) Handles table8seat4Button.Click

    End Sub
    Private Sub barSeat1Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat1Button.Click

    End Sub
    Private Sub barSeat2Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat2Button.Click

    End Sub
    Private Sub barSeat3Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat3Button.Click

    End Sub
    Private Sub barSeat4Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat4Button.Click

    End Sub
    Private Sub barSeat5Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat5Button.Click

    End Sub
    Private Sub barSeat6Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat6Button.Click

    End Sub
    Private Sub barSeat7Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat7Button.Click

    End Sub
    Private Sub barSeat8Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat8Button.Click

    End Sub
    Private Sub barSeat9Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat9Button.Click

    End Sub
    Private Sub barSeat10Button_Click(sender As System.Object, e As System.EventArgs) Handles barSeat10Button.Click

    End Sub
End Class