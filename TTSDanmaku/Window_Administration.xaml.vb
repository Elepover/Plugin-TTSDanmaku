Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Windows
Imports System.Windows.Interop

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
        Button_Apply.ToolTip = "保存设置。" & vbCrLf & vbCrLf & "当前设置文件路径: " & Settings.Vars.ConfigFileName
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
        Slider_DMLengthLimit.Value = Settings.Settings.MiniumDMLength

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

        CheckBox_EnableTrayIcon.IsChecked = TrayKeeper.NotifyIcon_Default.Visible

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
        Settings.Settings.TTSVolume = CInt(NumericUpDown_Volume.Value)
        Settings.Settings.DoNotKeepCache = CheckBox_NoKeepingCache.IsChecked
        Settings.Settings.ConnectSuccessful = TextBox_CustomConnected.Text
        Settings.Settings.DLFailRetry = CInt(NumericUpDown_RetryCount.Value)
        Settings.Settings.ReadInArray = CheckBox_OneByOne.IsChecked
        Settings.Settings.MiniumDMLength = CInt(Slider_DMLengthLimit.Value)

        Settings.Settings.Block_Mode = ComboBox_Blockmode.SelectedIndex
        Settings.Settings.Blacklist = TextBox_Blacklist.Text
        Settings.Settings.Whitelist = TextBox_Whitelist.Text

        Settings.Settings.GiftBlock_Mode = ComboBox_GiftBlockMode.SelectedIndex
        Settings.Settings.GiftBlacklist = TextBox_GiftBlacklist.Text
        Settings.Settings.GiftWhitelist = TextBox_GiftWhitelist.Text
        Settings.Settings.BlockType = CInt(TrackBar_BlockType.Value)

        Settings.Settings.NETFramework_VoiceSpeed = CInt(NumericUpDown_SpeechSpeed.Value)
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
        Button_Load_Click(Nothing, Nothing)
        LoadToControl()
    End Sub

    Private Sub Button_Load_Click(sender As Object, e As Windows.RoutedEventArgs) Handles Button_Load.Click
        Status("初始化...", False)
        Settings.Methods.Initialize()
        Status("保存...", False)
        Settings.Methods.ReadSettings()
        Status("更新...", False)
        LoadToControl()
        Status("就绪", False)
    End Sub

    Private Sub Button_CheckUpdates_Click(sender As Object, e As Windows.RoutedEventArgs) Handles Button_CheckUpdates.Click
        Dim frm As New Window_Upgrader
        frm.Show()
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

        'If CheckIfWin10() Then
        '    FullOpenAero()
        'End If

        LoadToControl()
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
#End Region

#Region "Glass"
    Private Declare Auto Function DwmIsCompositionEnabled Lib "dwmapi.dll" Alias "DwmIsCompositionEnabled" (ByRef pfEnabled As Boolean) As Integer
    Private Declare Auto Function DwmExtendFrameIntoClientArea Lib "dwmapi.dll" Alias "DwmExtendFrameIntoClientArea" (ByVal hWnd As IntPtr, ByRef pMargin As MARGINS) As Integer
    <StructLayout(LayoutKind.Sequential)>
    Private Structure MARGINS
        Public cxLeftWidth As Integer
        Public cxRightWidth As Integer
        Public cyTopHeight As Integer
        Public cyButtomheight As Integer
    End Structure
    Private Const FramBrod = -1

    <DllImport("user32.dll")>
    Friend Shared Function SetWindowCompositionAttribute(hwnd As IntPtr, ByRef data As WindowCompositionAttributeData) As Integer
    End Function

    <StructLayout(LayoutKind.Sequential)>
    Friend Structure WindowCompositionAttributeData
        Public Attribute As WindowCompositionAttribute
        Public Data As IntPtr
        Public SizeOfData As Integer
    End Structure

    Friend Enum WindowCompositionAttribute
        WCA_ACCENT_POLICY = 19
    End Enum

    Friend Enum AccentState
        ACCENT_DISABLED = 0
        ACCENT_ENABLE_GRADIENT = 1
        ACCENT_ENABLE_TRANSPARENTGRADIENT = 2
        ACCENT_ENABLE_BLURBEHIND = 3
        ACCENT_INVALID_STATE = 4
    End Enum

    <StructLayout(LayoutKind.Sequential)>
    Friend Structure AccentPolicy
        Public AccentState As AccentState
        Public AccentFlags As Integer
        Public GradientColor As Integer
        Public AnimationId As Integer
    End Structure

    Friend Sub EnableBlur()

        Dim accent = New AccentPolicy()
        Dim accentStructSize = Marshal.SizeOf(accent)
        accent.AccentState = AccentState.ACCENT_ENABLE_BLURBEHIND

        Dim accentPtr = Marshal.AllocHGlobal(accentStructSize)
        Marshal.StructureToPtr(accent, accentPtr, False)

        Dim data = New WindowCompositionAttributeData With {
            .Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY,
            .SizeOfData = accentStructSize,
            .Data = accentPtr
        }

        SetWindowCompositionAttribute(New WindowInteropHelper(Me).Handle, data)

        Marshal.FreeHGlobal(accentPtr)
    End Sub

    Friend Sub FullOpenAero()
        Dim IsOpenAero As Boolean = False
        Dim margins As MARGINS = New MARGINS
        With margins
            .cxLeftWidth = FramBrod
            .cxRightWidth = FramBrod
            .cyTopHeight = FramBrod
            .cyButtomheight = FramBrod
        End With
        Dim hwnd As IntPtr = New WindowInteropHelper(Me).Handle
        If System.Environment.OSVersion.Version.Major < 6 Then Exit Sub
        DwmIsCompositionEnabled(IsOpenAero)

        EnableBlur()
        If (IsOpenAero) Then
            DwmExtendFrameIntoClientArea(hwnd, margins)
        End If
    End Sub
#End Region

    Private Sub Button_About_Click(sender As Object, e As RoutedEventArgs) Handles Button_About.Click
        Process.Start("https://www.danmuji.cn/plugins/TTSDanmaku")
    End Sub

    Private Sub Button_FAQ_Click(sender As Object, e As RoutedEventArgs) Handles Button_FAQ.Click
        Process.Start("https://blog.elepover.com/archives/2017/05/faq.html")
    End Sub

    Private Sub Button_Suggestions_Click(sender As Object, e As RoutedEventArgs) Handles Button_Suggestions.Click
        Process.Start("https://blog.elepover.com/quoteLeft.html")
    End Sub

    Private Sub NumericUpDown_Volume_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double)) Handles NumericUpDown_Volume.ValueChanged
        If IsVisible Then
            TextBlock_Volume.Text = CInt(NumericUpDown_Volume.Value)
        End If
    End Sub

    Private Sub NumericUpDown_RetryCount_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double)) Handles NumericUpDown_RetryCount.ValueChanged
        If IsVisible Then
            TextBlock_RetryCount.Text = CInt(NumericUpDown_RetryCount.Value)
        End If
    End Sub

    Private Sub NumericUpDown_SpeechSpeed_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double)) Handles NumericUpDown_SpeechSpeed.ValueChanged
        If IsVisible Then
            TextBlock_SpeechSpeed.Text = CInt(NumericUpDown_SpeechSpeed.Value)
        End If
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As Controls.TextChangedEventArgs) Handles TextBox_CustomDMContent.TextChanged, TextBox_CustomGiftContent.TextChanged
        If IsVisible Then
            CheckIfLegal_DM()
            CheckIfLegal_GIFT()
        End If
    End Sub

    Private Sub Button_Donation_Click(sender As Object, e As RoutedEventArgs) Handles Button_Donation.Click
        Process.Start("https://blog.elepover.com/donation.html")
    End Sub

    Private Sub CheckBox_EnableTrayIcon_Click(sender As Object, e As RoutedEventArgs) Handles CheckBox_EnableTrayIcon.Click
        If CheckBox_EnableTrayIcon.IsChecked Then
            TrayKeeper.NotifyIcon_Default.Visible = True
        Else
            TrayKeeper.NotifyIcon_Default.Visible = False
            If Not System.Windows.Application.Current.MainWindow.Visibility = Windows.Visibility.Visible Then
                System.Windows.Application.Current.MainWindow.Visibility = Windows.Visibility.Visible
            End If
        End If
    End Sub

    Private Sub Slider_DMLengthLimit_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double)) Handles Slider_DMLengthLimit.ValueChanged
        If IsVisible Then
            TextBlock_DMLengthLimit.Text = CInt(Slider_DMLengthLimit.Value)
        End If
    End Sub

End Class
