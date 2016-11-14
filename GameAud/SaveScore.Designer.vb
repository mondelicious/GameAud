<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaveScore
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.scoree = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.playername = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(17, 56)
        Me.Label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 47)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Score:"
        '
        'scoree
        '
        Me.scoree.AutoSize = True
        Me.scoree.BackColor = System.Drawing.Color.Transparent
        Me.scoree.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scoree.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.scoree.Location = New System.Drawing.Point(170, 56)
        Me.scoree.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.scoree.Name = "scoree"
        Me.scoree.Size = New System.Drawing.Size(68, 47)
        Me.scoree.TabIndex = 2
        Me.scoree.Text = "00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(109, 103)
        Me.Label4.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(237, 31)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Enter Your Name"
        '
        'playername
        '
        Me.playername.Location = New System.Drawing.Point(348, 100)
        Me.playername.Name = "playername"
        Me.playername.Size = New System.Drawing.Size(210, 38)
        Me.playername.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(288, 159)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 47)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SaveScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GameAud.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(636, 359)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.playername)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.scoree)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SaveScore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SaveScore"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents scoree As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents playername As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
