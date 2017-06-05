Public Class Form_StatusReport

    ''' <summary>
    ''' 载入配置到控件中
    ''' </summary>
    Private Sub LoadToControl()
        CheckBox_EnableAdvVars.Checked = Settings.Settings.StatusReport_ResolveAdvVars
        CheckBox_EnableStatusReport.Checked = Settings.Settings.StatusReport
        NumericUpDown_Interval.Value = Settings.Settings.StatusReportInterval
        TextBox_ReportText.Text = Settings.Settings.StatusReportContent
    End Sub

    ''' <summary>
    ''' 根据配置状态更新控件样式
    ''' </summary>
    Private Sub UpdateControl()
        If CheckBox_ShowVarsHelp.Checked Then
            Me.Size = New Drawing.Size(500, 480)
        Else
            Me.Size = New Drawing.Size(500, 310)
        End If
        If (NumericUpDown_Interval.Value > 3600) Or (NumericUpDown_Interval.Value < 45) Then
            NumericUpDown_Interval.BackColor = Drawing.Color.Pink
        Else
            NumericUpDown_Interval.BackColor = Drawing.Color.White
        End If

        '检测配置是否不同于控件
        If Not CheckBox_EnableAdvVars.Checked = Settings.Settings.StatusReport_ResolveAdvVars Then
            CheckBox_EnableAdvVars.Font = New Drawing.Font(CheckBox_EnableAdvVars.Font, Drawing.FontStyle.Bold)
        Else
            CheckBox_EnableAdvVars.Font = New Drawing.Font(CheckBox_EnableAdvVars.Font, Drawing.FontStyle.Regular)
        End If
        If Not CheckBox_EnableStatusReport.Checked = Settings.Settings.StatusReport Then
            CheckBox_EnableStatusReport.Font = New Drawing.Font(CheckBox_EnableStatusReport.Font, Drawing.FontStyle.Bold)
        Else
            CheckBox_EnableStatusReport.Font = New Drawing.Font(CheckBox_EnableStatusReport.Font, Drawing.FontStyle.Regular)
        End If
        If Not NumericUpDown_Interval.Value = Settings.Settings.StatusReportInterval Then
            NumericUpDown_Interval.Font = New Drawing.Font(NumericUpDown_Interval.Font, Drawing.FontStyle.Bold)
        Else
            NumericUpDown_Interval.Font = New Drawing.Font(NumericUpDown_Interval.Font, Drawing.FontStyle.Regular)
        End If
        If Not TextBox_ReportText.Text = Settings.Settings.StatusReportContent Then
            TextBox_ReportText.Font = New Drawing.Font(TextBox_ReportText.Font, Drawing.FontStyle.Bold)
        Else
            TextBox_ReportText.Font = New Drawing.Font(TextBox_ReportText.Font, Drawing.FontStyle.Regular)
        End If
    End Sub

    Private Sub Form_StatusReport_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        '重新应用字体
        LoadToControl()
        UpdateControl()
        GroupBox_Configurations.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        GroupBox_FunctionSwitch.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        CheckBox_EnableAdvVars.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        CheckBox_EnableStatusReport.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        CheckBox_ShowVarsHelp.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        Label_CustomText.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        Label_Interval.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        NumericUpDown_Interval.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        Button_Cancel.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        Button_Save.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        TextBox_ReportText.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        TextBox_VarsHelp.Font = New Drawing.Font("Microsoft Yahei UI", 9)
    End Sub

    Private Sub UpdateControl(sender As Object, e As EventArgs) Handles CheckBox_ShowVarsHelp.CheckedChanged, CheckBox_EnableAdvVars.CheckedChanged, CheckBox_EnableStatusReport.CheckedChanged, TextBox_ReportText.TextChanged, NumericUpDown_Interval.ValueChanged
        UpdateControl()
    End Sub

    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        '保存
        Settings.Methods.Initialize()
        Settings.Settings.StatusReport_ResolveAdvVars = CheckBox_EnableAdvVars.Checked
        Settings.Settings.StatusReport = CheckBox_EnableStatusReport.Checked
        If Not ((NumericUpDown_Interval.Value > 3600) Or (NumericUpDown_Interval.Value < 45)) Then
            Settings.Settings.StatusReportInterval = NumericUpDown_Interval.Value
        End If
        Settings.Settings.StatusReportContent = TextBox_ReportText.Text

        Try
            Settings.Methods.SaveSettings()
        Catch ex As Exception
            Statistics.DBG_ErrCount += 1
            Statistics.DBG_LastException = ex
            NBlockMsgBox("保存出差错: " & ex.ToString, MsgBoxStyle.Critical + vbSystemModal + vbOKOnly, "TTSDanmaku 状态报告 - 高级设置")
        End Try
        LoadToControl()
        UpdateControl()
    End Sub

    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Cancel.Click
        Me.Close()
    End Sub
End Class