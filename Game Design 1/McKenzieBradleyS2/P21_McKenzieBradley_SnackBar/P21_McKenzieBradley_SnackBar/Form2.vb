Public Class Form2

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim hotdog As Double = (txtHotDog.Text)
        Dim chips As Double = (txtChips.Text)
        Dim chipscheese As Double = (txtChipsCheese.Text)
        Dim sodas As Double = (lblSodas.Text)
        Dim candy As Double = (txtCandy.Text)
        Dim subtotal As Double
        Dim tax As Double
        Dim total As Double

        lblHotDog.Text = (hotdog * 1.75).ToString
        lblChips.Text = (chips * 1.75).ToString
        lblChipsCheese.Text = (chipscheese * 1.75).ToString
        lblSodas.Text = (sodas * 1.75).ToString
        lblCandy.Text = (candy * 1.75).ToString

        subtotal = (hotdog * 1.75) + (chips * 1.25) + (chipscheese * 1.5) + (sodas * 1.75) + (candy * 1.75)
        tax = subtotal * 0.08
        total = subtotal + tax


        lblSubtotal.Text = subtotal.ToString
        lblTax.Text = tax.ToString
        lblTotal.Text = total.ToString

    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        txtCandy.Text = ""
        txtChips.Text = ""
        txtChipsCheese.Text = ""
        txtFruit.Text = ""
        txtHotDog.Text = ""
        txtSodas.Text = ""

        lblSubtotal.Text = " "
        lblTax.Text = " "
        lblTotal.Text = " "
    End Sub
End Class
