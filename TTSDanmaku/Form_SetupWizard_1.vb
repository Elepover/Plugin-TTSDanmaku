Public Class Form_SetupWizard_1
    Private Sub Button_Next_Click(sender As Object, e As EventArgs) Handles Button_Next.Click
        Dim frm As New Form_SetupWizard_2
        frm.Show()
        Me.Close()
    End Sub

    Private Sub Form_SetupWizard_1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Font = New Drawing.Font("Microsoft Yahei UI", 9)
    End Sub

    Private Sub LinkLabel_Exit_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Exit.LinkClicked
        Me.Close()
    End Sub

    Private Sub LinkLabel_FAQ_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_FAQ.LinkClicked
        Dim proc As New Process
        With proc.StartInfo
            .FileName = "https://blog.elepover.com/archives/2017/05/faq.html"
            .ErrorDialog = False
        End With
        proc.Start()
    End Sub

    Private Sub LinkLabel_Notice_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Notice.LinkClicked
        Dim proc As New Process
        With proc.StartInfo
            .FileName = "https://www.danmuji.cn/plugins/TTSDanmaku#注意事项"
            .ErrorDialog = False
        End With
        proc.Start()
    End Sub
End Class