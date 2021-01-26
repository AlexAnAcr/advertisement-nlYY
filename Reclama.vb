Public Class Reclama
    Public reclama_open As Boolean = False, reclama_names(-1) As String
    Dim select_reclama As Integer, time As Short = 0
    Private Sub Reclama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reclama_open = True
        Dim pos() As Integer = {My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height}
        Me.Width = Int(pos(0) / 2)
        Me.Height = Int(pos(1) / 3 * 2)
        Me.Left = Int(pos(0) / 2 - Me.Width / 2)
        Me.Top = Int(pos(1) / 2 - Me.Height / 2)
    End Sub
    Private Sub Reclama_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        select_reclama = 0
        Next_button.Enabled = True
        Dim time_dat As Reclama_dat = Main.GetFile(reclama_names(0))
        ProductTitle.Text = time_dat.title
        ProductPicture.ImageLocation = time_dat.picture_way
        ProductInfo.Lines = time_dat.info
        Dim time_dat1 As Integer = time_dat.time
        If time_dat1 > 0 Then
            Next_button.Text = time_dat1
            time = time_dat1
        Else
            Next_button.Text = "Далее"
        End If
    End Sub
    Private Sub Reclama_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        reclama_open = False
        Array.Resize(reclama_names, 0)
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "1" Then
            Next_Timer.Stop()
            select_reclama += 1
            If select_reclama = reclama_names.Length Then
                Me.Close()
            Else
                Dim time_dat As Reclama_dat = Main.GetFile(reclama_names(select_reclama))
                ProductTitle.Text = time_dat.title
                ProductPicture.ImageLocation = time_dat.picture_way
                ProductInfo.Lines = time_dat.info
                Next_button.Enabled = True
                Dim time_dat1 As Integer = time_dat.time
                If time_dat1 > 0 Then
                    Next_button.Text = time_dat1
                    time = time_dat1
                Else
                    Next_button.Text = "Далее"
                End If
            End If
        ElseIf TextBox1.Text = "0" Then
            select_reclama = reclama_names.Length
            Me.Close()
        End If
        TextBox1.Text = ""
    End Sub
    Private Sub Next_button_Click(sender As Object, e As EventArgs) Handles Next_button.Click
        If Next_button.Text <> "Далее" Then
            Next_button.Enabled = False
            Next_Timer.Start()
        Else
            select_reclama += 1
            If select_reclama = reclama_names.Length Then
                Me.Close()
            Else
                Dim time_dat As Reclama_dat = Main.GetFile(reclama_names(select_reclama))
                ProductTitle.Text = time_dat.title
                ProductPicture.ImageLocation = time_dat.picture_way
                ProductInfo.Lines = time_dat.info
                Next_button.Enabled = True
                Dim time_dat1 As Integer = time_dat.time
                If time_dat1 > 0 Then
                    Next_button.Text = time_dat1
                    time = time_dat1
                Else
                    Next_button.Text = "Далее"
                End If
            End If
        End If
    End Sub
    Private Sub Next_Timer_Tick(sender As Object, e As EventArgs) Handles Next_Timer.Tick
        If time = 1 Then
            Next_button.Text = "Далее"
            Next_button.Enabled = True
            Next_Timer.Stop()
        Else
            time -= 1
            Next_button.Text = time
        End If
    End Sub
End Class
