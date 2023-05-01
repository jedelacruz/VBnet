Public Class Form1

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btn1.Click

        Dim text As String
        Dim ch As String

        text = tbox1.Text
        ch = lbox1.Text

        If ch = "Uppercase" Then
            MsgBox(text.ToUpper)
        ElseIf ch = "Lowercase" Then
            MsgBox(text.ToLower)
        End If

    End Sub

End Class
