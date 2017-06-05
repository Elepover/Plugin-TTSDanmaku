' NetworkWatchdog.vb
' Copyright (C) 2017 Elepover.

Imports System.Net.NetworkInformation
Imports System.Threading
Imports System.Net

Namespace NetworkWatchdog
    ''' <summary>
    ''' Captive 请求获取到的连接状态
    ''' </summary>
    Public Enum NetworkAvailability
        ''' <summary>
        ''' OK, 服务器返回了 HTTP 204 状态码。
        ''' </summary>
        OK = 0
        ''' <summary>
        ''' 无法连接到服务器。
        ''' </summary>
        UnableToConnect = 1
        ''' <summary>
        ''' 已成功连接到服务器，但被重定向，可能需要登录。
        ''' </summary>
        Redirected = 2
        ''' <summary>
        ''' TTL 传输中过期。
        ''' </summary>
        TTLExpired = 3
        ''' <summary>
        ''' 服务器响应超时。
        ''' </summary>
        Timeout = 4
        ''' <summary>
        ''' 未知，服务器可能返回了非 301-303 307 204 的状态码。
        ''' </summary>
        Unknown = 5
    End Enum

    ''' <summary>
    ''' 一个基于 Android Captive Portal Detection 原理的网络连接监测器
    ''' </summary>
    Public Class NetworkWatchdog
        'Private Vars
        Private Const URL_SUFFIX As String = "/generate_204"
        Private pInterval As Long
        Private pCaptive As String
        Private pLastResult As NetworkAvailability = NetworkAvailability.Unknown
        Private pCurrentRunning As Boolean
        Private pInitialized As Boolean = False
        Private pThr As Thread
        Private pMethod As String = "HEAD"

        Private Sub InitializeCheck()
            If Not pInitialized Then Throw New System.InvalidOperationException("没有初始化。")
        End Sub

        Private Sub CheckNetAvi()
            Try
Redo:
                'Create request and send.
                Dim req As HttpWebRequest = HttpWebRequest.Create(pCaptive & "/generate_204")
                With req
                    .Method = pMethod
                    .AllowAutoRedirect = False
                    .Timeout = pInterval - 500
                    .UserAgent = "Mozilla/5.0 (Windows NT;) NetworkWathdog/0.0.0.0"
                End With
                Dim res As HttpWebResponse = req.GetResponse()
                Dim resCode As NetworkAvailability
                Console.WriteLine("[NetworkWatchdog]: Current status code: " & res.StatusCode & " - " & res.StatusDescription)

                If res.StatusCode = HttpStatusCode.NoContent Then
                    resCode = NetworkAvailability.OK
                ElseIf res.StatusCode = 301 Then
                    resCode = NetworkAvailability.Redirected
                ElseIf res.StatusCode = 302 Then
                    resCode = NetworkAvailability.Redirected
                ElseIf res.StatusCode = 303 Then
                    resCode = NetworkAvailability.Redirected
                ElseIf res.StatusCode = 307 Then
                    resCode = NetworkAvailability.Redirected
                Else
                    resCode = NetworkAvailability.Unknown
                End If

                If Not resCode = pLastResult Then
                    Console.WriteLine("[NetworkWatchdog]: Raising NetworkAvailabilityChanged event.")
                    pLastResult = resCode
                    RaiseEvent NetworkAvailabilityChanged(Me, pLastResult)
                End If

                Thread.Sleep(pInterval)
                GoTo Redo

            Catch thrEnd As Exception When thrEnd.GetType = GetType(ThreadAbortException)
                Exit Sub
            Catch ex As Exception
                RaiseEvent NetworkWatchdogErrorOccurred(Me, ex)
                Thread.Sleep(pInterval)
                GoTo Redo
            End Try
        End Sub

        'Events
        ''' <summary>
        ''' 网络连接可用性改变
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Public Event NetworkAvailabilityChanged(sender As Object, e As NetworkAvailability)
        ''' <summary>
        ''' 监控器遇到错误
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Public Event NetworkWatchdogErrorOccurred(sender As Object, e As Exception)

        ''' <summary>
        ''' 监测网络连接的时间间隔。
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property CheckInterval As Long
            Get
                InitializeCheck()
                Return pInterval
            End Get
        End Property
        ''' <summary>
        ''' 设置的 Captive Portal Server
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property CaptivePortal As String
            Get
                InitializeCheck()
                Return pCaptive
            End Get
        End Property

        ''' <summary>
        ''' 初始化一个新的 NetworkWatchdog
        ''' </summary>
        ''' <param name="interval">监测时间间隔，单位为 ms，最低为 1000ms。与此同时，响应超时将被设为 interval - 500</param>
        ''' <param name="captive"></param>
        Sub New(Optional interval As Long = 10000, Optional captive As String = "https://google.cn", Optional method As String = "HEAD")
            If interval < 1000 Then Throw New System.ArgumentOutOfRangeException("监测时间间隔必须大于 1000ms.")
            pInterval = interval
            pMethod = method
            pCaptive = captive
            pCurrentRunning = False
            pThr = New Thread(AddressOf CheckNetAvi) '实际上这个初始化过程没有任何必要
            pInitialized = True
        End Sub
        ''' <summary>
        ''' 根据当前设置，开始异步检查网络连接可用性。
        ''' </summary>
        Public Sub BeginCheckingNetworkAvailability()
            InitializeCheck()
            If pThr.IsAlive Then Throw New ThreadStateException("检测器已经在运行。")
            pThr = New Thread(AddressOf CheckNetAvi)
            pThr.Start()
        End Sub

        Public Sub StopCheckingNetworkAvailability()
            InitializeCheck()
            If pThr.IsAlive = False Then Throw New ThreadStateException("检测器没有运行。")
            pThr.Abort()
        End Sub
    End Class
End Namespace