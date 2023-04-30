Public Class Form1
  
   Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click

        Dim name As String
        Dim age As Integer
        Dim minor As Boolean
        Dim grade As Decimal
        Dim bday As Date

        name = "Je Dela Cruz"
        age = 16
        minor = True
        grade = 95.5
        bday = #10/21/2006#

        MsgBox("Hello I am " & name & " " & "I am " & age & " years old.")

    End Sub

End Class
