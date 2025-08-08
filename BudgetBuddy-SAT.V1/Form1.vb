'------------------------------------------------------------------------------
' File:        Form1.vb
' Description: Dashboard form for BudgetBuddy-SAT.V1. Handles navigation to
'              Add Income/Expense and Search Transactions forms.
' Author:      Nayan
' Date:        7/08/2025
'-----------------------------------------
Imports System.IO
Imports System.Reflection.Emit

Public Class frmDashboard

    Private Sub btnAddIncandExp_Click(sender As Object, e As EventArgs) Handles btnAddIncandExp.Click
        Me.Hide()
        frmAddIncomeExpense.Show()  'This will hide the dashboard form and show the Add Income and Expense form when the button is clicked.
    End Sub

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblGreetUser.Text = "Hello, " & Session.LoggedInName
        DisplayAlertsInLabels()  ' Display alerts in labels 
    End Sub


    '------------------------------------------------------
    ' Subroutine: DisplayAlertsInLabels
    ' Purpose: Clears the Labels and loads all alerts
    '          from helper functions into the UI.
    '------------------------------------------------------

    Private Sub DisplayAlertsInLabels()
        Dim allAlerts As New List(Of String)

        allAlerts.AddRange(GetSavingsGoalAlerts())
        allAlerts.AddRange(GetLowBalanceAlerts())
        allAlerts.AddRange(GetOverspendingAlerts())

        ' Set default text
        Label3.Text = "No alerts"
        Label2.Text = ""

        If allAlerts.Count > 0 Then
            Label3.Text = allAlerts(0) ' First alert
        End If

        If allAlerts.Count > 1 Then
            Label2.Text = allAlerts(1) ' Second alert
        End If
    End Sub

    '------------------------------------------------------
    ' Function: GetSavingsGoalAlerts
    ' Purpose: Checks savings goal progress and returns
    '          alerts if nearing or meeting the goal.
    '------------------------------------------------------
    Private Function GetSavingsGoalAlerts() As List(Of String)
        Dim alerts As New List(Of String)
        Dim goalPath As String = "SavingsGoal.csv"

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
                If fields(1).Trim().ToLower() = "income" Then
                    totalBalance += amount
                ElseIf fields(1).Trim().ToLower() = "expense" Then
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

    Private Sub btnSearchTransactions_Click(sender As Object, e As EventArgs) Handles btnSearchTransactions.Click
        Me.Hide()
        frmSearchTransactions.Show()  'This will hide the dashboard form and show the Search Transactions form when the button is clicked.
    End Sub

    Private Sub btnSetSavingGoal_Click(sender As Object, e As EventArgs) Handles btnSetSavingGoal.Click
        Me.Hide()
        frmSetSavingGoal.Show()  'This will hide the dashboard form and show the Set Saving Goal form when the button is clicked.   
    End Sub
End Class
