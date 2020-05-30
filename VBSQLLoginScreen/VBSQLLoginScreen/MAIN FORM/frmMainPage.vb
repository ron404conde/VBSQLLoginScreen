Public Class frmMainPage
    Private Sub frmMainPage_Close(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim x As DialogResult
        x = MessageBox.Show("Are you sure you want to exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        If x = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        ElseIf x = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class