﻿Public Class AppManagerForm
    Private Sub AppManagerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text += " " + Application.ProductVersion
        App.AppInfoManager.UpdateLocal()
        UpdateAppsList()
        Dim updateAvailable As New Threading.Thread(Sub()
                                                        App.AppInfoManager.UpdateAvailable()
                                                        Me.Invoke(Sub() UpdateAppsList())
                                                        App.AppInfoManager.CheckUpdates()
                                                        Me.Invoke(Sub() UpdateAppsList())
                                                        Threading.Thread.Sleep(1000 * 60 * 30)
                                                    End Sub)
        updateAvailable.IsBackground = True
        updateAvailable.Priority = Threading.ThreadPriority.Lowest
        updateAvailable.Start()
    End Sub

    Private Sub UpdateAppsList(Optional force As Boolean = False)
        Static lastAppsCount As Integer
        If lastAppsCount <> App.AppInfoManager.Apps.Count Or force Then
            mainPanel.SuspendLayout()
            mainPanel.Controls.Clear()
            Dim top = 0
            For Each info In App.AppInfoManager.Apps
                Dim show = False
                If cbAppsAvailable.Checked And info.Downloaded = False Then show = True
                If cbAppsInstalled.Checked And info.Downloaded = True Then show = True
                If show Then
                    Dim ctrl As New AppControl
                    ctrl.Left = 10
                    ctrl.Top = top
                    ctrl.Width = mainPanel.Width - 20
                    ctrl.Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Right
                    top += ctrl.Height + 10

                    ctrl.SetAppInfo(info)
                    mainPanel.Controls.Add(ctrl)
                End If
            Next
            mainPanel.ResumeLayout()
            lastAppsCount = App.AppInfoManager.Apps.Count
        Else
            For Each ctrl In mainPanel.Controls
                ctrl.refresh
            Next
            Me.Refresh()
        End If
    End Sub

    Private Sub bCheckUpdates_Click(sender As Object, e As EventArgs) Handles bCheckUpdates.Click
        If App.AppInfoManager.SelfRepository > "" Then
            Try
                Shell(IO.Path.Combine(App.AppInfoManager.SelfRepository, "Bwl AppManager Installer.exe"), AppWinStyle.NormalFocus)
                End
            Catch ex As Exception
                MsgBox("Failed to run Updater")
            End Try
        Else
            MsgBox("Repository with Bwl.AppManager not found. Please install program with installer.")
        End If
    End Sub

    Private Sub cbAppsInstalled_CheckedChanged(sender As Object, e As EventArgs) Handles cbAppsInstalled.CheckedChanged, cbAppsAvailable.CheckedChanged
        UpdateAppsList(True)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
        End

    End Sub

    Private Sub UpdateAllInstalledAppsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateAllInstalledAppsToolStripMenuItem.Click
        Dim thr As New Threading.Thread(Sub()
                                            App.AppInfoManager.CheckUpdates()
                                            Me.Invoke(Sub() UpdateAppsList())
                                        End Sub)
        thr.Start()
    End Sub

    Private Sub UpdateAvailableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateAvailableToolStripMenuItem.Click
        Dim thr As New Threading.Thread(Sub()
                                            App.AppInfoManager.UpdateAvailable()
                                            Me.Invoke(Sub() UpdateAppsList())
                                        End Sub)
        thr.Start()
    End Sub

    Private Sub UpdateAllInstalledAppsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UpdateAllInstalledAppsToolStripMenuItem1.Click
        Dim thr As New Threading.Thread(Sub()
                                            App.AppInfoManager.UpdateRemoteAll()
                                            Me.Invoke(Sub() UpdateAppsList())
                                        End Sub)
        thr.Start()
    End Sub

    Private Sub AppManagerForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
        End
    End Sub

    Private Sub MicrosoftBuildTools2015ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MicrosoftBuildTools2015ToolStripMenuItem.Click
        Process.Start("https://www.microsoft.com/en-US/download/details.aspx?id=48159")
    End Sub
End Class
