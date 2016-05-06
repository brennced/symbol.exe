Public Class mainForm
    Private Sub unicodeInput_TextChanged(sender As Object, e As EventArgs) Handles unicodeInput.TextChanged
        Try
            characterPreview.Text = ChrW(Integer.Parse(unicodeInput.Text, Globalization.NumberStyles.HexNumber))
            characterPreview.BackColor = Color.FromArgb(255, 170, 255, 170)
        Catch ex As Exception
            characterPreview.Text = ""
            characterPreview.BackColor = Color.FromArgb(255, 255, 170, 170)
        End Try
    End Sub

    Private Sub copyButton_Click(sender As Object, e As EventArgs) Handles copyButton.Click
        Try
            My.Computer.Clipboard.SetText(ChrW(Integer.Parse(unicodeInput.Text, Globalization.NumberStyles.HexNumber)))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub aboutButton_Click(sender As Object, e As EventArgs) Handles aboutButton.Click
        aboutForm.ShowDialog()
    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Location = Cursor.Position
        If Left > (My.Computer.Screen.WorkingArea.Width - Width) Then
            Left = My.Computer.Screen.WorkingArea.Width - Width
        End If
        If Top > (My.Computer.Screen.WorkingArea.Height - Height) Then
            Top = My.Computer.Screen.WorkingArea.Height - Height
        End If
    End Sub
End Class
