Public Class Form1

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btn1.Click

        Dim num1 As Integer
        Dim num2 As Integer
        Dim op As String
        Dim result As Integer

        num1 = tbox1.Text
        num2 = tbox2.Text
        op = lbox1.Text

        If op = "Addition" Then
            result = num1 + num2
            MsgBox(result)
        ElseIf op = "Subtraction" Then
            result = num1 - num2
            MsgBox(result)
        ElseIf op = "Multiplication" Then
            result = num1 * num2
            MsgBox(result)
        ElseIf op = "Division" Then
            result = num1 / num2
            MsgBox(result)
        End If

    End Sub

End Class
