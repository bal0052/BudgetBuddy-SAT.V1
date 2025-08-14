'----------------------------------------------------------
' File:          frmSearchTransactions.vb
' Project:       BudgetBuddy
' Description:   Handles searching of transactions stored in
'                "Transactions.csv" using filters such as 
'                description, date range, type, and category.
' Author:        Nayan
' Date Created:  30/07/2025
' Version:       1.0
'
' Purpose:
'   Allows users to search existing transactions stored in a CSV 
'   file, apply multiple filters, and view the results in a 
'   DataGridView.
'
' Notes:
'   - Reads CSV file using TextFieldParser to handle quoted 
'     descriptions with commas.
'   - Assumes CSV format: Date,Type,Category,Amount,Description
'   - Filters are optional; leaving them blank includes all results.
'
'----------------------------------------------------------
Imports System.IO

Public Class frmSearchTransactions
    '   Triggered when the Search button is clicked. 
    '   Loads transactions from "Transactions.csv", applies 
    '   filters, and displays matching results in dgvResults.
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' Clear existing results
        dgvResults.Rows.Clear()

        ' Load all lines from the CSV file
        Dim filePath As String = "Transactions.csv"
        If Not File.Exists(filePath) Then
            MessageBox.Show("Transaction file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim lines As String() = File.ReadAllLines(filePath)

        ' Get filter values
        Dim searchDesc As String = txtSearchDescription.Text.Trim().ToLower()
        Dim fromDate As Date = dtpFromDate.Value.Date
        Dim toDate As Date = dtpToDate.Value.Date
        Dim typeFilter As String = cmbTypeFilter.Text
        Dim categoryFilter As String = cmbCategoryFilter.Text

        ' Parse each line and filter
        For Each line In lines
            Dim fields As String() = line.Split(","c)
            If fields.Length < 5 Then Continue For

            Dim transDate As Date
            If Not Date.TryParseExact(fields(0), "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, transDate) Then Continue For

            Dim transType As String = fields(1).Trim()
            Dim transCategory As String = fields(2).Trim()
            Dim transAmount As String = fields(3).Trim()
            Dim transDescription As String = fields(4).Trim()

            ' Apply filters
            If Not String.IsNullOrWhiteSpace(searchDesc) AndAlso Not transDescription.ToLower().Contains(searchDesc) Then Continue For
            If transDate < fromDate Or transDate > toDate Then Continue For
            If typeFilter <> "All" AndAlso transType <> typeFilter Then Continue For
            If categoryFilter <> "All" AndAlso transCategory <> categoryFilter Then Continue For

            ' Add matching row to DataGridView
            dgvResults.Rows.Add(transDescription, transAmount, transType, transDate.ToString("dd/MM/yyyy"), transCategory)
        Next
    End Sub
End Class