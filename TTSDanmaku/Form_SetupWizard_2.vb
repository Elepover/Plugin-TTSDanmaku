Public Class Form_SetupWizard_2
    Private Sub Button_Previous_Click(sender As Object, e As EventArgs) Handles Button_Previous.Click
        Dim frm As New Form_SetupWizard_1
        frm.Show()
        Me.Close()
    End Sub

    Private Sub ErrorForm()
        Dim frm As New Form_SetupWizard_Interrupted
        frm.Show()
    End Sub

    Private Sub Form_SetupWizard_2_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Font = New Drawing.Font("Microsoft Yahei UI", 9)

        Button_Next.Enabled = False

        DoEvents()
        Delay(1000)

        'Configure settings system
        'CheckBox_Prog1.CheckState = Windows.Forms.CheckState.Indeterminate
        Try
            Settings.Methods.Initialize()
        Catch ex As Exception
            NBlockMsgBox("设置系统初始化故障: " & ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "设置向导")
            ErrorForm()
            Me.Close()
        End Try
        CheckBox_Prog1.CheckState = Windows.Forms.CheckState.Checked

        DoEvents()
        Delay(500)

        'CheckBox_Prog2.CheckState = Windows.Forms.CheckState.Indeterminate
        'Detect NAudio
        Try
            If Not IO.File.Exists(Settings.Vars.LibFileName) Then
                NBlockMsgBox("NAudio 库文件不存在，请参见弹幕姬插件仓库中的解决方案。", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "设置向导")
                ErrorForm()
                Me.Close()
            End If
        Catch ex As Exception
            NBlockMsgBox("NAudio 检测出错: " & ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "设置向导")
        End Try
        CheckBox_Prog2.CheckState = Windows.Forms.CheckState.Checked

        DoEvents()
        Delay(500)

        'CheckBox_Prog3.CheckState = Windows.Forms.CheckState.Indeterminate
        'Check network connectivity.
        'Try
        '    Dim ttsFileName As String = ""
        '    Dim client As New Net.WebClient()
        '    Dim ran1 As Integer = 0
        '    Dim ran2 As Integer = 0
        '    ran1 = (New Random).Next
        '    Randomize()
        '    ran2 = (New Random).Next
        '    ttsFileName = Settings.Vars.CacheDir & "\TTS" & ran1 & ran2 & ".mp3"
        '    client.DownloadFile(Settings.Settings.APIString.Replace("ZoharWang", "Connectivity test."), ttsFileName)

        '    GoogleTTS("Connectivity test.", True)
        'Catch ex As Exception
        '    NBlockMsgBox("网络连接检测出错: " & ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "设置向导")
        '    ErrorForm()
        '    Me.Close()
        'End Try
        CheckBox_Prog3.CheckState = Windows.Forms.CheckState.Checked
        Button_Next.Enabled = True
    End Sub

    Private Sub LinkLabel_Exit_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Exit.LinkClicked
        Me.Close()
    End Sub

    Private Sub Button_Next_Click(sender As Object, e As EventArgs) Handles Button_Next.Click
        Dim frm As New Form_SetupWizard_3
        frm.Show()
        Me.Close()
    End Sub
End Class