Public Class GameOver
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Start.Show()
        Level1.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveScore.Show()
        Level1.Close()
    End Sub
End Class