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
End Class
