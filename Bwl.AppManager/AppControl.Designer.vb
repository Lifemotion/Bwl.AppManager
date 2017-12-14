<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppControl
    Inherits System.Windows.Forms.UserControl

    'Пользовательский элемент управления (UserControl) переопределяет метод Dispose для очистки списка компонентов.
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
        Me.components = New System.ComponentModel.Container()
        Me.lName = New System.Windows.Forms.Label()
        Me.bInstallUpdate = New System.Windows.Forms.Button()
        Me.bMisc = New System.Windows.Forms.Button()
        Me.lVersion = New System.Windows.Forms.Label()
        Me.lDescription = New System.Windows.Forms.Label()
        Me.lStatus = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenInExplorerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pbIcon = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lName
        '
        Me.lName.AutoSize = True
        Me.lName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lName.Location = New System.Drawing.Point(32, 0)
        Me.lName.Name = "lName"
        Me.lName.Size = New System.Drawing.Size(253, 20)
        Me.lName.TabIndex = 0
        Me.lName.Text = "Bwl SimplSerial Tool Tool Tool Tool"
        '
        'bInstallUpdate
        '
        Me.bInstallUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bInstallUpdate.Location = New System.Drawing.Point(320, 20)
        Me.bInstallUpdate.Name = "bInstallUpdate"
        Me.bInstallUpdate.Size = New System.Drawing.Size(75, 23)
        Me.bInstallUpdate.TabIndex = 1
        Me.bInstallUpdate.Text = "Install"
        Me.bInstallUpdate.UseVisualStyleBackColor = True
        '
        'bMisc
        '
        Me.bMisc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bMisc.Location = New System.Drawing.Point(401, 20)
        Me.bMisc.Name = "bMisc"
        Me.bMisc.Size = New System.Drawing.Size(27, 23)
        Me.bMisc.TabIndex = 3
        Me.bMisc.Text = "..."
        Me.bMisc.UseVisualStyleBackColor = True
        '
        'lVersion
        '
        Me.lVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lVersion.AutoEllipsis = True
        Me.lVersion.Location = New System.Drawing.Point(385, 3)
        Me.lVersion.Name = "lVersion"
        Me.lVersion.Size = New System.Drawing.Size(51, 17)
        Me.lVersion.TabIndex = 4
        Me.lVersion.Text = "1.1.3.0"
        '
        'lDescription
        '
        Me.lDescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lDescription.AutoEllipsis = True
        Me.lDescription.Location = New System.Drawing.Point(33, 19)
        Me.lDescription.Name = "lDescription"
        Me.lDescription.Size = New System.Drawing.Size(202, 28)
        Me.lDescription.TabIndex = 5
        Me.lDescription.Text = "Description Description Description Description Description Description Descripti" &
    "on Description Description"
        '
        'lStatus
        '
        Me.lStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lStatus.Location = New System.Drawing.Point(236, 2)
        Me.lStatus.Name = "lStatus"
        Me.lStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lStatus.Size = New System.Drawing.Size(143, 16)
        Me.lStatus.TabIndex = 6
        Me.lStatus.Text = "Installed"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenInExplorerToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(171, 48)
        '
        'OpenInExplorerToolStripMenuItem
        '
        Me.OpenInExplorerToolStripMenuItem.Name = "OpenInExplorerToolStripMenuItem"
        Me.OpenInExplorerToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.OpenInExplorerToolStripMenuItem.Text = "Open in Explorer..."
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'pbIcon
        '
        Me.pbIcon.Location = New System.Drawing.Point(0, 9)
        Me.pbIcon.Name = "pbIcon"
        Me.pbIcon.Size = New System.Drawing.Size(30, 30)
        Me.pbIcon.TabIndex = 7
        Me.pbIcon.TabStop = False
        '
        'AppControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pbIcon)
        Me.Controls.Add(Me.lDescription)
        Me.Controls.Add(Me.lName)
        Me.Controls.Add(Me.bMisc)
        Me.Controls.Add(Me.bInstallUpdate)
        Me.Controls.Add(Me.lStatus)
        Me.Controls.Add(Me.lVersion)
        Me.Name = "AppControl"
        Me.Size = New System.Drawing.Size(436, 47)
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lName As Label
    Friend WithEvents bInstallUpdate As Button
    Friend WithEvents bMisc As Button
    Friend WithEvents lVersion As Label
    Friend WithEvents lDescription As Label
    Friend WithEvents lStatus As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents OpenInExplorerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pbIcon As PictureBox
End Class
