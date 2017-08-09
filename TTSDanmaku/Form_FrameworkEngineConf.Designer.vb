<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_FrameworkEngineConf
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_FrameworkEngineConf))
        Me.Label_SpeechSpeed = New System.Windows.Forms.Label()
        Me.ToolTip_Default = New System.Windows.Forms.ToolTip(Me.components)
        Me.NumericUpDown_SpeechSpeed = New System.Windows.Forms.NumericUpDown()
        Me.Label_Warning = New System.Windows.Forms.Label()
        Me.PictureBox_Alert = New System.Windows.Forms.PictureBox()
        Me.Label_SpeechGender = New System.Windows.Forms.Label()
        Me.ComboBox_TTSGender = New System.Windows.Forms.ComboBox()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.Button_OK = New System.Windows.Forms.Button()
        CType(Me.NumericUpDown_SpeechSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Alert, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_SpeechSpeed
        '
        Me.Label_SpeechSpeed.AutoSize = True
        Me.Label_SpeechSpeed.Location = New System.Drawing.Point(12, 9)
        Me.Label_SpeechSpeed.Name = "Label_SpeechSpeed"
        Me.Label_SpeechSpeed.Size = New System.Drawing.Size(57, 17)
        Me.Label_SpeechSpeed.TabIndex = 0
        Me.Label_SpeechSpeed.Text = "TTS 语速"
        '
        'NumericUpDown_SpeechSpeed
        '
        Me.NumericUpDown_SpeechSpeed.Location = New System.Drawing.Point(15, 29)
        Me.NumericUpDown_SpeechSpeed.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NumericUpDown_SpeechSpeed.Minimum = New Decimal(New Integer() {20, 0, 0, -2147483648})
        Me.NumericUpDown_SpeechSpeed.Name = "NumericUpDown_SpeechSpeed"
        Me.NumericUpDown_SpeechSpeed.Size = New System.Drawing.Size(120, 23)
        Me.NumericUpDown_SpeechSpeed.TabIndex = 1
        Me.ToolTip_Default.SetToolTip(Me.NumericUpDown_SpeechSpeed, "设置 TTS 语速，范围从 -20 到 20。")
        '
        'Label_Warning
        '
        Me.Label_Warning.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Warning.Font = New System.Drawing.Font("微软雅黑", 10.0!, System.Drawing.FontStyle.Italic)
        Me.Label_Warning.Location = New System.Drawing.Point(272, 9)
        Me.Label_Warning.Name = "Label_Warning"
        Me.Label_Warning.Size = New System.Drawing.Size(62, 30)
        Me.Label_Warning.TabIndex = 8
        Me.Label_Warning.Text = "警告"
        Me.Label_Warning.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.ToolTip_Default.SetToolTip(Me.Label_Warning, "此处设置仅供高级用户使用，可能会导致插件无法正常工作。")
        '
        'PictureBox_Alert
        '
        Me.PictureBox_Alert.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_Alert.Image = Global.TTSDanmaku.My.Resources.Resources.Network_Warning
        Me.PictureBox_Alert.Location = New System.Drawing.Point(340, 9)
        Me.PictureBox_Alert.Name = "PictureBox_Alert"
        Me.PictureBox_Alert.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox_Alert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Alert.TabIndex = 7
        Me.PictureBox_Alert.TabStop = False
        Me.ToolTip_Default.SetToolTip(Me.PictureBox_Alert, "此处设置仅供高级用户使用，可能会导致插件无法正常工作。")
        '
        'Label_SpeechGender
        '
        Me.Label_SpeechGender.AutoSize = True
        Me.Label_SpeechGender.Location = New System.Drawing.Point(12, 55)
        Me.Label_SpeechGender.Name = "Label_SpeechGender"
        Me.Label_SpeechGender.Size = New System.Drawing.Size(81, 17)
        Me.Label_SpeechGender.TabIndex = 9
        Me.Label_SpeechGender.Text = "TTS 语音性别"
        '
        'ComboBox_TTSGender
        '
        Me.ComboBox_TTSGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_TTSGender.FormattingEnabled = True
        Me.ComboBox_TTSGender.Items.AddRange(New Object() {"女性", "男性"})
        Me.ComboBox_TTSGender.Location = New System.Drawing.Point(15, 75)
        Me.ComboBox_TTSGender.Name = "ComboBox_TTSGender"
        Me.ComboBox_TTSGender.Size = New System.Drawing.Size(120, 25)
        Me.ComboBox_TTSGender.TabIndex = 10
        Me.ToolTip_Default.SetToolTip(Me.ComboBox_TTSGender, "选择语音性别。")
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Cancel.Location = New System.Drawing.Point(297, 226)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Button_Cancel.TabIndex = 12
        Me.Button_Cancel.Text = "取消"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'Button_OK
        '
        Me.Button_OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_OK.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_OK.Location = New System.Drawing.Point(216, 226)
        Me.Button_OK.Name = "Button_OK"
        Me.Button_OK.Size = New System.Drawing.Size(75, 23)
        Me.Button_OK.TabIndex = 11
        Me.Button_OK.Text = "保存"
        Me.Button_OK.UseVisualStyleBackColor = True
        '
        'Form_FrameworkEngineConf
        '
        Me.AcceptButton = Me.Button_OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Button_Cancel
        Me.ClientSize = New System.Drawing.Size(384, 261)
        Me.Controls.Add(Me.Button_Cancel)
        Me.Controls.Add(Me.Button_OK)
        Me.Controls.Add(Me.ComboBox_TTSGender)
        Me.Controls.Add(Me.Label_SpeechGender)
        Me.Controls.Add(Me.Label_Warning)
        Me.Controls.Add(Me.PictureBox_Alert)
        Me.Controls.Add(Me.NumericUpDown_SpeechSpeed)
        Me.Controls.Add(Me.Label_SpeechSpeed)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_FrameworkEngineConf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TTSDanmaku - .NET Framework 框架自带引擎配置"
        CType(Me.NumericUpDown_SpeechSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Alert, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_SpeechSpeed As Windows.Forms.Label
    Friend WithEvents ToolTip_Default As Windows.Forms.ToolTip
    Friend WithEvents NumericUpDown_SpeechSpeed As Windows.Forms.NumericUpDown
    Friend WithEvents Label_Warning As Windows.Forms.Label
    Friend WithEvents PictureBox_Alert As Windows.Forms.PictureBox
    Friend WithEvents Label_SpeechGender As Windows.Forms.Label
    Friend WithEvents ComboBox_TTSGender As Windows.Forms.ComboBox
    Friend WithEvents Button_Cancel As Windows.Forms.Button
    Friend WithEvents Button_OK As Windows.Forms.Button
End Class
