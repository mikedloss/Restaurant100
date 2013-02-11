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
        Me.tabControlWaiter.SuspendLayout()
        Me.SuspendLayout()
        '
        'orderTextBox
        '
        Me.orderTextBox.Location = New System.Drawing.Point(0, -1)
        Me.orderTextBox.Multiline = True
        Me.orderTextBox.Name = "orderTextBox"
        Me.orderTextBox.Size = New System.Drawing.Size(187, 723)
        Me.orderTextBox.TabIndex = 0
        '
        'Button13
        '
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(0, 721)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(187, 42)
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
        Me.tabControlWaiter.Location = New System.Drawing.Point(193, 12)
        Me.tabControlWaiter.Multiline = True
        Me.tabControlWaiter.Name = "tabControlWaiter"
        Me.tabControlWaiter.SelectedIndex = 0
        Me.tabControlWaiter.Size = New System.Drawing.Size(589, 710)
        Me.tabControlWaiter.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabControlWaiter.TabIndex = 14
        '
        'alcoholTab
        '
        Me.alcoholTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.alcoholTab.Location = New System.Drawing.Point(4, 30)
        Me.alcoholTab.Name = "alcoholTab"
        Me.alcoholTab.Padding = New System.Windows.Forms.Padding(3)
        Me.alcoholTab.Size = New System.Drawing.Size(581, 676)
        Me.alcoholTab.TabIndex = 0
        Me.alcoholTab.Text = "ALCOHOL"
        Me.alcoholTab.UseVisualStyleBackColor = True
        '
        'drinksTab
        '
        Me.drinksTab.Location = New System.Drawing.Point(4, 30)
        Me.drinksTab.Name = "drinksTab"
        Me.drinksTab.Padding = New System.Windows.Forms.Padding(3)
        Me.drinksTab.Size = New System.Drawing.Size(581, 676)
        Me.drinksTab.TabIndex = 1
        Me.drinksTab.Text = "DRINKS"
        Me.drinksTab.UseVisualStyleBackColor = True
        '
        'appetizerTab
        '
        Me.appetizerTab.Location = New System.Drawing.Point(4, 30)
        Me.appetizerTab.Name = "appetizerTab"
        Me.appetizerTab.Size = New System.Drawing.Size(581, 676)
        Me.appetizerTab.TabIndex = 2
        Me.appetizerTab.Text = "APPETIZERS"
        Me.appetizerTab.UseVisualStyleBackColor = True
        '
        'entreeTab
        '
        Me.entreeTab.Location = New System.Drawing.Point(4, 30)
        Me.entreeTab.Name = "entreeTab"
        Me.entreeTab.Size = New System.Drawing.Size(581, 676)
        Me.entreeTab.TabIndex = 3
        Me.entreeTab.Text = "ENTREE'S"
        Me.entreeTab.UseVisualStyleBackColor = True
        '
        'dessertTab
        '
        Me.dessertTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dessertTab.Location = New System.Drawing.Point(4, 30)
        Me.dessertTab.Name = "dessertTab"
        Me.dessertTab.Size = New System.Drawing.Size(581, 676)
        Me.dessertTab.TabIndex = 4
        Me.dessertTab.Text = "DESSERTS"
        Me.dessertTab.UseVisualStyleBackColor = True
        '
        'submitOrderButton
        '
        Me.submitOrderButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitOrderButton.Location = New System.Drawing.Point(197, 721)
        Me.submitOrderButton.Name = "submitOrderButton"
        Me.submitOrderButton.Size = New System.Drawing.Size(585, 42)
        Me.submitOrderButton.TabIndex = 15
        Me.submitOrderButton.Text = "SUBMIT ORDER"
        Me.submitOrderButton.UseVisualStyleBackColor = True
        '
        'waiter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 762)
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
End Class
