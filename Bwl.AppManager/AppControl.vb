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
        bRun.Enabled = False
        ForeColor = Color.Black
        bInstallUpdate.ForeColor = Color.Black
        bMisc.ForeColor = Color.Black
        If _info.Downloaded Then
            lStatus.Text = "Downloaded"
            If _info.Prepared Then
                bRun.Enabled = True
                BackColor = Color.FromArgb(240, 255, 240)
                lStatus.Text = "Ready"
            Else
            End If

            If _info.UpdateExists Then
                BackColor = Color.FromArgb(255, 255, 240)
                bInstallUpdate.Text = "Update"
                lStatus.Text += ", Update Exists"
            Else
                bInstallUpdate.Text = "Reinstall"
            End If
        Else
            bInstallUpdate.Text = "Install"
            lStatus.Text = "Available"
            ForeColor = Color.Gray

        End If
        lDescription.Text = _info.Homepage
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
