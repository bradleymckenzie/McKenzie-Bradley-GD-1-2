Public Class Form8

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Form2.Show()
        Form2.Activate()
    End Sub

    Private Sub btnSet_Click(sender As System.Object, e As System.EventArgs) Handles btnSet.Click
        Dim x As Integer = Integer.Parse(txtX.Text)
        Dim y As Integer = Integer.Parse(txtY.Text)

        If x < 0 Or x > 450 Then x = 450
        If y < 0 Or y > 450 Then y = 450

        picAnonymous.Width = x
        picAnonymous.Height = y
    End Sub

    Private Sub hsbX_Scroll(sender As System.Object, e As System.Windows.Forms.ScrollEventArgs) Handles hsbX.Scroll
        picAnonymous.Width = hsbX.Value
        txtX.Text = hsbX.Value.ToString
        txtY.Text = hsbY.Value.ToString
    End Sub

    Private Sub hsbY_Scroll(sender As System.Object, e As System.Windows.Forms.ScrollEventArgs) Handles hsbY.Scroll
        picAnonymous.Height = hsbY.Value
        txtX.Text = hsbX.Value.ToString
        txtY.Text = hsbY.Value.ToString
    End Sub
End Class