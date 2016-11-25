Imports Bwl.AppManager

Public Class AppControl
    Private _info As IAppInfo
    Public Event RequestPanelUpdate()

    Friend Sub SetAppInfo(info As IAppInfo)
        _info = info
        Refresh()
    End Sub

    Public Overrides Sub Refresh()
        lName.Text = _info.Name
        If _info.Downloaded Then
            bInstallUpdate.Text = "Update"
            lStatus.Text = "Downloaded"
        Else
            bInstallUpdate.Text = "Install"
            lStatus.Text = "Available"
        End If
        If _info.Prepared Then
            bRun.Enabled = True
            lStatus.Text = "Ready"
        Else
            bRun.Enabled = False
        End If
        lDescription.Text = ""
        lVersion.Text = _info.Version
        MyBase.Refresh()
    End Sub

    Private Sub bInstallUpdate_Click(sender As Object, e As EventArgs) Handles bInstallUpdate.Click
        _info.InstallOrUpdate()
        Refresh()
    End Sub

    Private Sub bRun_Click(sender As Object, e As EventArgs) Handles bRun.Click
        _info.Run()
        Refresh()
    End Sub
End Class
