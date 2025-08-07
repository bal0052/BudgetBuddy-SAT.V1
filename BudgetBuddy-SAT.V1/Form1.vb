'------------------------------------------------------------------------------
' File:        Form1.vb
' Description: Dashboard form for BudgetBuddy-SAT.V1. Handles navigation to
'              Add Income/Expense and Search Transactions forms.
' Author:      Nayan
' Date:        7/08/2025
'-----------------------------------------

Public Class frmDashboard

    Private Sub btnAddIncandExp_Click(sender As Object, e As EventArgs) Handles btnAddIncandExp.Click
        Me.Hide()
        frmAddIncomeExpense.Show()  'This will hide the dashboard form and show the Add Income and Expense form when the button is clicked.
    End Sub

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblGreetUser.Text = "Hello, " & Session.LoggedInName
    End Sub

    Private Sub btnSearchTransactions_Click(sender As Object, e As EventArgs) Handles btnSearchTransactions.Click
        Me.Hide()
        frmSearchTransactions.Show()  'This will hide the dashboard form and show the Search Transactions form when the button is clicked.
    End Sub

    Private Sub btnSetSavingGoal_Click(sender As Object, e As EventArgs) Handles btnSetSavingGoal.Click
        Me.Hide()
        frmSetSavingGoal.Show()  'This will hide the dashboard form and show the Set Saving Goal form when the button is clicked.   
    End Sub
End Class
