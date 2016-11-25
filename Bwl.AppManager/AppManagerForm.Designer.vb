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
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.menuMain = New System.Windows.Forms.MenuStrip()
        Me.AppManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.cbAppsInstalled = New System.Windows.Forms.CheckBox()
        Me.cbAppsAvailable = New System.Windows.Forms.CheckBox()
        Me.UpdateAvailableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateAllInstalledAppsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainPanel
        '
        Me.mainPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mainPanel.AutoScroll = True
        Me.mainPanel.Location = New System.Drawing.Point(0, 46)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(644, 446)
        Me.mainPanel.TabIndex = 0
        '
        'menuMain
        '
        Me.menuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AppManagerToolStripMenuItem})
        Me.menuMain.Location = New System.Drawing.Point(0, 0)
        Me.menuMain.Name = "menuMain"
        Me.menuMain.Size = New System.Drawing.Size(644, 24)
        Me.menuMain.TabIndex = 1
        Me.menuMain.Text = "MenuStrip1"
        '
        'AppManagerToolStripMenuItem
        '
        Me.AppManagerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateAvailableToolStripMenuItem, Me.UpdateAllInstalledAppsToolStripMenuItem})
        Me.AppManagerToolStripMenuItem.Name = "AppManagerToolStripMenuItem"
        Me.AppManagerToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.AppManagerToolStripMenuItem.Text = "AppManager"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 495)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(644, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'cbAppsInstalled
        '
        Me.cbAppsInstalled.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbAppsInstalled.Checked = True
        Me.cbAppsInstalled.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbAppsInstalled.Location = New System.Drawing.Point(498, 23)
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
        Me.cbAppsAvailable.Location = New System.Drawing.Point(574, 23)
        Me.cbAppsAvailable.Name = "cbAppsAvailable"
        Me.cbAppsAvailable.Size = New System.Drawing.Size(70, 21)
        Me.cbAppsAvailable.TabIndex = 4
        Me.cbAppsAvailable.Text = "Available"
        Me.cbAppsAvailable.UseVisualStyleBackColor = True
        '
        'UpdateAvailableToolStripMenuItem
        '
        Me.UpdateAvailableToolStripMenuItem.Name = "UpdateAvailableToolStripMenuItem"
        Me.UpdateAvailableToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.UpdateAvailableToolStripMenuItem.Text = "Check Available"
        '
        'UpdateAllInstalledAppsToolStripMenuItem
        '
        Me.UpdateAllInstalledAppsToolStripMenuItem.Name = "UpdateAllInstalledAppsToolStripMenuItem"
        Me.UpdateAllInstalledAppsToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.UpdateAllInstalledAppsToolStripMenuItem.Text = "Update All Installed Apps"
        '
        'AppManagerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 517)
        Me.Controls.Add(Me.cbAppsAvailable)
        Me.Controls.Add(Me.cbAppsInstalled)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.mainPanel)
        Me.Controls.Add(Me.menuMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menuMain
        Me.Name = "AppManagerForm"
        Me.Text = "Bwl.AppManager"
        Me.menuMain.ResumeLayout(False)
        Me.menuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainPanel As Panel
    Friend WithEvents menuMain As MenuStrip
    Friend WithEvents AppManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents cbAppsInstalled As CheckBox
    Friend WithEvents cbAppsAvailable As CheckBox
    Friend WithEvents UpdateAvailableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateAllInstalledAppsToolStripMenuItem As ToolStripMenuItem
End Class
