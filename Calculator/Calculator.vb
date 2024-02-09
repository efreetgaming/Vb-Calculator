Public Class Calculator
    ' Wont let the user type any letters
    Private Sub txtScreen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtScreen.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not e.KeyChar = "-" Then
            e.Handled = True
        End If
    End Sub

    ' NumPad
    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        If txtScreen.Text = "" Then
        Else
            txtScreen.AppendText(0)
        End If
    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        txtScreen.AppendText(1)
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        txtScreen.AppendText(2)
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        txtScreen.AppendText(3)
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        txtScreen.AppendText(4)
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        txtScreen.AppendText(5)
    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        txtScreen.AppendText(6)
    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        txtScreen.AppendText(7)
    End Sub

    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        txtScreen.AppendText(8)
    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        txtScreen.AppendText(9)
    End Sub

    ' Mathematical Operation
    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        lblNumOne.Text = txtScreen.Text
        lblOperator.Text = "+"
        txtScreen.Clear()
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        lblNumOne.Text = txtScreen.Text
        lblOperator.Text = "-"
        txtScreen.Clear()
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        lblNumOne.Text = txtScreen.Text
        lblOperator.Text = "*"
        txtScreen.Clear()
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        lblNumOne.Text = txtScreen.Text
        lblOperator.Text = "/"
        txtScreen.Clear()
    End Sub

    ' CE Button
    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        txtScreen.Clear()
        lblNumOne.Text = ""
        lblNumTwo.Text = ""
        lblOperator.Text = ""
    End Sub

    ' Clear ( C ) button
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtScreen.Clear()
    End Sub

    ' Backspace 
    Private Sub btnBackSpace_Click(sender As Object, e As EventArgs) Handles btnBackSpace.Click
        If txtScreen.Text.Length > 0 Then
            txtScreen.Text = txtScreen.Text.Remove(txtScreen.Text.Length - 1, 1)
        End If
    End Sub


    ' Equal
    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        lblNumTwo.Text = txtScreen.Text
        Dim sign As Char = lblOperator.Text
        Dim numOne As Double = Convert.ToDouble(lblNumOne.Text)
        Dim numTwo As Double = Convert.ToDouble(lblNumTwo.Text)
        Dim result As Double

        Select Case (sign)
            Case "+"
                result = numOne + numTwo
            Case "-"
                result = numOne - numTwo
            Case "*"
                result = numOne * numTwo
            Case "/"
                result = numOne / numTwo
        End Select

        txtScreen.Text = Convert.ToString(result)
    End Sub

    ' Decimal point wont let you input another point if you have already
    Private Sub btnPoint_Click(sender As Object, e As EventArgs) Handles btnPoint.Click
        If Not txtScreen.Text.Contains(".") Then
            txtScreen.Text += "."
        End If
    End Sub
End Class
