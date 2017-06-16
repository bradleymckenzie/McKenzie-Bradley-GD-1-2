Public Class Form1
    Dim score As Double
    Dim order As Integer = 0
    Dim rank(0 To 9) As Label
    Dim graph(0 To 9) As Label
    Dim tData(0 To 9) As Integer
    Dim sData(0 To 9) As Integer
    Dim Subject(0 To 9) As CheckBox
    Dim resetGraph As Integer

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        rank(0) = lbl0
        rank(1) = lbl1
        rank(2) = lbl2
        rank(3) = lbl3
        rank(4) = lbl4
        rank(5) = lbl5
        rank(6) = lbl6
        rank(7) = lbl7
        rank(8) = lbl8
        rank(9) = lbl9

        graph(0) = lblGraph0
        graph(1) = lblGraph1
        graph(2) = lblGraph2
        graph(3) = lblGraph3
        graph(4) = lblGraph4
        graph(5) = lblGraph5
        graph(6) = lblGraph6
        graph(7) = lblGraph7
        graph(8) = lblGraph8
        graph(9) = lblGraph9

        Subject(0) = chk0
        Subject(1) = chk1
        Subject(2) = chk2
        Subject(3) = chk3
        Subject(4) = chk4
        Subject(5) = chk5
        Subject(6) = chk6
        Subject(7) = chk7
        Subject(8) = chk8
        Subject(9) = chk9

        lblScore.Top += lblScore.Height
        lblScore.Height = 0
        resetGraph = lblScore.Top
    End Sub
    Public Sub resetRank(ByVal r As Integer)
        For i = 0 To 9
            If rank(i).Text <> "" Then
                If Integer.Parse(rank(i).Text) > r Then
                    rank(i).Text = Integer.Parse(rank(i).Text) - 1
                End If
            End If
        Next
        lblScore.Top = resetGraph
        lblScore.Height = 0
        cboTeachers.Text = "Select a teacher..."
    End Sub

    Private Sub chk0_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chk0.CheckedChanged
        If chk0.Checked = True Then
            order += 1
            rank(0).Text = order.ToString
        Else
            resetRank(Integer.Parse(rank(0).Text))
            order -= 1
            rank(0).Text = ""
        End If
    End Sub

    Private Sub chk1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chk1.CheckedChanged
        If chk1.Checked = True Then
            order += 1
            rank(1).Text = order.ToString
        Else
            resetRank(Integer.Parse(rank(1).Text))
            order -= 1
            rank(1).Text = ""
        End If

    End Sub
    Private Sub chk2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chk2.CheckedChanged
        If chk2.Checked = True Then
            order += 1
            rank(2).Text = order.ToString
        Else
            resetRank(Integer.Parse(rank(2).Text))
            order -= 1
            rank(2).Text = ""
        End If
    End Sub

    Private Sub chk3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chk3.CheckedChanged
        If chk3.Checked = True Then
            order += 1
            rank(3).Text = order.ToString
        Else
            resetRank(Integer.Parse(rank(3).Text))
            order -= 1
            rank(3).Text = ""
        End If
    End Sub

    Private Sub chk4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chk4.CheckedChanged
        If chk4.Checked = True Then
            order += 1
            rank(4).Text = order.ToString
        Else
            resetRank(Integer.Parse(rank(4).Text))
            order -= 1
            rank(4).Text = ""
        End If
    End Sub

    Private Sub chk5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chk5.CheckedChanged
        If chk5.Checked = True Then
            order += 1
            rank(5).Text = order.ToString
        Else
            resetRank(Integer.Parse(rank(5).Text))
            order -= 1
            rank(5).Text = ""
        End If
    End Sub

    Private Sub chk6_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chk6.CheckedChanged
        If chk6.Checked = True Then
            order += 1
            rank(6).Text = order.ToString
        Else
            resetRank(Integer.Parse(rank(6).Text))
            order -= 1
            rank(6).Text = ""
        End If
    End Sub

    Private Sub chk7_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chk7.CheckedChanged
        If chk7.Checked = True Then
            order += 1
            rank(7).Text = order.ToString
        Else
            resetRank(Integer.Parse(rank(7).Text))
            order -= 1
            rank(7).Text = ""
        End If
    End Sub

    Private Sub chk8_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chk8.CheckedChanged
        If chk8.Checked = True Then
            order += 1
            rank(8).Text = order.ToString
        Else
            resetRank(Integer.Parse(rank(8).Text))
            order -= 1
            rank(8).Text = ""
        End If
    End Sub

    Private Sub chk9_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chk9.CheckedChanged
        If chk9.Checked = True Then
            order += 1
            rank(9).Text = order.ToString
        Else
            resetRank(Integer.Parse(rank(9).Text))
            order -= 1
            rank(9).Text = ""
        End If
    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        For i = 0 To 9
            Subject(i).Checked = False
            graph(i).BackColor = Color.White
            rank(i).Text = ""
            tData(i) = 0
        Next

        lblScore.Text = ""
    End Sub

    Private Sub btnMatch_Click(sender As System.Object, e As System.EventArgs) Handles btnMatch.Click
        For i = 0 To 9
            If rank(i).Text = "" Then
                sData(i) = 9
            Else
                sData(i) = Integer.Parse(rank(i).Text) - 1
            End If
        Next
        If cboTeachers.Text = "Andersen, Charles" Then
            tData = {4, 1, 3, 2, 5, 7, 6, 10, 8, 9}
        ElseIf cboTeachers.Text = "Barnard, Jalyn" Then
            tData = {4, 3, 7, 1, 2, 10, 8, 9, 5, 6}
        ElseIf cboTeachers.Text = "Barry, Reno" Then
            tData = {4, 3, 6, 7, 5, 2, 10, 8, 1, 9}
        ElseIf cboTeachers.Text = "Case, Stephanie" Then
            tData = {2, 6, 5, 3, 1, 10, 4, 7, 8, 9}
        ElseIf cboTeachers.Text = "Cleary, Daniel" Then
            tData = {2, 3, 8, 1, 6, 10, 9, 4, 5, 7}
        ElseIf cboTeachers.Text = "Cleary, Tracey" Then
            tData = {1, 2, 10, 9, 8, 6, 4, 3, 7, 5}
        ElseIf cboTeachers.Text = "Dietz, Jeff" Then
            tData = {2, 1, 10, 6, 8, 7, 4, 3, 9, 5}
        ElseIf cboTeachers.Text = "Fonseca, Monica" Then
            tData = {7, 9, 1, 3, 2, 10, 5, 6, 8, 4}
        ElseIf cboTeachers.Text = "Gagnon, Becky" Then
            tData = {2, 3, 6, 10, 9, 5, 7, 1, 4, 8}
        ElseIf cboTeachers.Text = "Gerren, Jamal" Then
            tData = {6, 3, 4, 5, 7, 10, 2, 8, 9, 1}
        ElseIf cboTeachers.Text = "Gilleece, Fran" Then
            tData = {8, 9, 10, 1, 2, 4, 5, 7, 6, 3}
        ElseIf cboTeachers.Text = "Gore, Wendy" Then
            tData = {1, 6, 5, 7, 8, 2, 9, 4, 3, 10}
        ElseIf cboTeachers.Text = "Gray, Charles" Then
            tData = {2, 5, 9, 3, 8, 10, 1, 4, 6, 7}
        ElseIf cboTeachers.Text = "Guiliano, Donna" Then
            tData = {9, 2, 5, 6, 1, 8, 3, 10, 7, 4}
        ElseIf cboTeachers.Text = "Harris, Shaun" Then
            tData = {5, 3, 7, 6, 8, 1, 10, 4, 2, 9}
        ElseIf cboTeachers.Text = "Hebert, Raven" Then
            tData = {4, 3, 10, 9, 6, 2, 8, 5, 1, 7}
        ElseIf cboTeachers.Text = "Hocking, Ned" Then
            tData = {6, 7, 10, 1, 2, 9, 3, 8, 5, 4}
        ElseIf cboTeachers.Text = "Holm, Brian" Then
            tData = {3, 4, 5, 2, 6, 8, 1, 10, 7, 9}
        ElseIf cboTeachers.Text = "Jennings, Kristine" Then
            tData = {7, 5, 8, 3, 2, 4, 9, 6, 1, 10}
        ElseIf cboTeachers.Text = "Jimenez, Jessica" Then
            tData = {8, 9, 6, 1, 7, 10, 4, 5, 2, 3}
        ElseIf cboTeachers.Text = "Kalnin, Grace" Then
            tData = {9, 6, 3, 8, 5, 2, 7, 10, 4, 1}
        ElseIf cboTeachers.Text = "Madril, Adrianna" Then
            tData = {10, 4, 1, 2, 3, 5, 9, 7, 8, 6}
        ElseIf cboTeachers.Text = "Martin, Mike" Then
            tData = {4, 2, 9, 7, 6, 3, 8, 5, 1, 10}
        ElseIf cboTeachers.Text = "Norys, Deborah" Then
            tData = {9, 2, 10, 5, 8, 4, 7, 6, 1, 3}
        ElseIf cboTeachers.Text = "Nosce, Susan" Then
            tData = {3, 7, 6, 2, 9, 8, 5, 10, 4, 1}
        ElseIf cboTeachers.Text = "Peirce, Dan" Then
            tData = {10, 9, 5, 1, 3, 6, 7, 8, 4, 2}
        ElseIf cboTeachers.Text = "Rosa, Kevin" Then
            tData = {4, 3, 10, 5, 6, 7, 8, 1, 2, 9}
        ElseIf cboTeachers.Text = "Scarborough, Patricia" Then
            tData = {8, 9, 6, 3, 4, 10, 1, 5, 7, 2}
        ElseIf cboTeachers.Text = "Scott, Ken" Then
            tData = {2, 3, 10, 5, 9, 4, 7, 1, 6, 8}
        ElseIf cboTeachers.Text = "Torres-Manrique, Rosa" Then
            tData = {7, 2, 1, 10, 3, 9, 4, 5, 8, 6}
        ElseIf cboTeachers.Text = "Woolls, Christina" Then
            tData = {10, 1, 3, 7, 9, 2, 5, 4, 6, 8}
        End If

        setGraph()

    End Sub

    Public Sub setGraph()
        score = 100
        For i = 0 To 9
            If rank(i).Text = "" Then
                score -= 10
            Else
                score -= Math.Abs(sData(i) - (tData(i) - 1)) * 2
            End If
        Next
        lblScore.Text = score.ToString + "%"
        lblScore.Top = 575 - (score * 3.4)
        lblScore.Height = score * 3.4
    End Sub
End Class
