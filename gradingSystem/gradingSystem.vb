Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim subj1 As Integer
        Dim subj2 As Integer
        Dim subj3 As Integer
        Dim subj4 As Integer
        Dim subj5 As Integer
        Dim subj6 As Integer
        Dim ave As Decimal
        Dim rank As String

        subj1 = TextBox1.Text
        subj2 = TextBox2.Text
        subj3 = TextBox3.Text
        subj4 = TextBox4.Text
        subj5 = TextBox5.Text
        subj6 = TextBox6.Text

        ave = (subj1 + subj2 + subj3 + subj4 + subj5 + subj6) / 6

        If ave >= 97 AndAlso ave <= 100 Then
            rank = "With Highest Honors"
        ElseIf ave >= 95 AndAlso ave < 96 Then
            rank = "With High Honors"
        ElseIf ave >= 90 AndAlso ave < 95 Then
            rank = "With Honors"
        ElseIf ave >= 75 AndAlso ave < 90 Then
            rank = "Passed"
        ElseIf ave > 0 AndAlso ave < 74 Then
            rank = "Failed"
        Else
            rank = "Invalid"
        End If

        MsgBox("Average: " & ave & vbNewLine & "Rank: " & rank)


    End Sub

End Class
