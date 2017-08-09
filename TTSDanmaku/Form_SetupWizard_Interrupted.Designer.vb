<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_SetupWizard_Interrupted
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_SetupWizard_Interrupted))
        Me.Button_Next = New System.Windows.Forms.Button()
        Me.Label_Subtitle = New System.Windows.Forms.Label()
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button_Next
        '
        Me.Button_Next.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Next.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Next.Location = New System.Drawing.Point(497, 327)
        Me.Button_Next.Name = "Button_Next"
        Me.Button_Next.Size = New System.Drawing.Size(75, 23)
        Me.Button_Next.TabIndex = 7
        Me.Button_Next.Text = "退出"
        Me.Button_Next.UseVisualStyleBackColor = True
        '
        'Label_Subtitle
        '
        Me.Label_Subtitle.AutoSize = True
        Me.Label_Subtitle.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.Label_Subtitle.Location = New System.Drawing.Point(14, 39)
        Me.Label_Subtitle.Name = "Label_Subtitle"
        Me.Label_Subtitle.Size = New System.Drawing.Size(224, 34)
        Me.Label_Subtitle.TabIndex = 6
        Me.Label_Subtitle.Text = "配置过程中出现错误，向导被提前结束。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "没有应用任何更改到插件上。"
        '
        'Label_Title
        '
        Me.Label_Title.AutoSize = True
        Me.Label_Title.Font = New System.Drawing.Font("微软雅黑", 17.0!)
        Me.Label_Title.Location = New System.Drawing.Point(12, 9)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(59, 30)
        Me.Label_Title.TabIndex = 5
        Me.Label_Title.Text = "中断"
        '
        'Form_SetupWizard_Interrupted
        '
        Me.AcceptButton = Me.Button_Next
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(584, 362)
        Me.Controls.Add(Me.Button_Next)
        Me.Controls.Add(Me.Label_Subtitle)
        Me.Controls.Add(Me.Label_Title)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_SetupWizard_Interrupted"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TTSDanmaku 设置向导"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_Next As Windows.Forms.Button
    Friend WithEvents Label_Subtitle As Windows.Forms.Label
    Friend WithEvents Label_Title As Windows.Forms.Label
End Class
