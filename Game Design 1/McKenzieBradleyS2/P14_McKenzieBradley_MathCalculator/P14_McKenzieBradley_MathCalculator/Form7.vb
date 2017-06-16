Public Class Form7

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Form2.Show()
        Form2.Activate()
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        txtHeight.Text = " "
        txtWeight.Text = " "
        lblBMI.Text = " "
        lblResult.Text = " "
    
    End Sub

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim h As Double = Integer.Parse(txtHeight.Text)
        Dim w As Double = Integer.Parse(txtWeight.Text)
        Dim bmi As Double = (w / (h * h) * 703)

        Dim result As String

        lblBMI.Text = Format(bmi, "#.0")

        If bmi < 18.5 Then
            result = "Under Weight"
        ElseIf bmi < 25 Then
            result = "Normal Weight"
        ElseIf bmi < 30 Then
            result = "Over Weight"
        Else
            result = "Obese"
        End If
        lblResult.Text = result
    End Sub
End Class