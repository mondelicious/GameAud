Public Class Level1
    Dim yspeed As Integer = 0
    Dim gravity As Integer = 20
    Dim play As Integer = 0
    Dim scoret As Integer = 0
    Dim warn As Integer = 0
    Dim UpWrd, Leftside, Rightside, jumping, playing As Boolean
    Dim obstacle(4) As PictureBox
    Dim obstaclee(4) As PictureBox
    Private Sub Level1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.W Then
            UpWrd = True
        End If
        If e.KeyCode = Keys.A Then
            Leftside = True
        End If
        If e.KeyCode = Keys.D Then
            Rightside = True
        End If
        If e.KeyCode = Keys.Up Then
            UpWrd = True
        ElseIf e.KeyCode = Keys.Left Then
            Leftside = True
        ElseIf e.KeyCode = Keys.Right Then
            Rightside = True
        End If

    End Sub
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        GravityTimer.Start()
        If e.KeyCode = Keys.W Then
            UpWrd = False
        ElseIf e.KeyCode = Keys.A Then
            Leftside = False
        ElseIf e.KeyCode = Keys.D Then
            Rightside = False
        End If

        If e.KeyCode = Keys.Up Then
            UpWrd = False
        ElseIf e.KeyCode = Keys.Left Then
            Leftside = False
        ElseIf e.KeyCode = Keys.Right Then
            Rightside = False
        End If


    End Sub
    Sub bgmcontrolon()
        My.Computer.Audio.Play(My.Resources.BGM_BubbleWorld, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cat.Parent = Me

        cat.BringToFront()
        cat.Image = My.Resources.cat_run_by_slence

        Me.BackgroundImage = My.Resources.bg1
        Me.BackgroundImageLayout = ImageLayout.Stretch

        bgmcontrolon()


        Label1.Hide()
        createobstacle(2)
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub

    Private Sub GravityTimer_Tick(sender As Object, e As EventArgs) Handles GravityTimer.Tick
        yspeed += gravity
        cat.Top += 50
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
            If score.Text = 50 Then
                temp.BackgroundImage = My.Resources.cactus
                temp.BackgroundImageLayout = ImageLayout.Stretch
            ElseIf score.Text > 51 Then
                If score.Text <= 100 Then
                    temp.BackgroundImage = My.Resources.trunk
                    temp.BackgroundImageLayout = ImageLayout.Stretch
                End If

            End If


            temp.Top = 450
            temp.Left = (i * 600) + 800
            obstacle(i) = temp
            obstacle(i).Visible = True

        Next

    End Sub
    Private Sub createobstaclee(ByVal Number As Integer)
        Dim i As Integer = 0
        For i = 0 To Number
            Dim temp2 As New PictureBox
            Me.Controls.Add(temp2)
            temp2.Width = 70
            temp2.Height = 60 + 13 * Rnd()
            temp2.BackColor = Color.Transparent

            temp2.BackgroundImage = My.Resources.stone_PNG13590
            temp2.BackgroundImageLayout = ImageLayout.Stretch
            'If score.Text = 50 Then
            '    temp.BackgroundImage = My.Resources.cactus
            '    temp.BackgroundImageLayout = ImageLayout.Stretch
            'ElseIf score.Text > 51 Then
            '    If score.Text <= 100 Then
            '        temp.BackgroundImage = My.Resources.trunk
            '        temp.BackgroundImageLayout = ImageLayout.Stretch
            '    End If

            'End If
            temp2.Top = 450
            temp2.Left = (i * 600) + 800
            obstaclee(i) = temp2
            obstaclee(i).Visible = True

        Next

    End Sub
    Private Sub ObstacleTimer_Tick(sender As Object, e As EventArgs) Handles ObstacleTimer.Tick
        For i = 0 To 1
            obstacle(i).Left -= 4
            If obstacle(i).Left < 0 Then
                obstacle(i).Left += (i * 1000) + 800
            End If
        Next

        
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If UpWrd = True Then
            cat.Top -= 5
            If cat.Top <= 0 Then
                cat.Top = 0
            End If
        End If

        If Leftside = True Then
            cat.Left -= 5

            If cat.Left <= 0 Then
                cat.Left = 0
            End If
        End If

        If Rightside = True Then
            cat.Left += 5
            If cat.Left + 60 >= Me.Width Then
                cat.Left = Me.Width - 100
            End If
        End If
        If cat.Top + 100 >= Me.Height Then
            cat.Top = Me.Height - 120
            GravityTimer.Stop()
        End If

        If cat.Bounds.IntersectsWith(obstacle(0).Bounds) Then
            obstacle(0).Hide()
            Timer1.Stop()
            Timer2.Stop()
            SaveScore.scoree.Text = score.Text
            ObstacleTimer.Stop()
            GameOver.ShowDialog()

        End If
        If cat.Bounds.IntersectsWith(obstacle(1).Bounds) Then
            Timer1.Stop()
            Timer2.Stop()
            SaveScore.scoree.Text = score.Text
            ObstacleTimer.Stop()
            GameOver.ShowDialog()
            obstacle(1).Visible = False



        End If
        If cat.Bounds.IntersectsWith(obstacle(2).Bounds) Then
            Timer1.Stop()
            Timer2.Stop()
            SaveScore.scoree.Text = score.Text
            ObstacleTimer.Stop()
            GameOver.ShowDialog()
            obstacle(2).Visible = False

        End If



    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Sub leftdef()
        cat.Left = 0
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        scoret += 1

        score.Text = scoret
        If score.Text = 25 Then
            Me.BackgroundImage = My.Resources.bg2
            Me.BackgroundImageLayout = ImageLayout.Stretch
            cat.Left = 0
            Label1.Text = "Level 2"
            Timer3.Start()
        End If
        If score.Text = 50 Then
            Me.BackgroundImage = My.Resources.bg3
            Me.BackgroundImageLayout = ImageLayout.Stretch
            cat.Left = 0
            Label1.Text = "Level 3"
            Timer3.Start()
        End If
        If score.Text = 75 Then
            Me.BackgroundImage = My.Resources._4
            Me.BackgroundImageLayout = ImageLayout.Stretch
            cat.Left = 0
            Label1.Text = "Level 4"
            Timer3.Start()
        End If

        If score.Text = 100 Then
            Me.BackgroundImage = My.Resources._5
            Me.BackgroundImageLayout = ImageLayout.Stretch
            cat.Left = 0
            Label1.Text = "Level 5"
            Timer3.Start()
        End If
        If score.Text = 100 Then
            SaveScore.ShowDialog()
        End If

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        warn += 1
        Label1.Show()
        If warn = 3 Then
            Label1.Hide()
            Timer3.Stop()
            warn = 0
        
        End If
    End Sub

  
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick

    End Sub
End Class
