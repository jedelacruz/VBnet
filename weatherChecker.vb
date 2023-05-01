Public Class Form1

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btn1.Click

        Dim num As Integer

        num = CInt(tbox1.Text)

        Select Case num
            Case Is = 0
                MsgBox("cold")
            Case Is < 0
                MsgBox("freezing")
            Case 1 To 10
                MsgBox("moody")
            Case 11 To 20
                MsgBox("nice")
            Case 21 To 25
                MsgBox("warm")
            Case Else
                MsgBox("hot")
        End Select

    End Sub

End Class
