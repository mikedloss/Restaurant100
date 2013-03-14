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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.usernameLogin = New System.Windows.Forms.TextBox()
        Me.passwordLogin = New System.Windows.Forms.TextBox()
        Me.loginSubmitButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.dateLoginLabel = New System.Windows.Forms.Label()
        Me.timeLoginLabel = New System.Windows.Forms.Label()
        Me.login1KeyButton = New System.Windows.Forms.Button()
        Me.login2KeyButton = New System.Windows.Forms.Button()
        Me.login3KeyButton = New System.Windows.Forms.Button()
        Me.login4KeyButton = New System.Windows.Forms.Button()
        Me.login5KeyButton = New System.Windows.Forms.Button()
        Me.login6KeyButton = New System.Windows.Forms.Button()
        Me.login7KeyButton = New System.Windows.Forms.Button()
        Me.login8KeyButton = New System.Windows.Forms.Button()
        Me.login9KeyButton = New System.Windows.Forms.Button()
        Me.login0KeyButton = New System.Windows.Forms.Button()
        Me.loginClearButton = New System.Windows.Forms.Button()
        Me.errorLabel = New System.Windows.Forms.Label()
        Me.xMarkPicture = New System.Windows.Forms.PictureBox()
        Me.checkmarkPicture = New System.Windows.Forms.PictureBox()
        Me.statusLabel = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.reconnectButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xMarkPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkmarkPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 502)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Login"
        '
        'usernameLogin
        '
        Me.usernameLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameLogin.Location = New System.Drawing.Point(12, 542)
        Me.usernameLogin.MaxLength = 4
        Me.usernameLogin.Name = "usernameLogin"
        Me.usernameLogin.Size = New System.Drawing.Size(486, 38)
        Me.usernameLogin.TabIndex = 2
        '
        'passwordLogin
        '
        Me.passwordLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordLogin.Location = New System.Drawing.Point(12, 586)
        Me.passwordLogin.MaxLength = 4
        Me.passwordLogin.Name = "passwordLogin"
        Me.passwordLogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordLogin.Size = New System.Drawing.Size(486, 38)
        Me.passwordLogin.TabIndex = 3
        '
        'loginSubmitButton
        '
        Me.loginSubmitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginSubmitButton.Location = New System.Drawing.Point(12, 630)
        Me.loginSubmitButton.Name = "loginSubmitButton"
        Me.loginSubmitButton.Size = New System.Drawing.Size(240, 45)
        Me.loginSubmitButton.TabIndex = 4
        Me.loginSubmitButton.Text = "SUBMIT"
        Me.loginSubmitButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.project.My.Resources.Resources.Restaurant3
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
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
        'dateLoginLabel
        '
        Me.dateLoginLabel.AutoSize = True
        Me.dateLoginLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateLoginLabel.Location = New System.Drawing.Point(-1, 328)
        Me.dateLoginLabel.Name = "dateLoginLabel"
        Me.dateLoginLabel.Size = New System.Drawing.Size(203, 73)
        Me.dateLoginLabel.TabIndex = 7
        Me.dateLoginLabel.Text = "DATE"
        '
        'timeLoginLabel
        '
        Me.timeLoginLabel.AutoSize = True
        Me.timeLoginLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeLoginLabel.Location = New System.Drawing.Point(-1, 392)
        Me.timeLoginLabel.Name = "timeLoginLabel"
        Me.timeLoginLabel.Size = New System.Drawing.Size(185, 73)
        Me.timeLoginLabel.TabIndex = 8
        Me.timeLoginLabel.Text = "TIME"
        '
        'login1KeyButton
        '
        Me.login1KeyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login1KeyButton.Location = New System.Drawing.Point(754, 6)
        Me.login1KeyButton.Name = "login1KeyButton"
        Me.login1KeyButton.Size = New System.Drawing.Size(150, 150)
        Me.login1KeyButton.TabIndex = 9
        Me.login1KeyButton.Text = "1"
        Me.login1KeyButton.UseVisualStyleBackColor = False
        '
        'login2KeyButton
        '
        Me.login2KeyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login2KeyButton.Location = New System.Drawing.Point(929, 6)
        Me.login2KeyButton.Name = "login2KeyButton"
        Me.login2KeyButton.Size = New System.Drawing.Size(150, 150)
        Me.login2KeyButton.TabIndex = 10
        Me.login2KeyButton.Text = "2"
        Me.login2KeyButton.UseVisualStyleBackColor = False
        '
        'login3KeyButton
        '
        Me.login3KeyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login3KeyButton.Location = New System.Drawing.Point(1104, 6)
        Me.login3KeyButton.Name = "login3KeyButton"
        Me.login3KeyButton.Size = New System.Drawing.Size(150, 150)
        Me.login3KeyButton.TabIndex = 11
        Me.login3KeyButton.Text = "3"
        Me.login3KeyButton.UseVisualStyleBackColor = False
        '
        'login4KeyButton
        '
        Me.login4KeyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login4KeyButton.Location = New System.Drawing.Point(754, 181)
        Me.login4KeyButton.Name = "login4KeyButton"
        Me.login4KeyButton.Size = New System.Drawing.Size(150, 150)
        Me.login4KeyButton.TabIndex = 12
        Me.login4KeyButton.Text = "4"
        Me.login4KeyButton.UseVisualStyleBackColor = False
        '
        'login5KeyButton
        '
        Me.login5KeyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login5KeyButton.Location = New System.Drawing.Point(929, 181)
        Me.login5KeyButton.Name = "login5KeyButton"
        Me.login5KeyButton.Size = New System.Drawing.Size(150, 150)
        Me.login5KeyButton.TabIndex = 13
        Me.login5KeyButton.Text = "5"
        Me.login5KeyButton.UseVisualStyleBackColor = False
        '
        'login6KeyButton
        '
        Me.login6KeyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login6KeyButton.Location = New System.Drawing.Point(1104, 181)
        Me.login6KeyButton.Name = "login6KeyButton"
        Me.login6KeyButton.Size = New System.Drawing.Size(150, 150)
        Me.login6KeyButton.TabIndex = 14
        Me.login6KeyButton.Text = "6"
        Me.login6KeyButton.UseVisualStyleBackColor = False
        '
        'login7KeyButton
        '
        Me.login7KeyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login7KeyButton.Location = New System.Drawing.Point(754, 351)
        Me.login7KeyButton.Name = "login7KeyButton"
        Me.login7KeyButton.Size = New System.Drawing.Size(150, 150)
        Me.login7KeyButton.TabIndex = 15
        Me.login7KeyButton.Text = "7"
        Me.login7KeyButton.UseVisualStyleBackColor = False
        '
        'login8KeyButton
        '
        Me.login8KeyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login8KeyButton.Location = New System.Drawing.Point(929, 351)
        Me.login8KeyButton.Name = "login8KeyButton"
        Me.login8KeyButton.Size = New System.Drawing.Size(150, 150)
        Me.login8KeyButton.TabIndex = 16
        Me.login8KeyButton.Text = "8"
        Me.login8KeyButton.UseVisualStyleBackColor = False
        '
        'login9KeyButton
        '
        Me.login9KeyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login9KeyButton.Location = New System.Drawing.Point(1104, 351)
        Me.login9KeyButton.Name = "login9KeyButton"
        Me.login9KeyButton.Size = New System.Drawing.Size(150, 150)
        Me.login9KeyButton.TabIndex = 17
        Me.login9KeyButton.Text = "9"
        Me.login9KeyButton.UseVisualStyleBackColor = False
        '
        'login0KeyButton
        '
        Me.login0KeyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login0KeyButton.Location = New System.Drawing.Point(929, 526)
        Me.login0KeyButton.Name = "login0KeyButton"
        Me.login0KeyButton.Size = New System.Drawing.Size(150, 150)
        Me.login0KeyButton.TabIndex = 18
        Me.login0KeyButton.Text = "0"
        Me.login0KeyButton.UseVisualStyleBackColor = False
        '
        'loginClearButton
        '
        Me.loginClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginClearButton.Location = New System.Drawing.Point(258, 630)
        Me.loginClearButton.Name = "loginClearButton"
        Me.loginClearButton.Size = New System.Drawing.Size(240, 45)
        Me.loginClearButton.TabIndex = 19
        Me.loginClearButton.Text = "CLEAR"
        Me.loginClearButton.UseVisualStyleBackColor = False
        '
        'errorLabel
        '
        Me.errorLabel.AutoSize = True
        Me.errorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errorLabel.ForeColor = System.Drawing.Color.Firebrick
        Me.errorLabel.Location = New System.Drawing.Point(134, 505)
        Me.errorLabel.Name = "errorLabel"
        Me.errorLabel.Size = New System.Drawing.Size(118, 31)
        Me.errorLabel.TabIndex = 20
        Me.errorLabel.Text = "ERROR"
        Me.errorLabel.Visible = False
        '
        'xMarkPicture
        '
        Me.xMarkPicture.Image = CType(resources.GetObject("xMarkPicture.Image"), System.Drawing.Image)
        Me.xMarkPicture.Location = New System.Drawing.Point(504, 647)
        Me.xMarkPicture.Name = "xMarkPicture"
        Me.xMarkPicture.Size = New System.Drawing.Size(28, 28)
        Me.xMarkPicture.TabIndex = 21
        Me.xMarkPicture.TabStop = False
        '
        'checkmarkPicture
        '
        Me.checkmarkPicture.Image = CType(resources.GetObject("checkmarkPicture.Image"), System.Drawing.Image)
        Me.checkmarkPicture.Location = New System.Drawing.Point(504, 647)
        Me.checkmarkPicture.Name = "checkmarkPicture"
        Me.checkmarkPicture.Size = New System.Drawing.Size(28, 28)
        Me.checkmarkPicture.TabIndex = 22
        Me.checkmarkPicture.TabStop = False
        Me.checkmarkPicture.Visible = False
        '
        'statusLabel
        '
        Me.statusLabel.AutoSize = True
        Me.statusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusLabel.Location = New System.Drawing.Point(538, 655)
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(59, 20)
        Me.statusLabel.TabIndex = 23
        Me.statusLabel.Text = "status"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(299, 167)
        Me.TabControl1.TabIndex = 24
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(291, 141)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(-1, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(568, 299)
        Me.DataGridView1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(504, 655)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(276, 20)
        Me.TextBox1.TabIndex = 25
        Me.TextBox1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(504, 639)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "for debugging"
        Me.Label1.Visible = False
        '
        'reconnectButton
        '
        Me.reconnectButton.Location = New System.Drawing.Point(538, 630)
        Me.reconnectButton.Name = "reconnectButton"
        Me.reconnectButton.Size = New System.Drawing.Size(75, 23)
        Me.reconnectButton.TabIndex = 27
        Me.reconnectButton.Text = "reconnect"
        Me.reconnectButton.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 680)
        Me.Controls.Add(Me.reconnectButton)
        Me.Controls.Add(Me.statusLabel)
        Me.Controls.Add(Me.checkmarkPicture)
        Me.Controls.Add(Me.xMarkPicture)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.errorLabel)
        Me.Controls.Add(Me.loginClearButton)
        Me.Controls.Add(Me.login0KeyButton)
        Me.Controls.Add(Me.login9KeyButton)
        Me.Controls.Add(Me.login8KeyButton)
        Me.Controls.Add(Me.login7KeyButton)
        Me.Controls.Add(Me.login6KeyButton)
        Me.Controls.Add(Me.login5KeyButton)
        Me.Controls.Add(Me.login4KeyButton)
        Me.Controls.Add(Me.login3KeyButton)
        Me.Controls.Add(Me.login2KeyButton)
        Me.Controls.Add(Me.login1KeyButton)
        Me.Controls.Add(Me.timeLoginLabel)
        Me.Controls.Add(Me.dateLoginLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.loginSubmitButton)
        Me.Controls.Add(Me.passwordLogin)
        Me.Controls.Add(Me.usernameLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TabControl1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xMarkPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkmarkPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents usernameLogin As System.Windows.Forms.TextBox
    Friend WithEvents passwordLogin As System.Windows.Forms.TextBox
    Friend WithEvents loginSubmitButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents timer As System.Windows.Forms.Timer
    Friend WithEvents dateLoginLabel As System.Windows.Forms.Label
    Friend WithEvents timeLoginLabel As System.Windows.Forms.Label
    Friend WithEvents login1KeyButton As System.Windows.Forms.Button
    Friend WithEvents login2KeyButton As System.Windows.Forms.Button
    Friend WithEvents login3KeyButton As System.Windows.Forms.Button
    Friend WithEvents login4KeyButton As System.Windows.Forms.Button
    Friend WithEvents login5KeyButton As System.Windows.Forms.Button
    Friend WithEvents login6KeyButton As System.Windows.Forms.Button
    Friend WithEvents login7KeyButton As System.Windows.Forms.Button
    Friend WithEvents login8KeyButton As System.Windows.Forms.Button
    Friend WithEvents login9KeyButton As System.Windows.Forms.Button
    Friend WithEvents login0KeyButton As System.Windows.Forms.Button
    Friend WithEvents loginClearButton As System.Windows.Forms.Button
    Friend WithEvents errorLabel As System.Windows.Forms.Label
    Friend WithEvents xMarkPicture As System.Windows.Forms.PictureBox
    Friend WithEvents checkmarkPicture As System.Windows.Forms.PictureBox
    Friend WithEvents statusLabel As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents reconnectButton As System.Windows.Forms.Button

End Class
