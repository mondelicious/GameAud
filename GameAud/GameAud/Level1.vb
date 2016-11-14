Public Class Level1
    Dim yspeed As Integer = 0
    Dim gravity As Integer = 15
    Dim play As Integer = 0


    Dim UpWrd, Leftside, Rightside, jumping, playing As Boolean

    Dim obstacle(1) As PictureBox

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.W Then
            UpWrd = True

            yspeed = -15
            cat.BackgroundImage = My.Resources.c1
            cat.BackgroundImageLayout = ImageLayout.Stretch
            '   GravityTimer.Start()
        End If
        If e.KeyCode = Keys.Up Then
            UpWrd = True
            jumping = True
            yspeed = -15
            ' GravityTimer.Start()
        End If
        If e.KeyCode = Keys.A Then
            Leftside = True
            jumping = True
            yspeed = -15
            ' GravityTimer.Start()
        End If
        If e.KeyCode = Keys.Left Then
            Leftside = True
            jumping = True
            yspeed = -15
            '  GravityTimer.Start()
        End If
        If e.KeyCode = Keys.D Then
            Rightside = True
            jumping = True
            yspeed = -15
            ' GravityTimer.Start()
        End If
        If e.KeyCode = Keys.Right Then
            Rightside = True
            jumping = True
            yspeed = -15

        End If

        GravityTimer.Start()

    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.W Then
            UpWrd = False


        End If
        If e.KeyCode = Keys.Up Then
            UpWrd = False

        End If


        If e.KeyCode = Keys.A Then
            Leftside = False

        End If
        If e.KeyCode = Keys.Left Then
            Leftside = False

        End If

        If e.KeyCode = Keys.D Then
            Rightside = False

        End If
        If e.KeyCode = Keys.Right Then
            Rightside = False

        End If


    End Sub

    Sub bgmcontrolon()
        My.Computer.Audio.Play(My.Resources.BGM_BubbleWorld, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        bgmcontrolon()

        createobstacle(1)

        Timer1.Enabled = True

    End Sub

    Private Sub GravityTimer_Tick(sender As Object, e As EventArgs) Handles GravityTimer.Tick
        yspeed += gravity
        cat.Top += yspeed

        '  If cat.Bounds.IntersectsWith(floor.Bounds) Then

        ' GravityTimer.Stop()

        '    End If
    End Sub

    Private Sub createobstacle(ByVal Number As Integer)
        Dim i As Integer = 0
        For i = 0 To Number
            Dim temp As New PictureBox
            Me.Controls.Add(temp)
            temp.Width = 70
            temp.Height = 60 + 13 * Rnd()
            temp.BackColor = Color.Transparent

            temp.BackgroundImage = My.Resources.stone_PNG13590
            temp.BackgroundImageLayout = ImageLayout.Stretch


            temp.Top = 450
            temp.Left = (i * 600) + 400
            obstacle(i) = temp
            obstacle(i).Visible = True

        Next

    End Sub

    Private Sub ObstacleTimer_Tick(sender As Object, e As EventArgs) Handles ObstacleTimer.Tick
        For i = 0 To 1
            obstacle(i).Left -= 2
            If obstacle(i).Left < 0 Then
                obstacle(i).Left += (i * 900) + 800
            End If
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If UpWrd = True Then
            cat.Top -= 10
            If cat.Top <= 0 Then
                cat.Top = 0
            End If
        End If

        If Leftside = True Then
            cat.Left -= 10

            If cat.Left <= 0 Then
                cat.Left = 0
            End If
        End If

        If Rightside = True Then
            cat.Left += 10
            If cat.Left + 60 >= Me.Width Then
                cat.Left = Me.Width - 100
            End If
        End If
        If cat.Top + 100 >= Me.Height Then
            cat.Top = Me.Height - 120
            GravityTimer.Stop()
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        play += 1

            If play = 1 Then
            cat.BackgroundImage = My.Resources.c1
            ' cat.BackgroundImageLayout = ImageLayout.Stretch
            play = 2 + 1
            ElseIf play = 2 Then
            cat.BackgroundImage = My.Resources.c2
            ' cat.BackgroundImageLayout = ImageLayout.Stretch
            play = 3
            ElseIf play = 3 Then
            cat.BackgroundImage = My.Resources.c3
            ' cat.BackgroundImageLayout = ImageLayout.Stretch
                play = 4
            ElseIf play = 4 Then
            cat.BackgroundImage = My.Resources.c4
            ' cat.BackgroundImageLayout = ImageLayout.Stretch
                play = 5
            ElseIf play = 5 Then
            cat.BackgroundImage = My.Resources.c5
            '  cat.BackgroundImageLayout = ImageLayout.Stretch
                play = 6
            ElseIf play = 6 Then
            cat.BackgroundImage = My.Resources.c6
            ' cat.BackgroundImageLayout = ImageLayout.Stretch
                play = 1
            End If

    End Sub
End Class
