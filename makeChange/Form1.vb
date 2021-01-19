Public Class Form1
    Dim sngChange As Single
   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Const CAKE As Single = 35.99
        Dim sngMoney As Single

        sngMoney = Val(txtMoney.Text)

        If (sngMoney = CAKE) Then
            MessageBox.Show("You have exact change")

        ElseIf (sngMoney < CAKE) Then
            MessageBox.Show("You don't have enough")

        ElseIf (sngMoney > CAKE) Then
            sngChange = sngMoney - CAKE
            MessageBox.Show("Change: $" & sngChange)
        End If

        If (sngMoney > CAKE * 2) Then
            MessageBox.Show("You have more than double!")
        End If

    End Sub
End Class
