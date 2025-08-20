<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblWelcome = New Label()
        pnlSidebar = New Panel()
        btnNotifyAlerts = New Button()
        btnReportsNDTrends = New Button()
        btnSearchTransactions = New Button()
        btnSetSavingGoal = New Button()
        btnAddIncandExp = New Button()
        lblLogo = New Label()
        pnlDashboard = New Panel()
        lblAlerts = New Label()
        lblMonthlyBalance = New Label()
        lblMonthlyIncome = New Label()
        lstAlerts = New ListBox()
        lblGreetUser = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        lblSavingsGoal = New Label()
        lblMonthlySpending = New Label()
        lblTotalBalance1 = New Label()
        lblTotalBalance = New Label()
        pnlSidebar.SuspendLayout()
        pnlDashboard.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblWelcome
        ' 
        lblWelcome.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblWelcome.ForeColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        lblWelcome.Location = New Point(375, 29)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(391, 43)
        lblWelcome.TabIndex = 1
        lblWelcome.Text = "Welcome to BudgetBuddy"
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        pnlSidebar.Controls.Add(btnNotifyAlerts)
        pnlSidebar.Controls.Add(btnReportsNDTrends)
        pnlSidebar.Controls.Add(btnSearchTransactions)
        pnlSidebar.Controls.Add(btnSetSavingGoal)
        pnlSidebar.Controls.Add(btnAddIncandExp)
        pnlSidebar.Controls.Add(lblLogo)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(250, 497)
        pnlSidebar.TabIndex = 2
        ' 
        ' btnNotifyAlerts
        ' 
        btnNotifyAlerts.BackColor = Color.Transparent
        btnNotifyAlerts.FlatStyle = FlatStyle.Flat
        btnNotifyAlerts.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNotifyAlerts.ForeColor = Color.White
        btnNotifyAlerts.Location = New Point(12, 417)
        btnNotifyAlerts.Name = "btnNotifyAlerts"
        btnNotifyAlerts.Size = New Size(225, 40)
        btnNotifyAlerts.TabIndex = 7
        btnNotifyAlerts.Text = "Notify Alerts"
        btnNotifyAlerts.UseVisualStyleBackColor = False
        ' 
        ' btnReportsNDTrends
        ' 
        btnReportsNDTrends.BackColor = Color.Transparent
        btnReportsNDTrends.FlatStyle = FlatStyle.Flat
        btnReportsNDTrends.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReportsNDTrends.ForeColor = Color.White
        btnReportsNDTrends.Location = New Point(12, 324)
        btnReportsNDTrends.Name = "btnReportsNDTrends"
        btnReportsNDTrends.Size = New Size(225, 74)
        btnReportsNDTrends.TabIndex = 6
        btnReportsNDTrends.Text = "View Reports and Trends"
        btnReportsNDTrends.UseVisualStyleBackColor = False
        ' 
        ' btnSearchTransactions
        ' 
        btnSearchTransactions.BackColor = Color.Transparent
        btnSearchTransactions.FlatStyle = FlatStyle.Flat
        btnSearchTransactions.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearchTransactions.ForeColor = Color.White
        btnSearchTransactions.Location = New Point(12, 199)
        btnSearchTransactions.Name = "btnSearchTransactions"
        btnSearchTransactions.Size = New Size(225, 62)
        btnSearchTransactions.TabIndex = 5
        btnSearchTransactions.Text = "Search Transactions"
        btnSearchTransactions.UseVisualStyleBackColor = False
        ' 
        ' btnSetSavingGoal
        ' 
        btnSetSavingGoal.BackColor = Color.Transparent
        btnSetSavingGoal.FlatStyle = FlatStyle.Flat
        btnSetSavingGoal.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSetSavingGoal.ForeColor = Color.White
        btnSetSavingGoal.Location = New Point(12, 270)
        btnSetSavingGoal.Name = "btnSetSavingGoal"
        btnSetSavingGoal.Size = New Size(225, 40)
        btnSetSavingGoal.TabIndex = 4
        btnSetSavingGoal.Text = "Set Saving Goal"
        btnSetSavingGoal.UseVisualStyleBackColor = False
        ' 
        ' btnAddIncandExp
        ' 
        btnAddIncandExp.BackColor = Color.Transparent
        btnAddIncandExp.FlatStyle = FlatStyle.Flat
        btnAddIncandExp.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddIncandExp.ForeColor = Color.White
        btnAddIncandExp.Location = New Point(12, 112)
        btnAddIncandExp.Name = "btnAddIncandExp"
        btnAddIncandExp.Size = New Size(226, 72)
        btnAddIncandExp.TabIndex = 3
        btnAddIncandExp.Text = "Add Income and Expenses"
        btnAddIncandExp.UseVisualStyleBackColor = False
        ' 
        ' lblLogo
        ' 
        lblLogo.AutoSize = True
        lblLogo.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLogo.ForeColor = Color.White
        lblLogo.Location = New Point(12, 27)
        lblLogo.Name = "lblLogo"
        lblLogo.Size = New Size(226, 45)
        lblLogo.TabIndex = 1
        lblLogo.Text = "BudgetBuddy"
        ' 
        ' pnlDashboard
        ' 
        pnlDashboard.BackColor = Color.WhiteSmoke
        pnlDashboard.Controls.Add(lblAlerts)
        pnlDashboard.Controls.Add(lblMonthlyBalance)
        pnlDashboard.Controls.Add(lblMonthlyIncome)
        pnlDashboard.Controls.Add(lstAlerts)
        pnlDashboard.Controls.Add(lblGreetUser)
        pnlDashboard.Controls.Add(Label3)
        pnlDashboard.Controls.Add(Label2)
        pnlDashboard.Controls.Add(Label1)
        pnlDashboard.Controls.Add(lblSavingsGoal)
        pnlDashboard.Controls.Add(lblMonthlySpending)
        pnlDashboard.Controls.Add(lblTotalBalance1)
        pnlDashboard.Controls.Add(lblTotalBalance)
        pnlDashboard.Location = New Point(260, 80)
        pnlDashboard.Name = "pnlDashboard"
        pnlDashboard.Size = New Size(600, 450)
        pnlDashboard.TabIndex = 3
        ' 
        ' lblAlerts
        ' 
        lblAlerts.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAlerts.ForeColor = Color.Red
        lblAlerts.Location = New Point(117, 313)
        lblAlerts.Name = "lblAlerts"
        lblAlerts.Size = New Size(258, 56)
        lblAlerts.TabIndex = 10
        lblAlerts.Text = "No alerts available."
        ' 
        ' lblMonthlyBalance
        ' 
        lblMonthlyBalance.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        lblMonthlyBalance.ForeColor = Color.DarkBlue
        lblMonthlyBalance.Location = New Point(70, 124)
        lblMonthlyBalance.Margin = New Padding(2, 0, 2, 0)
        lblMonthlyBalance.Name = "lblMonthlyBalance"
        lblMonthlyBalance.Size = New Size(270, 30)
        lblMonthlyBalance.TabIndex = 9
        lblMonthlyBalance.Text = "Monthly Balance: $0.00"
        ' 
        ' lblMonthlyIncome
        ' 
        lblMonthlyIncome.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        lblMonthlyIncome.Location = New Point(71, 161)
        lblMonthlyIncome.Margin = New Padding(2, 0, 2, 0)
        lblMonthlyIncome.Name = "lblMonthlyIncome"
        lblMonthlyIncome.Size = New Size(269, 36)
        lblMonthlyIncome.TabIndex = 8
        lblMonthlyIncome.Text = "Monthly Income: $0.00"
        ' 
        ' lstAlerts
        ' 
        lstAlerts.FormattingEnabled = True
        lstAlerts.ItemHeight = 15
        lstAlerts.Location = New Point(449, 337)
        lstAlerts.Name = "lstAlerts"
        lstAlerts.Size = New Size(20, 49)
        lstAlerts.TabIndex = 7
        ' 
        ' lblGreetUser
        ' 
        lblGreetUser.AutoSize = True
        lblGreetUser.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGreetUser.Location = New Point(25, 32)
        lblGreetUser.Name = "lblGreetUser"
        lblGreetUser.Size = New Size(71, 30)
        lblGreetUser.TabIndex = 6
        lblGreetUser.Text = "Hello,"
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(460, 361)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 8)
        Label3.TabIndex = 5
        Label3.Text = "⚠ Rent due in 3 days"
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(544, 400)
        Label2.Name = "Label2"
        Label2.Size = New Size(23, 16)
        Label2.TabIndex = 4
        Label2.Text = "⚠ Weekly grocery budget exceeded"
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(81, 268)
        Label1.Name = "Label1"
        Label1.Size = New Size(198, 35)
        Label1.TabIndex = 3
        Label1.Text = "Upcoming Alerts:"
        ' 
        ' lblSavingsGoal
        ' 
        lblSavingsGoal.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSavingsGoal.ForeColor = Color.Black
        lblSavingsGoal.Location = New Point(71, 230)
        lblSavingsGoal.Name = "lblSavingsGoal"
        lblSavingsGoal.Size = New Size(304, 38)
        lblSavingsGoal.TabIndex = 2
        lblSavingsGoal.Text = "No saving goals available."
        ' 
        ' lblMonthlySpending
        ' 
        lblMonthlySpending.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMonthlySpending.ForeColor = Color.Black
        lblMonthlySpending.Location = New Point(71, 196)
        lblMonthlySpending.Name = "lblMonthlySpending"
        lblMonthlySpending.Size = New Size(269, 34)
        lblMonthlySpending.TabIndex = 1
        lblMonthlySpending.Text = "Monthly Spending: $0.00"
        ' 
        ' lblTotalBalance1
        ' 
        lblTotalBalance1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalBalance1.ForeColor = Color.DarkGreen
        lblTotalBalance1.Location = New Point(20, 85)
        lblTotalBalance1.Name = "lblTotalBalance1"
        lblTotalBalance1.Size = New Size(270, 27)
        lblTotalBalance1.TabIndex = 0
        lblTotalBalance1.Text = "Total Balance: $0.00"
        ' 
        ' lblTotalBalance
        ' 
        lblTotalBalance.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalBalance.ForeColor = Color.DarkGreen
        lblTotalBalance.Location = New Point(500, 418)
        lblTotalBalance.Name = "lblTotalBalance"
        lblTotalBalance.Size = New Size(37, 5)
        lblTotalBalance.TabIndex = 0
        lblTotalBalance.Text = "Total Balance: $4,500.00"
        ' 
        ' frmDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(884, 497)
        Controls.Add(pnlDashboard)
        Controls.Add(pnlSidebar)
        Controls.Add(lblWelcome)
        Name = "frmDashboard"
        Text = "Dashboard"
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        pnlDashboard.ResumeLayout(False)
        pnlDashboard.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents lblLogo As Label
    Friend WithEvents btnSearchTransactions As Button
    Friend WithEvents btnSetSavingGoal As Button
    Friend WithEvents btnAddIncandExp As Button
    Friend WithEvents btnNotifyAlerts As Button
    Friend WithEvents btnReportsNDTrends As Button
    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents lblMonthlySpending As Label
    Friend WithEvents lblTotalBalance As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSavingsGoal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblGreetUser As Label
    Friend WithEvents lstAlerts As ListBox
    Friend WithEvents lblTotalBalance1 As Label
    Friend WithEvents lblMonthlyIncome As Label
    Friend WithEvents lblMonthlyBalance As Label
    Friend WithEvents lblAlerts As Label

End Class
