Public Class Form1

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btn1.Click

        Dim num As Integer

        num = tbox1.Text

        If num > 100 Then
            MsgBox("old ass hag")
        ElseIf num >= 60 AndAlso num <= 100 Then
            MsgBox("senior bitch")
        ElseIf num >= 30 AndAlso num < 60 Then
            MsgBox("middle age fuck")
        ElseIf num >= 20 AndAlso num < 30 Then
            MsgBox("u a thot bitch mf")
        ElseIf num > 0 AndAlso num < 20 Then
            MsgBox("u a brat")
        Else
            MsgBox("bitch what are u")
        End If

    End Sub

End Class
