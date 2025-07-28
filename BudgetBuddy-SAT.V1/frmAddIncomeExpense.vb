'----------------------------------------------------------
' File:          frmAddIncomeExpense.vb
' Project:       BudgetBuddy
' Description:   Handles the form where users can add income 
'                or expense transactions including type, amount, 
'                description, date, and category.
' Author:        Nayan
' Date Created:  30/06/2025
' Version:       1.0
'
' Purpose:
'   Allows users to add a new transaction, which is then
'   saved to a CSV file ("Transactions.csv") for future use.
'
' Notes:
'   - Assumes combo boxes and fields are filled in correctly.
'   - Will create the file if it does not exist.
'
'----------------------------------------------------------
Imports System.IO






' When the user clicks Save, validate inputs and write the transaction to the CSV file.
Public Class frmAddIncomeExpense
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim transactionType As String = cmbType.SelectedItem?.ToString()
        Dim amountText As String = txtAmount.Text.Trim()
        Dim description As String = txtDescription.Text.Trim()
        Dim transactionDate As String = dtpDate.Value.ToString("dd/MM/yyyy")
        Dim category As String = cmbCategory.SelectedItem?.ToString()

        ' Basic input validation
        If String.IsNullOrEmpty(transactionType) OrElse
           String.IsNullOrEmpty(amountText) OrElse
           Not IsNumeric(amountText) OrElse
           String.IsNullOrEmpty(category) Then

            MessageBox.Show("Please enter a valid amount and select both type and category.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim amount As Decimal = Convert.ToDecimal(amountText)

        ' Prepare CSV line: Date, Type, Category, Amount, Description
        Dim safeDescription As String = Chr(34) & description.Replace(Chr(34), "'") & Chr(34)
        Dim line As String = $"{transactionDate},{transactionType},{category},{amount},{safeDescription}"

        Try
            ' Save to Transactions.csv
            Using writer As New StreamWriter("Transactions.csv", append:=True)
                writer.WriteLine(line)
            End Using

            MessageBox.Show("Transaction added successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear form fields
            cmbType.SelectedIndex = -1
            txtAmount.Clear()
            txtDescription.Clear()
            cmbCategory.SelectedIndex = -1
            dtpDate.Value = Date.Today
            Me.Hide()
            frmDashboard.Show()

        Catch ex As Exception
            MessageBox.Show("Error saving transaction: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class