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
End Class