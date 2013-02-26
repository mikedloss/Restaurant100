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
        Me.drinksTab = New System.Windows.Forms.TabPage()
        Me.waterDrinkButton = New System.Windows.Forms.Button()
        Me.milkDrinkButton = New System.Windows.Forms.Button()
        Me.sodaDrinkButton = New System.Windows.Forms.Button()
        Me.juiceDrinkButton = New System.Windows.Forms.Button()
        Me.cheeseFriesAppButton = New System.Windows.Forms.TabPage()
        Me.Splitter2 = New System.Windows.Forms.Splitter()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.bonelessAppButton = New System.Windows.Forms.Button()
        Me.wingsAppButton = New System.Windows.Forms.Button()
        Me.samplerAppButton = New System.Windows.Forms.Button()
        Me.mozStixAppButton = New System.Windows.Forms.Button()
        Me.chipsAppButton = New System.Windows.Forms.Button()
        Me.potatoSkinsAppButton = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.entreeTab = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dessertTab = New System.Windows.Forms.TabPage()
        Me.extrasTab = New System.Windows.Forms.TabPage()
        Me.submitOrderButton = New System.Windows.Forms.Button()
        Me.modifier86Button = New System.Windows.Forms.Button()
        Me.addModifierButton = New System.Windows.Forms.Button()
        Me.lightModifierButton = New System.Windows.Forms.Button()
        Me.crispyModifierButton = New System.Windows.Forms.Button()
        Me.onsideModifierButton = New System.Windows.Forms.Button()
        Me.sideofModifierButton = New System.Windows.Forms.Button()
        Me.extraModifierButton = New System.Windows.Forms.Button()
        Me.tabControlWaiter.SuspendLayout()
        Me.drinksTab.SuspendLayout()
        Me.cheeseFriesAppButton.SuspendLayout()
        Me.entreeTab.SuspendLayout()
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
        '
        'clearButton
        '
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(12, 676)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(282, 42)
        Me.clearButton.TabIndex = 13
        Me.clearButton.Text = "CLEAR"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'tabControlWaiter
        '
        Me.tabControlWaiter.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabControlWaiter.Controls.Add(Me.alcoholTab)
        Me.tabControlWaiter.Controls.Add(Me.drinksTab)
        Me.tabControlWaiter.Controls.Add(Me.cheeseFriesAppButton)
        Me.tabControlWaiter.Controls.Add(Me.entreeTab)
        Me.tabControlWaiter.Controls.Add(Me.dessertTab)
        Me.tabControlWaiter.Controls.Add(Me.extrasTab)
        Me.tabControlWaiter.Cursor = System.Windows.Forms.Cursors.Default
        Me.tabControlWaiter.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabControlWaiter.HotTrack = True
        Me.tabControlWaiter.Location = New System.Drawing.Point(422, 12)
        Me.tabControlWaiter.Multiline = True
        Me.tabControlWaiter.Name = "tabControlWaiter"
        Me.tabControlWaiter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tabControlWaiter.SelectedIndex = 0
        Me.tabControlWaiter.Size = New System.Drawing.Size(924, 658)
        Me.tabControlWaiter.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.tabControlWaiter.TabIndex = 14
        '
        'alcoholTab
        '
        Me.alcoholTab.Location = New System.Drawing.Point(4, 43)
        Me.alcoholTab.Name = "alcoholTab"
        Me.alcoholTab.Padding = New System.Windows.Forms.Padding(3)
        Me.alcoholTab.Size = New System.Drawing.Size(916, 611)
        Me.alcoholTab.TabIndex = 0
        Me.alcoholTab.Text = "ALCOHOL"
        Me.alcoholTab.UseVisualStyleBackColor = True
        '
        'drinksTab
        '
        Me.drinksTab.Controls.Add(Me.waterDrinkButton)
        Me.drinksTab.Controls.Add(Me.milkDrinkButton)
        Me.drinksTab.Controls.Add(Me.sodaDrinkButton)
        Me.drinksTab.Controls.Add(Me.juiceDrinkButton)
        Me.drinksTab.Location = New System.Drawing.Point(4, 43)
        Me.drinksTab.Name = "drinksTab"
        Me.drinksTab.Padding = New System.Windows.Forms.Padding(3)
        Me.drinksTab.Size = New System.Drawing.Size(916, 611)
        Me.drinksTab.TabIndex = 1
        Me.drinksTab.Text = "DRINKS"
        Me.drinksTab.UseVisualStyleBackColor = True
        '
        'waterDrinkButton
        '
        Me.waterDrinkButton.Location = New System.Drawing.Point(20, 263)
        Me.waterDrinkButton.Name = "waterDrinkButton"
        Me.waterDrinkButton.Size = New System.Drawing.Size(200, 75)
        Me.waterDrinkButton.TabIndex = 3
        Me.waterDrinkButton.Text = "WATER"
        Me.waterDrinkButton.UseVisualStyleBackColor = True
        '
        'milkDrinkButton
        '
        Me.milkDrinkButton.Location = New System.Drawing.Point(20, 182)
        Me.milkDrinkButton.Name = "milkDrinkButton"
        Me.milkDrinkButton.Size = New System.Drawing.Size(200, 75)
        Me.milkDrinkButton.TabIndex = 2
        Me.milkDrinkButton.Text = "MILK"
        Me.milkDrinkButton.UseVisualStyleBackColor = True
        '
        'sodaDrinkButton
        '
        Me.sodaDrinkButton.Location = New System.Drawing.Point(20, 101)
        Me.sodaDrinkButton.Name = "sodaDrinkButton"
        Me.sodaDrinkButton.Size = New System.Drawing.Size(200, 75)
        Me.sodaDrinkButton.TabIndex = 1
        Me.sodaDrinkButton.Text = "SODA"
        Me.sodaDrinkButton.UseVisualStyleBackColor = True
        '
        'juiceDrinkButton
        '
        Me.juiceDrinkButton.Location = New System.Drawing.Point(20, 20)
        Me.juiceDrinkButton.Name = "juiceDrinkButton"
        Me.juiceDrinkButton.Size = New System.Drawing.Size(200, 75)
        Me.juiceDrinkButton.TabIndex = 0
        Me.juiceDrinkButton.Text = "JUICE"
        Me.juiceDrinkButton.UseVisualStyleBackColor = True
        '
        'cheeseFriesAppButton
        '
        Me.cheeseFriesAppButton.Controls.Add(Me.Splitter2)
        Me.cheeseFriesAppButton.Controls.Add(Me.Splitter1)
        Me.cheeseFriesAppButton.Controls.Add(Me.bonelessAppButton)
        Me.cheeseFriesAppButton.Controls.Add(Me.wingsAppButton)
        Me.cheeseFriesAppButton.Controls.Add(Me.samplerAppButton)
        Me.cheeseFriesAppButton.Controls.Add(Me.mozStixAppButton)
        Me.cheeseFriesAppButton.Controls.Add(Me.chipsAppButton)
        Me.cheeseFriesAppButton.Controls.Add(Me.potatoSkinsAppButton)
        Me.cheeseFriesAppButton.Controls.Add(Me.Button5)
        Me.cheeseFriesAppButton.Location = New System.Drawing.Point(4, 43)
        Me.cheeseFriesAppButton.Name = "cheeseFriesAppButton"
        Me.cheeseFriesAppButton.Size = New System.Drawing.Size(916, 611)
        Me.cheeseFriesAppButton.TabIndex = 2
        Me.cheeseFriesAppButton.Text = "APPETIZERS"
        Me.cheeseFriesAppButton.UseVisualStyleBackColor = True
        '
        'Splitter2
        '
        Me.Splitter2.Location = New System.Drawing.Point(3, 0)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(3, 611)
        Me.Splitter2.TabIndex = 8
        Me.Splitter2.TabStop = False
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 611)
        Me.Splitter1.TabIndex = 7
        Me.Splitter1.TabStop = False
        '
        'bonelessAppButton
        '
        Me.bonelessAppButton.Location = New System.Drawing.Point(20, 506)
        Me.bonelessAppButton.Name = "bonelessAppButton"
        Me.bonelessAppButton.Size = New System.Drawing.Size(200, 75)
        Me.bonelessAppButton.TabIndex = 6
        Me.bonelessAppButton.Text = "B-LESS WINGS"
        Me.bonelessAppButton.UseVisualStyleBackColor = True
        '
        'wingsAppButton
        '
        Me.wingsAppButton.Location = New System.Drawing.Point(20, 425)
        Me.wingsAppButton.Name = "wingsAppButton"
        Me.wingsAppButton.Size = New System.Drawing.Size(200, 75)
        Me.wingsAppButton.TabIndex = 5
        Me.wingsAppButton.Text = "BONE WINGS"
        Me.wingsAppButton.UseVisualStyleBackColor = True
        '
        'samplerAppButton
        '
        Me.samplerAppButton.Location = New System.Drawing.Point(20, 344)
        Me.samplerAppButton.Name = "samplerAppButton"
        Me.samplerAppButton.Size = New System.Drawing.Size(200, 75)
        Me.samplerAppButton.TabIndex = 4
        Me.samplerAppButton.Text = "SAMPLER"
        Me.samplerAppButton.UseVisualStyleBackColor = True
        '
        'mozStixAppButton
        '
        Me.mozStixAppButton.Location = New System.Drawing.Point(20, 263)
        Me.mozStixAppButton.Name = "mozStixAppButton"
        Me.mozStixAppButton.Size = New System.Drawing.Size(200, 75)
        Me.mozStixAppButton.TabIndex = 3
        Me.mozStixAppButton.Text = "MOZ STIX"
        Me.mozStixAppButton.UseVisualStyleBackColor = True
        '
        'chipsAppButton
        '
        Me.chipsAppButton.Location = New System.Drawing.Point(20, 182)
        Me.chipsAppButton.Name = "chipsAppButton"
        Me.chipsAppButton.Size = New System.Drawing.Size(200, 75)
        Me.chipsAppButton.TabIndex = 2
        Me.chipsAppButton.Text = "CHIPS SALSA"
        Me.chipsAppButton.UseVisualStyleBackColor = True
        '
        'potatoSkinsAppButton
        '
        Me.potatoSkinsAppButton.Location = New System.Drawing.Point(20, 101)
        Me.potatoSkinsAppButton.Name = "potatoSkinsAppButton"
        Me.potatoSkinsAppButton.Size = New System.Drawing.Size(200, 75)
        Me.potatoSkinsAppButton.TabIndex = 1
        Me.potatoSkinsAppButton.Text = "PT SKINS"
        Me.potatoSkinsAppButton.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(20, 20)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(200, 75)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "CH FRIES"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'entreeTab
        '
        Me.entreeTab.Controls.Add(Me.Button3)
        Me.entreeTab.Controls.Add(Me.Button2)
        Me.entreeTab.Controls.Add(Me.Button1)
        Me.entreeTab.Location = New System.Drawing.Point(4, 43)
        Me.entreeTab.Name = "entreeTab"
        Me.entreeTab.Size = New System.Drawing.Size(916, 611)
        Me.entreeTab.TabIndex = 3
        Me.entreeTab.Text = "ENTREE'S"
        Me.entreeTab.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(20, 182)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(200, 75)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "BACON CHSBRGR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(20, 101)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 75)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "TURKEY BLT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(20, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 75)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "HONEY BBQ SANDWICH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dessertTab
        '
        Me.dessertTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dessertTab.Location = New System.Drawing.Point(4, 43)
        Me.dessertTab.Name = "dessertTab"
        Me.dessertTab.Size = New System.Drawing.Size(916, 611)
        Me.dessertTab.TabIndex = 4
        Me.dessertTab.Text = "DESSERTS"
        Me.dessertTab.UseVisualStyleBackColor = True
        '
        'extrasTab
        '
        Me.extrasTab.Location = New System.Drawing.Point(4, 43)
        Me.extrasTab.Name = "extrasTab"
        Me.extrasTab.Size = New System.Drawing.Size(916, 611)
        Me.extrasTab.TabIndex = 5
        Me.extrasTab.Text = "EXTRAS"
        Me.extrasTab.UseVisualStyleBackColor = True
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
        'addModifierButton
        '
        Me.addModifierButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addModifierButton.Location = New System.Drawing.Point(310, 130)
        Me.addModifierButton.Name = "addModifierButton"
        Me.addModifierButton.Size = New System.Drawing.Size(100, 70)
        Me.addModifierButton.TabIndex = 17
        Me.addModifierButton.Text = "ADD"
        Me.addModifierButton.UseVisualStyleBackColor = True
        '
        'lightModifierButton
        '
        Me.lightModifierButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lightModifierButton.Location = New System.Drawing.Point(310, 213)
        Me.lightModifierButton.Name = "lightModifierButton"
        Me.lightModifierButton.Size = New System.Drawing.Size(100, 70)
        Me.lightModifierButton.TabIndex = 18
        Me.lightModifierButton.Text = "LIGHT"
        Me.lightModifierButton.UseVisualStyleBackColor = True
        '
        'crispyModifierButton
        '
        Me.crispyModifierButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crispyModifierButton.Location = New System.Drawing.Point(310, 298)
        Me.crispyModifierButton.Name = "crispyModifierButton"
        Me.crispyModifierButton.Size = New System.Drawing.Size(100, 70)
        Me.crispyModifierButton.TabIndex = 19
        Me.crispyModifierButton.Text = "CRISPY"
        Me.crispyModifierButton.UseVisualStyleBackColor = True
        '
        'onsideModifierButton
        '
        Me.onsideModifierButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.onsideModifierButton.Location = New System.Drawing.Point(310, 385)
        Me.onsideModifierButton.Name = "onsideModifierButton"
        Me.onsideModifierButton.Size = New System.Drawing.Size(100, 70)
        Me.onsideModifierButton.TabIndex = 20
        Me.onsideModifierButton.Text = "ON SIDE"
        Me.onsideModifierButton.UseVisualStyleBackColor = True
        '
        'sideofModifierButton
        '
        Me.sideofModifierButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sideofModifierButton.Location = New System.Drawing.Point(310, 471)
        Me.sideofModifierButton.Name = "sideofModifierButton"
        Me.sideofModifierButton.Size = New System.Drawing.Size(100, 70)
        Me.sideofModifierButton.TabIndex = 21
        Me.sideofModifierButton.Text = "SIDE OF"
        Me.sideofModifierButton.UseVisualStyleBackColor = True
        '
        'extraModifierButton
        '
        Me.extraModifierButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.extraModifierButton.Location = New System.Drawing.Point(310, 558)
        Me.extraModifierButton.Name = "extraModifierButton"
        Me.extraModifierButton.Size = New System.Drawing.Size(100, 70)
        Me.extraModifierButton.TabIndex = 22
        Me.extraModifierButton.Text = "EXTRA"
        Me.extraModifierButton.UseVisualStyleBackColor = True
        '
        'waiter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 730)
        Me.Controls.Add(Me.extraModifierButton)
        Me.Controls.Add(Me.sideofModifierButton)
        Me.Controls.Add(Me.onsideModifierButton)
        Me.Controls.Add(Me.crispyModifierButton)
        Me.Controls.Add(Me.lightModifierButton)
        Me.Controls.Add(Me.addModifierButton)
        Me.Controls.Add(Me.modifier86Button)
        Me.Controls.Add(Me.submitOrderButton)
        Me.Controls.Add(Me.tabControlWaiter)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.orderTextBox)
        Me.Name = "waiter"
        Me.Text = "Waiter"
        Me.tabControlWaiter.ResumeLayout(False)
        Me.drinksTab.ResumeLayout(False)
        Me.cheeseFriesAppButton.ResumeLayout(False)
        Me.entreeTab.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents orderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents tabControlWaiter As System.Windows.Forms.TabControl
    Friend WithEvents alcoholTab As System.Windows.Forms.TabPage
    Friend WithEvents drinksTab As System.Windows.Forms.TabPage
    Friend WithEvents cheeseFriesAppButton As System.Windows.Forms.TabPage
    Friend WithEvents entreeTab As System.Windows.Forms.TabPage
    Friend WithEvents dessertTab As System.Windows.Forms.TabPage
    Friend WithEvents submitOrderButton As System.Windows.Forms.Button
    Friend WithEvents modifier86Button As System.Windows.Forms.Button
    Friend WithEvents addModifierButton As System.Windows.Forms.Button
    Friend WithEvents lightModifierButton As System.Windows.Forms.Button
    Friend WithEvents crispyModifierButton As System.Windows.Forms.Button
    Friend WithEvents onsideModifierButton As System.Windows.Forms.Button
    Friend WithEvents sideofModifierButton As System.Windows.Forms.Button
    Friend WithEvents extraModifierButton As System.Windows.Forms.Button
    Friend WithEvents extrasTab As System.Windows.Forms.TabPage
    Friend WithEvents waterDrinkButton As System.Windows.Forms.Button
    Friend WithEvents milkDrinkButton As System.Windows.Forms.Button
    Friend WithEvents sodaDrinkButton As System.Windows.Forms.Button
    Friend WithEvents juiceDrinkButton As System.Windows.Forms.Button
    Friend WithEvents samplerAppButton As System.Windows.Forms.Button
    Friend WithEvents mozStixAppButton As System.Windows.Forms.Button
    Friend WithEvents chipsAppButton As System.Windows.Forms.Button
    Friend WithEvents potatoSkinsAppButton As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents bonelessAppButton As System.Windows.Forms.Button
    Friend WithEvents wingsAppButton As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
