Public Class AppInfoManager
    Private _apps As New List(Of IAppInfo)

    Public ReadOnly Property Apps As List(Of IAppInfo)
        Get
            Return _apps
        End Get
    End Property

    Public Property SelfRepository As String = ""

    Public Sub UpdateAvailable()
        UpdateLocal()
        For Each source In Sources
            For Each parser In InfoLoaders
                parser.ProcessSourcesLine(source, Apps)
            Next
        Next
    End Sub

    Public Sub CheckUpdates()
        For Each info In App.AppInfoManager.Apps
            If info.Downloaded Then
                info.CheckUpdates()
            End If
        Next
    End Sub

    Public Sub UpdateRemoteAll()
        For Each info In App.AppInfoManager.Apps
            If info.Downloaded Then
                info.CheckUpdates()
                If info.UpdateExists Then info.InstallOrUpdate()
            End If
        Next
    End Sub

    Public Sub UpdateLocal()
        Dim dirs = IO.Directory.GetDirectories(DataPath)
        For Each path In dirs
            If IO.Directory.Exists(IO.Path.Combine(path, ".git")) Then
                If IO.Path.GetFileName(path) = Settings.SelfRepositoryName Then
                    'собственный репозиторий
                    _SelfRepository = path
                End If
                'это гит-репозиторий
                If IO.File.Exists(IO.Path.Combine(path, ".appsinfo")) Then
                    'файл со списком приложений имеется
                    Dim lines = IO.File.ReadAllLines(IO.Path.Combine(path, ".appsinfo"))
                    For Each line In lines
                        Dim parts = line.Split(",")
                        If parts.Length >= 3 Then
                            Dim gitapp As New GitAppInfo(path, parts(0).Trim, parts(2).Trim, parts(1).Trim)
                            If parts.Length > 3 Then gitapp.Description = parts(3)
                            If Not Apps.Any(Function(app) app.Name = gitapp.Name) Then
                                Apps.Add(gitapp)
                            Else

                            End If
                        End If
                    Next
                End If
            End If
        Next
    End Sub
End Class
