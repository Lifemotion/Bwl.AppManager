Module App

    Public Sub Main()
        'InstallTools.AssertGitInstalled()
        If Not WelcomeForm.CheckAll() Then WelcomeForm.ShowDialog()
        Dim appPath As String = IO.Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Bwl AppManager", "Bwl.AppManager")
        Dim appName = "Bwl AppManager"
        Dim url = "https://github.com/Lifemotion/Bwl.AppManager"
        InstallTools.InstallFromRepository(appPath, url, appName)
    End Sub
End Module
