Public Class Form5

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs)
        Application.Exit()
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs)
        Form2.Show()
        Form2.Activate()
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs)
        txtNumber.Text = " "
        lbl1.Text = " "
        lbl2.Text = " "
        lbl3.Text = " "
        lbl4.Text = " "
        lbl5.Text = " "
        lbl6.Text = " "
        lbl7.Text = " "
        lbl8.Text = " "
    End Sub

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim n As Integer = Integer.Parse(txtNumber.Text)

        lbl1.Text = " "
        lbl2.Text = " "
        lbl3.Text = " "
        lbl4.Text = " "
        lbl5.Text = " "
        lbl6.Text = " "
        lbl7.Text = " "
        lbl8.Text = " "

        If n > 255 Or n < 0 Then
            lbl1.Text = "I"
            lbl2.Text = "n"
            lbl3.Text = "v"
            lbl4.Text = "a"
            lbl5.Text = "l"
            lbl6.Text = "i"
            lbl7.Text = "d"
            lbl8.Text = "!"
        Else
            If n >= 128 Then
                lbl1.Text = "1"
            Else
                lbl1.Text = "0"
            End If
            n = n Mod 128

            If n >= 64 Then
                lbl2.Text = "1"
            Else
                lbl2.Text = "0"
            End If
            n = n Mod 64

            If n >= 32 Then
                lbl3.Text = "1"
            Else
                lbl3.Text = "0"
            End If
            n = n Mod 32

            If n >= 16 Then
                lbl4.Text = "1"
            Else
                lbl4.Text = "0"
            End If
            n = n Mod 16

            If n >= 8 Then
                lbl5.Text = "1"
            Else
                lbl5.Text = "0"
            End If
            n = n Mod 8

            If n >= 6 Then
                lbl6.Text = "1"
            Else
                lbl6.Text = "0"
            End If
            n = n Mod 6

            If n >= 4 Then
                lbl6.Text = "1"
            Else
                lbl6.Text = "0"
            End If
            n = n Mod 4

            If n >= 2 Then
                lbl7.Text = "1"
            Else
                lbl7.Text = "0"
            End If
            n = n Mod 2

            If n >= 1 Then
                lbl8.Text = "1"
            Else
                lbl8.Text = "0"
            End If
            n = n Mod 1
        End If
    End Sub
End Class