Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar1.Value = ProgressBar1.Value + "1"
        'Set 100 to your max ProgressBar value
        If ProgressBar1.Value = "100" Then
            Timer1.Stop()
        End If
    End Sub
End Class
