Public Class Form1
    Dim dir As Integer
    Dim xLoc As Integer
    Dim yLoc As Integer
    Dim penBurlyWood As New Pen(Color.BurlyWood, 15)
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        xLoc = -20
        yLoc = 72
        dir = 1
    End Sub

    Private Sub Reset()
        Dim g As Graphics = Me.CreateGraphics
        g.FillRectangle(Brushes.Lime, 250, 82, 10, 10)
        g.FillRectangle(Brushes.Lime, 50, 82, 10, 10)
        g.FillRectangle(Brushes.Lime, 55, 232, 10, 10)
        g.FillRectangle(Brushes.Lime, 300, 132, 10, 10)
        g.FillRectangle(Brushes.Lime, 250, 232, 10, 10)
        g.FillRectangle(Brushes.Lime, 100, 132, 10, 10)
        g.FillRectangle(Brushes.Lime, 268, 182, 10, 10)
        g.FillRectangle(Brushes.Lime, 122, 182, 10, 10)
        g.FillRectangle(Brushes.Lime, 285, 332, 10, 10)
        g.FillRectangle(Brushes.Lime, 50, 332, 10, 10)
        g.FillRectangle(Brushes.Lime, 285, 282, 10, 10)
        g.FillRectangle(Brushes.Lime, 59, 282, 10, 10)
    End Sub

    Private Sub tmrGo_Tick(sender As System.Object, e As System.EventArgs) Handles tmrGo.Tick
        Dim g As Graphics = Me.CreateGraphics
        g.DrawLine(penBurlyWood, 0, 100, Me.Width - 65, 100)
        g.DrawLine(penBurlyWood, 50, 150, Me.Width - 15, 150)
        g.DrawLine(penBurlyWood, 0, 200, Me.Width - 65, 200)
        g.DrawLine(penBurlyWood, 50, 250, Me.Width - 15, 250)
        g.DrawLine(penBurlyWood, 0, 300, Me.Width - 65, 300)
        g.DrawLine(penBurlyWood, 0, 350, Me.Width - 15, 350)

        g.FillEllipse(Brushes.White, xLoc, yLoc, 20, 20)
        g.DrawEllipse(Pens.White, xLoc, yLoc, 20, 20)

        g.FillEllipse(Brushes.Sienna, xLoc, yLoc, 20, 20)
        g.DrawEllipse(Pens.White, xLoc, yLoc, 20, 20)

        If dir = 1 Then 'right
            xLoc += 1
            If xLoc > Me.Width - 65 Then dir += 1
        ElseIf dir = 2 Then 'down
            yLoc += 1
            If yLoc > 122 Then dir += 1
        ElseIf dir = 3 Then 'left
            xLoc -= 1
            If xLoc < 30 Then dir += 1
        ElseIf dir = 4 Then 'down
            yLoc += 1
            If yLoc > 172 Then dir += 1
        ElseIf dir = 5 Then 'right
            xLoc += 1
            If xLoc > Me.Width - 65 Then dir += 1
        ElseIf dir = 6 Then 'down
            yLoc += 1
            If yLoc > 222 Then dir += 1
        ElseIf dir = 7 Then 'left
            xLoc -= 1
            If xLoc < 30 Then dir += 1
        ElseIf dir = 8 Then 'down
            yLoc += 1
            If yLoc > 272 Then dir += 1
        ElseIf dir = 9 Then 'right
            xLoc += 1
            If xLoc > Me.Width - 65 Then dir += 1
        ElseIf dir = 10 Then 'down
            yLoc += 1
            If yLoc > 322 Then dir += 1
        ElseIf dir = 11 Then 'left
            xLoc -= 1
            If xLoc < -20 Then
                dir = 1
                xLoc = -20
                yLoc = 72
                Reset()
                lblScore.Text += 50
            End If
        End If

    End Sub

    Private Sub PlayToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PlayToolStripMenuItem.Click
        Reset()
        tmrGo.Enabled = True
    End Sub

    Private Sub PauseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PauseToolStripMenuItem.Click
        tmrGo.Enabled = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
