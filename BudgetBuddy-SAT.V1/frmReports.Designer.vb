<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New Charting.Title()
        chartSpendingCategory = New Charting.Chart()
        chartIncomeVsExpenses = New Charting.Chart()
        lblTotalExpense = New Label()
        lblTotalExpense1 = New Label()
        lblNetBalance = New Label()
        Label1 = New Label()
        dtpTo = New DateTimePicker()
        Label2 = New Label()
        dtpFrom = New DateTimePicker()
        btnExportToCSV = New Button()
        CType(chartSpendingCategory, ComponentModel.ISupportInitialize).BeginInit()
        CType(chartIncomeVsExpenses, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' chartSpendingCategory
        ' 
        ChartArea1.Name = "ChartArea1"
        chartSpendingCategory.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        chartSpendingCategory.Legends.Add(Legend1)
        chartSpendingCategory.Location = New Point(30, 30)
        chartSpendingCategory.Name = "chartSpendingCategory"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = Charting.SeriesChartType.Pie
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        chartSpendingCategory.Series.Add(Series1)
        chartSpendingCategory.Size = New Size(350, 300)
        chartSpendingCategory.TabIndex = 0
        Title1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Title1.Name = "Spending by Category"
        Title1.Text = "Spending by Category"
        chartSpendingCategory.Titles.Add(Title1)
        ' 
        ' chartIncomeVsExpenses
        ' 
        ChartArea2.Name = "ChartArea1"
        chartIncomeVsExpenses.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        chartIncomeVsExpenses.Legends.Add(Legend2)
        chartIncomeVsExpenses.Location = New Point(30, 350)
        chartIncomeVsExpenses.Name = "chartIncomeVsExpenses"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        chartIncomeVsExpenses.Series.Add(Series2)
        chartIncomeVsExpenses.Size = New Size(700, 250)
        chartIncomeVsExpenses.TabIndex = 1
        Title2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Title2.Name = "Spending by Category"
        Title2.Text = "Monthly Income vs Expenses"
        chartIncomeVsExpenses.Titles.Add(Title2)
        ' 
        ' lblTotalExpense
        ' 
        lblTotalExpense.AutoSize = True
        lblTotalExpense.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalExpense.Location = New Point(400, 40)
        lblTotalExpense.Name = "lblTotalExpense"
        lblTotalExpense.Size = New Size(157, 21)
        lblTotalExpense.TabIndex = 2
        lblTotalExpense.Text = "Total Income: $0.00"
        ' 
        ' lblTotalExpense1
        ' 
        lblTotalExpense1.AutoSize = True
        lblTotalExpense1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalExpense1.Location = New Point(400, 70)
        lblTotalExpense1.Name = "lblTotalExpense1"
        lblTotalExpense1.Size = New Size(170, 21)
        lblTotalExpense1.TabIndex = 3
        lblTotalExpense1.Text = "Total Expenses: $0.00"
        ' 
        ' lblNetBalance
        ' 
        lblNetBalance.AutoSize = True
        lblNetBalance.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNetBalance.Location = New Point(400, 102)
        lblNetBalance.Name = "lblNetBalance"
        lblNetBalance.Size = New Size(150, 21)
        lblNetBalance.TabIndex = 4
        lblNetBalance.Text = "Net Balance: $0.00"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(400, 150)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 21)
        Label1.TabIndex = 5
        Label1.Text = "From:"
        ' 
        ' dtpTo
        ' 
        dtpTo.Location = New Point(459, 196)
        dtpTo.Name = "dtpTo"
        dtpTo.Size = New Size(200, 23)
        dtpTo.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(410, 196)
        Label2.Name = "Label2"
        Label2.Size = New Size(32, 21)
        Label2.TabIndex = 7
        Label2.Text = "To:"
        ' 
        ' dtpFrom
        ' 
        dtpFrom.Location = New Point(459, 150)
        dtpFrom.Name = "dtpFrom"
        dtpFrom.Size = New Size(200, 23)
        dtpFrom.TabIndex = 8
        ' 
        ' btnExportToCSV
        ' 
        btnExportToCSV.BackColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        btnExportToCSV.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExportToCSV.ForeColor = Color.White
        btnExportToCSV.Location = New Point(514, 253)
        btnExportToCSV.Name = "btnExportToCSV"
        btnExportToCSV.Size = New Size(191, 54)
        btnExportToCSV.TabIndex = 9
        btnExportToCSV.Text = "Export to CSV"
        btnExportToCSV.UseVisualStyleBackColor = False
        ' 
        ' frmReports
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(844, 634)
        Controls.Add(btnExportToCSV)
        Controls.Add(dtpFrom)
        Controls.Add(Label2)
        Controls.Add(dtpTo)
        Controls.Add(Label1)
        Controls.Add(lblNetBalance)
        Controls.Add(lblTotalExpense1)
        Controls.Add(lblTotalExpense)
        Controls.Add(chartIncomeVsExpenses)
        Controls.Add(chartSpendingCategory)
        Name = "frmReports"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Reports & Trends"
        CType(chartSpendingCategory, ComponentModel.ISupportInitialize).EndInit()
        CType(chartIncomeVsExpenses, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents chartSpendingCategory As Charting.Chart
    Friend WithEvents chartIncomeVsExpenses As Charting.Chart
    Friend WithEvents lblTotalExpense As Label
    Friend WithEvents lblTotalExpense1 As Label
    Friend WithEvents lblNetBalance As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents btnExportToCSV As Button
End Class
