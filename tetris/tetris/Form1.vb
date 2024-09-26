Public Class Form1
    Dim score As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        follow(enemy, avatar, 10, 0)
        follow(enemy2, avatar, 0, 5)
        PaceX(enemy3, platform, 20)
    End Sub
    Sub PaceX(e As PictureBox, p As PictureBox, speed As Integer)
        Dim dir As Integer
        dir = e.Tag

        move(e, dir * speed, 0)

        If e.Location.X > p.Location.X + p.Width - 100 Then
            e.Tag = dir * -1
        End If
        If e.Location.X < p.Location.X Then
            e.Tag = dir * -1
        End If
    End Sub
    Sub PaceY(e As PictureBox, p As PictureBox, speed As Integer)
        Dim dir As Integer
        dir = e.Tag

        move(e, 0, dir * speed)

        If e.Location.Y < p.Location.Y Then
            e.Tag = dir * -1
        End If
        If e.Location.Y > p.Location.Y + p.Height / 2 Then
            e.Tag = dir * -1
        End If
    End Sub

    Sub follow(e As PictureBox, a As PictureBox, speedx As Integer, speedy As Integer)
        If e.Location.Y > a.Location.Y Then
            move(e, 0, -speedy)
        Else
            move(e, 0, speedy)
        End If
        If e.Location.X > a.Location.X Then
            move(e, -speedx, 0)
        Else
            move(e, speedx, 0)
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.A Then
            move(avatar, -5, 0)
        End If
        If e.KeyCode = Keys.Right Or e.KeyCode = Keys.D Then
            move(avatar, 5, 0)
        End If
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.S Then
            move(avatar, 0, 5)
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.W Then
            move(avatar, 0, -5)
        End If
        If e.KeyCode = Keys.Space Then
            avatar.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
            avatar.Refresh()
        End If
    End Sub
    Sub move(p As PictureBox, xdir As Integer, ydir As Integer)
        p.Location += New Point(xdir, ydir)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        score += 1
        score_label.Text = score
    End Sub
End Class
