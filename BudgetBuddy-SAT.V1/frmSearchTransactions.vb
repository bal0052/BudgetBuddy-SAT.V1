
Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Public Class frmSearchTransactions
    '   Triggered when the Search button is clicked. 
    '   Loads transactions from "Transactions.csv", applies 
    '   filters, and displays matching results in dgvResults.
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' Clear existing results
        dgvResults.Rows.Clear()

        ' CSV file path
        Dim filePath = "Transactions.csv"
        If Not File.Exists(filePath) Then
            MessageBox.Show("Transaction file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Get filter values
        Dim searchDesc = txtSearchDescription.Text.Trim.ToLower
        Dim fromDate = dtpFromDate.Value.Date
        Dim toDate = dtpToDate.Value.Date
        Dim typeFilter = cmbTypeFilter.Text
        Dim categoryFilter = cmbCategoryFilter.Text

        ' Read CSV with TextFieldParser (handles quotes & commas in description)
        Using parser As New TextFieldParser(filePath)
            parser.TextFieldType = FieldType.Delimited
            parser.SetDelimiters(",")
            parser.HasFieldsEnclosedInQuotes = True

            While Not parser.EndOfData
                Dim fields = parser.ReadFields
                If fields.Length < 5 Then Continue While

                ' Parse date
                Dim transDate As Date
                If Not Date.TryParseExact(fields(0), "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, transDate) Then Continue While

                Dim transType = fields(1).Trim
                Dim transCategory = fields(2).Trim
                Dim transAmount = fields(3).Trim
                Dim transDescription = fields(4).Trim

                ' Apply filters
                If Not String.IsNullOrWhiteSpace(searchDesc) AndAlso Not transDescription.ToLower.Contains(searchDesc) Then Continue While
                If transDate < fromDate Or transDate > toDate Then Continue While
                If typeFilter <> "All" AndAlso transType <> typeFilter Then Continue While
                If categoryFilter <> "All" AndAlso transCategory <> categoryFilter Then Continue While

                ' Add matching row to DataGridView
                dgvResults.Rows.Add(transDescription, transAmount, transType, transDate.ToString("dd/MM/yyyy"), transCategory)
            End While
        End Using
    End Sub

    Private Sub btnBackToDash_Click(sender As Object, e As EventArgs) Handles btnBackToDash.Click
        Me.Hide()
        frmDashboard.Show()  ' Return to the dashboard after saving
    End Sub
End Class