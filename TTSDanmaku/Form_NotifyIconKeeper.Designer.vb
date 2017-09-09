<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_NotifyIconKeeper
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_NotifyIconKeeper))
        Me.NotifyIcon_Default = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip_Default = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem_ShowMgmtWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_ShowHideDMJForm = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_LeaveDMJ = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip_Default.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon_Default
        '
        Me.NotifyIcon_Default.ContextMenuStrip = Me.ContextMenuStrip_Default
        Me.NotifyIcon_Default.Icon = CType(resources.GetObject("NotifyIcon_Default.Icon"), System.Drawing.Icon)
        Me.NotifyIcon_Default.Text = "TTSDanmaku"
        Me.NotifyIcon_Default.Visible = True
        '
        'ContextMenuStrip_Default
        '
        Me.ContextMenuStrip_Default.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_ShowHideDMJForm, Me.ToolStripMenuItem_ShowMgmtWindow, Me.ToolStripMenuItem_LeaveDMJ})
        Me.ContextMenuStrip_Default.Name = "ContextMenuStrip_Default"
        Me.ContextMenuStrip_Default.Size = New System.Drawing.Size(235, 92)
        '
        'ToolStripMenuItem_ShowMgmtWindow
        '
        Me.ToolStripMenuItem_ShowMgmtWindow.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!)
        Me.ToolStripMenuItem_ShowMgmtWindow.Image = Global.TTSDanmaku.My.Resources.Resources.settings
        Me.ToolStripMenuItem_ShowMgmtWindow.Name = "ToolStripMenuItem_ShowMgmtWindow"
        Me.ToolStripMenuItem_ShowMgmtWindow.Size = New System.Drawing.Size(234, 22)
        Me.ToolStripMenuItem_ShowMgmtWindow.Text = "显示管理窗口 (&S)"
        '
        'ToolStripMenuItem_ShowHideDMJForm
        '
        Me.ToolStripMenuItem_ShowHideDMJForm.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem_ShowHideDMJForm.Image = Global.TTSDanmaku.My.Resources.Resources.dmj
        Me.ToolStripMenuItem_ShowHideDMJForm.Name = "ToolStripMenuItem_ShowHideDMJForm"
        Me.ToolStripMenuItem_ShowHideDMJForm.Size = New System.Drawing.Size(234, 22)
        Me.ToolStripMenuItem_ShowHideDMJForm.Text = "显示 / 隐藏弹幕姬主窗口 (&D)"
        '
        'ToolStripMenuItem_LeaveDMJ
        '
        Me.ToolStripMenuItem_LeaveDMJ.Image = Global.TTSDanmaku.My.Resources.Resources.warning
        Me.ToolStripMenuItem_LeaveDMJ.Name = "ToolStripMenuItem_LeaveDMJ"
        Me.ToolStripMenuItem_LeaveDMJ.Size = New System.Drawing.Size(234, 22)
        Me.ToolStripMenuItem_LeaveDMJ.Text = "退出弹幕姬 (&E)"
        '
        'Form_NotifyIconKeeper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(284, 61)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_NotifyIconKeeper"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TTSDanmaku NotifyIcon Keeper"
        Me.ContextMenuStrip_Default.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NotifyIcon_Default As Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip_Default As Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem_ShowMgmtWindow As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_LeaveDMJ As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_ShowHideDMJForm As Windows.Forms.ToolStripMenuItem
End Class
