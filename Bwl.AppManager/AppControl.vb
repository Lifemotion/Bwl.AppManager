Imports Bwl.AppManager

Public Class AppControl
    Private _info As IAppInfo
    Public Event RequestPanelUpdate()

    Friend Sub SetAppInfo(info As IAppInfo)
        _info = info
        AddHandler _info.Changed, AddressOf Refresh
        Refresh()
    End Sub

    Public Overrides Sub Refresh()
        If Me.InvokeRequired Then
            Me.Invoke(Sub() Refresh())
        Else
            lName.Text = _info.Name
            If _info.CurrentOperation > "" Then
                bRun.Enabled = False
                bInstallUpdate.Enabled = False
                lStatus.Text = _info.CurrentOperation
                BackColor = Color.FromArgb(240, 240, 255)
            Else
                bInstallUpdate.Enabled = True
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
                    BackColor = Color.FromArgb(240, 240, 240)

                End If
            End If

            lDescription.Text = _info.Description
            lVersion.Text = _info.Version
            MyBase.Refresh()
        End If
    End Sub

    Private Sub bInstallUpdate_Click(sender As Object, e As EventArgs) Handles bInstallUpdate.Click
        Dim thr As New Threading.Thread(Sub()
                                            Try
                                                _info.InstallOrUpdate()
                                                Refresh()
                                            Catch ex As Exception
                                                MsgBox("Install Or Update failed!" + vbCrLf + ex.Message, MsgBoxStyle.Critical)
                                                _info.CurrentOperation = ""
                                                Refresh()
                                            End Try
                                        End Sub)
        thr.Start()
        Refresh()
    End Sub

    Private Sub bRun_Click(sender As Object, e As EventArgs) Handles bRun.Click
        Try
            _info.Run()
        Catch ex As Exception
            MsgBox("Run failed!" + vbCrLf + ex.Message, MsgBoxStyle.Critical)
        End Try
        Refresh()
    End Sub

    Private Sub bMisc_Click(sender As Object, e As EventArgs) Handles bMisc.Click
        ContextMenuStrip1.Show(bMisc, 10, 10)
    End Sub

    Private Sub OpenInExplorerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenInExplorerToolStripMenuItem.Click
        Try
            Dim prc As New Process
            prc.StartInfo.FileName = "explorer"
            prc.StartInfo.Arguments = "."
            prc.StartInfo.WorkingDirectory = _info.BasePath
            prc.Start()
        Catch ex As Exception
            MsgBox("Explorer failed!" + vbCrLf + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If MsgBox("Are You sure to delete " + _info.Name + "?", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkCancel, "Confirm Delete") = MsgBoxResult.Ok Then
            Try
                _info.Delete()
            Catch ex As Exception
                MsgBox("Delete failed!" + vbCrLf + ex.Message, MsgBoxStyle.Critical)
            End Try
            Refresh()
        End If
    End Sub
End Class
