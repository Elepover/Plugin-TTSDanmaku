﻿Imports System.Windows

Public Class Window_Upgrader
    Private PluginDLURL As String = "undefined"

    Private Sub Button_CheckUpd_Click(sender As Object, e As Windows.RoutedEventArgs) Handles Button_CheckUpd.Click
        Me.IsEnabled = False
        TextBlock_Status.Text = "正在检查更新..."
        ProgressBar_Indicator.Visibility = Visibility.Visible
        Delay(1000)

        Dim latest As KruinUpdates.Update
        Dim currVer As Version = New Version(New Main().PluginVer)
        Try
            'Check release
            latest = KruinUpdates.GetLatestUpd()
            TextBlock_Latest.Text = "最新版本 (Stable): " & latest.LatestVersion.ToString & " / 当前版本: " & currVer.ToString & " (" & Edition & ")"
            If KruinUpdates.CheckIfLatest(latest, currVer) Then
                TextBlock_Status.Text = "插件已为最新。"
            Else
                TextBlock_Status.Text = "发现更新。"
            End If
            TextBox_UpdContents.Text = "更新时间: " & latest.UpdateTime.ToString() & vbCrLf & "更新日志: " & vbCrLf & latest.UpdateDescription
            PluginDLURL = "https://www.danmuji.cn" & latest.DLURL
        Catch ex As Exception
            TextBlock_Status.Text = "检查更新时出错。"
            TextBox_UpdContents.Text = "检查更新时出错: " & ex.ToString
        End Try

        ProgressBar_Indicator.Visibility = Visibility.Hidden
        Me.IsEnabled = True
    End Sub

    Private Sub Window_Upgrader_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Me.Icon = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(My.Resources.icon.GetHbitmap, IntPtr.Zero, Int32Rect.Empty, Media.Imaging.BitmapSizeOptions.FromEmptyOptions())
        Button_CheckUpd_Click(Nothing, Nothing)
    End Sub

    Private Sub Button_DLUpd_Click(sender As Object, e As RoutedEventArgs) Handles Button_DLUpd.Click
        If PluginDLURL = "undefined" Then
            MessageBox.Show("先检查更新吧！", "KruinUpdates", MessageBoxButton.OK, MessageBoxImage.Information)
        Else
            Process.Start(PluginDLURL)
        End If
    End Sub
End Class
