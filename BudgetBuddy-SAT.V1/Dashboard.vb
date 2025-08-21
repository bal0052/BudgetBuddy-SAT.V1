'------------------------------------------------------------------------------
' File:        frmDashboard.vb
' Description: Dashboard form for BudgetBuddy-SAT.V1. Handles navigation to
'              Add Income/Expense, Search Transactions, Set Saving Goal,
'              and Notify Alerts forms. Displays balances, monthly summaries,
'              savings goals, and alerts.
' Author:      Nayan
' Date:        7/08/2025
'------------------------------------------------------------------------------

Imports System.IO

Public Class frmDashboard

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblGreetUser.Text = "Hello, " & Session.LoggedInName
        UpdateDashboard()  ' Populate dashboard on first load
    End Sub

    Private Sub frmDashboard_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        UpdateDashboard()  ' Refresh data when returning from other forms
    End Sub

    ' Refreshes balances, savings goals, and alerts
    Private Sub UpdateDashboard()
        ComputeTransactionFigures()
        UpdateSavingsGoalLabel()
        DisplayAlertsInLabels()
    End Sub

    ' Reads Transactions.csv and calculates totals
    Private Sub ComputeTransactionFigures()
        Dim filePath As String = "Transactions.csv"
        Dim totalBalance As Decimal = 0
        Dim monthIncome As Decimal = 0
        Dim monthExpense As Decimal = 0
        Dim currentMonth As Integer = Date.Now.Month
        Dim currentYear As Integer = Date.Now.Year

        If File.Exists(filePath) Then
            Dim lines = File.ReadAllLines(filePath)

            For Each line In lines
                Dim fields = line.Split(","c)
                If fields.Length < 5 Then Continue For  ' Skip invalid rows

                Dim transDate As Date
                If Not Date.TryParseExact(fields(0), "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, transDate) Then Continue For

                Dim typ As String = fields(1).Trim()
                Dim amount As Decimal

                If Decimal.TryParse(fields(3), amount) Then
                    If typ = "Income" Then
                        totalBalance += amount  ' Add to overall balance
                        If transDate.Month = currentMonth AndAlso transDate.Year = currentYear Then
                            monthIncome += amount  ' Track monthly income
                        End If
                    ElseIf typ = "Expense" Then
                        totalBalance -= amount  ' Subtract from overall balance
                        If transDate.Month = currentMonth AndAlso transDate.Year = currentYear Then
                            monthExpense += amount  ' Track monthly expenses
                        End If
                    End If
                End If
            Next
        End If

        ' Update labels with calculated values
        lblTotalBalance1.Text = $"Total Balance: ${totalBalance:F2}"
        lblMonthlyIncome.Text = $"Monthly Income: ${monthIncome:F2}"
        lblMonthlySpending.Text = $"Monthly Spending: ${monthExpense:F2}"
        lblMonthlyBalance.Text = $"Monthly Balance: ${(monthIncome - monthExpense):F2}"
    End Sub

    ' Reads SavingGoal.csv and updates the label
    Private Sub UpdateSavingsGoalLabel()
        Dim goalPath As String = "SavingGoal.csv"

        If Not File.Exists(goalPath) Then
            lblSavingsGoal.Text = "No savings goal available."
            Return
        End If

        Dim lines = File.ReadAllLines(goalPath)
        If lines.Length = 0 Then
            lblSavingsGoal.Text = "No savings goal available."
            Return
        End If

        Dim parts = lines(0).Split(","c)
        If parts.Length < 2 Then
            lblSavingsGoal.Text = "No savings goal available."
            Return
        End If

        Dim goalAmount As Decimal
        Dim currentSavings As Decimal

        If Decimal.TryParse(parts(0), goalAmount) AndAlso Decimal.TryParse(parts(1), currentSavings) Then
            Dim progress As Decimal = (currentSavings / goalAmount) * 100
            lblSavingsGoal.Text = $"Savings Goal: ${goalAmount:F2} | Current: ${currentSavings:F2} | Progress: {progress:F0}%"
        Else
            lblSavingsGoal.Text = "No savings goal available."  ' In case of bad CSV data
        End If
    End Sub

    ' Collects alerts from helper functions and displays them
    Private Sub DisplayAlertsInLabels()
        Dim allAlerts As New List(Of String)

        allAlerts.AddRange(GetSavingsGoalAlerts())
        allAlerts.AddRange(GetLowBalanceAlerts())
        allAlerts.AddRange(GetOverspendingAlerts())

        If allAlerts.Count = 0 Then
            lblAlerts.Text = "No alerts"
        Else
            lblAlerts.Text = String.Join(Environment.NewLine, allAlerts)  ' Display multiple alerts stacked
        End If
    End Sub

    ' Checks if savings goal is reached or close
    Private Function GetSavingsGoalAlerts() As List(Of String)
        Dim alerts As New List(Of String)
        Dim goalPath As String = "SavingGoal.csv"

        If Not File.Exists(goalPath) Then Return alerts

        Dim lines = File.ReadAllLines(goalPath)
        If lines.Length = 0 Then Return alerts

        Dim parts = lines(0).Split(","c)
        If parts.Length < 2 Then Return alerts

        Dim goalAmount As Decimal
        Dim currentSavings As Decimal

        If Decimal.TryParse(parts(0), goalAmount) AndAlso Decimal.TryParse(parts(1), currentSavings) Then
            If currentSavings >= goalAmount Then
                alerts.Add("🎉 Savings goal reached!")
            ElseIf currentSavings >= goalAmount * 0.9D Then
                alerts.Add("⚠ Almost at your savings goal!")
            End If
        End If

        Return alerts
    End Function

    ' Alerts if total balance < $100
    Private Function GetLowBalanceAlerts() As List(Of String)
        Dim alerts As New List(Of String)
        Dim filePath As String = "Transactions.csv"

        If Not File.Exists(filePath) Then Return alerts

        Dim totalBalance As Decimal = 0
        Dim lines = File.ReadAllLines(filePath)

        For Each line In lines
            Dim fields = line.Split(","c)
            If fields.Length < 4 Then Continue For

            Dim amount As Decimal
            If Decimal.TryParse(fields(3), amount) Then
                If fields(1).Trim() = "Income" Then
                    totalBalance += amount
                ElseIf fields(1).Trim() = "Expense" Then
                    totalBalance -= amount
                End If
            End If
        Next

        If totalBalance < 100 Then
            alerts.Add("⚠ Low account balance!")  ' Show alert if balance too low
        End If

        Return alerts
    End Function

    ' Alerts if current month's expenses > $500
    Private Function GetOverspendingAlerts() As List(Of String)
        Dim alerts As New List(Of String)
        Dim filePath As String = "Transactions.csv"

        If Not File.Exists(filePath) Then Return alerts

        Dim monthlyExpenses As Decimal = 0
        Dim currentMonth As Integer = Date.Now.Month
        Dim currentYear As Integer = Date.Now.Year

        Dim lines = File.ReadAllLines(filePath)

        For Each line In lines
            Dim fields = line.Split(","c)
            If fields.Length < 5 Then Continue For

            Dim transDate As Date
            If Not Date.TryParseExact(fields(0), "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, transDate) Then Continue For

            If transDate.Month = currentMonth AndAlso transDate.Year = currentYear AndAlso fields(1).Trim() = "Expense" Then
                Dim amount As Decimal
                If Decimal.TryParse(fields(3), amount) Then
                    monthlyExpenses += amount
                End If
            End If
        Next

        If monthlyExpenses > 500 Then
            alerts.Add("⚠ You have spent over $500 this month!")
        End If

        Return alerts
    End Function

    ' Navigation buttons
    Private Sub btnAddIncandExp_Click(sender As Object, e As EventArgs) Handles btnAddIncandExp.Click
        Me.Hide()
        frmAddIncomeExpense.Show()
    End Sub

    Private Sub btnSearchTransactions_Click(sender As Object, e As EventArgs) Handles btnSearchTransactions.Click
        Me.Hide()
        frmSearchTransactions.Show()
    End Sub

    Private Sub btnSetSavingGoal_Click(sender As Object, e As EventArgs) Handles btnSetSavingGoal.Click
        Me.Hide()
        frmSetSavingGoal.Show()
    End Sub

    Private Sub btnNotifyAlerts_Click(sender As Object, e As EventArgs) Handles btnNotifyAlerts.Click
        Me.Hide()
        frmNotifyAlerts.Show()
    End Sub

    Private Sub btnReportsNDTrends_Click(sender As Object, e As EventArgs) Handles btnReportsNDTrends.Click
        Me.Hide()
        frmReports.Show()
    End Sub
End Class
