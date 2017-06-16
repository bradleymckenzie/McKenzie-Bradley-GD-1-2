
Public Class Form1
    Dim Bump As Integer
    Dim wall(0 To 62) As PictureBox
    Dim door(0 To 4) As PictureBox
    Dim Key As Boolean = False
    Dim enemy1 As Boolean = False
    Dim enemy2 As Boolean = False
    Dim sword As Boolean = False
    Dim diamond(0 To 5) As PictureBox
    Dim totalDiamonds As Integer = 0
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
        wall(62) = picWall62

        door(0) = picDoor0
        door(1) = picDoor1
        door(2) = picDoor2
        door(3) = picDoor3
        door(4) = picDoor4

        diamond(0) = picDiamond0
        diamond(1) = picDiamond1
        diamond(2) = picDiamond2
        diamond(3) = picDiamond3
        diamond(4) = picDiamond4
        diamond(5) = picDiamond5
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
    Private Sub chkSword()
        If picCharacter.Left > picSword.Left - picCharacter.Width _
                And picCharacter.Left < picSword.Left + picSword.Width _
                And picCharacter.Top > picSword.Top - picCharacter.Height _
                And picCharacter.Top < picSword.Top + picSword.Height Then
            picSword.Visible = False
            sword = True
        End If
    End Sub
    Private Sub chkWall(xBump As Integer, yBump As Integer)
        For i = 0 To 62
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
        For i = 0 To 4
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

    Private Sub chkDiamond()
        For i = 0 To 5
            If picCharacter.Left > diamond(i).Left - picCharacter.Width _
                And picCharacter.Left < diamond(i).Left + diamond(i).Width _
                And picCharacter.Top > diamond(i).Top - picCharacter.Height _
                And picCharacter.Top < diamond(i).Top + diamond(i).Height Then
                diamond(i).Visible = False
                totalDiamonds += 1
            End If
        Next
    End Sub
    Private Sub resetGame()
        'make doors visible
        For i = 0 To 4
            door(i).Visible = True
        Next

        'reset character location
        picCharacter.Left = 232
        picCharacter.Top = 400

        'reset key
        picKey.Visible = True
        Key = False

        'reset sword
        picSword.Visible = True
        sword = False

        'reset Diamond
        For i = 0 To 5
            diamond(i).Visible = True
        Next
        totalDiamonds = 0
    End Sub

    Private Sub chkEnemy2()
        If picCharacter.Left > picEnemy2.Left - picCharacter.Width _
                And picCharacter.Left < picEnemy2.Left + picEnemy2.Width _
                And picCharacter.Top > picEnemy2.Top - picCharacter.Height _
                And picCharacter.Top < picEnemy2.Top + picEnemy2.Height Then
            If sword = False Then
                resetGame()
            Else
                picEnemy2.Visible = False
            End If
        End If
    End Sub

    Private Sub tmrEnemy2_Tick(sender As System.Object, e As System.EventArgs) Handles tmrEnemy2.Tick
        If enemy2 = True Then
            picEnemy2.Left -= 3
            If picEnemy2.Left < 195 Then enemy2 = False
        Else
            picEnemy2.Left += 3
            If picEnemy2.Left > 500 Then enemy2 = True
        End If
    End Sub
    Private Sub chkEnemy1()
        If picCharacter.Left > picEnemy1.Left - picCharacter.Width _
             And picCharacter.Left < picEnemy1.Left + picEnemy1.Width _
             And picCharacter.Top > picEnemy1.Top - picCharacter.Height _
             And picCharacter.Top < picEnemy1.Top + picEnemy1.Height Then
            If sword = False Then
                resetGame()
            Else
                picEnemy1.Visible = False
            End If
        End If
    End Sub
    Private Sub tmrEnemy1_Tick(sender As System.Object, e As System.EventArgs) Handles tmrEnemy1.Tick
        If enemy1 = True Then
            picEnemy1.Left -= 3
            If picEnemy1.Left < 243 Then enemy1 = False
        Else
            picEnemy1.Left += 3
            If picEnemy1.Left > 500 Then enemy1 = True
        End If
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

    Private Sub tmrUp_Tick(sender As System.Object, e As System.EventArgs) Handles tmrUp.Tick
        picCharacter.Top = picCharacter.Top - 5
        chkWall(0, +5)
        chkDoor(0, +5)
        chkKey()
        chkSword()
        chkEnemy1()
        chkEnemy2()
        chkDiamond()
    End Sub

    Private Sub tmrDown_Tick(sender As System.Object, e As System.EventArgs) Handles tmrDown.Tick
        picCharacter.Top = picCharacter.Top + 5
        chkWall(0, -5)
        chkDoor(0, -5)
        chkKey()
        chkSword()
        chkEnemy1()
        chkEnemy2()
        chkDiamond()
    End Sub

    Private Sub tmrLeft_Tick(sender As System.Object, e As System.EventArgs) Handles tmrLeft.Tick
        picCharacter.Left = picCharacter.Left - 5
        chkWall(+5, 0)
        chkDoor(+5, 0)
        chkKey()
        chkSword()
        chkEnemy1()
        chkEnemy2()
        chkDiamond()
    End Sub

    Private Sub tmrRight_Tick(sender As System.Object, e As System.EventArgs) Handles tmrRight.Tick
        picCharacter.Left = picCharacter.Left + 5
        chkWall(-5, 0)
        chkDoor(-5, 0)
        chkKey()
        chkSword()
        chkEnemy1()
        chkEnemy2()
        chkDiamond()
    End Sub
End Class
