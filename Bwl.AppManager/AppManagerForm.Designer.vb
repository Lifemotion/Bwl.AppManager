<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppManagerForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppManagerForm))
        Me.menuMain = New System.Windows.Forms.MenuStrip()
        Me.AppManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateAvailableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UpdateAllInstalledAppsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateAllInstalledAppsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bCheckUpdates = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckDependensiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MSysGitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MicrosoftBuildTools2015ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.cbAppsInstalled = New System.Windows.Forms.CheckBox()
        Me.cbAppsAvailable = New System.Windows.Forms.CheckBox()
        Me.mainPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.menuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuMain
        '
        Me.menuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AppManagerToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.menuMain.Location = New System.Drawing.Point(0, 0)
        Me.menuMain.Name = "menuMain"
        Me.menuMain.Size = New System.Drawing.Size(917, 24)
        Me.menuMain.TabIndex = 1
        Me.menuMain.Text = "MenuStrip1"
        '
        'AppManagerToolStripMenuItem
        '
        Me.AppManagerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateAvailableToolStripMenuItem, Me.ToolStripMenuItem1, Me.UpdateAllInstalledAppsToolStripMenuItem, Me.UpdateAllInstalledAppsToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ExitToolStripMenuItem})
        Me.AppManagerToolStripMenuItem.Name = "AppManagerToolStripMenuItem"
        Me.AppManagerToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.AppManagerToolStripMenuItem.Text = "Apps"
        '
        'UpdateAvailableToolStripMenuItem
        '
        Me.UpdateAvailableToolStripMenuItem.Name = "UpdateAvailableToolStripMenuItem"
        Me.UpdateAvailableToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.UpdateAvailableToolStripMenuItem.Text = "Refresh Available Apps"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(245, 6)
        '
        'UpdateAllInstalledAppsToolStripMenuItem
        '
        Me.UpdateAllInstalledAppsToolStripMenuItem.Name = "UpdateAllInstalledAppsToolStripMenuItem"
        Me.UpdateAllInstalledAppsToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.UpdateAllInstalledAppsToolStripMenuItem.Text = "Check Updates for Installed Apps"
        '
        'UpdateAllInstalledAppsToolStripMenuItem1
        '
        Me.UpdateAllInstalledAppsToolStripMenuItem1.Name = "UpdateAllInstalledAppsToolStripMenuItem1"
        Me.UpdateAllInstalledAppsToolStripMenuItem1.Size = New System.Drawing.Size(248, 22)
        Me.UpdateAllInstalledAppsToolStripMenuItem1.Text = "Update All Installed Apps"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(245, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bCheckUpdates, Me.CheckDependensiesToolStripMenuItem, Me.MSysGitToolStripMenuItem, Me.MicrosoftBuildTools2015ToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'bCheckUpdates
        '
        Me.bCheckUpdates.Name = "bCheckUpdates"
        Me.bCheckUpdates.Size = New System.Drawing.Size(213, 22)
        Me.bCheckUpdates.Text = "Check Updates"
        '
        'CheckDependensiesToolStripMenuItem
        '
        Me.CheckDependensiesToolStripMenuItem.Name = "CheckDependensiesToolStripMenuItem"
        Me.CheckDependensiesToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.CheckDependensiesToolStripMenuItem.Text = "Check Dependensies"
        '
        'MSysGitToolStripMenuItem
        '
        Me.MSysGitToolStripMenuItem.Name = "MSysGitToolStripMenuItem"
        Me.MSysGitToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.MSysGitToolStripMenuItem.Text = "mSys Git"
        '
        'MicrosoftBuildTools2015ToolStripMenuItem
        '
        Me.MicrosoftBuildTools2015ToolStripMenuItem.Name = "MicrosoftBuildTools2015ToolStripMenuItem"
        Me.MicrosoftBuildTools2015ToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.MicrosoftBuildTools2015ToolStripMenuItem.Text = "Microsoft Build Tools 2015"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 509)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(917, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'cbAppsInstalled
        '
        Me.cbAppsInstalled.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbAppsInstalled.Checked = True
        Me.cbAppsInstalled.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbAppsInstalled.Location = New System.Drawing.Point(771, 23)
        Me.cbAppsInstalled.Name = "cbAppsInstalled"
        Me.cbAppsInstalled.Size = New System.Drawing.Size(70, 21)
        Me.cbAppsInstalled.TabIndex = 3
        Me.cbAppsInstalled.Text = "Installed"
        Me.cbAppsInstalled.UseVisualStyleBackColor = True
        '
        'cbAppsAvailable
        '
        Me.cbAppsAvailable.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbAppsAvailable.Checked = True
        Me.cbAppsAvailable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbAppsAvailable.Location = New System.Drawing.Point(847, 23)
        Me.cbAppsAvailable.Name = "cbAppsAvailable"
        Me.cbAppsAvailable.Size = New System.Drawing.Size(70, 21)
        Me.cbAppsAvailable.TabIndex = 4
        Me.cbAppsAvailable.Text = "Available"
        Me.cbAppsAvailable.UseVisualStyleBackColor = True
        '
        'mainPanel
        '
        Me.mainPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mainPanel.AutoScroll = True
        Me.mainPanel.Location = New System.Drawing.Point(0, 43)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(917, 465)
        Me.mainPanel.TabIndex = 5
        '
        'AppManagerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 531)
        Me.Controls.Add(Me.mainPanel)
        Me.Controls.Add(Me.cbAppsAvailable)
        Me.Controls.Add(Me.cbAppsInstalled)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.menuMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menuMain
        Me.Name = "AppManagerForm"
        Me.Text = "Bwl AppManager"
        Me.menuMain.ResumeLayout(False)
        Me.menuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuMain As MenuStrip
    Friend WithEvents AppManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents cbAppsInstalled As CheckBox
    Friend WithEvents cbAppsAvailable As CheckBox
    Friend WithEvents UpdateAvailableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateAllInstalledAppsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents bCheckUpdates As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents UpdateAllInstalledAppsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MicrosoftBuildTools2015ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MSysGitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckDependensiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mainPanel As FlowLayoutPanel
End Class
