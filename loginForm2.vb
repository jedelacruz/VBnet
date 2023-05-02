Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim username As String
        Dim password As String

        Dim userTry As String
        Dim passTry As String

        username = "user"
        password = "1234"

        userTry = TextBox1.Text
        passTry = TextBox2.Text

        If userTry = username AndAlso passTry = password Then
            MsgBox("Login Succesful")
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("Invalid Account lmao")
        End If


    End Sub

End Class
