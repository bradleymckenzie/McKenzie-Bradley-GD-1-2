Public Class Form1

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        Reset()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub reset()
        Dim g As Graphics = Me.CreateGraphics
        Dim penGray As New Pen(Color.Gray, 1)
        Dim penBlack As New Pen(Color.Black, 2)

        Me.Refresh()

        txtx1.Text = ""
        txtx2.Text = ""
        txty1.Text = ""
        txty2.Text = ""

        For x1 = 150 To 800 Step 25
            g.DrawLine(penGray, x1, 25, x1, 625)
        Next
        For y1 = 25 To 625 Step 25
            g.DrawLine(penGray, 150, y1, 800, y1)
        Next
        g.DrawLine(penBlack, 475, 25, 475, 625)
        g.DrawLine(penBlack, 100, 325, 800, 325)
    End Sub
    Private Sub btnPlot_Click(sender As System.Object, e As System.EventArgs) Handles btnPlot.Click
        Dim g As Graphics = Me.CreateGraphics
        Dim PenRed As New Pen(Color.Red, 2)

        Dim x1 As Integer = 475
        Dim x2 As Integer = 475
        Dim y1 As Integer = 325
        Dim y2 As Integer = 325

        If txtx1.Text <> "" Then x1 = Integer.Parse(txtx1.Text)
        If txtx2.Text <> "" Then x2 += Integer.Parse(txtx2.Text) - (x2 / 2)
        If txty1.Text <> "" Then y1 += Integer.Parse(txty1.Text) - (y1 / 2)
        If txty2.Text <> "" Then y2 += Integer.Parse(txty1.Text) - (y2 / 2)
        g.DrawLine(PenRed, x1, x2, y1, y2)
    End Sub

    Private Sub Form1_Click(sender As System.Object, e As System.EventArgs) Handles MyBase.Click
        lblBegin.Visible = False
        reset()
    End Sub
End Class
