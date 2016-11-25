Public Class AppManagerForm
    Private Sub AppManagerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        App.AppInfoManager.UpdateAvailable()
        Me.Text += " " + Application.ProductVersion
        UpdateAppsList()
    End Sub

    Private Sub UpdateAppsList()
        mainPanel.SuspendLayout()
        mainPanel.Controls.Clear()
        Dim top = 0
        For Each info In App.AppInfoManager.Apps
            Dim ctrl As New AppControl
            ctrl.Left = 0
            ctrl.Top = top
            ctrl.Width = mainPanel.Width - 20
            ctrl.Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Right
            top += ctrl.Height + 10

            ctrl.SetAppInfo(info)
            mainPanel.Controls.Add(ctrl )
        Next
        mainPanel.ResumeLayout()
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
End Class
