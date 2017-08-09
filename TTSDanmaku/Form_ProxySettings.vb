Public Class Form_ProxySettings

    Private Sub LoadToControl()
        TextBox_ProxyServer_IP.Text = Settings.Settings.ProxySettings_ProxyServer
        TextBox_ProxyServer_Port.Text = Settings.Settings.ProxySettings_ProxyPort
        TextBox_ProxyServer_Username.Text = Settings.Settings.ProxySettings_ProxyUser
        TextBox_ProxyServer_Password.Text = Settings.Settings.ProxySettings_ProxyPassword
        'HTTPS
        If Settings.Settings.HTTPSPreference Then
            RadioButton_HTTPS.Checked = True
        Else
            RadioButton_HTTP.Checked = True
        End If
        'Google Server
        If Settings.Settings.UseGoogleGlobal Then
            RadioButton_GoogleGlobal.Checked = True
        Else
            RadioButton_GoogleCN.Checked = True
        End If
    End Sub

    Private Sub ApplyFont()
        Label_Title.Font = New Drawing.Font("Microsoft Yahei UI", 17)
        Label_Warning.Font = New Drawing.Font("Microsoft Yahei UI", 10, Drawing.FontStyle.Italic)
        Button_Cancel.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        Button_OK.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        GroupBox_ProxySettings.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        GroupBox_Etc.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        GroupBox_Security.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        GroupBox_GoogleTTS.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        Label_ProxyServer.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        Label_ProxyServer_Port.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        Label_ProxyServer_Username.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        Label_ProxyServer_Password.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        RadioButton_GoogleCN.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        RadioButton_GoogleGlobal.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        RadioButton_HTTP.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        RadioButton_HTTPS.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        TextBox_ProxyServer_IP.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        TextBox_ProxyServer_Password.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        TextBox_ProxyServer_Port.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        TextBox_ProxyServer_Username.Font = New Drawing.Font("Microsoft Yahei UI", 9)
    End Sub

    Private Sub UpdateControl(sender As Object, e As EventArgs) Handles RadioButton_GoogleCN.CheckedChanged, RadioButton_GoogleGlobal.CheckedChanged, RadioButton_HTTP.CheckedChanged, RadioButton_HTTPS.CheckedChanged, TextBox_ProxyServer_IP.TextChanged, TextBox_ProxyServer_Password.TextChanged, TextBox_ProxyServer_Port.TextChanged, TextBox_ProxyServer_Username.TextChanged
        'Call master sub.
        UpdateControl()
    End Sub

    Private Sub UpdateControl()
        'Proxy Settings
        If TextBox_ProxyServer_IP.Text = Settings.Settings.ProxySettings_ProxyServer Then
            TextBox_ProxyServer_IP.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        Else
            TextBox_ProxyServer_IP.Font = New Drawing.Font("Microsoft Yahei UI", 9, Drawing.FontStyle.Bold)
        End If
        If TextBox_ProxyServer_Port.Text.Equals(Settings.Settings.ProxySettings_ProxyPort.ToString) Then
            TextBox_ProxyServer_Port.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        Else
            TextBox_ProxyServer_Port.Font = New Drawing.Font("Microsoft Yahei UI", 9, Drawing.FontStyle.Bold)
        End If
        If TextBox_ProxyServer_Username.Text = Settings.Settings.ProxySettings_ProxyUser Then
            TextBox_ProxyServer_Username.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        Else
            TextBox_ProxyServer_Username.Font = New Drawing.Font("Microsoft Yahei UI", 9, Drawing.FontStyle.Bold)
        End If
        If TextBox_ProxyServer_Password.Text = Settings.Settings.ProxySettings_ProxyPassword Then
            TextBox_ProxyServer_Password.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        Else
            TextBox_ProxyServer_Password.Font = New Drawing.Font("Microsoft Yahei UI", 9, Drawing.FontStyle.Bold)
        End If
        Dim httpsStatus As Boolean
        Dim googleGlobal As Boolean
        If RadioButton_GoogleGlobal.Checked Then googleGlobal = True
        If RadioButton_HTTPS.Checked Then httpsStatus = True
        If httpsStatus = Settings.Settings.HTTPSPreference Then
            GroupBox_Security.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        Else
            GroupBox_Security.Font = New Drawing.Font("Microsoft Yahei UI", 9, Drawing.FontStyle.Bold)
        End If
        If googleGlobal = Settings.Settings.UseGoogleGlobal Then
            GroupBox_GoogleTTS.Font = New Drawing.Font("Microsoft Yahei UI", 9)
        Else
            GroupBox_GoogleTTS.Font = New Drawing.Font("Microsoft Yahei UI", 9, Drawing.FontStyle.Bold)
        End If
    End Sub

    Private Sub Form_ProxySettings_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LoadToControl()
        UpdateControl()
    End Sub

    Private Sub Button_OK_Click(sender As Object, e As EventArgs) Handles Button_OK.Click
        Try
            Settings.Settings.ProxySettings_ProxyServer = TextBox_ProxyServer_IP.Text
            Settings.Settings.ProxySettings_ProxyPort = TextBox_ProxyServer_Port.Text
            Settings.Settings.ProxySettings_ProxyUser = TextBox_ProxyServer_Username.Text
            Settings.Settings.ProxySettings_ProxyPassword = TextBox_ProxyServer_Password.Text
            Dim httpsStatus As Boolean
            Dim googleGlobal As Boolean
            If RadioButton_GoogleGlobal.Checked Then
                googleGlobal = True
            Else
                googleGlobal = False
            End If
            If RadioButton_HTTPS.Checked Then
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

    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Cancel.Click
        Me.Close()
    End Sub

    Private Sub Form_ProxySettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class