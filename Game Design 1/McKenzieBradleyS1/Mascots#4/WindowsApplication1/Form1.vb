Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        lblDisplay1.Text = "Arlington"
        lblDisplay2.Text = "Lions"
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        lblDisplay1.Text = "North"
        lblDisplay2.Text = "Huskies"
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        lblDisplay1.Text = "King"
        lblDisplay2.Text = "Wolves"
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        lblDisplay1.Text = "Lincoln"
        lblDisplay2.Text = "Panthers"
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        lblDisplay1.Text = "Poly"
        lblDisplay2.Text = "Bears"
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        lblDisplay1.Text = "Ramano"
        lblDisplay2.Text = "Rams"
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
