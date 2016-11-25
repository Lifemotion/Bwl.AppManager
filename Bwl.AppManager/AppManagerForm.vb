Public Class AppManagerForm
    Private Sub AppManagerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        App.AppInfoManager.UpdateAvailable()
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
End Class
