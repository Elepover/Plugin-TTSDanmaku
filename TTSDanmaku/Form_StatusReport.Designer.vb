<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_StatusReport
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_StatusReport))
        Me.Panel_AutoScroll = New System.Windows.Forms.Panel()
        Me.TextBox_VarsHelp = New System.Windows.Forms.TextBox()
        Me.CheckBox_ShowVarsHelp = New System.Windows.Forms.CheckBox()
        Me.GroupBox_Configurations = New System.Windows.Forms.GroupBox()
        Me.TextBox_ReportText = New System.Windows.Forms.TextBox()
        Me.Label_CustomText = New System.Windows.Forms.Label()
        Me.NumericUpDown_Interval = New System.Windows.Forms.NumericUpDown()
        Me.Label_Interval = New System.Windows.Forms.Label()
        Me.GroupBox_FunctionSwitch = New System.Windows.Forms.GroupBox()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.CheckBox_EnableAdvVars = New System.Windows.Forms.CheckBox()
        Me.CheckBox_EnableStatusReport = New System.Windows.Forms.CheckBox()
        Me.ToolTip_Default = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel_AutoScroll.SuspendLayout()
        Me.GroupBox_Configurations.SuspendLayout()
        CType(Me.NumericUpDown_Interval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_FunctionSwitch.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_AutoScroll
        '
        Me.Panel_AutoScroll.Controls.Add(Me.TextBox_VarsHelp)
        Me.Panel_AutoScroll.Controls.Add(Me.CheckBox_ShowVarsHelp)
        Me.Panel_AutoScroll.Controls.Add(Me.GroupBox_Configurations)
        Me.Panel_AutoScroll.Controls.Add(Me.GroupBox_FunctionSwitch)
        Me.Panel_AutoScroll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_AutoScroll.Location = New System.Drawing.Point(0, 0)
        Me.Panel_AutoScroll.Name = "Panel_AutoScroll"
        Me.Panel_AutoScroll.Size = New System.Drawing.Size(484, 272)
        Me.Panel_AutoScroll.TabIndex = 0
        '
        'TextBox_VarsHelp
        '
        Me.TextBox_VarsHelp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_VarsHelp.Location = New System.Drawing.Point(12, 284)
        Me.TextBox_VarsHelp.Multiline = True
        Me.TextBox_VarsHelp.Name = "TextBox_VarsHelp"
        Me.TextBox_VarsHelp.ReadOnly = True
        Me.TextBox_VarsHelp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox_VarsHelp.Size = New System.Drawing.Size(460, 146)
        Me.TextBox_VarsHelp.TabIndex = 3
        Me.TextBox_VarsHelp.Text = resources.GetString("TextBox_VarsHelp.Text")
        '
        'CheckBox_ShowVarsHelp
        '
        Me.CheckBox_ShowVarsHelp.AutoSize = True
        Me.CheckBox_ShowVarsHelp.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_ShowVarsHelp.Location = New System.Drawing.Point(12, 256)
        Me.CheckBox_ShowVarsHelp.Name = "CheckBox_ShowVarsHelp"
        Me.CheckBox_ShowVarsHelp.Size = New System.Drawing.Size(105, 22)
        Me.CheckBox_ShowVarsHelp.TabIndex = 2
        Me.CheckBox_ShowVarsHelp.Text = "显示变量帮助"
        Me.ToolTip_Default.SetToolTip(Me.CheckBox_ShowVarsHelp, "查看可用变量列表。")
        Me.CheckBox_ShowVarsHelp.UseVisualStyleBackColor = True
        '
        'GroupBox_Configurations
        '
        Me.GroupBox_Configurations.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_Configurations.Controls.Add(Me.TextBox_ReportText)
        Me.GroupBox_Configurations.Controls.Add(Me.Label_CustomText)
        Me.GroupBox_Configurations.Controls.Add(Me.NumericUpDown_Interval)
        Me.GroupBox_Configurations.Controls.Add(Me.Label_Interval)
        Me.GroupBox_Configurations.Location = New System.Drawing.Point(12, 130)
        Me.GroupBox_Configurations.Name = "GroupBox_Configurations"
        Me.GroupBox_Configurations.Size = New System.Drawing.Size(460, 118)
        Me.GroupBox_Configurations.TabIndex = 1
        Me.GroupBox_Configurations.TabStop = False
        Me.GroupBox_Configurations.Text = "细节配置"
        '
        'TextBox_ReportText
        '
        Me.TextBox_ReportText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_ReportText.Location = New System.Drawing.Point(9, 85)
        Me.TextBox_ReportText.Name = "TextBox_ReportText"
        Me.TextBox_ReportText.Size = New System.Drawing.Size(445, 23)
        Me.TextBox_ReportText.TabIndex = 4
        Me.ToolTip_Default.SetToolTip(Me.TextBox_ReportText, "自定义状态报告时的读出内容。")
        '
        'Label_CustomText
        '
        Me.Label_CustomText.AutoSize = True
        Me.Label_CustomText.Location = New System.Drawing.Point(6, 65)
        Me.Label_CustomText.Name = "Label_CustomText"
        Me.Label_CustomText.Size = New System.Drawing.Size(116, 17)
        Me.Label_CustomText.TabIndex = 3
        Me.Label_CustomText.Text = "自定义状态报告内容"
        '
        'NumericUpDown_Interval
        '
        Me.NumericUpDown_Interval.Location = New System.Drawing.Point(9, 39)
        Me.NumericUpDown_Interval.Maximum = New Decimal(New Integer() {3600, 0, 0, 0})
        Me.NumericUpDown_Interval.Minimum = New Decimal(New Integer() {45, 0, 0, 0})
        Me.NumericUpDown_Interval.Name = "NumericUpDown_Interval"
        Me.NumericUpDown_Interval.Size = New System.Drawing.Size(220, 23)
        Me.NumericUpDown_Interval.TabIndex = 2
        Me.ToolTip_Default.SetToolTip(Me.NumericUpDown_Interval, "状态报告的时间间隔，单位为秒。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "最小间隔 45 秒，最大 3600 秒（1 小时）。")
        Me.NumericUpDown_Interval.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'Label_Interval
        '
        Me.Label_Interval.AutoSize = True
        Me.Label_Interval.Location = New System.Drawing.Point(6, 19)
        Me.Label_Interval.Name = "Label_Interval"
        Me.Label_Interval.Size = New System.Drawing.Size(223, 17)
        Me.Label_Interval.TabIndex = 1
        Me.Label_Interval.Text = "状态报告时间间隔（45 ~ 3600）（秒）"
        '
        'GroupBox_FunctionSwitch
        '
        Me.GroupBox_FunctionSwitch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_FunctionSwitch.Controls.Add(Me.Button_Cancel)
        Me.GroupBox_FunctionSwitch.Controls.Add(Me.Button_Save)
        Me.GroupBox_FunctionSwitch.Controls.Add(Me.CheckBox_EnableAdvVars)
        Me.GroupBox_FunctionSwitch.Controls.Add(Me.CheckBox_EnableStatusReport)
        Me.GroupBox_FunctionSwitch.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox_FunctionSwitch.Name = "GroupBox_FunctionSwitch"
        Me.GroupBox_FunctionSwitch.Size = New System.Drawing.Size(460, 112)
        Me.GroupBox_FunctionSwitch.TabIndex = 0
        Me.GroupBox_FunctionSwitch.TabStop = False
        Me.GroupBox_FunctionSwitch.Text = "功能开关"
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Cancel.Location = New System.Drawing.Point(379, 83)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Button_Cancel.TabIndex = 3
        Me.Button_Cancel.Text = "关闭"
        Me.ToolTip_Default.SetToolTip(Me.Button_Cancel, "放弃设置，关闭。")
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'Button_Save
        '
        Me.Button_Save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Save.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_Save.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Save.Location = New System.Drawing.Point(379, 22)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(75, 23)
        Me.Button_Save.TabIndex = 2
        Me.Button_Save.Text = "保存"
        Me.ToolTip_Default.SetToolTip(Me.Button_Save, "保存设置。")
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'CheckBox_EnableAdvVars
        '
        Me.CheckBox_EnableAdvVars.AutoSize = True
        Me.CheckBox_EnableAdvVars.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_EnableAdvVars.Location = New System.Drawing.Point(9, 50)
        Me.CheckBox_EnableAdvVars.Name = "CheckBox_EnableAdvVars"
        Me.CheckBox_EnableAdvVars.Size = New System.Drawing.Size(129, 22)
        Me.CheckBox_EnableAdvVars.TabIndex = 1
        Me.CheckBox_EnableAdvVars.Text = "允许使用高级变量"
        Me.ToolTip_Default.SetToolTip(Me.CheckBox_EnableAdvVars, "允许使用与直播间状态无关的变量。")
        Me.CheckBox_EnableAdvVars.UseVisualStyleBackColor = True
        '
        'CheckBox_EnableStatusReport
        '
        Me.CheckBox_EnableStatusReport.AutoSize = True
        Me.CheckBox_EnableStatusReport.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_EnableStatusReport.Location = New System.Drawing.Point(9, 22)
        Me.CheckBox_EnableStatusReport.Name = "CheckBox_EnableStatusReport"
        Me.CheckBox_EnableStatusReport.Size = New System.Drawing.Size(105, 22)
        Me.CheckBox_EnableStatusReport.TabIndex = 0
        Me.CheckBox_EnableStatusReport.Text = "启用状态报告"
        Me.ToolTip_Default.SetToolTip(Me.CheckBox_EnableStatusReport, "启动状态报告功能。")
        Me.CheckBox_EnableStatusReport.UseVisualStyleBackColor = True
        '
        'Form_StatusReport
        '
        Me.AcceptButton = Me.Button_Save
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Button_Cancel
        Me.ClientSize = New System.Drawing.Size(484, 272)
        Me.Controls.Add(Me.Panel_AutoScroll)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_StatusReport"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TTSDanmaku 状态报告 - 高级设置"
        Me.Panel_AutoScroll.ResumeLayout(False)
        Me.Panel_AutoScroll.PerformLayout()
        Me.GroupBox_Configurations.ResumeLayout(False)
        Me.GroupBox_Configurations.PerformLayout()
        CType(Me.NumericUpDown_Interval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_FunctionSwitch.ResumeLayout(False)
        Me.GroupBox_FunctionSwitch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_AutoScroll As Windows.Forms.Panel
    Friend WithEvents GroupBox_FunctionSwitch As Windows.Forms.GroupBox
    Friend WithEvents CheckBox_EnableStatusReport As Windows.Forms.CheckBox
    Friend WithEvents Label_Interval As Windows.Forms.Label
    Friend WithEvents NumericUpDown_Interval As Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox_Configurations As Windows.Forms.GroupBox
    Friend WithEvents CheckBox_EnableAdvVars As Windows.Forms.CheckBox
    Friend WithEvents Label_CustomText As Windows.Forms.Label
    Friend WithEvents TextBox_ReportText As Windows.Forms.TextBox
    Friend WithEvents CheckBox_ShowVarsHelp As Windows.Forms.CheckBox
    Friend WithEvents TextBox_VarsHelp As Windows.Forms.TextBox
    Friend WithEvents Button_Save As Windows.Forms.Button
    Friend WithEvents Button_Cancel As Windows.Forms.Button
    Friend WithEvents ToolTip_Default As Windows.Forms.ToolTip
End Class
