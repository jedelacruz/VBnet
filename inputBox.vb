Public Class Form1
  
  Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click

        Dim enterName As String
        enterName = InputBox("Enter your name: ")

        MsgBox("hello " & enterName)

    End Sub

End Class
