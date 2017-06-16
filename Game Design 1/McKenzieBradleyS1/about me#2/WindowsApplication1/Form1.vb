Public Class Form1

    Private Sub lblDisplay_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btnActor_Click(sender As System.Object, e As System.EventArgs) Handles btnActor.Click
        lblDisplay.Text = "Adam Sander"
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles lblDisplay.Click
    End Sub

    Private Sub btnAnimal_Click(sender As System.Object, e As System.EventArgs) Handles btnAnimal.Click
        lblDisplay.Text = "Hawk"
    End Sub

    Private Sub btnBand_Click(sender As System.Object, e As System.EventArgs) Handles btnBand.Click
        lblDisplay.Text = "Linkin Park"
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles btnColor.Click
        lblDisplay.Text = "Red"
    End Sub

    Private Sub btnFood_Click(sender As System.Object, e As System.EventArgs) Handles btnFood.Click
        lblDisplay.Text = "Pizza"
    End Sub

    Private Sub btnHobbie_Click(sender As System.Object, e As System.EventArgs) Handles btnHobbie.Click
        lblDisplay.Text = "Playing Video Games"
    End Sub

    Private Sub btnSport_Click(sender As System.Object, e As System.EventArgs) Handles btnSport.Click
        lblDisplay.Text = "Football"
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles btnState.Click
        lblDisplay.Text = "California"
    End Sub

    Private Sub btnStore_Click(sender As System.Object, e As System.EventArgs) Handles btnStore.Click
        lblDisplay.Text = "Game Stop"
    End Sub

    Private Sub btnCareer_Click(sender As System.Object, e As System.EventArgs) Handles btnCareer.Click
        lblDisplay.Text = "Army Ranger"
    End Sub


End Class
