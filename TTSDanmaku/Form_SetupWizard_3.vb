Public Class Form_SetupWizard_3
    Private Sub Form_SetupWizard_3_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Font = New Drawing.Font("Microsoft Yahei UI", 9)
    End Sub
    Private Sub LinkLabel_Exit_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Exit.LinkClicked
        Me.Close()
    End Sub

    Private Sub Button_Next_Click(sender As Object, e As EventArgs) Handles Button_Next.Click
        Settings.Settings.TTSGiftsReceived = CheckBox_TTSGifts.Checked
        Settings.Settings.TTSDanmakuSender = CheckBox_TTSSender.Checked
        Settings.Settings.AutoClearCache = CheckBox_NoCache.Checked
        Settings.Methods.SaveSettings()
        Dim frm As New Form_SetupWizard_4
        frm.Show()
        Me.Close()
    End Sub

    Private Sub Button_Previous_Click(sender As Object, e As EventArgs) Handles Button_Previous.Click
        Dim frm As New Form_SetupWizard_2
        frm.Show()
        Me.Close()
    End Sub
End Class