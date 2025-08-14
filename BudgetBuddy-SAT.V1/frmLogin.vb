'----------------------------------------------------------
' File:          Login.vb
' Project:       BudgetBuddy
' Description:   Handles user authentication, including login
'                and registration features with validation and 
'                CSV-based credential storage.
' Author:        Nayan
' Date Created:  26/06/2025
' Version:       1.1
'
' Purpose:
'   Allows users to securely log in or register for the 
'   BudgetBuddy application by verifying or storing valid 
'   email and password credentials.
'
' Notes:
'   - Login checks user email and password against CSV.
'   - Registration stores name, email, and password to CSV.
'   - Includes input validation and feedback for common errors.
'   - Designed to integrate with the main dashboard form.
'
'----------------------------------------------------------


Imports System.Collections.Specialized.BitVector32
Imports System.IO

Public Module Session
    Public LoggedInEmail As String
    Public LoggedInName As String
End Module


Public Class frmLogin


    ' Load saved email if Remember Me was used
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not String.IsNullOrEmpty(My.Settings.SavedEmail) Then
            txtLoginEmail.Text = My.Settings.SavedEmail
            CheckBox1.Checked = True
        End If
    End Sub

    ' When the user clicks on the Login button, this subroutine validates the user credentials and logs them in if correct.
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Trim and normalize user input
        Dim enteredEmail As String = txtLoginEmail.Text.Trim().ToLower()
        Dim enteredPassword As String = txtLoginPassword.Text.Trim()
        Dim loginSuccess As Boolean = False
        Dim loggedInName As String = ""

        Try
            ' Check if the CSV file exists
            If Not File.Exists("CustomerDetails.csv") Then
                MessageBox.Show("CustomerDetails.csv not found.")
                Exit Sub
            End If

            ' Read the file line by line
            Using loginFile As New StreamReader("CustomerDetails.csv")
                Do While loginFile.Peek() <> -1
                    Dim lineData() As String = loginFile.ReadLine().Split(","c)

                    ' Expecting each line to have Name, Email, Password
                    If lineData.Length = 3 Then
                        Dim name As String = lineData(0).Trim()
                        Dim email As String = lineData(1).Trim().ToLower()
                        Dim password As String = lineData(2).Trim()

                        ' Check if credentials match
                        If enteredEmail = email AndAlso enteredPassword = password Then
                            loginSuccess = True
                            loggedInName = name ' Store matched name
                            Exit Do
                        End If
                    End If
                Loop
            End Using

            If loginSuccess Then
                ' Save session info for use in other forms
                Session.LoggedInEmail = enteredEmail
                Session.LoggedInName = loggedInName

                ' Handle Remember Me setting
                If CheckBox1.Checked Then
                    My.Settings.SavedEmail = enteredEmail
                Else
                    My.Settings.SavedEmail = ""
                End If
                My.Settings.Save()

                ' Navigate to dashboard
                Me.Hide()
                frmDashboard.Show()
            Else
                ' Show error if login failed
                MsgBox("Incorrect email or password.", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception
            ' Generic error handler
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
    End Sub



    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' Get and clean user input from the register tab fields
        Dim newName As String = txtRegName.Text.Trim()
        Dim newEmail As String = txtRegEmail.Text.Trim().ToLower()
        Dim newPassword As String = txtRegPassword.Text.Trim()
        Dim userExists As Boolean = False

        ' Validate required fields
        If newName = "" OrElse newEmail = "" OrElse newPassword = "" Then
            MessageBox.Show("Please enter Name, Email and Password.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validate email format using simple Regex
        If Not System.Text.RegularExpressions.Regex.IsMatch(newEmail, "^[^@\s]+@[^@\s]+\.[^@\s]+$") Then
            MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            ' If file doesn't exist, create it
            If Not File.Exists("CustomerDetails.csv") Then
                File.Create("CustomerDetails.csv").Close()
            End If

            ' Check for duplicate email (username)
            Using reader As New StreamReader("CustomerDetails.csv")
                Do While reader.Peek() <> -1
                    Dim lineData() As String = reader.ReadLine().Split(","c)
                    If lineData.Length >= 2 Then
                        Dim csvEmail As String = lineData(1).Trim().ToLower()
                        If csvEmail = newEmail Then
                            userExists = True
                            Exit Do
                        End If
                    End If
                Loop
            End Using

            If userExists Then
                MessageBox.Show("This email is already registered. Please try logging in.", "Duplicate Account", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            ' Append new user data to the CSV file: Name, Email, Password
            Using writer As New StreamWriter("CustomerDetails.csv", append:=True)
                writer.WriteLine($"{newName},{newEmail},{newPassword}")
            End Using

            MessageBox.Show("Registration successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear registration form fields
            txtRegName.Clear()
            txtRegEmail.Clear()
            txtRegPassword.Clear()

            ' Return user to the login tab
            TabControl1.SelectedTab = tabMain

        Catch ex As IOException
            MessageBox.Show("The registration file is currently in use or locked. Please close it and try again.", "File Access Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
