Public Class Form1
    Dim box(0 To 48) As Label
    Dim line(0 To 111) As Label
    Dim player As Integer = 1
    Dim player1 As Integer
    Dim player2 As Integer
    Dim score As Boolean

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        box(0) = lblBox0
        box(1) = lblBox1
        box(2) = lblBox2
        box(3) = lblBox3
        box(4) = lblBox4
        box(5) = lblBox5
        box(6) = lblBox6
        box(7) = lblBox7
        box(8) = lblBox8
        box(9) = lblBox9
        box(10) = lblBox10
        box(11) = lblBox11
        box(12) = lblBox12
        box(13) = lblBox13
        box(14) = lblBox14
        box(15) = lblBox15
        box(16) = lblBox16
        box(17) = lblBox17
        box(18) = lblBox18
        box(19) = lblBox19
        box(20) = lblBox20
        box(21) = lblBox21
        box(22) = lblBox22
        box(23) = lblBox23
        box(24) = lblBox24
        box(25) = lblBox25
        box(26) = lblBox26
        box(27) = lblBox27
        box(28) = lblBox28
        box(29) = lblBox29
        box(30) = lblBox30
        box(31) = lblBox31
        box(32) = lblBox32
        box(33) = lblBox33
        box(34) = lblBox34
        box(35) = lblBox35
        box(36) = lblBox36
        box(37) = lblBox37
        box(38) = lblBox38
        box(39) = lblBox39
        box(40) = lblBox40
        box(41) = lblBox41
        box(42) = lblBox42
        box(43) = lblBox43
        box(44) = lblBox44
        box(45) = lblBox45
        box(46) = lblBox46
        box(47) = lblBox47
        box(48) = lblBox48

        line(0) = lbl0
        line(1) = lbl1
        line(2) = lbl2
        line(3) = lbl3
        line(4) = lbl4
        line(5) = lbl5
        line(6) = lbl6
        line(7) = lbl7
        line(8) = lbl8
        line(9) = lbl9
        line(10) = lbl10
        line(11) = lbl11
        line(12) = lbl12
        line(13) = lbl13
        line(14) = lbl14
        line(15) = lbl15
        line(16) = lbl16
        line(17) = lbl17
        line(18) = lbl18
        line(19) = lbl19
        line(20) = lbl20
        line(21) = lbl21
        line(22) = lbl22
        line(23) = lbl23
        line(24) = lbl24
        line(25) = lbl25
        line(26) = lbl26
        line(27) = lbl27
        line(28) = lbl28
        line(29) = lbl29
        line(30) = lbl30
        line(31) = lbl31
        line(32) = lbl32
        line(33) = lbl33
        line(34) = lbl34
        line(35) = lbl35
        line(36) = lbl36
        line(37) = lbl37
        line(38) = lbl38
        line(39) = lbl39
        line(40) = lbl40
        line(41) = lbl41
        line(42) = lbl42
        line(43) = lbl43
        line(44) = lbl44
        line(45) = lbl45
        line(46) = lbl46
        line(47) = lbl47
        line(48) = lbl48
        line(49) = lbl59
        line(50) = lbl50
        line(51) = lbl51
        line(52) = lbl52
        line(53) = lbl53
        line(54) = lbl54
        line(55) = lbl55
        line(56) = lbl56
        line(57) = lbl57
        line(58) = lbl58
        line(59) = lbl59
        line(60) = lbl60
        line(61) = lbl61
        line(62) = lbl62
        line(63) = lbl63
        line(64) = lbl64
        line(65) = lbl65
        line(66) = lbl66
        line(67) = lbl67
        line(68) = lbl68
        line(69) = lbl69
        line(70) = lbl70
        line(71) = lbl71
        line(72) = lbl72
        line(73) = lbl73
        line(74) = lbl74
        line(75) = lbl75
        line(76) = lbl76
        line(77) = lbl77
        line(78) = lbl78
        line(79) = lbl79
        line(80) = lbl80
        line(81) = lbl81
        line(82) = lbl82
        line(83) = lbl83
        line(84) = lbl84
        line(85) = lbl85
        line(86) = lbl86
        line(87) = lbl87
        line(88) = lbl88
        line(89) = lbl89
        line(90) = lbl90
        line(91) = lbl91
        line(92) = lbl92
        line(93) = lbl93
        line(94) = lbl94
        line(95) = lbl95
        line(96) = lbl96
        line(97) = lbl97
        line(98) = lbl98
        line(99) = lbl99
        line(100) = lbl100
        line(101) = lbl101
        line(102) = lbl102
        line(103) = lbl103
        line(104) = lbl104
        line(105) = lbl105
        line(106) = lbl106
        line(107) = lbl107
        line(108) = lbl108
        line(109) = lbl109
        line(110) = lbl110
        line(111) = lbl111
        Me.BackColor = Color.Black

        reset()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnNewGame_Click(sender As System.Object, e As System.EventArgs) Handles btnNewGame.Click
        reset()
    End Sub

    Public Sub getLine(ByVal i As Integer)
        line(i).BackColor = Color.Gray
        getBox()
    End Sub

    Public Sub reset()
        For i = 0 To 48
            box(i).BackColor = Color.Black
        Next
        For i = 0 To 111
            line(i).BackColor = Color.Black
        Next
        player1 = 0
        player2 = 0

        lblPlayer1.Text = player1.ToString
        lblPlayer2.Text = player2.ToString
    End Sub

    Public Sub getBox()

        score = False

        For i = 0 To 6
            If box(i).BackColor = Color.Black _
             And line(i).BackColor = Color.Gray _
              And line(i + 7).BackColor = Color.Gray _
              And line(i + 8).BackColor = Color.Gray _
              And line(i + 15).BackColor = Color.Gray Then
                If player = 1 Then
                    box(i).BackColor = Color.Yellow
                    player1 += 1
                    score = True
                Else
                    box(i).BackColor = Color.Cyan
                    player2 += 1
                    score = True
                End If
            End If
        Next
        For i = 7 To 13
            If box(i).BackColor = Color.Black _
            And line(i + 8).BackColor = Color.Gray _
             And line(i + 15).BackColor = Color.Gray _
                And line(i + 16).BackColor = Color.Gray _
             And line(i + 23).BackColor = Color.Gray Then
                If player = 1 Then
                    box(i).BackColor = Color.Yellow
                    player1 += 1
                    score = True
                Else
                    box(i).BackColor = Color.Cyan
                    player2 += 1
                    score = True
                End If
            End If
        Next
        For i = 14 To 20
            If box(i).BackColor = Color.Black _
            And line(i + 16).BackColor = Color.Gray _
             And line(i + 23).BackColor = Color.Gray _
             And line(i + 24).BackColor = Color.Gray _
             And line(i + 31).BackColor = Color.Gray Then
                If player = 1 Then
                    box(i).BackColor = Color.Yellow
                    player1 += 1
                    score = True
                Else
                    box(i).BackColor = Color.Cyan
                    player2 += 1
                    score = True
                End If
            End If
        Next
        For i = 21 To 27
            If box(i).BackColor = Color.Black _
            And line(i + 24).BackColor = Color.Gray _
             And line(i + 31).BackColor = Color.Gray _
             And line(i + 32).BackColor = Color.Gray _
             And line(i + 39).BackColor = Color.Gray Then
                If player = 1 Then
                    box(i).BackColor = Color.Yellow
                    player1 += 1
                    score = True
                Else
                    box(i).BackColor = Color.Cyan
                    player2 += 1
                    score = True
                End If
            End If
        Next
        For i = 28 To 34
            If box(i).BackColor = Color.Black _
            And line(i + 32).BackColor = Color.Gray _
             And line(i + 39).BackColor = Color.Gray _
             And line(i + 40).BackColor = Color.Gray _
             And line(i + 47).BackColor = Color.Gray Then
                If player = 1 Then
                    box(i).BackColor = Color.Yellow
                    player1 += 1
                    score = True
                Else
                    box(i).BackColor = Color.Cyan
                    player2 += 1
                    score = True
                End If
            End If
        Next
        For i = 35 To 41
            If box(i).BackColor = Color.Black _
            And line(i + 40).BackColor = Color.Gray _
             And line(i + 47).BackColor = Color.Gray _
             And line(i + 48).BackColor = Color.Gray _
             And line(i + 55).BackColor = Color.Gray Then
                If player = 1 Then
                    box(i).BackColor = Color.Yellow
                    player1 += 1
                    score = True
                Else
                    box(i).BackColor = Color.Cyan
                    player2 += 1
                    score = True
                End If
            End If
        Next
        For i = 42 To 48
            If box(i).BackColor = Color.Black _
            And line(i + 48).BackColor = Color.Gray _
             And line(i + 55).BackColor = Color.Gray _
             And line(i + 56).BackColor = Color.Gray _
             And line(i + 63).BackColor = Color.Gray Then
                If player = 1 Then
                    box(i).BackColor = Color.Yellow
                    player1 += 1
                    score = True
                Else
                    box(i).BackColor = Color.Cyan
                    player2 += 1
                    score = True
                End If
            End If
        Next
        If score = False Then
            If player = 1 Then
                player = 2
                lblPlayer.BackColor = Color.White
                lblPlayer.BackColor = Color.Cyan
                lblPlayer.Text = "2"
            Else
                player = 1
                lblPlayer.BackColor = Color.White
                lblPlayer.Text = "1"
                lblPlayer.BackColor = Color.Yellow
            End If
        End If
        lblPlayer1.Text = player1.ToString
        lblPlayer2.Text = player2.ToString
    End Sub

    Private Sub lbl0_Click(sender As System.Object, e As System.EventArgs) Handles lbl0.Click
        getLine(0)
    End Sub

    Private Sub lbl1_Click(sender As System.Object, e As System.EventArgs) Handles lbl1.Click
        getLine(1)
    End Sub

    Private Sub lbl2_Click(sender As System.Object, e As System.EventArgs) Handles lbl2.Click
        getLine(2)
    End Sub

    Private Sub lbl3_Click(sender As System.Object, e As System.EventArgs) Handles lbl3.Click
        getLine(3)
    End Sub

    Private Sub lbl4_Click(sender As System.Object, e As System.EventArgs) Handles lbl4.Click
        getLine(4)
    End Sub

    Private Sub lbl5_Click(sender As System.Object, e As System.EventArgs) Handles lbl5.Click
        getLine(5)
    End Sub

    Private Sub lbl6_Click(sender As System.Object, e As System.EventArgs) Handles lbl6.Click
        getLine(6)
    End Sub

    Private Sub lbl7_Click(sender As System.Object, e As System.EventArgs) Handles lbl7.Click
        getLine(7)
    End Sub

    Private Sub lbl8_Click(sender As System.Object, e As System.EventArgs) Handles lbl8.Click
        getLine(8)
    End Sub

    Private Sub lbl9_Click(sender As System.Object, e As System.EventArgs) Handles lbl9.Click
        getLine(9)
    End Sub

    Private Sub lbl10_Click(sender As System.Object, e As System.EventArgs) Handles lbl10.Click
        getLine(10)
    End Sub

    Private Sub lbl12_Click(sender As System.Object, e As System.EventArgs) Handles lbl12.Click
        getLine(12)
    End Sub

    Private Sub lbl13_Click(sender As System.Object, e As System.EventArgs) Handles lbl13.Click
        getLine(13)
    End Sub

    Private Sub lbl14_Click(sender As System.Object, e As System.EventArgs) Handles lbl14.Click
        getLine(14)
    End Sub

    Private Sub lbl15_Click(sender As System.Object, e As System.EventArgs) Handles lbl15.Click
        getLine(15)
    End Sub

    Private Sub lbl16_Click(sender As System.Object, e As System.EventArgs) Handles lbl16.Click
        getLine(16)
    End Sub

    Private Sub lbl17_Click(sender As System.Object, e As System.EventArgs) Handles lbl17.Click
        getLine(17)
    End Sub

    Private Sub lbl18_Click(sender As System.Object, e As System.EventArgs) Handles lbl18.Click
        getLine(18)
    End Sub

    Private Sub lbl19_Click(sender As System.Object, e As System.EventArgs) Handles lbl19.Click
        getLine(19)
    End Sub

    Private Sub lbl20_Click(sender As System.Object, e As System.EventArgs) Handles lbl20.Click
        getLine(20)
    End Sub

    Private Sub lbl21_Click(sender As System.Object, e As System.EventArgs) Handles lbl21.Click
        getLine(21)
    End Sub

    Private Sub lbl22_Click(sender As System.Object, e As System.EventArgs) Handles lbl22.Click
        getLine(22)
    End Sub

    Private Sub lbl23_Click(sender As System.Object, e As System.EventArgs) Handles lbl23.Click
        getLine(23)
    End Sub

    Private Sub lbl24_Click(sender As System.Object, e As System.EventArgs) Handles lbl24.Click
        getLine(24)
    End Sub

    Private Sub lbl25_Click(sender As System.Object, e As System.EventArgs) Handles lbl25.Click
        getLine(25)
    End Sub

    Private Sub lbl26_Click(sender As System.Object, e As System.EventArgs) Handles lbl26.Click
        getLine(26)
    End Sub

    Private Sub lbl27_Click(sender As System.Object, e As System.EventArgs) Handles lbl27.Click
        getLine(27)
    End Sub

    Private Sub lbl28_Click(sender As System.Object, e As System.EventArgs) Handles lbl28.Click
        getLine(28)
    End Sub

    Private Sub lbl29_Click(sender As System.Object, e As System.EventArgs) Handles lbl29.Click
        getLine(29)
    End Sub

    Private Sub lbl30_Click(sender As System.Object, e As System.EventArgs) Handles lbl30.Click
        getLine(30)
    End Sub

    Private Sub lbl31_Click(sender As System.Object, e As System.EventArgs) Handles lbl31.Click
        getLine(31)
    End Sub

    Private Sub lbl32_Click(sender As System.Object, e As System.EventArgs) Handles lbl32.Click
        getLine(32)
    End Sub

    Private Sub lbl33_Click(sender As System.Object, e As System.EventArgs) Handles lbl33.Click
        getLine(33)
    End Sub

    Private Sub lbl34_Click(sender As System.Object, e As System.EventArgs) Handles lbl34.Click
        getLine(34)
    End Sub

    Private Sub lbl35_Click(sender As System.Object, e As System.EventArgs) Handles lbl35.Click
        getLine(35)
    End Sub

    Private Sub lbl36_Click(sender As System.Object, e As System.EventArgs) Handles lbl36.Click
        getLine(36)
    End Sub

    Private Sub lbl37_Click(sender As System.Object, e As System.EventArgs) Handles lbl37.Click
        getLine(37)
    End Sub

    Private Sub lbl38_Click(sender As System.Object, e As System.EventArgs) Handles lbl38.Click
        getLine(38)
    End Sub

    Private Sub lbl39_Click(sender As System.Object, e As System.EventArgs) Handles lbl39.Click
        getLine(39)
    End Sub

    Private Sub lbl40_Click(sender As System.Object, e As System.EventArgs) Handles lbl40.Click
        getLine(40)
    End Sub

    Private Sub lbl41_Click(sender As System.Object, e As System.EventArgs) Handles lbl41.Click
        getLine(41)
    End Sub

    Private Sub lbl42_Click(sender As System.Object, e As System.EventArgs) Handles lbl42.Click
        getLine(42)
    End Sub

    Private Sub lbl43_Click(sender As System.Object, e As System.EventArgs) Handles lbl43.Click
        getLine(43)
    End Sub

    Private Sub lbl44_Click(sender As System.Object, e As System.EventArgs) Handles lbl44.Click
        getLine(44)
    End Sub

    Private Sub lbl45_Click(sender As System.Object, e As System.EventArgs) Handles lbl45.Click
        getLine(45)
    End Sub

    Private Sub lbl46_Click(sender As System.Object, e As System.EventArgs) Handles lbl46.Click
        getLine(46)
    End Sub

    Private Sub lbl47_Click(sender As System.Object, e As System.EventArgs) Handles lbl47.Click
        getLine(47)
    End Sub

    Private Sub lbl48_Click(sender As System.Object, e As System.EventArgs) Handles lbl48.Click
        getLine(48)
    End Sub

    Private Sub lbl49_Click(sender As System.Object, e As System.EventArgs) Handles lbl49.Click
        getLine(49)
    End Sub

    Private Sub lbl50_Click(sender As System.Object, e As System.EventArgs) Handles lbl50.Click
        getLine(50)
    End Sub

    Private Sub lbl51_Click(sender As System.Object, e As System.EventArgs) Handles lbl51.Click
        getLine(51)
    End Sub

    Private Sub lbl52_Click(sender As System.Object, e As System.EventArgs) Handles lbl52.Click
        getLine(52)
    End Sub

    Private Sub lbl53_Click(sender As System.Object, e As System.EventArgs) Handles lbl53.Click
        getLine(53)
    End Sub

    Private Sub lbl54_Click(sender As System.Object, e As System.EventArgs) Handles lbl54.Click
        getLine(54)
    End Sub

    Private Sub lbl55_Click(sender As System.Object, e As System.EventArgs) Handles lbl55.Click
        getLine(55)
    End Sub

    Private Sub lbl56_Click(sender As System.Object, e As System.EventArgs) Handles lbl56.Click
        getLine(56)
    End Sub

    Private Sub lbl57_Click(sender As System.Object, e As System.EventArgs) Handles lbl57.Click
        getLine(57)
    End Sub

    Private Sub lbl58_Click(sender As System.Object, e As System.EventArgs) Handles lbl58.Click
        getLine(58)
    End Sub

    Private Sub lbl59_Click(sender As System.Object, e As System.EventArgs) Handles lbl59.Click
        getLine(59)
    End Sub

    Private Sub lbl60_Click(sender As System.Object, e As System.EventArgs) Handles lbl60.Click
        getLine(60)
    End Sub

    Private Sub lbl61_Click(sender As System.Object, e As System.EventArgs) Handles lbl61.Click
        getLine(61)
    End Sub

    Private Sub lbl62_Click(sender As System.Object, e As System.EventArgs) Handles lbl62.Click
        getLine(62)
    End Sub

    Private Sub lbl63_Click(sender As System.Object, e As System.EventArgs) Handles lbl63.Click
        getLine(63)
    End Sub

    Private Sub lbl64_Click(sender As System.Object, e As System.EventArgs) Handles lbl64.Click
        getLine(64)
    End Sub

    Private Sub lbl65_Click(sender As System.Object, e As System.EventArgs) Handles lbl65.Click
        getLine(65)
    End Sub

    Private Sub lbl66_Click(sender As System.Object, e As System.EventArgs) Handles lbl66.Click
        getLine(66)
    End Sub

    Private Sub lbl67_Click(sender As System.Object, e As System.EventArgs) Handles lbl67.Click
        getLine(67)
    End Sub

    Private Sub lbl68_Click(sender As System.Object, e As System.EventArgs) Handles lbl68.Click
        getLine(68)
    End Sub

    Private Sub lbl69_Click(sender As System.Object, e As System.EventArgs) Handles lbl69.Click
        getLine(69)
    End Sub

    Private Sub lbl70_Click(sender As System.Object, e As System.EventArgs) Handles lbl70.Click
        getLine(70)
    End Sub

    Private Sub lbl71_Click(sender As System.Object, e As System.EventArgs) Handles lbl71.Click
        getLine(71)
    End Sub

    Private Sub lbl72_Click(sender As System.Object, e As System.EventArgs) Handles lbl72.Click
        getLine(72)
    End Sub

    Private Sub lbl73_Click(sender As System.Object, e As System.EventArgs) Handles lbl73.Click
        getLine(73)
    End Sub

    Private Sub lbl74_Click(sender As System.Object, e As System.EventArgs) Handles lbl74.Click
        getLine(74)
    End Sub

    Private Sub lbl75_Click(sender As System.Object, e As System.EventArgs) Handles lbl75.Click
        getLine(75)
    End Sub

    Private Sub lbl76_Click(sender As System.Object, e As System.EventArgs) Handles lbl76.Click
        getLine(76)
    End Sub

    Private Sub lbl77_Click(sender As System.Object, e As System.EventArgs) Handles lbl77.Click
        getLine(77)
    End Sub

    Private Sub lbl78_Click(sender As System.Object, e As System.EventArgs) Handles lbl78.Click
        getLine(78)
    End Sub

    Private Sub lbl79_Click(sender As System.Object, e As System.EventArgs) Handles lbl79.Click
        getLine(79)
    End Sub

    Private Sub lblL80_Click(sender As System.Object, e As System.EventArgs) Handles lbl80.Click
        getLine(80)
    End Sub

    Private Sub lbl81_Click(sender As System.Object, e As System.EventArgs) Handles lbl81.Click
        getLine(81)
    End Sub

    Private Sub lbl82_Click(sender As System.Object, e As System.EventArgs) Handles lbl82.Click
        getLine(82)
    End Sub

    Private Sub lbl83_Click(sender As System.Object, e As System.EventArgs) Handles lbl83.Click
        getLine(83)
    End Sub

    Private Sub lbl84_Click(sender As System.Object, e As System.EventArgs) Handles lbl84.Click
        getLine(84)
    End Sub

    Private Sub lbl85_Click(sender As System.Object, e As System.EventArgs) Handles lbl85.Click
        getLine(85)
    End Sub

    Private Sub lbl86_Click(sender As System.Object, e As System.EventArgs) Handles lbl86.Click
        getLine(86)
    End Sub

    Private Sub lbl87_Click(sender As System.Object, e As System.EventArgs) Handles lbl87.Click
        getLine(87)
    End Sub

    Private Sub lbl88_Click(sender As System.Object, e As System.EventArgs) Handles lbl88.Click
        getLine(88)
    End Sub

    Private Sub lbl89_Click(sender As System.Object, e As System.EventArgs) Handles lbl89.Click
        getLine(9)
    End Sub

    Private Sub lbl90_Click(sender As System.Object, e As System.EventArgs) Handles lbl90.Click
        getLine(90)
    End Sub

    Private Sub lbl91_Click(sender As System.Object, e As System.EventArgs) Handles lbl91.Click
        getLine(91)
    End Sub

    Private Sub lbl92_Click(sender As System.Object, e As System.EventArgs) Handles lbl92.Click
        getLine(92)
    End Sub

    Private Sub lbl93_Click(sender As System.Object, e As System.EventArgs) Handles lbl93.Click
        getLine(93)
    End Sub

    Private Sub lbl94_Click(sender As System.Object, e As System.EventArgs) Handles lbl94.Click
        getLine(94)
    End Sub

    Private Sub lbl95_Click(sender As System.Object, e As System.EventArgs) Handles lbl95.Click
        getLine(95)
    End Sub

    Private Sub lbl96_Click(sender As System.Object, e As System.EventArgs) Handles lbl96.Click
        getLine(96)
    End Sub

    Private Sub lbl97_Click(sender As System.Object, e As System.EventArgs) Handles lbl97.Click
        getLine(97)
    End Sub

    Private Sub lbl98_Click(sender As System.Object, e As System.EventArgs) Handles lbl98.Click
        getLine(98)
    End Sub

    Private Sub lbl99_Click(sender As System.Object, e As System.EventArgs) Handles lbl99.Click
        getLine(99)
    End Sub

    Private Sub lbl100_Click(sender As System.Object, e As System.EventArgs) Handles lbl100.Click
        getLine(100)
    End Sub

    Private Sub lbl101_Click(sender As System.Object, e As System.EventArgs) Handles lbl101.Click
        getLine(101)
    End Sub

    Private Sub lbl102_Click(sender As System.Object, e As System.EventArgs) Handles lbl102.Click
        getLine(102)
    End Sub

    Private Sub lbl103_Click(sender As System.Object, e As System.EventArgs) Handles lbl103.Click
        getLine(103)
    End Sub

    Private Sub lbl104_Click(sender As System.Object, e As System.EventArgs) Handles lbl104.Click
        getLine(104)
    End Sub

    Private Sub lbl105_Click(sender As System.Object, e As System.EventArgs) Handles lbl105.Click
        getLine(105)
    End Sub

    Private Sub lbl106_Click(sender As System.Object, e As System.EventArgs) Handles lbl106.Click
        getLine(106)
    End Sub

    Private Sub lbl107_Click(sender As System.Object, e As System.EventArgs) Handles lbl107.Click
        getLine(107)
    End Sub

    Private Sub lbl108_Click(sender As System.Object, e As System.EventArgs) Handles lbl108.Click
        getLine(108)
    End Sub

    Private Sub lbl109_Click(sender As System.Object, e As System.EventArgs) Handles lbl109.Click
        getLine(109)
    End Sub

    Private Sub lbl110_Click(sender As System.Object, e As System.EventArgs) Handles lbl110.Click
        getLine(110)
    End Sub

    Private Sub lbl111_Click(sender As System.Object, e As System.EventArgs) Handles lbl111.Click
        getLine(111)
    End Sub
End Class

