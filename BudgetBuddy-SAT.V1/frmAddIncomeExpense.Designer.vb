<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddIncomeExpense
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
        cmbType = New ComboBox()
        Label3 = New Label()
        txtAmount = New TextBox()
        txtDescription = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        dtpDate = New DateTimePicker()
        Label6 = New Label()
        cmbCategory = New ComboBox()
        btnSave = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        Label1.Location = New Point(20, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(296, 32)
        Label1.TabIndex = 0
        Label1.Text = "Add Income or Expenses"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        Label2.Location = New Point(20, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 30)
        Label2.TabIndex = 1
        Label2.Text = "Type:"
        ' 
        ' cmbType
        ' 
        cmbType.FormattingEnabled = True
        cmbType.Items.AddRange(New Object() {"Income, Expense"})
        cmbType.Location = New Point(101, 79)
        cmbType.Name = "cmbType"
        cmbType.Size = New Size(121, 23)
        cmbType.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        Label3.Location = New Point(20, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(134, 30)
        Label3.TabIndex = 3
        Label3.Text = "Amount ($):"
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(153, 119)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(163, 23)
        txtAmount.TabIndex = 4
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(153, 162)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(200, 60)
        txtDescription.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        Label4.Location = New Point(20, 153)
        Label4.Name = "Label4"
        Label4.Size = New Size(131, 30)
        Label4.TabIndex = 6
        Label4.Text = "Description:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        Label5.Location = New Point(20, 230)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 30)
        Label5.TabIndex = 7
        Label5.Text = "Date:"
        ' 
        ' dtpDate
        ' 
        dtpDate.Location = New Point(90, 237)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(200, 23)
        dtpDate.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        Label6.Location = New Point(20, 270)
        Label6.Name = "Label6"
        Label6.Size = New Size(108, 30)
        Label6.TabIndex = 9
        Label6.Text = "Category:"
        ' 
        ' cmbCategory
        ' 
        cmbCategory.FormattingEnabled = True
        cmbCategory.Items.AddRange(New Object() {"Salary, Food, Transport, Shopping, Bills, Other"})
        cmbCategory.Location = New Point(134, 279)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(161, 23)
        cmbCategory.TabIndex = 10
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.White
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        btnSave.Location = New Point(134, 344)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(271, 71)
        btnSave.TabIndex = 11
        btnSave.Text = "Add Transaction"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' frmAddIncomeExpense
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnSave)
        Controls.Add(cmbCategory)
        Controls.Add(Label6)
        Controls.Add(dtpDate)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtDescription)
        Controls.Add(txtAmount)
        Controls.Add(Label3)
        Controls.Add(cmbType)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmAddIncomeExpense"
        Text = "Add Expenses & Income"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents btnSave As Button
End Class
