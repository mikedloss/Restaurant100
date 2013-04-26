<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class firsttime
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(firsttime))
        Me.createDatabaseButton = New System.Windows.Forms.Button()
        Me.employeeinfoTableButton = New System.Windows.Forms.Button()
        Me.inventoryTableButton = New System.Windows.Forms.Button()
        Me.tablechecksTableButton = New System.Windows.Forms.Button()
        Me.tableoccupancyTableButton = New System.Windows.Forms.Button()
        Me.tablewaitlistTableButton = New System.Windows.Forms.Button()
        Me.createLabel = New System.Windows.Forms.Label()
        Me.tablewaitlistPopulateButton = New System.Windows.Forms.Button()
        Me.tableoccupancyPopulateButton = New System.Windows.Forms.Button()
        Me.tablechecksPopulateButton = New System.Windows.Forms.Button()
        Me.inventoryPopulateButton = New System.Windows.Forms.Button()
        Me.employeeinfoPopulateButton = New System.Windows.Forms.Button()
        Me.populateLabel = New System.Windows.Forms.Label()
        Me.workLabel = New System.Windows.Forms.Label()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.dateLabel = New System.Windows.Forms.Label()
        Me.timeLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.errorLabel = New System.Windows.Forms.Label()
        Me.finishedButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'createDatabaseButton
        '
        Me.createDatabaseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createDatabaseButton.Location = New System.Drawing.Point(655, 18)
        Me.createDatabaseButton.Name = "createDatabaseButton"
        Me.createDatabaseButton.Size = New System.Drawing.Size(598, 68)
        Me.createDatabaseButton.TabIndex = 86
        Me.createDatabaseButton.Text = "Create database"
        Me.createDatabaseButton.UseVisualStyleBackColor = True
        '
        'employeeinfoTableButton
        '
        Me.employeeinfoTableButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeinfoTableButton.Location = New System.Drawing.Point(655, 162)
        Me.employeeinfoTableButton.Name = "employeeinfoTableButton"
        Me.employeeinfoTableButton.Size = New System.Drawing.Size(255, 68)
        Me.employeeinfoTableButton.TabIndex = 87
        Me.employeeinfoTableButton.Text = "Employee info"
        Me.employeeinfoTableButton.UseVisualStyleBackColor = True
        '
        'inventoryTableButton
        '
        Me.inventoryTableButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inventoryTableButton.Location = New System.Drawing.Point(655, 236)
        Me.inventoryTableButton.Name = "inventoryTableButton"
        Me.inventoryTableButton.Size = New System.Drawing.Size(255, 68)
        Me.inventoryTableButton.TabIndex = 88
        Me.inventoryTableButton.Text = "Inventory"
        Me.inventoryTableButton.UseVisualStyleBackColor = True
        '
        'tablechecksTableButton
        '
        Me.tablechecksTableButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tablechecksTableButton.Location = New System.Drawing.Point(655, 310)
        Me.tablechecksTableButton.Name = "tablechecksTableButton"
        Me.tablechecksTableButton.Size = New System.Drawing.Size(255, 68)
        Me.tablechecksTableButton.TabIndex = 89
        Me.tablechecksTableButton.Text = "Table checks"
        Me.tablechecksTableButton.UseVisualStyleBackColor = True
        '
        'tableoccupancyTableButton
        '
        Me.tableoccupancyTableButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableoccupancyTableButton.Location = New System.Drawing.Point(655, 384)
        Me.tableoccupancyTableButton.Name = "tableoccupancyTableButton"
        Me.tableoccupancyTableButton.Size = New System.Drawing.Size(255, 68)
        Me.tableoccupancyTableButton.TabIndex = 90
        Me.tableoccupancyTableButton.Text = "Table occupancy"
        Me.tableoccupancyTableButton.UseVisualStyleBackColor = True
        '
        'tablewaitlistTableButton
        '
        Me.tablewaitlistTableButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tablewaitlistTableButton.Location = New System.Drawing.Point(655, 458)
        Me.tablewaitlistTableButton.Name = "tablewaitlistTableButton"
        Me.tablewaitlistTableButton.Size = New System.Drawing.Size(255, 68)
        Me.tablewaitlistTableButton.TabIndex = 91
        Me.tablewaitlistTableButton.Text = "Table waitlist"
        Me.tablewaitlistTableButton.UseVisualStyleBackColor = True
        '
        'createLabel
        '
        Me.createLabel.AutoSize = True
        Me.createLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.createLabel.Location = New System.Drawing.Point(651, 135)
        Me.createLabel.Name = "createLabel"
        Me.createLabel.Size = New System.Drawing.Size(119, 24)
        Me.createLabel.TabIndex = 92
        Me.createLabel.Text = "Create tables"
        '
        'tablewaitlistPopulateButton
        '
        Me.tablewaitlistPopulateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tablewaitlistPopulateButton.Location = New System.Drawing.Point(998, 458)
        Me.tablewaitlistPopulateButton.Name = "tablewaitlistPopulateButton"
        Me.tablewaitlistPopulateButton.Size = New System.Drawing.Size(255, 68)
        Me.tablewaitlistPopulateButton.TabIndex = 97
        Me.tablewaitlistPopulateButton.Text = "Table waitlist"
        Me.tablewaitlistPopulateButton.UseVisualStyleBackColor = True
        '
        'tableoccupancyPopulateButton
        '
        Me.tableoccupancyPopulateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableoccupancyPopulateButton.Location = New System.Drawing.Point(998, 384)
        Me.tableoccupancyPopulateButton.Name = "tableoccupancyPopulateButton"
        Me.tableoccupancyPopulateButton.Size = New System.Drawing.Size(255, 68)
        Me.tableoccupancyPopulateButton.TabIndex = 96
        Me.tableoccupancyPopulateButton.Text = "Table occupancy"
        Me.tableoccupancyPopulateButton.UseVisualStyleBackColor = True
        '
        'tablechecksPopulateButton
        '
        Me.tablechecksPopulateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tablechecksPopulateButton.Location = New System.Drawing.Point(998, 310)
        Me.tablechecksPopulateButton.Name = "tablechecksPopulateButton"
        Me.tablechecksPopulateButton.Size = New System.Drawing.Size(255, 68)
        Me.tablechecksPopulateButton.TabIndex = 95
        Me.tablechecksPopulateButton.Text = "Table checks"
        Me.tablechecksPopulateButton.UseVisualStyleBackColor = True
        '
        'inventoryPopulateButton
        '
        Me.inventoryPopulateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inventoryPopulateButton.Location = New System.Drawing.Point(998, 236)
        Me.inventoryPopulateButton.Name = "inventoryPopulateButton"
        Me.inventoryPopulateButton.Size = New System.Drawing.Size(255, 68)
        Me.inventoryPopulateButton.TabIndex = 94
        Me.inventoryPopulateButton.Text = "Inventory"
        Me.inventoryPopulateButton.UseVisualStyleBackColor = True
        '
        'employeeinfoPopulateButton
        '
        Me.employeeinfoPopulateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeinfoPopulateButton.Location = New System.Drawing.Point(998, 162)
        Me.employeeinfoPopulateButton.Name = "employeeinfoPopulateButton"
        Me.employeeinfoPopulateButton.Size = New System.Drawing.Size(255, 68)
        Me.employeeinfoPopulateButton.TabIndex = 93
        Me.employeeinfoPopulateButton.Text = "Employee info"
        Me.employeeinfoPopulateButton.UseVisualStyleBackColor = True
        '
        'populateLabel
        '
        Me.populateLabel.AutoSize = True
        Me.populateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.populateLabel.ForeColor = System.Drawing.SystemColors.Highlight
        Me.populateLabel.Location = New System.Drawing.Point(994, 135)
        Me.populateLabel.Name = "populateLabel"
        Me.populateLabel.Size = New System.Drawing.Size(138, 24)
        Me.populateLabel.TabIndex = 98
        Me.populateLabel.Text = "Populate tables"
        '
        'workLabel
        '
        Me.workLabel.AutoSize = True
        Me.workLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.workLabel.ForeColor = System.Drawing.Color.DarkCyan
        Me.workLabel.Location = New System.Drawing.Point(905, 543)
        Me.workLabel.Name = "workLabel"
        Me.workLabel.Size = New System.Drawing.Size(67, 16)
        Me.workLabel.TabIndex = 99
        Me.workLabel.Text = "Working..."
        Me.workLabel.Visible = False
        '
        'timer
        '
        Me.timer.Enabled = True
        Me.timer.Interval = 1000
        '
        'dateLabel
        '
        Me.dateLabel.AutoSize = True
        Me.dateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateLabel.Location = New System.Drawing.Point(12, 655)
        Me.dateLabel.Name = "dateLabel"
        Me.dateLabel.Size = New System.Drawing.Size(35, 16)
        Me.dateLabel.TabIndex = 101
        Me.dateLabel.Text = "date"
        '
        'timeLabel
        '
        Me.timeLabel.AutoSize = True
        Me.timeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeLabel.Location = New System.Drawing.Point(12, 630)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(33, 16)
        Me.timeLabel.TabIndex = 100
        Me.timeLabel.Text = "time"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 182)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(39, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 26)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "9999" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "9999"
        '
        'errorLabel
        '
        Me.errorLabel.AutoSize = True
        Me.errorLabel.ForeColor = System.Drawing.Color.Red
        Me.errorLabel.Location = New System.Drawing.Point(572, 633)
        Me.errorLabel.Name = "errorLabel"
        Me.errorLabel.Size = New System.Drawing.Size(28, 13)
        Me.errorLabel.TabIndex = 104
        Me.errorLabel.Text = "error"
        Me.errorLabel.Visible = False
        '
        'finishedButton
        '
        Me.finishedButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.finishedButton.Location = New System.Drawing.Point(15, 511)
        Me.finishedButton.Name = "finishedButton"
        Me.finishedButton.Size = New System.Drawing.Size(255, 68)
        Me.finishedButton.TabIndex = 105
        Me.finishedButton.Text = "Finished? Click me"
        Me.finishedButton.UseVisualStyleBackColor = True
        '
        'firsttime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 680)
        Me.Controls.Add(Me.finishedButton)
        Me.Controls.Add(Me.errorLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dateLabel)
        Me.Controls.Add(Me.timeLabel)
        Me.Controls.Add(Me.workLabel)
        Me.Controls.Add(Me.populateLabel)
        Me.Controls.Add(Me.tablewaitlistPopulateButton)
        Me.Controls.Add(Me.tableoccupancyPopulateButton)
        Me.Controls.Add(Me.tablechecksPopulateButton)
        Me.Controls.Add(Me.inventoryPopulateButton)
        Me.Controls.Add(Me.employeeinfoPopulateButton)
        Me.Controls.Add(Me.createLabel)
        Me.Controls.Add(Me.tablewaitlistTableButton)
        Me.Controls.Add(Me.tableoccupancyTableButton)
        Me.Controls.Add(Me.tablechecksTableButton)
        Me.Controls.Add(Me.inventoryTableButton)
        Me.Controls.Add(Me.employeeinfoTableButton)
        Me.Controls.Add(Me.createDatabaseButton)
        Me.Name = "firsttime"
        Me.Text = "firsttime"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents createDatabaseButton As System.Windows.Forms.Button
    Friend WithEvents employeeinfoTableButton As System.Windows.Forms.Button
    Friend WithEvents inventoryTableButton As System.Windows.Forms.Button
    Friend WithEvents tablechecksTableButton As System.Windows.Forms.Button
    Friend WithEvents tableoccupancyTableButton As System.Windows.Forms.Button
    Friend WithEvents tablewaitlistTableButton As System.Windows.Forms.Button
    Friend WithEvents createLabel As System.Windows.Forms.Label
    Friend WithEvents tablewaitlistPopulateButton As System.Windows.Forms.Button
    Friend WithEvents tableoccupancyPopulateButton As System.Windows.Forms.Button
    Friend WithEvents tablechecksPopulateButton As System.Windows.Forms.Button
    Friend WithEvents inventoryPopulateButton As System.Windows.Forms.Button
    Friend WithEvents employeeinfoPopulateButton As System.Windows.Forms.Button
    Friend WithEvents populateLabel As System.Windows.Forms.Label
    Friend WithEvents workLabel As System.Windows.Forms.Label
    Friend WithEvents timer As System.Windows.Forms.Timer
    Friend WithEvents dateLabel As System.Windows.Forms.Label
    Friend WithEvents timeLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents errorLabel As System.Windows.Forms.Label
    Friend WithEvents finishedButton As System.Windows.Forms.Button
End Class
