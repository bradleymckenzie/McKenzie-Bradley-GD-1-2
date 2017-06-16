Public Class Form1
    Dim r As Integer = 25
    Dim image As Integer = 1
    Dim myBrush = New SolidBrush(Color.Red)

    Private Sub Form1_Click(sender As System.Object, e As System.EventArgs) Handles MyBase.Click
        Dim g As Graphics = Me.CreateGraphics
        Dim x As Integer = Cursor.Position.X - (Me.Left + (8 + (r / 2)))
        Dim wingdings As New Font("wingdings", 32)
        Dim y As Integer = Cursor.Position.Y - (Me.Top + (28 + (r / 2)))

        If image = 1 Then 'dot
            g.FillEllipse(myBrush, x, y, r, r)
        ElseIf image = 2 Then 'diamond
            g.DrawString("t", wingdings, myBrush, x - 12, y - 12)
        ElseIf image = 3 Then 'sciccor
            g.DrawString("#", wingdings, myBrush, x - 12, y - 12)
        ElseIf image = 4 Then 'Phone
            g.DrawString("Q", wingdings, myBrush, x - 12, y - 12)
        ElseIf image = 5 Then 'Plane
            g.DrawString("(", wingdings, myBrush, x - 12, y - 12)
        ElseIf image = 6 Then 'Peace
            g.DrawString("A", wingdings, myBrush, x - 12, y - 12)
        ElseIf image = 7 Then 'Pencil
            g.DrawString("!", wingdings, myBrush, x - 12, y - 12)
        ElseIf image = 8 Then 'Cross
            g.DrawString("X", wingdings, myBrush, x - 12, y - 12)
        End If
    End Sub
    Private Sub btnRed_Click(sender As System.Object, e As System.EventArgs) Handles btnRed.Click
        Dim b = New SolidBrush(Color.Red)
        myBrush = b
    End Sub

    Private Sub btnOrange_Click(sender As System.Object, e As System.EventArgs) Handles btnOrange.Click
        Dim b = New SolidBrush(Color.Orange)
        myBrush = b
    End Sub

    Private Sub btnYellow_Click(sender As System.Object, e As System.EventArgs) Handles btnYellow.Click
        Dim b = New SolidBrush(Color.Yellow)
        myBrush = b
    End Sub

    Private Sub btnGreen_Click(sender As System.Object, e As System.EventArgs) Handles btnGreen.Click
        Dim b = New SolidBrush(Color.Green)
        myBrush = b
    End Sub

    Private Sub btnBlue_Click(sender As System.Object, e As System.EventArgs) Handles btnBlue.Click
        Dim b = New SolidBrush(Color.Blue)
        myBrush = b
    End Sub

    Private Sub btnPurple_Click(sender As System.Object, e As System.EventArgs) Handles btnPurple.Click
        Dim b = New SolidBrush(Color.Purple)
        myBrush = b
    End Sub

    Private Sub btnWhite_Click(sender As System.Object, e As System.EventArgs) Handles btnWhite.Click
        Dim b = New SolidBrush(Color.White)
        myBrush = b
    End Sub

    Private Sub btnBlack_Click(sender As System.Object, e As System.EventArgs) Handles btnBlack.Click
        Dim b = New SolidBrush(Color.Black)
        myBrush = b
    End Sub

    Private Sub btnImage1_Click(sender As System.Object, e As System.EventArgs) Handles btnImage1.Click
        image = 1
    End Sub

    Private Sub btnImage2_Click(sender As System.Object, e As System.EventArgs) Handles btnImage2.Click
        image = 2
    End Sub

    Private Sub btnImage3_Click(sender As System.Object, e As System.EventArgs) Handles btnImage3.Click
        image = 3
    End Sub

    Private Sub btnImage4_Click(sender As System.Object, e As System.EventArgs) Handles btnImage4.Click
        image = 4
    End Sub

    Private Sub btnImage5_Click(sender As System.Object, e As System.EventArgs) Handles btnImage5.Click
        image = 5
    End Sub

    Private Sub btnImage6_Click(sender As System.Object, e As System.EventArgs) Handles btnImage6.Click
        image = 6
    End Sub

    Private Sub btnImage7_Click(sender As System.Object, e As System.EventArgs) Handles btnImage7.Click
        image = 7
    End Sub

    Private Sub btnImage8_Click(sender As System.Object, e As System.EventArgs) Handles btnImage8.Click
        image = 8
    End Sub
End Class
