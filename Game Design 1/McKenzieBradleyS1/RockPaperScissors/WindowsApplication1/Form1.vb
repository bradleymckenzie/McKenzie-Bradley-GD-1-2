Public Class Form1

    Private Sub btnRock_Click(sender As System.Object, e As System.EventArgs) Handles btnRock.Click
        picHuman.Image = picFace1.Image

        Dim c1 As Integer = Rnd() * 3 + 1
        Dim c2 As Integer = Rnd() * 3 + 1
        Dim c3 As Integer = Rnd() * 3 + 1
        Dim c4 As Integer = Rnd() * 3 + 1
        Dim c5 As Integer = Rnd() * 3 + 1
        'Rock'
        If c1 = 1 Then picComputer.Image = picFace1.Image
        If c1 = 2 Then picComputer.Image = picFace2.Image
        If c1 = 3 Then picComputer.Image = picFace3.Image

    End Sub

    Private Sub btnPaper_Click(sender As System.Object, e As System.EventArgs) Handles btnPaper.Click
        picHuman.Image = picFace2.Image

        Dim c1 As Integer = Rnd() * 3 + 1
        Dim c2 As Integer = Rnd() * 3 + 1
        Dim c3 As Integer = Rnd() * 3 + 1
        Dim c4 As Integer = Rnd() * 3 + 1
        Dim c5 As Integer = Rnd() * 3 + 1
        'Paper'
        If c1 = 1 Then picComputer.Image = picFace1.Image
        If c1 = 2 Then picComputer.Image = picFace2.Image
        If c1 = 3 Then picComputer.Image = picFace3.Image
    End Sub

    Private Sub btnScissors_Click(sender As System.Object, e As System.EventArgs) Handles btnScissors.Click
        picHuman.Image = picFace3.Image

        Dim c1 As Integer = Rnd() * 3 + 1
        Dim c2 As Integer = Rnd() * 3 + 1
        Dim c3 As Integer = Rnd() * 3 + 1
        Dim c4 As Integer = Rnd() * 3 + 1
        Dim c5 As Integer = Rnd() * 3 + 1
        'Scissors'
        If c1 = 1 Then picComputer.Image = picFace1.Image
        If c1 = 2 Then picComputer.Image = picFace2.Image
        If c1 = 3 Then picComputer.Image = picFace3.Image
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
