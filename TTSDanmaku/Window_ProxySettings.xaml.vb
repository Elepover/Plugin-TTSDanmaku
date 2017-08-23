Imports System.Windows

Public Class Window_ProxySettings
    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

    End Sub

    Private Sub LoadToControl()
        TextBox_ProxyServer_IP.Text = Settings.Settings.ProxySettings_ProxyServer
        TextBox_ProxyServer_Port.Text = Settings.Settings.ProxySettings_ProxyPort
        TextBox_ProxyServer_Username.Text = Settings.Settings.ProxySettings_ProxyUser
        TextBox_ProxyServer_Password.Text = Settings.Settings.ProxySettings_ProxyPassword
        'HTTPS
        If Settings.Settings.HTTPSPreference Then
            RadioButton_HTTPS.IsChecked = True
        Else
            RadioButton_HTTP.IsChecked = True
        End If
        'Google Server
        If Settings.Settings.UseGoogleGlobal Then
            RadioButton_GoogleGlobal.IsChecked = True
        Else
            RadioButton_GoogleCN.IsChecked = True
        End If
    End Sub

    Private Sub Window_ProxySettings_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Icon = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(My.Resources.icon.GetHbitmap, IntPtr.Zero, Int32Rect.Empty, Media.Imaging.BitmapSizeOptions.FromEmptyOptions())
        LoadToControl()
    End Sub

    Private Sub Button_OK_Click(sender As Object, e As RoutedEventArgs) Handles Button_OK.Click
        Try
            Settings.Settings.ProxySettings_ProxyServer = TextBox_ProxyServer_IP.Text
            Settings.Settings.ProxySettings_ProxyPort = TextBox_ProxyServer_Port.Text
            Settings.Settings.ProxySettings_ProxyUser = TextBox_ProxyServer_Username.Text
            Settings.Settings.ProxySettings_ProxyPassword = TextBox_ProxyServer_Password.Text
            Dim httpsStatus As Boolean
            Dim googleGlobal As Boolean
            If RadioButton_GoogleGlobal.IsChecked Then
                googleGlobal = True
            Else
                googleGlobal = False
            End If
            If RadioButton_HTTPS.IsChecked Then
                httpsStatus = True
            Else
                httpsStatus = False
            End If
            Settings.Settings.UseGoogleGlobal = googleGlobal
            Settings.Settings.HTTPSPreference = httpsStatus
            Settings.Methods.SaveSettings()
            Me.Close()
        Catch ex As Exception
            MsgBox("代理设置保存失败: " & ex.ToString, vbCritical + vbOKOnly, "网络设置")
        End Try
        Me.Close()
    End Sub

    Private Sub Button_Cancel_Click(sender As Object, e As RoutedEventArgs) Handles Button_Cancel.Click
        Me.Close()
    End Sub
End Class
