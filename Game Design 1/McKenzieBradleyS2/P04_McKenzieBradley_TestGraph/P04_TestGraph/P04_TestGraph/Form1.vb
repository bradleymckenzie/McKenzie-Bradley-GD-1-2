Public Class Form1

    Private Sub btnGraph_Click(sender As System.Object, e As System.EventArgs) Handles btnGraph.Click
        Dim g As Graphics = lblGraph.CreateGraphics()
        Dim penBlue As New Pen(Color.Blue, 4)
        Dim y As Integer = lblGraph.Height
        Dim score1 As Integer = 0
        Dim score2 As Integer = 0
        Dim score3 As Integer = 0
        Dim score4 As Integer = 0
        Dim score5 As Integer = 0
        Reset()
        '1
        If IsNumeric(TxtT1.Text) Then
            If Integer.Parse(TxtT1.Text) > 0 And Integer.Parse(TxtT1.Text) <= 100 Then
                score1 = Integer.Parse(TxtT1.Text) * 3
            End If
        End If
        '2
        If IsNumeric(TxtT2.Text) Then
            If Integer.Parse(TxtT2.Text) > 0 And Integer.Parse(TxtT2.Text) <= 100 Then
                score2 = Integer.Parse(TxtT2.Text) * 3
            End If
        End If
        '3
        If IsNumeric(TxtT3.Text) Then
            If Integer.Parse(TxtT3.Text) > 0 And Integer.Parse(TxtT3.Text) <= 100 Then
                score3 = Integer.Parse(TxtT3.Text) * 3
            End If
        End If
        '4
        If IsNumeric(TxtT4.Text) Then
            If Integer.Parse(TxtT4.Text) > 0 And Integer.Parse(TxtT4.Text) <= 100 Then
                score4 = Integer.Parse(TxtT4.Text) * 3
            End If
        End If
        '5
        If IsNumeric(TxtT5.Text) Then
            If Integer.Parse(TxtT5.Text) > 0 And Integer.Parse(TxtT5.Text) <= 100 Then
                score5 = Integer.Parse(TxtT5.Text) * 3
            End If
        End If

        g.DrawLine(penBlue, 55, y - score1, 165, y - score2)
        g.DrawLine(penBlue, 165, y - score2, 275, y - score3)
        g.DrawLine(penBlue, 275, y - score3, 385, y - score4)
        g.DrawLine(penBlue, 385, y - score4, 495, y - score5)
    End Sub

    Private Sub Reset()
        Dim g As Graphics = lblGraph.CreateGraphics()
        Dim penGray As New Pen(Color.Gray, 1)

        For x = 0 To lblGraph.Width Step 55
            g.DrawLine(penGray, x, 0, x, lblGraph.Height)
        Next

        For y = 0 To lblGraph.Height Step 60
            g.DrawLine(penGray, 0, y, lblGraph.Width, y)
        Next
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub tmrDraw_Tick(sender As System.Object, e As System.EventArgs) Handles tmrDraw.Tick
        tmrDraw.Enabled = False
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        lblGraph.Refresh()
        Reset()
        TxtT1.Text = ""
        TxtT2.Text = ""
        TxtT3.Text = ""
        TxtT4.Text = ""
        TxtT5.Text = ""
    End Sub
End Class
