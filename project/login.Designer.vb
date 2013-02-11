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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.usernameLogin = New System.Windows.Forms.TextBox()
        Me.passwordLogin = New System.Windows.Forms.TextBox()
        Me.loginSubmitButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(274, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Restaurant100"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(274, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Login"
        '
        'usernameLogin
        '
        Me.usernameLogin.Location = New System.Drawing.Point(277, 268)
        Me.usernameLogin.Name = "usernameLogin"
        Me.usernameLogin.Size = New System.Drawing.Size(240, 20)
        Me.usernameLogin.TabIndex = 2
        '
        'passwordLogin
        '
        Me.passwordLogin.Location = New System.Drawing.Point(277, 294)
        Me.passwordLogin.Name = "passwordLogin"
        Me.passwordLogin.Size = New System.Drawing.Size(240, 20)
        Me.passwordLogin.TabIndex = 3
        '
        'loginSubmitButton
        '
        Me.loginSubmitButton.Location = New System.Drawing.Point(277, 320)
        Me.loginSubmitButton.Name = "loginSubmitButton"
        Me.loginSubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.loginSubmitButton.TabIndex = 4
        Me.loginSubmitButton.Text = "Submit"
        Me.loginSubmitButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.Location = New System.Drawing.Point(277, 157)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.loginSubmitButton)
        Me.Controls.Add(Me.passwordLogin)
        Me.Controls.Add(Me.usernameLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents usernameLogin As System.Windows.Forms.TextBox
    Friend WithEvents passwordLogin As System.Windows.Forms.TextBox
    Friend WithEvents loginSubmitButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
