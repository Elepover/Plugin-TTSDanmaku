<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ProxySettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_ProxySettings))
        Me.ToolTip_Default = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox_Alert = New System.Windows.Forms.PictureBox()
        Me.TextBox_ProxyServer_IP = New System.Windows.Forms.TextBox()
        Me.TextBox_ProxyServer_Port = New System.Windows.Forms.TextBox()
        Me.TextBox_ProxyServer_Username = New System.Windows.Forms.TextBox()
        Me.TextBox_ProxyServer_Password = New System.Windows.Forms.TextBox()
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.GroupBox_ProxySettings = New System.Windows.Forms.GroupBox()
        Me.Label_ProxyServer_Password = New System.Windows.Forms.Label()
        Me.Label_ProxyServer_Username = New System.Windows.Forms.Label()
        Me.Label_ProxyServer_Port = New System.Windows.Forms.Label()
        Me.Label_ProxyServer = New System.Windows.Forms.Label()
        Me.GroupBox_Etc = New System.Windows.Forms.GroupBox()
        Me.GroupBox_GoogleTTS = New System.Windows.Forms.GroupBox()
        Me.RadioButton_GoogleCN = New System.Windows.Forms.RadioButton()
        Me.RadioButton_GoogleGlobal = New System.Windows.Forms.RadioButton()
        Me.GroupBox_Security = New System.Windows.Forms.GroupBox()
        Me.RadioButton_HTTP = New System.Windows.Forms.RadioButton()
        Me.RadioButton_HTTPS = New System.Windows.Forms.RadioButton()
        Me.Button_OK = New System.Windows.Forms.Button()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.Label_Warning = New System.Windows.Forms.Label()
        CType(Me.PictureBox_Alert, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_ProxySettings.SuspendLayout()
        Me.GroupBox_Etc.SuspendLayout()
        Me.GroupBox_GoogleTTS.SuspendLayout()
        Me.GroupBox_Security.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox_Alert
        '
        Me.PictureBox_Alert.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_Alert.Image = Global.TTSDanmaku.My.Resources.Resources.Network_Warning
        Me.PictureBox_Alert.Location = New System.Drawing.Point(540, 12)
        Me.PictureBox_Alert.Name = "PictureBox_Alert"
        Me.PictureBox_Alert.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox_Alert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Alert.TabIndex = 0
        Me.PictureBox_Alert.TabStop = False
        Me.ToolTip_Default.SetToolTip(Me.PictureBox_Alert, "此处设置仅供高级用户使用，可能会导致插件无法正常工作。")
        '
        'TextBox_ProxyServer_IP
        '
        Me.TextBox_ProxyServer_IP.Location = New System.Drawing.Point(9, 39)
        Me.TextBox_ProxyServer_IP.Name = "TextBox_ProxyServer_IP"
        Me.TextBox_ProxyServer_IP.Size = New System.Drawing.Size(235, 23)
        Me.TextBox_ProxyServer_IP.TabIndex = 1
        Me.ToolTip_Default.SetToolTip(Me.TextBox_ProxyServer_IP, "HTTP 代理服务器的 IP 地址")
        '
        'TextBox_ProxyServer_Port
        '
        Me.TextBox_ProxyServer_Port.Location = New System.Drawing.Point(9, 85)
        Me.TextBox_ProxyServer_Port.Name = "TextBox_ProxyServer_Port"
        Me.TextBox_ProxyServer_Port.Size = New System.Drawing.Size(235, 23)
        Me.TextBox_ProxyServer_Port.TabIndex = 3
        Me.ToolTip_Default.SetToolTip(Me.TextBox_ProxyServer_Port, "HTTP 代理服务器的 代理端口")
        '
        'TextBox_ProxyServer_Username
        '
        Me.TextBox_ProxyServer_Username.Enabled = False
        Me.TextBox_ProxyServer_Username.Location = New System.Drawing.Point(9, 131)
        Me.TextBox_ProxyServer_Username.Name = "TextBox_ProxyServer_Username"
        Me.TextBox_ProxyServer_Username.Size = New System.Drawing.Size(235, 23)
        Me.TextBox_ProxyServer_Username.TabIndex = 5
        Me.ToolTip_Default.SetToolTip(Me.TextBox_ProxyServer_Username, "HTTP 代理服务器的 代理用户名")
        '
        'TextBox_ProxyServer_Password
        '
        Me.TextBox_ProxyServer_Password.Enabled = False
        Me.TextBox_ProxyServer_Password.Location = New System.Drawing.Point(9, 177)
        Me.TextBox_ProxyServer_Password.Name = "TextBox_ProxyServer_Password"
        Me.TextBox_ProxyServer_Password.Size = New System.Drawing.Size(235, 23)
        Me.TextBox_ProxyServer_Password.TabIndex = 7
        Me.ToolTip_Default.SetToolTip(Me.TextBox_ProxyServer_Password, "HTTP 代理服务器的密码" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "「！」注意：您的代理密码将以明文形式存储于本地计算机中，请注意密码安全。")
        Me.TextBox_ProxyServer_Password.UseSystemPasswordChar = True
        '
        'Label_Title
        '
        Me.Label_Title.AutoSize = True
        Me.Label_Title.Font = New System.Drawing.Font("微软雅黑", 17.0!)
        Me.Label_Title.Location = New System.Drawing.Point(12, 12)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(105, 30)
        Me.Label_Title.TabIndex = 1
        Me.Label_Title.Text = "网络设置"
        '
        'GroupBox_ProxySettings
        '
        Me.GroupBox_ProxySettings.Controls.Add(Me.TextBox_ProxyServer_Password)
        Me.GroupBox_ProxySettings.Controls.Add(Me.Label_ProxyServer_Password)
        Me.GroupBox_ProxySettings.Controls.Add(Me.TextBox_ProxyServer_Username)
        Me.GroupBox_ProxySettings.Controls.Add(Me.Label_ProxyServer_Username)
        Me.GroupBox_ProxySettings.Controls.Add(Me.TextBox_ProxyServer_Port)
        Me.GroupBox_ProxySettings.Controls.Add(Me.Label_ProxyServer_Port)
        Me.GroupBox_ProxySettings.Controls.Add(Me.TextBox_ProxyServer_IP)
        Me.GroupBox_ProxySettings.Controls.Add(Me.Label_ProxyServer)
        Me.GroupBox_ProxySettings.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.GroupBox_ProxySettings.Location = New System.Drawing.Point(17, 50)
        Me.GroupBox_ProxySettings.Name = "GroupBox_ProxySettings"
        Me.GroupBox_ProxySettings.Size = New System.Drawing.Size(250, 212)
        Me.GroupBox_ProxySettings.TabIndex = 2
        Me.GroupBox_ProxySettings.TabStop = False
        Me.GroupBox_ProxySettings.Text = "HTTP 代理设置"
        '
        'Label_ProxyServer_Password
        '
        Me.Label_ProxyServer_Password.AutoSize = True
        Me.Label_ProxyServer_Password.Location = New System.Drawing.Point(6, 157)
        Me.Label_ProxyServer_Password.Name = "Label_ProxyServer_Password"
        Me.Label_ProxyServer_Password.Size = New System.Drawing.Size(72, 17)
        Me.Label_ProxyServer_Password.TabIndex = 6
        Me.Label_ProxyServer_Password.Text = "代理密码 [!]"
        '
        'Label_ProxyServer_Username
        '
        Me.Label_ProxyServer_Username.AutoSize = True
        Me.Label_ProxyServer_Username.Location = New System.Drawing.Point(6, 111)
        Me.Label_ProxyServer_Username.Name = "Label_ProxyServer_Username"
        Me.Label_ProxyServer_Username.Size = New System.Drawing.Size(68, 17)
        Me.Label_ProxyServer_Username.TabIndex = 4
        Me.Label_ProxyServer_Username.Text = "代理用户名"
        '
        'Label_ProxyServer_Port
        '
        Me.Label_ProxyServer_Port.AutoSize = True
        Me.Label_ProxyServer_Port.Location = New System.Drawing.Point(6, 65)
        Me.Label_ProxyServer_Port.Name = "Label_ProxyServer_Port"
        Me.Label_ProxyServer_Port.Size = New System.Drawing.Size(92, 17)
        Me.Label_ProxyServer_Port.TabIndex = 2
        Me.Label_ProxyServer_Port.Text = "代理服务器端口"
        '
        'Label_ProxyServer
        '
        Me.Label_ProxyServer.AutoSize = True
        Me.Label_ProxyServer.Location = New System.Drawing.Point(6, 19)
        Me.Label_ProxyServer.Name = "Label_ProxyServer"
        Me.Label_ProxyServer.Size = New System.Drawing.Size(83, 17)
        Me.Label_ProxyServer.TabIndex = 0
        Me.Label_ProxyServer.Text = "代理服务器 IP"
        '
        'GroupBox_Etc
        '
        Me.GroupBox_Etc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_Etc.Controls.Add(Me.GroupBox_GoogleTTS)
        Me.GroupBox_Etc.Controls.Add(Me.GroupBox_Security)
        Me.GroupBox_Etc.Location = New System.Drawing.Point(273, 50)
        Me.GroupBox_Etc.Name = "GroupBox_Etc"
        Me.GroupBox_Etc.Size = New System.Drawing.Size(299, 212)
        Me.GroupBox_Etc.TabIndex = 3
        Me.GroupBox_Etc.TabStop = False
        Me.GroupBox_Etc.Text = "杂项设置"
        '
        'GroupBox_GoogleTTS
        '
        Me.GroupBox_GoogleTTS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_GoogleTTS.Controls.Add(Me.RadioButton_GoogleCN)
        Me.GroupBox_GoogleTTS.Controls.Add(Me.RadioButton_GoogleGlobal)
        Me.GroupBox_GoogleTTS.Location = New System.Drawing.Point(6, 114)
        Me.GroupBox_GoogleTTS.Name = "GroupBox_GoogleTTS"
        Me.GroupBox_GoogleTTS.Size = New System.Drawing.Size(287, 86)
        Me.GroupBox_GoogleTTS.TabIndex = 1
        Me.GroupBox_GoogleTTS.TabStop = False
        Me.GroupBox_GoogleTTS.Text = "Google TTS 服务器"
        '
        'RadioButton_GoogleCN
        '
        Me.RadioButton_GoogleCN.AutoSize = True
        Me.RadioButton_GoogleCN.Checked = True
        Me.RadioButton_GoogleCN.Location = New System.Drawing.Point(6, 49)
        Me.RadioButton_GoogleCN.Name = "RadioButton_GoogleCN"
        Me.RadioButton_GoogleCN.Size = New System.Drawing.Size(165, 21)
        Me.RadioButton_GoogleCN.TabIndex = 1
        Me.RadioButton_GoogleCN.TabStop = True
        Me.RadioButton_GoogleCN.Text = "使用 translate.google.cn"
        Me.RadioButton_GoogleCN.UseVisualStyleBackColor = True
        '
        'RadioButton_GoogleGlobal
        '
        Me.RadioButton_GoogleGlobal.AutoSize = True
        Me.RadioButton_GoogleGlobal.Location = New System.Drawing.Point(6, 22)
        Me.RadioButton_GoogleGlobal.Name = "RadioButton_GoogleGlobal"
        Me.RadioButton_GoogleGlobal.Size = New System.Drawing.Size(280, 21)
        Me.RadioButton_GoogleGlobal.TabIndex = 0
        Me.RadioButton_GoogleGlobal.Text = "使用 translate.google.com - 可能需要 ladder"
        Me.RadioButton_GoogleGlobal.UseVisualStyleBackColor = True
        '
        'GroupBox_Security
        '
        Me.GroupBox_Security.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_Security.Controls.Add(Me.RadioButton_HTTP)
        Me.GroupBox_Security.Controls.Add(Me.RadioButton_HTTPS)
        Me.GroupBox_Security.Location = New System.Drawing.Point(6, 22)
        Me.GroupBox_Security.Name = "GroupBox_Security"
        Me.GroupBox_Security.Size = New System.Drawing.Size(287, 86)
        Me.GroupBox_Security.TabIndex = 0
        Me.GroupBox_Security.TabStop = False
        Me.GroupBox_Security.Text = "安全性"
        '
        'RadioButton_HTTP
        '
        Me.RadioButton_HTTP.AutoSize = True
        Me.RadioButton_HTTP.Location = New System.Drawing.Point(6, 49)
        Me.RadioButton_HTTP.Name = "RadioButton_HTTP"
        Me.RadioButton_HTTP.Size = New System.Drawing.Size(84, 21)
        Me.RadioButton_HTTP.TabIndex = 1
        Me.RadioButton_HTTP.Text = "使用 HTTP"
        Me.RadioButton_HTTP.UseVisualStyleBackColor = True
        '
        'RadioButton_HTTPS
        '
        Me.RadioButton_HTTPS.AutoSize = True
        Me.RadioButton_HTTPS.Checked = True
        Me.RadioButton_HTTPS.Location = New System.Drawing.Point(6, 22)
        Me.RadioButton_HTTPS.Name = "RadioButton_HTTPS"
        Me.RadioButton_HTTPS.Size = New System.Drawing.Size(128, 21)
        Me.RadioButton_HTTPS.TabIndex = 0
        Me.RadioButton_HTTPS.TabStop = True
        Me.RadioButton_HTTPS.Text = "使用 HTTPS - 推荐"
        Me.RadioButton_HTTPS.UseVisualStyleBackColor = True
        '
        'Button_OK
        '
        Me.Button_OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_OK.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_OK.Location = New System.Drawing.Point(416, 268)
        Me.Button_OK.Name = "Button_OK"
        Me.Button_OK.Size = New System.Drawing.Size(75, 23)
        Me.Button_OK.TabIndex = 4
        Me.Button_OK.Text = "保存"
        Me.Button_OK.UseVisualStyleBackColor = True
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Cancel.Location = New System.Drawing.Point(497, 268)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Button_Cancel.TabIndex = 5
        Me.Button_Cancel.Text = "取消"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'Label_Warning
        '
        Me.Label_Warning.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Warning.Font = New System.Drawing.Font("微软雅黑", 10.0!, System.Drawing.FontStyle.Italic)
        Me.Label_Warning.Location = New System.Drawing.Point(472, 12)
        Me.Label_Warning.Name = "Label_Warning"
        Me.Label_Warning.Size = New System.Drawing.Size(62, 30)
        Me.Label_Warning.TabIndex = 6
        Me.Label_Warning.Text = "警告"
        Me.Label_Warning.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Form_ProxySettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(584, 297)
        Me.Controls.Add(Me.Label_Warning)
        Me.Controls.Add(Me.Button_Cancel)
        Me.Controls.Add(Me.Button_OK)
        Me.Controls.Add(Me.GroupBox_Etc)
        Me.Controls.Add(Me.GroupBox_ProxySettings)
        Me.Controls.Add(Me.Label_Title)
        Me.Controls.Add(Me.PictureBox_Alert)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_ProxySettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TTSDanmaku - 网络设置"
        CType(Me.PictureBox_Alert, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_ProxySettings.ResumeLayout(False)
        Me.GroupBox_ProxySettings.PerformLayout()
        Me.GroupBox_Etc.ResumeLayout(False)
        Me.GroupBox_GoogleTTS.ResumeLayout(False)
        Me.GroupBox_GoogleTTS.PerformLayout()
        Me.GroupBox_Security.ResumeLayout(False)
        Me.GroupBox_Security.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox_Alert As Windows.Forms.PictureBox
    Friend WithEvents ToolTip_Default As Windows.Forms.ToolTip
    Friend WithEvents Label_Title As Windows.Forms.Label
    Friend WithEvents GroupBox_ProxySettings As Windows.Forms.GroupBox
    Friend WithEvents Label_ProxyServer As Windows.Forms.Label
    Friend WithEvents TextBox_ProxyServer_Port As Windows.Forms.TextBox
    Friend WithEvents Label_ProxyServer_Port As Windows.Forms.Label
    Friend WithEvents TextBox_ProxyServer_IP As Windows.Forms.TextBox
    Friend WithEvents TextBox_ProxyServer_Password As Windows.Forms.TextBox
    Friend WithEvents Label_ProxyServer_Password As Windows.Forms.Label
    Friend WithEvents TextBox_ProxyServer_Username As Windows.Forms.TextBox
    Friend WithEvents Label_ProxyServer_Username As Windows.Forms.Label
    Friend WithEvents GroupBox_Etc As Windows.Forms.GroupBox
    Friend WithEvents GroupBox_Security As Windows.Forms.GroupBox
    Friend WithEvents RadioButton_HTTP As Windows.Forms.RadioButton
    Friend WithEvents RadioButton_HTTPS As Windows.Forms.RadioButton
    Friend WithEvents GroupBox_GoogleTTS As Windows.Forms.GroupBox
    Friend WithEvents RadioButton_GoogleGlobal As Windows.Forms.RadioButton
    Friend WithEvents RadioButton_GoogleCN As Windows.Forms.RadioButton
    Friend WithEvents Button_OK As Windows.Forms.Button
    Friend WithEvents Button_Cancel As Windows.Forms.Button
    Friend WithEvents Label_Warning As Windows.Forms.Label
End Class
