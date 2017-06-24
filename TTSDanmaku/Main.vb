' Main.vb
' Copyright (C) 2017 Elepover & CopyLiu (For his demo version).

Public Class Main
    Inherits BilibiliDM_PluginFramework.DMPlugin

    Public Sub New()
        AddHandler Me.Connected, AddressOf Main_Connected
        AddHandler Me.Disconnected, AddressOf Main_Disconnected
        AddHandler Me.ReceivedDanmaku, AddressOf Main_ReceivedDanmaku
        AddHandler Me.ReceivedRoomCount, AddressOf Main_ReceivedRoomCount
        Me.PluginAuth = "Elepover"
        Me.PluginName = "TTSDanmaku"
        Me.PluginCont = "elepover@outlook.com"
        Me.PluginVer = "1.0.3.50"
        Me.PluginDesc = "把你收到的弹幕和礼物，读出来！"
    End Sub

#Region "Includings"

    Public Shared IsEnabled As Boolean = False
    Public Shared IsCoolingDown As Boolean = False
    Public Shared IsNAudioNotFoundAlerted As Boolean = False
    Public Shared UserCountLatest As Integer = 0
    Public Shared SRThread As Threading.Thread
    Public Shared SRCount As Integer = 0

    Private Sub ShowADM()
        Dim frm As New TTSDanmakuMgmt
        frm.Show()
    End Sub

    Private Sub StartStatusReport()
        SRThread = New Threading.Thread(AddressOf ThrStatusReport)
        SRThread.Start()
    End Sub

    Private Sub ThrStatusReport()
        Do Until 233 = 2333
            '注意检测插件是否启用
            DBGLog("状态报告已开始计时: " & Settings.Settings.StatusReportInterval)
            Threading.Thread.Sleep(Settings.Settings.StatusReportInterval * 1000)
            DBGLog("计时达到，检查环境。")
            If Settings.Settings.StatusReport = False Then GoTo DLoop
            If Status = False Then Exit Sub
            Dim content As String = Settings.Settings.StatusReportContent
            If Settings.Settings.StatusReport_ResolveAdvVars Then
                content = content.Replace("$ONLINE", UserCountLatest).Replace("$TOTALDM", Statistics.TTS_Total - Statistics.TTS_Silent - SRCount).Replace("$HOUR", Now.Hour).Replace("$MINUTE", Now.Minute).Replace("$SEC", Now.Second).Replace("$YEAR", Now.Year).Replace("$MONTH", Now.Month).Replace("$DAY", Now.Day).Replace("$MEMAVAI", Math.Round((My.Computer.Info.AvailablePhysicalMemory / 1024 / 1024 / 1024), 2)).Replace("$MPERCENT", Math.Round(((My.Computer.Info.TotalPhysicalMemory - My.Computer.Info.AvailablePhysicalMemory) / My.Computer.Info.TotalPhysicalMemory) * 100, 2)).Replace("$VMEM", Math.Round((My.Computer.Info.AvailableVirtualMemory / 1024 / 1024 / 1024 / 1024), 2)).Replace("$VPERCENT_VM", Math.Round(((My.Computer.Info.TotalVirtualMemory - My.Computer.Info.AvailableVirtualMemory) / My.Computer.Info.TotalVirtualMemory) * 100, 2))
            Else
                content = content.Replace("$ONLINE", UserCountLatest).Replace("$TOTALDM", Statistics.TTS_Total - Statistics.TTS_Silent - SRCount)
            End If
            PlayTTS(content)
            SRCount += 1
DLoop:
        Loop
    End Sub

    Public Sub DBGLog(logstr As String)
        If Settings.Settings.DebugMode Then Log(logstr)
    End Sub

    Private Function CheckNAudio() As Boolean
        If Not IO.File.Exists(Settings.Vars.LibFileName) Then
            If IsNAudioNotFoundAlerted = False Then NBlockMsgBox("NAudio 模块未找到，可能是启动期间文件释放失败。" & vbCrLf & "请检查是否存在以下文件: " & vbCrLf & Settings.Vars.LibFileName & vbCrLf & vbCrLf & "如果不存在此文件，请前往弹幕姬官网 -> 插件目录 -> TTSDanmaku 在页面底部下载 NAudio.dll, 并与 TTSDanmaku 置于一起。随后重新启用 TTSDanmaku 即可！" & vbCrLf & vbCrLf & "（此对话框只会出现一次。）", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly + vbSystemModal, "TTSDanmaku 错误")
            IsNAudioNotFoundAlerted = True
            Return False
        Else
            IsNAudioNotFoundAlerted = False
            Return True
        End If
    End Function

    ''' <summary>
    ''' 下载并播放 TTS 文件。
    ''' </summary>
    ''' <param name="content">TTS 内容。</param>
    ''' <param name="silent">静默模式，调试用。</param>
    ''' <param name="sysMsg">系统消息，启用此选项将无视冷却时间。</param>
    ''' <param name="forceDispose">播放后瞬间强行释放资源（不播放）</param>
    ''' <returns></returns>
    Public Function PlayTTS(content As String, Optional silent As Boolean = False, Optional sysMsg As Boolean = False, Optional forceDispose As Boolean = False) As Boolean
        Statistics.TTS_Total += 1
        If content.Length > 128 Then
            DBGLog("TTS 内容太多，放弃。")
            Statistics.TTS_Dropped += 1
            Return False
        End If

        If Settings.Settings.Engine = 1 Then
            Try
                DBGLog("已确定使用 .NET 框架自带方法播放，忽略为毒瘤准备的下载过程。")
                If silent Then DBGLog("正在静默播放模式中。")
                If Not silent Then
                    If Not IsCoolingDown Then
                        DBGLog("启动播放: " & content)
                        SpeechOutput(content)
                        Statistics.TTS_Succeeded += 1
                        If Settings.Settings.TTSDelayEnabled Then StartCoolDown() '启动冷却
                        Return True
                    Else
                        Statistics.TTS_PlayedDuringCoolDown += 1
                        DBGLog("正在冷却时间中，将不会播放 TTS。")
                        Return True
                    End If
                Else
                    Statistics.TTS_Silent += 1
                    Return True
                End If
            Catch ex As Exception
                Statistics.DBG_ErrCount += 1
                Statistics.DBG_LastException = ex
                Statistics.TTS_Failed += 1
                Log("TTS 播放错误: " & ex.ToString)
                Return False
            End Try
        End If


        If CheckNAudio() = False Then
            DBGLog("NAudio 模块错误，放弃。")
            Statistics.TTS_Dropped += 1
            Return False
        End If

        If Settings.Settings.Engine = 2 Then
            Try
                DBGLog("使用 404 翻译 API。")
                If silent Then DBGLog("正在静默播放模式中。")
                If Not silent Then
                    If Not IsCoolingDown Then
                        DBGLog("启动播放: " & content)
                        GoogleTTS(content)
                        Statistics.TTS_Succeeded += 1
                        If Settings.Settings.TTSDelayEnabled Then StartCoolDown() '启动冷却
                        Return True
                    Else
                        Statistics.TTS_PlayedDuringCoolDown += 1
                        DBGLog("正在冷却时间中，将不会播放 TTS。")
                        Return True
                    End If
                Else
                    Statistics.TTS_Silent += 1
                    Return True
                End If
            Catch ex As Exception
                Statistics.DBG_ErrCount += 1
                Statistics.DBG_LastException = ex
                Statistics.TTS_Failed += 1
                Log("TTS 播放错误: " & ex.ToString)
                Return False
            End Try
        End If

        Dim retryCount As Short = 0
retry:
        DBGLog("正尝试播放: " & content)
        'Download
        Dim ttsFileName As String = ""
        Dim timer As New Stopwatch
        timer.Start()
        Try
            Dim client As New Net.WebClient()
            Dim ran1 As Integer = 0
            Dim ran2 As Integer = 0
            ran1 = (New Random).Next
            Randomize()
            ran2 = (New Random).Next
            ttsFileName = Settings.Vars.CacheDir & "\TTS" & ran1 & ran2 & ".mp3"
            client.DownloadFile(Settings.Settings.APIString.Replace("ZoharWang", content), ttsFileName)
        Catch ex As Exception
            Statistics.DBG_LastException = ex
            Statistics.DBG_ErrCount += 1
            'Retry
            If retryCount < 5 Then
                retryCount += 1
                DBGLog("下载失败: " & ex.Message & "；将在 1 秒后执行第 " & retryCount & " 次重试。")
                Statistics.TTS_DownloadFail += 1
                Delay(1000)
                GoTo retry
            End If
            If retryCount = 5 Then
                retryCount += 1
                DBGLog("下载失败: " & ex.Message & "；即将在 1 秒后执行最后一次重试。")
                Statistics.TTS_DownloadFail += 1
                Delay(1000)
                GoTo retry
            End If
            'Over 5 times
            Log("在重试 5 次以后，TTS 下载失败: " & ex.Message)
            Return False
        End Try
        timer.Stop()
        If Not retryCount = 0 Then DBGLog("在重试 " & retryCount & " 次后, TTS 下载成功。")
        DBGLog("下载完毕，耗时: " & timer.Elapsed.TotalMilliseconds & "ms. 文件名: " & ttsFileName)
        DBGLog("启动播放.")
        Statistics.TTS_PlayTries += 1
        Try
            Dim waveout As New NAudio.Wave.WaveOutEvent
            Dim mp3reader As New NAudio.Wave.Mp3FileReader(ttsFileName)
            waveout.Init(mp3reader)
            If silent Then DBGLog("正在静默播放模式中。")
            If Not silent Then
                If Not IsCoolingDown Then
                    waveout.Play()
                    Statistics.TTS_Succeeded += 1
                    Now.AddSeconds(1)
                    If Settings.Settings.TTSDelayEnabled Then StartCoolDown() '启动冷却
                    If forceDispose Then
                        waveout.Stop()
                        waveout.Dispose()
                        mp3reader.Dispose()
                    End If
                    Delay(120000)
                    waveout.Dispose()
                    mp3reader.Dispose()
                Else
                    Statistics.TTS_PlayedDuringCoolDown += 1
                    DBGLog("正在冷却时间中，将不会播放 TTS。")
                End If
            Else
                Statistics.TTS_Silent += 1
            End If
        Catch ex As Exception When ex.Message.Contains("no MP3 Frames Detected")
            Statistics.DBG_ErrCount += 1
            Statistics.DBG_LastException = ex
            'Retry
            If retryCount < 5 Then
                retryCount += 1
                DBGLog("下载失败: " & ex.Message & "；将在 1 秒后执行第 " & retryCount & " 次重试。")
                Statistics.TTS_DownloadFail += 1
                Delay(1000)
                GoTo retry
            End If
            If retryCount = 5 Then
                retryCount += 1
                DBGLog("下载失败: " & ex.Message & "；即将在 1 秒后执行最后一次重试。")
                Statistics.TTS_DownloadFail += 1
                Delay(1000)
                GoTo retry
            End If
            'Over 5 times
            Log("在重试 5 次以后，TTS 下载失败: " & ex.Message)
            Return False
        Catch ex As Exception
            Statistics.DBG_ErrCount += 1
            Statistics.DBG_LastException = ex
            Statistics.TTS_Failed += 1
            Log("TTS 播放错误: " & ex.ToString)
            Return False
        End Try
        Return True
    End Function

    Public Sub CountDown()
        IsCoolingDown = True
        Statistics.TTS_CoolDown += 1
        Delay(Settings.Settings.TTSDelayValue)
        IsCoolingDown = False
    End Sub

    Public Sub StartCoolDown()
        Dim cThread As New System.Threading.Thread(AddressOf CountDown)
        cThread.Start() '使用新线程 防止阻塞
        GC.Collect() '回收垃圾
    End Sub

#End Region

    Private Sub Main_ReceivedRoomCount(sender As Object, e As BilibiliDM_PluginFramework.ReceivedRoomCountArgs)
        Statistics.DBG_ReceivedRoomCount += 1
        UserCountLatest = e.UserCount
        DBGLog("ReceivedRoomCount Event Handled, data: " & e.UserCount)
    End Sub

    Private Sub Main_ReceivedDanmaku(sender As Object, e As BilibiliDM_PluginFramework.ReceivedDanmakuArgs)
        If e.Danmaku.MsgType = BilibiliDM_PluginFramework.MsgTypeEnum.Comment Then
            If Settings.Settings.TTSDanmakuSender Then
                Dim unreplacedText As String = Settings.Settings.DanmakuText
                Dim replacedText As String = unreplacedText.Replace("$USER", e.Danmaku.CommentUser).Replace("$DM", e.Danmaku.CommentText)
                PlayTTS(replacedText)
            Else
                Dim unreplacedText As String = Settings.Settings.DanmakuText
                Dim replacedText As String = unreplacedText.Replace("$USER", "").Replace("$DM", e.Danmaku.CommentText)
                PlayTTS(replacedText)
            End If
        End If
        If e.Danmaku.MsgType = BilibiliDM_PluginFramework.MsgTypeEnum.GiftSend Then
            'DBGLog("收到来自 " & e.Danmaku.GiftUser & " 的 " & e.Danmaku.GiftNum & " 个 " & e.Danmaku.GiftName & "。")
            Dim unreplacedText As String = Settings.Settings.GiftsText
            Dim replacedText As String = unreplacedText.Replace("$USER", e.Danmaku.GiftUser).Replace("$COUNT", e.Danmaku.GiftNum).Replace("$GIFT", e.Danmaku.GiftName)
            PlayTTS(replacedText)
        End If
    End Sub

    Private Sub Main_Disconnected(sender As Object, e As BilibiliDM_PluginFramework.DisconnectEvtArgs)
        'DBGLog("Disconnected Event Handled, data: " & e.Error.ToString)
        'PlayTTS("插件检测到弹幕姬已断开，错误信息: " & e.Error.Message)
    End Sub

    Private Sub Main_Connected(sender As Object, e As BilibiliDM_PluginFramework.ConnectedEvtArgs)
        DBGLog("Connected Event Handled, data: " & e.roomid)
        If IsEnabled Then
            PlayTTS("已成功连接至房间: " & e.roomid)
        End If
    End Sub

    Public Overrides Sub Admin()
        MyBase.Admin()
        'DBGLog("在新线程中打开插件管理界面...")
        'If IsEnabled = False Then Exit Sub
        'Dim pThr As New System.Threading.Thread(AddressOf ShowADM)
        'pThr.Start()
        If My.Computer.Keyboard.ShiftKeyDown Then
            Dim frm As New Form_WizardChooser
            frm.Show()
        Else
            ShowADM()
        End If
    End Sub

    Public Overrides Sub [Stop]()
        MyBase.[Stop]()
        ''請勿使用任何阻塞方法
        If SRThread?.IsAlive Then
            SRThread.Abort()
        End If
        IsEnabled = False
        Console.WriteLine("Plugin Stoped!")
        Log("插件已停止。")
    End Sub

    Public Overrides Sub Start()
        MyBase.Start()
        '請勿使用任何阻塞方法
        Dim startSW As New Stopwatch
        startSW.Start()
        Dim startupFailure As Boolean = False
        Log("正在启动...")
        Try
            Settings.Methods.Initialize()
            DBGLog("设置初始化成功: ")
            DBGLog("DebugMode: " & Settings.Settings.DebugMode)
            DBGLog("TTSDanmakuSender: " & Settings.Settings.TTSDanmakuSender)
            DBGLog("TTSGifts: " & Settings.Settings.TTSGiftsReceived)
            DBGLog("AutoClearCache: " & Settings.Settings.AutoClearCache)
            DBGLog("TTSDelayEnabled: " & Settings.Settings.TTSDelayEnabled)
            DBGLog("TTSDelayValue: " & Settings.Settings.TTSDelayValue)
            DBGLog("GiftsText: " & Settings.Settings.GiftsText)
            DBGLog("DanmakuText: " & Settings.Settings.DanmakuText)
            DBGLog("StatusReport: " & Settings.Settings.StatusReport)
            DBGLog("StatusReportContent: " & Settings.Settings.StatusReportContent)
            DBGLog("StatusReportInterval: " & Settings.Settings.StatusReportInterval)
            DBGLog("StatusReport_ResolveAdvVars: " & Settings.Settings.StatusReport_ResolveAdvVars)
        Catch ex As Exception
            Log("启动失败 - 无法初始化设置系统: " & ex.ToString)
            startupFailure = True
            [Stop]()
        End Try
        If Settings.Settings.AutoClearCache Then
            DBGLog("自动缓存清理已启动")
            DBGLog("正在准备...")
            Dim totalSize As Long = 0
            Dim count As Integer = 0
            Try
                Dim rmrf As New System.IO.DirectoryInfo(Settings.Vars.CacheDir)
                For Each file As System.IO.FileInfo In rmrf.GetFiles
                    DBGLog("正在删除: " & file.FullName)
                    totalSize += file.Length
                    file.Delete()
                    count += 1
                    DoEvents()
                Next
            Catch ex As Exception
                Log("缓存清除失败，中断: " & ex.Message)
                Log("在中断前已有 " & count & " 个文件清理成功。总大小: " & totalSize / 1024 & " KiB.")
                GoTo APIs
            End Try
            DBGLog("操作成功: " & count & " 个。")
            Log("总大小为 " & totalSize / 1024 & " KiB 的 " & count & " 个缓存文件已被自动清除。")
        End If
APIs:
        DBGLog("正在准备 API...")
        Try
            DoEvents()
            If Not PlayTTS("TTSDanmaku Initialization.", True) Then
                NBlockMsgBox("API 异常，请注意 TTSDanmaku 可能无法正常工作。", vbExclamation + vbOKOnly + vbSystemModal, "TTSDanmaku Alert")
            End If
        Catch ex As Exception
            Log("启动失败 - TTS 播放时出现错误: " & ex.ToString)
            startupFailure = True
            [Stop]()
        End Try
        DBGLog("初始化统计系统...")
        Statistics.ResetStats()
        DBGLog("启动状态报告守护线程...")
        StartStatusReport()
        'If Settings.Settings.StatusReport Then
        '    NBlockMsgBox("状态报告已启动，这可能会阻止弹幕姬正常退出。" & vbCrLf & "请务必在退出弹幕姬之前停止插件！", vbExclamation + vbSystemModal + vbOKOnly, "TTSDanmaku")
        'End If
        GC.Collect()
        Console.WriteLine("Plugin Started!")
        startSW.Stop()
        If startupFailure Then
            Log("启动过程中出现无法恢复的错误，请检查日志。")
            Exit Sub
        End If
        Me.Log("已启动成功! 耗时: " & startSW.Elapsed.TotalSeconds & "s.")
        If startSW.ElapsedMilliseconds > 5000 Then
            Log("TTSDanmaku 启动用时比以往来得久...如有条件请将 TTSDanmaku 自动清理缓存选项关闭。")
        End If
        IsEnabled = True
    End Sub

    Public Overrides Sub DeInit()
        MyBase.DeInit()
        If SRThread?.IsAlive Then
            SRThread.Abort()
        End If
        IsEnabled = False
    End Sub

End Class
