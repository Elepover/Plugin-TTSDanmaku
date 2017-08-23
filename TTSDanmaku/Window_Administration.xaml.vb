Imports System.Windows

Public Class Window_Administration
#Region "Including"
    Private Sub Status(status As String, Optional log As Boolean = True)
        StatusLabel_Default.Text = status
        'If log Then TextBox_Stats.AppendText(status & vbCrLf)
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Public Function CheckIfLegal_DM()
        '检查弹幕内容中有无礼物变量
        If TextBox_CustomDMContent.Text.Contains("$GIFT") Then
            TextBox_CustomDMContent.Background = Windows.Media.Brushes.Pink
            Return True
        Else
            TextBox_CustomDMContent.Background = Windows.Media.Brushes.LightGreen
            Return False
        End If
        If TextBox_CustomDMContent.Text.Contains("$COUNT") Then
            TextBox_CustomDMContent.Background = Windows.Media.Brushes.Pink
            Return True
        Else
            TextBox_CustomDMContent.Background = Windows.Media.Brushes.LightGreen
            Return False
        End If
    End Function
    Public Function CheckIfLegal_GIFT()
        '检查礼物内容中有无弹幕变量
        If TextBox_CustomGiftContent.Text.Contains("$DM") Then
            TextBox_CustomGiftContent.Background = Windows.Media.Brushes.Pink
            Return True
        Else
            TextBox_CustomGiftContent.Background = Windows.Media.Brushes.LightGreen
            Return False
        End If
    End Function

    Private Sub UpdateControl()
        Status("载入...", False)

        If Not CheckBox_TTSDebug.IsChecked = Settings.Settings.DebugMode Then
            CheckBox_TTSDebug.FontWeight = Windows.FontWeights.Bold
        Else
            CheckBox_TTSDebug.FontWeight = Windows.FontWeights.Normal
        End If

        If Not CheckBox_TTSGifts.IsChecked = Settings.Settings.TTSGiftsReceived Then
            CheckBox_TTSGifts.FontWeight = Windows.FontWeights.Bold
        Else
            CheckBox_TTSGifts.FontWeight = Windows.FontWeights.Normal
        End If

        If Not CheckBox_TTSSender.IsChecked = Settings.Settings.TTSDanmakuSender Then
            CheckBox_TTSSender.FontWeight = Windows.FontWeights.Bold
        Else
            CheckBox_TTSSender.FontWeight = Windows.FontWeights.Normal
        End If

        If Not CheckBox_NoCache.IsChecked = Settings.Settings.AutoClearCache Then
            CheckBox_NoCache.FontWeight = Windows.FontWeights.Bold
        Else
            CheckBox_NoCache.FontWeight = Windows.FontWeights.Normal
        End If

        If Not ComboBox_Engine.SelectedIndex = Settings.Settings.Engine Then
            ComboBox_Engine.FontWeight = Windows.FontWeights.Bold
        Else
            ComboBox_Engine.FontWeight = Windows.FontWeights.Normal
        End If

        If Not NumericUpDown_Volume.Value = Settings.Settings.TTSVolume Then
            NumericUpDown_Volume.FontWeight = Windows.FontWeights.Bold
        Else
            NumericUpDown_Volume.FontWeight = Windows.FontWeights.Normal
        End If

        If Not CheckBox_NoKeepingCache.IsChecked = Settings.Settings.DoNotKeepCache Then
            CheckBox_NoKeepingCache.FontWeight = Windows.FontWeights.Bold
        Else
            CheckBox_NoKeepingCache.FontWeight = Windows.FontWeights.Normal
        End If

        If Not CheckBox_OneByOne.IsChecked = Settings.Settings.ReadInArray Then
            CheckBox_OneByOne.FontWeight = Windows.FontWeights.Bold
        Else
            CheckBox_OneByOne.FontWeight = Windows.FontWeights.Normal
        End If

        If Not TextBox_CustomConnected.Text = Settings.Settings.ConnectSuccessful Then
            TextBox_CustomConnected.FontWeight = Windows.FontWeights.Bold
        Else
            TextBox_CustomConnected.FontWeight = Windows.FontWeights.Normal
        End If

        If Not NumericUpDown_RetryCount.Value = Settings.Settings.DLFailRetry Then
            NumericUpDown_RetryCount.FontWeight = Windows.FontWeights.Bold
        Else
            NumericUpDown_RetryCount.FontWeight = Windows.FontWeights.Normal
        End If

        CheckIfLegal_DM()
        If Not TextBox_CustomDMContent.Text = Settings.Settings.DanmakuText Then
            TextBox_CustomDMContent.FontWeight = Windows.FontWeights.Bold
        Else
            TextBox_CustomDMContent.FontWeight = Windows.FontWeights.Normal
        End If

        CheckIfLegal_GIFT()
        If Not TextBox_CustomGiftContent.Text = Settings.Settings.GiftsText Then
            TextBox_CustomGiftContent.FontWeight = Windows.FontWeights.Bold
        Else
            TextBox_CustomGiftContent.FontWeight = Windows.FontWeights.Normal
        End If

        If Not ComboBox_Blockmode.SelectedIndex = Settings.Settings.Block_Mode Then
            ComboBox_Blockmode.FontWeight = Windows.FontWeights.Bold
        Else
            ComboBox_Blockmode.FontWeight = Windows.FontWeights.Normal
        End If

        If Not TextBox_Blacklist.Text = Settings.Settings.Blacklist Then
            Label_Blacklist.FontWeight = Windows.FontWeights.Bold
            Label_Blacklist.Text = "黑名单*"
        Else
            Label_Blacklist.FontWeight = Windows.FontWeights.Normal
            Label_Blacklist.Text = "黑名单"
        End If

        If Not TextBox_Whitelist.Text = Settings.Settings.Whitelist Then
            Label_Whitelist.FontWeight = Windows.FontWeights.Bold
            Label_Whitelist.Text = "白名单*"
        Else
            Label_Whitelist.FontWeight = Windows.FontWeights.Normal
            Label_Whitelist.Text = "白名单"
        End If

        If Not ComboBox_GiftBlockMode.SelectedIndex = Settings.Settings.GiftBlock_Mode Then
            ComboBox_GiftBlockMode.FontWeight = Windows.FontWeights.Bold
        Else
            ComboBox_GiftBlockMode.FontWeight = Windows.FontWeights.Normal
        End If

        If Not TextBox_GiftBlacklist.Text = Settings.Settings.GiftBlacklist Then
            Label_GiftBlacklist.FontWeight = Windows.FontWeights.Bold
            Label_GiftBlacklist.Text = "黑名单*"
        Else
            Label_GiftBlacklist.FontWeight = Windows.FontWeights.Normal
            Label_GiftBlacklist.Text = "黑名单"
        End If

        If Not TextBox_GiftWhitelist.Text = Settings.Settings.GiftWhitelist Then
            Label_GiftWhitelist.FontWeight = Windows.FontWeights.Bold
            Label_GiftWhitelist.Text = "白名单*"
        Else
            Label_GiftWhitelist.FontWeight = Windows.FontWeights.Normal
            Label_GiftWhitelist.Text = "白名单"
        End If

        If Not TrackBar_BlockType.Value = Settings.Settings.BlockType Then
            Label_UID.FontWeight = Windows.FontWeights.Bold
            Label_Username.FontWeight = Windows.FontWeights.Bold
        Else
            Label_UID.FontWeight = Windows.FontWeights.Normal
            Label_Username.FontWeight = Windows.FontWeights.Normal
        End If

        Button_Apply.ToolTip = "保存设置。" & vbCrLf & vbCrLf & "当前设置文件路径: " & Settings.Vars.ConfigFileName

        Status("就绪", False)
    End Sub

    Private Sub LoadToControl()
        Status("载入...", False)
        Dim version As String = New Main().PluginVer
        CheckBox_TTSDebug.IsChecked = Settings.Settings.DebugMode
        CheckBox_TTSGifts.IsChecked = Settings.Settings.TTSGiftsReceived
        CheckBox_TTSSender.IsChecked = Settings.Settings.TTSDanmakuSender
        CheckBox_NoCache.IsChecked = Settings.Settings.AutoClearCache
        NumericUpDown_Volume.Value = Settings.Settings.TTSVolume
        NumericUpDown_RetryCount.Value = Settings.Settings.DLFailRetry

        TextBox_CustomDMContent.Text = Settings.Settings.DanmakuText
        TextBox_CustomGiftContent.Text = Settings.Settings.GiftsText
        TextBox_CustomConnected.Text = Settings.Settings.ConnectSuccessful

        ComboBox_Engine.SelectedIndex = Settings.Settings.Engine
        ComboBox_Blockmode.SelectedIndex = Settings.Settings.Block_Mode
        ComboBox_GiftBlockMode.SelectedIndex = Settings.Settings.GiftBlock_Mode

        CheckBox_NoKeepingCache.IsChecked = Settings.Settings.DoNotKeepCache
        CheckBox_OneByOne.IsChecked = Settings.Settings.ReadInArray

        TextBox_Blacklist.Text = Settings.Settings.Blacklist
        TextBox_Whitelist.Text = Settings.Settings.Whitelist
        TextBox_GiftBlacklist.Text = Settings.Settings.GiftBlacklist
        TextBox_GiftWhitelist.Text = Settings.Settings.GiftWhitelist
        TrackBar_BlockType.Value = Settings.Settings.BlockType

        NumericUpDown_SpeechSpeed.Value = Settings.Settings.NETFramework_VoiceSpeed

        If Edition = "Live" Then
            Me.Title = "TTSDanmaku v" & version & " (Live) - **EXPERIMENTAL**"
            Label_ThanksViaMyHeart.Text = "感谢您使用 Live 版。"
        Else
            Me.Title = "TTSDanmaku v" & version & " (" & Edition & ")"
        End If



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
        TextBox_Stats.AppendText("等待播放的 TTS 数量: " & PendingTTSes.Count & vbCrLf)
        If IsNothing(Statistics.DBG_LastException) Then
            TextBox_Stats.AppendText("最后一次发生的错误: 无" & vbCrLf)
        Else
            TextBox_Stats.AppendText("最后一次发生的错误: " & Statistics.DBG_LastException.ToString & vbCrLf)
        End If

        Label_AboutTitle.Text = "TTSDanmaku " & Edition & " v" & version
        TextBox_Debug.Clear()
        TextBox_Debug.AppendText("---------- OS Environment ----------" & vbCrLf)
        TextBox_Debug.AppendText("Operating System: " & My.Computer.Info.OSFullName & vbCrLf)
        TextBox_Debug.AppendText("OS Version: " & My.Computer.Info.OSVersion & vbCrLf)
        TextBox_Debug.AppendText("---------- Plugin Environment ----------" & vbCrLf)
        TextBox_Debug.AppendText("TTSDanmaku version: " & version & vbCrLf)
        TextBox_Debug.AppendText("TTSDanmaku edition: " & Edition & vbCrLf)
        TextBox_Debug.AppendText("Plugin executable: " & Reflection.Assembly.GetExecutingAssembly().Location & vbCrLf)
        TextBox_Debug.AppendText("Plugin configuration directory: " & Settings.Vars.ConfigurationDir & vbCrLf)
        TextBox_Debug.AppendText("Plugins directory: " & Settings.Vars.PluginDir & vbCrLf)
        Status("就绪", False)
    End Sub

    Private Sub Button_Apply_Click(sender As Object, e As Windows.RoutedEventArgs) Handles Button_Apply.Click
        Status("初始化...", False)
        Settings.Methods.Initialize()
        Settings.Settings.DebugMode = CheckBox_TTSDebug.IsChecked
        Settings.Settings.TTSDanmakuSender = CheckBox_TTSSender.IsChecked
        Settings.Settings.TTSGiftsReceived = CheckBox_TTSGifts.IsChecked
        Settings.Settings.AutoClearCache = CheckBox_NoCache.IsChecked
        Settings.Settings.Engine = ComboBox_Engine.SelectedIndex
        Settings.Settings.TTSVolume = NumericUpDown_Volume.Value
        Settings.Settings.DoNotKeepCache = CheckBox_NoKeepingCache.IsChecked
        Settings.Settings.ConnectSuccessful = TextBox_CustomConnected.Text
        Settings.Settings.DLFailRetry = NumericUpDown_RetryCount.Value
        Settings.Settings.ReadInArray = CheckBox_OneByOne.IsChecked

        Settings.Settings.Block_Mode = ComboBox_Blockmode.SelectedIndex
        Settings.Settings.Blacklist = TextBox_Blacklist.Text
        Settings.Settings.Whitelist = TextBox_Whitelist.Text

        Settings.Settings.GiftBlock_Mode = ComboBox_GiftBlockMode.SelectedIndex
        Settings.Settings.GiftBlacklist = TextBox_GiftBlacklist.Text
        Settings.Settings.GiftWhitelist = TextBox_GiftWhitelist.Text
        Settings.Settings.BlockType = TrackBar_BlockType.Value

        Settings.Settings.NETFramework_VoiceSpeed = NumericUpDown_SpeechSpeed.Value
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
        If Settings.Settings.TTSDelayEnabled Then IsCoolingDown = False

        Try
            Status("保存...", False)
            Settings.Methods.SaveSettings()
            Status("已保存配置到: " & Settings.Vars.ConfigFileName)
        Catch ex As Exception
            Statistics.DBG_ErrCount += 1
            Statistics.DBG_LastException = ex
            Status("保存错误，请检查权限设置。")
        End Try
        Button_Load.RaiseEvent(Nothing)
        LoadToControl()
        UpdateControl()
    End Sub

    Private Sub Button_Load_Click(sender As Object, e As Windows.RoutedEventArgs) Handles Button_Load.Click
        Status("初始化...", False)
        Settings.Methods.Initialize()
        Status("保存...", False)
        Settings.Methods.ReadSettings()
        Status("更新...", False)
        LoadToControl()
        UpdateControl()
        Status("就绪", False)
    End Sub

    Private Sub Button_CheckUpdates_Click(sender As Object, e As Windows.RoutedEventArgs) Handles Button_CheckUpdates.Click
        Try
            If My.Computer.Keyboard.ShiftKeyDown Then
                'Check beta
                Dim latest As KruinUpdates.Update = KruinUpdates.CheckUpdatesViaKruinUpdates(KruinUpdates.UpdateType.Beta)
                Dim latestVer As Version = New Version(latest.Version)
                Dim currentVer As Version = New Version(New Main().PluginVer)
                If latestVer > currentVer Then
                    If MsgBox("最新版本: " & latest.Version & " 已发布！" & vbCrLf & "是否前往下载？", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "KruinUpdates") = MsgBoxResult.Yes Then
                        Dim proc As New Process()
                        proc.StartInfo.FileName = "https://ttsdanmaku.elepover.com/TTSDanmaku v" & latest.Version & ".zip"
                        proc.Start()
                    End If
                Else
                    NBlockMsgBox("插件已为最新。", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "KruinUpdates")
                End If
            Else
                'Check release
                Dim latest As KruinUpdates.Update = KruinUpdates.CheckUpdatesViaKruinUpdates(KruinUpdates.UpdateType.Release)
                Dim latestVer As Version = New Version(latest.Version)
                Dim currentVer As Version = New Version(New Main().PluginVer)
                If latestVer > currentVer Then
                    If MsgBox("最新版本: " & latest.Version & " 已发布！" & vbCrLf & "是否前往下载？", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "KruinUpdates") = MsgBoxResult.Yes Then
                        Dim proc As New Process()
                        proc.StartInfo.FileName = "https://www.danmuji.cn/plugins/TTSDanmaku"
                        proc.Start()
                    End If
                Else
                    NBlockMsgBox("插件已为最新。", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "KruinUpdates")
                End If
            End If
        Catch ex As Exception
            NBlockMsgBox("检查更新时出错: " & ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "KruinUpdates")
        End Try
    End Sub

    Private Sub Button_Close_Click(sender As Object, e As Windows.RoutedEventArgs) Handles Button_Close.Click
        Me.Close()
    End Sub

    Private Sub Button_StatusReport_Click(sender As Object, e As Windows.RoutedEventArgs) Handles Button_StatusReport.Click
        Dim frm As New Window_StatusReport
        frm.Show()
    End Sub

    Private Sub Button_ProxySettings_Click(sender As Object, e As Windows.RoutedEventArgs) Handles Button_ProxySettings.Click
        Dim frm As New Window_ProxySettings
        frm.Show()
    End Sub

    Private Sub Button_SetupWizard_Click(sender As Object, e As Windows.RoutedEventArgs) Handles Button_SetupWizard.Click
        Dim frm As New Form_SetupWizard_1
        frm.Show()
        Me.Close()
    End Sub

    Private Sub Button_Reload_Click(sender As Object, e As Windows.RoutedEventArgs) Handles Button_Reload.Click
        Me.IsEnabled = False

        Me.IsEnabled = True
    End Sub

    Private Sub Window_Administration_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Settings.Methods.Initialize()
        Icon = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(My.Resources.icon.GetHbitmap, IntPtr.Zero, Int32Rect.Empty, Media.Imaging.BitmapSizeOptions.FromEmptyOptions())
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
        TextBox_Stats.ScrollToEnd()
    End Sub

    Private Sub Button_DeleteAll_Click(sender As Object, e As RoutedEventArgs) Handles Button_DeleteAll.Click
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

    Private Sub Button_About_Click(sender As Object, e As RoutedEventArgs) Handles Button_About.Click
        Process.Start("https://www.danmuji.cn/plugins/TTSDanmaku")
    End Sub

    Private Sub Button_FAQ_Click(sender As Object, e As RoutedEventArgs) Handles Button_FAQ.Click
        Process.Start("https://blog.elepover.com/archives/2017/05/faq.html")
    End Sub

    Private Sub Button_Suggestions_Click(sender As Object, e As RoutedEventArgs) Handles Button_Suggestions.Click
        Process.Start("https://blog.elepover.com/quoteLeft.html")
    End Sub
#End Region
End Class
