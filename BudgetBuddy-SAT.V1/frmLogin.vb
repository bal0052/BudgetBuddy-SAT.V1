'----------------------------------------------------------
' File:          Login.vb
' Project:       BudgetBuddy
' Description:   Handles user login functionality including
'                user authentication and validation.
' Author:        Nayan
' Date Created:  26/06/2025
' Version:       1.0
'
' Purpose:
'   Allows users to securely log into the BudgetBuddy application
'   by verifying username and password credentials.
'
' Notes:
'   - Includes input validation and error messages for incorrect logins.
'   - Designed to integrate with the registration and main application forms.
'
'----------------------------------------------------------


Imports System.IO

Public Class frmLogin

    ' When the user clicks on the Login button, this subroutine validates the user credentials and logs them in if correct.
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim enteredUsername As String = txtLoginEmail.Text.Trim().ToLower()
        Dim enteredPassword As String = txtLoginPassword.Text.Trim()
        Dim loginSuccess As Boolean = False

        Try
            If Not File.Exists("CustomerDetails.csv") Then
                MessageBox.Show("CustomerDetails.csv not found in Debug folder.")
                Exit Sub
            End If
            'This checks too see if the file exists, if it does not then it will show a message box to the user.

            Using loginFile As New StreamReader("CustomerDetails.csv")
                Do While loginFile.Peek() <> -1                     'Checks the entered username and password against the saved credentials in the CustomerDetails.csv file.
                    Dim lineData() As String = loginFile.ReadLine().Split(",")
                    If lineData.Length = 2 Then                     'Ensure the line has exactly two parts: username and password
                        Dim csvUsername As String = lineData(0).Trim().ToLower()
                        Dim csvPassword As String = lineData(1).Trim()

                        If enteredUsername = csvUsername AndAlso enteredPassword = csvPassword Then
                            loginSuccess = True                 'This sets the loginSuccess variable to true if the entered username and password match the saved credentials.
                            Exit Do
                        End If
                    End If
                Loop
            End Using

            If loginSuccess Then
                Me.Hide()
                frmDashboard.Show()     'This will hide the login form and show the dashboard form if the login is successful.
            Else
                MsgBox("Incorrect username or password.", MsgBoxStyle.Exclamation)
            End If                      'This will show a message box to the user if the login is unsuccessful.

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
    End Sub



    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

    End Sub
End Class
