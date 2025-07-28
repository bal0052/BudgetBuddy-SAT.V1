' NAME: frmSearchTransactions.vb
' AUTHOR: Nayan Balla
' DATE: July 2025
' PURPOSE: Allows users to search for past financial transactions based on filters such as
'          description, date range, transaction type, and category. Results are displayed
'          in a DataGridView.
' INPUT: User input from TextBox (description), DatePickers (from/to date), and ComboBoxes (type, category)
' OUTPUT: Filtered transaction rows displayed in DataGridView



Imports System.Globalization
Imports System.IO
Public Class frmSearchTransactions
    Private Sub frmSearchTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' Load default filter values and populate combo boxes
        cmbTypeFilter.Items.Clear()
            cmbTypeFilter.Items.AddRange({"All", "Income", "Expense"})
            cmbTypeFilter.SelectedIndex = 0

            cmbCategoryFilter.Items.Clear()
            cmbCategoryFilter.Items.AddRange({"All", "Salary", "Food", "Transport", "Shopping", "Bills", "Other"})
            cmbCategoryFilter.SelectedIndex = 0

            ' Set date pickers to the last month
            dtpFromDate.Value = Date.Today.AddMonths(-1)
            dtpToDate.Value = Date.Today
        End Sub

        ' Handles the Search button click
        Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
            dgvResults.Rows.Clear()

            Dim fromDate As Date = dtpFromDate.Value.Date
            Dim toDate As Date = dtpToDate.Value.Date
            Dim descFilter As String = txtSearchDescription.Text.Trim().ToLower()
            Dim typeFilter As String = cmbTypeFilter.SelectedItem.ToString()
            Dim categoryFilter As String = cmbCategoryFilter.SelectedItem.ToString()

            ' Exit if file does not exist
            If Not File.Exists("Transactions.csv") Then
                MessageBox.Show("No transactions file found.", "File Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim lines As String() = File.ReadAllLines("Transactions.csv")

            ' Loop through each line in the CSV file
            For Each line As String In lines
                Dim fields As List(Of String) = ParseCsvLine(line)
                If fields.Count < 5 Then Continue For ' Skip invalid rows

                ' Fields: Date, Type, Category, Amount, Description
                Dim transDate As Date
                If Not Date.TryParseExact(fields(0), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, transDate) Then Continue For

                Dim transType As String = fields(1).Trim()
                Dim transCategory As String = fields(2).Trim()
                Dim transAmount As String = fields(3).Trim()
                Dim transDescription As String = fields(4).Trim().ToLower()

                ' Apply all selected filters
                If transDate < fromDate OrElse transDate > toDate Then Continue For
                If typeFilter <> "All" AndAlso transType <> typeFilter Then Continue For
                If categoryFilter <> "All" AndAlso transCategory <> categoryFilter Then Continue For
                If Not transDescription.Contains(descFilter) Then Continue For

                ' Add matching transaction to the DataGridView
                dgvResults.Rows.Add(fields(4), transAmount, transType, fields(0), transCategory)
            Next
        End Sub

        ' Safely parse a CSV line with support for quoted values
        Private Function ParseCsvLine(line As String) As List(Of String)
            Dim result As New List(Of String)
            Dim inQuotes As Boolean = False
            Dim currentField As String = ""

            For i As Integer = 0 To line.Length - 1
                Dim ch As Char = line(i)

                If ch = """"c Then
                    inQuotes = Not inQuotes
                ElseIf ch = ","c AndAlso Not inQuotes Then
                    result.Add(currentField)
                    currentField = ""
                Else
                    currentField &= ch
                End If
            Next

            result.Add(currentField)
            Return result
        End Function
End Class