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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.employeeTab = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.editEmployeeButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.errorPasswordLabel = New System.Windows.Forms.Label()
        Me.errorUsernameLabel = New System.Windows.Forms.Label()
        Me.errorDisplayNameLabel = New System.Windows.Forms.Label()
        Me.errorLastNameLabel = New System.Windows.Forms.Label()
        Me.errorFirstNameLabel = New System.Windows.Forms.Label()
        Me.addEmployeeButton = New System.Windows.Forms.Button()
        Me.managerButton = New System.Windows.Forms.RadioButton()
        Me.bartenderButton = New System.Windows.Forms.RadioButton()
        Me.QAButton = New System.Windows.Forms.RadioButton()
        Me.cookButton = New System.Windows.Forms.RadioButton()
        Me.waiterButton = New System.Windows.Forms.RadioButton()
        Me.hostButton = New System.Windows.Forms.RadioButton()
        Me.usernameTextbox = New System.Windows.Forms.TextBox()
        Me.passwordTextbox = New System.Windows.Forms.TextBox()
        Me.displayNameTextbox = New System.Windows.Forms.TextBox()
        Me.lastNameTextbox = New System.Windows.Forms.TextBox()
        Me.firstNameTextbox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.inventoryTab = New System.Windows.Forms.TabPage()
        Me.logoutButton = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.employeeTab.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Size = New System.Drawing.Size(1242, 576)
        Me.TabControl1.TabIndex = 0
        '
        'employeeTab
        '
        Me.employeeTab.Controls.Add(Me.TabControl2)
        Me.employeeTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeTab.Location = New System.Drawing.Point(4, 43)
        Me.employeeTab.Margin = New System.Windows.Forms.Padding(6)
        Me.employeeTab.Name = "employeeTab"
        Me.employeeTab.Padding = New System.Windows.Forms.Padding(6)
        Me.employeeTab.Size = New System.Drawing.Size(1234, 529)
        Me.employeeTab.TabIndex = 0
        Me.employeeTab.Text = "EMPLOYEES"
        Me.employeeTab.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(-3, 2)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(6)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1238, 527)
        Me.TabControl2.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.editEmployeeButton)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 43)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(6)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(6)
        Me.TabPage1.Size = New System.Drawing.Size(1230, 480)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "LIST"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'editEmployeeButton
        '
        Me.editEmployeeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editEmployeeButton.Location = New System.Drawing.Point(3, 407)
        Me.editEmployeeButton.Name = "editEmployeeButton"
        Me.editEmployeeButton.Size = New System.Drawing.Size(416, 68)
        Me.editEmployeeButton.TabIndex = 83
        Me.editEmployeeButton.Text = "EDIT EMPLOYEE"
        Me.editEmployeeButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 80
        Me.DataGridView1.Size = New System.Drawing.Size(1229, 401)
        Me.DataGridView1.TabIndex = 80
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.errorPasswordLabel)
        Me.TabPage2.Controls.Add(Me.errorUsernameLabel)
        Me.TabPage2.Controls.Add(Me.errorDisplayNameLabel)
        Me.TabPage2.Controls.Add(Me.errorLastNameLabel)
        Me.TabPage2.Controls.Add(Me.errorFirstNameLabel)
        Me.TabPage2.Controls.Add(Me.addEmployeeButton)
        Me.TabPage2.Controls.Add(Me.managerButton)
        Me.TabPage2.Controls.Add(Me.bartenderButton)
        Me.TabPage2.Controls.Add(Me.QAButton)
        Me.TabPage2.Controls.Add(Me.cookButton)
        Me.TabPage2.Controls.Add(Me.waiterButton)
        Me.TabPage2.Controls.Add(Me.hostButton)
        Me.TabPage2.Controls.Add(Me.usernameTextbox)
        Me.TabPage2.Controls.Add(Me.passwordTextbox)
        Me.TabPage2.Controls.Add(Me.displayNameTextbox)
        Me.TabPage2.Controls.Add(Me.lastNameTextbox)
        Me.TabPage2.Controls.Add(Me.firstNameTextbox)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 43)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(6)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(6)
        Me.TabPage2.Size = New System.Drawing.Size(1230, 480)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "ADD"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'errorPasswordLabel
        '
        Me.errorPasswordLabel.AutoSize = True
        Me.errorPasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errorPasswordLabel.ForeColor = System.Drawing.Color.Firebrick
        Me.errorPasswordLabel.Location = New System.Drawing.Point(169, 435)
        Me.errorPasswordLabel.Name = "errorPasswordLabel"
        Me.errorPasswordLabel.Size = New System.Drawing.Size(47, 20)
        Me.errorPasswordLabel.TabIndex = 88
        Me.errorPasswordLabel.Text = "error"
        Me.errorPasswordLabel.Visible = False
        '
        'errorUsernameLabel
        '
        Me.errorUsernameLabel.AutoSize = True
        Me.errorUsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errorUsernameLabel.ForeColor = System.Drawing.Color.Firebrick
        Me.errorUsernameLabel.Location = New System.Drawing.Point(169, 385)
        Me.errorUsernameLabel.Name = "errorUsernameLabel"
        Me.errorUsernameLabel.Size = New System.Drawing.Size(47, 20)
        Me.errorUsernameLabel.TabIndex = 87
        Me.errorUsernameLabel.Text = "error"
        Me.errorUsernameLabel.Visible = False
        '
        'errorDisplayNameLabel
        '
        Me.errorDisplayNameLabel.AutoSize = True
        Me.errorDisplayNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errorDisplayNameLabel.ForeColor = System.Drawing.Color.Firebrick
        Me.errorDisplayNameLabel.Location = New System.Drawing.Point(169, 145)
        Me.errorDisplayNameLabel.Name = "errorDisplayNameLabel"
        Me.errorDisplayNameLabel.Size = New System.Drawing.Size(47, 20)
        Me.errorDisplayNameLabel.TabIndex = 86
        Me.errorDisplayNameLabel.Text = "error"
        Me.errorDisplayNameLabel.Visible = False
        '
        'errorLastNameLabel
        '
        Me.errorLastNameLabel.AutoSize = True
        Me.errorLastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errorLastNameLabel.ForeColor = System.Drawing.Color.Firebrick
        Me.errorLastNameLabel.Location = New System.Drawing.Point(169, 95)
        Me.errorLastNameLabel.Name = "errorLastNameLabel"
        Me.errorLastNameLabel.Size = New System.Drawing.Size(47, 20)
        Me.errorLastNameLabel.TabIndex = 85
        Me.errorLastNameLabel.Text = "error"
        Me.errorLastNameLabel.Visible = False
        '
        'errorFirstNameLabel
        '
        Me.errorFirstNameLabel.AutoSize = True
        Me.errorFirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errorFirstNameLabel.ForeColor = System.Drawing.Color.Firebrick
        Me.errorFirstNameLabel.Location = New System.Drawing.Point(169, 45)
        Me.errorFirstNameLabel.Name = "errorFirstNameLabel"
        Me.errorFirstNameLabel.Size = New System.Drawing.Size(47, 20)
        Me.errorFirstNameLabel.TabIndex = 84
        Me.errorFirstNameLabel.Text = "error"
        Me.errorFirstNameLabel.Visible = False
        '
        'addEmployeeButton
        '
        Me.addEmployeeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addEmployeeButton.Location = New System.Drawing.Point(945, 403)
        Me.addEmployeeButton.Name = "addEmployeeButton"
        Me.addEmployeeButton.Size = New System.Drawing.Size(276, 68)
        Me.addEmployeeButton.TabIndex = 29
        Me.addEmployeeButton.Text = "Add employee"
        Me.addEmployeeButton.UseVisualStyleBackColor = True
        '
        'managerButton
        '
        Me.managerButton.AutoSize = True
        Me.managerButton.Location = New System.Drawing.Point(184, 318)
        Me.managerButton.Name = "managerButton"
        Me.managerButton.Size = New System.Drawing.Size(80, 20)
        Me.managerButton.TabIndex = 24
        Me.managerButton.TabStop = True
        Me.managerButton.Text = "Manager"
        Me.managerButton.UseVisualStyleBackColor = True
        '
        'bartenderButton
        '
        Me.bartenderButton.AutoSize = True
        Me.bartenderButton.Location = New System.Drawing.Point(184, 240)
        Me.bartenderButton.Name = "bartenderButton"
        Me.bartenderButton.Size = New System.Drawing.Size(85, 20)
        Me.bartenderButton.TabIndex = 23
        Me.bartenderButton.TabStop = True
        Me.bartenderButton.Text = "Bartender"
        Me.bartenderButton.UseVisualStyleBackColor = True
        '
        'QAButton
        '
        Me.QAButton.AutoSize = True
        Me.QAButton.Location = New System.Drawing.Point(184, 292)
        Me.QAButton.Name = "QAButton"
        Me.QAButton.Size = New System.Drawing.Size(199, 20)
        Me.QAButton.TabIndex = 22
        Me.QAButton.TabStop = True
        Me.QAButton.Text = "Quality Assurance Employee"
        Me.QAButton.UseVisualStyleBackColor = True
        '
        'cookButton
        '
        Me.cookButton.AutoSize = True
        Me.cookButton.Location = New System.Drawing.Point(184, 266)
        Me.cookButton.Name = "cookButton"
        Me.cookButton.Size = New System.Drawing.Size(58, 20)
        Me.cookButton.TabIndex = 21
        Me.cookButton.TabStop = True
        Me.cookButton.Text = "Cook"
        Me.cookButton.UseVisualStyleBackColor = True
        '
        'waiterButton
        '
        Me.waiterButton.AutoSize = True
        Me.waiterButton.Location = New System.Drawing.Point(184, 214)
        Me.waiterButton.Name = "waiterButton"
        Me.waiterButton.Size = New System.Drawing.Size(65, 20)
        Me.waiterButton.TabIndex = 20
        Me.waiterButton.TabStop = True
        Me.waiterButton.Text = "Waiter"
        Me.waiterButton.UseVisualStyleBackColor = True
        '
        'hostButton
        '
        Me.hostButton.AutoSize = True
        Me.hostButton.Location = New System.Drawing.Point(184, 188)
        Me.hostButton.Name = "hostButton"
        Me.hostButton.Size = New System.Drawing.Size(54, 20)
        Me.hostButton.TabIndex = 19
        Me.hostButton.TabStop = True
        Me.hostButton.Text = "Host"
        Me.hostButton.UseVisualStyleBackColor = True
        '
        'usernameTextbox
        '
        Me.usernameTextbox.Location = New System.Drawing.Point(173, 360)
        Me.usernameTextbox.MaxLength = 4
        Me.usernameTextbox.Name = "usernameTextbox"
        Me.usernameTextbox.Size = New System.Drawing.Size(200, 22)
        Me.usernameTextbox.TabIndex = 18
        '
        'passwordTextbox
        '
        Me.passwordTextbox.Location = New System.Drawing.Point(173, 410)
        Me.passwordTextbox.MaxLength = 4
        Me.passwordTextbox.Name = "passwordTextbox"
        Me.passwordTextbox.Size = New System.Drawing.Size(200, 22)
        Me.passwordTextbox.TabIndex = 16
        '
        'displayNameTextbox
        '
        Me.displayNameTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.displayNameTextbox.Location = New System.Drawing.Point(173, 120)
        Me.displayNameTextbox.Name = "displayNameTextbox"
        Me.displayNameTextbox.Size = New System.Drawing.Size(200, 22)
        Me.displayNameTextbox.TabIndex = 15
        '
        'lastNameTextbox
        '
        Me.lastNameTextbox.Location = New System.Drawing.Point(173, 70)
        Me.lastNameTextbox.Name = "lastNameTextbox"
        Me.lastNameTextbox.Size = New System.Drawing.Size(200, 22)
        Me.lastNameTextbox.TabIndex = 14
        '
        'firstNameTextbox
        '
        Me.firstNameTextbox.Location = New System.Drawing.Point(173, 20)
        Me.firstNameTextbox.Name = "firstNameTextbox"
        Me.firstNameTextbox.Size = New System.Drawing.Size(200, 22)
        Me.firstNameTextbox.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(74, 413)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Password PIN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 363)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Username PIN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Employee Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Display Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(94, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(94, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "First Name"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.deleteButton)
        Me.TabPage3.Controls.Add(Me.DataGridView2)
        Me.TabPage3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage3.Location = New System.Drawing.Point(4, 43)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1230, 480)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "DELETE"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'deleteButton
        '
        Me.deleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteButton.Location = New System.Drawing.Point(8, 407)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(416, 68)
        Me.deleteButton.TabIndex = 82
        Me.deleteButton.Text = "DELETE EMPLOYEE"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.GridColor = System.Drawing.SystemColors.Control
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidth = 80
        Me.DataGridView2.Size = New System.Drawing.Size(1229, 401)
        Me.DataGridView2.TabIndex = 81
        '
        'inventoryTab
        '
        Me.inventoryTab.Location = New System.Drawing.Point(4, 43)
        Me.inventoryTab.Margin = New System.Windows.Forms.Padding(6)
        Me.inventoryTab.Name = "inventoryTab"
        Me.inventoryTab.Padding = New System.Windows.Forms.Padding(6)
        Me.inventoryTab.Size = New System.Drawing.Size(1234, 529)
        Me.inventoryTab.TabIndex = 1
        Me.inventoryTab.Text = "INVENTORY"
        Me.inventoryTab.UseVisualStyleBackColor = True
        '
        'logoutButton
        '
        Me.logoutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutButton.Location = New System.Drawing.Point(976, 600)
        Me.logoutButton.Name = "logoutButton"
        Me.logoutButton.Size = New System.Drawing.Size(276, 68)
        Me.logoutButton.TabIndex = 28
        Me.logoutButton.Text = "LOGOUT"
        Me.logoutButton.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 43)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1230, 480)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "EDIT"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 680)
        Me.Controls.Add(Me.logoutButton)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "manager"
        Me.TabControl1.ResumeLayout(False)
        Me.employeeTab.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents employeeTab As System.Windows.Forms.TabPage
    Friend WithEvents inventoryTab As System.Windows.Forms.TabPage
    Friend WithEvents logoutButton As System.Windows.Forms.Button
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents usernameTextbox As System.Windows.Forms.TextBox
    Friend WithEvents passwordTextbox As System.Windows.Forms.TextBox
    Friend WithEvents displayNameTextbox As System.Windows.Forms.TextBox
    Friend WithEvents lastNameTextbox As System.Windows.Forms.TextBox
    Friend WithEvents firstNameTextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents QAButton As System.Windows.Forms.RadioButton
    Friend WithEvents cookButton As System.Windows.Forms.RadioButton
    Friend WithEvents waiterButton As System.Windows.Forms.RadioButton
    Friend WithEvents hostButton As System.Windows.Forms.RadioButton
    Friend WithEvents managerButton As System.Windows.Forms.RadioButton
    Friend WithEvents bartenderButton As System.Windows.Forms.RadioButton
    Friend WithEvents addEmployeeButton As System.Windows.Forms.Button
    Friend WithEvents deleteButton As System.Windows.Forms.Button
    Friend WithEvents errorPasswordLabel As System.Windows.Forms.Label
    Friend WithEvents errorUsernameLabel As System.Windows.Forms.Label
    Friend WithEvents errorDisplayNameLabel As System.Windows.Forms.Label
    Friend WithEvents errorLastNameLabel As System.Windows.Forms.Label
    Friend WithEvents errorFirstNameLabel As System.Windows.Forms.Label
    Friend WithEvents editEmployeeButton As System.Windows.Forms.Button
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
End Class
