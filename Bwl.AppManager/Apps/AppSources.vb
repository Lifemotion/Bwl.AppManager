Module AppSources
    Public ReadOnly Property Sources As New List(Of String)

    Sub New()
        Sources.Add("GitRepo,https://github.com/Lifemotion/Bwl.Framework")
        Sources.Add("GitRepo,https://github.com/Lifemotion/Bwl.GitManager")
        Sources.Add("GitRepo,https://github.com/Lifemotion/Bwl.ProjectGenerator")
        Sources.Add("GitRepo,https://github.com/Lifemotion/Bwl.Hardware.Serial")
        Sources.Add("GitRepo,https://github.com/Lifemotion/Bwl.Tools.RunMonitorPlatform")
    End Sub
End Module
