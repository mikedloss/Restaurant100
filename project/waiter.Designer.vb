<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class waiter
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.orderTextBox = New System.Windows.Forms.TextBox()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.tabControlWaiter = New System.Windows.Forms.TabControl()
        Me.alcoholTab = New System.Windows.Forms.TabPage()
        Me.drinksTab = New System.Windows.Forms.TabPage()
        Me.appetizerTab = New System.Windows.Forms.TabPage()
        Me.entreeTab = New System.Windows.Forms.TabPage()
        Me.dessertTab = New System.Windows.Forms.TabPage()
        Me.submitOrderButton = New System.Windows.Forms.Button()
        Me.modifier86Button = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.tabControlWaiter.SuspendLayout()
        Me.SuspendLayout()
        '
        'orderTextBox
        '
        Me.orderTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orderTextBox.Location = New System.Drawing.Point(2, 0)
        Me.orderTextBox.Multiline = True
        Me.orderTextBox.Name = "orderTextBox"
        Me.orderTextBox.Size = New System.Drawing.Size(292, 670)
        Me.orderTextBox.TabIndex = 0
        Me.orderTextBox.Text = "TEST" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TEST" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TESTTESTTEST" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TESTTESTTESTTEST"
        '
        'Button13
        '
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(12, 676)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(282, 42)
        Me.Button13.TabIndex = 13
        Me.Button13.Text = "CLEAR"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'tabControlWaiter
        '
        Me.tabControlWaiter.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabControlWaiter.Controls.Add(Me.alcoholTab)
        Me.tabControlWaiter.Controls.Add(Me.drinksTab)
        Me.tabControlWaiter.Controls.Add(Me.appetizerTab)
        Me.tabControlWaiter.Controls.Add(Me.entreeTab)
        Me.tabControlWaiter.Controls.Add(Me.dessertTab)
        Me.tabControlWaiter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabControlWaiter.Location = New System.Drawing.Point(422, 12)
        Me.tabControlWaiter.Multiline = True
        Me.tabControlWaiter.Name = "tabControlWaiter"
        Me.tabControlWaiter.SelectedIndex = 0
        Me.tabControlWaiter.Size = New System.Drawing.Size(924, 658)
        Me.tabControlWaiter.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabControlWaiter.TabIndex = 14
        '
        'alcoholTab
        '
        Me.alcoholTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.alcoholTab.Location = New System.Drawing.Point(4, 30)
        Me.alcoholTab.Name = "alcoholTab"
        Me.alcoholTab.Padding = New System.Windows.Forms.Padding(3)
        Me.alcoholTab.Size = New System.Drawing.Size(916, 624)
        Me.alcoholTab.TabIndex = 0
        Me.alcoholTab.Text = "ALCOHOL"
        Me.alcoholTab.UseVisualStyleBackColor = True
        '
        'drinksTab
        '
        Me.drinksTab.Location = New System.Drawing.Point(4, 30)
        Me.drinksTab.Name = "drinksTab"
        Me.drinksTab.Padding = New System.Windows.Forms.Padding(3)
        Me.drinksTab.Size = New System.Drawing.Size(916, 624)
        Me.drinksTab.TabIndex = 1
        Me.drinksTab.Text = "DRINKS"
        Me.drinksTab.UseVisualStyleBackColor = True
        '
        'appetizerTab
        '
        Me.appetizerTab.Location = New System.Drawing.Point(4, 30)
        Me.appetizerTab.Name = "appetizerTab"
        Me.appetizerTab.Size = New System.Drawing.Size(916, 624)
        Me.appetizerTab.TabIndex = 2
        Me.appetizerTab.Text = "APPETIZERS"
        Me.appetizerTab.UseVisualStyleBackColor = True
        '
        'entreeTab
        '
        Me.entreeTab.Location = New System.Drawing.Point(4, 30)
        Me.entreeTab.Name = "entreeTab"
        Me.entreeTab.Size = New System.Drawing.Size(916, 624)
        Me.entreeTab.TabIndex = 3
        Me.entreeTab.Text = "ENTREE'S"
        Me.entreeTab.UseVisualStyleBackColor = True
        '
        'dessertTab
        '
        Me.dessertTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dessertTab.Location = New System.Drawing.Point(4, 30)
        Me.dessertTab.Name = "dessertTab"
        Me.dessertTab.Size = New System.Drawing.Size(916, 624)
        Me.dessertTab.TabIndex = 4
        Me.dessertTab.Text = "DESSERTS"
        Me.dessertTab.UseVisualStyleBackColor = True
        '
        'submitOrderButton
        '
        Me.submitOrderButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitOrderButton.Location = New System.Drawing.Point(300, 676)
        Me.submitOrderButton.Name = "submitOrderButton"
        Me.submitOrderButton.Size = New System.Drawing.Size(1046, 42)
        Me.submitOrderButton.TabIndex = 15
        Me.submitOrderButton.Text = "SUBMIT ORDER"
        Me.submitOrderButton.UseVisualStyleBackColor = True
        '
        'modifier86Button
        '
        Me.modifier86Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modifier86Button.Location = New System.Drawing.Point(310, 48)
        Me.modifier86Button.Name = "modifier86Button"
        Me.modifier86Button.Size = New System.Drawing.Size(100, 70)
        Me.modifier86Button.TabIndex = 16
        Me.modifier86Button.Text = "86"
        Me.modifier86Button.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(310, 130)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 70)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "ADD"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(310, 213)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 70)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "LIGHT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(310, 298)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 70)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "CRISPY"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(310, 385)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 70)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "ON SIDE"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(310, 471)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 70)
        Me.Button6.TabIndex = 21
        Me.Button6.Text = "SIDE OF"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(310, 558)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(100, 70)
        Me.Button7.TabIndex = 22
        Me.Button7.Text = "EXTRA"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'waiter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 730)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.modifier86Button)
        Me.Controls.Add(Me.submitOrderButton)
        Me.Controls.Add(Me.tabControlWaiter)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.orderTextBox)
        Me.Name = "waiter"
        Me.Text = "Waiter"
        Me.tabControlWaiter.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents orderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents tabControlWaiter As System.Windows.Forms.TabControl
    Friend WithEvents alcoholTab As System.Windows.Forms.TabPage
    Friend WithEvents drinksTab As System.Windows.Forms.TabPage
    Friend WithEvents appetizerTab As System.Windows.Forms.TabPage
    Friend WithEvents entreeTab As System.Windows.Forms.TabPage
    Friend WithEvents dessertTab As System.Windows.Forms.TabPage
    Friend WithEvents submitOrderButton As System.Windows.Forms.Button
    Friend WithEvents modifier86Button As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
End Class
