Public Class Form1
    Dim Bump As Integer
    Dim wall(0 To 83) As PictureBox
    Dim door(0 To 7) As PictureBox
    Dim Key As Boolean = False

    Private Sub chkWall(xBump As Integer, yBump As Integer)
        For i = 0 To 83
            If picCharacter.Left > wall(i).Left - picCharacter.Width _
            And picCharacter.Left < wall(i).Left + wall(i).Width _
            And picCharacter.Top > wall(i).Top - picCharacter.Height _
            And picCharacter.Top < wall(i).Top + wall(i).Height Then
                picCharacter.Left += xBump
                picCharacter.Top += yBump
            End If
        Next
    End Sub
    Private Sub chkDoor(xBump As Integer, yBump As Integer)
        For i = 0 To 1
            If picCharacter.Left > door(i).Left - picCharacter.Width _
                And picCharacter.Left < door(i).Left + door(i).Width _
                And picCharacter.Top > door(i).Top - picCharacter.Height _
                And picCharacter.Top < door(i).Top + door(i).Height Then
                If Key = False Then
                    picCharacter.Left += xBump
                    picCharacter.Top += yBump
                Else
                    door(i).Visible = False
                End If
            End If
        Next
    End Sub
    Private Sub chkKey()
        If picCharacter.Left > picKey.Left - picCharacter.Width _
             And picCharacter.Left < picKey.Left + picKey.Width _
             And picCharacter.Top > picKey.Top - picCharacter.Height _
             And picCharacter.Top < picKey.Top + picKey.Height Then
            picKey.Visible = False
            Key = True
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        wall(0) = picWall0
        wall(1) = picWall1
        wall(2) = picWall2
        wall(3) = picWall3
        wall(4) = picWall4
        wall(5) = picWall5
        wall(6) = picWall6
        wall(7) = picWall7
        wall(8) = picWall8
        wall(9) = picWall9
        wall(10) = picWall10
        wall(11) = picWall11
        wall(12) = picWall12
        wall(13) = picWall13
        wall(14) = picWall14
        wall(15) = picWall15
        wall(16) = picWall16
        wall(17) = picWall17
        wall(18) = picWall18
        wall(19) = picWall19
        wall(20) = picWall20
        wall(21) = picWall21
        wall(22) = picWall22
        wall(23) = picWall23
        wall(24) = picWall24
        wall(25) = picWall25
        wall(26) = picWall26
        wall(27) = picWall27
        wall(28) = picWall28
        wall(29) = picWall29
        wall(30) = picWall30
        wall(31) = picWall31
        wall(32) = picWall32
        wall(33) = picWall33
        wall(34) = picWall34
        wall(35) = picWall35
        wall(36) = picWall36
        wall(37) = picWall37
        wall(38) = picWall38
        wall(39) = picWall39
        wall(40) = picWall40
        wall(41) = picWall41
        wall(42) = picWall42
        wall(43) = picWall43
        wall(44) = picWall44
        wall(45) = picWall45
        wall(46) = picWall46
        wall(47) = picWall47
        wall(48) = picWall48
        wall(49) = picWall49
        wall(50) = picWall50
        wall(51) = picWall51
        wall(52) = picWall52
        wall(53) = picWall53
        wall(54) = picWall54
        wall(55) = picWall55
        wall(56) = picWall56
        wall(57) = picWall57
        wall(58) = picWall58
        wall(59) = picWall59
        wall(60) = picWall60
        wall(61) = picWall61
        wall(62) = picWall63
        wall(63) = picWall63
        wall(64) = picWall64
        wall(65) = picWall65
        wall(66) = picWall66
        wall(67) = picWall67
        wall(68) = picWall68
        wall(69) = picWall69
        wall(70) = picWall70
        wall(71) = picWall71
        wall(72) = picWall72
        wall(73) = picWall73
        wall(74) = picWall74
        wall(75) = picWall75
        wall(76) = picWall76
        wall(77) = picWall77
        wall(78) = picWall78
        wall(79) = picWall79
        wall(80) = picWall80
        wall(81) = picWall81
        wall(82) = picWall82
        wall(83) = picWall83

        door(0) = picDoor0
        door(1) = picDoor1
    End Sub

    Private Sub tmrDown_Tick(sender As System.Object, e As System.EventArgs) Handles tmrDown.Tick
        picCharacter.Top = picCharacter.Top + 5
        chkWall(0, -5)
        chkDoor(0, -5)
        chkKey()
    End Sub

    Private Sub tmrUp_Tick(sender As System.Object, e As System.EventArgs) Handles tmrUp.Tick
        picCharacter.Top = picCharacter.Top - 5
        chkWall(0, +5)
        chkDoor(0, +5)
        chkKey()
    End Sub

    Private Sub tmrLeft_Tick(sender As System.Object, e As System.EventArgs) Handles tmrLeft.Tick
        picCharacter.Left = picCharacter.Left - 5
        chkWall(+5, 0)
        chkDoor(+5, 0)
        chkKey()
    End Sub

    Private Sub tmrRight_Tick(sender As System.Object, e As System.EventArgs) Handles tmrRight.Tick
        picCharacter.Left = picCharacter.Left + 5
        chkWall(-5, 0)
        chkDoor(-5, 0)
        chkKey()
    End Sub

    Private Sub Form1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = 37 Then 'left
            tmrLeft.Enabled = True
        ElseIf e.KeyValue = 38 Then 'Up
            tmrUp.Enabled = True
        ElseIf e.KeyValue = 39 Then 'Right
            tmrRight.Enabled = True
        ElseIf e.KeyValue = 40 Then 'Down
            tmrDown.Enabled = True
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = 37 Then 'left
            tmrLeft.Enabled = False
        ElseIf e.KeyValue = 38 Then 'Up
            tmrUp.Enabled = False
        ElseIf e.KeyValue = 39 Then 'Right
            tmrRight.Enabled = False
        ElseIf e.KeyValue = 40 Then 'Down
            tmrDown.Enabled = False
        End If
    End Sub
End Class
