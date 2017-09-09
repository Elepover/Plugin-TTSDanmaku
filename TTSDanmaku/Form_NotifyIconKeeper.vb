Public Class Form_NotifyIconKeeper
    Private Sub ToolStripMenuItem_ShowHideMgmtWindow_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_ShowMgmtWindow.Click
        Dim frm As New Window_Administration
        frm.Show()
    End Sub

    Private Sub ToolStripMenuItem_LeaveDMJ_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_LeaveDMJ.Click
        NotifyIcon_Default.Visible = False
        Dim proc As Process = Process.GetCurrentProcess
        proc.Kill()
    End Sub

    Private Sub NotifyIcon_Default_MouseDoubleClick(sender As Object, e As Windows.Forms.MouseEventArgs) Handles NotifyIcon_Default.MouseDoubleClick
        ToolStripMenuItem_ShowHideDMJForm.PerformClick()
    End Sub

    Private Sub Form_NotifyIconKeeper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = False
    End Sub

    Private Sub ToolStripMenuItem_ShowHideDMJForm_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_ShowHideDMJForm.Click
        If System.Windows.Application.Current.MainWindow.Visibility = Windows.Visibility.Visible Then
            System.Windows.Application.Current.MainWindow.Visibility = Windows.Visibility.Hidden
        Else
            System.Windows.Application.Current.MainWindow.Visibility = Windows.Visibility.Visible
        End If
    End Sub

End Class