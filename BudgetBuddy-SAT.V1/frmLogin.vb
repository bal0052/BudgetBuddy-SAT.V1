Imports System.IO

Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim loginFile As New StreamReader("LoginDetails.csv.csv")
        Dim lineData() As String
        Dim enteredUsername As String = txtLoginEmail.Text.Trim()
        Dim enteredPassword As String = txtLoginPassword.Text.Trim()
        Dim loginSuccess As Boolean = False

        Try
            Do While loginFile.Peek() <> -1
                lineData = loginFile.ReadLine().Split(",")

                Dim csvUsername As String = lineData(0).Trim() ' First Name
                Dim csvPassword As String = lineData(2).Trim() ' Password

                If enteredUsername = csvUsername AndAlso enteredPassword = csvPassword Then
                    loginSuccess = True
                    Exit Do
                End If
            Loop

            loginFile.Close()

            If loginSuccess Then
                Me.Hide()
                frmDashboard.Show() ' ✅ Show dashboard
            Else
                MsgBox("Incorrect username or password.", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception
            MsgBox("An error occurred while reading the file: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class