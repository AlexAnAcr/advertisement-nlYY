Public Class Main
    Public reclama_data_way As String = Application.StartupPath & "\r_dat.dat"
    Dim WshShell As Object, strDesktop As String, reclama_data As New List(Of Reclama_dat)
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = -Me.Width - 10
        Try
            Dim reclama_data_stand() As String = IO.File.ReadAllLines(reclama_data_way)
            For i As Integer = 0 To reclama_data_stand.Length - 1
                If "<" & reclama_data_stand(i).TrimStart("<") = reclama_data_stand(i) Then
                    reclama_data.Add(New Reclama_dat)
                    reclama_data.Item(reclama_data.Count - 1).name = Mid(reclama_data_stand(i), 2)
                    reclama_data.Item(reclama_data.Count - 1).title = reclama_data_stand(i + 1)
                    reclama_data.Item(reclama_data.Count - 1).picture_way = reclama_data_stand(i + 2)
                    reclama_data.Item(reclama_data.Count - 1).time = reclama_data_stand(i + 3)
                    reclama_data.Item(reclama_data.Count - 1).povtor = reclama_data_stand(i + 4)
                    Dim simvol As String = "", i1 As Integer = i
                    While simvol <> ">"
                        simvol = reclama_data_stand(i1)
                        i1 += 1
                    End While
                    For i2 As Integer = i + 5 To i1 - 2
                        Array.Resize(reclama_data.Item(reclama_data.Count - 1).info, reclama_data.Item(reclama_data.Count - 1).info.Length + 1)
                        reclama_data.Item(reclama_data.Count - 1).info(reclama_data.Item(reclama_data.Count - 1).info.Length - 1) = reclama_data_stand(i2)
                    Next
                End If
            Next
        Catch
            My.Computer.FileSystem.WriteAllText(reclama_data_way, "", False)
        End Try
    End Sub
    Private Sub Main_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If reclama_data.Count > 0 Then
            Array.Resize(Reclama.reclama_names, reclama_data.Count)
            For i As Integer = 0 To Reclama.reclama_names.Length - 1
                Reclama.reclama_names(i) = reclama_data(i).name
            Next
            Reclama.Show()
        End If
        WshShell = CreateObject("WScript.Shell")
        strDesktop = WshShell.SpecialFolders("Startup")
        Main_Timer.Start()
    End Sub
    Dim time_tick As Integer = 0
    Private Sub Main_Timer_Tick(sender As Object, e As EventArgs) Handles Main_Timer.Tick
        If My.Computer.FileSystem.FileExists(strDesktop & "/advertisement.lnk") = False Then
            Dim oShellLink As Object
            oShellLink = WshShell.CreateShortcut(strDesktop & "\advertisement.lnk")
            oShellLink.TargetPath = Application.StartupPath & " \advertisement.exe"
            oShellLink.WindowStyle = 1
            oShellLink.IconLocation = Application.StartupPath & "\advertisement.exe, 0"
            oShellLink.WorkingDirectory = Application.StartupPath & " \advertisement.exe"
            oShellLink.Save()
        End If
        If Math.IEEERemainder(time_tick, 6) = 0 And time_tick <> 0 Then
            If My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "/Advertisement Settings.ls3") Then
                If My.Computer.FileSystem.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "/Advertisement Settings.ls3") = "A:Settings A 14237281372445390598598759805900390" Then
                    My.Computer.FileSystem.DeleteFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "/Advertisement Settings.ls3")
                    Reclama.Close()
                    Main_Timer.Stop()
                    SetReclam.ShowDialog()
                    Main_Timer.Start()
                End If
            End If
            For i As Integer = 0 To reclama_data.Count - 1
                If reclama_data(i).povtor <> 0 Then
                    If Math.IEEERemainder(time_tick, reclama_data(i).povtor * 6) = 0 Then
                        Array.Resize(Reclama.reclama_names, Reclama.reclama_names.Length + 1)
                        Reclama.reclama_names(Reclama.reclama_names.Length - 1) = reclama_data(i).name
                        If Reclama.reclama_open = False Then
                            Reclama.Show()
                        End If
                    End If
                End If
            Next
        End If
        If time_tick = 2147483640 Then
            time_tick = 0
        Else
            time_tick += 1
        End If
    End Sub
    Public Function GetFiles()
        Dim files(reclama_data.Count - 1) As String
        For i As Integer = 0 To reclama_data.Count - 1
            files(i) = reclama_data(i).name
        Next
        Return files
    End Function
    Public Function FileExits(file As String)
        Dim exits As Boolean = False
        For i As Integer = 0 To reclama_data.Count - 1
            If reclama_data(i).name = file Then
                exits = True
                Exit For
            End If
        Next
        Return exits
    End Function
    Public Sub WriteFile(file As String, title As String, picture_way As String, time As Short, povtor As Short, info() As String)
        If FileExits(file) Then
            For i As Integer = 0 To reclama_data.Count - 1
                If reclama_data(i).name = file Then
                    reclama_data.Item(i).title = title
                    reclama_data.Item(i).picture_way = picture_way
                    reclama_data.Item(i).time = time
                    reclama_data.Item(i).povtor = povtor
                    Array.Resize(reclama_data(i).info, info.Length)
                    For i1 As Integer = 0 To info.Length - 1
                        reclama_data(i).info(i1) = info(i1)
                    Next
                    Exit For
                End If
            Next
        Else
            reclama_data.Add(New Reclama_dat)
            reclama_data.Item(reclama_data.Count - 1).name = file
            reclama_data.Item(reclama_data.Count - 1).title = title
            reclama_data.Item(reclama_data.Count - 1).picture_way = picture_way
            reclama_data.Item(reclama_data.Count - 1).time = time
            reclama_data.Item(reclama_data.Count - 1).povtor = povtor
            Array.Resize(reclama_data(reclama_data.Count - 1).info, info.Length)
            For i As Integer = 0 To info.Length - 1
                reclama_data(reclama_data.Count - 1).info(i) = info(i)
            Next
        End If
    End Sub
    Public Function GetFile(file As String) As Reclama_dat
        Dim index As Short = -1
        If FileExits(file) Then
            For i As Integer = 0 To reclama_data.Count - 1
                If reclama_data(i).name = file Then
                    index = i
                    Exit For
                End If
            Next
            Return reclama_data(index)
        Else
            Return Nothing
        End If
    End Function
    Public Sub DeleteFile(file As String)
        If FileExits(file) Then
            For i As Integer = 0 To reclama_data.Count - 1
                If reclama_data(i).name = file Then
                    reclama_data.RemoveAt(i)
                    Exit For
                End If
            Next
        End If
    End Sub
    Public Sub Reclama_Write()
        Dim filedata(-1) As String
        For i As Integer = 0 To reclama_data.Count - 1
            Array.Resize(filedata, filedata.Length + 5)
            filedata(filedata.Length - 5) = "<" & reclama_data.Item(i).name
            filedata(filedata.Length - 4) = reclama_data.Item(i).title
            filedata(filedata.Length - 3) = reclama_data.Item(i).picture_way
            filedata(filedata.Length - 2) = reclama_data.Item(i).time
            filedata(filedata.Length - 1) = reclama_data.Item(i).povtor
            For i1 As Integer = 0 To reclama_data.Item(i).info.Length - 1
                Array.Resize(filedata, filedata.Length + 1)
                filedata(filedata.Length - 1) = reclama_data.Item(i).info(i1)
            Next
            Array.Resize(filedata, filedata.Length + 1)
            filedata(filedata.Length - 1) = ">"
        Next
        IO.File.WriteAllLines(reclama_data_way, filedata)
    End Sub
End Class
Public Class Reclama_dat
    Public name, title, picture_way As String, time, povtor As Short, info(-1) As String
    Public Sub New()
        name = ""
        title = ""
        picture_way = ""
        time = 0
        povtor = 0
    End Sub
End Class
