<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Btn_GREEN = New System.Windows.Forms.Button()
        Me.Btn_RED = New System.Windows.Forms.Button()
        Me.Btn_YELLOW = New System.Windows.Forms.Button()
        Me.Btn_BLUE = New System.Windows.Forms.Button()
        Me.Restart = New System.Windows.Forms.Button()
        Me.Score = New System.Windows.Forms.Label()
        Me.Load = New System.Windows.Forms.Timer(Me.components)
        Me.Reset = New System.Windows.Forms.Timer(Me.components)
        Me.PlaySequence = New System.Windows.Forms.Timer(Me.components)
        Me.Time = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Btn_GREEN
        '
        Me.Btn_GREEN.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Btn_GREEN.Location = New System.Drawing.Point(12, 94)
        Me.Btn_GREEN.Name = "Btn_GREEN"
        Me.Btn_GREEN.Size = New System.Drawing.Size(225, 225)
        Me.Btn_GREEN.TabIndex = 0
        Me.Btn_GREEN.UseVisualStyleBackColor = False
        '
        'Btn_RED
        '
        Me.Btn_RED.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Btn_RED.Location = New System.Drawing.Point(246, 94)
        Me.Btn_RED.Name = "Btn_RED"
        Me.Btn_RED.Size = New System.Drawing.Size(225, 225)
        Me.Btn_RED.TabIndex = 1
        Me.Btn_RED.UseVisualStyleBackColor = False
        '
        'Btn_YELLOW
        '
        Me.Btn_YELLOW.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Btn_YELLOW.Location = New System.Drawing.Point(12, 325)
        Me.Btn_YELLOW.Name = "Btn_YELLOW"
        Me.Btn_YELLOW.Size = New System.Drawing.Size(225, 225)
        Me.Btn_YELLOW.TabIndex = 3
        Me.Btn_YELLOW.UseVisualStyleBackColor = False
        '
        'Btn_BLUE
        '
        Me.Btn_BLUE.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Btn_BLUE.Location = New System.Drawing.Point(247, 325)
        Me.Btn_BLUE.Name = "Btn_BLUE"
        Me.Btn_BLUE.Size = New System.Drawing.Size(225, 225)
        Me.Btn_BLUE.TabIndex = 2
        Me.Btn_BLUE.UseVisualStyleBackColor = False
        '
        'Restart
        '
        Me.Restart.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Restart.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.Restart.Location = New System.Drawing.Point(245, 22)
        Me.Restart.Name = "Restart"
        Me.Restart.Size = New System.Drawing.Size(226, 57)
        Me.Restart.TabIndex = 4
        Me.Restart.Text = "Restart"
        Me.Restart.UseVisualStyleBackColor = False
        '
        'Score
        '
        Me.Score.AutoSize = True
        Me.Score.BackColor = System.Drawing.Color.Transparent
        Me.Score.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score.Location = New System.Drawing.Point(12, 49)
        Me.Score.Name = "Score"
        Me.Score.Size = New System.Drawing.Size(107, 30)
        Me.Score.TabIndex = 5
        Me.Score.Text = "Score: 0"
        '
        'Load
        '
        Me.Load.Interval = 500
        '
        'Reset
        '
        Me.Reset.Interval = 200
        '
        'PlaySequence
        '
        Me.PlaySequence.Interval = 1000
        '
        'Time
        '
        Me.Time.AutoSize = True
        Me.Time.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Time.Location = New System.Drawing.Point(13, 9)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(153, 22)
        Me.Time.TabIndex = 6
        Me.Time.Text = "60 Seconds Left"
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 562)
        Me.Controls.Add(Me.Time)
        Me.Controls.Add(Me.Score)
        Me.Controls.Add(Me.Restart)
        Me.Controls.Add(Me.Btn_YELLOW)
        Me.Controls.Add(Me.Btn_BLUE)
        Me.Controls.Add(Me.Btn_RED)
        Me.Controls.Add(Me.Btn_GREEN)
        Me.Name = "Form1"
        Me.Text = "Simon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_GREEN As System.Windows.Forms.Button
    Friend WithEvents Btn_RED As System.Windows.Forms.Button
    Friend WithEvents Btn_YELLOW As System.Windows.Forms.Button
    Friend WithEvents Btn_BLUE As System.Windows.Forms.Button
    Friend WithEvents Restart As System.Windows.Forms.Button
    Friend WithEvents Score As System.Windows.Forms.Label
    Friend WithEvents Load As System.Windows.Forms.Timer
    Friend WithEvents Reset As System.Windows.Forms.Timer
    Friend WithEvents PlaySequence As System.Windows.Forms.Timer
    Friend WithEvents Time As System.Windows.Forms.Label
    Friend WithEvents Timer As System.Windows.Forms.Timer

End Class
