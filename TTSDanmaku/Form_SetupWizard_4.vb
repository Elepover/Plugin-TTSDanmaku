Public Class Form_SetupWizard_4
    Private Sub SpellingCheck()
        'Check if there's any empty box.
        Dim pass1 As Boolean = True
        Dim pass2 As Boolean = True
        If TextBox_CustomDMContent.Text = "" Then
            pass1 = False
        End If
        If TextBox_CustomGiftContent.Text = "" Then
            pass2 = False
        End If
        'Check if there's any illegal vars.
        If TextBox_CustomDMContent.Text.Contains("$GIFT") Then
            pass1 = False
        End If
        If TextBox_CustomDMContent.Text.Contains("$COUNT") Then
            pass1 = False
        End If
        If TextBox_CustomGiftContent.Text.Contains("$DM") Then
            pass2 = False
        End If

        'Apply pass state
        If pass1 Then
            TextBox_CustomDMContent.ForeColor = Drawing.Color.LightGreen
            PictureBox_OK_1.Visible = True
        Else
            TextBox_CustomDMContent.ForeColor = Drawing.Color.Pink
            PictureBox_OK_1.Visible = False
        End If
        If pass2 Then
            TextBox_CustomGiftContent.ForeColor = Drawing.Color.LightGreen
            PictureBox_OK_2.Visible = True
        Else
            TextBox_CustomGiftContent.ForeColor = Drawing.Color.Pink
            PictureBox_OK_2.Visible = False
        End If

        'Next Button
        If pass1 Then
            If pass2 Then
                Button_Next.Enabled = True
            Else
                Button_Next.Enabled = False
            End If
        Else
            Button_Next.Enabled = False
        End If
    End Sub

    Private Sub Form_SetupWizard_4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SpellingCheck()
    End Sub

    Private Sub Form_SetupWizard_4_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Font = New Drawing.Font("Microsoft Yahei UI", 9)
    End Sub

    Private Sub Button_Previous_Click(sender As Object, e As EventArgs) Handles Button_Previous.Click
        Dim frm As New Form_SetupWizard_3
        frm.Show()
        Me.Close()
    End Sub

    Private Sub Button_Next_Click(sender As Object, e As EventArgs) Handles Button_Next.Click
        Settings.Settings.DanmakuText = TextBox_CustomDMContent.Text
        Settings.Settings.GiftsText = TextBox_CustomGiftContent.Text
        Dim frm As New Form_SetupWizard_5
        frm.Show()
        Me.Close()
    End Sub

    Private Sub TextBox_CustomDMContent_TextChanged(sender As Object, e As EventArgs) Handles TextBox_CustomDMContent.TextChanged
        SpellingCheck()
    End Sub

    Private Sub LinkLabel_Exit_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_Exit.LinkClicked
        Me.Close()
    End Sub
End Class