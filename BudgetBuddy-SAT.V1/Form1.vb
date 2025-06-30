Public Class frmDashboard

    Private Sub btnAddIncandExp_Click(sender As Object, e As EventArgs) Handles btnAddIncandExp.Click
        Me.Hide()
        frmAddIncomeExpense.Show()  'This will hide the dashboard form and show the Add Income and Expense form when the button is clicked.
    End Sub
End Class
