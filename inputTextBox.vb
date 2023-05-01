Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btn1.Click

        Dim firstName As String
        Dim lastName As String

        firstName = txt1.Text
        lastName = txt2.Text

        MsgBox("Hello " & firstName & " " & lastName)

    End Sub

End Class
