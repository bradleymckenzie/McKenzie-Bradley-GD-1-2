Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles btn17.Click
        lblDisplay1.Text = "Fats, Oils and Sweets Group"
        lblDisplay2.Text = "(Use Sparingly)"
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub lblDisplay2_Click(sender As System.Object, e As System.EventArgs) Handles lblDisplay2.Click
        
    End Sub

    Private Sub btn16_Click(sender As System.Object, e As System.EventArgs) Handles btn16.Click
        lblDisplay1.Text = "Milk, Yogurt, and Cheese Group"
        lblDisplay2.Text = "(2-3 servings)"
    End Sub

    Private Sub btn15_Click(sender As System.Object, e As System.EventArgs) Handles btn15.Click
        lblDisplay1.Text = "Meat, Egg and Nut Group"
        lblDisplay2.Text = "(2-3 servings)"
    End Sub

    Private Sub btn14_Click(sender As System.Object, e As System.EventArgs) Handles btn14.Click
        lblDisplay1.Text = "Vegetable Group"
        lblDisplay2.Text = "(3-5 servings)"
    End Sub

    Private Sub btn13_Click(sender As System.Object, e As System.EventArgs) Handles btn13.Click
        lblDisplay1.Text = "Fruit Group"
        lblDisplay2.Text = "(2-4 servings)"
    End Sub

    Private Sub btn12_Click(sender As System.Object, e As System.EventArgs) Handles btn12.Click
        lblDisplay1.Text = "Bread, Cereal, Rice and Pasta Group"
        lblDisplay2.Text = "(6-11 servings)"
    End Sub
End Class
