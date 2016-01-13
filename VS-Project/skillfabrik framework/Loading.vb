Public Class Loading

    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgTimer.Start()
    End Sub

    Private Sub ProgTimer_Tick(sender As Object, e As EventArgs) Handles ProgTimer.Tick
        ProgBar.Increment(5)

        If ProgBar.Value = 100 Then
            Application.Exit()
        End If
    End Sub
End Class