Public Class Highscores
    Dim connstr As String = System.Environment.CurrentDirectory.ToString & "\scores.accdb"
    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & connstr & "")
    Dim pname1, pname2, pname3, pname4, pname5 As String
    Dim pscore1, pscore2, pscore3, pscore4, pscore5 As String
    Private Sub Highscores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ScoresDataSet.Score_tbl' table. You can move, or remove it, as needed.
        ' Me.Score_tblTableAdapter.FillBydec(Me.ScoresDataSet.Score_tbl)
        Try
           

            conn.Open()
            Dim dt As New DataTable
            
            Dim gg As New OleDb.OleDbDataAdapter("Select PlayerName, PlayerScore from Score_tbl order by Playerscore desc", conn)

            gg.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.Refresh()

            gg.Dispose()
          
        Catch ex As Exception

        End Try
        conn.Close()


        Try
            conn.Open()
            Dim i As Integer
            i = DataGridView1.CurrentRow.Index
            Dim rs As New OleDb.OleDbCommand("Select PlayerName, PlayerScore from Score_Tbl order by PlayerScore desc", conn)
            Dim reader As OleDb.OleDbDataReader = rs.ExecuteReader
            If reader.Read() Then
                pname1 = DataGridView1.Item(0, 0).Value
                pname2 = DataGridView1.Item(0, 1).Value
                pname3 = DataGridView1.Item(0, 2).Value
                pname4 = DataGridView1.Item(0, 3).Value
                pname5 = DataGridView1.Item(0, 4).Value
                pscore1 = DataGridView1.Item(1, 0).Value
                pscore2 = DataGridView1.Item(1, 1).Value
                pscore3 = DataGridView1.Item(1, 2).Value
                pscore4 = DataGridView1.Item(1, 3).Value
                pscore5 = DataGridView1.Item(1, 4).Value
                High1.Text = pname1.ToString + " - " + pscore1.ToString + " Pts."
                High2.Text = pname2.ToString + " - " + pscore2.ToString + " Pts."
                High3.Text = pname3.ToString + " - " + pscore3.ToString + " Pts."
                High4.Text = pname4.ToString + " - " + pscore4.ToString + " Pts."
                High5.Text = pname5.ToString + " - " + pscore5.ToString + " Pts."
               
            End If
        Catch ex As Exception

        End Try
        conn.Close()

    End Sub
End Class