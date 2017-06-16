Public Class Form2
    Dim alien(0 To 32) As PictureBox
    Dim bomb(0 To 4) As PictureBox
    Dim shield(0 To 5) As PictureBox
    Dim missile(0 To 9) As PictureBox
    Dim xLoc(0 To 32) As Integer
    Dim yLoc(0 To 32) As Integer
    Dim movemissile As Integer
    Dim dir As Boolean
    Dim img As Boolean
    Dim play As Boolean
    Dim score As Integer
    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        alien(0) = picAlien0
        alien(1) = picAlien1
        alien(2) = picAlien2
        alien(3) = picAlien3
        alien(4) = picAlien4
        alien(5) = picAlien5
        alien(6) = picAlien6
        alien(7) = picAlien7
        alien(8) = picAlien8
        alien(9) = picAlien9
        alien(10) = picAlien10
        alien(11) = picAlien11
        alien(12) = picAlien12
        alien(13) = picAlien13
        alien(14) = picAlien14
        alien(15) = picAlien15
        alien(16) = picAlien16
        alien(17) = picAlien17
        alien(18) = picAlien18
        alien(19) = picAlien19
        alien(20) = picAlien20
        alien(21) = picAlien21
        alien(22) = picAlien22
        alien(23) = picAlien23
        alien(24) = picAlien24
        alien(25) = picAlien25
        alien(26) = picAlien26
        alien(27) = picAlien27
        alien(28) = picAlien28
        alien(29) = picAlien29
        alien(30) = picAlien30
        alien(31) = picAlien31
        alien(32) = picAlien32

        bomb(0) = picBomb0
        bomb(1) = picBomb1
        bomb(2) = picBomb2
        bomb(3) = picBomb3
        bomb(4) = picBomb4

        shield(0) = picShield0
        shield(1) = picShield1
        shield(2) = picShield2
        shield(3) = picShield3
        shield(4) = picShield4
        shield(5) = picShield5

        missile(0) = picMissile0
        missile(1) = picMissile1
        missile(2) = picMissile2
        missile(3) = picMissile3
        missile(4) = picMissile4
        missile(5) = picMissile5
        missile(6) = picMissile6
        missile(7) = picMissile7
        missile(8) = picMissile8
        missile(9) = picMissile9

        For i = 0 To 32
            xLoc(i) = alien(i).Left
            yLoc(i) = alien(i).Top
        Next
    End Sub

    Private Sub Form2_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = 37 And play = True Then
            tmrLeft.Enabled = True
        ElseIf e.KeyValue = 39 And play = True Then
            tmrRight.Enabled = True
        ElseIf e.KeyValue = 13 Then
            reset()
        ElseIf e.KeyValue = 27 Then
            Application.Exit()
        ElseIf e.KeyValue = 32 And play = True Then
            movemissile += 1
            If movemissile > 9 Then movemissile = 0
            missile(movemissile).Top = picShip.Top
            missile(movemissile).Left = picShip.Left + (picShip.Width - picMissile0.Width) / 2
            missile(movemissile).Visible = True
            My.Computer.Audio.Play("Z:\P20_McKenzieBradley_CreativeGame\P20_McKenzieBradley_CreativeGame\Martian_Death_Ray-Mike_Koenig-937891031.wav", AudioPlayMode.Background)
        End If
    End Sub

    Private Sub Form2_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = 37 Then
            tmrLeft.Enabled = False
        ElseIf e.KeyValue = 39 Then
            tmrRight.Enabled = False

        End If
    End Sub
    Private Sub tmrLeft_Tick(sender As System.Object, e As System.EventArgs) Handles tmrLeft.Tick
        picShip.Left -= 5
        If picShip.Left < 0 Then picShip.Left = 0
    End Sub

    Private Sub tmrRight_Tick(sender As System.Object, e As System.EventArgs) Handles tmrRight.Tick
        picShip.Left += 5
        If picShip.Left > Me.Width - 65 Then picShip.Left = Me.Width - 65
    End Sub

    Private Sub tmrAlien_Tick(sender As System.Object, e As System.EventArgs) Handles tmrAlien.Tick
        If play = True Then
            getAlien()
            moveAlien()
        End If
    End Sub
    Public Sub moveAlien()
        If dir = True Then
            For i = 0 To 32
                alien(i).Left += 25
                If alien(i).Visible = True And alien(i).Left > Me.Width - (2 * alien(i).Width) Then
                    dir = False
                    moveDown(25)
                End If
            Next
        Else
            For i = 0 To 32
                alien(i).Left -= 25
                If alien(i).Visible = True And alien(i).Left < alien(i).Width Then
                    dir = True
                    moveDown(-25)
                End If
            Next
        End If
        'if alien hits shield, end game
        For a = 0 To 32
            For s = 0 To 5
                If alien(a).Bounds.IntersectsWith(shield(s).Bounds) Then
                    If alien(a).Visible = True Then
                        play = False
                        For i = 0 To 5
                            shield(i).Visible = False
                        Next
                    End If
                End If
            Next
        Next
    End Sub
    Public Sub moveDown(ByVal x As Integer)
        For i = 0 To 32
            alien(i).Top += 25
            alien(i).Left -= x
        Next
    End Sub

    Public Sub getAlien()
        If img = True Then
            For i = 0 To 32
                If i Mod 2 = 1 Then
                    alien(i).Image = picAlienA.Image
                Else
                    alien(i).Image = picAlienB.Image
                End If
            Next
            img = False
        Else
            For i = 0 To 32
                If i Mod 2 = 1 Then
                    alien(i).Image = picAlienB.Image
                Else
                    alien(i).Image = picAlienA.Image
                End If
            Next
            img = True

        End If
    End Sub

    Private Sub tmrBomb_Tick(sender As System.Object, e As System.EventArgs) Handles tmrBomb.Tick

        For i = 0 To 4
            bomb(i).Top += 1
            If bomb(i).Top > Me.Height Then
                For a = 32 To 0 Step -1
                    If alien(a).Visible = True Then
                        If alien(a).Left < picShip.Left And alien(a).Left + 50 > picShip.Left Then
                            bomb(i).Top = alien(32).Top + alien(a).Height
                            bomb(i).Left = picShip.Left + (alien(a).Width - picShip.Width) / 2
                            bomb(i).Visible = True
                            My.Computer.Audio.Play("Z:\P20_McKenzieBradley_CreativeGame\P20_McKenzieBradley_CreativeGame\Comet-SoundBible.com-1256431940.wav", AudioPlayMode.Background)
                        End If
                    End If
                Next
            End If
        Next

        'if bombs colides , make one invisible
        For x = 0 To 3
            For y = 1 To 4
                If bomb(x).Bounds.IntersectsWith(bomb(y).Bounds) Then
                    If bomb(x).Visible = True And bomb(y).Visible = True Then
                        bomb(y).Visible = False
                    End If
                End If
            Next
        Next
        hitShip()

    End Sub

    Public Sub chkShield()
        For s = 0 To 5
            For b = 0 To 4
                If shield(s).Bounds.IntersectsWith(bomb(b).Bounds) Then
                    bomb(b).Visible = False
                End If
            Next
        Next
    End Sub

    Public Sub hitAlien()
        For a = 0 To 32
            For m = 0 To 9
                If alien(a).Visible = True And missile(m).Visible = True Then
                    If alien(a).Bounds.IntersectsWith(missile(m).Bounds) Then
                        alien(a).Visible = False
                        missile(m).Visible = False
                        score += 10
                        lblScore.Text = score.ToString
                        My.Computer.Audio.Play("Z:\P20_McKenzieBradley_CreativeGame\P20_McKenzieBradley_CreativeGame\Flashbang-Kibblesbob-899170896.wav", AudioPlayMode.Background)
                    End If
                End If
            Next
        Next
    End Sub
    Public Sub hitBomb()
        For b = 0 To 4
            For m = 0 To 9
                If bomb(b).Visible = True And missile(m).Visible = True Then
                    If bomb(b).Bounds.IntersectsWith(missile(m).Bounds) Then
                        bomb(b).Visible = False
                        missile(m).Visible = False
                        score += 15
                        lblScore.Text = score.ToString
                        My.Computer.Audio.Play("Z:\P20_McKenzieBradley_CreativeGame\P20_McKenzieBradley_CreativeGame\Flashbang-Kibblesbob-899170896.wav", AudioPlayMode.Background)
                    End If
                End If
            Next
        Next
    End Sub
    Public Sub hitShield()
        'missile hits sheild
        For s = 0 To 5
            For m = 0 To 9
                If shield(s).Visible = True And missile(m).Visible = True Then
                    If shield(s).Bounds.IntersectsWith(missile(m).Bounds) Then
                        shield(s).Visible = False
                        missile(m).Visible = False
                        My.Computer.Audio.Play("Z:\P20_McKenzieBradley_CreativeGame\P20_McKenzieBradley_CreativeGame\Flashbang-Kibblesbob-899170896.wav", AudioPlayMode.Background)
                    End If
                End If
            Next
        Next
        'bomb hits shield
        For s = 0 To 5
            For b = 0 To 4
                If shield(s).Visible = True And bomb(b).Visible = True Then
                    If shield(s).Bounds.IntersectsWith(bomb(b).Bounds) Then
                        bomb(b).Visible = False
                        My.Computer.Audio.Play("Z:\P20_McKenzieBradley_CreativeGame\P20_McKenzieBradley_CreativeGame\Flashbang-Kibblesbob-899170896.wav", AudioPlayMode.Background)
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub tmrMissile_Tick(sender As System.Object, e As System.EventArgs) Handles tmrMissile.Tick
        If play = True Then
            For b = 0 To 9
                missile(b).Top -= 10
                hitAlien()
                hitShield()
                hitBomb()
            Next
        End If
    End Sub
    Public Sub hitShip()
        For b = 0 To 4
            If bomb(b).Bounds.IntersectsWith(picShip.Bounds) And bomb(b).Visible = True Then
                play = False
                tmrBomb.Enabled = False
                tmrAlien.Enabled = False
                tmrMissile.Enabled = False
                My.Computer.Audio.Play("Z:\P20_McKenzieBradley_CreativeGame\P20_McKenzieBradley_CreativeGame\Flashbang-Kibblesbob-899170896.wav", AudioPlayMode.Background)
            End If
        Next
    End Sub
    Public Sub reset()
        play = True
        score = 0
        lblScore.Text = score.ToString
        For i = 0 To 32
            alien(i).Left = xLoc(i)
            alien(i).Top = yLoc(i)
            alien(i).Visible = True
        Next
        For i = 0 To 4
            bomb(i).Visible = False
        Next
        For i = 0 To 9
            missile(i).Visible = False
        Next
        For i = 0 To 5
            shield(i).Visible = True
        Next
        tmrAlien.Enabled = True
        tmrBomb.Enabled = True
        tmrMissile.Enabled = True
    End Sub

    Private Sub PlayResetToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles PlayResetToolStripMenuItem.Click
        reset()
        play = True
    End Sub

    Private Sub ExitToolStripMenuItem2_Click_1(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem2.Click
        Application.Exit()
    End Sub
End Class
