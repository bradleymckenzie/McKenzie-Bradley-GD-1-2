Public Class Form1

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        lblGraph.Refresh()
        drawGraph()
        txtP1.Text = ""
        txtP2.Text = ""
        txtP3.Text = ""
        txtP4.Text = ""
        txtP5.Text = ""
        txtP6.Text = ""
    End Sub

    Private Sub btnGraph_Click(sender As System.Object, e As System.EventArgs) Handles btnGraph.Click
        Dim g As Graphics = lblGraph.CreateGraphics()
        Dim x1 As Integer = (txtP1.Left - lblGraph.Left) + (txtP1.Width / 3)
        Dim x2 As Integer = (txtP1.Left - lblGraph.Left) + (txtP1.Width / 3)

        lblGraph.Refresh()
        drawGraph()
        g.FillRectangle(Brushes.Cyan, x1, lblGraph.Height - getValue(txtP1.Text), x2, getValue(txtP1.Text))
        x1 += 100
        g.FillRectangle(Brushes.Cyan, x1, lblGraph.Height - getValue(txtP2.Text), x2, getValue(txtP2.Text))
        x1 += 100
        g.FillRectangle(Brushes.Cyan, x1, lblGraph.Height - getValue(txtP3.Text), x2, getValue(txtP3.Text))
        x1 += 100
        g.FillRectangle(Brushes.Cyan, x1, lblGraph.Height - getValue(txtP4.Text), x2, getValue(txtP4.Text))
        x1 += 100
        g.FillRectangle(Brushes.Cyan, x1, lblGraph.Height - getValue(txtP5.Text), x2, getValue(txtP5.Text))
        x1 += 100
        g.FillRectangle(Brushes.Cyan, x1, lblGraph.Height - getValue(txtP6.Text), x2, getValue(txtP6.Text))
        x1 += 100
    End Sub
    Private Sub drawGraph()
        Dim g As Graphics = lblGraph.CreateGraphics()
        Dim penGray As New Pen(Color.Gray, 1)
        Dim y As Integer = lblGraph.Height
        Dim x As Integer = lblGraph.Width
        For x = 0 To lblGraph.Width Step 100
            g.DrawLine(penGray, x, 0, x, lblGraph.Height)
        Next
        For y = 0 To lblGraph.Height Step 100
            g.DrawLine(penGray, 0, y, lblGraph.Width, y)
        Next
    End Sub

    Public Function getValue(ByVal grade As String)
        If UCase(grade) = "A" Then
            Return 4 * 100
        ElseIf UCase(grade) = "B" Then
            Return 3 * 100
        ElseIf UCase(grade) = "C" Then
            Return 2 * 100
        ElseIf UCase(grade) = "D" Then
            Return 1 * 100
        Else
            Return 0
        End If
    End Function
End Class
