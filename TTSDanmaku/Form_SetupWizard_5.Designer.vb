<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_SetupWizard_5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_SetupWizard_5))
        Me.GroupBox_Steps = New System.Windows.Forms.GroupBox()
        Me.CheckBox_Finish = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Custom = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Conf = New System.Windows.Forms.CheckBox()
        Me.CheckBox_EnviChk = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Welcome = New System.Windows.Forms.CheckBox()
        Me.Button_Next = New System.Windows.Forms.Button()
        Me.Label_Subtitle = New System.Windows.Forms.Label()
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.GroupBox_Steps.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox_Steps
        '
        Me.GroupBox_Steps.Controls.Add(Me.CheckBox_Finish)
        Me.GroupBox_Steps.Controls.Add(Me.CheckBox_Custom)
        Me.GroupBox_Steps.Controls.Add(Me.CheckBox_Conf)
        Me.GroupBox_Steps.Controls.Add(Me.CheckBox_EnviChk)
        Me.GroupBox_Steps.Controls.Add(Me.CheckBox_Welcome)
        Me.GroupBox_Steps.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.GroupBox_Steps.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox_Steps.Name = "GroupBox_Steps"
        Me.GroupBox_Steps.Size = New System.Drawing.Size(145, 338)
        Me.GroupBox_Steps.TabIndex = 4
        Me.GroupBox_Steps.TabStop = False
        Me.GroupBox_Steps.Text = "进度"
        '
        'CheckBox_Finish
        '
        Me.CheckBox_Finish.AutoSize = True
        Me.CheckBox_Finish.Checked = True
        Me.CheckBox_Finish.CheckState = System.Windows.Forms.CheckState.Checked
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
        Me.CheckBox_Custom.CheckState = System.Windows.Forms.CheckState.Checked
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
        'Button_Next
        '
        Me.Button_Next.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Next.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Next.Location = New System.Drawing.Point(497, 327)
        Me.Button_Next.Name = "Button_Next"
        Me.Button_Next.Size = New System.Drawing.Size(75, 23)
        Me.Button_Next.TabIndex = 7
        Me.Button_Next.Text = "完成"
        Me.Button_Next.UseVisualStyleBackColor = True
        '
        'Label_Subtitle
        '
        Me.Label_Subtitle.AutoSize = True
        Me.Label_Subtitle.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.Label_Subtitle.Location = New System.Drawing.Point(165, 42)
        Me.Label_Subtitle.Name = "Label_Subtitle"
        Me.Label_Subtitle.Size = New System.Drawing.Size(224, 17)
        Me.Label_Subtitle.TabIndex = 6
        Me.Label_Subtitle.Text = "插件所有配置均已完成！请尽情享用吧！"
        '
        'Label_Title
        '
        Me.Label_Title.AutoSize = True
        Me.Label_Title.Font = New System.Drawing.Font("微软雅黑", 17.0!)
        Me.Label_Title.Location = New System.Drawing.Point(163, 12)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(59, 30)
        Me.Label_Title.TabIndex = 5
        Me.Label_Title.Text = "完成"
        '
        'Form_SetupWizard_5
        '
        Me.AcceptButton = Me.Button_Next
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(584, 362)
        Me.Controls.Add(Me.GroupBox_Steps)
        Me.Controls.Add(Me.Button_Next)
        Me.Controls.Add(Me.Label_Subtitle)
        Me.Controls.Add(Me.Label_Title)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_SetupWizard_5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TTSDanmaku 设置向导"
        Me.GroupBox_Steps.ResumeLayout(False)
        Me.GroupBox_Steps.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox_Steps As Windows.Forms.GroupBox
    Friend WithEvents CheckBox_Finish As Windows.Forms.CheckBox
    Friend WithEvents CheckBox_Custom As Windows.Forms.CheckBox
    Friend WithEvents CheckBox_Conf As Windows.Forms.CheckBox
    Friend WithEvents CheckBox_EnviChk As Windows.Forms.CheckBox
    Friend WithEvents CheckBox_Welcome As Windows.Forms.CheckBox
    Friend WithEvents Button_Next As Windows.Forms.Button
    Friend WithEvents Label_Subtitle As Windows.Forms.Label
    Friend WithEvents Label_Title As Windows.Forms.Label
End Class
