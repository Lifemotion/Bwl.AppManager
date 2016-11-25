Public Class AppInfoManager
    Public ReadOnly Property Apps As New List(Of IAppInfo)

    Public Sub UpdateAvailable()
        UpdateLocal()
        For Each source In Sources
            Dim parts = source.Split(",")
            If parts.Length = 2 Then
                If parts(0) = "GitRepo" Then
                    Dim url = parts(1)
                    If url.ToLower.StartsWith("https://github.com/") Then
                        Dim appinfourl = url.Replace("https://github.com/", "https://raw.githubusercontent.com/") + "/master/.appsinfo"
                        Dim appinfoResp = System.Net.HttpWebRequest.Create(appinfourl).GetResponse
                        Dim appinfoReader = New IO.StreamReader(appinfoResp.GetResponseStream)
                        Dim appInfo = appinfoReader.ReadToEnd
                        Dim name = url.Split("/").Last
                        Dim path = IO.Path.Combine(App.DataPath, name)
                        '  Dim apppath = IO.Path(IO.Path.)
                        Dim lines = appInfo.Split({vbCr, vbLf}, StringSplitOptions.RemoveEmptyEntries)
                        For Each line In lines
                            Dim lparts = line.Split(",")
                            If lparts.Length = 3 Then
                                Dim gitapp As New GitAppInfo(path, lparts(0).Trim, lparts(2).Trim, lparts(1).Trim)
                                gitapp.RepositoryUrl = url + ".git"
                                If Not Apps.Any(Function(app) app.Name = gitapp.Name) Then
                                    Apps.Add(gitapp)
                                End If
                            End If
                        Next
                    End If
                End If
            End If
        Next
    End Sub

    Public Sub UpdateLocal()
        Dim dirs = IO.Directory.GetDirectories(DataPath)
        For Each path In dirs
            If IO.Directory.Exists(IO.Path.Combine(path, ".git")) Then
                'это гит-репозиторий
                If IO.File.Exists(IO.Path.Combine(path, ".appsinfo")) Then
                    'файл со списком приложений имеется
                    Dim lines = IO.File.ReadAllLines(IO.Path.Combine(path, ".appsinfo"))
                    For Each line In lines
                        Dim parts = line.Split(",")
                        If parts.Length = 3 Then
                            Dim gitapp As New GitAppInfo(path, parts(0).Trim, parts(2).Trim, parts(1).Trim)
                            Apps.Add(gitapp)
                        End If
                    Next
                End If
            End If
        Next
    End Sub
End Class
