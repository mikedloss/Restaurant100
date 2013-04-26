<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cook))
        Me.welcomeLabel = New System.Windows.Forms.Label()
        Me.timeLabel = New System.Windows.Forms.Label()
        Me.dateLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.noteLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.logoutButton = New System.Windows.Forms.Button()
        Me.clockOutButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'welcomeLabel
        '
        Me.welcomeLabel.AutoSize = True
        Me.welcomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcomeLabel.Location = New System.Drawing.Point(53, 54)
        Me.welcomeLabel.Name = "welcomeLabel"
        Me.welcomeLabel.Size = New System.Drawing.Size(126, 31)
        Me.welcomeLabel.TabIndex = 0
        Me.welcomeLabel.Text = "Welcome"
        '
        'timeLabel
        '
        Me.timeLabel.AutoSize = True
        Me.timeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeLabel.Location = New System.Drawing.Point(54, 94)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(52, 25)
        Me.timeLabel.TabIndex = 1
        Me.timeLabel.Text = "time"
        '
        'dateLabel
        '
        Me.dateLabel.AutoSize = True
        Me.dateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateLabel.Location = New System.Drawing.Point(54, 128)
        Me.dateLabel.Name = "dateLabel"
        Me.dateLabel.Size = New System.Drawing.Size(54, 25)
        Me.dateLabel.TabIndex = 2
        Me.dateLabel.Text = "date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 588)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(550, 80)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'timer
        '
        Me.timer.Enabled = True
        Me.timer.Interval = 1000
        '
        'noteLabel
        '
        Me.noteLabel.AutoSize = True
        Me.noteLabel.Location = New System.Drawing.Point(111, 374)
        Me.noteLabel.Name = "noteLabel"
        Me.noteLabel.Size = New System.Drawing.Size(41, 20)
        Me.noteLabel.TabIndex = 4
        Me.noteLabel.Text = "note"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 354)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Notes for today:"
        '
        'logoutButton
        '
        Me.logoutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutButton.Location = New System.Drawing.Point(722, 12)
        Me.logoutButton.Name = "logoutButton"
        Me.logoutButton.Size = New System.Drawing.Size(530, 530)
        Me.logoutButton.TabIndex = 29
        Me.logoutButton.Text = "CLOSE WINDOW"
        Me.logoutButton.UseVisualStyleBackColor = True
        '
        'clockOutButton
        '
        Me.clockOutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clockOutButton.Location = New System.Drawing.Point(976, 600)
        Me.clockOutButton.Name = "clockOutButton"
        Me.clockOutButton.Size = New System.Drawing.Size(276, 68)
        Me.clockOutButton.TabIndex = 30
        Me.clockOutButton.Text = "CLOCK OUT"
        Me.clockOutButton.UseVisualStyleBackColor = True
        '
        'cook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1264, 680)
        Me.Controls.Add(Me.clockOutButton)
        Me.Controls.Add(Me.logoutButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.noteLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dateLabel)
        Me.Controls.Add(Me.timeLabel)
        Me.Controls.Add(Me.welcomeLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "cook"
        Me.Text = "cook"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents welcomeLabel As System.Windows.Forms.Label
    Friend WithEvents timeLabel As System.Windows.Forms.Label
    Friend WithEvents dateLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents timer As System.Windows.Forms.Timer
    Friend WithEvents noteLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents logoutButton As System.Windows.Forms.Button
    Friend WithEvents clockOutButton As System.Windows.Forms.Button
End Class
