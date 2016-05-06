Public Class aboutForm
    Private Sub websiteLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles websiteLinkLabel.LinkClicked
        If MessageBox.Show("This link openes https://brennced.github.io/ in your default browser. Continue?", "Open link", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Process.Start("https://brennced.github.io/")
        End If
    End Sub
End Class