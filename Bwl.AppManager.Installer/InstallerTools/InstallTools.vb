Public Class InstallTools
    Public Shared Sub CreateShortcut(path As String, targetPath As String)
        Dim wsh As Object = CreateObject("WScript.Shell")
        wsh = CreateObject("WScript.Shell")
        Dim MyShortcut = wsh.CreateShortcut(path)
        MyShortcut.TargetPath = targetPath
        MyShortcut.WorkingDirectory = IO.Path.GetDirectoryName(targetPath)
        MyShortcut.WindowStyle = 4
        MyShortcut.Save()
    End Sub

    Public Shared Sub AssertGitInstalled()
        Try
            GitTool.Init()
        Catch ex As Exception
            MsgBox("Git not installed. Git required to work. Please download git at: " + vbCrLf + "https://git-scm.com/", MsgBoxStyle.Exclamation)
            Return
        End Try
    End Sub

    Public Shared Sub InstallFromRepository(appPath As String, cloneUrl As String, appName As String)
        InstallTools.AssertGitInstalled()
        MsgBox(appName + " will be downloaded and installed")

        GitTool.RepositoryPullOrClone(appPath, cloneUrl)

        For Each sol In IO.Directory.GetFiles(appPath, "*.sln")
            Try
                Dim bh As New BuildHelper(sol, "Release")
                bh.Build("")
            Catch ex As Exception
            End Try
        Next

        Dim foundExe As Boolean
        For Each exe In IO.Directory.GetFiles(IO.Path.Combine(appPath, "release"), "*.exe", IO.SearchOption.AllDirectories)
            Dim lnkName = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), IO.Path.GetFileNameWithoutExtension(exe)) + ".lnk"
            InstallTools.CreateShortcut(lnkName, exe)
            foundExe = True
        Next
        If foundExe Then
            MsgBox(appName + " installed sucessfully!", MsgBoxStyle.Information)
        Else
            MsgBox("Install failed, no EXE found after pull & build", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class
