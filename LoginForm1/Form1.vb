Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim tvlDepUsername As String
        Dim tvlDepPassword As String

        tvlDepUsername = "tvluser"
        tvlDepPassword = "12345"

        Dim acadsDepUsername As String
        Dim acadsDepPassword As String

        acadsDepUsername = "acaduser"
        acadsDepPassword = "54321"


        Dim Username As String
        Dim Password As String

        Username = TextBox1.Text
        Password = TextBox2.Text

        If Username = tvlDepUsername AndAlso Password = tvlDepPassword Or Username = acadsDepUsername AndAlso Password = acadsDepPassword Then
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("Invalid Account")
        End If

    End Sub

End Class
