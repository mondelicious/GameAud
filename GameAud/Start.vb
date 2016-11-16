Public Class Start

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Sub bgmcontrolon()
        My.Computer.Audio.Play(My.Resources.Nyan_Cat__original_, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Level1.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Options.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Highscores.ShowDialog()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Credits.ShowDialog()

    End Sub

    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bgmcontrolon()
    End Sub
End Class