﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Level1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GravityTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ObstacleTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.score = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.fish = New System.Windows.Forms.PictureBox()
        Me.wall = New System.Windows.Forms.PictureBox()
        Me.bird = New System.Windows.Forms.PictureBox()
        Me.cat = New System.Windows.Forms.PictureBox()
        Me.Timer7 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.fish, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bird, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GravityTimer
        '
        Me.GravityTimer.Enabled = True
        Me.GravityTimer.Interval = 90
        '
        'ObstacleTimer
        '
        Me.ObstacleTimer.Enabled = True
        Me.ObstacleTimer.Interval = 40
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.score, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip1.Size = New System.Drawing.Size(1058, 42)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'score
        '
        Me.score.Name = "score"
        Me.score.Size = New System.Drawing.Size(47, 37)
        Me.score.Text = "00"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(88, 37)
        Me.ToolStripStatusLabel2.Text = ":Score"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(496, 221)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 55)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Game over!"
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        Me.Timer4.Interval = 40
        '
        'Timer5
        '
        '
        'Timer6
        '
        '
        'fish
        '
        Me.fish.BackColor = System.Drawing.Color.Transparent
        Me.fish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.fish.Image = Global.GameAud.My.Resources.Resources.animated_fish_image_0025
        Me.fish.Location = New System.Drawing.Point(741, 279)
        Me.fish.Name = "fish"
        Me.fish.Size = New System.Drawing.Size(119, 109)
        Me.fish.TabIndex = 6
        Me.fish.TabStop = False
        '
        'wall
        '
        Me.wall.BackColor = System.Drawing.Color.Transparent
        Me.wall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.wall.Location = New System.Drawing.Point(866, 138)
        Me.wall.Name = "wall"
        Me.wall.Size = New System.Drawing.Size(180, 138)
        Me.wall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.wall.TabIndex = 5
        Me.wall.TabStop = False
        '
        'bird
        '
        Me.bird.BackColor = System.Drawing.Color.Transparent
        Me.bird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bird.Image = Global.GameAud.My.Resources.Resources.flamingo_flying_2
        Me.bird.Location = New System.Drawing.Point(81, 138)
        Me.bird.Name = "bird"
        Me.bird.Size = New System.Drawing.Size(180, 138)
        Me.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bird.TabIndex = 4
        Me.bird.TabStop = False
        '
        'cat
        '
        Me.cat.BackColor = System.Drawing.Color.Transparent
        Me.cat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cat.Location = New System.Drawing.Point(115, 348)
        Me.cat.Name = "cat"
        Me.cat.Size = New System.Drawing.Size(146, 80)
        Me.cat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.cat.TabIndex = 1
        Me.cat.TabStop = False
        '
        'Timer7
        '
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 57)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.TabIndex = 7
        Me.ProgressBar1.Visible = False
        '
        'Level1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1058, 492)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.fish)
        Me.Controls.Add(Me.wall)
        Me.Controls.Add(Me.bird)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.cat)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Level1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.fish, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bird, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GravityTimer As System.Windows.Forms.Timer
    Friend WithEvents ObstacleTimer As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents cat As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents score As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents bird As PictureBox
    Friend WithEvents Timer5 As Timer
    Friend WithEvents wall As PictureBox
    Friend WithEvents Timer6 As Timer
    Friend WithEvents fish As PictureBox
    Friend WithEvents Timer7 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
