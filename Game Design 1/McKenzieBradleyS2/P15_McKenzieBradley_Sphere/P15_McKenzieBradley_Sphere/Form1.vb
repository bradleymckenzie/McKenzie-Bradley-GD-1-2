Public Class Form1

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        lblSurfaceArea.Text = " "
        lblVolume.Text = " "
        txtRadius.Text = " "
    End Sub

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim r As Double = Integer.Parse(txtRadius.Text)
        Dim sa As Double = (4 * 3.14 * (r * r))
        Dim v As Double = (4 / 3 * 3.14 * (r * r * r))

        lblSurfaceArea.Text = Format(sa, "#.0")
        lblVolume.Text = Format(v, "#.0")
    End Sub
End Class
