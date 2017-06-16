Public Class Form1
    Dim frogs(0 To 4) As PictureBox
    Dim Log(0 To 9) As PictureBox
    Dim turtle(0 To 9)
    Dim cars(0 To 5) As PictureBox
    Dim speed(0 To 5) As Integer
    Dim carImage(0 To 9) As PictureBox
    Dim safe As Boolean = True
    Dim play As Boolean = False

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Randomize()

        frogs(0) = picFrog
        frogs(1) = picUp
        frogs(2) = picLeft
        frogs(3) = picDown
        frogs(4) = picRight

        Log(0) = picLog0
        Log(1) = picLog1
        Log(2) = picLog2
        Log(3) = picLog3
        Log(4) = picLog4
        Log(5) = picLog5
        Log(6) = picLog6
        Log(7) = picLog7
        Log(8) = picLog8
        Log(9) = picLog9

        turtle(0) = picTurtle0
        turtle(1) = picTurtle1
        turtle(2) = picTurtle2
        turtle(3) = picTurtle3
        turtle(4) = picTurtle4
        turtle(5) = picTurtle5
        turtle(6) = picTurtle6
        turtle(7) = picTurtle7
        turtle(8) = picTurtle8
        turtle(9) = picTurtle9

        cars(0) = picCar0
        cars(1) = picCar1
        cars(2) = picCar2
        cars(3) = picCar3
        cars(4) = picCar4
        cars(5) = picCar5

        carImage(0) = picCarImage0
        carImage(1) = picCarImage1
        carImage(2) = picCarImage2
        carImage(3) = picCarImage3
        carImage(4) = picCarImage4
        carImage(5) = picCarImage5
        carImage(6) = picCarImage6
        carImage(7) = picCarImage7
        carImage(8) = picCarImage8
        carImage(9) = picCarImage9

        For i = 0 To 5
            speed(i) = Rnd() * 4 + 1
        Next
    End Sub

    Private Sub Form1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If play = True Then
            If e.KeyValue = 37 Then
                picFrog.Image = picLeft.Image
                picFrog.Left -= 50
            ElseIf e.KeyValue = 38 Then
                picFrog.Image = picUp.Image
                picFrog.Left -= 50
            ElseIf e.KeyValue = 39 Then
                picFrog.Image = picRight.Image
                picFrog.Left += 50
            ElseIf e.KeyValue = 40 Then
                picFrog.Image = picDown.Image
                picFrog.Top += 50
            End If
        End If
        If e.KeyValue = 32 Then
            Reset()
            play = True
            tmrRoad.Enabled = True
            tmrWater.Enabled = True
            lblDisplay.Visible = False
            For i = 0 To 4
                frogs(i).Visible = False
            Next
        End If
        getFrog()
    End Sub

    Public Sub getFrog()
        For i = 0 To 4
            If (picFrog.Bounds.IntersectsWith(frogs(i).Bounds)) Then
                frogs(i).Visible = True
                picFrog.Left = 250
                picFrog.Top = 700
            End If
        Next
    End Sub

    Public Sub hitCar()
        For i = 0 To 5
            If (picFrog.Bounds.IntersectsWith(cars(i).Bounds)) Then
                Reset()
            End If
        Next
    End Sub

    Public Sub Reset()
        picFrog.Left = 360
        picFrog.Top = 635
        picFrog.Image = picUp.Image
        play = False
        tmrRoad.Enabled = False
        tmrWater.Enabled = False
        lblDisplay.Visible = True
    End Sub

    Public Sub getTurtle()
        If picFrog.Top < 235 Then
            safe = False
            For i = 0 To 9
                If (picFrog.Bounds.IntersectsWith(turtle(i).Bounds)) Then
                    picFrog.Left = turtle(i).Left
                    picFrog.Top = turtle(i).Top
                    safe = True
                ElseIf (picFrog.Bounds.IntersectsWith(Log(i).Bounds)) Then
                    picFrog.Left = Log(i).Left
                    picFrog.Top = Log(i).Top
                    safe = True
                End If
            Next
            If safe = False Then Reset()
        End If
    End Sub

    Private Sub tmrRoad_Tick(sender As System.Object, e As System.EventArgs) Handles tmrRoad.Tick
        For i = 0 To 5 Step 2
            cars(i).Left += speed(i) 'move right
            If cars(i).Left = Me.Width Then
                cars(i).Left = -50
                speed(i) = Rnd() * 4 + 1
                getCar(i, "right")
            End If
            cars(i + 1).Left -= speed(i + 1) 'move Left
            If cars(i + 1).Left < -50 Then
                cars(i + 1).Left = Me.Width
                speed(i + 1) = Rnd() * 4 + 1
                getCar(i + 1, "left")
            End If
        Next
        hitCar()

    End Sub
    Public Sub getCar(car As Integer, direction As String)
        If direction = "left" Then
            cars(car).Image = carImage(Int(Rnd() * 5)).Image
        Else
            cars(car).Image = carImage(Int(Rnd() * 5) + 5).Image
        End If
    End Sub

    Private Sub tmrWater_Tick(sender As System.Object, e As System.EventArgs) Handles tmrWater.Tick
        For i = 0 To 4
            turtle(i).Left -= 2
            If turtle(i).Left = -50 Then turtle(i).Left = 550
        Next

        For i = 5 To 9
            turtle(i).Left += 2
            If turtle(i).Left = 500 Then turtle(i).Left = -50
        Next

        For i = 0 To 4
            Log(i).Left -= 1
            If Log(i).Left = 550 Then Log(i).Left = -50
        Next
        For i = 5 To 9
            Log(i).Left -= 1
            If Log(i).Left = -50 Then Log(i).Left = 550
        Next
        If picFrog.Left < 0 Or picFrog.Left > 550 Then
        End If
        getTurtle()
    End Sub
End Class
