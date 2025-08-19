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
        Label7 = New Label()
        CType(dgvResults, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        Label1.Location = New Point(37, 43)
        Label1.Margin = New Padding(6, 0, 6, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(471, 65)
        Label1.TabIndex = 0
        Label1.Text = "Search Transactions"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        Label2.Location = New Point(37, 149)
        Label2.Margin = New Padding(6, 0, 6, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(262, 57)
        Label2.TabIndex = 1
        Label2.Text = "Description:"
        ' 
        ' txtSearchDescription
        ' 
        txtSearchDescription.Location = New Point(297, 166)
        txtSearchDescription.Margin = New Padding(6, 6, 6, 6)
        txtSearchDescription.Name = "txtSearchDescription"
        txtSearchDescription.Size = New Size(268, 39)
        txtSearchDescription.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        Label3.Location = New Point(37, 235)
        Label3.Margin = New Padding(6, 0, 6, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(139, 57)
        Label3.TabIndex = 3
        Label3.Text = "From:"
        ' 
        ' dtpFromDate
        ' 
        dtpFromDate.Location = New Point(178, 250)
        dtpFromDate.Margin = New Padding(6, 6, 6, 6)
        dtpFromDate.Name = "dtpFromDate"
        dtpFromDate.Size = New Size(368, 39)
        dtpFromDate.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        Label4.Location = New Point(37, 320)
        Label4.Margin = New Padding(6, 0, 6, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 57)
        Label4.TabIndex = 5
        Label4.Text = "To:"
        ' 
        ' dtpToDate
        ' 
        dtpToDate.Location = New Point(126, 335)
        dtpToDate.Margin = New Padding(6, 6, 6, 6)
        dtpToDate.Name = "dtpToDate"
        dtpToDate.Size = New Size(368, 39)
        dtpToDate.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        Label5.Location = New Point(37, 405)
        Label5.Margin = New Padding(6, 0, 6, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(131, 57)
        Label5.TabIndex = 7
        Label5.Text = "Type:"
        ' 
        ' cmbTypeFilter
        ' 
        cmbTypeFilter.FormattingEnabled = True
        cmbTypeFilter.Items.AddRange(New Object() {"Income", "Expense"})
        cmbTypeFilter.Location = New Point(167, 422)
        cmbTypeFilter.Margin = New Padding(6, 6, 6, 6)
        cmbTypeFilter.Name = "cmbTypeFilter"
        cmbTypeFilter.Size = New Size(309, 40)
        cmbTypeFilter.TabIndex = 8
        ' 
        ' cmbCategoryFilter
        ' 
        cmbCategoryFilter.FormattingEnabled = True
        cmbCategoryFilter.Items.AddRange(New Object() {"All", "Salary", "Food", "Transport", "Shopping", "Bills", "Other"})
        cmbCategoryFilter.Location = New Point(256, 508)
        cmbCategoryFilter.Margin = New Padding(6, 6, 6, 6)
        cmbCategoryFilter.Name = "cmbCategoryFilter"
        cmbCategoryFilter.Size = New Size(309, 40)
        cmbCategoryFilter.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        Label6.Location = New Point(37, 491)
        Label6.Margin = New Padding(6, 0, 6, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(218, 57)
        Label6.TabIndex = 9
        Label6.Text = "Category:"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(126, 602)
        btnSearch.Margin = New Padding(6, 6, 6, 6)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(371, 128)
        btnSearch.TabIndex = 11
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' dgvResults
        ' 
        dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvResults.Columns.AddRange(New DataGridViewColumn() {Description, Amount, Type, Time, Category})
        dgvResults.Location = New Point(379, 804)
        dgvResults.Margin = New Padding(6, 6, 6, 6)
        dgvResults.Name = "dgvResults"
        dgvResults.RowHeadersWidth = 82
        dgvResults.Size = New Size(1016, 130)
        dgvResults.TabIndex = 12
        ' 
        ' Description
        ' 
        Description.HeaderText = "Description"
        Description.MinimumWidth = 10
        Description.Name = "Description"
        Description.Width = 200
        ' 
        ' Amount
        ' 
        Amount.HeaderText = "Amount"
        Amount.MinimumWidth = 10
        Amount.Name = "Amount"
        Amount.Width = 200
        ' 
        ' Type
        ' 
        Type.HeaderText = "Type"
        Type.MinimumWidth = 10
        Type.Name = "Type"
        Type.Width = 200
        ' 
        ' Time
        ' 
        Time.HeaderText = "Time"
        Time.MinimumWidth = 10
        Time.Name = "Time"
        Time.Width = 200
        ' 
        ' Category
        ' 
        Category.HeaderText = "Category"
        Category.MinimumWidth = 10
        Category.Name = "Category"
        Category.Width = 200
        ' 
        ' btnBackToDash
        ' 
        btnBackToDash.BackColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        btnBackToDash.FlatStyle = FlatStyle.Flat
        btnBackToDash.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBackToDash.ForeColor = Color.White
        btnBackToDash.Location = New Point(1020, 26)
        btnBackToDash.Margin = New Padding(6, 6, 6, 6)
        btnBackToDash.Name = "btnBackToDash"
        btnBackToDash.Size = New Size(444, 160)
        btnBackToDash.TabIndex = 13
        btnBackToDash.Text = "Back to Dashboard"
        btnBackToDash.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        Label7.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(802, 715)
        Label7.Margin = New Padding(6, 0, 6, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(150, 51)
        Label7.TabIndex = 14
        Label7.Text = "Results"
        ' 
        ' frmSearchTransactions
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1486, 960)
        Controls.Add(Label7)
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
        Margin = New Padding(6, 6, 6, 6)
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
    Friend WithEvents Label7 As Label
End Class
