Public Class Form3

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        txtNumber.Text = " "
        lblFactors.Text = " "
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Form2.Show()
        Form2.Activate()
    End Sub

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Form1.Hide()
        Form2.Hide()
    End Sub

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim n As Integer = Integer.Parse(txtNumber.Text)

        lblFactors.Text = "1"

        For i = 2 To n
            If n Mod i Then
                lblFactors.Text = lblFactors.Text + ",  " + i.ToString
            End If
        Next
    End Sub
End Class