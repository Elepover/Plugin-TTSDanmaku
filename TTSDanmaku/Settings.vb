' Settings.vb
' Copyright (C) 2017 Elepover, Genteure.

' Basic configurations directory tree:
' -----------------------------------
' TTSDanmaku.dll
' NAudio.dll
' 
' TTSDanmaku
' |- blocking
' |  |- blacklist.ini
' |  |- whitelist.ini
' |  |- gifts
' |  |  |- blacklist.ini
' |  |  |- whitelist.ini
' |- cache
' |  |- TTS*.mp3
' |  |- ...
' -----------------------------------
'
' Thanks to Hxert for Logical Optimization.
'

Imports System.IO
Imports System.Text


Namespace Settings
    ''' <summary>
    ''' Current Settings
    ''' </summary>
    Public Class Settings
        Sub New()
            DebugMode = False
            TTSDanmakuSender = True
            TTSGiftsReceived = True
            AutoClearCache = True
            TTSDelayEnabled = False
            TTSDelayValue = 5000
            DanmakuText = "$USER 说: $DM"
            GiftsText = "收到来自 $USER 的 $COUNT 个 $GIFT"
            Engine = 0
            StatusReport = False
            StatusReport_ResolveAdvVars = True
            StatusReportInterval = 60
            StatusReportContent = "当前在线人数: $ONLINE, 弹幕总数: $TOTALDM, 现在是 $YEAR 年 $MONTH 月 $DAY 日，$HOUR 时 $MINUTE 分 $SEC 秒，当前物理内存可用 $MEMAVAI GB，已用百分之 $MPERCENT，虚拟内存可用 $VMEM GB，已用百分之 $VPERCENT_VM。"
            TTSVolume = 100
            DoNotKeepCache = False
            ConnectSuccessful = "已成功连接至房间: %s"
            DLFailRetry = 5
            ProxySettings_ProxyServer = ""
            ProxySettings_ProxyPort = 0
            ProxySettings_ProxyUser = ""
            ProxySettings_ProxyPassword = ""
            HTTPSPreference = True
            UseGoogleGlobal = False
            NETFramework_VoiceSpeed = 0
            Block_Mode = 0
            GiftBlock_Mode = 0
            Blacklist = ""
            Whitelist = ""
            GiftBlacklist = ""
            GiftWhitelist = ""
            ReadInArray = True
            BlockType = 0
            MiniumDMLength = 1
            FirstUseTrayIcon = True
            ShowTrayIcon = True
            AutoUpdEnabled = True
        End Sub
        ''' <summary>
        ''' 只读设置项, API 字符串。
        ''' </summary>
        ''' <returns></returns>
        Public Shared ReadOnly Property APIString As String
            Get
                If Settings.HTTPSPreference Then
                    Return "https://fanyi.baidu.com/gettts?lan=zh&text=ZoharWang&spd=5&source=web"
                Else
                    Return "http://fanyi.baidu.com/gettts?lan=zh&text=ZoharWang&spd=5&source=web"
                End If
            End Get
        End Property
        ''' <summary>
        ''' 只读设置项, 用户名变量。
        ''' </summary>
        ''' <returns></returns>
        Public Shared ReadOnly Property UserNameVar As String = "$USER"
        ''' <summary>
        ''' 只读设置项, 礼物名称变量。
        ''' </summary>
        ''' <returns></returns>
        Public Shared ReadOnly Property GiftVar As String = "$GIFT"
        ''' <summary>
        ''' 只读设置项, 收到的礼物个数变量。
        ''' </summary>
        ''' <returns></returns>
        Public Shared ReadOnly Property GiftCount As String = "$COUNT"
        ''' <summary>
        ''' 只读设置项, 弹幕内容变量。
        ''' </summary>
        ''' <returns></returns>
        Public Shared ReadOnly Property DanmakuContent As String = "$DM"


        ''' <summary>
        ''' 只读设置项，当前直播间人数对应变量。
        ''' </summary>
        ''' <returns></returns>
        Public Shared ReadOnly Property StatusR_VAR_OnlineUsers As String = "$ONLINE"
        ''' <summary>
        ''' 只读设置项，当前系统时间 小时
        ''' </summary>
        ''' <returns></returns>
        Public Shared ReadOnly Property StatusR_VAR_OS_TIME_H As String = "$HOUR"
        ''' <summary>
        ''' 只读设置项，当前系统时间 分钟
        ''' </summary>
        ''' <returns></returns>
        Public Shared ReadOnly Property StatusR_VAR_OS_TIME_MIN As String = "$MINUTE"
        ''' <summary>
        ''' 只读设置项，当前系统时间 秒
        ''' </summary>
        ''' <returns></returns>
        Public Shared ReadOnly Property StatusR_VAR_OS_TIME_S As String = "$SEC"
        ''' <summary>
        ''' 只读设置项，当前系统时间 日
        ''' </summary>
        ''' <returns></returns>
        Public Shared ReadOnly Property StatusR_VAR_OS_TIME_D As String = "$DAY"
        ''' <summary>
        ''' 只读设置项，当前系统时间 月
        ''' </summary>
        ''' <returns></returns>
        Public Shared ReadOnly Property StatusR_VAR_OS_TIME_MO As String = "$MONTH"
        ''' <summary>
        ''' 只读设置项，当前系统时间 年
        ''' </summary>
        ''' <returns></returns>
        Public Shared ReadOnly Property StatusR_VAR_OS_TIME_Y As String = "$YEAR"
        ''' <summary>
        ''' 只读设置项，当前可用物理内存
        ''' </summary>
        ''' <returns></returns>
        Public Shared ReadOnly Property StatusR_VAR_OS_MEMAVAI As String = "$MEMAVAI"
        ''' <summary>
        ''' 只读设置项，当前物理内存占用率
        ''' </summary>
        ''' <returns></returns>
        Public Shared ReadOnly Property StatusR_VAR_OS_MEMUSAGE As String = "$MPERCENT"
        ''' <summary>
        ''' 只读设置项，当前可用虚拟内存
        ''' </summary>
        ''' <returns></returns>
        Public Shared ReadOnly Property StatusR_VAR_OS_VMEMAVAI As String = "$VMEM"
        ''' <summary>
        ''' 只读设置项，当前虚拟内存使用率
        ''' </summary>
        ''' <returns></returns>
        Public Shared ReadOnly Property StatusR_VAR_OS_VMEMUSAGE As String = "$PERCENT_VM"
        ''' <summary>
        ''' 只读设置项，总收到弹幕
        ''' </summary>
        ''' <returns></returns>
        Public Shared ReadOnly Property StatusR_VAR_DM_DMCOCUNT As String = "$TOTALDM"

        ''' <summary>
        ''' 调试模式是否启用
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property DebugMode As Boolean
        ''' <summary>
        ''' 是否读出弹幕发送者
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property TTSDanmakuSender As Boolean
        ''' <summary>
        ''' 是否读出收到的礼物
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property TTSGiftsReceived As Boolean
        ''' <summary>
        ''' 自动清理缓存是否启用
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property AutoClearCache As Boolean
        ''' <summary>
        ''' 新增于 2017/04/25 17:34 - 是否启用 TTS 冷却
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property TTSDelayEnabled As Boolean
        ''' <summary>
        ''' 新增于 2017/04/25 17:34 - TTS 冷却值
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property TTSDelayValue As Long
        ''' <summary>
        ''' 新增于 2017/05/21 10:18 - 自定义礼物读出文本。
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property GiftsText As String
        ''' <summary>
        ''' 新增于 2017/05/21 10:18 - 自定义弹幕读出文本。
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property DanmakuText As String
        ''' <summary>
        ''' 新增于 2017/05/28 22:09 - 弹幕引擎 (0 = 毒瘤, 1 = .NET, 2 = Does not exist)
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property Engine As Integer
#Region "Status Reporting"
        ''' <summary>
        ''' 新增于 2017/05/29 23:30 - 是否启用状态报告。
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property StatusReport As Boolean
        ''' <summary>
        ''' 新增于 2017/05/29 23:30 - 状态报告时间间隔。
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property StatusReportInterval As Integer
        ''' <summary>
        ''' 新增于 2017/05/30 00:38 - 状态报告内容
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property StatusReportContent As String
        ''' <summary>
        ''' 新增于 2017/05/29 23:30 - 是否启用状态报告高级变量。
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property StatusReport_ResolveAdvVars As Boolean
#End Region
        ''' <summary>
        ''' 新增于 2017/06/24 20:50 - TTS 播放音量
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property TTSVolume As Integer
        ''' <summary>
        ''' 新增于 2017/07/08 00:08 - 缓存文件使用后立即删除
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property DoNotKeepCache As Boolean
        ''' <summary>
        ''' 新增于 2017/07/16 17:53 - 成功连接到房间后的读出内容
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property ConnectSuccessful As String
        ''' <summary>
        ''' 新增于 2017/07/16 17:53 - 下载失败后的重试次数，默认为 5
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property DLFailRetry As Short = 5
#Region "Proxy"
        ''' <summary>
        ''' 新增于 2017/07/28 17:01 - 代理服务器
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property ProxySettings_ProxyServer As String
        ''' <summary>
        ''' 新增于 2017/07/28 17:01 - 代理端口
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property ProxySettings_ProxyPort As Integer
        ''' <summary>
        ''' 新增于 2017/07/28 17:01 - 代理用户
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property ProxySettings_ProxyUser As String
        ''' <summary>
        ''' 新增于 2017/07/28 17:01 - 代理密码
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property ProxySettings_ProxyPassword As String
        ''' <summary>
        ''' 新增于 2017/07/28 17:01 - 是否使用 HTTPS
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property HTTPSPreference As Boolean
        ''' <summary>
        ''' 新增于 2017/07/28 17:01 - 是否使用 Google Global
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property UseGoogleGlobal As Boolean
#End Region
#Region ".NET Framework TTS"
        ''' <summary>
        ''' 新增于 2017/08/09 09:08 - NET 框架引擎语速
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property NETFramework_VoiceSpeed As String
#End Region
#Region "Blocking Settings"
        ''' <summary>
        ''' 新增于 2017/08/09 09:08 - 屏蔽模式 (0 = 已关闭, 1 = 黑名单, 2 = 白名单)
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property Block_Mode As String
        ''' <summary>
        ''' 新增于 2017/08/09 09:08 - 礼物屏蔽模式 (0 = 已关闭, 1 = 黑名单, 2 = 白名单)
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property GiftBlock_Mode As String
#End Region
        ''' <summary>
        ''' 常驻内存，黑名单
        ''' </summary>
        Public Shared Blacklist As String
        ''' <summary>
        ''' 常驻内存，白名单
        ''' </summary>
        Public Shared Whitelist As String
        ''' <summary>
        ''' 常驻内存，礼物黑名单
        ''' </summary>
        Public Shared GiftBlacklist As String
        ''' <summary>
        ''' 常驻内存，礼物白名单
        ''' </summary>
        Public Shared GiftWhitelist As String
        ''' <summary>
        ''' 队列读出
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property ReadInArray As Boolean
        ''' <summary>
        ''' 屏蔽类型 (0 = UID, 1 = 用户名)
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property BlockType As String
        ''' <summary>
        ''' 最少弹幕字数限制
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property MiniumDMLength As String
        ''' <summary>
        ''' 首次使用通知栏图标
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property FirstUseTrayIcon As Boolean
        ''' <summary>
        ''' 是否展示通知栏图标
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property ShowTrayIcon As Boolean
        ''' <summary>
        ''' 是否启用自动更新
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property AutoUpdEnabled As Boolean
    End Class

    Public Class Vars
        Public Shared Sub Initialize()
            PluginDir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
            LibFileName = Path.Combine(PluginDir, "NAudio.dll")
            ConfigurationDir = Path.Combine(PluginDir, "TTSDanmaku")
            ConfigFileName = Path.Combine(ConfigurationDir, "config.ini")
            CacheDir = Path.Combine(ConfigurationDir, "cache")
            BlacklistDir = Path.Combine(ConfigurationDir, "blocking")
            GiftBlacklistDir = Path.Combine(BlacklistDir, "gifts")
        End Sub
        Public Shared Property ConfigurationDir As String '配置文件夹
        Public Shared Property ConfigFileName As String '配置文件名
        Public Shared Property CacheDir As String '缓存文件夹
        Public Shared Property LibFileName As String 'NAudio 文件名
        Public Shared Property PluginDir As String '弹幕姬插件目录
        Public Shared Property BlacklistDir As String '屏蔽配置目录
        Public Shared Property GiftBlacklistDir As String '礼物屏蔽配置目录
    End Class

    Public Class Methods
        Public Shared Sub Initialize()
            Vars.Initialize()
            InitializeDirectories()
            InitializeSettingsFile()
        End Sub

        Public Shared Sub InitializeDirectories()
            '初始化设置系统 -> 寻找文件夹
            '%USERPROFILE%\Documents\弹幕姬\Plugins\TTSDanmaku
            '%USERPROFILE%\Documents\弹幕姬\Plugins\TTSDanmaku\cache
            If Not Directory.Exists(Vars.ConfigurationDir) Then
                Directory.CreateDirectory(Vars.ConfigurationDir)
            End If
            If Not Directory.Exists(Vars.CacheDir) Then
                Directory.CreateDirectory(Vars.CacheDir)
            End If
            If Not Directory.Exists(Vars.BlacklistDir) Then
                Directory.CreateDirectory(Vars.BlacklistDir)
            End If
            If Not Directory.Exists(Vars.GiftBlacklistDir) Then
                Directory.CreateDirectory(Vars.GiftBlacklistDir)
            End If
        End Sub

        Public Shared Sub InitializeSettingsFile()

            If Not ReadSettings() Then
                CreateSettingsFile()
            End If

            'If Not File.Exists(Vars.LibFileName) Then
            '    Dim [bytes]() As Byte = My.Resources.libNAudio
            '    Dim [stream] As Stream = File.Create(Vars.LibFileName)
            '    [stream].Write([bytes], 0, [bytes].Length)
            '    [stream].Close()
            'End If
            If Not File.Exists(Path.Combine(Vars.PluginDir, "NAudio.dll")) Then
                Dim [bytes]() As Byte = My.Resources.libNAudio
                Dim [stream] As Stream = File.Create(Path.Combine(Vars.PluginDir, "NAudio.dll"))
                [stream].Write([bytes], 0, [bytes].Length)
                [stream].Close()
            End If
        End Sub

        Public Shared Function ReadSettings() As Boolean
            Dim SettingsReader As StreamReader = Nothing
            Dim BlacklistReader As StreamReader = Nothing
            Dim WhitelistReader As StreamReader = Nothing
            Dim GiftBlacklistReader As StreamReader = Nothing
            Dim GiftWhitelistReader As StreamReader = Nothing
            Try
                SettingsReader = New StreamReader(Vars.ConfigFileName, Encoding.UTF8)
                BlacklistReader = New StreamReader(Path.Combine(Vars.BlacklistDir, "blacklist.ini"), Encoding.UTF8)
                WhitelistReader = New StreamReader(Path.Combine(Vars.BlacklistDir, "whitelist.ini"), Encoding.UTF8)
                GiftBlacklistReader = New StreamReader(Path.Combine(Vars.GiftBlacklistDir, "blacklist.ini"), Encoding.UTF8)
                GiftWhitelistReader = New StreamReader(Path.Combine(Vars.GiftBlacklistDir, "whitelist.ini"), Encoding.UTF8)

                SettingsReader.ReadLine()
                SettingsReader.ReadLine()
                Settings.DebugMode = SettingsReader.ReadLine()
                SettingsReader.ReadLine()
                Settings.TTSDanmakuSender = SettingsReader.ReadLine()
                SettingsReader.ReadLine()
                Settings.TTSGiftsReceived = SettingsReader.ReadLine()
                SettingsReader.ReadLine()
                Settings.AutoClearCache = SettingsReader.ReadLine()
                SettingsReader.ReadLine()
                Settings.TTSDelayEnabled = SettingsReader.ReadLine()
                SettingsReader.ReadLine()
                Settings.TTSDelayValue = SettingsReader.ReadLine()
                SettingsReader.ReadLine()
                Settings.DanmakuText = SettingsReader.ReadLine()
                SettingsReader.ReadLine()
                Settings.GiftsText = SettingsReader.ReadLine()
                SettingsReader.ReadLine()
                Settings.Engine = SettingsReader.ReadLine()
                SettingsReader.ReadLine()
                Settings.StatusReport = SettingsReader.ReadLine()
                SettingsReader.ReadLine()
                Settings.StatusReport_ResolveAdvVars = SettingsReader.ReadLine()
                SettingsReader.ReadLine()
                Settings.StatusReportInterval = SettingsReader.ReadLine()
                SettingsReader.ReadLine()
                Settings.StatusReportContent = SettingsReader.ReadLine()
                SettingsReader.ReadLine()
                Settings.TTSVolume = SettingsReader.ReadLine()
                SettingsReader.ReadLine()
                Settings.DoNotKeepCache = SettingsReader.ReadLine()
                SettingsReader.ReadLine()
                Settings.ConnectSuccessful = SettingsReader.ReadLine()
                SettingsReader.ReadLine()
                Settings.DLFailRetry = SettingsReader.ReadLine()
                SettingsReader.ReadLine()
                Settings.ProxySettings_ProxyServer = SettingsReader.ReadLine()
                SettingsReader.ReadLine()
                Settings.ProxySettings_ProxyPort = SettingsReader.ReadLine()
                SettingsReader.ReadLine()
                Settings.ProxySettings_ProxyUser = SettingsReader.ReadLine()
                SettingsReader.ReadLine()
                Settings.ProxySettings_ProxyPassword = SettingsReader.ReadLine()
                SettingsReader.ReadLine()
                Settings.HTTPSPreference = SettingsReader.ReadLine()
                SettingsReader.ReadLine()
                Settings.UseGoogleGlobal = SettingsReader.ReadLine()
                SettingsReader.ReadLine()
                Settings.NETFramework_VoiceSpeed = SettingsReader.ReadLine()
                SettingsReader.ReadLine()
                Settings.Block_Mode = SettingsReader.ReadLine()
                SettingsReader.ReadLine()
                Settings.GiftBlock_Mode = SettingsReader.ReadLine()
                SettingsReader.ReadLine()
                Settings.ReadInArray = SettingsReader.ReadLine()
                SettingsReader.ReadLine()
                Settings.BlockType = SettingsReader.ReadLine()
                SettingsReader.ReadLine()
                Settings.MiniumDMLength = SettingsReader.ReadLine()
                SettingsReader.ReadLine()
                Settings.FirstUseTrayIcon = SettingsReader.ReadLine()
                SettingsReader.ReadLine()
                Settings.ShowTrayIcon = SettingsReader.ReadLine()
                SettingsReader.ReadLine()
                Settings.AutoUpdEnabled = SettingsReader.ReadLine()

                SettingsReader.Close()

                Settings.Blacklist = BlacklistReader.ReadToEnd()
                BlacklistReader.Close()

                Settings.Whitelist = WhitelistReader.ReadToEnd()
                WhitelistReader.Close()

                Settings.GiftBlacklist = GiftBlacklistReader.ReadToEnd()
                GiftBlacklistReader.Close()

                Settings.GiftWhitelist = GiftWhitelistReader.ReadToEnd()
                GiftWhitelistReader.Close()

                Return True
            Catch ex As Exception
                Try
                    SettingsReader.Close()
                    BlacklistReader.Close()
                    WhitelistReader.Close()
                    GiftBlacklistReader.Close()
                    GiftWhitelistReader.Close()
                Catch ex2 As Exception
                End Try
                Return False
            End Try
        End Function

        Public Shared Sub CreateSettingsFile()
            '初始化设置系统 -> 寻找基本文件
            '%USERPROFILE%\Documents\弹幕姬\Plugins\TTSDanmaku\config.ini
            '%USERPROFILE%\Documents\弹幕姬\Plugins\TTSDanmaku\libNAudio.dll
            Dim SettingsWriter As New StreamWriter(Vars.ConfigFileName, False, Encoding.UTF8) With {.AutoFlush = True}
            SettingsWriter.WriteLine("[TTSDanmaku 配置文件]")
            SettingsWriter.WriteLine("启用调试模式:")
            SettingsWriter.WriteLine("False")
            SettingsWriter.WriteLine("读出弹幕发送者昵称:")
            SettingsWriter.WriteLine("True")
            SettingsWriter.WriteLine("读出收到的礼物:")
            SettingsWriter.WriteLine("True")
            SettingsWriter.WriteLine("自动清理缓存:")
            SettingsWriter.WriteLine("True")
            SettingsWriter.WriteLine("[已弃用] 启用 TTS 冷却:")
            SettingsWriter.WriteLine("False")
            SettingsWriter.WriteLine("[已弃用] TTS 冷却值(毫秒):")
            SettingsWriter.WriteLine("5000")
            SettingsWriter.WriteLine("自定义收到弹幕读出内容:")
            SettingsWriter.WriteLine("$USER 说: $DM")
            SettingsWriter.WriteLine("自定义收到礼物读出内容:")
            SettingsWriter.WriteLine("收到来自 $USER 的 $COUNT 个 $GIFT")
            SettingsWriter.WriteLine("选择 TTS 引擎（0 = 百度翻译 API; 1 = .NET 框架自带; 2 = 不存在的公司）: ")
            SettingsWriter.WriteLine("0")
            SettingsWriter.WriteLine("是否启用状态报告功能:")
            SettingsWriter.WriteLine("False")
            SettingsWriter.WriteLine("是否解析高级变量:")
            SettingsWriter.WriteLine("True")
            SettingsWriter.WriteLine("状态报告时间间隔（秒）:")
            SettingsWriter.WriteLine("60")
            SettingsWriter.WriteLine("状态报告内容:")
            SettingsWriter.WriteLine("当前在线人数: $ONLINE, 弹幕总数: $TOTALDM, 现在是 $YEAR 年 $MONTH 月 $DAY 日，$HOUR 时 $MINUTE 分 $SEC 秒，当前物理内存可用 $MEMAVAI GB，已用百分之 $MPERCENT，虚拟内存可用 $VMEM GB，已用百分之 $VPERCENT_VM。")
            SettingsWriter.WriteLine("TTS 音量:")
            SettingsWriter.WriteLine("100")
            SettingsWriter.WriteLine("播放后立即删除缓存:")
            SettingsWriter.WriteLine("False")
            SettingsWriter.WriteLine("成功连接到房间后的读出内容:")
            SettingsWriter.WriteLine("已成功连接至房间: %s")
            SettingsWriter.WriteLine("下载失败后的重试次数，默认为 5:")
            SettingsWriter.WriteLine("5")
            SettingsWriter.WriteLine("代理服务器 IP:")
            SettingsWriter.WriteLine("")
            SettingsWriter.WriteLine("代理服务器端口:")
            SettingsWriter.WriteLine("0")
            SettingsWriter.WriteLine("代理服务器用户名:")
            SettingsWriter.WriteLine("")
            SettingsWriter.WriteLine("代理服务器密码:")
            SettingsWriter.WriteLine("")
            SettingsWriter.WriteLine("是否使用 HTTPS:")
            SettingsWriter.WriteLine("True")
            SettingsWriter.WriteLine("是否使用 Google Global:")
            SettingsWriter.WriteLine("False")
            SettingsWriter.WriteLine(".NET 框架引擎的语速 (-10 至 10):")
            SettingsWriter.WriteLine("0")
            SettingsWriter.WriteLine("屏蔽模式 (0 = 已关闭, 1 = 黑名单, 2 = 白名单):")
            SettingsWriter.WriteLine("0")
            SettingsWriter.WriteLine("礼物屏蔽模式 (0 = 已关闭, 1 = 黑名单, 2 = 白名单):")
            SettingsWriter.WriteLine("0")
            SettingsWriter.WriteLine("队列读出:")
            SettingsWriter.WriteLine("True")
            SettingsWriter.WriteLine("黑白名单目标 (0 = UID, 1 = 用户名):")
            SettingsWriter.WriteLine(0)
            SettingsWriter.WriteLine("最少弹幕字数限制:")
            SettingsWriter.WriteLine(1)
            SettingsWriter.WriteLine("首次使用通知栏图标:")
            SettingsWriter.WriteLine(True)
            SettingsWriter.WriteLine("显示通知栏图标:")
            SettingsWriter.WriteLine(True)
            SettingsWriter.WriteLine("自动检查更新:")
            SettingsWriter.WriteLine(True)
            SettingsWriter.Close()

            Dim whitelistWriter As New StreamWriter(Path.Combine(Vars.BlacklistDir, "whitelist.ini"), False, Encoding.UTF8) With {.AutoFlush = True}
            Dim blacklistWriter As New StreamWriter(Path.Combine(Vars.BlacklistDir, "blacklist.ini"), False, Encoding.UTF8) With {.AutoFlush = True}
            whitelistWriter.Close()
            blacklistWriter.Close()

            Dim giftWhitelistWriter As New StreamWriter(Path.Combine(Vars.GiftBlacklistDir, "whitelist.ini"), False, Encoding.UTF8) With {.AutoFlush = True}
            Dim giftBlacklistWriter As New StreamWriter(Path.Combine(Vars.GiftBlacklistDir, "blacklist.ini"), False, Encoding.UTF8) With {.AutoFlush = True}
            giftWhitelistWriter.Close()
            giftBlacklistWriter.Close()

            ReadSettings()
        End Sub

        Public Shared Sub SaveSettings()
            Dim SettingsWriter As New StreamWriter(Vars.ConfigFileName, False, Encoding.UTF8) With {.AutoFlush = True}
            SettingsWriter.WriteLine("[TTSDanmaku 配置文件]")
            SettingsWriter.WriteLine("启用调试模式:")
            SettingsWriter.WriteLine(Settings.DebugMode)
            SettingsWriter.WriteLine("读出弹幕发送者昵称:")
            SettingsWriter.WriteLine(Settings.TTSDanmakuSender)
            SettingsWriter.WriteLine("读出收到的礼物:")
            SettingsWriter.WriteLine(Settings.TTSGiftsReceived)
            SettingsWriter.WriteLine("自动清理缓存:")
            SettingsWriter.WriteLine(Settings.AutoClearCache)
            SettingsWriter.WriteLine("[已弃用] 启用 TTS 冷却:")
            SettingsWriter.WriteLine(Settings.TTSDelayEnabled)
            SettingsWriter.WriteLine("[已弃用] TTS 冷却值(毫秒):")
            SettingsWriter.WriteLine(Settings.TTSDelayValue)
            SettingsWriter.WriteLine("自定义收到弹幕读出内容:")
            SettingsWriter.WriteLine(Settings.DanmakuText)
            SettingsWriter.WriteLine("自定义收到礼物读出内容:")
            SettingsWriter.WriteLine(Settings.GiftsText)
            SettingsWriter.WriteLine("选择 TTS 引擎（0 = 百度翻译 API; 1 = .NET 框架自带; 2 = 不存在的公司）: ")
            SettingsWriter.WriteLine(Settings.Engine)
            SettingsWriter.WriteLine("是否启用状态报告功能:")
            SettingsWriter.WriteLine(Settings.StatusReport)
            SettingsWriter.WriteLine("是否解析高级变量:")
            SettingsWriter.WriteLine(Settings.StatusReport_ResolveAdvVars)
            SettingsWriter.WriteLine("状态报告时间间隔（秒）:")
            SettingsWriter.WriteLine(Settings.StatusReportInterval)
            SettingsWriter.WriteLine("状态报告内容:")
            SettingsWriter.WriteLine(Settings.StatusReportContent)
            SettingsWriter.WriteLine("TTS 音量:")
            SettingsWriter.WriteLine(Settings.TTSVolume)
            SettingsWriter.WriteLine("播放后立即删除缓存:")
            SettingsWriter.WriteLine(Settings.DoNotKeepCache)
            SettingsWriter.WriteLine("成功连接到房间后的读出内容:")
            SettingsWriter.WriteLine(Settings.ConnectSuccessful)
            SettingsWriter.WriteLine("下载失败后的重试次数，默认为 5:")
            SettingsWriter.WriteLine(Settings.DLFailRetry)
            SettingsWriter.WriteLine("代理服务器 IP:")
            SettingsWriter.WriteLine(Settings.ProxySettings_ProxyServer)
            SettingsWriter.WriteLine("代理服务器端口:")
            SettingsWriter.WriteLine(Settings.ProxySettings_ProxyPort)
            SettingsWriter.WriteLine("代理服务器用户名:")
            SettingsWriter.WriteLine(Settings.ProxySettings_ProxyUser)
            SettingsWriter.WriteLine("代理服务器密码:")
            SettingsWriter.WriteLine(Settings.ProxySettings_ProxyPassword)
            SettingsWriter.WriteLine("是否使用 HTTPS:")
            SettingsWriter.WriteLine(Settings.HTTPSPreference)
            SettingsWriter.WriteLine("是否使用 Google Global:")
            SettingsWriter.WriteLine(Settings.UseGoogleGlobal)
            SettingsWriter.WriteLine(".NET 框架引擎的语速 (-10 至 10)")
            SettingsWriter.WriteLine(Settings.NETFramework_VoiceSpeed)
            SettingsWriter.WriteLine("屏蔽模式 (0 = 已关闭, 1 = 黑名单, 2 = 白名单)")
            SettingsWriter.WriteLine(Settings.Block_Mode)
            SettingsWriter.WriteLine("礼物屏蔽模式 (0 = 已关闭, 1 = 黑名单, 2 = 白名单)")
            SettingsWriter.WriteLine(Settings.GiftBlock_Mode)
            SettingsWriter.WriteLine("队列读出")
            SettingsWriter.WriteLine(Settings.ReadInArray)
            SettingsWriter.WriteLine("黑白名单目标 (0 = UID, 1 = 用户名)")
            SettingsWriter.WriteLine(Settings.BlockType)
            SettingsWriter.WriteLine("最少弹幕字数限制:")
            SettingsWriter.WriteLine(Settings.MiniumDMLength)
            SettingsWriter.WriteLine("首次使用通知栏图标:")
            SettingsWriter.WriteLine(Settings.FirstUseTrayIcon)
            SettingsWriter.WriteLine("显示通知栏图标:")
            SettingsWriter.WriteLine(Settings.ShowTrayIcon)
            SettingsWriter.WriteLine("自动检查更新:")
            SettingsWriter.WriteLine(Settings.AutoUpdEnabled)
            SettingsWriter.Close()

            Dim whitelistWriter As New StreamWriter(Path.Combine(Vars.BlacklistDir, "whitelist.ini"), False, Encoding.UTF8) With {.AutoFlush = True}
            Dim blacklistWriter As New StreamWriter(Path.Combine(Vars.BlacklistDir, "blacklist.ini"), False, Encoding.UTF8) With {.AutoFlush = True}
            whitelistWriter.Write(Settings.Whitelist)
            blacklistWriter.Write(Settings.Blacklist)
            whitelistWriter.Close()
            blacklistWriter.Close()

            Dim giftWhitelistWriter As New StreamWriter(Path.Combine(Vars.GiftBlacklistDir, "whitelist.ini"), False, Encoding.UTF8) With {.AutoFlush = True}
            Dim giftBlacklistWriter As New StreamWriter(Path.Combine(Vars.GiftBlacklistDir, "blacklist.ini"), False, Encoding.UTF8) With {.AutoFlush = True}
            giftWhitelistWriter.Write(Settings.GiftWhitelist)
            giftBlacklistWriter.Write(Settings.GiftBlacklist)
            giftWhitelistWriter.Close()
            giftBlacklistWriter.Close()
        End Sub
    End Class
End Namespace
