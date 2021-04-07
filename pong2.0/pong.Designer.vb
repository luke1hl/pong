<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pong
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
        Me.baller = New System.Windows.Forms.Label()
        Me.leftpaddle = New System.Windows.Forms.Label()
        Me.pingpongtable = New System.Windows.Forms.PictureBox()
        Me.rightpaddle = New System.Windows.Forms.Label()
        Me.leftpaddlescore = New System.Windows.Forms.Label()
        Me.rightpaddlescore = New System.Windows.Forms.Label()
        Me.play = New System.Windows.Forms.Button()
        Me.Pause = New System.Windows.Forms.Button()
        Me.reset = New System.Windows.Forms.Button()
        Me.Escape = New System.Windows.Forms.Button()
        Me.balltimer = New System.Windows.Forms.Timer(Me.components)
        Me.paddletimer = New System.Windows.Forms.Timer(Me.components)
        Me.endofround = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pingpongtable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'baller
        '
        Me.baller.BackColor = System.Drawing.Color.LawnGreen
        Me.baller.Location = New System.Drawing.Point(324, 244)
        Me.baller.Name = "baller"
        Me.baller.Size = New System.Drawing.Size(16, 16)
        Me.baller.TabIndex = 1
        '
        'leftpaddle
        '
        Me.leftpaddle.BackColor = System.Drawing.Color.LawnGreen
        Me.leftpaddle.Location = New System.Drawing.Point(23, 212)
        Me.leftpaddle.Name = "leftpaddle"
        Me.leftpaddle.Size = New System.Drawing.Size(16, 80)
        Me.leftpaddle.TabIndex = 2
        '
        'pingpongtable
        '
        Me.pingpongtable.ErrorImage = Global.pong2._0.My.Resources.Resources.pong_table1
        Me.pingpongtable.Image = Global.pong2._0.My.Resources.Resources.pong_table1
        Me.pingpongtable.Location = New System.Drawing.Point(12, 12)
        Me.pingpongtable.Name = "pingpongtable"
        Me.pingpongtable.Size = New System.Drawing.Size(640, 480)
        Me.pingpongtable.TabIndex = 0
        Me.pingpongtable.TabStop = False
        '
        'rightpaddle
        '
        Me.rightpaddle.BackColor = System.Drawing.Color.LawnGreen
        Me.rightpaddle.Location = New System.Drawing.Point(625, 212)
        Me.rightpaddle.Name = "rightpaddle"
        Me.rightpaddle.Size = New System.Drawing.Size(16, 80)
        Me.rightpaddle.TabIndex = 3
        '
        'leftpaddlescore
        '
        Me.leftpaddlescore.AutoSize = True
        Me.leftpaddlescore.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leftpaddlescore.ForeColor = System.Drawing.Color.White
        Me.leftpaddlescore.Location = New System.Drawing.Point(210, 40)
        Me.leftpaddlescore.Name = "leftpaddlescore"
        Me.leftpaddlescore.Size = New System.Drawing.Size(29, 31)
        Me.leftpaddlescore.TabIndex = 4
        Me.leftpaddlescore.Text = "0"
        '
        'rightpaddlescore
        '
        Me.rightpaddlescore.AutoSize = True
        Me.rightpaddlescore.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rightpaddlescore.ForeColor = System.Drawing.Color.White
        Me.rightpaddlescore.Location = New System.Drawing.Point(420, 40)
        Me.rightpaddlescore.Name = "rightpaddlescore"
        Me.rightpaddlescore.Size = New System.Drawing.Size(29, 31)
        Me.rightpaddlescore.TabIndex = 5
        Me.rightpaddlescore.Text = "0"
        '
        'play
        '
        Me.play.BackColor = System.Drawing.Color.GreenYellow
        Me.play.Location = New System.Drawing.Point(566, 506)
        Me.play.Name = "play"
        Me.play.Size = New System.Drawing.Size(75, 23)
        Me.play.TabIndex = 6
        Me.play.Text = "play"
        Me.play.UseVisualStyleBackColor = False
        '
        'Pause
        '
        Me.Pause.BackColor = System.Drawing.Color.LawnGreen
        Me.Pause.Location = New System.Drawing.Point(485, 506)
        Me.Pause.Name = "Pause"
        Me.Pause.Size = New System.Drawing.Size(75, 23)
        Me.Pause.TabIndex = 7
        Me.Pause.Text = "pause"
        Me.Pause.UseVisualStyleBackColor = False
        '
        'reset
        '
        Me.reset.BackColor = System.Drawing.Color.Lime
        Me.reset.Location = New System.Drawing.Point(404, 506)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(75, 23)
        Me.reset.TabIndex = 8
        Me.reset.Text = "reset"
        Me.reset.UseVisualStyleBackColor = False
        '
        'Escape
        '
        Me.Escape.BackColor = System.Drawing.Color.Red
        Me.Escape.Location = New System.Drawing.Point(12, 502)
        Me.Escape.Name = "Escape"
        Me.Escape.Size = New System.Drawing.Size(36, 31)
        Me.Escape.TabIndex = 9
        Me.Escape.Text = "X"
        Me.Escape.UseVisualStyleBackColor = False
        '
        'balltimer
        '
        Me.balltimer.Interval = 10
        '
        'paddletimer
        '
        Me.paddletimer.Interval = 10
        '
        'endofround
        '
        Me.endofround.Interval = 3000
        '
        'pong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(664, 541)
        Me.Controls.Add(Me.Escape)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.Pause)
        Me.Controls.Add(Me.play)
        Me.Controls.Add(Me.rightpaddlescore)
        Me.Controls.Add(Me.leftpaddlescore)
        Me.Controls.Add(Me.rightpaddle)
        Me.Controls.Add(Me.leftpaddle)
        Me.Controls.Add(Me.baller)
        Me.Controls.Add(Me.pingpongtable)
        Me.Name = "pong"
        Me.Text = "pong"
        CType(Me.pingpongtable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pingpongtable As PictureBox
    Friend WithEvents baller As Label
    Friend WithEvents leftpaddle As Label
    Friend WithEvents rightpaddle As Label
    Friend WithEvents leftpaddlescore As Label
    Friend WithEvents rightpaddlescore As Label
    Friend WithEvents play As Button
    Friend WithEvents Pause As Button
    Friend WithEvents reset As Button
    Friend WithEvents Escape As Button
    Friend WithEvents balltimer As Timer
    Friend WithEvents paddletimer As Timer
    Friend WithEvents endofround As Timer
End Class
