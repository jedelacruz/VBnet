Public Class Form1
  
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btn1.Click

        Dim favSubj As String
    
        favSubj = lbox1.SelectedItem

        MsgBox("Hello u love " & favSubj)

    End Sub

End Class
