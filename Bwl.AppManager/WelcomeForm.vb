Public Class WelcomeForm

    Private Sub WelcomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bCheck_Click(Nothing, Nothing)
    End Sub

    Private Sub bCheck_Click(sender As Object, e As EventArgs) Handles bCheck.Click
        buildTools.Checked = CheckMBT()
        mSysGit.Checked = CheckGit()
        If buildTools.Checked And mSysGit.Checked Then bOk.Enabled = True
    End Sub

    Public Shared Function CheckGit() As Boolean
        Try
            GitTools.GitTool.Init()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Function CheckMBT() As Boolean
        If IO.File.Exists(IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "MSBuild", "14.0", "Bin", "MSBuild.EXE")) Or
             IO.File.Exists(IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "MSBuild", "14.0", "Bin", "MSBuild.EXE")) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function CheckAll() As Boolean
        Return CheckGit() And CheckMBT()
    End Function

    Private Sub bOk_Click(sender As Object, e As EventArgs) Handles bOk.Click
        Close()
    End Sub

    Private Sub mSysGitLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles mSysGitLink.LinkClicked, buildToolsLink.LinkClicked
        Process.Start(sender.text)
    End Sub
End Class