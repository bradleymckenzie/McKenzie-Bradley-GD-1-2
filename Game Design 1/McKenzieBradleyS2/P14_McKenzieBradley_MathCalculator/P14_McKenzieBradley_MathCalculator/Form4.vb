Public Class Form4

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Form2.Show()
        Form2.Activate()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        rtbNormal.Text = " "
        lblEncrypted.Text = " "
    End Sub

    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Form2.Hide()
    End Sub

    Private Sub btnEnctypt_Click(sender As System.Object, e As System.EventArgs) Handles btnEncrypt.Click
        Dim len As Integer = rtbNormal.Text.Length - 1
        Dim s = rtbNormal.Text.ToCharArray
        Dim value As Integer

        lblEncrypted.Text = " "

        For i = 0 To len
            value = Asc(s(i))
            If value >= 65 And value < 90 Then
                lblEncrypted.Text = lblEncrypted.Text + Chr(value + 1)
            ElseIf value >= 97 And value < 122 Then
                lblEncrypted.Text = lblEncrypted.Text + Chr(value + 1)
            ElseIf value = 90 Or value = 122 Then
                lblEncrypted.Text = lblEncrypted.Text + Chr(value - 25)
            Else
                lblEncrypted.Text = lblEncrypted.Text + " "
            End If
        Next
    End Sub
End Class