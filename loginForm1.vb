Public Class Form1
  
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btn1.Click

        Dim name As String
        Dim pw As String

        name = tbox1.Text
        pw = tbox2.Text

        If name = "user" AndAlso pw = "12345" Then
            MsgBox("Hello " & name)
        Else
            MsgBox("invalid account")
        End If

    End Sub

End Class
