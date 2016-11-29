Imports Bwl.AppManager

Public Class GitAppInfo
    Implements IAppInfo

    Public ReadOnly Property BasePath As String = "" Implements IAppInfo.BasePath
    Public ReadOnly Property Name As String = "" Implements IAppInfo.Name
    Public ReadOnly Property Homepage As String = "" Implements IAppInfo.Homepage
    Public ReadOnly Property ExecutablePath As String = "" Implements IAppInfo.ExecutablePath
    Public ReadOnly Property UpdateExists As Boolean Implements IAppInfo.UpdateExists
    Public ReadOnly Property Downloaded As Boolean Implements IAppInfo.Downloaded
    Public ReadOnly Property Prepared As Boolean Implements IAppInfo.Prepared
    Public ReadOnly Property Version As String = "" Implements IAppInfo.Version
    Public ReadOnly Property CurrentOperation As String = "" Implements IAppInfo.CurrentOperation

    Public Property RepositoryUrl As String = ""
    Public ReadOnly Property BuildCommand As String = ""

    Public Property Description As String = "" Implements IAppInfo.Description

    Public Sub New(basePath As String, name As String, executablePath As String, buildCommand As String)
        Me.BasePath = basePath
        Me.Name = name
        Me.Homepage = Homepage
        Me.RepositoryUrl = RepositoryUrl
        Me.ExecutablePath = executablePath
        Me.BuildCommand = buildCommand
        UpdateLocal()
    End Sub

    Public Sub UpdateLocal() Implements IAppInfo.UpdateLocal
        '  If IO.Directory.Exists(IO.Path.Combine(BasePath, ".git")) Then
        Dim status = GitTools.GitTool.GetRepositoryStatus(BasePath)
        If status.IsRepository Then _Downloaded = True
        _UpdateExists = status.CanPull

        If IO.File.Exists(IO.Path.Combine(BasePath, ExecutablePath)) Then
            _Prepared = True
            Try
                Dim versionInfo = FileVersionInfo.GetVersionInfo(IO.Path.Combine(BasePath, ExecutablePath))
                _Version = versionInfo.ProductVersion
            Catch ex As Exception
            End Try
        Else
            _Prepared = False
            _Version = ""
        End If
        Try
            Dim remotes = GitTools.GitTool.GetRepositoryRemotes(BasePath)(0).Split(" ")
            RepositoryUrl = remotes(1)
        Catch ex As Exception
        End Try
        RaiseEvent Changed(Me)
    End Sub

    Public Sub CheckUpdates() Implements IAppInfo.CheckUpdates
        If Not Downloaded Then Throw New Exception("Must be installed to check updates")
        _CurrentOperation = "Checking updates"
        RaiseEvent Changed(Me)
        GitTools.GitTool.RepositoryFetch(BasePath)
        _CurrentOperation = ""
        UpdateLocal()
    End Sub

    Public Sub InstallOrUpdate() Implements IAppInfo.InstallOrUpdate
        _CurrentOperation = "Install\Update"
        RaiseEvent Changed(Me)
        Dim success = True
        GitTools.GitTool.RepositoryPullOrClone(BasePath, RepositoryUrl)
        Dim prc As New Process
        Try
            prc.StartInfo.FileName = BuildCommand
            prc.StartInfo.WorkingDirectory = BasePath
            prc.StartInfo.RedirectStandardOutput = False
            prc.StartInfo.RedirectStandardError = False
            'prc.StartInfo.RedirectStandardInput = True
            prc.Start()
            'Dim thr As New Threading.Thread(Sub()
            'Do While prc.HasExited = False
            'prc.StandardInput.Write(" ")
            'Threading.Thread.Sleep(500)
            'Loop
            'End Sub)
            'thr.Start()
            prc.WaitForExit(30000)
        Catch ex As Exception
        End Try
        Try
            prc.kill
        Catch ex As Exception

        End Try
        _CurrentOperation = ""
        UpdateLocal()
    End Sub

    Public Event Changed(source As IAppInfo) Implements IAppInfo.Changed

    Public Sub Run() Implements IAppInfo.Run
        Try
            Dim prc As New Process
            prc.StartInfo.FileName = ExecutablePath
            prc.StartInfo.WorkingDirectory = BasePath
            prc.Start()
        Catch ex As Exception
        End Try
    End Sub

    Public Sub Delete() Implements IAppInfo.Delete
        Try
            IO.Directory.Delete(BasePath, True)
        Catch ex As Exception
        End Try
        UpdateLocal()
    End Sub
End Class
