Public Class Form1
    Dim g As Graphics
    Dim xSun As Integer
    Dim ySun As Integer

    Dim xEarth As Integer
    Dim yEarth As Integer
    Dim rEarth As Double

    Dim xMoon As Integer
    Dim yMoon As Integer
    Dim rMoon As Double

    Private Sub PlayToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PlayToolStripMenuItem.Click
        tmrGo.Enabled = True
    End Sub
    Private Sub PauseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PauseToolStripMenuItem.Click
        tmrGo.Enabled = False
    End Sub

    Private Sub EToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub FastToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FastToolStripMenuItem.Click
        tmrGo.Interval = 20
    End Sub

    Private Sub SlowToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SlowToolStripMenuItem.Click
        tmrGo.Interval = 100
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        g = Me.CreateGraphics
        xSun = (Me.Width / 2) - 50
        ySun = (Me.Height / 2) - 75
        rEarth = Rnd() * 360
        rMoon = Rnd() * 360
    End Sub

    Private Sub tmrGo_Tick(sender As System.Object, e As System.EventArgs) Handles tmrGo.Tick
        'Blocking Out Planet
        g.FillEllipse(Brushes.Black, xEarth, yEarth, 25, 25)
        g.FillEllipse(Brushes.Black, xMoon, yMoon, 10, 10)

        'Calculate New Location of Planet
        rEarth += 0.009
        If rEarth >= 360 Then rEarth = 0
        xEarth = (xSun + 12) + 250 * Math.Sin(rEarth)
        yEarth = (ySun + 10) + 125 * Math.Cos(rEarth)

        rMoon += 0.025
        If rMoon >= 360 Then rMoon = 0
        xMoon = (xEarth + 12) + 50 * Math.Sin(rMoon)
        yMoon = (yEarth + 10) + 25 * Math.Cos(rMoon)
        'Draw New Planet
        g.FillEllipse(Brushes.Yellow, xSun, ySun, 100, 100)
        g.FillEllipse(Brushes.Blue, xEarth, yEarth, 25, 25)
        g.FillEllipse(Brushes.DarkGray, xMoon, yMoon, 10, 10)
    End Sub


End Class
