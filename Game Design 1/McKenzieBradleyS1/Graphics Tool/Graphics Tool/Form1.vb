Public Class Form1

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnDrawLine_Click(sender As System.Object, e As System.EventArgs) Handles btnDrawLine.Click
        Dim g As Graphics = Me.CreateGraphics
        Dim penBlack As New Pen(Color.Black, 4)
        Me.Refresh()

        'b
        g.DrawLine(penBlack, 200, 75, 325, 75)
        g.DrawLine(penBlack, 200, 75, 200, 250)
        g.DrawLine(penBlack, 325, 75, 325, 250)
        g.DrawLine(penBlack, 200, 250, 325, 250)
        g.DrawLine(penBlack, 200, 160, 325, 160)

        'c
        g.DrawLine(penBlack, 350, 75, 475, 75)
        g.DrawLine(penBlack, 350, 75, 350, 250)
        g.DrawLine(penBlack, 350, 250, 475, 250)

        'm
        g.DrawLine(penBlack, 500, 75, 500, 250)
        g.DrawLine(penBlack, 625, 75, 625, 250)
        g.DrawLine(penBlack, 500, 75, 565, 150)
        g.DrawLine(penBlack, 625, 75, 565, 150)
    End Sub

    Private Sub btnDrawEllipse_Click(sender As System.Object, e As System.EventArgs) Handles btnDrawEllipse.Click
        Dim g As Graphics = Me.CreateGraphics
        Dim penBlack As New Pen(Color.Black, 4)
        Me.Refresh()

        'bLine1
        g.DrawEllipse(penBlack, 200, 75, 25, 25)
        g.DrawEllipse(penBlack, 225, 75, 25, 25)
        g.DrawEllipse(penBlack, 250, 75, 25, 25)
        g.DrawEllipse(penBlack, 275, 75, 25, 25)
        g.DrawEllipse(penBlack, 300, 75, 25, 25)
        g.DrawEllipse(penBlack, 325, 75, 25, 25)
        'bLine2
        g.DrawEllipse(penBlack, 200, 100, 25, 25)
        g.DrawEllipse(penBlack, 200, 125, 25, 25)
        g.DrawEllipse(penBlack, 200, 150, 25, 25)
        g.DrawEllipse(penBlack, 200, 175, 25, 25)
        g.DrawEllipse(penBlack, 200, 200, 25, 25)
        g.DrawEllipse(penBlack, 200, 225, 25, 25)
        g.DrawEllipse(penBlack, 200, 250, 25, 25)
        'bLine3
        g.DrawEllipse(penBlack, 325, 100, 25, 25)
        g.DrawEllipse(penBlack, 325, 125, 25, 25)
        g.DrawEllipse(penBlack, 325, 150, 25, 25)
        g.DrawEllipse(penBlack, 325, 175, 25, 25)
        g.DrawEllipse(penBlack, 325, 200, 25, 25)
        g.DrawEllipse(penBlack, 325, 225, 25, 25)
        g.DrawEllipse(penBlack, 325, 250, 25, 25)
        'bLine5
        g.DrawEllipse(penBlack, 225, 165, 25, 25)
        g.DrawEllipse(penBlack, 250, 165, 25, 25)
        g.DrawEllipse(penBlack, 275, 165, 25, 25)
        g.DrawEllipse(penBlack, 300, 165, 25, 25)
        'bLine6
        g.DrawEllipse(penBlack, 225, 250, 25, 25)
        g.DrawEllipse(penBlack, 250, 250, 25, 25)
        g.DrawEllipse(penBlack, 275, 250, 25, 25)
        g.DrawEllipse(penBlack, 300, 250, 25, 25)

        'cLine1
        g.DrawEllipse(penBlack, 375, 75, 25, 25)
        g.DrawEllipse(penBlack, 400, 75, 25, 25)
        g.DrawEllipse(penBlack, 425, 75, 25, 25)
        g.DrawEllipse(penBlack, 450, 75, 25, 25)
        g.DrawEllipse(penBlack, 475, 75, 25, 25)
        'cLine2
        g.DrawEllipse(penBlack, 375, 100, 25, 25)
        g.DrawEllipse(penBlack, 375, 125, 25, 25)
        g.DrawEllipse(penBlack, 375, 150, 25, 25)
        g.DrawEllipse(penBlack, 375, 175, 25, 25)
        g.DrawEllipse(penBlack, 375, 200, 25, 25)
        g.DrawEllipse(penBlack, 375, 225, 25, 25)
        g.DrawEllipse(penBlack, 375, 250, 25, 25)
        'cLine3
        g.DrawEllipse(penBlack, 375, 250, 25, 25)
        g.DrawEllipse(penBlack, 400, 250, 25, 25)
        g.DrawEllipse(penBlack, 425, 250, 25, 25)
        g.DrawEllipse(penBlack, 450, 250, 25, 25)
        g.DrawEllipse(penBlack, 475, 250, 25, 25)

        'mLine1
        g.DrawEllipse(penBlack, 525, 75, 25, 25)
        g.DrawEllipse(penBlack, 525, 100, 25, 25)
        g.DrawEllipse(penBlack, 525, 125, 25, 25)
        g.DrawEllipse(penBlack, 525, 150, 25, 25)
        g.DrawEllipse(penBlack, 525, 175, 25, 25)
        g.DrawEllipse(penBlack, 525, 200, 25, 25)
        g.DrawEllipse(penBlack, 525, 225, 25, 25)
        g.DrawEllipse(penBlack, 525, 250, 25, 25)
        'mLine2
        g.DrawEllipse(penBlack, 625, 75, 25, 25)
        g.DrawEllipse(penBlack, 625, 100, 25, 25)
        g.DrawEllipse(penBlack, 625, 125, 25, 25)
        g.DrawEllipse(penBlack, 625, 150, 25, 25)
        g.DrawEllipse(penBlack, 625, 175, 25, 25)
        g.DrawEllipse(penBlack, 625, 200, 25, 25)
        g.DrawEllipse(penBlack, 625, 225, 25, 25)
        g.DrawEllipse(penBlack, 625, 250, 25, 25)
        'mLine3
        g.DrawEllipse(penBlack, 550, 85, 25, 25)
        g.DrawEllipse(penBlack, 575, 95, 25, 25)
        g.DrawEllipse(penBlack, 600, 85, 25, 25)
    End Sub

    Private Sub btnFillEllipse_Click(sender As System.Object, e As System.EventArgs) Handles btnFillEllipse.Click
        Dim g As Graphics = Me.CreateGraphics
        Dim penBlack As New Pen(Color.Black, 4)
        Me.Refresh()

        'bLine1
        g.FillEllipse(Brushes.Red, 200, 75, 25, 25)
        g.FillEllipse(Brushes.Red, 225, 75, 25, 25)
        g.FillEllipse(Brushes.Red, 250, 75, 25, 25)
        g.FillEllipse(Brushes.Red, 275, 75, 25, 25)
        g.FillEllipse(Brushes.Red, 300, 75, 25, 25)
        g.FillEllipse(Brushes.Red, 325, 75, 25, 25)
        'bLine2
        g.FillEllipse(Brushes.Red, 200, 100, 25, 25)
        g.FillEllipse(Brushes.Red, 200, 125, 25, 25)
        g.FillEllipse(Brushes.Red, 200, 150, 25, 25)
        g.FillEllipse(Brushes.Red, 200, 175, 25, 25)
        g.FillEllipse(Brushes.Red, 200, 200, 25, 25)
        g.FillEllipse(Brushes.Red, 200, 225, 25, 25)
        g.FillEllipse(Brushes.Red, 200, 250, 25, 25)
        'bLine3
        g.FillEllipse(Brushes.Red, 325, 100, 25, 25)
        g.FillEllipse(Brushes.Red, 325, 125, 25, 25)
        g.FillEllipse(Brushes.Red, 325, 150, 25, 25)
        g.FillEllipse(Brushes.Red, 325, 175, 25, 25)
        g.FillEllipse(Brushes.Red, 325, 200, 25, 25)
        g.FillEllipse(Brushes.Red, 325, 225, 25, 25)
        g.FillEllipse(Brushes.Red, 325, 250, 25, 25)
        'bLine5
        g.FillEllipse(Brushes.Red, 225, 165, 25, 25)
        g.FillEllipse(Brushes.Red, 250, 165, 25, 25)
        g.FillEllipse(Brushes.Red, 275, 165, 25, 25)
        g.FillEllipse(Brushes.Red, 300, 165, 25, 25)
        'bLine6
        g.FillEllipse(Brushes.Red, 225, 250, 25, 25)
        g.FillEllipse(Brushes.Red, 250, 250, 25, 25)
        g.FillEllipse(Brushes.Red, 275, 250, 25, 25)
        g.FillEllipse(Brushes.Red, 300, 250, 25, 25)

        'cLine1
        g.FillEllipse(Brushes.Red, 375, 75, 25, 25)
        g.FillEllipse(Brushes.Red, 400, 75, 25, 25)
        g.FillEllipse(Brushes.Red, 425, 75, 25, 25)
        g.FillEllipse(Brushes.Red, 450, 75, 25, 25)
        g.FillEllipse(Brushes.Red, 475, 75, 25, 25)
        'cLine2
        g.FillEllipse(Brushes.Red, 375, 100, 25, 25)
        g.FillEllipse(Brushes.Red, 375, 125, 25, 25)
        g.FillEllipse(Brushes.Red, 375, 150, 25, 25)
        g.FillEllipse(Brushes.Red, 375, 175, 25, 25)
        g.FillEllipse(Brushes.Red, 375, 200, 25, 25)
        g.FillEllipse(Brushes.Red, 375, 225, 25, 25)
        g.FillEllipse(Brushes.Red, 375, 250, 25, 25)
        'cLine3
        g.FillEllipse(Brushes.Red, 375, 250, 25, 25)
        g.FillEllipse(Brushes.Red, 400, 250, 25, 25)
        g.FillEllipse(Brushes.Red, 425, 250, 25, 25)
        g.FillEllipse(Brushes.Red, 450, 250, 25, 25)
        g.FillEllipse(Brushes.Red, 475, 250, 25, 25)

        'mLine1
        g.FillEllipse(Brushes.Red, 525, 75, 25, 25)
        g.FillEllipse(Brushes.Red, 525, 100, 25, 25)
        g.FillEllipse(Brushes.Red, 525, 125, 25, 25)
        g.FillEllipse(Brushes.Red, 525, 150, 25, 25)
        g.FillEllipse(Brushes.Red, 525, 175, 25, 25)
        g.FillEllipse(Brushes.Red, 525, 200, 25, 25)
        g.FillEllipse(Brushes.Red, 525, 225, 25, 25)
        g.FillEllipse(Brushes.Red, 525, 250, 25, 25)
        'mLine2
        g.FillEllipse(Brushes.Red, 625, 75, 25, 25)
        g.FillEllipse(Brushes.Red, 625, 100, 25, 25)
        g.FillEllipse(Brushes.Red, 625, 125, 25, 25)
        g.FillEllipse(Brushes.Red, 625, 150, 25, 25)
        g.FillEllipse(Brushes.Red, 625, 175, 25, 25)
        g.FillEllipse(Brushes.Red, 625, 200, 25, 25)
        g.FillEllipse(Brushes.Red, 625, 225, 25, 25)
        g.FillEllipse(Brushes.Red, 625, 250, 25, 25)
        'mLine3
        g.FillEllipse(Brushes.Red, 550, 85, 25, 25)
        g.FillEllipse(Brushes.Red, 575, 95, 25, 25)
        g.FillEllipse(Brushes.Red, 600, 85, 25, 25)


        'bLine1
        g.DrawEllipse(penBlack, 200, 75, 25, 25)
        g.DrawEllipse(penBlack, 225, 75, 25, 25)
        g.DrawEllipse(penBlack, 250, 75, 25, 25)
        g.DrawEllipse(penBlack, 275, 75, 25, 25)
        g.DrawEllipse(penBlack, 300, 75, 25, 25)
        g.DrawEllipse(penBlack, 325, 75, 25, 25)
        'bLine2
        g.DrawEllipse(penBlack, 200, 100, 25, 25)
        g.DrawEllipse(penBlack, 200, 125, 25, 25)
        g.DrawEllipse(penBlack, 200, 150, 25, 25)
        g.DrawEllipse(penBlack, 200, 175, 25, 25)
        g.DrawEllipse(penBlack, 200, 200, 25, 25)
        g.DrawEllipse(penBlack, 200, 225, 25, 25)
        g.DrawEllipse(penBlack, 200, 250, 25, 25)
        'bLine3
        g.DrawEllipse(penBlack, 325, 100, 25, 25)
        g.DrawEllipse(penBlack, 325, 125, 25, 25)
        g.DrawEllipse(penBlack, 325, 150, 25, 25)
        g.DrawEllipse(penBlack, 325, 175, 25, 25)
        g.DrawEllipse(penBlack, 325, 200, 25, 25)
        g.DrawEllipse(penBlack, 325, 225, 25, 25)
        g.DrawEllipse(penBlack, 325, 250, 25, 25)
        'bLine5
        g.DrawEllipse(penBlack, 225, 165, 25, 25)
        g.DrawEllipse(penBlack, 250, 165, 25, 25)
        g.DrawEllipse(penBlack, 275, 165, 25, 25)
        g.DrawEllipse(penBlack, 300, 165, 25, 25)
        'bLine6
        g.DrawEllipse(penBlack, 225, 250, 25, 25)
        g.DrawEllipse(penBlack, 250, 250, 25, 25)
        g.DrawEllipse(penBlack, 275, 250, 25, 25)
        g.DrawEllipse(penBlack, 300, 250, 25, 25)

        'cLine1
        g.DrawEllipse(penBlack, 375, 75, 25, 25)
        g.DrawEllipse(penBlack, 400, 75, 25, 25)
        g.DrawEllipse(penBlack, 425, 75, 25, 25)
        g.DrawEllipse(penBlack, 450, 75, 25, 25)
        g.DrawEllipse(penBlack, 475, 75, 25, 25)
        'cLine2
        g.DrawEllipse(penBlack, 375, 100, 25, 25)
        g.DrawEllipse(penBlack, 375, 125, 25, 25)
        g.DrawEllipse(penBlack, 375, 150, 25, 25)
        g.DrawEllipse(penBlack, 375, 175, 25, 25)
        g.DrawEllipse(penBlack, 375, 200, 25, 25)
        g.DrawEllipse(penBlack, 375, 225, 25, 25)
        g.DrawEllipse(penBlack, 375, 250, 25, 25)
        'cLine3
        g.DrawEllipse(penBlack, 375, 250, 25, 25)
        g.DrawEllipse(penBlack, 400, 250, 25, 25)
        g.DrawEllipse(penBlack, 425, 250, 25, 25)
        g.DrawEllipse(penBlack, 450, 250, 25, 25)
        g.DrawEllipse(penBlack, 475, 250, 25, 25)

        'mLine1
        g.DrawEllipse(penBlack, 525, 75, 25, 25)
        g.DrawEllipse(penBlack, 525, 100, 25, 25)
        g.DrawEllipse(penBlack, 525, 125, 25, 25)
        g.DrawEllipse(penBlack, 525, 150, 25, 25)
        g.DrawEllipse(penBlack, 525, 175, 25, 25)
        g.DrawEllipse(penBlack, 525, 200, 25, 25)
        g.DrawEllipse(penBlack, 525, 225, 25, 25)
        g.DrawEllipse(penBlack, 525, 250, 25, 25)
        'mLine2
        g.DrawEllipse(penBlack, 625, 75, 25, 25)
        g.DrawEllipse(penBlack, 625, 100, 25, 25)
        g.DrawEllipse(penBlack, 625, 125, 25, 25)
        g.DrawEllipse(penBlack, 625, 150, 25, 25)
        g.DrawEllipse(penBlack, 625, 175, 25, 25)
        g.DrawEllipse(penBlack, 625, 200, 25, 25)
        g.DrawEllipse(penBlack, 625, 225, 25, 25)
        g.DrawEllipse(penBlack, 625, 250, 25, 25)
        'mLine3
        g.DrawEllipse(penBlack, 550, 85, 25, 25)
        g.DrawEllipse(penBlack, 575, 95, 25, 25)
        g.DrawEllipse(penBlack, 600, 85, 25, 25)
    End Sub

    Private Sub btnDrawRectangle_Click(sender As System.Object, e As System.EventArgs) Handles btnDrawRectangle.Click
        Dim g As Graphics = Me.CreateGraphics
        Dim penBlack As New Pen(Color.Black, 4)
        Me.Refresh()

        'bLine1
        g.DrawRectangle(penBlack, 200, 75, 25, 25)
        g.DrawRectangle(penBlack, 225, 75, 25, 25)
        g.DrawRectangle(penBlack, 250, 75, 25, 25)
        g.DrawRectangle(penBlack, 275, 75, 25, 25)
        g.DrawRectangle(penBlack, 300, 75, 25, 25)
        g.DrawRectangle(penBlack, 325, 75, 25, 25)
        'bLine2
        g.DrawRectangle(penBlack, 200, 100, 25, 25)
        g.DrawRectangle(penBlack, 200, 125, 25, 25)
        g.DrawRectangle(penBlack, 200, 150, 25, 25)
        g.DrawRectangle(penBlack, 200, 175, 25, 25)
        g.DrawRectangle(penBlack, 200, 200, 25, 25)
        g.DrawRectangle(penBlack, 200, 225, 25, 25)
        g.DrawRectangle(penBlack, 200, 250, 25, 25)
        'bLine3
        g.DrawRectangle(penBlack, 325, 100, 25, 25)
        g.DrawRectangle(penBlack, 325, 125, 25, 25)
        g.DrawRectangle(penBlack, 325, 150, 25, 25)
        g.DrawRectangle(penBlack, 325, 175, 25, 25)
        g.DrawRectangle(penBlack, 325, 200, 25, 25)
        g.DrawRectangle(penBlack, 325, 225, 25, 25)
        g.DrawRectangle(penBlack, 325, 250, 25, 25)
        'bLine5
        g.DrawRectangle(penBlack, 225, 165, 25, 25)
        g.DrawRectangle(penBlack, 250, 165, 25, 25)
        g.DrawRectangle(penBlack, 275, 165, 25, 25)
        g.DrawRectangle(penBlack, 300, 165, 25, 25)
        'bLine6
        g.DrawRectangle(penBlack, 225, 250, 25, 25)
        g.DrawRectangle(penBlack, 250, 250, 25, 25)
        g.DrawRectangle(penBlack, 275, 250, 25, 25)
        g.DrawRectangle(penBlack, 300, 250, 25, 25)

        'cLine1
        g.DrawRectangle(penBlack, 375, 75, 25, 25)
        g.DrawRectangle(penBlack, 400, 75, 25, 25)
        g.DrawRectangle(penBlack, 425, 75, 25, 25)
        g.DrawRectangle(penBlack, 450, 75, 25, 25)
        g.DrawRectangle(penBlack, 475, 75, 25, 25)
        'cLine2
        g.DrawRectangle(penBlack, 375, 100, 25, 25)
        g.DrawRectangle(penBlack, 375, 125, 25, 25)
        g.DrawRectangle(penBlack, 375, 150, 25, 25)
        g.DrawRectangle(penBlack, 375, 175, 25, 25)
        g.DrawRectangle(penBlack, 375, 200, 25, 25)
        g.DrawRectangle(penBlack, 375, 225, 25, 25)
        g.DrawRectangle(penBlack, 375, 250, 25, 25)
        'cLine3
        g.DrawRectangle(penBlack, 375, 250, 25, 25)
        g.DrawRectangle(penBlack, 400, 250, 25, 25)
        g.DrawRectangle(penBlack, 425, 250, 25, 25)
        g.DrawRectangle(penBlack, 450, 250, 25, 25)
        g.DrawRectangle(penBlack, 475, 250, 25, 25)

        'mLine1
        g.DrawRectangle(penBlack, 525, 75, 25, 25)
        g.DrawRectangle(penBlack, 525, 100, 25, 25)
        g.DrawRectangle(penBlack, 525, 125, 25, 25)
        g.DrawRectangle(penBlack, 525, 150, 25, 25)
        g.DrawRectangle(penBlack, 525, 175, 25, 25)
        g.DrawRectangle(penBlack, 525, 200, 25, 25)
        g.DrawRectangle(penBlack, 525, 225, 25, 25)
        g.DrawRectangle(penBlack, 525, 250, 25, 25)
        'mLine2
        g.DrawRectangle(penBlack, 625, 75, 25, 25)
        g.DrawRectangle(penBlack, 625, 100, 25, 25)
        g.DrawRectangle(penBlack, 625, 125, 25, 25)
        g.DrawRectangle(penBlack, 625, 150, 25, 25)
        g.DrawRectangle(penBlack, 625, 175, 25, 25)
        g.DrawRectangle(penBlack, 625, 200, 25, 25)
        g.DrawRectangle(penBlack, 625, 225, 25, 25)
        g.DrawRectangle(penBlack, 625, 250, 25, 25)
        'mLine3
        g.DrawRectangle(penBlack, 550, 85, 25, 25)
        g.DrawRectangle(penBlack, 575, 95, 25, 25)
        g.DrawRectangle(penBlack, 600, 85, 25, 25)
    End Sub

    Private Sub btnFillRectangle_Click(sender As System.Object, e As System.EventArgs) Handles btnFillRectangle.Click
        Dim g As Graphics = Me.CreateGraphics
        Dim penBlack As New Pen(Color.Black, 4)
        Me.Refresh()

        'bLine1
        g.FillRectangle(Brushes.Red, 200, 75, 25, 25)
        g.FillRectangle(Brushes.Red, 225, 75, 25, 25)
        g.FillRectangle(Brushes.Red, 250, 75, 25, 25)
        g.FillRectangle(Brushes.Red, 275, 75, 25, 25)
        g.FillRectangle(Brushes.Red, 300, 75, 25, 25)
        g.FillRectangle(Brushes.Red, 325, 75, 25, 25)
        'bLine2
        g.FillRectangle(Brushes.Red, 200, 100, 25, 25)
        g.FillRectangle(Brushes.Red, 200, 125, 25, 25)
        g.FillRectangle(Brushes.Red, 200, 150, 25, 25)
        g.FillRectangle(Brushes.Red, 200, 175, 25, 25)
        g.FillRectangle(Brushes.Red, 200, 200, 25, 25)
        g.FillRectangle(Brushes.Red, 200, 225, 25, 25)
        g.FillRectangle(Brushes.Red, 200, 250, 25, 25)
        'bLine3
        g.FillRectangle(Brushes.Red, 325, 100, 25, 25)
        g.FillRectangle(Brushes.Red, 325, 125, 25, 25)
        g.FillRectangle(Brushes.Red, 325, 150, 25, 25)
        g.FillRectangle(Brushes.Red, 325, 175, 25, 25)
        g.FillRectangle(Brushes.Red, 325, 200, 25, 25)
        g.FillRectangle(Brushes.Red, 325, 225, 25, 25)
        g.FillRectangle(Brushes.Red, 325, 250, 25, 25)
        'bLine5
        g.FillRectangle(Brushes.Red, 225, 165, 25, 25)
        g.FillRectangle(Brushes.Red, 250, 165, 25, 25)
        g.FillRectangle(Brushes.Red, 275, 165, 25, 25)
        g.FillRectangle(Brushes.Red, 300, 165, 25, 25)
        'bLine6
        g.FillRectangle(Brushes.Red, 225, 250, 25, 25)
        g.FillRectangle(Brushes.Red, 250, 250, 25, 25)
        g.FillRectangle(Brushes.Red, 275, 250, 25, 25)
        g.FillRectangle(Brushes.Red, 300, 250, 25, 25)

        'cLine1
        g.FillRectangle(Brushes.Red, 375, 75, 25, 25)
        g.FillRectangle(Brushes.Red, 400, 75, 25, 25)
        g.FillRectangle(Brushes.Red, 425, 75, 25, 25)
        g.FillRectangle(Brushes.Red, 450, 75, 25, 25)
        g.FillRectangle(Brushes.Red, 475, 75, 25, 25)
        'cLine2
        g.FillRectangle(Brushes.Red, 375, 100, 25, 25)
        g.FillRectangle(Brushes.Red, 375, 125, 25, 25)
        g.FillRectangle(Brushes.Red, 375, 150, 25, 25)
        g.FillRectangle(Brushes.Red, 375, 175, 25, 25)
        g.FillRectangle(Brushes.Red, 375, 200, 25, 25)
        g.FillRectangle(Brushes.Red, 375, 225, 25, 25)
        g.FillRectangle(Brushes.Red, 375, 250, 25, 25)
        'cLine3
        g.FillRectangle(Brushes.Red, 375, 250, 25, 25)
        g.FillRectangle(Brushes.Red, 400, 250, 25, 25)
        g.FillRectangle(Brushes.Red, 425, 250, 25, 25)
        g.FillRectangle(Brushes.Red, 450, 250, 25, 25)
        g.FillRectangle(Brushes.Red, 475, 250, 25, 25)

        'mLine1
        g.FillRectangle(Brushes.Red, 525, 75, 25, 25)
        g.FillRectangle(Brushes.Red, 525, 100, 25, 25)
        g.FillRectangle(Brushes.Red, 525, 125, 25, 25)
        g.FillRectangle(Brushes.Red, 525, 150, 25, 25)
        g.FillRectangle(Brushes.Red, 525, 175, 25, 25)
        g.FillRectangle(Brushes.Red, 525, 200, 25, 25)
        g.FillRectangle(Brushes.Red, 525, 225, 25, 25)
        g.FillRectangle(Brushes.Red, 525, 250, 25, 25)
        'mLine2
        g.FillRectangle(Brushes.Red, 625, 75, 25, 25)
        g.FillRectangle(Brushes.Red, 625, 100, 25, 25)
        g.FillRectangle(Brushes.Red, 625, 125, 25, 25)
        g.FillRectangle(Brushes.Red, 625, 150, 25, 25)
        g.FillRectangle(Brushes.Red, 625, 175, 25, 25)
        g.FillRectangle(Brushes.Red, 625, 200, 25, 25)
        g.FillRectangle(Brushes.Red, 625, 225, 25, 25)
        g.FillRectangle(Brushes.Red, 625, 250, 25, 25)
        'mLine3
        g.FillRectangle(Brushes.Red, 550, 85, 25, 25)
        g.FillRectangle(Brushes.Red, 575, 95, 25, 25)
        g.FillRectangle(Brushes.Red, 600, 85, 25, 25)



        'bLine1
        g.DrawRectangle(penBlack, 200, 75, 25, 25)
        g.DrawRectangle(penBlack, 225, 75, 25, 25)
        g.DrawRectangle(penBlack, 250, 75, 25, 25)
        g.DrawRectangle(penBlack, 275, 75, 25, 25)
        g.DrawRectangle(penBlack, 300, 75, 25, 25)
        g.DrawRectangle(penBlack, 325, 75, 25, 25)
        'bLine2
        g.DrawRectangle(penBlack, 200, 100, 25, 25)
        g.DrawRectangle(penBlack, 200, 125, 25, 25)
        g.DrawRectangle(penBlack, 200, 150, 25, 25)
        g.DrawRectangle(penBlack, 200, 175, 25, 25)
        g.DrawRectangle(penBlack, 200, 200, 25, 25)
        g.DrawRectangle(penBlack, 200, 225, 25, 25)
        g.DrawRectangle(penBlack, 200, 250, 25, 25)
        'bLine3
        g.DrawRectangle(penBlack, 325, 100, 25, 25)
        g.DrawRectangle(penBlack, 325, 125, 25, 25)
        g.DrawRectangle(penBlack, 325, 150, 25, 25)
        g.DrawRectangle(penBlack, 325, 175, 25, 25)
        g.DrawRectangle(penBlack, 325, 200, 25, 25)
        g.DrawRectangle(penBlack, 325, 225, 25, 25)
        g.DrawRectangle(penBlack, 325, 250, 25, 25)
        'bLine5
        g.DrawRectangle(penBlack, 225, 165, 25, 25)
        g.DrawRectangle(penBlack, 250, 165, 25, 25)
        g.DrawRectangle(penBlack, 275, 165, 25, 25)
        g.DrawRectangle(penBlack, 300, 165, 25, 25)
        'bLine6
        g.DrawRectangle(penBlack, 225, 250, 25, 25)
        g.DrawRectangle(penBlack, 250, 250, 25, 25)
        g.DrawRectangle(penBlack, 275, 250, 25, 25)
        g.DrawRectangle(penBlack, 300, 250, 25, 25)

        'cLine1
        g.DrawRectangle(penBlack, 375, 75, 25, 25)
        g.DrawRectangle(penBlack, 400, 75, 25, 25)
        g.DrawRectangle(penBlack, 425, 75, 25, 25)
        g.DrawRectangle(penBlack, 450, 75, 25, 25)
        g.DrawRectangle(penBlack, 475, 75, 25, 25)
        'cLine2
        g.DrawRectangle(penBlack, 375, 100, 25, 25)
        g.DrawRectangle(penBlack, 375, 125, 25, 25)
        g.DrawRectangle(penBlack, 375, 150, 25, 25)
        g.DrawRectangle(penBlack, 375, 175, 25, 25)
        g.DrawRectangle(penBlack, 375, 200, 25, 25)
        g.DrawRectangle(penBlack, 375, 225, 25, 25)
        g.DrawRectangle(penBlack, 375, 250, 25, 25)
        'cLine3
        g.DrawRectangle(penBlack, 375, 250, 25, 25)
        g.DrawRectangle(penBlack, 400, 250, 25, 25)
        g.DrawRectangle(penBlack, 425, 250, 25, 25)
        g.DrawRectangle(penBlack, 450, 250, 25, 25)
        g.DrawRectangle(penBlack, 475, 250, 25, 25)

        'mLine1
        g.DrawRectangle(penBlack, 525, 75, 25, 25)
        g.DrawRectangle(penBlack, 525, 100, 25, 25)
        g.DrawRectangle(penBlack, 525, 125, 25, 25)
        g.DrawRectangle(penBlack, 525, 150, 25, 25)
        g.DrawRectangle(penBlack, 525, 175, 25, 25)
        g.DrawRectangle(penBlack, 525, 200, 25, 25)
        g.DrawRectangle(penBlack, 525, 225, 25, 25)
        g.DrawRectangle(penBlack, 525, 250, 25, 25)
        'mLine2
        g.DrawRectangle(penBlack, 625, 75, 25, 25)
        g.DrawRectangle(penBlack, 625, 100, 25, 25)
        g.DrawRectangle(penBlack, 625, 125, 25, 25)
        g.DrawRectangle(penBlack, 625, 150, 25, 25)
        g.DrawRectangle(penBlack, 625, 175, 25, 25)
        g.DrawRectangle(penBlack, 625, 200, 25, 25)
        g.DrawRectangle(penBlack, 625, 225, 25, 25)
        g.DrawRectangle(penBlack, 625, 250, 25, 25)
        'mLine3
        g.DrawRectangle(penBlack, 550, 85, 25, 25)
        g.DrawRectangle(penBlack, 575, 95, 25, 25)
        g.DrawRectangle(penBlack, 600, 85, 25, 25)
    End Sub

    Private Sub btnDrawArc_Click(sender As System.Object, e As System.EventArgs) Handles btnDrawArc.Click
        Dim g As Graphics = Me.CreateGraphics
        Dim penBlack As New Pen(Color.Black, 4)
        Me.Refresh()

        'b
        g.DrawArc(penBlack, 200, 220, 25, 25, 90, 90)
        g.DrawLine(penBlack, 200, 237, 200, 87)
        g.DrawArc(penBlack, 200, 75, 25, 25, 180, 90)
        g.DrawLine(penBlack, 212, 75, 315, 75)
        g.DrawArc(penBlack, 300, 75, 25, 25, 275, 90)
        g.DrawLine(penBlack, 325, 237, 325, 80)
        g.DrawArc(penBlack, 300, 220, 25, 25, 0, 90)
        g.DrawLine(penBlack, 212, 245, 315, 245)

        g.DrawArc(penBlack, 220, 100, 25, 25, 180, 90)
        g.DrawLine(penBlack, 230, 100, 290, 100)
        g.DrawArc(penBlack, 275, 100, 25, 25, 270, 90)
        g.DrawLine(penBlack, 220, 110, 220, 210)
        g.DrawLine(penBlack, 300, 110, 300, 210)
        g.DrawArc(penBlack, 220, 195, 25, 25, 90, 90)
        g.DrawLine(penBlack, 225, 220, 290, 220)
        g.DrawArc(penBlack, 275, 195, 25, 25, 0, 90)

        g.DrawArc(penBlack, 220, 150, 25, 25, 180, 90)
        g.DrawLine(penBlack, 230, 150, 290, 150)
        g.DrawArc(penBlack, 275, 150, 25, 25, 270, 90)
        g.DrawArc(penBlack, 220, 150, 25, 25, 90, 90)
        g.DrawLine(penBlack, 230, 175, 290, 175)
        g.DrawArc(penBlack, 275, 150, 25, 25, 0, 90)

        'c
        g.DrawLine(penBlack, 365, 75, 450, 75)
        g.DrawArc(penBlack, 355, 75, 25, 25, 180, 90)
        g.DrawLine(penBlack, 355, 82, 355, 245)
        g.DrawArc(penBlack, 355, 225, 25, 25, 90, 90)
        g.DrawLine(penBlack, 365, 250, 450, 250)
        g.DrawArc(penBlack, 450, 75, 25, 25, 0, 90)
    End Sub

    Private Sub btnDrawText_Click(sender As System.Object, e As System.EventArgs) Handles btnDrawText.Click
        Dim g As Graphics = Me.CreateGraphics
        Dim forte175 As New Font("Forte", 175)
        Me.Refresh()

        g.DrawString("B", forte175, Brushes.Gray, 160, 60)
        g.DrawString("B", forte175, Brushes.Red, 160, 40)

        g.DrawString("C", forte175, Brushes.Gray, 325, 60)
        g.DrawString("C", forte175, Brushes.Red, 325, 40)

        g.DrawString("M", forte175, Brushes.Gray, 465, 60)
        g.DrawString("M", forte175, Brushes.Red, 465, 40)
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        Me.Refresh()
    End Sub

    Private Sub FillPie_Click(sender As System.Object, e As System.EventArgs) Handles FillPie.Click
        Dim g As Graphics = Me.CreateGraphics
        Dim penBlack As New Pen(Color.Black, 4)
        Dim penGray As New Pen(Color.Gray, 4)
        Dim penRed As New Pen(Color.Red, 4)
        Me.Refresh()
        g.FillRectangle(Brushes.LawnGreen, 225, 50, 425, 225)
        g.DrawRectangle(penBlack, 225, 50, 425, 225)
        g.DrawRectangle(penGray, 250, 100, 325, 325)
    End Sub
End Class
