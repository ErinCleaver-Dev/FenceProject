''' <summary>
''' Name:  Erin Cleaver
''' Class:  Visual Basic Programming II CIS225.6306.W22
''' Week:  1/22/2021
''' </summary>

'

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
