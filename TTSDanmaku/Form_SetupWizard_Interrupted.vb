Public Class Form_SetupWizard_Interrupted
    Private Sub Button_Next_Click(sender As Object, e As EventArgs) Handles Button_Next.Click
        Me.Close()
    End Sub

    Private Sub Form_SetupWizard_Interrupted_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Font = New Drawing.Font("Microsoft Yahei UI", 9)
    End Sub
End Class