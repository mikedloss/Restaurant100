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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.employeeTab = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.listTab = New System.Windows.Forms.TabPage()
        Me.addEmployeeButtonDGV = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.editEmployeeButtonDGV = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.addTab = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.noteTextBox = New System.Windows.Forms.TextBox()
        Me.closeTabButton = New System.Windows.Forms.Button()
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
        Me.editTab = New System.Windows.Forms.TabPage()
        Me.closeTabButtonE = New System.Windows.Forms.Button()
        Me.submitChangesButton = New System.Windows.Forms.Button()
        Me.errorPasswordLabelE = New System.Windows.Forms.Label()
        Me.errorUsernameLabelE = New System.Windows.Forms.Label()
        Me.errorDisplayNameLabelE = New System.Windows.Forms.Label()
        Me.errorLastNameLabelE = New System.Windows.Forms.Label()
        Me.errorFirstNameLabelE = New System.Windows.Forms.Label()
        Me.managerButtonE = New System.Windows.Forms.RadioButton()
        Me.cookQAButtonE = New System.Windows.Forms.RadioButton()
        Me.waiterButtonE = New System.Windows.Forms.RadioButton()
        Me.hostButtonE = New System.Windows.Forms.RadioButton()
        Me.usernameTextBoxE = New System.Windows.Forms.TextBox()
        Me.passwordTextBoxE = New System.Windows.Forms.TextBox()
        Me.displayNameTextBoxE = New System.Windows.Forms.TextBox()
        Me.lastNameTextBoxE = New System.Windows.Forms.TextBox()
        Me.firstNameTextBoxE = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.inventoryTab = New System.Windows.Forms.TabPage()
        Me.logoutButton = New System.Windows.Forms.Button()
        Me.welcomeLabel = New System.Windows.Forms.Label()
        Me.timeLabel = New System.Windows.Forms.Label()
        Me.dateLabel = New System.Windows.Forms.Label()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.noteTextBoxE = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.employeeTab.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.listTab.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.addTab.SuspendLayout()
        Me.editTab.SuspendLayout()
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
        Me.TabControl2.Controls.Add(Me.listTab)
        Me.TabControl2.Controls.Add(Me.addTab)
        Me.TabControl2.Controls.Add(Me.editTab)
        Me.TabControl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(-3, 2)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(6)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1238, 527)
        Me.TabControl2.TabIndex = 1
        Me.TabControl2.TabStop = False
        '
        'listTab
        '
        Me.listTab.Controls.Add(Me.addEmployeeButtonDGV)
        Me.listTab.Controls.Add(Me.deleteButton)
        Me.listTab.Controls.Add(Me.editEmployeeButtonDGV)
        Me.listTab.Controls.Add(Me.DataGridView1)
        Me.listTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listTab.Location = New System.Drawing.Point(4, 43)
        Me.listTab.Margin = New System.Windows.Forms.Padding(6)
        Me.listTab.Name = "listTab"
        Me.listTab.Padding = New System.Windows.Forms.Padding(6)
        Me.listTab.Size = New System.Drawing.Size(1230, 480)
        Me.listTab.TabIndex = 0
        Me.listTab.Text = "LIST"
        Me.listTab.UseVisualStyleBackColor = True
        '
        'addEmployeeButtonDGV
        '
        Me.addEmployeeButtonDGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addEmployeeButtonDGV.Location = New System.Drawing.Point(0, 407)
        Me.addEmployeeButtonDGV.Name = "addEmployeeButtonDGV"
        Me.addEmployeeButtonDGV.Size = New System.Drawing.Size(410, 68)
        Me.addEmployeeButtonDGV.TabIndex = 85
        Me.addEmployeeButtonDGV.Text = "ADD EMPLOYEE"
        Me.addEmployeeButtonDGV.UseVisualStyleBackColor = True
        '
        'deleteButton
        '
        Me.deleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteButton.Location = New System.Drawing.Point(820, 407)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(410, 68)
        Me.deleteButton.TabIndex = 84
        Me.deleteButton.Text = "DELETE EMPLOYEE"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'editEmployeeButtonDGV
        '
        Me.editEmployeeButtonDGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editEmployeeButtonDGV.Location = New System.Drawing.Point(410, 407)
        Me.editEmployeeButtonDGV.Name = "editEmployeeButtonDGV"
        Me.editEmployeeButtonDGV.Size = New System.Drawing.Size(410, 68)
        Me.editEmployeeButtonDGV.TabIndex = 83
        Me.editEmployeeButtonDGV.Text = "EDIT EMPLOYEE"
        Me.editEmployeeButtonDGV.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 80
        Me.DataGridView1.Size = New System.Drawing.Size(1229, 401)
        Me.DataGridView1.TabIndex = 80
        '
        'addTab
        '
        Me.addTab.Controls.Add(Me.Label10)
        Me.addTab.Controls.Add(Me.Label7)
        Me.addTab.Controls.Add(Me.noteTextBox)
        Me.addTab.Controls.Add(Me.closeTabButton)
        Me.addTab.Controls.Add(Me.errorPasswordLabel)
        Me.addTab.Controls.Add(Me.errorUsernameLabel)
        Me.addTab.Controls.Add(Me.errorDisplayNameLabel)
        Me.addTab.Controls.Add(Me.errorLastNameLabel)
        Me.addTab.Controls.Add(Me.errorFirstNameLabel)
        Me.addTab.Controls.Add(Me.addEmployeeButton)
        Me.addTab.Controls.Add(Me.managerButton)
        Me.addTab.Controls.Add(Me.bartenderButton)
        Me.addTab.Controls.Add(Me.QAButton)
        Me.addTab.Controls.Add(Me.cookButton)
        Me.addTab.Controls.Add(Me.waiterButton)
        Me.addTab.Controls.Add(Me.hostButton)
        Me.addTab.Controls.Add(Me.usernameTextbox)
        Me.addTab.Controls.Add(Me.passwordTextbox)
        Me.addTab.Controls.Add(Me.displayNameTextbox)
        Me.addTab.Controls.Add(Me.lastNameTextbox)
        Me.addTab.Controls.Add(Me.firstNameTextbox)
        Me.addTab.Controls.Add(Me.Label6)
        Me.addTab.Controls.Add(Me.Label5)
        Me.addTab.Controls.Add(Me.Label4)
        Me.addTab.Controls.Add(Me.Label3)
        Me.addTab.Controls.Add(Me.Label2)
        Me.addTab.Controls.Add(Me.Label1)
        Me.addTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addTab.Location = New System.Drawing.Point(4, 43)
        Me.addTab.Margin = New System.Windows.Forms.Padding(6)
        Me.addTab.Name = "addTab"
        Me.addTab.Padding = New System.Windows.Forms.Padding(6)
        Me.addTab.Size = New System.Drawing.Size(1230, 480)
        Me.addTab.TabIndex = 1
        Me.addTab.Text = "ADD"
        Me.addTab.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(822, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 16)
        Me.Label7.TabIndex = 115
        Me.Label7.Text = "Note for the employee:"
        '
        'noteTextBox
        '
        Me.noteTextBox.Location = New System.Drawing.Point(825, 65)
        Me.noteTextBox.MaxLength = 140
        Me.noteTextBox.Multiline = True
        Me.noteTextBox.Name = "noteTextBox"
        Me.noteTextBox.Size = New System.Drawing.Size(396, 141)
        Me.noteTextBox.TabIndex = 114
        '
        'closeTabButton
        '
        Me.closeTabButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeTabButton.Location = New System.Drawing.Point(945, 331)
        Me.closeTabButton.Name = "closeTabButton"
        Me.closeTabButton.Size = New System.Drawing.Size(276, 68)
        Me.closeTabButton.TabIndex = 113
        Me.closeTabButton.Text = "Close Tab"
        Me.closeTabButton.UseVisualStyleBackColor = True
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
        'editTab
        '
        Me.editTab.Controls.Add(Me.Label9)
        Me.editTab.Controls.Add(Me.Label8)
        Me.editTab.Controls.Add(Me.noteTextBoxE)
        Me.editTab.Controls.Add(Me.closeTabButtonE)
        Me.editTab.Controls.Add(Me.submitChangesButton)
        Me.editTab.Controls.Add(Me.errorPasswordLabelE)
        Me.editTab.Controls.Add(Me.errorUsernameLabelE)
        Me.editTab.Controls.Add(Me.errorDisplayNameLabelE)
        Me.editTab.Controls.Add(Me.errorLastNameLabelE)
        Me.editTab.Controls.Add(Me.errorFirstNameLabelE)
        Me.editTab.Controls.Add(Me.managerButtonE)
        Me.editTab.Controls.Add(Me.cookQAButtonE)
        Me.editTab.Controls.Add(Me.waiterButtonE)
        Me.editTab.Controls.Add(Me.hostButtonE)
        Me.editTab.Controls.Add(Me.usernameTextBoxE)
        Me.editTab.Controls.Add(Me.passwordTextBoxE)
        Me.editTab.Controls.Add(Me.displayNameTextBoxE)
        Me.editTab.Controls.Add(Me.lastNameTextBoxE)
        Me.editTab.Controls.Add(Me.firstNameTextBoxE)
        Me.editTab.Controls.Add(Me.Label12)
        Me.editTab.Controls.Add(Me.Label13)
        Me.editTab.Controls.Add(Me.Label14)
        Me.editTab.Controls.Add(Me.Label15)
        Me.editTab.Controls.Add(Me.Label16)
        Me.editTab.Controls.Add(Me.Label17)
        Me.editTab.Location = New System.Drawing.Point(4, 43)
        Me.editTab.Name = "editTab"
        Me.editTab.Size = New System.Drawing.Size(1230, 480)
        Me.editTab.TabIndex = 3
        Me.editTab.Text = "EDIT"
        Me.editTab.UseVisualStyleBackColor = True
        '
        'closeTabButtonE
        '
        Me.closeTabButtonE.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeTabButtonE.Location = New System.Drawing.Point(945, 331)
        Me.closeTabButtonE.Name = "closeTabButtonE"
        Me.closeTabButtonE.Size = New System.Drawing.Size(276, 68)
        Me.closeTabButtonE.TabIndex = 112
        Me.closeTabButtonE.Text = "Close Tab"
        Me.closeTabButtonE.UseVisualStyleBackColor = True
        '
        'submitChangesButton
        '
        Me.submitChangesButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitChangesButton.Location = New System.Drawing.Point(945, 403)
        Me.submitChangesButton.Name = "submitChangesButton"
        Me.submitChangesButton.Size = New System.Drawing.Size(276, 68)
        Me.submitChangesButton.TabIndex = 111
        Me.submitChangesButton.Text = "Submit changes"
        Me.submitChangesButton.UseVisualStyleBackColor = True
        '
        'errorPasswordLabelE
        '
        Me.errorPasswordLabelE.AutoSize = True
        Me.errorPasswordLabelE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errorPasswordLabelE.ForeColor = System.Drawing.Color.Firebrick
        Me.errorPasswordLabelE.Location = New System.Drawing.Point(169, 383)
        Me.errorPasswordLabelE.Name = "errorPasswordLabelE"
        Me.errorPasswordLabelE.Size = New System.Drawing.Size(47, 20)
        Me.errorPasswordLabelE.TabIndex = 110
        Me.errorPasswordLabelE.Text = "error"
        Me.errorPasswordLabelE.Visible = False
        '
        'errorUsernameLabelE
        '
        Me.errorUsernameLabelE.AutoSize = True
        Me.errorUsernameLabelE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errorUsernameLabelE.ForeColor = System.Drawing.Color.Firebrick
        Me.errorUsernameLabelE.Location = New System.Drawing.Point(169, 333)
        Me.errorUsernameLabelE.Name = "errorUsernameLabelE"
        Me.errorUsernameLabelE.Size = New System.Drawing.Size(47, 20)
        Me.errorUsernameLabelE.TabIndex = 109
        Me.errorUsernameLabelE.Text = "error"
        Me.errorUsernameLabelE.Visible = False
        '
        'errorDisplayNameLabelE
        '
        Me.errorDisplayNameLabelE.AutoSize = True
        Me.errorDisplayNameLabelE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errorDisplayNameLabelE.ForeColor = System.Drawing.Color.Firebrick
        Me.errorDisplayNameLabelE.Location = New System.Drawing.Point(169, 145)
        Me.errorDisplayNameLabelE.Name = "errorDisplayNameLabelE"
        Me.errorDisplayNameLabelE.Size = New System.Drawing.Size(47, 20)
        Me.errorDisplayNameLabelE.TabIndex = 108
        Me.errorDisplayNameLabelE.Text = "error"
        Me.errorDisplayNameLabelE.Visible = False
        '
        'errorLastNameLabelE
        '
        Me.errorLastNameLabelE.AutoSize = True
        Me.errorLastNameLabelE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errorLastNameLabelE.ForeColor = System.Drawing.Color.Firebrick
        Me.errorLastNameLabelE.Location = New System.Drawing.Point(169, 95)
        Me.errorLastNameLabelE.Name = "errorLastNameLabelE"
        Me.errorLastNameLabelE.Size = New System.Drawing.Size(47, 20)
        Me.errorLastNameLabelE.TabIndex = 107
        Me.errorLastNameLabelE.Text = "error"
        Me.errorLastNameLabelE.Visible = False
        '
        'errorFirstNameLabelE
        '
        Me.errorFirstNameLabelE.AutoSize = True
        Me.errorFirstNameLabelE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errorFirstNameLabelE.ForeColor = System.Drawing.Color.Firebrick
        Me.errorFirstNameLabelE.Location = New System.Drawing.Point(169, 45)
        Me.errorFirstNameLabelE.Name = "errorFirstNameLabelE"
        Me.errorFirstNameLabelE.Size = New System.Drawing.Size(47, 20)
        Me.errorFirstNameLabelE.TabIndex = 106
        Me.errorFirstNameLabelE.Text = "error"
        Me.errorFirstNameLabelE.Visible = False
        '
        'managerButtonE
        '
        Me.managerButtonE.AutoSize = True
        Me.managerButtonE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.managerButtonE.Location = New System.Drawing.Point(184, 266)
        Me.managerButtonE.Name = "managerButtonE"
        Me.managerButtonE.Size = New System.Drawing.Size(80, 20)
        Me.managerButtonE.TabIndex = 105
        Me.managerButtonE.TabStop = True
        Me.managerButtonE.Text = "Manager"
        Me.managerButtonE.UseVisualStyleBackColor = True
        '
        'cookQAButtonE
        '
        Me.cookQAButtonE.AutoSize = True
        Me.cookQAButtonE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cookQAButtonE.Location = New System.Drawing.Point(184, 240)
        Me.cookQAButtonE.Name = "cookQAButtonE"
        Me.cookQAButtonE.Size = New System.Drawing.Size(87, 20)
        Me.cookQAButtonE.TabIndex = 102
        Me.cookQAButtonE.TabStop = True
        Me.cookQAButtonE.Text = "Cook / QA"
        Me.cookQAButtonE.UseVisualStyleBackColor = True
        '
        'waiterButtonE
        '
        Me.waiterButtonE.AutoSize = True
        Me.waiterButtonE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.waiterButtonE.Location = New System.Drawing.Point(184, 214)
        Me.waiterButtonE.Name = "waiterButtonE"
        Me.waiterButtonE.Size = New System.Drawing.Size(134, 20)
        Me.waiterButtonE.TabIndex = 101
        Me.waiterButtonE.TabStop = True
        Me.waiterButtonE.Text = "Waiter / Bartender"
        Me.waiterButtonE.UseVisualStyleBackColor = True
        '
        'hostButtonE
        '
        Me.hostButtonE.AutoSize = True
        Me.hostButtonE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hostButtonE.Location = New System.Drawing.Point(184, 188)
        Me.hostButtonE.Name = "hostButtonE"
        Me.hostButtonE.Size = New System.Drawing.Size(54, 20)
        Me.hostButtonE.TabIndex = 100
        Me.hostButtonE.TabStop = True
        Me.hostButtonE.Text = "Host"
        Me.hostButtonE.UseVisualStyleBackColor = True
        '
        'usernameTextBoxE
        '
        Me.usernameTextBoxE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameTextBoxE.Location = New System.Drawing.Point(173, 308)
        Me.usernameTextBoxE.MaxLength = 4
        Me.usernameTextBoxE.Name = "usernameTextBoxE"
        Me.usernameTextBoxE.Size = New System.Drawing.Size(200, 22)
        Me.usernameTextBoxE.TabIndex = 99
        '
        'passwordTextBoxE
        '
        Me.passwordTextBoxE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordTextBoxE.Location = New System.Drawing.Point(173, 358)
        Me.passwordTextBoxE.MaxLength = 4
        Me.passwordTextBoxE.Name = "passwordTextBoxE"
        Me.passwordTextBoxE.Size = New System.Drawing.Size(200, 22)
        Me.passwordTextBoxE.TabIndex = 98
        '
        'displayNameTextBoxE
        '
        Me.displayNameTextBoxE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.displayNameTextBoxE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayNameTextBoxE.Location = New System.Drawing.Point(173, 120)
        Me.displayNameTextBoxE.Name = "displayNameTextBoxE"
        Me.displayNameTextBoxE.Size = New System.Drawing.Size(200, 22)
        Me.displayNameTextBoxE.TabIndex = 97
        '
        'lastNameTextBoxE
        '
        Me.lastNameTextBoxE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastNameTextBoxE.Location = New System.Drawing.Point(173, 70)
        Me.lastNameTextBoxE.Name = "lastNameTextBoxE"
        Me.lastNameTextBoxE.Size = New System.Drawing.Size(200, 22)
        Me.lastNameTextBoxE.TabIndex = 96
        '
        'firstNameTextBoxE
        '
        Me.firstNameTextBoxE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstNameTextBoxE.Location = New System.Drawing.Point(173, 20)
        Me.firstNameTextBoxE.Name = "firstNameTextBoxE"
        Me.firstNameTextBoxE.Size = New System.Drawing.Size(200, 22)
        Me.firstNameTextBoxE.TabIndex = 95
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(74, 361)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 16)
        Me.Label12.TabIndex = 94
        Me.Label12.Text = "Password PIN"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(71, 311)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 16)
        Me.Label13.TabIndex = 93
        Me.Label13.Text = "Username PIN"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(62, 190)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(105, 16)
        Me.Label14.TabIndex = 92
        Me.Label14.Text = "Employee Type"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(73, 123)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 16)
        Me.Label15.TabIndex = 91
        Me.Label15.Text = "Display Name"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(94, 73)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 16)
        Me.Label16.TabIndex = 90
        Me.Label16.Text = "Last Name"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(94, 23)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 16)
        Me.Label17.TabIndex = 89
        Me.Label17.Text = "First Name"
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
        'welcomeLabel
        '
        Me.welcomeLabel.AutoSize = True
        Me.welcomeLabel.Location = New System.Drawing.Point(5, 600)
        Me.welcomeLabel.Name = "welcomeLabel"
        Me.welcomeLabel.Size = New System.Drawing.Size(172, 25)
        Me.welcomeLabel.TabIndex = 29
        Me.welcomeLabel.Text = "Welcome, name!"
        '
        'timeLabel
        '
        Me.timeLabel.AutoSize = True
        Me.timeLabel.Location = New System.Drawing.Point(5, 625)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(52, 25)
        Me.timeLabel.TabIndex = 30
        Me.timeLabel.Text = "time"
        '
        'dateLabel
        '
        Me.dateLabel.AutoSize = True
        Me.dateLabel.Location = New System.Drawing.Point(5, 650)
        Me.dateLabel.Name = "dateLabel"
        Me.dateLabel.Size = New System.Drawing.Size(54, 25)
        Me.dateLabel.TabIndex = 31
        Me.dateLabel.Text = "date"
        '
        'timer
        '
        Me.timer.Enabled = True
        Me.timer.Interval = 1000
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(822, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 16)
        Me.Label8.TabIndex = 117
        Me.Label8.Text = "Note for the employee:"
        '
        'noteTextBoxE
        '
        Me.noteTextBoxE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noteTextBoxE.Location = New System.Drawing.Point(825, 67)
        Me.noteTextBoxE.MaxLength = 140
        Me.noteTextBoxE.Multiline = True
        Me.noteTextBoxE.Name = "noteTextBoxE"
        Me.noteTextBoxE.Size = New System.Drawing.Size(396, 40)
        Me.noteTextBoxE.TabIndex = 116
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(863, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(358, 32)
        Me.Label9.TabIndex = 118
        Me.Label9.Text = "(Please remember to put two forward slashes (//) at the end " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of a line or the be" & _
    "ginning of a new line!)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(863, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(358, 32)
        Me.Label10.TabIndex = 119
        Me.Label10.Text = "(Please remember to put two forward slashes (//) at the end " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of a line or the be" & _
    "ginning of a new line!)"
        '
        'manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 680)
        Me.Controls.Add(Me.dateLabel)
        Me.Controls.Add(Me.timeLabel)
        Me.Controls.Add(Me.welcomeLabel)
        Me.Controls.Add(Me.logoutButton)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "manager"
        Me.TabControl1.ResumeLayout(False)
        Me.employeeTab.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.listTab.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.addTab.ResumeLayout(False)
        Me.addTab.PerformLayout()
        Me.editTab.ResumeLayout(False)
        Me.editTab.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents employeeTab As System.Windows.Forms.TabPage
    Friend WithEvents inventoryTab As System.Windows.Forms.TabPage
    Friend WithEvents logoutButton As System.Windows.Forms.Button
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents listTab As System.Windows.Forms.TabPage
    Friend WithEvents addEmployeeButtonDGV As System.Windows.Forms.Button
    Friend WithEvents deleteButton As System.Windows.Forms.Button
    Friend WithEvents editEmployeeButtonDGV As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents addTab As System.Windows.Forms.TabPage
    Friend WithEvents errorPasswordLabel As System.Windows.Forms.Label
    Friend WithEvents errorUsernameLabel As System.Windows.Forms.Label
    Friend WithEvents errorDisplayNameLabel As System.Windows.Forms.Label
    Friend WithEvents errorLastNameLabel As System.Windows.Forms.Label
    Friend WithEvents errorFirstNameLabel As System.Windows.Forms.Label
    Friend WithEvents addEmployeeButton As System.Windows.Forms.Button
    Friend WithEvents managerButton As System.Windows.Forms.RadioButton
    Friend WithEvents bartenderButton As System.Windows.Forms.RadioButton
    Friend WithEvents QAButton As System.Windows.Forms.RadioButton
    Friend WithEvents cookButton As System.Windows.Forms.RadioButton
    Friend WithEvents waiterButton As System.Windows.Forms.RadioButton
    Friend WithEvents hostButton As System.Windows.Forms.RadioButton
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
    Friend WithEvents editTab As System.Windows.Forms.TabPage
    Friend WithEvents welcomeLabel As System.Windows.Forms.Label
    Friend WithEvents timeLabel As System.Windows.Forms.Label
    Friend WithEvents dateLabel As System.Windows.Forms.Label
    Friend WithEvents timer As System.Windows.Forms.Timer
    Friend WithEvents errorPasswordLabelE As System.Windows.Forms.Label
    Friend WithEvents errorUsernameLabelE As System.Windows.Forms.Label
    Friend WithEvents errorDisplayNameLabelE As System.Windows.Forms.Label
    Friend WithEvents errorLastNameLabelE As System.Windows.Forms.Label
    Friend WithEvents errorFirstNameLabelE As System.Windows.Forms.Label
    Friend WithEvents managerButtonE As System.Windows.Forms.RadioButton
    Friend WithEvents cookQAButtonE As System.Windows.Forms.RadioButton
    Friend WithEvents waiterButtonE As System.Windows.Forms.RadioButton
    Friend WithEvents hostButtonE As System.Windows.Forms.RadioButton
    Friend WithEvents usernameTextBoxE As System.Windows.Forms.TextBox
    Friend WithEvents passwordTextBoxE As System.Windows.Forms.TextBox
    Friend WithEvents displayNameTextBoxE As System.Windows.Forms.TextBox
    Friend WithEvents lastNameTextBoxE As System.Windows.Forms.TextBox
    Friend WithEvents firstNameTextBoxE As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents submitChangesButton As System.Windows.Forms.Button
    Friend WithEvents closeTabButton As System.Windows.Forms.Button
    Friend WithEvents closeTabButtonE As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents noteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents noteTextBoxE As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
