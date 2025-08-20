'------------------------------------------------------------------------------
' File:        Form1.vb
' Description: Dashboard form for BudgetBuddy-SAT.V1. Handles navigation,
'              savings goal display, balances, alerts and spending overview.
' Author:      Nayan
' Date:        7/08/2025
'------------------------------------------------------------------------------

Imports System.IO
Imports System.Reflection.Emit

Public Class frmDashboard

    '------------------------------------------------------
    ' Event: frmDashboard_Load
    ' Purpose: Executes when dashboard is loaded. Greets
    '          the user, updates savings goal display,
    '          and loads alerts into the labels.
    '------------------------------------------------------
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblGreetUser.Text = "Hello, " & Session.LoggedInName
        RefreshDashboard()
    End Sub

    Private Sub frmDashboard_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        RefreshDashboard()
    End Sub

    '------------------------------------------------------
    ' Subroutine: DisplayTotalBalance
    ' Purpose: Reads Transactions.csv and calculates the
    '          overall balance to show on the dashboard.
    '------------------------------------------------------
    Private Sub DisplayTotalBalance()
        Dim filePath As String = "Transactions.csv"
        Dim totalBalance As Decimal = 0

        If File.Exists(filePath) Then
            Dim lines = File.ReadAllLines(filePath)
            For Each line In lines
                Dim fields = line.Split(","c)
                If fields.Length < 4 Then Continue For

                Dim amount As Decimal
                If Decimal.TryParse(fields(3), amount) Then
                    If fields(1).Trim().ToLower() = "Income" Then
                        totalBalance += amount
                    ElseIf fields(1).Trim().ToLower() = "Expense" Then
                        totalBalance -= amount
                    End If
                End If
            Next
        End If

        lblTotalBalance1.Text = "Total Balance: $" & totalBalance.ToString("N2")
    End Sub

    '------------------------------------------------------
    ' Subroutine: DisplayMonthlyBalances
    ' Purpose: Calculates income and expenses for current
    '          month and updates labels.
    '------------------------------------------------------
    Private Sub DisplayMonthlyBalances()
        Dim filePath As String = "Transactions.csv"
        Dim monthlyIncome As Decimal = 0
        Dim monthlyExpenses As Decimal = 0

        If File.Exists(filePath) Then
            Dim currentMonth As Integer = Date.Now.Month
            Dim currentYear As Integer = Date.Now.Year
            Dim lines = File.ReadAllLines(filePath)

            For Each line In lines
                Dim fields = line.Split(","c)
                If fields.Length < 5 Then Continue For

                Dim transDate As Date
                If Date.TryParseExact(fields(0), "dd/MM/yyyy", Nothing,
                                  Globalization.DateTimeStyles.None, transDate) Then
                    If transDate.Month = currentMonth AndAlso transDate.Year = currentYear Then
                        Dim amount As Decimal
                        If Decimal.TryParse(fields(3), amount) Then
                            If fields(1).Trim().ToLower() = "Income" Then
                                monthlyIncome += amount
                            ElseIf fields(1).Trim().ToLower() = "Expense" Then
                                monthlyExpenses += amount
                            End If
                        End If
                    End If
                End If
            Next
        End If

        lblMonthlyIncome.Text = "Monthly Income: $" & monthlyIncome.ToString("N2")
        lblMonthlySpending.Text = "Monthly Spending: $" & monthlyExpenses.ToString("N2")
        lblMonthlyBalance.Text = "Monthly Balance: $" & (monthlyIncome - monthlyExpenses).ToString("N2")
    End Sub

    '------------------------------------------------------
    ' Subroutine: DisplaySavingsGoal
    ' Purpose: Reads SavingsGoal.csv and updates the
    '          savings goal label.
    '------------------------------------------------------
    Private Sub DisplaySavingsGoal()
        Dim goalPath As String = "SavingGoal.csv"

        If Not File.Exists(goalPath) Then
            lblSavingsGoal.Text = "No savings goal set"
            Return
        End If

        Dim lines = File.ReadAllLines(goalPath)
        If lines.Length = 0 Then
            lblSavingsGoal.Text = "No savings goal set"
            Return
        End If

        Dim parts = lines(0).Split(","c)
        If parts.Length < 2 Then
            lblSavingsGoal.Text = "No savings goal set"
            Return
        End If

        Dim goalAmount As Decimal
        Dim currentSavings As Decimal

        If Decimal.TryParse(parts(0), goalAmount) AndAlso Decimal.TryParse(parts(1), currentSavings) Then
            Dim progress As Decimal = (currentSavings / goalAmount) * 100
            lblSavingsGoal.Text = $"Savings Goal: ${goalAmount:N2} | Progress: {progress:N0}%"
        Else
            lblSavingsGoal.Text = "No savings goal set"
        End If
    End Sub

    '------------------------------------------------------
    ' Subroutine: DisplayAlerts
    ' Purpose: Combines all alerts and displays them in lblAlerts
    '------------------------------------------------------
    Private Sub DisplayAlerts()
        Dim allAlerts As New List(Of String)

        allAlerts.AddRange(GetSavingsGoalAlerts())
        allAlerts.AddRange(GetLowBalanceAlerts())
        allAlerts.AddRange(GetOverspendingAlerts())

        If allAlerts.Count = 0 Then
            lblAlerts.Text = "No alerts"
        Else
            lblAlerts.Text = String.Join(Environment.NewLine, allAlerts)
        End If
    End Sub

    '------------------------------------------------------
    ' Subroutine: RefreshDashboard
    ' Purpose: Refreshes all dashboard values
    '------------------------------------------------------
    Private Sub RefreshDashboard()
        DisplayTotalBalance()
        DisplayMonthlyBalances()
        DisplaySavingsGoal()
        DisplayAlerts()
    End Sub

    '------------------------------------------------------
    ' Function: GetSavingsGoalAlerts
    ' Purpose: Checks savings goal progress and returns
    '          alerts if nearing or meeting the goal.
    '------------------------------------------------------
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
                alerts.Add("Almost at your savings goal!")
            End If
        End If

        Return alerts
    End Function

    '------------------------------------------------------
    ' Function: GetLowBalanceAlerts
    ' Purpose: Alerts if total balance is below threshold.
    '------------------------------------------------------
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
                If fields(1).Trim().ToLower() = "Income" Then
                    totalBalance += amount
                ElseIf fields(1).Trim().ToLower() = "Expense" Then
                    totalBalance -= amount
                End If
            End If
        Next

        If totalBalance < 100 Then
            alerts.Add("⚠ Low account balance!")
        End If

        Return alerts
    End Function

    '------------------------------------------------------
    ' Function: GetOverspendingAlerts
    ' Purpose: Alerts if expenses for the month exceed $500.
    '------------------------------------------------------
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

            If transDate.Month = currentMonth AndAlso transDate.Year = currentYear AndAlso fields(1).Trim().ToLower() = "expense" Then
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

    '------------------------------------------------------
    ' Navigation Buttons
    ' Purpose: Handle navigation to other forms
    '------------------------------------------------------
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

End Class
