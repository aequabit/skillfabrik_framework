Imports System.Threading
Public Class Login

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Me.AcceptButton = LoginButton

        If NameBox.Text = "ko1N" And PassBox.Text = "headzots" Then
            NameBox.Enabled = False
            PassBox.Enabled = False
            LoginButton.Enabled = False
            CancelButton.Enabled = False
            NameLabel.ForeColor = Color.Gray
            PassLabel.ForeColor = Color.Gray
            Main.Show()
            Me.Close()
        Else
            MessageBox.Show("Incorrect login!", "skillfabrik framework - error    ")
            NameLabel.ForeColor = Color.Black
            PassLabel.ForeColor = Color.Black
        End If
    End Sub
End Class
