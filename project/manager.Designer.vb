<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manager
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.employeeTab = New System.Windows.Forms.TabPage()
        Me.inventoryTab = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.employeeTab)
        Me.TabControl1.Controls.Add(Me.inventoryTab)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(5, 5)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1257, 674)
        Me.TabControl1.TabIndex = 0
        '
        'employeeTab
        '
        Me.employeeTab.Location = New System.Drawing.Point(4, 43)
        Me.employeeTab.Margin = New System.Windows.Forms.Padding(6)
        Me.employeeTab.Name = "employeeTab"
        Me.employeeTab.Padding = New System.Windows.Forms.Padding(6)
        Me.employeeTab.Size = New System.Drawing.Size(1249, 627)
        Me.employeeTab.TabIndex = 0
        Me.employeeTab.Text = "EMPLOYEES"
        Me.employeeTab.UseVisualStyleBackColor = True
        '
        'inventoryTab
        '
        Me.inventoryTab.Location = New System.Drawing.Point(4, 43)
        Me.inventoryTab.Margin = New System.Windows.Forms.Padding(6)
        Me.inventoryTab.Name = "inventoryTab"
        Me.inventoryTab.Padding = New System.Windows.Forms.Padding(6)
        Me.inventoryTab.Size = New System.Drawing.Size(1312, 653)
        Me.inventoryTab.TabIndex = 1
        Me.inventoryTab.Text = "INVENTORY"
        Me.inventoryTab.UseVisualStyleBackColor = True
        '
        'manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 680)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "manager"
        Me.Text = "manager"
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents employeeTab As System.Windows.Forms.TabPage
    Friend WithEvents inventoryTab As System.Windows.Forms.TabPage
End Class
