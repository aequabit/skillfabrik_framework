Public Class Main
    Dim selectedApp As String
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConBox.Text = "Connecting to server... ok" + Environment.NewLine + "Sending login information... ok" + Environment.NewLine


        If AppBox.Items.Count > 0 Then
            AppBox.Items(0).Selected = True
            AppBox.Select()
        End If
    End Sub

    Private Sub AppBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AppBox.SelectedIndexChanged
        If AppBox.SelectedItems.Count > 0 Then
            selectedApp = AppBox.SelectedItems(0).Text
        End If
    End Sub

    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles LoadButton.Click
        LoadButton.Enabled = False
        CloseButton.Enabled = False
        AppBox.Enabled = False
        Loading.Show()
        If selectedApp = "headzots v4" Then
            ConBox.Text = ConBox.Text + "Starting HEADZOTS... ok" + Environment.NewLine + "loading application... ok" + Environment.NewLine + "waiting for game... ok" + Environment.NewLine + "initializing engine... ok" + Environment.NewLine
        Else
            ConBox.Text = ConBox.Text + "Starting " + selectedApp + "... ok" + Environment.NewLine + "loading application... ok" + Environment.NewLine + "waiting for game... ok" + Environment.NewLine + "initializing engine... ok" + Environment.NewLine
        End If
    End Sub

    Private Sub UnloadButton_Click(sender As Object, e As EventArgs) Handles UnloadButton.Click
        LoadButton.Enabled = True
        UnloadButton.Enabled = False
    End Sub
End Class