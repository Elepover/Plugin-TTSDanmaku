Namespace MainBridge
    ''' <summary>
    ''' Control Main over MainBridge delivery system.
    ''' Required to be initialized by Main.
    ''' </summary>
    Public Class MainBridge
        ''' <summary>
        ''' Plugin version details.
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property MainVersion As Version
        ''' <summary>
        ''' If DMJ is in debugging mode?
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property MainDebug As Boolean
        ''' <summary>
        ''' Plugin running status to set.
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property MainStatusReq As MainStatusModel = MainStatusModel.Uninitialized
        ''' <summary>
        ''' Array of logs waiting to be passed to Main.
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property LogArray As New List(Of MainLogModel)
        ''' <summary>
        ''' Plugin running status to read.
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property MainStatus As MainStatusModel = MainStatusModel.Uninitialized
        ''' <summary>
        ''' Provides a quick access of DMJ window.
        ''' </summary>
        ''' <returns></returns>
        Public Shared ReadOnly Property DMJWindow As Windows.Window
            Get
                Return System.Windows.Application.Current.MainWindow
            End Get
        End Property
        ''' <summary>
        ''' Add a MainLogModel to LogArray.
        ''' </summary>
        ''' <param name="content"></param>
        ''' <param name="debug"></param>
        Public Shared Sub LogToArray(content As String, Optional debug As Boolean = False)
            Dim LogToPass As New MainLogModel(content, debug)
            LogArray.Add(LogToPass)
        End Sub
    End Class

    ''' <summary>
    ''' Acting as a log to pass to Main through MainBridge.
    ''' </summary>
    Public Class MainLogModel
        ''' <summary>
        ''' Create a MainLogModel with specified message.
        ''' </summary>
        ''' <param name="msg">Message to log.</param>
        Sub New(msg As String)
            Message = msg
            IsDebug = False
        End Sub
        ''' <summary>
        ''' Create a MainLogModel with specified message.
        ''' </summary>
        ''' <param name="msg">Message to log.</param>
        ''' <param name="debug">Whether the message is debug-only or not.</param>
        Sub New(msg As String, debug As Boolean)
            Message = msg
            IsDebug = debug
        End Sub
        ''' <summary>
        ''' Log message.
        ''' </summary>
        ''' <returns></returns>
        Public Property Message As String
        ''' <summary>
        ''' Indicates if the message shouldn't be displayed under non-debugging mode.
        ''' </summary>
        ''' <returns></returns>
        Public Property IsDebug As Boolean
    End Class

    ''' <summary>
    ''' A series of statuses, which indicating the plugin status.
    ''' </summary>
    Public Enum MainStatusModel
        ''' <summary>
        ''' Plugin has not been initialized yet.
        ''' </summary>
        Uninitialized = 0
        ''' <summary>
        ''' Plugin has stopped.
        ''' </summary>
        Stopped = 1
        ''' <summary>
        ''' Plugin has started and running currently.
        ''' </summary>
        Started = 2
        ''' <summary>
        ''' MainBridge has requested main to stop plugin.
        ''' </summary>
        RequestedStop = 3
        ''' <summary>
        ''' MainBridge has requested main to start plugin.
        ''' </summary>
        RequestedStart = 4
    End Enum
End Namespace