' Includings.vb
' Copyright (C) 2017 Elepover.

Imports System.Net

Module Includings

    '排队读 / TTS Dispatching Center
    Friend WithEvents GlobalPlayer As New NAudio.Wave.WaveOutEvent

    Public Sub PlayFinished(sender As Object, e As NAudio.Wave.StoppedEventArgs) Handles GlobalPlayer.PlaybackStopped
        If Settings.Settings.TTSDelayEnabled Then StartCoolDown() '启动冷却
        If Not PendingTTSes.Count = 0 Then '如果还有就播，没有就丢
            If Not Settings.Settings.DoNotKeepCache = Nothing Then '不要缓存就删
                If Settings.Settings.DoNotKeepCache Then
                    Try
                        IO.File.Delete(PendingFilenames(0))
                    Catch ex As Exception
                        Statistics.DBG_LastException = ex
                    End Try
                End If
            End If
            Try
                GlobalPlayer.Init(PendingTTSes(0))
                GlobalPlayer.Play()
            Catch ex As Exception
            End Try
            PendingTTSes.RemoveAt(0)
            PendingFilenames.RemoveAt(0)
        End If
    End Sub

    Public Sub NPlayTTS(filename As String)
        If IsCoolingDown Then Exit Sub

        GlobalPlayer.Volume = Settings.Settings.TTSVolume / 100

        If Settings.Settings.ReadInArray = False Then
            Try
                Dim waveout As New NAudio.Wave.WaveOutEvent
                waveout.Init(New NAudio.Wave.Mp3FileReader(filename))
                waveout.Play()
                Delay(120000)
                If waveout.PlaybackState = NAudio.Wave.PlaybackState.Playing Then
                    waveout.Stop()
                    waveout.Dispose()
                Else
                    waveout.Dispose()
                End If
            Catch ex As Exception
                Statistics.DBG_ErrCount += 1
                Statistics.DBG_LastException = ex
            Finally
                If Not Settings.Settings.DoNotKeepCache = Nothing Then
                    If Settings.Settings.DoNotKeepCache Then
                        Try
                            IO.File.Delete(filename)
                        Catch ex2 As Exception
                            Statistics.DBG_ErrCount += 1
                            Statistics.DBG_LastException = ex2
                        End Try
                    End If
                End If
            End Try
        Else
            Try
                Dim reader As New NAudio.Wave.Mp3FileReader(filename)
                If GlobalPlayer.PlaybackState = NAudio.Wave.PlaybackState.Playing Then '勃了就添加
                    PendingFilenames.Add(filename)
                    PendingTTSes.Add(reader)
                ElseIf GlobalPlayer.PlaybackState = NAudio.Wave.PlaybackState.Stopped Then '没播就启动
                    PendingTTSes.Add(reader)
                    PendingFilenames.Add(filename)
                    GlobalPlayer.Init(PendingTTSes.ElementAt(0))
                    GlobalPlayer.Play()
                End If
            Catch ex As Exception
                Statistics.DBG_ErrCount += 1
                Statistics.DBG_LastException = ex
            End Try
        End If
    End Sub

    Public PendingTTSes As New List(Of NAudio.Wave.Mp3FileReader)
    Public PendingFilenames As New List(Of String)
    Public IsCoolingDown As Boolean = False

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



    Public Sub Delay(interval As Single)
        Dim TimerCount As Single
        Dim Timer As New Stopwatch
        Timer.Start()
        interval = interval / 1000
        TimerCount = Timer.Elapsed.TotalSeconds + interval
        While TimerCount - Timer.Elapsed.TotalSeconds > 0
            System.Windows.Forms.Application.DoEvents()
            System.Threading.Thread.Sleep(1)
        End While
    End Sub
    ''' <summary>
    ''' 处理队列中 Windows 消息
    ''' </summary>
    Public Sub DoEvents()
        System.Windows.Forms.Application.DoEvents()
    End Sub
    Public Sub NBlockMsgBox(message As String, style As MsgBoxStyle, title As String)
        Dim tmpThr As New NoBlockMsgBox
        tmpThr.NoBlockMsgBox(message, style, title)
    End Sub

    ''' <summary>
    ''' 不阻塞主线程的情况下弹出对话框
    ''' </summary>
    Public Class NoBlockMsgBox '不阻塞主线程的情况下弹出对话框
        ''' <summary>
        ''' 传递给线程的消息
        ''' </summary>
        Private pMessage As String
        ''' <summary>
        ''' 传递给线程的样式信息
        ''' </summary>
        Private pStyle As MsgBoxStyle
        ''' <summary>
        ''' 传递给线程的标题
        ''' </summary>
        Private pTitle As String
        ''' <summary>
        ''' 线程回传的数据
        ''' </summary>
        Public pReturned As MsgBoxResult
        ''' <summary>
        ''' 不阻塞主线程的情况下弹出对话框，主要方法
        ''' </summary>
        ''' <param name="message">消息</param>
        ''' <param name="style">样式</param>
        ''' <param name="title">标题</param>
        Public Sub NoBlockMsgBox(message As String, style As MsgBoxStyle, title As String)
            pMessage = message
            pStyle = style
            pTitle = title
            Dim pThread As New System.Threading.Thread(AddressOf Msg)
            pThread.Start()
        End Sub
        ''' <summary>
        ''' 线程所使用的方法，根据 Class 内传参实现
        ''' </summary>
        Private Sub Msg()
            pReturned = MsgBox(pMessage, pStyle, pTitle)
        End Sub
    End Class

    ''' <summary>
    ''' 向钦定的 URL 发送钦定的请求，获取返回的状（真）态（他）码（妈）
    ''' </summary>
    ''' <param name="url">钦定的 URL</param>
    ''' <param name="method">钦定的方法，默认 HEAD</param>
    ''' <returns></returns>
    Public Function GetHttpStatusCode(url As String, Optional method As String = "HEAD") As Short
        Dim req As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(url)
        req.Method = method
        req.Referer = "https://www.danmuji.cn/plugins/TTSDanmaku"
        req.UserAgent = "TTSDanmaku/23333 (Linux 4.10.11-1 ARCH)"
        req.Timeout = 10000
        Dim response As System.Net.HttpWebResponse = req.GetResponse()
        Return response.StatusCode
    End Function

    ''' <summary>
    ''' 通过官方钦定 Elepover's APIs 获取 IP
    ''' </summary>
    ''' <returns></returns>
    Public Function GetIP() As String
        Return (New WebClient()).DownloadString("https://apis.elepover.com/ip")
    End Function

    ''' <summary>
    ''' 检查一个列表中是否存在某用户
    ''' </summary>
    ''' <param name="list">以换行分割的列表</param>
    ''' <param name="user">目标用户</param>
    ''' <returns></returns>
    Public Function UserExists(list As String, user As String) As Boolean
        Dim strs As String() = list.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
        Dim pass As Boolean = False
        For Each s As String In strs
            If s.Replace(vbCr, "").Replace(vbLf, "").Replace(" ", "") = user.Replace(vbCr, "").Replace(vbLf, "").Replace(" ", "") Then pass = True
        Next
        Return pass
    End Function


    Public Function GetRandomFilename() As String
        Dim ran1 As Integer = 0
        Dim ran2 As Integer = 0
        ran1 = (New Random).Next
        Randomize()
        ran2 = (New Random).Next
        Return Settings.Vars.CacheDir & "\TTS" & ran1 & ran2 & ".mp3"
    End Function

    ''' <summary>
    ''' 使用 .NET 框架自带实现方法读出，未出错则返回 True.
    ''' </summary>
    ''' <param name="text">文本</param>
    Public Sub SpeechOutput(text As String, filename As String)
        Dim obj As New Speech.Synthesis.SpeechSynthesizer() With {.Volume = Settings.Settings.TTSVolume, .Rate = Settings.Settings.NETFramework_VoiceSpeed}
        obj.SetOutputToWaveFile(filename)
        obj.Speak(text)
        NPlayTTS(filename)
    End Sub

    ''' <summary>
    ''' 召唤不存在的404娘语音
    ''' </summary>
    ''' <param name="text"></param>
    ''' <param name="forceDispose">强制释放资源</param>
    Public Sub GoogleTTS(text As String, Optional silent As Boolean = False, Optional forceDispose As Boolean = False, Optional useProxy As Boolean = False, Optional proxy As System.Net.WebProxy = Nothing)
        Dim retryCount As Short = 0
retry:
        Dim filename As String = ""
        Try
            If useProxy Then
                filename = Google.TTS.TTSHelper.GerarArquivo(text, Google.TTS.Idioma.Chinese, Settings.Settings.UseGoogleGlobal, True, proxy)
            Else
                filename = Google.TTS.TTSHelper.GerarArquivo(text, Google.TTS.Idioma.Chinese, Settings.Settings.UseGoogleGlobal)
            End If
        Catch ex As Exception
            If retryCount >= 5 Then Throw ex
            retryCount += 1
            GoTo retry
        End Try
        Try
            If Not silent Then
                NPlayTTS(filename)
            Else
                Statistics.TTS_Silent += 1
            End If
        Catch ex As Exception
            If retryCount >= Settings.Settings.DLFailRetry Then Throw ex
            retryCount += 1
            GoTo retry
        End Try
    End Sub
    Public Class KruinUpdates
        Public Enum UpdateType
            ''' <summary>
            ''' 测试版
            ''' </summary>
            Beta = 1
            ''' <summary>
            ''' 发布版
            ''' </summary>
            Release = 0
        End Enum

        Public Class Update
            Sub New()
                Version = "0.0.0.0"
                Type = UpdateType.Release
            End Sub
            Public Version As String
            Public Type As UpdateType
        End Class

        Public Shared Function CheckUpdatesViaKruinUpdates(Optional Type As UpdateType = UpdateType.Release) As Update
            'Check updates via Elepover's APIs.
            Dim client As New WebClient()
            Dim ver As String
            If Type = UpdateType.Beta Then
                ver = client.DownloadString(New Uri("https://apis.elepover.com/kruinupdates/latest-beta"))
            Else
                ver = client.DownloadString(New Uri("https://apis.elepover.com/kruinupdates/latest-release"))
            End If
            Dim u As New Update() With {.Type = Type, .Version = ver}
            Return u
        End Function
    End Class

End Module
