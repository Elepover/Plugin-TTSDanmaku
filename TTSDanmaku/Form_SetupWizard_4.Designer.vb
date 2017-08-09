<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_SetupWizard_4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_SetupWizard_4))
        Me.GroupBox_Steps = New System.Windows.Forms.GroupBox()
        Me.LinkLabel_Exit = New System.Windows.Forms.LinkLabel()
        Me.CheckBox_Finish = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Custom = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Conf = New System.Windows.Forms.CheckBox()
        Me.CheckBox_EnviChk = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Welcome = New System.Windows.Forms.CheckBox()
        Me.GroupBox_Conf = New System.Windows.Forms.GroupBox()
        Me.TextBox_CustomGiftContent = New System.Windows.Forms.TextBox()
        Me.TextBox_CustomDMContent = New System.Windows.Forms.TextBox()
        Me.Label_CustomGiftContent_Header = New System.Windows.Forms.Label()
        Me.Label_CustomDM_Header = New System.Windows.Forms.Label()
        Me.Button_Previous = New System.Windows.Forms.Button()
        Me.Button_Next = New System.Windows.Forms.Button()
        Me.Label_Subtitle = New System.Windows.Forms.Label()
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.PictureBox_OK_2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_OK_1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox_Steps.SuspendLayout()
        Me.GroupBox_Conf.SuspendLayout()
        CType(Me.PictureBox_OK_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_OK_1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox_Steps.TabIndex = 12
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
        Me.CheckBox_Custom.Checked = True
        Me.CheckBox_Custom.CheckState = System.Windows.Forms.CheckState.Indeterminate
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
        Me.CheckBox_Conf.CheckState = System.Windows.Forms.CheckState.Checked
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
        Me.GroupBox_Conf.Controls.Add(Me.PictureBox_OK_2)
        Me.GroupBox_Conf.Controls.Add(Me.PictureBox_OK_1)
        Me.GroupBox_Conf.Controls.Add(Me.TextBox_CustomGiftContent)
        Me.GroupBox_Conf.Controls.Add(Me.TextBox_CustomDMContent)
        Me.GroupBox_Conf.Controls.Add(Me.Label_CustomGiftContent_Header)
        Me.GroupBox_Conf.Controls.Add(Me.Label_CustomDM_Header)
        Me.GroupBox_Conf.Location = New System.Drawing.Point(168, 62)
        Me.GroupBox_Conf.Name = "GroupBox_Conf"
        Me.GroupBox_Conf.Size = New System.Drawing.Size(404, 259)
        Me.GroupBox_Conf.TabIndex = 17
        Me.GroupBox_Conf.TabStop = False
        Me.GroupBox_Conf.Text = "选项"
        '
        'TextBox_CustomGiftContent
        '
        Me.TextBox_CustomGiftContent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_CustomGiftContent.Location = New System.Drawing.Point(6, 88)
        Me.TextBox_CustomGiftContent.Name = "TextBox_CustomGiftContent"
        Me.TextBox_CustomGiftContent.Size = New System.Drawing.Size(359, 23)
        Me.TextBox_CustomGiftContent.TabIndex = 14
        Me.TextBox_CustomGiftContent.Text = "收到来自 $USER 的 $COUNT 个 $GIFT"
        '
        'TextBox_CustomDMContent
        '
        Me.TextBox_CustomDMContent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_CustomDMContent.Location = New System.Drawing.Point(6, 42)
        Me.TextBox_CustomDMContent.Name = "TextBox_CustomDMContent"
        Me.TextBox_CustomDMContent.Size = New System.Drawing.Size(359, 23)
        Me.TextBox_CustomDMContent.TabIndex = 12
        Me.TextBox_CustomDMContent.Text = "$USER 说: $DM"
        '
        'Label_CustomGiftContent_Header
        '
        Me.Label_CustomGiftContent_Header.AutoSize = True
        Me.Label_CustomGiftContent_Header.Location = New System.Drawing.Point(6, 68)
        Me.Label_CustomGiftContent_Header.Name = "Label_CustomGiftContent_Header"
        Me.Label_CustomGiftContent_Header.Size = New System.Drawing.Size(116, 17)
        Me.Label_CustomGiftContent_Header.TabIndex = 13
        Me.Label_CustomGiftContent_Header.Text = "自定义礼物读出内容"
        '
        'Label_CustomDM_Header
        '
        Me.Label_CustomDM_Header.AutoSize = True
        Me.Label_CustomDM_Header.Location = New System.Drawing.Point(6, 22)
        Me.Label_CustomDM_Header.Name = "Label_CustomDM_Header"
        Me.Label_CustomDM_Header.Size = New System.Drawing.Size(116, 17)
        Me.Label_CustomDM_Header.TabIndex = 11
        Me.Label_CustomDM_Header.Text = "自定义弹幕读出内容"
        '
        'Button_Previous
        '
        Me.Button_Previous.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Previous.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Previous.Location = New System.Drawing.Point(416, 327)
        Me.Button_Previous.Name = "Button_Previous"
        Me.Button_Previous.Size = New System.Drawing.Size(75, 23)
        Me.Button_Previous.TabIndex = 13
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
        Me.Button_Next.TabIndex = 14
        Me.Button_Next.Text = "下一步 >"
        Me.Button_Next.UseVisualStyleBackColor = True
        '
        'Label_Subtitle
        '
        Me.Label_Subtitle.AutoSize = True
        Me.Label_Subtitle.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.Label_Subtitle.Location = New System.Drawing.Point(165, 42)
        Me.Label_Subtitle.Name = "Label_Subtitle"
        Me.Label_Subtitle.Size = New System.Drawing.Size(112, 17)
        Me.Label_Subtitle.TabIndex = 16
        Me.Label_Subtitle.Text = "想不到描述了 QAQ"
        '
        'Label_Title
        '
        Me.Label_Title.AutoSize = True
        Me.Label_Title.Font = New System.Drawing.Font("微软雅黑", 17.0!)
        Me.Label_Title.Location = New System.Drawing.Point(163, 12)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(82, 30)
        Me.Label_Title.TabIndex = 15
        Me.Label_Title.Text = "个性化"
        '
        'PictureBox_OK_2
        '
        Me.PictureBox_OK_2.Image = Global.TTSDanmaku.My.Resources.Resources.check_correct
        Me.PictureBox_OK_2.Location = New System.Drawing.Point(371, 88)
        Me.PictureBox_OK_2.Name = "PictureBox_OK_2"
        Me.PictureBox_OK_2.Size = New System.Drawing.Size(23, 23)
        Me.PictureBox_OK_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_OK_2.TabIndex = 15
        Me.PictureBox_OK_2.TabStop = False
        Me.PictureBox_OK_2.Visible = False
        '
        'PictureBox_OK_1
        '
        Me.PictureBox_OK_1.Image = Global.TTSDanmaku.My.Resources.Resources.check_correct
        Me.PictureBox_OK_1.Location = New System.Drawing.Point(371, 42)
        Me.PictureBox_OK_1.Name = "PictureBox_OK_1"
        Me.PictureBox_OK_1.Size = New System.Drawing.Size(23, 23)
        Me.PictureBox_OK_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_OK_1.TabIndex = 15
        Me.PictureBox_OK_1.TabStop = False
        Me.PictureBox_OK_1.Visible = False
        '
        'Form_SetupWizard_4
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
        Me.Name = "Form_SetupWizard_4"
        Me.Opacity = 0.97R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TTSDanmaku 设置向导"
        Me.GroupBox_Steps.ResumeLayout(False)
        Me.GroupBox_Steps.PerformLayout()
        Me.GroupBox_Conf.ResumeLayout(False)
        Me.GroupBox_Conf.PerformLayout()
        CType(Me.PictureBox_OK_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_OK_1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TextBox_CustomGiftContent As Windows.Forms.TextBox
    Friend WithEvents TextBox_CustomDMContent As Windows.Forms.TextBox
    Friend WithEvents Label_CustomGiftContent_Header As Windows.Forms.Label
    Friend WithEvents Label_CustomDM_Header As Windows.Forms.Label
    Friend WithEvents PictureBox_OK_1 As Windows.Forms.PictureBox
    Friend WithEvents PictureBox_OK_2 As Windows.Forms.PictureBox
End Class
