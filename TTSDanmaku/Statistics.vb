' Statistics.vb
' Copyright (C) 2017 Elepover.

''' <summary>
''' TTSDanmaku 统计系统
''' </summary>
Public Class Statistics
    ''' <summary>
    ''' 总共尝试的 TTS 次数，不计成败
    ''' </summary>
    ''' <returns></returns>
    Public Shared Property TTS_Total As Integer
    ''' <summary>
    ''' 播放**出了声音**的 TTS（比如冷却时间播放的就不算）
    ''' </summary>
    ''' <returns></returns>
    Public Shared Property TTS_Succeeded As Integer
    ''' <summary>
    ''' 因未预料的原因播放失败的 TTS 计数
    ''' </summary>
    ''' <returns></returns>
    Public Shared Property TTS_Failed As Integer
    ''' <summary>
    ''' 在冷却时间内播放的 TTS 次数
    ''' </summary>
    ''' <returns></returns>
    Public Shared Property TTS_PlayedDuringCoolDown As Integer
    ''' <summary>
    ''' 下载 TTS 失败计数
    ''' </summary>
    ''' <returns></returns>
    Public Shared Property TTS_DownloadFail As Long
    ''' <summary>
    ''' 因字符太长被忽略的 TTS 数量
    ''' </summary>
    ''' <returns></returns>
    Public Shared Property TTS_Dropped As Integer
    ''' <summary>
    ''' 尝试播放 TTS 的总次数（此前必须下载成功
    ''' </summary>
    ''' <returns></returns>
    Public Shared Property TTS_PlayTries As Integer
    ''' <summary>
    ''' 静默播放的 TTS 计数
    ''' </summary>
    ''' <returns></returns>
    Public Shared Property TTS_Silent As Integer
    ''' <summary>
    ''' 进入冷却模式的次数
    ''' </summary>
    ''' <returns></returns>
    Public Shared Property TTS_CoolDown As Integer
    ''' <summary>
    ''' ReceivedRoomCount 事件引发次数
    ''' </summary>
    ''' <returns></returns>
    Public Shared Property DBG_ReceivedRoomCount As Integer
    ''' <summary>
    ''' 插件出错计数器
    ''' </summary>
    ''' <returns></returns>
    Public Shared Property DBG_ErrCount As Integer
    ''' <summary>
    ''' 最后一个遇到的错误
    ''' </summary>
    ''' <returns></returns>
    Public Shared Property DBG_LastException As Exception

    Public Shared Property DBG_BridgeUpdateCount As Long

    ''' <summary>
    ''' 重置统计数据
    ''' </summary>
    Public Shared Sub ResetStats()
        TTS_Dropped = 0
        TTS_PlayTries = 0
        TTS_DownloadFail = 0
        TTS_Failed = 0
        TTS_PlayedDuringCoolDown = 0
        TTS_Succeeded = 0
        TTS_Total = 0
        TTS_Silent = 0
        TTS_CoolDown = 0
        DBG_ReceivedRoomCount = 0
        DBG_ErrCount = 0
        DBG_LastException = Nothing
        DBG_BridgeUpdateCount = 0
    End Sub
End Class
