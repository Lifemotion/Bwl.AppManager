Imports System.Runtime.InteropServices
Imports Bwl.AppManager

Public Class GitAppInfo
    Implements IAppInfo
    <DllImport("User32.dll")>
    Private Shared Function SendMessage(hWnd As IntPtr, uMsg As Integer, wParam As Integer, lParam As String) As Integer
    End Function
    Private Const WM_SETTEXT As Integer = &HC
    Private Const WM_KEYDOWN As Integer = &H100
    Private Const WM_KEYUP As Integer = &H101
    Private Const WM_CHAR As Integer = &H102
    Private Const VK_RETURN As Integer = &HD

    Public Property BasePath As String = "" Implements IAppInfo.BasePath
    Public Property Name As String = "" Implements IAppInfo.Name
    Public Property Homepage As String = "" Implements IAppInfo.Homepage
    Public Property ExecutablePath As String = "" Implements IAppInfo.ExecutablePath
    Public Property UpdateExists As Boolean Implements IAppInfo.UpdateExists
    Public Property Downloaded As Boolean Implements IAppInfo.Downloaded
    Public Property Prepared As Boolean Implements IAppInfo.Prepared
    Public Property Version As String = "" Implements IAppInfo.Version
    Public Property CurrentOperation As String = "" Implements IAppInfo.CurrentOperation

    Public Property RepositoryUrl As String = ""
    Public Property BuildCommand As String = ""

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
        If IO.Directory.Exists(IO.Path.Combine(BasePath, ".git")) Then
            _Downloaded = True
        Else
            _Downloaded = False
        End If
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
        RaiseEvent Changed(Me)
    End Sub

    Public Sub CheckUpdates() Implements IAppInfo.CheckUpdates
        If Not Downloaded Then Throw New Exception("Must be installed to check updates")
        _CurrentOperation = "Checking updates"
        Try
            RaiseEvent Changed(Me)
            GitTools.GitTool.RepositoryFetch(BasePath)
            Dim status = GitTools.GitTool.GetRepositoryStatus(BasePath)
            _UpdateExists = status.CanPull
            _CurrentOperation = ""
            UpdateLocal()
        Catch ex As Exception
            _CurrentOperation = ""
            UpdateLocal()
            Throw ex
        End Try

    End Sub

    Public Sub InstallOrUpdate() Implements IAppInfo.InstallOrUpdate
        _CurrentOperation = "Install\Update"
        RaiseEvent Changed(Me)
        Dim success = True
        Try
            Dim remotes = GitTools.GitTool.GetRepositoryRemotes(BasePath)(0).Split(" ")
            RepositoryUrl = remotes(1)
        Catch ex As Exception
        End Try
        GitTools.GitTool.RepositoryPullOrClone(BasePath, RepositoryUrl)
        Dim status = GitTools.GitTool.GetRepositoryStatus(BasePath)
        _UpdateExists = status.CanPull
        Dim prc As New Process
        Try
            prc.StartInfo.FileName = IO.Path.Combine(BasePath, BuildCommand)
            prc.StartInfo.WorkingDirectory = BasePath
            prc.StartInfo.RedirectStandardOutput = False
            prc.StartInfo.RedirectStandardError = False
            prc.StartInfo.UseShellExecute = False
            prc.StartInfo.EnvironmentVariables.Add("nopause", "true")
            'prc.StartInfo.RedirectStandardInput = True
            prc.Start()
            Dim thr As New Threading.Thread(Sub()
                                                Try
                                                    Do While prc.HasExited = False
                                                        SendMessage(prc.MainWindowHandle, WM_KEYDOWN, VK_RETURN, Nothing)
                                                        SendMessage(prc.MainWindowHandle, WM_CHAR, VK_RETURN, Nothing)
                                                        Threading.Thread.Sleep(500)
                                                    Loop
                                                Catch ex As Exception
                                                End Try
                                            End Sub)
            thr.IsBackground = True
            thr.Start()
            prc.WaitForExit(30000)
        Catch ex As Exception
        End Try
        Try
            prc.Kill()
        Catch ex As Exception

        End Try
        _CurrentOperation = ""
        UpdateLocal()
    End Sub

    Public Event Changed(source As IAppInfo) Implements IAppInfo.Changed

    Public Sub Run() Implements IAppInfo.Run
        Try
            Dim prc As New Process
            prc.StartInfo.FileName = IO.Path.Combine(BasePath, ExecutablePath)
            prc.StartInfo.WorkingDirectory = IO.Path.GetDirectoryName(prc.StartInfo.FileName)
            prc.Start()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub Delete() Implements IAppInfo.Delete
        Try
            DeleteReadOnly.ForceDelete(BasePath)
            UpdateLocal()
        Catch ex As Exception
            UpdateLocal()
            Throw ex
        End Try
    End Sub
End Class
