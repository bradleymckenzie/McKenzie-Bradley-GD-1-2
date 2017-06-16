Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Tetris_Click(sender As System.Object, e As System.EventArgs) Handles Tetris.Click
        Dim g As Graphics = Me.CreateGraphics
        Dim penBlack As New Pen(Color.Black, 4)
        Me.Refresh()

        'pink
        g.FillRectangle(Brushes.DeepPink, 100, 50, 100, 100)
        g.DrawRectangle(penBlack, 100, 50, 50, 50)
        g.DrawRectangle(penBlack, 150, 50, 50, 50)
        g.DrawRectangle(penBlack, 100, 100, 50, 50)
        g.DrawRectangle(penBlack, 150, 100, 50, 50)

        'Orange
        g.FillRectangle(Brushes.DarkOrange, 300, 100, 100, 50)
        g.DrawRectangle(penBlack, 300, 100, 50, 50)
        g.DrawRectangle(penBlack, 350, 100, 50, 50)
        g.FillRectangle(Brushes.DarkOrange, 350, 50, 100, 50)
        g.DrawRectangle(penBlack, 400, 50, 50, 50)
        g.DrawRectangle(penBlack, 350, 50, 50, 50)

        'Blue
        g.FillRectangle(Brushes.Blue, 700, 50, 50, 100)
        g.FillRectangle(Brushes.Blue, 650, 50, 150, 50)
        g.DrawRectangle(penBlack, 650, 50, 50, 50)
        g.DrawRectangle(penBlack, 700, 50, 50, 50)
        g.DrawRectangle(penBlack, 750, 50, 50, 50)
        g.DrawRectangle(penBlack, 700, 100, 50, 50)
        'Green
        g.FillRectangle(Brushes.Green, 300, 250, 50, 50)
        g.FillRectangle(Brushes.Green, 300, 300, 150, 50)
        g.DrawRectangle(penBlack, 300, 250, 50, 50)
        g.DrawRectangle(penBlack, 300, 300, 50, 50)
        g.DrawRectangle(penBlack, 350, 300, 50, 50)
        g.DrawRectangle(penBlack, 400, 300, 50, 50)

        'Gray
        g.FillRectangle(Brushes.Gray, 50, 200, 100, 50)
        g.FillRectangle(Brushes.Gray, 100, 250, 100, 50)
        g.DrawRectangle(penBlack, 50, 200, 50, 50)
        g.DrawRectangle(penBlack, 100, 200, 50, 50)
        g.DrawRectangle(penBlack, 100, 250, 50, 50)
        g.DrawRectangle(penBlack, 150, 250, 50, 50)

        'Yellow
        g.FillRectangle(Brushes.Yellow, 550, 150, 50, 200)
        g.DrawRectangle(penBlack, 550, 150, 50, 50)
        g.DrawRectangle(penBlack, 550, 200, 50, 50)
        g.DrawRectangle(penBlack, 550, 250, 50, 50)
        g.DrawRectangle(penBlack, 550, 300, 50, 50)

        'Red
        g.FillRectangle(Brushes.Red, 750, 250, 50, 50)
        g.FillRectangle(Brushes.Red, 650, 300, 150, 50)
        g.DrawRectangle(penBlack, 750, 250, 50, 50)
        g.DrawRectangle(penBlack, 650, 300, 50, 50)
        g.DrawRectangle(penBlack, 700, 300, 50, 50)
        g.DrawRectangle(penBlack, 750, 300, 50, 50)
    End Sub

    Private Sub Dominos_Click(sender As System.Object, e As System.EventArgs) Handles Dominos.Click
        Dim g As Graphics = Me.CreateGraphics
        Dim penBlack As New Pen(Color.Black, 4)
        Me.Refresh()

        g.DrawRectangle(penBlack, 50, 175, 175, 175)
        g.DrawRectangle(penBlack, 225, 175, 175, 175)

        g.FillEllipse(Brushes.Gray, 75, 200, 25, 25)
        g.FillEllipse(Brushes.Gray, 125, 250, 25, 25)
        g.FillEllipse(Brushes.Gray, 175, 300, 25, 25)
        g.DrawEllipse(penBlack, 75, 200, 25, 25)
        g.DrawEllipse(penBlack, 125, 250, 25, 25)
        g.DrawEllipse(penBlack, 175, 300, 25, 25)

        g.FillEllipse(Brushes.Gray, 250, 200, 25, 25)
        g.FillEllipse(Brushes.Gray, 350, 200, 25, 25)
        g.FillEllipse(Brushes.Gray, 250, 300, 25, 25)
        g.FillEllipse(Brushes.Gray, 350, 300, 25, 25)
        g.FillEllipse(Brushes.Gray, 300, 250, 25, 25)
        g.DrawEllipse(penBlack, 250, 200, 25, 25)
        g.DrawEllipse(penBlack, 350, 200, 25, 25)
        g.DrawEllipse(penBlack, 250, 300, 25, 25)
        g.DrawEllipse(penBlack, 350, 300, 25, 25)
        g.DrawEllipse(penBlack, 300, 250, 25, 25)

        '
        g.DrawRectangle(penBlack, 450, 50, 175, 175)
        g.DrawRectangle(penBlack, 625, 50, 175, 175)

        g.FillEllipse(Brushes.Gray, 475, 75, 25, 25)
        g.FillEllipse(Brushes.Gray, 575, 75, 25, 25)
        g.FillEllipse(Brushes.Gray, 475, 175, 25, 25)
        g.FillEllipse(Brushes.Gray, 475, 175, 25, 25)
        g.FillEllipse(Brushes.Gray, 575, 175, 25, 25)
        g.DrawEllipse(penBlack, 475, 75, 25, 25)
        g.DrawEllipse(penBlack, 575, 75, 25, 25)
        g.DrawEllipse(penBlack, 475, 175, 25, 25)
        g.DrawEllipse(penBlack, 575, 175, 25, 25)

        g.FillEllipse(Brushes.Gray, 650, 75, 25, 25)
        g.FillEllipse(Brushes.Gray, 700, 75, 25, 25)
        g.FillEllipse(Brushes.Gray, 750, 75, 25, 25)
        g.FillEllipse(Brushes.Gray, 650, 175, 25, 25)
        g.FillEllipse(Brushes.Gray, 750, 175, 25, 25)
        g.FillEllipse(Brushes.Gray, 700, 175, 25, 25)
        g.DrawEllipse(penBlack, 650, 75, 25, 25)
        g.DrawEllipse(penBlack, 575, 75, 25, 25)
        g.DrawEllipse(penBlack, 700, 75, 25, 25)
        g.DrawEllipse(penBlack, 750, 75, 25, 25)
        g.DrawEllipse(penBlack, 650, 175, 25, 25)
        g.DrawEllipse(penBlack, 750, 175, 25, 25)
        g.DrawEllipse(penBlack, 700, 175, 25, 25)
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Refresh()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub
End Class
