Imports System.IO

Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim FileContent() As String
        Dim CorrectUserName As String
        Dim CorrectPassword As String


        Try
            Dim UserDetailsFile As New StreamReader("UserDetails.csv")

            Do While UserDetailsFile.Peek
                If txtLoginEmail.Text = CorrectUserName And txtLoginPassword.Text = CorrectPassword Then
                Me.Hide()
                frmDashboard.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class