﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_SetupWizard_3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_SetupWizard_3))
        Me.GroupBox_Steps = New System.Windows.Forms.GroupBox()
        Me.LinkLabel_Exit = New System.Windows.Forms.LinkLabel()
        Me.CheckBox_Finish = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Custom = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Conf = New System.Windows.Forms.CheckBox()
        Me.CheckBox_EnviChk = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Welcome = New System.Windows.Forms.CheckBox()
        Me.GroupBox_Conf = New System.Windows.Forms.GroupBox()
        Me.CheckBox_NoCache = New System.Windows.Forms.CheckBox()
        Me.CheckBox_TTSGifts = New System.Windows.Forms.CheckBox()
        Me.CheckBox_TTSSender = New System.Windows.Forms.CheckBox()
        Me.Button_Previous = New System.Windows.Forms.Button()
        Me.Button_Next = New System.Windows.Forms.Button()
        Me.Label_Subtitle = New System.Windows.Forms.Label()
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.GroupBox_Steps.SuspendLayout()
        Me.GroupBox_Conf.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox_Steps
        '
        Me.GroupBox_Steps.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_Steps.Controls.Add(Me.LinkLabel_Exit)
        Me.GroupBox_Steps.Controls.Add(Me.CheckBox_Finish)
        Me.GroupBox_Steps.Controls.Add(Me.CheckBox_Custom)
        Me.GroupBox_Steps.Controls.Add(Me.CheckBox_Conf)
        Me.GroupBox_Steps.Controls.Add(Me.CheckBox_EnviChk)
        Me.GroupBox_Steps.Controls.Add(Me.CheckBox_Welcome)
        Me.GroupBox_Steps.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.GroupBox_Steps.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox_Steps.Name = "GroupBox_Steps"
        Me.GroupBox_Steps.Size = New System.Drawing.Size(145, 338)
        Me.GroupBox_Steps.TabIndex = 6
        Me.GroupBox_Steps.TabStop = False
        Me.GroupBox_Steps.Text = "进度"
        '
        'LinkLabel_Exit
        '
        Me.LinkLabel_Exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel_Exit.AutoSize = True
        Me.LinkLabel_Exit.Location = New System.Drawing.Point(6, 315)
        Me.LinkLabel_Exit.Name = "LinkLabel_Exit"
        Me.LinkLabel_Exit.Size = New System.Drawing.Size(32, 17)
        Me.LinkLabel_Exit.TabIndex = 5
        Me.LinkLabel_Exit.TabStop = True
        Me.LinkLabel_Exit.Text = "退出"
        '
        'CheckBox_Finish
        '
        Me.CheckBox_Finish.AutoSize = True
        Me.CheckBox_Finish.Enabled = False
        Me.CheckBox_Finish.Location = New System.Drawing.Point(6, 137)
        Me.CheckBox_Finish.Name = "CheckBox_Finish"
        Me.CheckBox_Finish.Size = New System.Drawing.Size(51, 21)
        Me.CheckBox_Finish.TabIndex = 4
        Me.CheckBox_Finish.Text = "完成"
        Me.CheckBox_Finish.UseVisualStyleBackColor = True
        '
        'CheckBox_Custom
        '
        Me.CheckBox_Custom.AutoSize = True
        Me.CheckBox_Custom.Enabled = False
        Me.CheckBox_Custom.Location = New System.Drawing.Point(6, 110)
        Me.CheckBox_Custom.Name = "CheckBox_Custom"
        Me.CheckBox_Custom.Size = New System.Drawing.Size(63, 21)
        Me.CheckBox_Custom.TabIndex = 3
        Me.CheckBox_Custom.Text = "个性化"
        Me.CheckBox_Custom.UseVisualStyleBackColor = True
        '
        'CheckBox_Conf
        '
        Me.CheckBox_Conf.AutoSize = True
        Me.CheckBox_Conf.Checked = True
        Me.CheckBox_Conf.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.CheckBox_Conf.Enabled = False
        Me.CheckBox_Conf.Location = New System.Drawing.Point(6, 83)
        Me.CheckBox_Conf.Name = "CheckBox_Conf"
        Me.CheckBox_Conf.Size = New System.Drawing.Size(75, 21)
        Me.CheckBox_Conf.TabIndex = 2
        Me.CheckBox_Conf.Text = "功能配置"
        Me.CheckBox_Conf.UseVisualStyleBackColor = True
        '
        'CheckBox_EnviChk
        '
        Me.CheckBox_EnviChk.AutoSize = True
        Me.CheckBox_EnviChk.Checked = True
        Me.CheckBox_EnviChk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_EnviChk.Enabled = False
        Me.CheckBox_EnviChk.Location = New System.Drawing.Point(6, 56)
        Me.CheckBox_EnviChk.Name = "CheckBox_EnviChk"
        Me.CheckBox_EnviChk.Size = New System.Drawing.Size(75, 21)
        Me.CheckBox_EnviChk.TabIndex = 1
        Me.CheckBox_EnviChk.Text = "环境检查"
        Me.CheckBox_EnviChk.UseVisualStyleBackColor = True
        '
        'CheckBox_Welcome
        '
        Me.CheckBox_Welcome.AutoSize = True
        Me.CheckBox_Welcome.Checked = True
        Me.CheckBox_Welcome.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_Welcome.Enabled = False
        Me.CheckBox_Welcome.Location = New System.Drawing.Point(6, 29)
        Me.CheckBox_Welcome.Name = "CheckBox_Welcome"
        Me.CheckBox_Welcome.Size = New System.Drawing.Size(51, 21)
        Me.CheckBox_Welcome.TabIndex = 0
        Me.CheckBox_Welcome.Text = "欢迎"
        Me.CheckBox_Welcome.UseVisualStyleBackColor = True
        '
        'GroupBox_Conf
        '
        Me.GroupBox_Conf.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_Conf.Controls.Add(Me.CheckBox_NoCache)
        Me.GroupBox_Conf.Controls.Add(Me.CheckBox_TTSGifts)
        Me.GroupBox_Conf.Controls.Add(Me.CheckBox_TTSSender)
        Me.GroupBox_Conf.Location = New System.Drawing.Point(168, 79)
        Me.GroupBox_Conf.Name = "GroupBox_Conf"
        Me.GroupBox_Conf.Size = New System.Drawing.Size(404, 242)
        Me.GroupBox_Conf.TabIndex = 11
        Me.GroupBox_Conf.TabStop = False
        Me.GroupBox_Conf.Text = "选项"
        '
        'CheckBox_NoCache
        '
        Me.CheckBox_NoCache.AutoSize = True
        Me.CheckBox_NoCache.Checked = True
        Me.CheckBox_NoCache.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_NoCache.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_NoCache.Location = New System.Drawing.Point(6, 78)
        Me.CheckBox_NoCache.Name = "CheckBox_NoCache"
        Me.CheckBox_NoCache.Size = New System.Drawing.Size(134, 22)
        Me.CheckBox_NoCache.TabIndex = 7
        Me.CheckBox_NoCache.Text = "自动清理 TTS 缓存"
        Me.CheckBox_NoCache.UseVisualStyleBackColor = True
        '
        'CheckBox_TTSGifts
        '
        Me.CheckBox_TTSGifts.AutoSize = True
        Me.CheckBox_TTSGifts.Checked = True
        Me.CheckBox_TTSGifts.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_TTSGifts.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_TTSGifts.Location = New System.Drawing.Point(6, 50)
        Me.CheckBox_TTSGifts.Name = "CheckBox_TTSGifts"
        Me.CheckBox_TTSGifts.Size = New System.Drawing.Size(117, 22)
        Me.CheckBox_TTSGifts.TabIndex = 6
        Me.CheckBox_TTSGifts.Text = "读出收到的礼物"
        Me.CheckBox_TTSGifts.UseVisualStyleBackColor = True
        '
        'CheckBox_TTSSender
        '
        Me.CheckBox_TTSSender.AutoSize = True
        Me.CheckBox_TTSSender.Checked = True
        Me.CheckBox_TTSSender.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_TTSSender.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox_TTSSender.Location = New System.Drawing.Point(6, 22)
        Me.CheckBox_TTSSender.Name = "CheckBox_TTSSender"
        Me.CheckBox_TTSSender.Size = New System.Drawing.Size(117, 22)
        Me.CheckBox_TTSSender.TabIndex = 5
        Me.CheckBox_TTSSender.Text = "读出弹幕发送者"
        Me.CheckBox_TTSSender.UseVisualStyleBackColor = True
        '
        'Button_Previous
        '
        Me.Button_Previous.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Previous.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Previous.Location = New System.Drawing.Point(416, 327)
        Me.Button_Previous.Name = "Button_Previous"
        Me.Button_Previous.Size = New System.Drawing.Size(75, 23)
        Me.Button_Previous.TabIndex = 7
        Me.Button_Previous.Text = "< 上一步"
        Me.Button_Previous.UseVisualStyleBackColor = True
        '
        'Button_Next
        '
        Me.Button_Next.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Next.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Next.Location = New System.Drawing.Point(497, 327)
        Me.Button_Next.Name = "Button_Next"
        Me.Button_Next.Size = New System.Drawing.Size(75, 23)
        Me.Button_Next.TabIndex = 8
        Me.Button_Next.Text = "下一步 >"
        Me.Button_Next.UseVisualStyleBackColor = True
        '
        'Label_Subtitle
        '
        Me.Label_Subtitle.AutoSize = True
        Me.Label_Subtitle.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.Label_Subtitle.Location = New System.Drawing.Point(165, 42)
        Me.Label_Subtitle.Name = "Label_Subtitle"
        Me.Label_Subtitle.Size = New System.Drawing.Size(282, 34)
        Me.Label_Subtitle.TabIndex = 10
        Me.Label_Subtitle.Text = "按您的意愿调节功能开关。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "其余高级设置可在配置完成后于""管理""菜单中调节。"
        '
        'Label_Title
        '
        Me.Label_Title.AutoSize = True
        Me.Label_Title.Font = New System.Drawing.Font("微软雅黑", 17.0!)
        Me.Label_Title.Location = New System.Drawing.Point(163, 12)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(105, 30)
        Me.Label_Title.TabIndex = 9
        Me.Label_Title.Text = "功能配置"
        '
        'Form_SetupWizard_3
        '
        Me.AcceptButton = Me.Button_Next
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(584, 362)
        Me.Controls.Add(Me.GroupBox_Steps)
        Me.Controls.Add(Me.GroupBox_Conf)
        Me.Controls.Add(Me.Button_Previous)
        Me.Controls.Add(Me.Button_Next)
        Me.Controls.Add(Me.Label_Subtitle)
        Me.Controls.Add(Me.Label_Title)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_SetupWizard_3"
        Me.Opacity = 0.97R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TTSDanmaku 设置向导"
        Me.GroupBox_Steps.ResumeLayout(False)
        Me.GroupBox_Steps.PerformLayout()
        Me.GroupBox_Conf.ResumeLayout(False)
        Me.GroupBox_Conf.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox_Steps As Windows.Forms.GroupBox
    Friend WithEvents LinkLabel_Exit As Windows.Forms.LinkLabel
    Friend WithEvents CheckBox_Finish As Windows.Forms.CheckBox
    Friend WithEvents CheckBox_Custom As Windows.Forms.CheckBox
    Friend WithEvents CheckBox_Conf As Windows.Forms.CheckBox
    Friend WithEvents CheckBox_EnviChk As Windows.Forms.CheckBox
    Friend WithEvents CheckBox_Welcome As Windows.Forms.CheckBox
    Friend WithEvents GroupBox_Conf As Windows.Forms.GroupBox
    Friend WithEvents Button_Previous As Windows.Forms.Button
    Friend WithEvents Button_Next As Windows.Forms.Button
    Friend WithEvents Label_Subtitle As Windows.Forms.Label
    Friend WithEvents Label_Title As Windows.Forms.Label
    Friend WithEvents CheckBox_NoCache As Windows.Forms.CheckBox
    Friend WithEvents CheckBox_TTSGifts As Windows.Forms.CheckBox
    Friend WithEvents CheckBox_TTSSender As Windows.Forms.CheckBox
End Class
