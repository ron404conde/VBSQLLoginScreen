Public Class frmSplashScreen

    Private Sub TimerFadeIn_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerFadeIn.Tick
        If Me.Opacity < 1 Then
            Me.Opacity = Me.Opacity + 0.04
        Else
            TimerFadeOut.Enabled = True
            TimerFadeIn.Enabled = False
        End If
    End Sub

    Private Sub frmSplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.TimerLoading.Start()
    End Sub

    Private Sub TimerFadeOut_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerFadeOut.Tick
        TimerFadeOut.Interval = 5
        If Me.Opacity <> 0 Then
            Me.Opacity = Me.Opacity - 0.03
        Else
            TimerFadeOut.Enabled = False
            frmLoginScreen.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub TimerLoading_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerLoading.Tick
        pgbLoading.Value += 1
        If pgbLoading.Value < pgbLoading.Maximum Then
            If pgbLoading.Value + 50 = 100 Then
                lblPreparing.Text = "Preparing . . . " & 100 & "%"
                lblPreparing.Refresh()
                TimerLoading.Stop()
            Else
                lblPreparing.Text = "Preparing . . . " & pgbLoading.Value + 75 & "%"
                lblPreparing.Refresh()
            End If
        End If
    End Sub

End Class