'------------------------------------------------------------------------------
' File:        frmReports.vb
' Description: Displays reports & trends using charts for spending categories
'              and monthly income vs expenses. Allows CSV export.
' Author:      Nayan
' Date:        21/08/2025
'------------------------------------------------------------------------------

Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmReports

    ' Form load: populate charts with initial data
    Private Sub frmReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFrom.Value = New DateTime(Date.Now.Year, Date.Now.Month, 1)
        dtpTo.Value = Date.Now
        LoadChartsAndTotals()
    End Sub

    ' Refresh charts and totals based on date filter
    Private Sub LoadChartsAndTotals()
        Dim filePath As String = "Transactions.csv"
        If Not File.Exists(filePath) Then Return

        Dim transactions = File.ReadAllLines(filePath).Select(Function(l) l.Split(","c)).ToList()

        ' Date range filter
        Dim fromDate As Date = dtpFrom.Value.Date
        Dim toDate As Date = dtpTo.Value.Date

        ' Totals
        Dim totalIncome As Decimal = 0
        Dim totalExpenses As Decimal = 0
        Dim categoryTotals As New Dictionary(Of String, Decimal)(StringComparer.OrdinalIgnoreCase)

        For Each t In transactions
            If t.Length < 5 Then Continue For
            Dim transDate As Date
            If Not Date.TryParseExact(t(0), "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, transDate) Then Continue For
            If transDate < fromDate OrElse transDate > toDate Then Continue For

            Dim typ As String = t(1).Trim()
            Dim category As String = t(2).Trim()
            Dim amount As Decimal
            If Not Decimal.TryParse(t(3), amount) Then Continue For

            If typ = "Income" Then
                totalIncome += amount
            ElseIf typ = "Expense" Then
                totalExpenses += amount
                ' Add to category total
                If categoryTotals.ContainsKey(category) Then
                    categoryTotals(category) += amount
                Else
                    categoryTotals(category) = amount
                End If
            End If
        Next

        ' Update labels with thousands separators
        lblTotalExpense.Text = $"Total Income: ${totalIncome:N2}"
        lblTotalExpense1.Text = $"Total Expenses: ${totalExpenses:N2}"
        lblNetBalance.Text = $"Net Balance: ${(totalIncome - totalExpenses):N2}"


        ' Update Spending by Category chart
        chartSpendingCategory.Series(0).Points.Clear()
        For Each kvp In categoryTotals
            chartSpendingCategory.Series(0).Points.AddXY(kvp.Key, kvp.Value)
        Next

        ' Update Income vs Expenses chart
        chartIncomeVsExpenses.Series(0).Points.Clear()
        chartIncomeVsExpenses.Series(0).Points.AddXY("Income", totalIncome)
        chartIncomeVsExpenses.Series(0).Points.AddXY("Expenses", totalExpenses)
    End Sub

    ' Date pickers change event: reload charts
    Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged, dtpTo.ValueChanged
        LoadChartsAndTotals()
    End Sub

    ' Export currently displayed transactions to CSV
    Private Sub btnExportToCSV_Click(sender As Object, e As EventArgs) Handles btnExportToCSV.Click
        Dim sfd As New SaveFileDialog With {
            .Filter = "CSV Files|*.csv",
            .Title = "Export Report to CSV",
            .FileName = "BudgetBuddy_Report.csv"
        }

        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                Dim lines As New List(Of String)
                lines.Add("Type,Category,Amount,Date,Description")

                Dim filePath As String = "Transactions.csv"
                If File.Exists(filePath) Then
                    Dim transactions = File.ReadAllLines(filePath).Select(Function(l) l.Split(","c)).ToList()
                    Dim fromDate As Date = dtpFrom.Value.Date
                    Dim toDate As Date = dtpTo.Value.Date

                    For Each t In transactions
                        If t.Length < 5 Then Continue For
                        Dim transDate As Date
                        If Not Date.TryParseExact(t(0), "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, transDate) Then Continue For
                        If transDate < fromDate OrElse transDate > toDate Then Continue For

                        lines.Add(String.Join(",", t))
                    Next
                End If

                File.WriteAllLines(sfd.FileName, lines)
                MessageBox.Show("Report exported successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show($"Error exporting report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class
