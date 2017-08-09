Public Class Form_FrameworkEngineConf
    Private Sub UpdateControl()
        If Not ComboBox_TTSGender.SelectedIndex = Settings.Settings.NETFramework_Gender Then
            ComboBox_TTSGender.Font = New Drawing.Font(ComboBox_TTSGender.Font, Drawing.FontStyle.Bold)
        Else
            ComboBox_TTSGender.Font = New Drawing.Font(ComboBox_TTSGender.Font, Drawing.FontStyle.Regular)
        End If
        If Not NumericUpDown_SpeechSpeed.Value = Settings.Settings.NETFramework_VoiceSpeed Then
            NumericUpDown_SpeechSpeed.Font = New Drawing.Font(NumericUpDown_SpeechSpeed.Font, Drawing.FontStyle.Bold)
        Else
            NumericUpDown_SpeechSpeed.Font = New Drawing.Font(NumericUpDown_SpeechSpeed.Font, Drawing.FontStyle.Regular)
        End If
    End Sub

    Private Sub LoadToControl()
        NumericUpDown_SpeechSpeed.Value = Settings.Settings.NETFramework_VoiceSpeed
        ComboBox_TTSGender.SelectedIndex = Settings.Settings.NETFramework_Gender
    End Sub

    Private Sub Form_FrameworkEngineConf_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button_OK_Click(sender As Object, e As EventArgs) Handles Button_OK.Click
        Try
            Settings.Settings.NETFramework_Gender = ComboBox_TTSGender.SelectedIndex
            Settings.Settings.NETFramework_VoiceSpeed = NumericUpDown_SpeechSpeed.Value
            Settings.Methods.SaveSettings()
            Me.Close()
        Catch ex As Exception
            MsgBox("引擎设置保存失败: " & ex.ToString, vbCritical + vbOKOnly, "TTSDanmaku")
        End Try
    End Sub

    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Cancel.Click
        Me.Close()
    End Sub

    Private Sub Form_FrameworkEngineConf_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LoadToControl()
        UpdateControl()
    End Sub
End Class