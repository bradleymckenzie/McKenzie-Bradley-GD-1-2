Public Class Form1
    Dim g As Graphics
    Dim xSun As Integer
    Dim ySun As Integer
    Dim xMercury As Integer
    Dim yMercury As Integer
    Dim rMercury As Double
    Dim xVenus As Integer
    Dim yVenus As Integer
    Dim rVenus As Double
    Dim xEarth As Integer
    Dim yEarth As Integer
    Dim rEarth As Double
    Dim xMars As Integer
    Dim yMars As Integer
    Dim rMars As Double
    Dim xJupiter As Integer
    Dim yJupiter As Integer
    Dim rJupiter As Double
    Dim xSaturn As Integer
    Dim ySaturn As Integer
    Dim rSaturn As Double
    Dim xUranus As Integer
    Dim yUranus As Integer
    Dim rUranus As Double
    Dim xNeptune As Integer
    Dim yNeptune As Integer
    Dim rNeptune As Double
    Dim xPluto As Integer
    Dim yPluto As Integer
    Dim rPluto As Double
    Private Sub EToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub PauseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PauseToolStripMenuItem.Click
        tmrGo.Enabled = False
    End Sub

    Private Sub PlayToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles PlayToolStripMenuItem.Click
        tmrGo.Enabled = True
    End Sub

    Private Sub FastToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FastToolStripMenuItem.Click
        tmrGo.Interval = 20
    End Sub

    Private Sub SlowToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SlowToolStripMenuItem.Click
        tmrGo.Interval = 100
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        g = Me.CreateGraphics
        xSun = (Me.Width / 2) - 25
        ySun = (Me.Height / 2) - 25
        rMercury = Rnd() * 360
        rVenus = Rnd() * 360
        rEarth = Rnd() * 360
        rMars = Rnd() * 360
        rJupiter = Rnd() * 360
        rSaturn = Rnd() * 360
        rUranus = Rnd() * 360
        rNeptune = Rnd() * 360
        rSaturn = Rnd() * 360
        rPluto = Rnd() * 360
    End Sub

    Private Sub tmrGo_Tick(sender As System.Object, e As System.EventArgs) Handles tmrGo.Tick
        'Blocking out Planet
        g.FillEllipse(Brushes.Black, xMercury, yMercury, 5, 5)
        g.FillEllipse(Brushes.Black, xVenus, yVenus, 7, 7)
        g.FillEllipse(Brushes.Black, xEarth, yEarth, 7, 7)
        g.FillEllipse(Brushes.Black, xMars, yMars, 5, 5)
        g.FillEllipse(Brushes.Black, xJupiter, yJupiter, 12, 12)
        g.FillEllipse(Brushes.Black, xSaturn, ySaturn, 11, 11)
        g.FillEllipse(Brushes.Black, xUranus, yUranus, 10, 10)
        g.FillEllipse(Brushes.Black, xNeptune, yNeptune, 10, 10)
        g.FillEllipse(Brushes.Black, xPluto, yPluto, 5, 5)
        'Calculate New Location of Planet
        rMercury += 0.009
        If rMercury >= 360 Then rMercury = 0
        xMercury = (xSun + 12) + 100 * Math.Sin(rMercury)
        yMercury = (ySun + 10) + 50 * Math.Cos(rMercury)
        rVenus += 0.008
        If rVenus >= 360 Then rVenus = 0
        xVenus = (xSun + 12) + 125 * Math.Sin(rVenus)
        yVenus = (ySun + 10) + 62 * Math.Cos(rVenus)
        rEarth += 0.007
        If rEarth >= 360 Then rEarth = 0
        xEarth = (xSun + 12) + 150 * Math.Sin(rEarth)
        yEarth = (ySun + 10) + 74 * Math.Cos(rEarth)
        rMars += 0.006
        If rMars >= 360 Then rMars = 0
        xMars = (xSun + 12) + 175 * Math.Sin(rMars)
        yMars = (ySun + 10) + 87 * Math.Cos(rMars)
        rJupiter += 0.005
        If rJupiter >= 360 Then rJupiter = 0
        xJupiter = (xSun + 12) + 200 * Math.Sin(rJupiter)
        yJupiter = (ySun + 10) + 100 * Math.Cos(rJupiter)
        rSaturn += 0.004
        If rSaturn >= 360 Then rSaturn = 0
        xSaturn = (xSun + 12) + 225 * Math.Sin(rSaturn)
        ySaturn = (ySun + 10) + 113 * Math.Cos(rSaturn)
        rUranus += 0.003
        If rUranus >= 360 Then rUranus = 0
        xUranus = (xSun + 12) + 250 * Math.Sin(rUranus)
        yUranus = (ySun + 10) + 125 * Math.Cos(rUranus)
        rNeptune += 0.002
        If rNeptune >= 360 Then rNeptune = 0
        xNeptune = (xSun + 12) + 250 * Math.Sin(rNeptune)
        yNeptune = (ySun + 10) + 125 * Math.Cos(rNeptune)
        rPluto += 0.001
        If rPluto >= 360 Then rPluto = 0
        xPluto = (xSun + 12) + 275 * Math.Sin(rPluto)
        yPluto = (ySun + 10) + 137 * Math.Cos(rPluto)
        'Draw New Planet
        g.FillEllipse(Brushes.Yellow, xSun, ySun, 25, 25)
        g.FillEllipse(Brushes.Orange, xMercury, yMercury, 5, 5)
        g.FillEllipse(Brushes.Coral, xVenus, yVenus, 7, 7)
        g.FillEllipse(Brushes.Blue, xEarth, yEarth, 7, 7)
        g.FillEllipse(Brushes.Red, xMars, yMars, 5, 5)
        g.FillEllipse(Brushes.NavajoWhite, xJupiter, yJupiter, 12, 12)
        g.FillEllipse(Brushes.SandyBrown, xSaturn, ySaturn, 11, 11)
        g.FillEllipse(Brushes.SkyBlue, xUranus, yUranus, 10, 10)
        g.FillEllipse(Brushes.DodgerBlue, xNeptune, yNeptune, 10, 10)
        g.FillEllipse(Brushes.DarkGray, xPluto, yPluto, 5, 5)
    End Sub
End Class
