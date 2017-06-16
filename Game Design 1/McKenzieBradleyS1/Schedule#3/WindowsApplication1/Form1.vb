Public Class Form1

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub btn1_Click(sender As System.Object, e As System.EventArgs) Handles btn1.Click
        lblDisplay1.Text = "1"
        lblDisplay2.Text = "Game Design 1"
        lblDisplay3.Text = "Andersen, C"
        lblDisplay4.Text = "G-109"
    End Sub

    Private Sub btn2_Click(sender As System.Object, e As System.EventArgs) Handles btn2.Click
        lblDisplay1.Text = "2"
        lblDisplay2.Text = "Draw/Paint 1/2"
        lblDisplay3.Text = "Anthony, L"
        lblDisplay4.Text = "F-103"
    End Sub

    Private Sub btn3_Click(sender As System.Object, e As System.EventArgs) Handles btn3.Click
        lblDisplay1.Text = "3"
        lblDisplay2.Text = "Physical Ed 9"
        lblDisplay3.Text = "Mapes, T"
        lblDisplay4.Text = "GYM"
    End Sub

    Private Sub btn4_Click(sender As System.Object, e As System.EventArgs) Handles btn4.Click
        lblDisplay1.Text = "4"
        lblDisplay2.Text = "Intro Lit/Comp"
        lblDisplay3.Text = "Guiliano, D"
        lblDisplay4.Text = "D-133"
    End Sub

    Private Sub btn5_Click(sender As System.Object, e As System.EventArgs) Handles btn5.Click
        lblDisplay1.Text = "5"
        lblDisplay2.Text = "Biology"
        lblDisplay3.Text = "Olague, V"
        lblDisplay4.Text = "B-101"
    End Sub

    Private Sub btn6_Click(sender As System.Object, e As System.EventArgs) Handles btn6.Click
        lblDisplay1.Text = "6"
        lblDisplay2.Text = "Geometry"
        lblDisplay3.Text = "Harris,S"
        lblDisplay4.Text = "E-231"
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
