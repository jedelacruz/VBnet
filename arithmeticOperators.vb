Public Class Form1
    
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btn1.Click

        Dim num1 As Integer
        Dim num2 As Integer
        Dim result As Integer

        num1 = tbox1.Text
        num2 = tbox2.Text

        result = num1 + num2
        MsgBox("Addition: " & result)

        result = num1 - num2
        MsgBox("Subtraction: " & result)

        result = num1 * num2
        MsgBox("Multiplication: " & result)

        result = num1 / num2
        MsgBox("Division: " & result)

        result = num1 ^ num2
        MsgBox("Exponent: " & result)

        result = num1 Mod num2
        MsgBox("Modulo: " & result)

        result = num1 \ num2
        MsgBox("Ignore R Division: " & result)

    End Sub

End Class
