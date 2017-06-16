Public Class Form2

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs)
        Form1.Hide()
        Form3.Hide()
        Form4.Hide()
        Form5.Hide()
        Form6.Hide()
        Form7.Hide()
        Form8.Hide()
        Form9.Hide()
        Form10.Hide()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnFactors_Click(sender As System.Object, e As System.EventArgs) Handles btnFactors.Click
        Me.Hide()
        Form3.Show()
        Form3.Activate()
    End Sub

    Private Sub btnEncryption_Click(sender As System.Object, e As System.EventArgs) Handles btnEncryption.Click
        Me.Hide()
        Form4.Show()
        Form4.Activate()
    End Sub

    Private Sub btnDecimaltoBinary_Click(sender As System.Object, e As System.EventArgs) Handles btnDecimaltoBinary.Click
        Me.Hide()
        Form5.Show()
        Form5.Activate()
    End Sub

    Private Sub btnColor_Click(sender As System.Object, e As System.EventArgs) Handles btnColor.Click
        Me.Hide()
        Form6.Show()
        Form6.Activate()
    End Sub

    Private Sub btnBodyMassIndex_Click(sender As System.Object, e As System.EventArgs) Handles btnBodyMassIndex.Click
        Me.Hide()
        Form7.Show()
        Form7.Activate()
    End Sub

    Private Sub btnGPA_Click(sender As System.Object, e As System.EventArgs) Handles btnGPA.Click
        Me.Hide()
        Form9.Show()
        Form9.Activate()
    End Sub

    Private Sub btnGraphing_Click(sender As System.Object, e As System.EventArgs) Handles btnGraphing.Click
        Me.Hide()
        Form10.Show()
        Form10.Activate()
    End Sub

End Class