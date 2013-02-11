<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.usernameLogin = New System.Windows.Forms.TextBox()
        Me.passwordLogin = New System.Windows.Forms.TextBox()
        Me.loginSubmitButton = New System.Windows.Forms.Button()
        Me.loginStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.timeLoginStatusStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.dateLoginStatusStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.loginStatusStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 532)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Login"
        '
        'usernameLogin
        '
        Me.usernameLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameLogin.Location = New System.Drawing.Point(12, 572)
        Me.usernameLogin.Name = "usernameLogin"
        Me.usernameLogin.Size = New System.Drawing.Size(240, 38)
        Me.usernameLogin.TabIndex = 2
        '
        'passwordLogin
        '
        Me.passwordLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordLogin.Location = New System.Drawing.Point(12, 616)
        Me.passwordLogin.Name = "passwordLogin"
        Me.passwordLogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.passwordLogin.Size = New System.Drawing.Size(240, 38)
        Me.passwordLogin.TabIndex = 3
        '
        'loginSubmitButton
        '
        Me.loginSubmitButton.Location = New System.Drawing.Point(12, 660)
        Me.loginSubmitButton.Name = "loginSubmitButton"
        Me.loginSubmitButton.Size = New System.Drawing.Size(240, 45)
        Me.loginSubmitButton.TabIndex = 4
        Me.loginSubmitButton.Text = "Submit"
        Me.loginSubmitButton.UseVisualStyleBackColor = False
        '
        'loginStatusStrip
        '
        Me.loginStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dateLoginStatusStrip, Me.timeLoginStatusStrip})
        Me.loginStatusStrip.Location = New System.Drawing.Point(0, 708)
        Me.loginStatusStrip.Name = "loginStatusStrip"
        Me.loginStatusStrip.Size = New System.Drawing.Size(1350, 22)
        Me.loginStatusStrip.TabIndex = 5
        Me.loginStatusStrip.Text = "StatusStrip1"
        '
        'timeLoginStatusStrip
        '
        Me.timeLoginStatusStrip.Name = "timeLoginStatusStrip"
        Me.timeLoginStatusStrip.Size = New System.Drawing.Size(34, 17)
        Me.timeLoginStatusStrip.Text = "TIME"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.project.My.Resources.Resources.Restaurant3
        Me.PictureBox1.Location = New System.Drawing.Point(382, 156)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(575, 325)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'timer
        '
        Me.timer.Enabled = True
        Me.timer.Interval = 1000
        '
        'dateLoginStatusStrip
        '
        Me.dateLoginStatusStrip.Name = "dateLoginStatusStrip"
        Me.dateLoginStatusStrip.Size = New System.Drawing.Size(36, 17)
        Me.dateLoginStatusStrip.Text = "DATE"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 730)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.loginStatusStrip)
        Me.Controls.Add(Me.loginSubmitButton)
        Me.Controls.Add(Me.passwordLogin)
        Me.Controls.Add(Me.usernameLogin)
        Me.Controls.Add(Me.Label2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "login"
        Me.Text = "Login"
        Me.loginStatusStrip.ResumeLayout(False)
        Me.loginStatusStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents usernameLogin As System.Windows.Forms.TextBox
    Friend WithEvents passwordLogin As System.Windows.Forms.TextBox
    Friend WithEvents loginSubmitButton As System.Windows.Forms.Button
    Friend WithEvents loginStatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents timeLoginStatusStrip As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents timer As System.Windows.Forms.Timer
    Friend WithEvents dateLoginStatusStrip As System.Windows.Forms.ToolStripStatusLabel

End Class
