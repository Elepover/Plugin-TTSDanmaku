Imports System.Windows

Public Class Window_SpeakAnything

    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

    End Sub

    Private Sub DBGLog(text As String)
        TextBox_Log.AppendText(text & vbCrLf)
    End Sub
    ''' <summary>
    ''' 下载并播放 TTS 文件。
    ''' </summary>
    ''' <param name="content">TTS 内容。</param>
    ''' <param name="silent">静默模式，调试用。</param>
    ''' <param name="sysMsg">系统消息，启用此选项将无视冷却时间。</param>
    ''' <param name="forceDispose">播放后瞬间强行释放资源（不播放）</param>
    ''' <returns></returns>
    Public Function PlayTTS(content As String, Optional silent As Boolean = False, Optional sysMsg As Boolean = False, Optional forceDispose As Boolean = False) As Boolean
        'Proxy preprocessing
        Dim useProxy As Boolean = True
#Disable Warning 'mmp
        Dim proxy As System.Net.WebProxy = System.Net.WebProxy.GetDefaultProxy
#Enable Warning
        If Settings.Settings.ProxySettings_ProxyServer = "" Then
            useProxy = False
        End If
        If useProxy Then
            proxy = New System.Net.WebProxy(Settings.Settings.ProxySettings_ProxyServer, Settings.Settings.ProxySettings_ProxyPort)
        End If


        If Settings.Settings.Engine = 1 Then
            Try
                DBGLog("Selected .NET Framework as default TTS Engine.")
                If silent Then DBGLog("Playing with silent mode.")
                If Not silent Then
                    DBGLog("Attempting playing: " & content)
                    SpeechOutput(content, GetRandomFilename)
                    Return True
                Else
                    Return True
                End If
            Catch ex As Exception
                DBGLog("TTS playing failed: " & ex.ToString)
                Return False
            End Try
        End If

        If Settings.Settings.Engine = 2 Then
            Try
                DBGLog("Using Google Translate API.")
                If silent Then DBGLog("Playing with silent mode.")
                If Not silent Then
                    DBGLog("Starting playing: " & content)
                    If useProxy Then
                        GoogleTTS(content,,, True, proxy)
                    Else
                        GoogleTTS(content)
                    End If
                    Return True
                Else
                    Return True
                End If
            Catch ex As Exception
                DBGLog("TTS playing failed: " & ex.ToString)
                Return False
            End Try
        End If

        Dim retryCount As Short = 0
retry:
        DBGLog("Attempting playing: " & content)
        'Download
        Dim ttsFileName As String = ""
        Dim timer As New Stopwatch
        timer.Start()
        Try
            Dim client As New Net.WebClient()
            If useProxy Then
                client.Proxy = proxy
            End If
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
            If Settings.Settings.DLFailRetry = 0 Then
                DBGLog("Downloading failed, dropped. (DLFailRetry = 0)")
                Return False
            End If
            If retryCount < Settings.Settings.DLFailRetry Then
                retryCount += 1
                DBGLog("Download failed: " & ex.Message & ", will attempt " & retryCount & "th retry after 1s.")
                Delay(1000)
                GoTo retry
            End If
            If retryCount = Settings.Settings.DLFailRetry Then
                retryCount += 1
                DBGLog("Download failed: " & ex.Message & ".")
                Delay(1000)
                GoTo retry
            End If
            'Over 5 times
            DBGLog("After " & Settings.Settings.DLFailRetry & " retry attemps, TTS downloading failed: " & ex.Message)
            Return False
        End Try
        timer.Stop()
        If Not retryCount = 0 Then DBGLog("After " & retryCount & " retries, TTS downloading finished succcessfully.")
        DBGLog("Downloading succeeded, time elapsed: " & timer.Elapsed.TotalMilliseconds & "ms. Filename: " & ttsFileName)
        DBGLog("Starting playing...")
        Try
            Dim waveout As New NAudio.Wave.WaveOutEvent
            Dim mp3reader As New NAudio.Wave.Mp3FileReader(ttsFileName)
            waveout.Init(mp3reader)
            If silent Then DBGLog("Playing with silent mode...")
            If Not silent Then
                waveout.Volume = Settings.Settings.TTSVolume / 100
                waveout.Play()
                Now.AddSeconds(1)
                If forceDispose Then
                    waveout.Stop()
                    waveout.Dispose()
                    mp3reader.Dispose()
                    IO.File.Delete(ttsFileName)
                End If
                Delay(120000)
                waveout.Dispose()
                mp3reader.Dispose()
            Else
            End If
        Catch ex As Exception When ex.Message.Contains("no MP3 Frames Detected")
            'Retry
            If Settings.Settings.DLFailRetry = 0 Then
                DBGLog("Download failed, dropped. (DLFailRetry = 0)")
                Return False
            End If
            If retryCount < Settings.Settings.DLFailRetry Then
                retryCount += 1
                DBGLog("Download failed: " & ex.Message & ", will attempt " & retryCount & "th retry after 1s.")
                Delay(1000)
                GoTo retry
            End If
            If retryCount = Settings.Settings.DLFailRetry Then
                retryCount += 1
                DBGLog("Download failed: " & ex.Message & ", will restart downloading after 1s.")
                Delay(1000)
                GoTo retry
            End If
            'Over 5 times
            DBGLog("Download failed after " & Settings.Settings.DLFailRetry & " retries: " & ex.Message)
            Return False
        Catch ex As Exception
            DBGLog("Fatal: " & ex.ToString)
            Return False
        End Try
        Return True
    End Function

    Private Sub Button_SpeakOut_Click(sender As Object, e As Windows.RoutedEventArgs) Handles Button_SpeakOut.Click
        PlayTTS(TextBox_Text.Text, False, False, False)
    End Sub

    Private Sub Button_Exit_Click(sender As Object, e As Windows.RoutedEventArgs) Handles Button_Exit.Click
        Me.Close()
    End Sub

    Private Sub Button_SpeakOut_Loaded(sender As Object, e As RoutedEventArgs) Handles Button_SpeakOut.Loaded
        Icon = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(My.Resources.icon.GetHbitmap, IntPtr.Zero, Int32Rect.Empty, Media.Imaging.BitmapSizeOptions.FromEmptyOptions())
    End Sub
End Class
