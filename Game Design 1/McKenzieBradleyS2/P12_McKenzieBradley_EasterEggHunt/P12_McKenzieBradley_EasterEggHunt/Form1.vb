Public Class Form1
    Dim eggs(0 To 11) As PictureBox
    Dim found As Integer = 0
    Dim hidden As Integer = 12
    Dim seconds As Double = 0

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        eggs(0) = pic0
        eggs(1) = pic1
        eggs(2) = pic2
        eggs(3) = pic3
        eggs(4) = pic4
        eggs(5) = pic5
        eggs(6) = pic6
        eggs(7) = pic7
        eggs(8) = pic8
        eggs(9) = pic9
        eggs(10) = pic10
        eggs(11) = pic11
    End Sub
    Private Sub Form1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If lblFound.Text = "0" Then tmrSeconds.Enabled = True
        If e.KeyValue = 37 Then
            tmrLeft.Enabled = True
        ElseIf e.KeyValue = 38 Then
            tmrUp.Enabled = True
        ElseIf e.KeyValue = 39 Then
            tmrRight.Enabled = True
        ElseIf e.KeyValue = 40 Then
            tmrDown.Enabled = True
        ElseIf e.KeyValue = 32 Then
            reset()
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = 37 Then
            tmrLeft.Enabled = False
        ElseIf e.KeyValue = 38 Then
            tmrUp.Enabled = False
        ElseIf e.KeyValue = 39 Then
            tmrRight.Enabled = False
        ElseIf e.KeyValue = 40 Then
            tmrDown.Enabled = False
        End If
    End Sub

    Private Sub tmrLeft_Tick(sender As System.Object, e As System.EventArgs) Handles tmrLeft.Tick
        picBunny.Left -= 3
        If picBunny.Left < 0 Then picBunny.Left = 0
        chkEgg()
    End Sub

    Private Sub tmrRight_Tick(sender As System.Object, e As System.EventArgs) Handles tmrRight.Tick
        picBunny.Left += 3
        If picBunny.Left > Me.Width - 65 Then picBunny.Left = Me.Width - 65
        chkEgg()
    End Sub

    Private Sub tmrUp_Tick(sender As System.Object, e As System.EventArgs) Handles tmrUp.Tick
        picBunny.Top -= 3
        If picBunny.Top < 0 Then picBunny.Top = 0
        chkEgg()
    End Sub

    Private Sub tmrDown_Tick(sender As System.Object, e As System.EventArgs) Handles tmrDown.Tick
        picBunny.Top += 3
        If picBunny.Top > Me.Width - 325 Then picBunny.Top = Me.Height - 325
        chkEgg()
    End Sub

    Public Sub reset()
        Found = 0
        hidden = 12
        seconds = 0
        lblFound.Text = found
        lblHidden.Text = hidden
        lblSeconds.Text = Format(seconds, "#0.0")
        tmrSeconds.Enabled = True

        For i = 0 To 11
            eggs(i).Visible = False
            eggs(i).Top = Rnd() * 400
            eggs(i).Left = Rnd() * 700 '
            If i > 0 Then
                For j = 0 To i - 1
                    If eggs(i).Bounds.IntersectsWith(eggs(j).Bounds) Then
                        i -= 1
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub tmrSeconds_Tick(sender As System.Object, e As System.EventArgs) Handles tmrSeconds.Tick
        If found < 12 Then
            seconds += 0.1
            lblSeconds.Text = Format(seconds, "#0.0")
        End If
    End Sub

    Public Sub chkEgg()
        For i = 0 To 11
            If picBunny.Bounds.IntersectsWith(eggs(i).Bounds) And eggs(i).Visible = False Then
                eggs(i).Visible = True
                found += 1
                hidden -= 1
            End If
        Next
        lblFound.Text = found
        lblHidden.Text = hidden
    End Sub
End Class
