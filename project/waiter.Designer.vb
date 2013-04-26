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
        Me.clearButton = New System.Windows.Forms.Button()
        Me.tabControlWaiter = New System.Windows.Forms.TabControl()
        Me.alcoholTab = New System.Windows.Forms.TabPage()
        Me.alcohol1Button = New System.Windows.Forms.Button()
        Me.drinksTab = New System.Windows.Forms.TabPage()
        Me.drink4Button = New System.Windows.Forms.Button()
        Me.drink3Button = New System.Windows.Forms.Button()
        Me.drink2Button = New System.Windows.Forms.Button()
        Me.drink1Button = New System.Windows.Forms.Button()
        Me.appTab = New System.Windows.Forms.TabPage()
        Me.app3Button = New System.Windows.Forms.Button()
        Me.app2Button = New System.Windows.Forms.Button()
        Me.app1Button = New System.Windows.Forms.Button()
        Me.entreeTab = New System.Windows.Forms.TabPage()
        Me.entree3Button = New System.Windows.Forms.Button()
        Me.entree2Button = New System.Windows.Forms.Button()
        Me.entree1Button = New System.Windows.Forms.Button()
        Me.dessertTab = New System.Windows.Forms.TabPage()
        Me.dessert1Button = New System.Windows.Forms.Button()
        Me.eightySixTab = New System.Windows.Forms.TabPage()
        Me.onion86Button = New System.Windows.Forms.Button()
        Me.tomato86Button = New System.Windows.Forms.Button()
        Me.lettuce86Button = New System.Windows.Forms.Button()
        Me.cheese86Button = New System.Windows.Forms.Button()
        Me.bacon86Button = New System.Windows.Forms.Button()
        Me.sideOfTab = New System.Windows.Forms.TabPage()
        Me.submitOrderButton = New System.Windows.Forms.Button()
        Me.modifier86Button = New System.Windows.Forms.Button()
        Me.sideofModifierButton = New System.Windows.Forms.Button()
        Me.closeTableButton = New System.Windows.Forms.Button()
        Me.tableNumLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.totalTextBox = New System.Windows.Forms.TextBox()
        Me.areYouSureLabel = New System.Windows.Forms.Label()
        Me.noButton = New System.Windows.Forms.Button()
        Me.yesButton = New System.Windows.Forms.Button()
        Me.tabControlWaiter.SuspendLayout()
        Me.alcoholTab.SuspendLayout()
        Me.drinksTab.SuspendLayout()
        Me.appTab.SuspendLayout()
        Me.entreeTab.SuspendLayout()
        Me.dessertTab.SuspendLayout()
        Me.eightySixTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'orderTextBox
        '
        Me.orderTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orderTextBox.Location = New System.Drawing.Point(12, 12)
        Me.orderTextBox.Multiline = True
        Me.orderTextBox.Name = "orderTextBox"
        Me.orderTextBox.Size = New System.Drawing.Size(302, 563)
        Me.orderTextBox.TabIndex = 0
        '
        'clearButton
        '
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(12, 626)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(302, 42)
        Me.clearButton.TabIndex = 13
        Me.clearButton.Text = "CLEAR"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'tabControlWaiter
        '
        Me.tabControlWaiter.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabControlWaiter.Controls.Add(Me.alcoholTab)
        Me.tabControlWaiter.Controls.Add(Me.drinksTab)
        Me.tabControlWaiter.Controls.Add(Me.appTab)
        Me.tabControlWaiter.Controls.Add(Me.entreeTab)
        Me.tabControlWaiter.Controls.Add(Me.dessertTab)
        Me.tabControlWaiter.Controls.Add(Me.eightySixTab)
        Me.tabControlWaiter.Controls.Add(Me.sideOfTab)
        Me.tabControlWaiter.Cursor = System.Windows.Forms.Cursors.Default
        Me.tabControlWaiter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabControlWaiter.HotTrack = True
        Me.tabControlWaiter.Location = New System.Drawing.Point(426, 12)
        Me.tabControlWaiter.Multiline = True
        Me.tabControlWaiter.Name = "tabControlWaiter"
        Me.tabControlWaiter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tabControlWaiter.SelectedIndex = 0
        Me.tabControlWaiter.Size = New System.Drawing.Size(826, 605)
        Me.tabControlWaiter.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.tabControlWaiter.TabIndex = 14
        '
        'alcoholTab
        '
        Me.alcoholTab.Controls.Add(Me.alcohol1Button)
        Me.alcoholTab.Location = New System.Drawing.Point(4, 37)
        Me.alcoholTab.Name = "alcoholTab"
        Me.alcoholTab.Padding = New System.Windows.Forms.Padding(3)
        Me.alcoholTab.Size = New System.Drawing.Size(818, 564)
        Me.alcoholTab.TabIndex = 0
        Me.alcoholTab.Text = "ALCOHOL"
        Me.alcoholTab.UseVisualStyleBackColor = True
        '
        'alcohol1Button
        '
        Me.alcohol1Button.Location = New System.Drawing.Point(20, 20)
        Me.alcohol1Button.Name = "alcohol1Button"
        Me.alcohol1Button.Size = New System.Drawing.Size(200, 75)
        Me.alcohol1Button.TabIndex = 1
        Me.alcohol1Button.Text = "BEER"
        Me.alcohol1Button.UseVisualStyleBackColor = True
        '
        'drinksTab
        '
        Me.drinksTab.Controls.Add(Me.drink4Button)
        Me.drinksTab.Controls.Add(Me.drink3Button)
        Me.drinksTab.Controls.Add(Me.drink2Button)
        Me.drinksTab.Controls.Add(Me.drink1Button)
        Me.drinksTab.Location = New System.Drawing.Point(4, 37)
        Me.drinksTab.Name = "drinksTab"
        Me.drinksTab.Padding = New System.Windows.Forms.Padding(3)
        Me.drinksTab.Size = New System.Drawing.Size(818, 564)
        Me.drinksTab.TabIndex = 1
        Me.drinksTab.Text = "DRINKS"
        Me.drinksTab.UseVisualStyleBackColor = True
        '
        'drink4Button
        '
        Me.drink4Button.Location = New System.Drawing.Point(20, 263)
        Me.drink4Button.Name = "drink4Button"
        Me.drink4Button.Size = New System.Drawing.Size(200, 75)
        Me.drink4Button.TabIndex = 3
        Me.drink4Button.Text = "WATER"
        Me.drink4Button.UseVisualStyleBackColor = True
        '
        'drink3Button
        '
        Me.drink3Button.Location = New System.Drawing.Point(20, 182)
        Me.drink3Button.Name = "drink3Button"
        Me.drink3Button.Size = New System.Drawing.Size(200, 75)
        Me.drink3Button.TabIndex = 2
        Me.drink3Button.Text = "MILK"
        Me.drink3Button.UseVisualStyleBackColor = True
        '
        'drink2Button
        '
        Me.drink2Button.Location = New System.Drawing.Point(20, 101)
        Me.drink2Button.Name = "drink2Button"
        Me.drink2Button.Size = New System.Drawing.Size(200, 75)
        Me.drink2Button.TabIndex = 1
        Me.drink2Button.Text = "SODA"
        Me.drink2Button.UseVisualStyleBackColor = True
        '
        'drink1Button
        '
        Me.drink1Button.Location = New System.Drawing.Point(20, 20)
        Me.drink1Button.Name = "drink1Button"
        Me.drink1Button.Size = New System.Drawing.Size(200, 75)
        Me.drink1Button.TabIndex = 0
        Me.drink1Button.Text = "JUICE"
        Me.drink1Button.UseVisualStyleBackColor = True
        '
        'appTab
        '
        Me.appTab.Controls.Add(Me.app3Button)
        Me.appTab.Controls.Add(Me.app2Button)
        Me.appTab.Controls.Add(Me.app1Button)
        Me.appTab.Location = New System.Drawing.Point(4, 37)
        Me.appTab.Name = "appTab"
        Me.appTab.Size = New System.Drawing.Size(818, 564)
        Me.appTab.TabIndex = 2
        Me.appTab.Text = "APPETIZERS"
        Me.appTab.UseVisualStyleBackColor = True
        '
        'app3Button
        '
        Me.app3Button.Location = New System.Drawing.Point(20, 182)
        Me.app3Button.Name = "app3Button"
        Me.app3Button.Size = New System.Drawing.Size(200, 75)
        Me.app3Button.TabIndex = 2
        Me.app3Button.Text = "CHIPS SALSA"
        Me.app3Button.UseVisualStyleBackColor = True
        '
        'app2Button
        '
        Me.app2Button.Location = New System.Drawing.Point(20, 101)
        Me.app2Button.Name = "app2Button"
        Me.app2Button.Size = New System.Drawing.Size(200, 75)
        Me.app2Button.TabIndex = 1
        Me.app2Button.Text = "PT SKINS"
        Me.app2Button.UseVisualStyleBackColor = True
        '
        'app1Button
        '
        Me.app1Button.Location = New System.Drawing.Point(20, 20)
        Me.app1Button.Name = "app1Button"
        Me.app1Button.Size = New System.Drawing.Size(200, 75)
        Me.app1Button.TabIndex = 0
        Me.app1Button.Text = "CH FRIES"
        Me.app1Button.UseVisualStyleBackColor = True
        '
        'entreeTab
        '
        Me.entreeTab.Controls.Add(Me.entree3Button)
        Me.entreeTab.Controls.Add(Me.entree2Button)
        Me.entreeTab.Controls.Add(Me.entree1Button)
        Me.entreeTab.Location = New System.Drawing.Point(4, 37)
        Me.entreeTab.Name = "entreeTab"
        Me.entreeTab.Size = New System.Drawing.Size(818, 564)
        Me.entreeTab.TabIndex = 3
        Me.entreeTab.Text = "ENTREE'S"
        Me.entreeTab.UseVisualStyleBackColor = True
        '
        'entree3Button
        '
        Me.entree3Button.Location = New System.Drawing.Point(20, 182)
        Me.entree3Button.Name = "entree3Button"
        Me.entree3Button.Size = New System.Drawing.Size(200, 75)
        Me.entree3Button.TabIndex = 3
        Me.entree3Button.Text = "BACON CHSBRGR"
        Me.entree3Button.UseVisualStyleBackColor = True
        '
        'entree2Button
        '
        Me.entree2Button.Location = New System.Drawing.Point(20, 101)
        Me.entree2Button.Name = "entree2Button"
        Me.entree2Button.Size = New System.Drawing.Size(200, 75)
        Me.entree2Button.TabIndex = 2
        Me.entree2Button.Text = "TURKEY BLT"
        Me.entree2Button.UseVisualStyleBackColor = True
        '
        'entree1Button
        '
        Me.entree1Button.Location = New System.Drawing.Point(20, 20)
        Me.entree1Button.Name = "entree1Button"
        Me.entree1Button.Size = New System.Drawing.Size(200, 75)
        Me.entree1Button.TabIndex = 1
        Me.entree1Button.Text = "HONEY BBQ SANDWICH"
        Me.entree1Button.UseVisualStyleBackColor = True
        '
        'dessertTab
        '
        Me.dessertTab.Controls.Add(Me.dessert1Button)
        Me.dessertTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dessertTab.Location = New System.Drawing.Point(4, 37)
        Me.dessertTab.Name = "dessertTab"
        Me.dessertTab.Size = New System.Drawing.Size(818, 564)
        Me.dessertTab.TabIndex = 4
        Me.dessertTab.Text = "DESSERTS"
        Me.dessertTab.UseVisualStyleBackColor = True
        '
        'dessert1Button
        '
        Me.dessert1Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dessert1Button.Location = New System.Drawing.Point(20, 20)
        Me.dessert1Button.Name = "dessert1Button"
        Me.dessert1Button.Size = New System.Drawing.Size(200, 75)
        Me.dessert1Button.TabIndex = 1
        Me.dessert1Button.Text = "ICE CREAM"
        Me.dessert1Button.UseVisualStyleBackColor = True
        '
        'eightySixTab
        '
        Me.eightySixTab.Controls.Add(Me.onion86Button)
        Me.eightySixTab.Controls.Add(Me.tomato86Button)
        Me.eightySixTab.Controls.Add(Me.lettuce86Button)
        Me.eightySixTab.Controls.Add(Me.cheese86Button)
        Me.eightySixTab.Controls.Add(Me.bacon86Button)
        Me.eightySixTab.Location = New System.Drawing.Point(4, 37)
        Me.eightySixTab.Name = "eightySixTab"
        Me.eightySixTab.Size = New System.Drawing.Size(818, 564)
        Me.eightySixTab.TabIndex = 5
        Me.eightySixTab.Text = "86"
        Me.eightySixTab.UseVisualStyleBackColor = True
        '
        'onion86Button
        '
        Me.onion86Button.Location = New System.Drawing.Point(444, 20)
        Me.onion86Button.Name = "onion86Button"
        Me.onion86Button.Size = New System.Drawing.Size(100, 100)
        Me.onion86Button.TabIndex = 4
        Me.onion86Button.Text = "Onion"
        Me.onion86Button.UseVisualStyleBackColor = True
        '
        'tomato86Button
        '
        Me.tomato86Button.Location = New System.Drawing.Point(338, 20)
        Me.tomato86Button.Name = "tomato86Button"
        Me.tomato86Button.Size = New System.Drawing.Size(100, 100)
        Me.tomato86Button.TabIndex = 3
        Me.tomato86Button.Text = "Tomato"
        Me.tomato86Button.UseVisualStyleBackColor = True
        '
        'lettuce86Button
        '
        Me.lettuce86Button.Location = New System.Drawing.Point(232, 20)
        Me.lettuce86Button.Name = "lettuce86Button"
        Me.lettuce86Button.Size = New System.Drawing.Size(100, 100)
        Me.lettuce86Button.TabIndex = 2
        Me.lettuce86Button.Text = "Lettuce"
        Me.lettuce86Button.UseVisualStyleBackColor = True
        '
        'cheese86Button
        '
        Me.cheese86Button.Location = New System.Drawing.Point(126, 20)
        Me.cheese86Button.Name = "cheese86Button"
        Me.cheese86Button.Size = New System.Drawing.Size(100, 100)
        Me.cheese86Button.TabIndex = 1
        Me.cheese86Button.Text = "Cheese"
        Me.cheese86Button.UseVisualStyleBackColor = True
        '
        'bacon86Button
        '
        Me.bacon86Button.Location = New System.Drawing.Point(20, 20)
        Me.bacon86Button.Name = "bacon86Button"
        Me.bacon86Button.Size = New System.Drawing.Size(100, 100)
        Me.bacon86Button.TabIndex = 0
        Me.bacon86Button.Text = "Bacon"
        Me.bacon86Button.UseVisualStyleBackColor = True
        '
        'sideOfTab
        '
        Me.sideOfTab.Location = New System.Drawing.Point(4, 37)
        Me.sideOfTab.Name = "sideOfTab"
        Me.sideOfTab.Size = New System.Drawing.Size(818, 564)
        Me.sideOfTab.TabIndex = 6
        Me.sideOfTab.Text = "SIDES"
        Me.sideOfTab.UseVisualStyleBackColor = True
        '
        'submitOrderButton
        '
        Me.submitOrderButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitOrderButton.Location = New System.Drawing.Point(426, 626)
        Me.submitOrderButton.Name = "submitOrderButton"
        Me.submitOrderButton.Size = New System.Drawing.Size(826, 42)
        Me.submitOrderButton.TabIndex = 15
        Me.submitOrderButton.Text = "SUBMIT ORDER"
        Me.submitOrderButton.UseVisualStyleBackColor = True
        '
        'modifier86Button
        '
        Me.modifier86Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modifier86Button.Location = New System.Drawing.Point(322, 50)
        Me.modifier86Button.Name = "modifier86Button"
        Me.modifier86Button.Size = New System.Drawing.Size(100, 70)
        Me.modifier86Button.TabIndex = 16
        Me.modifier86Button.Text = "86"
        Me.modifier86Button.UseVisualStyleBackColor = True
        '
        'sideofModifierButton
        '
        Me.sideofModifierButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sideofModifierButton.Location = New System.Drawing.Point(322, 126)
        Me.sideofModifierButton.Name = "sideofModifierButton"
        Me.sideofModifierButton.Size = New System.Drawing.Size(100, 70)
        Me.sideofModifierButton.TabIndex = 21
        Me.sideofModifierButton.Text = "SIDE OF"
        Me.sideofModifierButton.UseVisualStyleBackColor = True
        '
        'closeTableButton
        '
        Me.closeTableButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeTableButton.Location = New System.Drawing.Point(320, 581)
        Me.closeTableButton.Name = "closeTableButton"
        Me.closeTableButton.Size = New System.Drawing.Size(100, 87)
        Me.closeTableButton.TabIndex = 23
        Me.closeTableButton.Text = "CLOSE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TABLE"
        Me.closeTableButton.UseVisualStyleBackColor = True
        '
        'tableNumLabel
        '
        Me.tableNumLabel.AutoSize = True
        Me.tableNumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableNumLabel.Location = New System.Drawing.Point(320, 12)
        Me.tableNumLabel.Name = "tableNumLabel"
        Me.tableNumLabel.Size = New System.Drawing.Size(19, 20)
        Me.tableNumLabel.TabIndex = 24
        Me.tableNumLabel.Text = "#"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 589)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 24)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Total:"
        '
        'totalTextBox
        '
        Me.totalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalTextBox.Location = New System.Drawing.Point(123, 587)
        Me.totalTextBox.Name = "totalTextBox"
        Me.totalTextBox.ReadOnly = True
        Me.totalTextBox.Size = New System.Drawing.Size(191, 26)
        Me.totalTextBox.TabIndex = 26
        Me.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'areYouSureLabel
        '
        Me.areYouSureLabel.AutoSize = True
        Me.areYouSureLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.areYouSureLabel.Location = New System.Drawing.Point(8, 638)
        Me.areYouSureLabel.Name = "areYouSureLabel"
        Me.areYouSureLabel.Size = New System.Drawing.Size(120, 20)
        Me.areYouSureLabel.TabIndex = 27
        Me.areYouSureLabel.Text = "Are you sure?"
        Me.areYouSureLabel.Visible = False
        '
        'noButton
        '
        Me.noButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noButton.Location = New System.Drawing.Point(231, 631)
        Me.noButton.Name = "noButton"
        Me.noButton.Size = New System.Drawing.Size(85, 37)
        Me.noButton.TabIndex = 28
        Me.noButton.Text = "NO"
        Me.noButton.UseVisualStyleBackColor = True
        Me.noButton.Visible = False
        '
        'yesButton
        '
        Me.yesButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yesButton.Location = New System.Drawing.Point(142, 631)
        Me.yesButton.Name = "yesButton"
        Me.yesButton.Size = New System.Drawing.Size(83, 37)
        Me.yesButton.TabIndex = 29
        Me.yesButton.Text = "YES"
        Me.yesButton.UseVisualStyleBackColor = True
        Me.yesButton.Visible = False
        '
        'waiter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 680)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.yesButton)
        Me.Controls.Add(Me.noButton)
        Me.Controls.Add(Me.areYouSureLabel)
        Me.Controls.Add(Me.totalTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tableNumLabel)
        Me.Controls.Add(Me.closeTableButton)
        Me.Controls.Add(Me.sideofModifierButton)
        Me.Controls.Add(Me.modifier86Button)
        Me.Controls.Add(Me.submitOrderButton)
        Me.Controls.Add(Me.tabControlWaiter)
        Me.Controls.Add(Me.orderTextBox)
        Me.Name = "waiter"
        Me.Text = "Waiter"
        Me.tabControlWaiter.ResumeLayout(False)
        Me.alcoholTab.ResumeLayout(False)
        Me.drinksTab.ResumeLayout(False)
        Me.appTab.ResumeLayout(False)
        Me.entreeTab.ResumeLayout(False)
        Me.dessertTab.ResumeLayout(False)
        Me.eightySixTab.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents orderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents tabControlWaiter As System.Windows.Forms.TabControl
    Friend WithEvents alcoholTab As System.Windows.Forms.TabPage
    Friend WithEvents drinksTab As System.Windows.Forms.TabPage
    Friend WithEvents appTab As System.Windows.Forms.TabPage
    Friend WithEvents entreeTab As System.Windows.Forms.TabPage
    Friend WithEvents dessertTab As System.Windows.Forms.TabPage
    Friend WithEvents submitOrderButton As System.Windows.Forms.Button
    Friend WithEvents modifier86Button As System.Windows.Forms.Button
    Friend WithEvents sideofModifierButton As System.Windows.Forms.Button
    Friend WithEvents eightySixTab As System.Windows.Forms.TabPage
    Friend WithEvents drink4Button As System.Windows.Forms.Button
    Friend WithEvents drink3Button As System.Windows.Forms.Button
    Friend WithEvents drink2Button As System.Windows.Forms.Button
    Friend WithEvents drink1Button As System.Windows.Forms.Button
    Friend WithEvents app3Button As System.Windows.Forms.Button
    Friend WithEvents app2Button As System.Windows.Forms.Button
    Friend WithEvents app1Button As System.Windows.Forms.Button
    Friend WithEvents entree2Button As System.Windows.Forms.Button
    Friend WithEvents entree1Button As System.Windows.Forms.Button
    Friend WithEvents entree3Button As System.Windows.Forms.Button
    Friend WithEvents alcohol1Button As System.Windows.Forms.Button
    Friend WithEvents dessert1Button As System.Windows.Forms.Button
    Friend WithEvents closeTableButton As System.Windows.Forms.Button
    Friend WithEvents tableNumLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents totalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents areYouSureLabel As System.Windows.Forms.Label
    Friend WithEvents noButton As System.Windows.Forms.Button
    Friend WithEvents yesButton As System.Windows.Forms.Button
    Friend WithEvents sideOfTab As System.Windows.Forms.TabPage
    Friend WithEvents onion86Button As System.Windows.Forms.Button
    Friend WithEvents tomato86Button As System.Windows.Forms.Button
    Friend WithEvents lettuce86Button As System.Windows.Forms.Button
    Friend WithEvents cheese86Button As System.Windows.Forms.Button
    Friend WithEvents bacon86Button As System.Windows.Forms.Button
End Class
