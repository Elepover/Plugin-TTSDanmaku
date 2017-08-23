Imports System.Windows

Public Class Window_StatusReport
    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

    End Sub

    Private Sub Window_StatusReport_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Icon = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(My.Resources.icon.GetHbitmap, IntPtr.Zero, Int32Rect.Empty, Media.Imaging.BitmapSizeOptions.FromEmptyOptions())
        LoadToControl()
        UpdateControl()
        TextBox_VarsHelp.Text = "状态报告 - 变量帮助。

以下变量将在读出时被自动替换为对应内容。
详细范例请在弹幕姬插件仓库 -> TTSDanmaku 中查看。

$ONLINE 直播间在线人数。
$TOTALDM 插件运行期间收到的总弹幕数。

$HOUR 系统时间，小时。
$MINUTE 系统时间，分钟。
$SEC 系统时间，秒。
$YEAR 系统时间，年。
$MONTH 系统时间，月。
$DAY 系统时间，日。

$MEMAVAI 可用系统内存（GB）。
$MPERCENT 系统内存占用百分比。
$VMEM 可用虚拟内存（GB）。
$VPERCENT_VM 虚拟内存占用百分比。"

    End Sub

    Private Sub Button_Save_Click(sender As Object, e As RoutedEventArgs) Handles Button_Save.Click
        '保存
        Settings.Methods.Initialize()
        Settings.Settings.StatusReport_ResolveAdvVars = CheckBox_EnableAdvVars.IsChecked
        Settings.Settings.StatusReport = CheckBox_EnableStatusReport.IsChecked
        Try
            If Not ((CInt(NumericUpDown_Interval.Text) > 3600) Or (CInt(NumericUpDown_Interval.Text) < 45)) Then
                Settings.Settings.StatusReportInterval = NumericUpDown_Interval.Text
            End If
        Catch ex As Exception
        End Try
        Settings.Settings.StatusReportContent = TextBox_ReportText.Text

        Try
            Settings.Methods.SaveSettings()
        Catch ex As Exception
            Statistics.DBG_ErrCount += 1
            Statistics.DBG_LastException = ex
            NBlockMsgBox("保存出差错: " & ex.ToString, MsgBoxStyle.Critical + vbSystemModal + vbOKOnly, "TTSDanmaku 状态报告 - 高级设置")
        End Try
        LoadToControl()
        UpdateControl()
    End Sub

    Private Sub LoadToControl()
        CheckBox_EnableAdvVars.IsChecked = Settings.Settings.StatusReport_ResolveAdvVars
        CheckBox_EnableStatusReport.IsChecked = Settings.Settings.StatusReport
        NumericUpDown_Interval.Text = Settings.Settings.StatusReportInterval
        TextBox_ReportText.Text = Settings.Settings.StatusReportContent
    End Sub

    Private Sub UpdateControl()
        Try
            If (CInt(NumericUpDown_Interval.Text) > 3600) Or (CInt(NumericUpDown_Interval.Text) < 45) Then
                NumericUpDown_Interval.Background = Media.Brushes.Pink
            Else
                NumericUpDown_Interval.Background = Media.Brushes.White
            End If
        Catch ex As Exception
            NumericUpDown_Interval.Background = Media.Brushes.Pink
        End Try

        '检测配置是否不同于控件
        If Not CheckBox_EnableAdvVars.IsChecked = Settings.Settings.StatusReport_ResolveAdvVars Then
            CheckBox_EnableAdvVars.FontWeight = FontWeights.Bold
        Else
            CheckBox_EnableAdvVars.FontWeight = FontWeights.Normal
        End If
        If Not CheckBox_EnableStatusReport.IsChecked = Settings.Settings.StatusReport Then
            CheckBox_EnableStatusReport.FontWeight = FontWeights.Bold
        Else
            CheckBox_EnableStatusReport.FontWeight = FontWeights.Normal
        End If
        If Not NumericUpDown_Interval.Text = Settings.Settings.StatusReportInterval Then
            NumericUpDown_Interval.FontWeight = FontWeights.Bold
        Else
            NumericUpDown_Interval.FontWeight = FontWeights.Normal
        End If
        If Not TextBox_ReportText.Text = Settings.Settings.StatusReportContent Then
            TextBox_ReportText.FontWeight = FontWeights.Bold
        Else
            TextBox_ReportText.FontWeight = FontWeights.Normal
        End If
    End Sub

    Private Sub Button_Cancel_Click(sender As Object, e As RoutedEventArgs) Handles Button_Cancel.Click
        Me.Close()
    End Sub
End Class
