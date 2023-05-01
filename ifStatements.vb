Public Class Form1

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btn1.Click

        Dim num As Integer

        num = tbox1.Text

        If num >= 60 Then
            MsgBox("senior citizen")
        ElseIf num >= 18 Then
            MsgBox("adult")
        ElseIf num > 0 Then
            MsgBox("minor")
        Else
            MsgBox("invalid age")
        End If

    End Sub

End Class
