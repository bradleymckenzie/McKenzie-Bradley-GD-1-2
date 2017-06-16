Public Class Form1
    Dim snake(0 To 15) As PictureBox
    Dim hits As Integer = 0
    Dim play As Boolean = False
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        snake(0) = pic0
        snake(1) = pic1
        snake(2) = pic2
        snake(3) = pic3
        snake(4) = pic4
        snake(5) = pic5
        snake(6) = pic6
        snake(7) = pic7
        snake(8) = pic8
        snake(9) = pic9
        snake(10) = pic10
        snake(11) = pic11
        snake(12) = pic12
        snake(13) = pic13
        snake(14) = pic14
        snake(15) = pic15
    End Sub

    Private Sub Form1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        tmrUp.Enabled = False
        tmrDown.Enabled = False
        tmrLeft.Enabled = False
        tmrRight.Enabled = False

        If e.KeyValue = 37 Then 'left
            tmrLeft.Enabled = True
        ElseIf e.KeyValue = 38 Then 'Up
            tmrUp.Enabled = True
        ElseIf e.KeyValue = 39 Then 'Right
            tmrRight.Enabled = True
        ElseIf e.KeyValue = 40 Then 'Down
            tmrDown.Enabled = True
        ElseIf e.KeyValue = 32 Then
            reset()
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        ' tmrUp.Enabled = False
        ' tmrDown.Enabled = False
        ' tmrLeft.Enabled = False
        ' tmrRight.Enabled = False
        '
        '        If e.KeyValue = 37 Then 'left
        ' tmrLeft.Enabled = False
        ' ElseIf e.KeyValue = 38 Then 'Up
        ' tmrUp.Enabled = False
        ' ElseIf e.KeyValue = 39 Then 'Right
        ' tmrRight.Enabled = False
        ' ElseIf e.KeyValue = 40 Then 'Down
        ' tmrDown.Enabled = False
        ' End If
    End Sub

    Private Sub tmrUp_Tick(sender As System.Object, e As System.EventArgs) Handles tmrUp.Tick
        If hits < 15 And play = True Then
            For i = 15 To 1 Step -1
                snake(i).Left = snake(i - 1).Left
                snake(i).Top = snake(i - 1).Top
            Next
            snake(0).Top -= 50
            snake(0).Image = picUp.Image
            chkMouse()
            chkBody()
            chkBorder()
        End If
    End Sub

    Private Sub tmrDown_Tick(sender As System.Object, e As System.EventArgs) Handles tmrDown.Tick
        If hits < 15 And play = True Then
            For i = 15 To 1 Step -1
                snake(i).Left = snake(i - 1).Left
                snake(i).Top = snake(i - 1).Top
            Next
            snake(0).Top += 50
            snake(0).Image = picDown.Image
            chkMouse()
            chkBody()
            chkBorder()
        End If
    End Sub

    Private Sub tmrLeft_Tick(sender As System.Object, e As System.EventArgs) Handles tmrLeft.Tick
        If hits < 15 And play = True Then
            For i = 15 To 1 Step -1
                snake(i).Left = snake(i - 1).Left
                snake(i).Top = snake(i - 1).Top
            Next
            snake(0).Left -= 50
            snake(0).Image = picLeft.Image
            chkMouse()
            chkBody()
            chkBorder()
        End If
    End Sub

    Private Sub tmrRight_Tick(sender As System.Object, e As System.EventArgs) Handles tmrRight.Tick
        If hits < 15 And play = True Then
            For i = 15 To 1 Step -1
                snake(i).Left = snake(i - 1).Left
                snake(i).Top = snake(i - 1).Top
            Next
            snake(0).Left += 50
            snake(0).Image = picRight.Image
            chkMouse()
            chkBody()
            chkBorder()
        End If
    End Sub

    Private Sub reset()
        picMouse.Top = Int(Rnd() * 10) * 50
        picMouse.Left = Int(Rnd() * 18) * 50

        snake(0).Top = Int(Rnd() * 10) * 50
        snake(0).Left = Int(Rnd() * 18) * 50

        picMouse.Visible = True

        For i = 1 To 15
            snake(i).Visible = False
        Next
        snake(0).Visible = True

        hits = 0
        play = True

        lblDisplay1.Visible = False
        lblDisplay2.Visible = False
        lblDisplay1.Text = ""
        lblDisplay2.Text = ""
    End Sub

    Private Sub chkMouse()
        If picMouse.Bounds.IntersectsWith(snake(0).Bounds) Then
            hits += 1
            If hits < 15 Then
                snake(hits).Visible = True
                picMouse.Top = Int(Rnd() * 10) * 50
                picMouse.Left = Int(Rnd() * 18) * 50
            Else
                lblDisplay1.Visible = True
                lblDisplay2.Visible = True
                lblDisplay1.Text = "Congratulations, You Won!"
                lblDisplay2.Text = "Press Space Bar to Play..."
                picMouse.Visible = False
            End If
        End If
    End Sub

    Private Sub chkBody()
        For i = 1 To 15
            If (snake(0).Bounds.IntersectsWith(snake(i).Bounds)) _
                And snake(i).Visible = True Then
                stopGame()
            End If
        Next
    End Sub

    Private Sub chkBorder()
        If snake(0).Left < 0 _
            Or snake(0).Left > Width - snake(0).Width _
            Or snake(0).Top < 0 _
            Or snake(0).Top > Height - snake(0).Height Then
            stopGame()
        End If
    End Sub

    Private Sub stopGame()
        play = False

        lblDisplay1.Visible = True
        lblDisplay2.Visible = True
        lblDisplay1.Text = "Nice Game, Try Again!"
        lblDisplay2.Text = "Press Space Bar to Play..."

        tmrUp.Enabled = False
        tmrDown.Enabled = False
        tmrLeft.Enabled = False
        tmrRight.Enabled = False

    End Sub
End Class
