<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Highscores
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ScoretblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ScoresDataSet = New GameAud.ScoresDataSet()
        Me.Score_tblTableAdapter = New GameAud.ScoresDataSetTableAdapters.Score_tblTableAdapter()
        Me.High1 = New System.Windows.Forms.Label()
        Me.High2 = New System.Windows.Forms.Label()
        Me.High3 = New System.Windows.Forms.Label()
        Me.High4 = New System.Windows.Forms.Label()
        Me.High5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScoretblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScoresDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ColumnHeadersVisible = False
        Me.DataGridView1.Location = New System.Drawing.Point(354, 122)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(326, 237)
        Me.DataGridView1.TabIndex = 0
        '
        'ScoretblBindingSource
        '
        Me.ScoretblBindingSource.DataMember = "Score_tbl"
        Me.ScoretblBindingSource.DataSource = Me.ScoresDataSet
        '
        'ScoresDataSet
        '
        Me.ScoresDataSet.DataSetName = "ScoresDataSet"
        Me.ScoresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Score_tblTableAdapter
        '
        Me.Score_tblTableAdapter.ClearBeforeFill = True
        '
        'High1
        '
        Me.High1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.High1.BackColor = System.Drawing.Color.Transparent
        Me.High1.Font = New System.Drawing.Font("Maiandra GD", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.High1.Location = New System.Drawing.Point(3, 36)
        Me.High1.Name = "High1"
        Me.High1.Size = New System.Drawing.Size(348, 35)
        Me.High1.TabIndex = 1
        Me.High1.Text = "Label1"
        Me.High1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'High2
        '
        Me.High2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.High2.BackColor = System.Drawing.Color.Transparent
        Me.High2.Font = New System.Drawing.Font("Maiandra GD", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.High2.Location = New System.Drawing.Point(0, 71)
        Me.High2.Name = "High2"
        Me.High2.Size = New System.Drawing.Size(351, 34)
        Me.High2.TabIndex = 2
        Me.High2.Text = "Label2"
        Me.High2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'High3
        '
        Me.High3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.High3.BackColor = System.Drawing.Color.Transparent
        Me.High3.Font = New System.Drawing.Font("Maiandra GD", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.High3.Location = New System.Drawing.Point(0, 105)
        Me.High3.Name = "High3"
        Me.High3.Size = New System.Drawing.Size(351, 34)
        Me.High3.TabIndex = 3
        Me.High3.Text = "Label3"
        Me.High3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'High4
        '
        Me.High4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.High4.BackColor = System.Drawing.Color.Transparent
        Me.High4.Font = New System.Drawing.Font("Maiandra GD", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.High4.Location = New System.Drawing.Point(0, 139)
        Me.High4.Name = "High4"
        Me.High4.Size = New System.Drawing.Size(351, 34)
        Me.High4.TabIndex = 4
        Me.High4.Text = "Label4"
        Me.High4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'High5
        '
        Me.High5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.High5.BackColor = System.Drawing.Color.Transparent
        Me.High5.Font = New System.Drawing.Font("Maiandra GD", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.High5.Location = New System.Drawing.Point(0, 173)
        Me.High5.Name = "High5"
        Me.High5.Size = New System.Drawing.Size(351, 34)
        Me.High5.TabIndex = 5
        Me.High5.Text = "Label5"
        Me.High5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Highscores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GameAud.My.Resources.Resources.bg
        Me.ClientSize = New System.Drawing.Size(350, 248)
        Me.Controls.Add(Me.High5)
        Me.Controls.Add(Me.High4)
        Me.Controls.Add(Me.High3)
        Me.Controls.Add(Me.High2)
        Me.Controls.Add(Me.High1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Highscores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Highscores"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScoretblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScoresDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ScoresDataSet As GameAud.ScoresDataSet
    Friend WithEvents ScoretblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Score_tblTableAdapter As GameAud.ScoresDataSetTableAdapters.Score_tblTableAdapter
    Friend WithEvents High1 As System.Windows.Forms.Label
    Friend WithEvents High2 As System.Windows.Forms.Label
    Friend WithEvents High3 As System.Windows.Forms.Label
    Friend WithEvents High4 As System.Windows.Forms.Label
    Friend WithEvents High5 As System.Windows.Forms.Label
End Class
