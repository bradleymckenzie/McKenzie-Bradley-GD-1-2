Public Class Form1

    Private Sub Form1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Form2.Show()
        tmrGo.Enabled = False
    End Sub

    Private Sub tmrGo_Tick(sender As System.Object, e As System.EventArgs) Handles tmrGo.Tick
        If pgrBar.Value < 100 Then pgrBar.Value += 1
        If pgrBar.Value = 100 Then
            Me.Hide()
            Form2.Show()
            Form2.Activate()
            tmrGo.Enabled = False
        End If
    End Sub
End Class