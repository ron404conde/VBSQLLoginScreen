'RON
'Created by: RON CONDE

Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient

Public Class frmLoginScreen

    Dim c As New AppConfiguration
    Dim cs = c.cnstring

    Public loginCancel As Boolean = False

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Dim frmClose As String = MsgBox("Are you sure you want to exit?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Exit")
        If frmClose = vbYes Then
            loginCancel = True
            TimerFadeOut.Enabled = True
        End If
    End Sub

    Private Sub frmLoginScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUsername.Focus()

        lblDatabaseName.Text = c.Database
        lblServerName.Text = c.Server
        lblApplicationVersion.Text = "v:" & Application.ProductVersion
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Call AttempLogin(txtUsername.Text, txtPassword.Text)
    End Sub

    Private Sub AttempLogin(ByVal Username As String, ByVal Password As String)
        Try
            Dim sqlDR As SqlDataReader

            If txtUsername.Text <> "" And txtPassword.Text <> "" Then
                sqlDR = SqlHelper.ExecuteReader(cs, CommandType.StoredProcedure, "spu_UserLogin",
                                                New SqlParameter("@Username", Username),
                                                New SqlParameter("@Password", Password))
                If sqlDR.HasRows Then
                    If sqlDR.Read Then

                        'login success
                        MsgBox("Login Successfully!", MsgBoxStyle.Information, "")
                        TimerFadeOut.Enabled = True
                    End If
                Else
                    MsgBox("Login failed! Please try again", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "")
                End If
            Else
                MsgBox("Username and Password is Required!", MsgBoxStyle.Exclamation, "")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub TimerFadeIn_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerFadeIn.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += 0.04
        Else
            TimerFadeIn.Enabled = False
        End If
    End Sub

    Private Sub TimerFadeOut_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerFadeOut.Tick
        If Me.Opacity <> 0 Then
            Me.Opacity -= 0.03
        Else
            If loginCancel Then
                End
            Else
                Me.Close()
                frmMainPage.Show()
                TimerFadeOut.Enabled = False
            End If
        End If
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            Call AttempLogin(txtUsername.Text, txtPassword.Text)
        End If
    End Sub

    Private Sub txtUsername_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsername.GotFocus
        txtUsername.SelectAll()
    End Sub

End Class
