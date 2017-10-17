Imports Bwl.Framework

Public Module App
    Public AppInfoManager As New AppInfoManager
    Public DataPath As String = IO.Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Bwl AppManager")

    Public Sub Main()
        GitTools.GitTool.Init()
        If IO.Directory.Exists(DataPath) = False Then IO.Directory.CreateDirectory(DataPath)

        Application.EnableVisualStyles()
        Application.Run(AppManagerForm)
    End Sub
End Module
