<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Level1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Level1))
        Me.GravityTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ObstacleTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.cat = New System.Windows.Forms.PictureBox()
        CType(Me.cat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GravityTimer
        '
        Me.GravityTimer.Enabled = True
        Me.GravityTimer.Interval = 40
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
        '
        'cat
        '
        Me.cat.BackColor = System.Drawing.Color.Transparent
        Me.cat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cat.Location = New System.Drawing.Point(108, 337)
        Me.cat.Name = "cat"
        Me.cat.Size = New System.Drawing.Size(115, 87)
        Me.cat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cat.TabIndex = 1
        Me.cat.TabStop = False
        '
        'Level1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1058, 492)
        Me.Controls.Add(Me.cat)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Level1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.cat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GravityTimer As System.Windows.Forms.Timer
    Friend WithEvents ObstacleTimer As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents cat As System.Windows.Forms.PictureBox

End Class
