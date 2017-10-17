Public Class GuthubAppInfoLoader
    Implements IAppInfoLoader

    Public Sub ProcessSourcesLine(line As String, apps As List(Of IAppInfo)) Implements IAppInfoLoader.ProcessSourcesLine
        Dim parts = line.Split(",")
        If parts.Length = 3 Then
            If parts(0) = "GitRepo" Then
                Dim url = parts(1)
                Dim branch = parts(2)
                If url.ToLower.StartsWith("https://github.com/") Then
                    Dim appinfourl = url.Replace("https://github.com/", "https://raw.githubusercontent.com/") + "/" + branch + "/.appsinfo"
                    Dim appinfoResp = System.Net.HttpWebRequest.Create(appinfourl).GetResponse
                    Dim appinfoReader = New IO.StreamReader(appinfoResp.GetResponseStream)
                    Dim appInfo = appinfoReader.ReadToEnd
                    Dim name = url.Split("/").Last
                    Dim path = IO.Path.Combine(App.DataPath, name)
                    '  Dim apppath = IO.Path(IO.Path.)
                    Dim lines = appInfo.Split({vbCr, vbLf}, StringSplitOptions.RemoveEmptyEntries)
                    For Each line In lines
                        Dim lparts = line.Split(",")
                        If lparts.Length >= 3 Then
                            Dim gitapp As New GitAppInfo(path, lparts(0).Trim, lparts(2).Trim, lparts(1).Trim)
                            gitapp.RepositoryUrl = url + ".git"
                            If lparts.Length > 3 Then gitapp.Description = lparts(3)
                            If Not apps.Any(Function(app) app.Name = gitapp.Name) Then
                                apps.Add(gitapp)
                            End If
                        End If
                    Next
                End If
            End If
        End If
    End Sub
End Class
