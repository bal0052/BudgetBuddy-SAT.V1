<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetSavingGoal
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
        txtGoalName = New TextBox()
        txtTargetAmount = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        dtpTargetDate = New DateTimePicker()
        Label5 = New Label()
        cmbCategory = New ComboBox()
        btnSetGoal = New Button()
        btnClearGoal = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        Label1.Location = New Point(20, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(262, 32)
        Label1.TabIndex = 0
        Label1.Text = "Set Your Savings Goal"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        Label2.Location = New Point(35, 96)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 30)
        Label2.TabIndex = 1
        Label2.Text = "Goal Name:"
        ' 
        ' txtGoalName
        ' 
        txtGoalName.Location = New Point(169, 103)
        txtGoalName.Name = "txtGoalName"
        txtGoalName.Size = New Size(122, 23)
        txtGoalName.TabIndex = 2
        ' 
        ' txtTargetAmount
        ' 
        txtTargetAmount.Location = New Point(219, 162)
        txtTargetAmount.Name = "txtTargetAmount"
        txtTargetAmount.Size = New Size(122, 23)
        txtTargetAmount.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        Label3.Location = New Point(12, 155)
        Label3.Name = "Label3"
        Label3.Size = New Size(201, 30)
        Label3.TabIndex = 3
        Label3.Text = "Target Amount ($):"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        Label4.Location = New Point(20, 213)
        Label4.Name = "Label4"
        Label4.Size = New Size(131, 30)
        Label4.TabIndex = 5
        Label4.Text = "Target Date:"
        ' 
        ' dtpTargetDate
        ' 
        dtpTargetDate.Location = New Point(157, 220)
        dtpTargetDate.Name = "dtpTargetDate"
        dtpTargetDate.Size = New Size(200, 23)
        dtpTargetDate.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        Label5.Location = New Point(23, 276)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 30)
        Label5.TabIndex = 7
        Label5.Text = "Category:"
        ' 
        ' cmbCategory
        ' 
        cmbCategory.FormattingEnabled = True
        cmbCategory.Items.AddRange(New Object() {"Emergency Fund, Vacation, Education, Car, Other"})
        cmbCategory.Location = New Point(137, 283)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(186, 23)
        cmbCategory.TabIndex = 8
        ' 
        ' btnSetGoal
        ' 
        btnSetGoal.BackColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        btnSetGoal.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSetGoal.ForeColor = Color.White
        btnSetGoal.Location = New Point(160, 357)
        btnSetGoal.Name = "btnSetGoal"
        btnSetGoal.Size = New Size(197, 48)
        btnSetGoal.TabIndex = 9
        btnSetGoal.Text = "Set Goal"
        btnSetGoal.UseVisualStyleBackColor = False
        ' 
        ' btnClearGoal
        ' 
        btnClearGoal.BackColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        btnClearGoal.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClearGoal.ForeColor = Color.White
        btnClearGoal.Location = New Point(466, 357)
        btnClearGoal.Name = "btnClearGoal"
        btnClearGoal.Size = New Size(197, 48)
        btnClearGoal.TabIndex = 10
        btnClearGoal.Text = "Clear"
        btnClearGoal.UseVisualStyleBackColor = False
        ' 
        ' frmSetSavingGoal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnClearGoal)
        Controls.Add(btnSetGoal)
        Controls.Add(cmbCategory)
        Controls.Add(Label5)
        Controls.Add(dtpTargetDate)
        Controls.Add(Label4)
        Controls.Add(txtTargetAmount)
        Controls.Add(Label3)
        Controls.Add(txtGoalName)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmSetSavingGoal"
        Text = "Set Saving Goal"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGoalName As TextBox
    Friend WithEvents txtTargetAmount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpTargetDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents btnSetGoal As Button
    Friend WithEvents btnClearGoal As Button
End Class
