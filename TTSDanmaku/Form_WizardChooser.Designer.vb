<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_WizardChooser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_WizardChooser))
        Me.Label_SelectHead = New System.Windows.Forms.Label()
        Me.Button_Wizard = New System.Windows.Forms.Button()
        Me.Button_Canonical = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label_SelectHead
        '
        Me.Label_SelectHead.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_SelectHead.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.Label_SelectHead.Location = New System.Drawing.Point(12, 9)
        Me.Label_SelectHead.Name = "Label_SelectHead"
        Me.Label_SelectHead.Size = New System.Drawing.Size(460, 25)
        Me.Label_SelectHead.TabIndex = 0
        Me.Label_SelectHead.Text = "选择设置方法"
        Me.Label_SelectHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button_Wizard
        '
        Me.Button_Wizard.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button_Wizard.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Wizard.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.Button_Wizard.Location = New System.Drawing.Point(16, 37)
        Me.Button_Wizard.Name = "Button_Wizard"
        Me.Button_Wizard.Size = New System.Drawing.Size(140, 33)
        Me.Button_Wizard.TabIndex = 1
        Me.Button_Wizard.Text = "设置向导"
        Me.Button_Wizard.UseVisualStyleBackColor = True
        '
        'Button_Canonical
        '
        Me.Button_Canonical.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Canonical.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Canonical.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.Button_Canonical.Location = New System.Drawing.Point(332, 37)
        Me.Button_Canonical.Name = "Button_Canonical"
        Me.Button_Canonical.Size = New System.Drawing.Size(140, 33)
        Me.Button_Canonical.TabIndex = 2
        Me.Button_Canonical.Text = "设置菜单"
        Me.Button_Canonical.UseVisualStyleBackColor = True
        '
        'Form_WizardChooser
        '
        Me.AcceptButton = Me.Button_Canonical
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 82)
        Me.Controls.Add(Me.Button_Canonical)
        Me.Controls.Add(Me.Button_Wizard)
        Me.Controls.Add(Me.Label_SelectHead)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_WizardChooser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "选择设置方法"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label_SelectHead As Windows.Forms.Label
    Friend WithEvents Button_Wizard As Windows.Forms.Button
    Friend WithEvents Button_Canonical As Windows.Forms.Button
End Class
