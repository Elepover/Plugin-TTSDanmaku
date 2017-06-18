' Includings.vb
' Copyright (C) 2017 Elepover.

Imports System.Net

Module Includings
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
            Dim pThread As New System.Threading.Thread(AddressOf msg)
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
    ''' 使用 .NET 框架自带实现方法读出，未出错则返回 True.
    ''' </summary>
    ''' <param name="text">文本</param>
    Public Sub SpeechOutput(text As String)
        Dim obj As New Speech.Synthesis.SpeechSynthesizer() With {.Volume = 9, .Rate = 5}
        obj.SelectVoice("Microsoft Huihui Desktop")
        obj.SpeakAsync(text)
    End Sub

    ''' <summary>
    ''' 召唤不存在的404娘语音
    ''' </summary>
    ''' <param name="text"></param>
    Public Sub GoogleTTS(text As String, Optional silent As Boolean = False)
        Dim retryCount As Short = 0
retry:
        Dim filename As String = ""
        Try
            filename = Google.TTS.TTSHelper.GerarArquivo(text, Google.TTS.Idioma.Chinese)
        Catch ex As Exception
            If retryCount >= 5 Then Throw ex
            retryCount += 1
            GoTo retry
        End Try
        Dim waveout As New NAudio.Wave.WaveOutEvent
        Dim mp3reader As New NAudio.Wave.Mp3FileReader(filename)
        waveout.Init(mp3reader)
        Try
            If Not silent Then waveout.Play()
            Delay(120000)
            waveout.Dispose()
            mp3reader.Dispose()
        Catch ex As Exception
            If retryCount >= 5 Then Throw ex
            retryCount += 1
            GoTo retry
        End Try
    End Sub
End Module

Public Class WizardStatic
    Public Property WizardSettings As Settings.Settings = Nothing
End Class
