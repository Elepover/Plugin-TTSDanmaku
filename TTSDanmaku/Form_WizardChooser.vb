﻿Public Class Form_WizardChooser
    Private Sub Button_Canonical_Click(sender As Object, e As EventArgs) Handles Button_Canonical.Click
        Dim frm As New TTSDanmakuMgmt
        frm.Show()
        Me.Close()
    End Sub

    Private Sub Button_Wizard_Click(sender As Object, e As EventArgs) Handles Button_Wizard.Click
        Dim frm As New Form_SetupWizard_1
        frm.Show()
        Me.Close()
    End Sub

    Private Sub Form_WizardChooser_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Font = New Drawing.Font("Microsoft Yahei UI", 9)
    End Sub

End Class