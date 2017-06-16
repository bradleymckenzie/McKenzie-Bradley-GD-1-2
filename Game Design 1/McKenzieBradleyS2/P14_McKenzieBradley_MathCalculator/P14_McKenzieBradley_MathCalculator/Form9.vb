Public Class Form9
    Dim points As Integer
    Dim grades As Integer
    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Form2.Show()
        Form2.Activate()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        lblGPA.Text = ""
        txtP1.Text = ""
        txtP2.Text = ""
        txtP3.Text = ""
        txtP4.Text = ""
        txtP5.Text = ""
        txtP6.Text = ""
    End Sub

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim gpa As Double

        gradePoint(txtP1.Text)
        gradePoint(txtP2.Text)
        gradePoint(txtP3.Text)
        gradePoint(txtP4.Text)
        gradePoint(txtP5.Text)
        gradePoint(txtP6.Text)

        gpa = points / grades

        lblGPA.Text = Format(gpa, ".00")
    End Sub
    Private Sub gradePoint(s As String)
        If s = "A" Or s = "a" Then
            points += 4
            grades += 1

        ElseIf s = "B" Or s = "b" Then
            points += 3
            grades += 1

        ElseIf s = "C" Or s = "c" Then
            points += 2
            grades += 1

        ElseIf s = "D" Or s = "d" Then
            points += 1
            grades += 1

        ElseIf s = "F" Or s = "d" Then
            points += 0
            grades += 1
        End If
    End Sub
End Class