Public Class Form1
    Dim balloon(0 To 9) As PictureBox
    Dim balloonColor(0 To 9) As PictureBox
    Dim speed(0 To 9) As Integer
    Dim bColor As Integer
    Dim score As Integer
    Dim seconds As Integer
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Randomize()

        balloon(0) = pic0
        balloon(1) = pic1
        balloon(2) = pic2
        balloon(3) = pic3
        balloon(4) = pic4
        balloon(5) = pic5
        balloon(6) = pic6
        balloon(7) = pic7
        balloon(8) = pic8
        balloon(9) = pic9

        balloonColor(0) = picRed
        balloonColor(1) = picLime
        balloonColor(2) = picBlue
        balloonColor(3) = picPink
        balloonColor(4) = picYellow
        balloonColor(5) = picTeal
        balloonColor(6) = picNavy
        balloonColor(7) = picPurple
        balloonColor(8) = picGold
        balloonColor(9) = picMaroon

        For i = 0 To 9
            getSpeed(i)
        Next

        For i = 0 To 9
            balloon(i).Top = (Rnd() * Me.Height) + Me.Height
        Next
    End Sub

    Private Sub Form1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = 32 Then
            tmrTime.Enabled = True
            tmrUp.Enabled = True
            score = 0
            seconds = 584
            lblScore.Text = score.ToString
        End If
        For i = 0 To 9
            balloon(i).Top = (Rnd() * Me.Height) + Me.Height
            balloon(i).Visible = True
        Next
    End Sub

    Private Sub tmrTime_Tick(sender As System.Object, e As System.EventArgs) Handles tmrTime.Tick
        seconds -= 1
        If seconds < 0 Then seconds = 0
        pgrTime.Value = seconds
        If seconds = 0 Then
            tmrUp.Enabled = False
            tmrTime.Enabled = False
        End If
    End Sub

    Private Sub tmrUp_Tick(sender As System.Object, e As System.EventArgs) Handles tmrUp.Tick
        For i = 0 To 9
            balloon(i).Top -= speed(i)
            If balloon(i).Top < 0 Then
                bColor = Math.Floor(Rnd() * 10)
                balloon(i).Top = (Rnd() * Me.Height) + Me.Height
                balloon(i).Visible = True
                balloon(i).Image = balloonColor(bColor).Image
            End If
        Next
    End Sub
    Public Sub getSpeed(ByVal i As Integer)
        speed(i) = Math.Floor(Rnd() * 4 + 2)
    End Sub

    Public Sub popBalloon(ByVal i As Integer)
        If tmrTime.Enabled = True Then
            My.Computer.Audio.Play("Z:\P18_McKenzieBradley_Balloons\P18_McKenzieBradley_Balloons\BalloonPopping.wav", AudioPlayMode.Background)
            bColor = Math.Floor(Rnd() * 10)
            balloon(i).Top = Rnd() * Me.Height + Me.Height
            balloon(i).Image = balloonColor(bColor).Image
            getSpeed(i)
            score += 1
            lblScore.Text = score.ToString
        End If
    End Sub

    Private Sub pic0_MouseEnter(sender As System.Object, e As System.EventArgs) Handles pic0.MouseEnter
        popBalloon(0)
    End Sub

    Private Sub pic1_MouseEnter(sender As System.Object, e As System.EventArgs) Handles pic1.MouseEnter
        popBalloon(1)
    End Sub

    Private Sub pic2_MouseEnter(sender As System.Object, e As System.EventArgs) Handles pic2.MouseEnter
        popBalloon(2)
    End Sub

    Private Sub pic3_MouseEnter(sender As System.Object, e As System.EventArgs) Handles pic3.MouseEnter
        popBalloon(3)
    End Sub

    Private Sub pic4_MouseEnter(sender As System.Object, e As System.EventArgs) Handles pic4.MouseEnter
        popBalloon(4)
    End Sub

    Private Sub pic5_MouseEnter(sender As System.Object, e As System.EventArgs) Handles pic5.MouseEnter
        popBalloon(5)
    End Sub

    Private Sub pic6_MouseEnter(sender As System.Object, e As System.EventArgs) Handles pic6.MouseEnter
        popBalloon(6)
    End Sub

    Private Sub pic7_MouseEnter(sender As System.Object, e As System.EventArgs) Handles pic7.MouseEnter
        popBalloon(7)
    End Sub

    Private Sub pic8_MouseEnter(sender As System.Object, e As System.EventArgs) Handles pic8.MouseEnter
        popBalloon(8)
    End Sub

    Private Sub pic9_MouseEnter(sender As System.Object, e As System.EventArgs) Handles pic9.MouseEnter
        popBalloon(9)
    End Sub
End Class

