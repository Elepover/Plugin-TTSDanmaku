<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_SpeakAnything
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_SpeakAnything))
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.Label_EnterText = New System.Windows.Forms.Label()
        Me.TextBox_Text = New System.Windows.Forms.TextBox()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.Button_SpeakOut = New System.Windows.Forms.Button()
        Me.TextBox_Log = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label_Title
        '
        Me.Label_Title.AutoSize = True
        Me.Label_Title.Font = New System.Drawing.Font("微软雅黑", 13.0!)
        Me.Label_Title.Location = New System.Drawing.Point(12, 9)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(74, 24)
        Me.Label_Title.TabIndex = 0
        Me.Label_Title.Text = "TTSGen"
        '
        'Label_EnterText
        '
        Me.Label_EnterText.AutoSize = True
        Me.Label_EnterText.Location = New System.Drawing.Point(13, 33)
        Me.Label_EnterText.Name = "Label_EnterText"
        Me.Label_EnterText.Size = New System.Drawing.Size(143, 17)
        Me.Label_EnterText.TabIndex = 1
        Me.Label_EnterText.Text = "Enter Target Text Here:"
        '
        'TextBox_Text
        '
        Me.TextBox_Text.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Text.Location = New System.Drawing.Point(16, 53)
        Me.TextBox_Text.Multiline = True
        Me.TextBox_Text.Name = "TextBox_Text"
        Me.TextBox_Text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox_Text.Size = New System.Drawing.Size(656, 136)
        Me.TextBox_Text.TabIndex = 2
        '
        'Button_Close
        '
        Me.Button_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Close.Location = New System.Drawing.Point(597, 326)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(75, 23)
        Me.Button_Close.TabIndex = 3
        Me.Button_Close.Text = "&Exit"
        Me.Button_Close.UseVisualStyleBackColor = True
        '
        'Button_SpeakOut
        '
        Me.Button_SpeakOut.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_SpeakOut.Location = New System.Drawing.Point(16, 195)
        Me.Button_SpeakOut.Name = "Button_SpeakOut"
        Me.Button_SpeakOut.Size = New System.Drawing.Size(128, 23)
        Me.Button_SpeakOut.TabIndex = 5
        Me.Button_SpeakOut.Text = "&Speak Out"
        Me.Button_SpeakOut.UseVisualStyleBackColor = True
        '
        'TextBox_Log
        '
        Me.TextBox_Log.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Log.Location = New System.Drawing.Point(16, 224)
        Me.TextBox_Log.Multiline = True
        Me.TextBox_Log.Name = "TextBox_Log"
        Me.TextBox_Log.ReadOnly = True
        Me.TextBox_Log.Size = New System.Drawing.Size(262, 125)
        Me.TextBox_Log.TabIndex = 6
        '
        'Form_SpeakAnything
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 361)
        Me.Controls.Add(Me.TextBox_Log)
        Me.Controls.Add(Me.Button_SpeakOut)
        Me.Controls.Add(Me.Button_Close)
        Me.Controls.Add(Me.TextBox_Text)
        Me.Controls.Add(Me.Label_EnterText)
        Me.Controls.Add(Me.Label_Title)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(700, 400)
        Me.Name = "Form_SpeakAnything"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hey, could you please speak anything?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Title As Windows.Forms.Label
    Friend WithEvents Label_EnterText As Windows.Forms.Label
    Friend WithEvents TextBox_Text As Windows.Forms.TextBox
    Friend WithEvents Button_Close As Windows.Forms.Button
    Friend WithEvents Button_SpeakOut As Windows.Forms.Button
    Friend WithEvents TextBox_Log As Windows.Forms.TextBox
End Class
