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
        lblWelcome.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblWelcome.ForeColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        lblWelcome.Location = New Point(696, 62)
        lblWelcome.Margin = New Padding(6, 0, 6, 0)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(726, 92)
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
        pnlSidebar.Margin = New Padding(6)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(464, 1197)
        pnlSidebar.TabIndex = 2
        ' 
        ' btnNotifyAlerts
        ' 
        btnNotifyAlerts.BackColor = Color.Transparent
        btnNotifyAlerts.FlatStyle = FlatStyle.Flat
        btnNotifyAlerts.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNotifyAlerts.ForeColor = Color.White
        btnNotifyAlerts.Location = New Point(22, 890)
        btnNotifyAlerts.Margin = New Padding(6)
        btnNotifyAlerts.Name = "btnNotifyAlerts"
        btnNotifyAlerts.Size = New Size(418, 85)
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
        btnReportsNDTrends.Location = New Point(22, 691)
        btnReportsNDTrends.Margin = New Padding(6)
        btnReportsNDTrends.Name = "btnReportsNDTrends"
        btnReportsNDTrends.Size = New Size(418, 158)
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
        btnSearchTransactions.Location = New Point(22, 425)
        btnSearchTransactions.Margin = New Padding(6)
        btnSearchTransactions.Name = "btnSearchTransactions"
        btnSearchTransactions.Size = New Size(418, 133)
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
        btnSetSavingGoal.Location = New Point(22, 576)
        btnSetSavingGoal.Margin = New Padding(6)
        btnSetSavingGoal.Name = "btnSetSavingGoal"
        btnSetSavingGoal.Size = New Size(418, 85)
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
        btnAddIncandExp.Location = New Point(22, 239)
        btnAddIncandExp.Margin = New Padding(6)
        btnAddIncandExp.Name = "btnAddIncandExp"
        btnAddIncandExp.Size = New Size(420, 154)
        btnAddIncandExp.TabIndex = 3
        btnAddIncandExp.Text = "Add Income and Expenses"
        btnAddIncandExp.UseVisualStyleBackColor = False
        ' 
        ' lblLogo
        ' 
        lblLogo.AutoSize = True
        lblLogo.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLogo.ForeColor = Color.White
        lblLogo.Location = New Point(22, 58)
        lblLogo.Margin = New Padding(6, 0, 6, 0)
        lblLogo.Name = "lblLogo"
        lblLogo.Size = New Size(451, 86)
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
        pnlDashboard.Location = New Point(483, 171)
        pnlDashboard.Margin = New Padding(6)
        pnlDashboard.Name = "pnlDashboard"
        pnlDashboard.Size = New Size(1114, 960)
        pnlDashboard.TabIndex = 3
        ' 
        ' lblAlerts
        ' 
        lblAlerts.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAlerts.ForeColor = Color.Red
        lblAlerts.Location = New Point(211, 641)
        lblAlerts.Margin = New Padding(6, 0, 6, 0)
        lblAlerts.Name = "lblAlerts"
        lblAlerts.Size = New Size(480, 120)
        lblAlerts.TabIndex = 10
        lblAlerts.Text = "No alerts available."
        ' 
        ' lblMonthlyBalance
        ' 
        lblMonthlyBalance.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        lblMonthlyBalance.ForeColor = Color.DarkBlue
        lblMonthlyBalance.Location = New Point(130, 265)
        lblMonthlyBalance.Name = "lblMonthlyBalance"
        lblMonthlyBalance.Size = New Size(502, 64)
        lblMonthlyBalance.TabIndex = 9
        lblMonthlyBalance.Text = "Monthly Balance: $0.00"
        ' 
        ' lblMonthlyIncome
        ' 
        lblMonthlyIncome.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        lblMonthlyIncome.Location = New Point(132, 343)
        lblMonthlyIncome.Name = "lblMonthlyIncome"
        lblMonthlyIncome.Size = New Size(500, 76)
        lblMonthlyIncome.TabIndex = 8
        lblMonthlyIncome.Text = "Monthly Income: $0.00"
        ' 
        ' lstAlerts
        ' 
        lstAlerts.FormattingEnabled = True
        lstAlerts.Location = New Point(834, 719)
        lstAlerts.Margin = New Padding(6)
        lstAlerts.Name = "lstAlerts"
        lstAlerts.Size = New Size(34, 100)
        lstAlerts.TabIndex = 7
        ' 
        ' lblGreetUser
        ' 
        lblGreetUser.AutoSize = True
        lblGreetUser.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGreetUser.Location = New Point(47, 68)
        lblGreetUser.Margin = New Padding(6, 0, 6, 0)
        lblGreetUser.Name = "lblGreetUser"
        lblGreetUser.Size = New Size(141, 57)
        lblGreetUser.TabIndex = 6
        lblGreetUser.Text = "Hello,"
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(854, 770)
        Label3.Margin = New Padding(6, 0, 6, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 18)
        Label3.TabIndex = 5
        Label3.Text = "⚠ Rent due in 3 days"
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(1011, 854)
        Label2.Margin = New Padding(6, 0, 6, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 34)
        Label2.TabIndex = 4
        Label2.Text = "⚠ Weekly grocery budget exceeded"
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(150, 571)
        Label1.Margin = New Padding(6, 0, 6, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(368, 57)
        Label1.TabIndex = 3
        Label1.Text = "Upcoming Alerts:"
        ' 
        ' lblSavingsGoal
        ' 
        lblSavingsGoal.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSavingsGoal.ForeColor = Color.Black
        lblSavingsGoal.Location = New Point(132, 491)
        lblSavingsGoal.Margin = New Padding(6, 0, 6, 0)
        lblSavingsGoal.Name = "lblSavingsGoal"
        lblSavingsGoal.Size = New Size(564, 57)
        lblSavingsGoal.TabIndex = 2
        lblSavingsGoal.Text = "No saving goals available."
        ' 
        ' lblMonthlySpending
        ' 
        lblMonthlySpending.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMonthlySpending.ForeColor = Color.Black
        lblMonthlySpending.Location = New Point(132, 419)
        lblMonthlySpending.Margin = New Padding(6, 0, 6, 0)
        lblMonthlySpending.Name = "lblMonthlySpending"
        lblMonthlySpending.Size = New Size(444, 57)
        lblMonthlySpending.TabIndex = 1
        lblMonthlySpending.Text = "Monthly Spending: $0.00"
        ' 
        ' lblTotalBalance1
        ' 
        lblTotalBalance1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalBalance1.ForeColor = Color.DarkGreen
        lblTotalBalance1.Location = New Point(38, 181)
        lblTotalBalance1.Margin = New Padding(6, 0, 6, 0)
        lblTotalBalance1.Name = "lblTotalBalance1"
        lblTotalBalance1.Size = New Size(501, 57)
        lblTotalBalance1.TabIndex = 0
        lblTotalBalance1.Text = "Total Balance: $0.00"
        ' 
        ' lblTotalBalance
        ' 
        lblTotalBalance.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalBalance.ForeColor = Color.DarkGreen
        lblTotalBalance.Location = New Point(929, 891)
        lblTotalBalance.Margin = New Padding(6, 0, 6, 0)
        lblTotalBalance.Name = "lblTotalBalance"
        lblTotalBalance.Size = New Size(69, 10)
        lblTotalBalance.TabIndex = 0
        lblTotalBalance.Text = "Total Balance: $4,500.00"
        ' 
        ' frmDashboard
        ' 
        AutoScaleDimensions = New SizeF(13.0F, 32.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1642, 1197)
        Controls.Add(pnlDashboard)
        Controls.Add(pnlSidebar)
        Controls.Add(lblWelcome)
        Margin = New Padding(6)
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
