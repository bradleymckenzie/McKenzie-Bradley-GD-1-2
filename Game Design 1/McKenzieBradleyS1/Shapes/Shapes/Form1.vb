Public Class Form1
    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        Me.Refresh()
    End Sub

    Private Sub Shape1_Click(sender As System.Object, e As System.EventArgs) Handles btnShape1.Click
        Dim g As Graphics = Me.CreateGraphics
        Dim penBlack As New Pen(Color.Black, 4)
        Me.Refresh()


        g.DrawLine(penBlack, 300, 50, 350, 50)
        g.DrawLine(penBlack, 250, 100, 250, 150)
        g.DrawLine(penBlack, 300, 200, 350, 200)
        g.DrawLine(penBlack, 400, 100, 400, 150)

        g.DrawArc(penBlack, 200, 0, 100, 100, 0, 90)
        g.DrawArc(penBlack, 350, 0, 100, 100, 90, 90)
        g.DrawArc(penBlack, 200, 150, 100, 100, 270, 90)
        g.DrawArc(penBlack, 350, 150, 100, 100, 180, 90)
    End Sub


    Private Sub Shade2_Click(sender As System.Object, e As System.EventArgs) Handles btnShape2.Click
        Dim g As Graphics = Me.CreateGraphics
        Dim penBlack As New Pen(Color.Black, 4)
        Me.Refresh()

        g.DrawArc(penBlack, 450, 50, 50, 50, 180, 90)
        g.DrawLine(penBlack, 450, 75, 450, 100)
        g.DrawLine(penBlack, 475, 50, 500, 50)
        g.DrawArc(penBlack, 425, 100, 50, 50, 270, 180)
        g.DrawArc(penBlack, 500, 25, 50, 50, 0, 180)

        g.DrawArc(penBlack, 550, 50, 50, 50, 270, 90)
        g.DrawLine(penBlack, 550, 50, 580, 50)
        g.DrawLine(penBlack, 600, 75, 600, 100)
        g.DrawArc(penBlack, 575, 100, 50, 50, 90, 180)

        g.DrawArc(penBlack, 450, 150, 50, 50, 90, 90)
        g.DrawLine(penBlack, 450, 150, 450, 175)
        g.DrawLine(penBlack, 475, 200, 500, 200)
        g.DrawArc(penBlack, 500, 175, 50, 50, 180, 180)
        g.DrawArc(penBlack, 550, 150, 50, 50, 0, 90)
        g.DrawLine(penBlack, 600, 150, 600, 175)
        g.DrawLine(penBlack, 575, 200, 550, 200)

    End Sub

    Private Sub btnShape3_Click(sender As System.Object, e As System.EventArgs) Handles btnShape3.Click
        Dim g As Graphics = Me.CreateGraphics
        Dim penBlack As New Pen(Color.Black, 4)
        Me.Refresh()

        g.DrawArc(penBlack, 650, 50, 50, 50, 90, 270)
        g.DrawLine(penBlack, 700, 75, 725, 100)
        g.DrawLine(penBlack, 725, 100, 750, 75)
        g.DrawLine(penBlack, 675, 100, 700, 125)
        g.DrawLine(penBlack, 775, 100, 750, 125)
        g.DrawArc(penBlack, 750, 50, 50, 50, 180, 270)

    End Sub
End Class
