Public Class TTSDanmakuMgmt
#Region "Including"
    Private Sub Status(status As String, Optional log As Boolean = True)
        StatusLabel_Default.Text = status
        'If log Then TextBox_Stats.AppendText(status & vbCrLf)
        System.Windows.Forms.Application.DoEvents()
        If Me.Visible Then Threading.Thread.Sleep(2) '假装处理很快
    End Sub

    Public Function CheckIfLegal_DM()
        '检查弹幕内容中有无礼物变量
        If TextBox_CustomDMContent.Text.Contains("$GIFT") Then
            TextBox_CustomDMContent.BackColor = Drawing.Color.Pink
            Return True
        Else
            TextBox_CustomDMContent.BackColor = Drawing.Color.LightGreen
            Return False
        End If
        If TextBox_CustomDMContent.Text.Contains("$COUNT") Then
            TextBox_CustomDMContent.BackColor = Drawing.Color.Pink
            Return True
        Else
            TextBox_CustomDMContent.BackColor = Drawing.Color.LightGreen
            Return False
        End If
    End Function

    Public Function CheckIfLegal_GIFT()
        '检查礼物内容中有无弹幕变量
        If TextBox_CustomGiftContent.Text.Contains("$DM") Then
            TextBox_CustomGiftContent.BackColor = Drawing.Color.Pink
            Return True
        Else
            TextBox_CustomGiftContent.BackColor = Drawing.Color.LightGreen
            Return False
        End If
    End Function

    Private Sub UpdateControl()
        Status("载入...", False)

        If Not CheckBox_TTSDebug.Checked = Settings.Settings.DebugMode Then
            CheckBox_TTSDebug.Font = New Drawing.Font(CheckBox_TTSDebug.Font, Drawing.FontStyle.Bold)
        Else
            CheckBox_TTSDebug.Font = New Drawing.Font(CheckBox_TTSDebug.Font, Drawing.FontStyle.Regular)
        End If

        If Not CheckBox_TTSGifts.Checked = Settings.Settings.TTSGiftsReceived Then
            CheckBox_TTSGifts.Font = New Drawing.Font(CheckBox_TTSGifts.Font, Drawing.FontStyle.Bold)
        Else
            CheckBox_TTSGifts.Font = New Drawing.Font(CheckBox_TTSGifts.Font, Drawing.FontStyle.Regular)
        End If

        If Not CheckBox_TTSSender.Checked = Settings.Settings.TTSDanmakuSender Then
            CheckBox_TTSSender.Font = New Drawing.Font(CheckBox_TTSSender.Font, Drawing.FontStyle.Bold)
        Else
            CheckBox_TTSSender.Font = New Drawing.Font(CheckBox_TTSSender.Font, Drawing.FontStyle.Regular)
        End If

        If Not CheckBox_NoCache.Checked = Settings.Settings.AutoClearCache Then
            CheckBox_NoCache.Font = New Drawing.Font(CheckBox_NoCache.Font, Drawing.FontStyle.Bold)
        Else
            CheckBox_NoCache.Font = New Drawing.Font(CheckBox_NoCache.Font, Drawing.FontStyle.Regular)
        End If

        If Not CheckBox_TTSCoolDown.Checked = Settings.Settings.TTSDelayEnabled Then
            CheckBox_TTSCoolDown.Font = New Drawing.Font(CheckBox_TTSCoolDown.Font, Drawing.FontStyle.Bold)
        Else
            CheckBox_TTSCoolDown.Font = New Drawing.Font(CheckBox_TTSCoolDown.Font, Drawing.FontStyle.Regular)
        End If

        If Not NumericUpDown_CoolDownValue.Value = Settings.Settings.TTSDelayValue Then
            NumericUpDown_CoolDownValue.Font = New Drawing.Font(NumericUpDown_CoolDownValue.Font, Drawing.FontStyle.Bold)
        Else
            NumericUpDown_CoolDownValue.Font = New Drawing.Font(NumericUpDown_CoolDownValue.Font, Drawing.FontStyle.Regular)
        End If

        If Not ComboBox_Engine.SelectedIndex = Settings.Settings.Engine Then
            ComboBox_Engine.Font = New Drawing.Font(ComboBox_Engine.Font, Drawing.FontStyle.Bold)
        Else
            ComboBox_Engine.Font = New Drawing.Font(ComboBox_Engine.Font, Drawing.FontStyle.Regular)
        End If

        CheckIfLegal_DM()
        If Not TextBox_CustomDMContent.Text = Settings.Settings.DanmakuText Then
            TextBox_CustomDMContent.Font = New Drawing.Font(TextBox_CustomDMContent.Font, Drawing.FontStyle.Bold)
        Else
            TextBox_CustomDMContent.Font = New Drawing.Font(TextBox_CustomDMContent.Font, Drawing.FontStyle.Regular)
        End If

        CheckIfLegal_GIFT()
        If Not TextBox_CustomGiftContent.Text = Settings.Settings.GiftsText Then
            TextBox_CustomGiftContent.Font = New Drawing.Font(TextBox_CustomGiftContent.Font, Drawing.FontStyle.Bold)
        Else
            TextBox_CustomGiftContent.Font = New Drawing.Font(TextBox_CustomGiftContent.Font, Drawing.FontStyle.Regular)
        End If

        If CheckBox_TTSCoolDown.Checked Then
            NumericUpDown_CoolDownValue.Enabled = True
            Label_Value_Prefix.Enabled = True
        Else
            NumericUpDown_CoolDownValue.Enabled = False
            Label_Value_Prefix.Enabled = False
        End If

        ToolTip_Default.SetToolTip(Button_Apply, "保存设置。" & vbCrLf & vbCrLf & "当前设置文件路径: " & Settings.Vars.ConfigFileName)

        Status("就绪", False)
    End Sub
    Private Sub LoadToControl()
        Status("载入...", False)
        CheckBox_TTSDebug.Checked = Settings.Settings.DebugMode
        CheckBox_TTSGifts.Checked = Settings.Settings.TTSGiftsReceived
        CheckBox_TTSSender.Checked = Settings.Settings.TTSDanmakuSender
        CheckBox_NoCache.Checked = Settings.Settings.AutoClearCache
        CheckBox_TTSCoolDown.Checked = Settings.Settings.TTSDelayEnabled
        NumericUpDown_CoolDownValue.Value = Settings.Settings.TTSDelayValue

        TextBox_CustomDMContent.Text = Settings.Settings.DanmakuText
        TextBox_CustomGiftContent.Text = Settings.Settings.GiftsText

        ComboBox_Engine.SelectedIndex = Settings.Settings.Engine

        TextBox_Stats.Clear()
        TextBox_Stats.AppendText("TTS 播放总尝试次数: " & Statistics.TTS_Total & vbCrLf)
        TextBox_Stats.AppendText("完全播放成功次数: " & Statistics.TTS_Succeeded & vbCrLf)
        TextBox_Stats.AppendText("播放失败/出错次数: " & Statistics.TTS_Failed & vbCrLf)
        TextBox_Stats.AppendText("下载成功次数: " & Statistics.TTS_PlayTries & vbCrLf)
        TextBox_Stats.AppendText("下载失败次数: " & Statistics.TTS_DownloadFail & vbCrLf)
        TextBox_Stats.AppendText("放弃播放的次数: " & Statistics.TTS_Dropped & vbCrLf)
        TextBox_Stats.AppendText("冷却时间激活次数: " & Statistics.TTS_CoolDown & vbCrLf)
        TextBox_Stats.AppendText("冷却时间内尝试播放次数: " & Statistics.TTS_PlayedDuringCoolDown & vbCrLf)
        TextBox_Stats.AppendText("静默模式播放计数: " & Statistics.TTS_Silent & vbCrLf)
        TextBox_Stats.AppendText("房间人数数据接收次数: " & Statistics.DBG_ReceivedRoomCount & vbCrLf)
        TextBox_Stats.AppendText("插件运行过程中出错次数: " & Statistics.DBG_ErrCount & vbCrLf)
        If IsNothing(Statistics.DBG_LastException) Then
            TextBox_Stats.AppendText("最后一次发生的错误: 无" & vbCrLf)
        Else
            TextBox_Stats.AppendText("最后一次发生的错误: " & Statistics.DBG_LastException.ToString & vbCrLf)
        End If
        Status("应用字体...")
        CheckBox_NoCache.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        CheckBox_TTSCoolDown.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        CheckBox_TTSDebug.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        CheckBox_TTSGifts.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        CheckBox_TTSSender.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        TextBox_CustomDMContent.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        TextBox_CustomGiftContent.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        TextBox_Files.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        TextBox_Stats.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        Label_CustomDM_Header.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        Label_CustomGiftContent_Header.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        Label_Value_Prefix.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        Label_SpeechEngine.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        LinkLabel_About.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        LinkLabel_FAQ.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        LinkLabel_Suggestions.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        StatusLabel_Default.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        Button_Apply.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        Button_Close.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        Button_Load.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        Button_DeleteAll.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        Button_Reload.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        NumericUpDown_CoolDownValue.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        ComboBox_Engine.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        GroupBox_Statistics.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        GroupBox_TempMgr.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        GroupBox_TTSOptions.Font = New Drawing.Font("Microsoft Yahei UI", 9)

        Status("就绪", False)
    End Sub
#End Region

    Private Sub Button_Apply_Click(sender As Object, e As EventArgs) Handles Button_Apply.Click
        Status("初始化...", False)
        Settings.Methods.Initialize()
        Settings.Settings.DebugMode = CheckBox_TTSDebug.Checked
        Settings.Settings.TTSDanmakuSender = CheckBox_TTSSender.Checked
        Settings.Settings.TTSGiftsReceived = CheckBox_TTSGifts.Checked
        Settings.Settings.AutoClearCache = CheckBox_NoCache.Checked
        Settings.Settings.TTSDelayEnabled = CheckBox_TTSCoolDown.Checked
        Settings.Settings.TTSDelayValue = NumericUpDown_CoolDownValue.Value
        Settings.Settings.Engine = ComboBox_Engine.SelectedIndex
        '检查自定义字符是否正常
        Dim IllegalVars_DM As Boolean = CheckIfLegal_DM()
        Dim IllegalVars_GIFT As Boolean = CheckIfLegal_GIFT()

        If Not IllegalVars_DM Then
            Settings.Settings.DanmakuText = TextBox_CustomDMContent.Text
        End If
        If Not IllegalVars_GIFT Then
            Settings.Settings.GiftsText = TextBox_CustomGiftContent.Text
        End If

        '停用冷却，如果冷却时间已经关闭。
        If Settings.Settings.TTSDelayEnabled Then Main.IsCoolingDown = False

        Try
            Status("保存...", False)
            Settings.Methods.SaveSettings()
            Status("已保存配置到: " & Settings.Vars.ConfigFileName)
        Catch ex As Exception
            Statistics.DBG_ErrCount += 1
            Statistics.DBG_LastException = ex
            Status("保存错误，请检查权限设置。")
        End Try
        Button_Load.PerformClick()
        LoadToControl()
        UpdateControl()
    End Sub

    Private Sub Button_Load_Click(sender As Object, e As EventArgs) Handles Button_Load.Click
        Status("初始化...", False)
        Settings.Methods.Initialize()
        Status("保存...", False)
        Settings.Methods.ReadSettings()
        Status("更新...", False)
        LoadToControl()
        UpdateControl()
        Status("就绪", False)
    End Sub

    Private Sub Button_Reload_Click(sender As Object, e As EventArgs) Handles Button_Reload.Click
        Me.Enabled = False
        OnShown(Nothing)
        Me.Enabled = True
    End Sub

    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        Me.Close()
    End Sub

    Private Sub Button_DeleteAll_Click(sender As Object, e As EventArgs) Handles Button_DeleteAll.Click
        Status("正在准备...")
        NBlockMsgBox("注意: 当前会话中产生的 TTS 缓存将可在下次启动时清除。", vbInformation + vbOKOnly, "TTSDanmaku")
        Dim count As Integer = 0
        Try
            Dim rmrf As New System.IO.DirectoryInfo(Settings.Vars.CacheDir)
            For Each file As System.IO.FileInfo In rmrf.GetFiles
                Status("正在删除: " & file.FullName)
                file.Delete()
                count += 1
            Next
        Catch ex As Exception
            Statistics.DBG_ErrCount += 1
            Statistics.DBG_LastException = ex
            Status("操作失败: " & ex.Message)
        End Try
        TextBox_Files.Clear()
        Status("处理 TTS 缓存...")
        Dim rmrf2 As New System.IO.DirectoryInfo(Settings.Vars.CacheDir)
        Dim count2 As Integer = 0
        Dim totalLength2 As Long = 0
        For Each file As System.IO.FileInfo In rmrf2.GetFiles
            Status(file.FullName)
            count += 1
            totalLength2 += file.Length
            TextBox_Files.AppendText(count & " - " & file.Name & " - 大小(KiB): " & (file.Length / 1024) & vbCrLf)
        Next
        TextBox_Files.AppendText("总大小: " & (totalLength2 / 1024) & " KiB.")
        Status("操作成功: " & count & " 个。")
    End Sub

    Private Sub ControlReloadReceiver(sender As Object, e As EventArgs) Handles CheckBox_TTSDebug.CheckedChanged, CheckBox_TTSSender.CheckedChanged, CheckBox_TTSGifts.CheckedChanged, CheckBox_NoCache.CheckedChanged, CheckBox_TTSCoolDown.CheckedChanged, NumericUpDown_CoolDownValue.ValueChanged, TextBox_CustomDMContent.TextChanged, TextBox_CustomGiftContent.TextChanged
        UpdateControl()
    End Sub

    Private Sub TTSDanmakuMgmt_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LoadToControl()
        UpdateControl()
        '处理缓存
        Try
            Status("处理 TTS 缓存...")
            TextBox_Files.Clear()
            Dim rmrf As New IO.DirectoryInfo(Settings.Vars.CacheDir)
            Dim count As Integer = 0
            Dim totalLength As Long = 0
            For Each file As System.IO.FileInfo In rmrf.GetFiles
                Status(file.FullName)
                count += 1
                totalLength += file.Length
                TextBox_Files.AppendText(count & " - " & file.Name & " - 大小(KiB): " & (file.Length / 1024) & vbCrLf)
            Next
            TextBox_Files.AppendText("总大小: " & (totalLength / 1024) & " KiB.")
        Catch ex As Exception
            Statistics.DBG_ErrCount += 1
            Statistics.DBG_LastException = ex
        End Try
        Status("就绪", False)
        TextBox_Stats.SelectionStart = TextBox_Stats.TextLength
        TextBox_Stats.SelectionLength = 0
        TextBox_Stats.ScrollToCaret()
    End Sub

    Private Sub TTSDanmakuMgmt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Settings.Methods.Initialize()
    End Sub

    Private Sub LinkLabel_About_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_About.LinkClicked
        Dim proc As New Process
        With proc.StartInfo
            .FileName = "https://www.danmuji.cn/plugins/TTSDanmaku"
            .ErrorDialog = False
        End With
        proc.Start()
    End Sub

    Private Sub LinkLabel_Suggestions_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Suggestions.LinkClicked
        Dim proc As New Process
        With proc.StartInfo
            .FileName = "https://blog.elepover.com/quoteLeft.html"
            .ErrorDialog = False
        End With
        proc.Start()
    End Sub

    Private Sub LinkLabel_FAQ_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_FAQ.LinkClicked
        Dim proc As New Process
        With proc.StartInfo
            .FileName = "https://blog.elepover.com/archives/2017/05/faq.html"
            .ErrorDialog = False
        End With
        proc.Start()
    End Sub

    Private Sub Button_StatusReport_Click(sender As Object, e As EventArgs) Handles Button_StatusReport.Click
        Dim frm As New Form_StatusReport
        frm.Show()
    End Sub
End Class