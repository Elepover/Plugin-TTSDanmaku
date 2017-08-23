Imports System.Windows

Public Class Window_ProxySettings
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
        LoadToControl()
        UpdateControl()
    End Sub
    Private Sub UpdateControl(sender As Object, e As EventArgs) Handles RadioButton_GoogleCN.Click, RadioButton_GoogleGlobal.Click, RadioButton_HTTP.Click, RadioButton_HTTPS.Click, TextBox_ProxyServer_IP.TextChanged, TextBox_ProxyServer_Password.TextChanged, TextBox_ProxyServer_Port.TextChanged, TextBox_ProxyServer_Username.TextChanged
        'Call master sub.
        UpdateControl()
    End Sub
    Private Sub UpdateControl()
        'Proxy Settings
        If TextBox_ProxyServer_IP.Text = Settings.Settings.ProxySettings_ProxyServer Then
            TextBox_ProxyServer_IP.FontWeight = FontWeights.Normal
        Else
            TextBox_ProxyServer_IP.FontWeight = FontWeights.Bold
        End If
        If TextBox_ProxyServer_Port.Text.Equals(Settings.Settings.ProxySettings_ProxyPort.ToString) Then
            TextBox_ProxyServer_Port.FontWeight = FontWeights.Normal
        Else
            TextBox_ProxyServer_Port.FontWeight = FontWeights.Bold
        End If
        If TextBox_ProxyServer_Username.Text = Settings.Settings.ProxySettings_ProxyUser Then
            TextBox_ProxyServer_Username.FontWeight = FontWeights.Normal
        Else
            TextBox_ProxyServer_Username.FontWeight = FontWeights.Bold
        End If
        If TextBox_ProxyServer_Password.Text = Settings.Settings.ProxySettings_ProxyPassword Then
            TextBox_ProxyServer_Password.FontWeight = FontWeights.Normal
        Else
            TextBox_ProxyServer_Password.FontWeight = FontWeights.Bold
        End If
        Dim httpsStatus As Boolean
        Dim googleGlobal As Boolean
        If RadioButton_GoogleGlobal.IsChecked Then googleGlobal = True
        If RadioButton_HTTPS.IsChecked Then httpsStatus = True
        If httpsStatus = Settings.Settings.HTTPSPreference Then
            RadioButton_HTTP.FontWeight = FontWeights.Normal
            RadioButton_HTTPS.FontWeight = FontWeights.Normal
        Else
            RadioButton_HTTP.FontWeight = FontWeights.Bold
            RadioButton_HTTPS.FontWeight = FontWeights.Bold
        End If
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
    End Sub
End Class
