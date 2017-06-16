Public Class Form1

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        If TextBox1.Text = ("SnakeBar") Then TextBox2.Text = ("SnackBar123")
        Form2.Show()
        Me.Hide()
    End Sub
End Class