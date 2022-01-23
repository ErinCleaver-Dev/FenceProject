Public Class Form1
    Private Sub bntCalculate_Click(sender As Object, e As EventArgs) Handles bntCalculate.Click

        Dim rectangle = New Rectangle(txtLength.Text.Trim, txtWidth.Text.Trim)

        Dim totalCost As Double = rectangle.GetPerimeter() * txtCost.Text.Trim

        txtTotalCost.Text = Format(totalCost, "$###,###.00")


    End Sub

    Private Sub bntExit_Click(sender As Object, e As EventArgs) Handles bntExit.Click

        Me.Close()
    End Sub
End Class
