Imports System.Net
Imports Bwl.Framework

Public Module App
    Public AppInfoManager As New AppInfoManager
    Public DataPath As String = IO.Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Bwl AppManager")

    Public Sub Main()
        ServicePointManager.Expect100Continue = True
        ServicePointManager.SecurityProtocol = 3072
        GitTools.GitTool.Init()
        If IO.Directory.Exists(DataPath) = False Then IO.Directory.CreateDirectory(DataPath)

        Application.EnableVisualStyles()
        Application.Run(AppManagerForm)
    End Sub
End Module
