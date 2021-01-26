Public Class SetReclam
    Dim selected_reclam As String = "", img As New Bitmap(10, 10, Imaging.PixelFormat.Format16bppRgb555)
    Private Sub SetReclam_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(Main.GetFiles())
        selected_reclam = ""
        For i1 As Short = 0 To 9
            For i2 As Short = 0 To 9
                img.SetPixel(i1, i2, Color.Gray)
            Next
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult = OpenFile1.ShowDialog
        If result = DialogResult.OK Then
            TextBox3.Text = OpenFile1.FileName
            PictureBox1.ImageLocation = TextBox3.Text
        End If
    End Sub
    Private Sub ОбновитьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОбновитьToolStripMenuItem.Click
        If TextBox3.Text = "" Then
            PictureBox1.Image = img
        Else
            PictureBox1.ImageLocation = TextBox3.Text
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            NumericUpDown2.Enabled = True
        Else
            NumericUpDown2.Enabled = False
        End If
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        selected_reclam = ListBox1.SelectedItem
        If Main.FileExits(selected_reclam) Then
            Dim time_dat As Reclama_dat = Main.GetFile(selected_reclam)
            TextBox2.Text = time_dat.title
            TextBox3.Text = time_dat.picture_way
            TextBox1.Lines = time_dat.info
            NumericUpDown1.Value = time_dat.time
            If time_dat.povtor = 0 Then
                CheckBox1.Checked = False
                NumericUpDown2.Enabled = False
                NumericUpDown2.Value = 10
            Else
                CheckBox1.Checked = True
                NumericUpDown2.Enabled = True
                NumericUpDown2.Value = time_dat.povtor
            End If
            PictureBox1.ImageLocation = TextBox3.Text
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Main.FileExits(selected_reclam) = False Then
            Dim result As DialogResult = Reclam_name.ShowDialog
            If result = DialogResult.OK Then
                If CheckBox1.Checked Then
                    Main.WriteFile(Reclam_name.TextBox1.Text, TextBox2.Text, TextBox3.Text, NumericUpDown1.Value, NumericUpDown2.Value, TextBox1.Lines)
                Else
                    Main.WriteFile(Reclam_name.TextBox1.Text, TextBox2.Text, TextBox3.Text, NumericUpDown1.Value, 0, TextBox1.Lines)
                End If
                Main.Reclama_Write()
                ListBox1.Items.Add(Reclam_name.TextBox1.Text)
            End If
        Else
            If CheckBox1.Checked Then
                Main.WriteFile(selected_reclam, TextBox2.Text, TextBox3.Text, NumericUpDown1.Value, NumericUpDown2.Value, TextBox1.Lines)
            Else
                Main.WriteFile(selected_reclam, TextBox2.Text, TextBox3.Text, NumericUpDown1.Value, 0, TextBox1.Lines)
            End If
            Main.Reclama_Write()
            MsgBox("Изменения сохранены.",, "Сообщение")
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.SelectedIndex > -1 Then
            Main.DeleteFile(ListBox1.SelectedItem)
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            Main.Reclama_Write()
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result As DialogResult = Reclam_name.ShowDialog
        If result = DialogResult.OK Then
            Dim data(-1) As String
            Main.WriteFile(Reclam_name.TextBox1.Text, "Заголовок", "", 0, 0, data)
            Main.Reclama_Write()
            ListBox1.Items.Add(Reclam_name.TextBox1.Text)
        End If
    End Sub
    Private Sub КопироватьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles КопироватьToolStripMenuItem.Click
        My.Computer.Clipboard.SetText(TextBox3.SelectedText)
    End Sub
    Private Sub КопироватьВсёToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles КопироватьВсёToolStripMenuItem.Click
        My.Computer.Clipboard.SetText(TextBox3.Text)
    End Sub
    Private Sub ОчиститьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОчиститьToolStripMenuItem.Click
        TextBox3.Text = ""
        PictureBox1.Image = img
    End Sub
End Class
