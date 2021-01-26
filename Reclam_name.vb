Public Class Reclam_name
    Private Sub Reclam_name_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        TextBox1.Text = ""
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox1.Text.IndexOf("<") > -1 Or TextBox1.Text.IndexOf(">") > -1 Or TextBox1.Text.IndexOf("/") > -1 Or TextBox1.Text.IndexOf("\") > -1 Or TextBox1.Text.IndexOf(":") > -1 Or TextBox1.Text.IndexOf("?") > -1 Or TextBox1.Text.IndexOf("|") > -1 Or TextBox1.Text.IndexOf("*") > -1 Or TextBox1.Text.IndexOf(My.Resources.Brackets) > -1 Or Main.FileExits(TextBox1.Text) = True Then
            MsgBox("Имя пустое, повторяется или содержит недопустиные символы: <>/:?" & My.Resources.Brackets & "|\*",, "Ошибка")
            Exit Sub
        End If
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class
