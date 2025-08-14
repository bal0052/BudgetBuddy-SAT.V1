<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchTransactions
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
        Label1 = New Label()
        Label2 = New Label()
        txtSearchDescription = New TextBox()
        Label3 = New Label()
        dtpFromDate = New DateTimePicker()
        Label4 = New Label()
        dtpToDate = New DateTimePicker()
        Label5 = New Label()
        cmbTypeFilter = New ComboBox()
        cmbCategoryFilter = New ComboBox()
        Label6 = New Label()
        btnSearch = New Button()
        dgvResults = New DataGridView()
        Description = New DataGridViewTextBoxColumn()
        Amount = New DataGridViewTextBoxColumn()
        Type = New DataGridViewTextBoxColumn()
        Time = New DataGridViewTextBoxColumn()
        Category = New DataGridViewTextBoxColumn()
        btnBackToDash = New Button()
        CType(dgvResults, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        Label1.Location = New Point(20, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(239, 32)
        Label1.TabIndex = 0
        Label1.Text = "Search Transactions"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        Label2.Location = New Point(20, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 30)
        Label2.TabIndex = 1
        Label2.Text = "Description:"
        ' 
        ' txtSearchDescription
        ' 
        txtSearchDescription.Location = New Point(147, 77)
        txtSearchDescription.Name = "txtSearchDescription"
        txtSearchDescription.Size = New Size(146, 23)
        txtSearchDescription.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        Label3.Location = New Point(20, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 30)
        Label3.TabIndex = 3
        Label3.Text = "From:"
        ' 
        ' dtpFromDate
        ' 
        dtpFromDate.Location = New Point(96, 117)
        dtpFromDate.Name = "dtpFromDate"
        dtpFromDate.Size = New Size(200, 23)
        dtpFromDate.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        Label4.Location = New Point(20, 150)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 30)
        Label4.TabIndex = 5
        Label4.Text = "To:"
        ' 
        ' dtpToDate
        ' 
        dtpToDate.Location = New Point(68, 157)
        dtpToDate.Name = "dtpToDate"
        dtpToDate.Size = New Size(200, 23)
        dtpToDate.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        Label5.Location = New Point(20, 190)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 30)
        Label5.TabIndex = 7
        Label5.Text = "Type:"
        ' 
        ' cmbTypeFilter
        ' 
        cmbTypeFilter.FormattingEnabled = True
        cmbTypeFilter.Items.AddRange(New Object() {"Income", "Expense"})
        cmbTypeFilter.Location = New Point(81, 197)
        cmbTypeFilter.Name = "cmbTypeFilter"
        cmbTypeFilter.Size = New Size(168, 23)
        cmbTypeFilter.TabIndex = 8
        ' 
        ' cmbCategoryFilter
        ' 
        cmbCategoryFilter.FormattingEnabled = True
        cmbCategoryFilter.Items.AddRange(New Object() {"All", "Salary", "Food", "Transport", "Shopping", "Bills", "Other"})
        cmbCategoryFilter.Location = New Point(128, 237)
        cmbCategoryFilter.Name = "cmbCategoryFilter"
        cmbCategoryFilter.Size = New Size(168, 23)
        cmbCategoryFilter.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        Label6.Location = New Point(20, 230)
        Label6.Name = "Label6"
        Label6.Size = New Size(108, 30)
        Label6.TabIndex = 9
        Label6.Text = "Category:"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(68, 282)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(200, 60)
        btnSearch.TabIndex = 11
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' dgvResults
        ' 
        dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvResults.Columns.AddRange(New DataGridViewColumn() {Description, Amount, Type, Time, Category})
        dgvResults.Location = New Point(68, 377)
        dgvResults.Name = "dgvResults"
        dgvResults.Size = New Size(547, 61)
        dgvResults.TabIndex = 12
        ' 
        ' Description
        ' 
        Description.HeaderText = "Description"
        Description.Name = "Description"
        ' 
        ' Amount
        ' 
        Amount.HeaderText = "Amount"
        Amount.Name = "Amount"
        ' 
        ' Type
        ' 
        Type.HeaderText = "Type"
        Type.Name = "Type"
        ' 
        ' Time
        ' 
        Time.HeaderText = "Time"
        Time.Name = "Time"
        ' 
        ' Category
        ' 
        Category.HeaderText = "Category"
        Category.Name = "Category"
        ' 
        ' btnBackToDash
        ' 
        btnBackToDash.BackColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        btnBackToDash.FlatStyle = FlatStyle.Flat
        btnBackToDash.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBackToDash.ForeColor = Color.White
        btnBackToDash.Location = New Point(549, 12)
        btnBackToDash.Name = "btnBackToDash"
        btnBackToDash.Size = New Size(239, 75)
        btnBackToDash.TabIndex = 13
        btnBackToDash.Text = "Back to Dashboard"
        btnBackToDash.UseVisualStyleBackColor = False
        ' 
        ' frmSearchTransactions
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnBackToDash)
        Controls.Add(dgvResults)
        Controls.Add(btnSearch)
        Controls.Add(cmbCategoryFilter)
        Controls.Add(Label6)
        Controls.Add(cmbTypeFilter)
        Controls.Add(Label5)
        Controls.Add(dtpToDate)
        Controls.Add(Label4)
        Controls.Add(dtpFromDate)
        Controls.Add(Label3)
        Controls.Add(txtSearchDescription)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmSearchTransactions"
        CType(dgvResults, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearchDescription As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpFromDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpToDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbTypeFilter As ComboBox
    Friend WithEvents cmbCategoryFilter As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgvResults As DataGridView
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents Time As DataGridViewTextBoxColumn
    Friend WithEvents Category As DataGridViewTextBoxColumn
    Friend WithEvents btnBackToDash As Button
End Class
