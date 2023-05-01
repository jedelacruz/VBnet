Public Class Form1

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btn1.Click

        Dim num As Integer

        num = tbox1.Text

        If num >= 97 AndAlso num <= 100 Then
            MsgBox("Grade: " & num & " Nice. With Highest Honors")
        ElseIf num >= 95 AndAlso num < 97 Then
            MsgBox("Grade: " & num & " Nice. With High Honors")
        ElseIf num >= 90 AndAlso num < 95 Then
            MsgBox("Grade: " & num & " Nice. With Honors")
        ElseIf num >= 75 AndAlso num < 90 Then
            MsgBox("Grade: " & num & " You Passed")
        ElseIf num >= 0 AndAlso num < 75 Then
            MsgBox("Grade: " & num & " Sorry. You failed")
        Else
            MsgBox("Grade: " & num & " Invalid Grade")
        End If

    End Sub

End Class
