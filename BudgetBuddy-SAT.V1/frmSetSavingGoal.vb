'----------------------------------------------------------
' File:          frmSetSavingGoal.vb
' Project:       BudgetBuddy
' Description:   Allows users to set and save a financial
'                savings goal, which is stored in "SavingGoal.csv".
' Author:        Nayan
' Date Created:  31/07/2025
' Version:       1.0
'
' Purpose:
'   Lets the user set a target amount and optional target date
'   for a savings goal. This data is saved for future reference.
'
' Notes:
'   - Will create "SavingGoal.csv" if it does not exist.
'   - CSV format: TargetAmount,TargetDate
'   - Input validation ensures numeric amount and valid date.
'
'----------------------------------------------------------

Imports System.IO

Public Class frmSetSavingGoal
    Private Sub frmSetSavingGoal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filePath As String = "SavingGoal.csv"
        If Not File.Exists(filePath) Then
            File.Create(filePath).Close()
        End If


        Try
            Dim line As String = File.ReadAllText(filePath)
            Dim parts As String() = line.Split(","c)

            If parts.Length >= 2 Then
                txtTargetAmount.Text = parts(0)
                Dim loadedDate As Date
                If Date.TryParseExact(parts(1), "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, loadedDate) Then
                    dtpTargetDate.Value = loadedDate
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading savings goal: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSetGoal_Click(sender As Object, e As EventArgs) Handles btnSetGoal.Click
        Dim amountText As String = txtTargetAmount.Text.Trim()
        Dim targetDate As String = dtpTargetDate.Value.ToString("dd/MM/yyyy")

        ' Validate target amount
        If String.IsNullOrEmpty(amountText) OrElse Not IsNumeric(amountText) Then
            MessageBox.Show("Please enter a valid numeric target amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim targetAmount As Decimal = Convert.ToDecimal(amountText)

        ' Prepare CSV line: TargetAmount,TargetDate
        Dim line As String = $"{targetAmount},{targetDate}"

        Try
            ' Save to SavingGoal.csv (overwrite previous goal)
            File.WriteAllText("SavingGoal.csv", line)

            MessageBox.Show("Savings goal saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Reset form
            txtTargetAmount.Clear()
            dtpTargetDate.Value = Date.Today
            txtGoalName.Clear()
            cmbCategory.SelectedIndex = -1
            Me.Hide()
            frmDashboard.Show()  ' Return to the dashboard after saving


        Catch ex As Exception
            MessageBox.Show("Error saving savings goal: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBackToDash_Click(sender As Object, e As EventArgs) Handles btnBackToDash.Click
        Me.Hide()
        frmDashboard.Show()  ' Return to the dashboard after saving 
    End Sub
End Class