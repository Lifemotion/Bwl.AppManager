<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomeForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WelcomeForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mSysGit = New System.Windows.Forms.CheckBox()
        Me.buildTools = New System.Windows.Forms.CheckBox()
        Me.bOk = New System.Windows.Forms.Button()
        Me.bCheck = New System.Windows.Forms.Button()
        Me.mSysGitLink = New System.Windows.Forms.LinkLabel()
        Me.buildToolsLink = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(385, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bwl AppManager allows you to install and update all Bwl software with one click."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(280, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "mSys git and Microsoft Build Tools should be installed first."
        '
        'mSysGit
        '
        Me.mSysGit.AutoCheck = False
        Me.mSysGit.AutoSize = True
        Me.mSysGit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.mSysGit.Location = New System.Drawing.Point(13, 53)
        Me.mSysGit.Name = "mSysGit"
        Me.mSysGit.Size = New System.Drawing.Size(88, 24)
        Me.mSysGit.TabIndex = 2
        Me.mSysGit.Text = "mSysGit"
        Me.mSysGit.UseVisualStyleBackColor = True
        '
        'buildTools
        '
        Me.buildTools.AutoCheck = False
        Me.buildTools.AutoSize = True
        Me.buildTools.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.buildTools.Location = New System.Drawing.Point(13, 83)
        Me.buildTools.Name = "buildTools"
        Me.buildTools.Size = New System.Drawing.Size(174, 24)
        Me.buildTools.TabIndex = 3
        Me.buildTools.Text = "Microsoft Build Tools"
        Me.buildTools.UseVisualStyleBackColor = True
        '
        'bOk
        '
        Me.bOk.Enabled = False
        Me.bOk.Location = New System.Drawing.Point(580, 115)
        Me.bOk.Name = "bOk"
        Me.bOk.Size = New System.Drawing.Size(75, 23)
        Me.bOk.TabIndex = 4
        Me.bOk.Text = "OK"
        Me.bOk.UseVisualStyleBackColor = True
        '
        'bCheck
        '
        Me.bCheck.Location = New System.Drawing.Point(462, 115)
        Me.bCheck.Name = "bCheck"
        Me.bCheck.Size = New System.Drawing.Size(112, 23)
        Me.bCheck.TabIndex = 5
        Me.bCheck.Text = "Check Again"
        Me.bCheck.UseVisualStyleBackColor = True
        '
        'mSysGitLink
        '
        Me.mSysGitLink.AutoSize = True
        Me.mSysGitLink.Location = New System.Drawing.Point(312, 59)
        Me.mSysGitLink.Name = "mSysGitLink"
        Me.mSysGitLink.Size = New System.Drawing.Size(331, 13)
        Me.mSysGitLink.TabIndex = 6
        Me.mSysGitLink.TabStop = True
        Me.mSysGitLink.Text = "https://www.microsoft.com/en-US/download/details.aspx?id=48159"
        '
        'buildToolsLink
        '
        Me.buildToolsLink.AutoSize = True
        Me.buildToolsLink.Location = New System.Drawing.Point(312, 87)
        Me.buildToolsLink.Name = "buildToolsLink"
        Me.buildToolsLink.Size = New System.Drawing.Size(161, 13)
        Me.buildToolsLink.TabIndex = 7
        Me.buildToolsLink.TabStop = True
        Me.buildToolsLink.Text = "https://git-for-windows.github.io/"
        '
        'WelcomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 150)
        Me.Controls.Add(Me.buildToolsLink)
        Me.Controls.Add(Me.mSysGitLink)
        Me.Controls.Add(Me.bCheck)
        Me.Controls.Add(Me.bOk)
        Me.Controls.Add(Me.buildTools)
        Me.Controls.Add(Me.mSysGit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WelcomeForm"
        Me.Text = "Welcome to AppManager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents mSysGit As CheckBox
    Friend WithEvents buildTools As CheckBox
    Friend WithEvents bOk As Button
    Friend WithEvents bCheck As Button
    Friend WithEvents mSysGitLink As LinkLabel
    Friend WithEvents buildToolsLink As LinkLabel
End Class
