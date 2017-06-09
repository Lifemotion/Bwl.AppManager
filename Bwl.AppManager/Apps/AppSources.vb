Module AppSources
    Public Property Sources As New List(Of String)

    Sub New()
        Sources.Add("GitRepo,https://github.com/Lifemotion/GitterCake,cake-master")
        Sources.Add("GitRepo,https://github.com/Lifemotion/Bwl.Framework,master")
        Sources.Add("GitRepo,https://github.com/Lifemotion/Bwl.GitManager,master")
        Sources.Add("GitRepo,https://github.com/Lifemotion/Bwl.ProjectGenerator,master")
        Sources.Add("GitRepo,https://github.com/Lifemotion/Bwl.Hardware.Serial,master")
        Sources.Add("GitRepo,https://github.com/Lifemotion/Bwl.Tools.RunMonitorPlatform,master")
        Sources.Add("GitRepo,https://github.com/Lifemotion/Bwl.GPS,master")
        Sources.Add("GitRepo,https://github.com/Lifemotion/Bwl.RaspberryPi,master")
        Sources.Add("GitRepo,https://github.com/Lifemotion/Bwl.IrTerm,master")
    End Sub
End Module
