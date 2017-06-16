Public Class Form1

    Private Sub btnNext_Click(sender As System.Object, e As System.EventArgs) Handles btnNext.Click
        Dim d1 As Integer = Rnd() * 10 + 1
        Dim d2 As Integer = Rnd() * 3 + 1
        Dim d3 As Integer = Rnd() * 10 + 1

        'Slot1'
        If d1 = 0 Then picSlot1.Image = picFace0.Image
        If d1 = 1 Then picSlot1.Image = picFace1.Image
        If d1 = 2 Then picSlot1.Image = picFace2.Image
        If d1 = 3 Then picSlot1.Image = picFace3.Image
        If d1 = 4 Then picSlot1.Image = picFace4.Image
        If d1 = 5 Then picSlot1.Image = picFace5.Image
        If d1 = 6 Then picSlot1.Image = picFace6.Image
        If d1 = 7 Then picSlot1.Image = picFace7.Image
        If d1 = 8 Then picSlot1.Image = picFace8.Image
        If d1 = 9 Then picSlot1.Image = picFace9.Image
        'Slot2'
        If d2 = 1 Then picSlot2.Image = picFaceAddition.Image
        If d2 = 2 Then picSlot2.Image = picFaceDivison.Image
        If d2 = 3 Then picSlot2.Image = picFaceSubtract.Image
        If d2 = 4 Then picSlot2.Image = picFaceMulitcation.Image
        'Slot3'
        If d3 = 0 Then picSlot3.Image = picFace0.Image
        If d3 = 1 Then picSlot3.Image = picFace1.Image
        If d3 = 2 Then picSlot3.Image = picFace2.Image
        If d3 = 3 Then picSlot3.Image = picFace3.Image
        If d3 = 4 Then picSlot3.Image = picFace4.Image
        If d3 = 5 Then picSlot3.Image = picFace5.Image
        If d3 = 6 Then picSlot3.Image = picFace6.Image
        If d3 = 7 Then picSlot3.Image = picFace7.Image
        If d3 = 8 Then picSlot3.Image = picFace8.Image
        If d3 = 9 Then picSlot3.Image = picFace9.Image
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
