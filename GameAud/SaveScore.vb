Public Class SaveScore
    Dim connstr As String = System.Environment.CurrentDirectory.ToString & "\scores.accdb"
    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & connstr & "")
    Private Sub SaveScore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        scoree.Text = Level1.score.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn.Open()
            Dim addsc As New OleDb.OleDbCommand("Insert into score_tbl (PlayerName, PlayerScore)values('" & playername.Text & "', '" & scoree.Text & "')", conn)
            addsc.ExecuteNonQuery()
            playername.Clear()
            scoree.Text = ""
            Start.Show()
            Level1.Close()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Progress saved!", "")
        End Try
        conn.Close()

    End Sub
End Class