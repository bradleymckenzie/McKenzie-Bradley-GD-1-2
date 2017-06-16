Public Class Form6

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Form2.Show()
        Form2.Activate()
    End Sub

    Private Sub hsbRed_Scroll(sender As System.Object, e As System.Windows.Forms.ScrollEventArgs) Handles hsbRed.Scroll
        lblRed.Text = hsbRed.Value.ToString
        upDateColor()
    End Sub

    Private Sub hsbGreen_Scroll(sender As System.Object, e As System.Windows.Forms.ScrollEventArgs) Handles hsbGreen.Scroll
        lblGreen.Text = hsbGreen.Value.ToString
        upDateColor()
    End Sub

    Private Sub hsbBlue_Scroll(sender As System.Object, e As System.Windows.Forms.ScrollEventArgs) Handles hsbBlue.Scroll
        lblBlue.Text = hsbBlue.Value.ToString
        upDateColor()
    End Sub

    Public Sub upDateColor()
        Dim red As Integer = hsbRed.Value
        Dim green As Integer = hsbGreen.Value
        Dim blue As Integer = hsbBlue.Value

        lblColor.BackColor = Color.FromArgb(red, green, blue)
    End Sub
End Class