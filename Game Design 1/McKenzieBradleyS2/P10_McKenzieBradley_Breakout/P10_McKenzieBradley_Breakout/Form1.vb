Public Class Form1
    Dim xDir As Boolean
    Dim yDir As Boolean
    Dim xSpeed As Integer = 4
    Dim ySpeed As Integer = 4
    Dim block(0 To 47) As Label
    Dim xBall As Integer
    Dim yBall As Integer
    Dim score As Integer

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        block(0) = lbl0
        block(1) = lbl1
        block(2) = lbl2
        block(3) = lbl3
        block(4) = lbl4
        block(5) = lbl5
        block(6) = lbl6
        block(7) = lbl7
        block(8) = lbl8
        block(9) = lbl9
        block(10) = lbl10
        block(11) = lbl11
        block(12) = lbl12
        block(13) = lbl13
        block(14) = lbl14
        block(15) = lbl15
        block(16) = lbl16
        block(17) = lbl17
        block(18) = lbl18
        block(19) = lbl19
        block(20) = lbl20
        block(21) = lbl21
        block(22) = lbl22
        block(23) = lbl23
        block(24) = lbl24
        block(25) = lbl25
        block(26) = lbl26
        block(27) = lbl27
        block(28) = lbl28
        block(29) = lbl29
        block(30) = lbl30
        block(31) = lbl31
        block(32) = lbl32
        block(33) = lbl33
        block(34) = lbl34
        block(35) = lbl35
        block(36) = lbl36
        block(37) = lbl37
        block(38) = lbl38
        block(39) = lbl39
        block(40) = lbl40
        block(41) = lbl41
        block(42) = lbl42
        block(43) = lbl43
        block(44) = lbl44
        block(45) = lbl45
        block(46) = lbl46
        block(47) = lbl47
       
        xBall = picBall.Left
        yBall = picBall.Top
    End Sub

    Private Sub tmrBall_Tick(sender As System.Object, e As System.EventArgs) Handles tmrBall.Tick
        If (xDir) Then
            picBall.Left += xSpeed
            If picBall.Left > Me.Width - 40 Then xDir = False
        Else
            picBall.Left -= xSpeed
            If picBall.Left < 0 Then xDir = True
        End If
        If (yDir) Then
            picBall.Top += ySpeed
            chkPaddle()
            If picBall.Top > Me.Height Then
                tmrBall.Enabled = False
                lblScore.Text = "Score = " + score.ToString
                lblScore.Visible = True
            End If
        Else
            picBall.Top -= ySpeed
            If picBall.Top < 25 Then yDir = True
        End If
        chkBlock()
    End Sub

    Public Sub chkPaddle()
        If lblPaddle.Bounds.IntersectsWith(picBall.Bounds) Then
            yDir = False
            xSpeed = Rnd() * 5
        End If
    End Sub

    Public Sub chkBlock()
        For i = 0 To 47
            If block(i).Bounds.IntersectsWith(picBall.Bounds) _
            And block(i).Visible = True Then
                block(i).Visible = False
                score += 10
                lblScore.Text = score.ToString
                If score = 420 Then
                    lblScore.Visible = True
                    tmrBall.Enabled = False
                End If
                If yDir = True Then
                    yDir = False
                Else
                    yDir = True
                End If
            End If
        Next
    End Sub

    Public Sub reset()
        For i = 0 To 47
            block(i).Visible = True
        Next
        picBall.Left = xBall
        picBall.Top = yBall
        tmrBall.Enabled = True
        score = 0
        lblScore.Text = score.ToString
        lblScore.Visible = False
        picBall.Top = 200
        yDir = True
    End Sub

    Private Sub PlayToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PlayToolStripMenuItem.Click
        reset()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub tmrLeft_Tick(sender As System.Object, e As System.EventArgs) Handles tmrLeft.Tick
        lblPaddle.Left -= 8
        If lblPaddle.Left < 0 Then lblPaddle.Left = 0
    End Sub

    Private Sub tmrRight_Tick(sender As System.Object, e As System.EventArgs) Handles tmrRight.Tick
        lblPaddle.Left += 8
        If lblPaddle.Left > Me.Width - 88 Then lblPaddle.Left = Me.Width - 88
    End Sub

    Private Sub Form1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = 37 Then
            tmrLeft.Enabled = True
        ElseIf e.KeyValue = 39 Then
            tmrRight.Enabled = True
        ElseIf e.KeyValue = 32 Then
            reset()
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = 37 Then
            tmrLeft.Enabled = False
        ElseIf e.KeyValue = 39 Then
            tmrRight.Enabled = False
        End If
    End Sub

 
End Class
