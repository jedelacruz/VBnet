Public Class Form1
  
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    
        Panel2.Width += 3
        If Panel2.Width >= 800 Then
            Timer1.Stop()
            Form2.Show()
            Me.Hide()
        End If

    End Sub
End Class
