Public Class Form_SetupWizard_5
    Private Sub Button_Next_Click(sender As Object, e As EventArgs) Handles Button_Next.Click
        Me.Close()
        Settings.Methods.Initialize()
        Settings.Methods.SaveSettings()
    End Sub
End Class