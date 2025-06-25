<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotifyAlerts
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
        lblTitle = New Label()
        lblLimit = New Label()
        lblCategory = New Label()
        cmbCategory = New ComboBox()
        txtLimitAmount = New TextBox()
        btnSaveAlert = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(20, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(234, 30)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Set Alert for Spending"
        ' 
        ' lblLimit
        ' 
        lblLimit.AutoSize = True
        lblLimit.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLimit.Location = New Point(20, 144)
        lblLimit.Name = "lblLimit"
        lblLimit.Size = New Size(190, 30)
        lblLimit.TabIndex = 1
        lblLimit.Text = "Limit Amount ($):"
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCategory.Location = New Point(20, 80)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(108, 30)
        lblCategory.TabIndex = 2
        lblCategory.Text = "Category:"
        ' 
        ' cmbCategory
        ' 
        cmbCategory.FormattingEnabled = True
        cmbCategory.Items.AddRange(New Object() {"Food"", ""Transport"", ""Bills"", ""Shopping"", ""Other"})
        cmbCategory.Location = New Point(134, 89)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(121, 23)
        cmbCategory.TabIndex = 3
        ' 
        ' txtLimitAmount
        ' 
        txtLimitAmount.Location = New Point(216, 151)
        txtLimitAmount.Name = "txtLimitAmount"
        txtLimitAmount.Size = New Size(100, 23)
        txtLimitAmount.TabIndex = 4
        ' 
        ' btnSaveAlert
        ' 
        btnSaveAlert.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSaveAlert.Location = New Point(48, 217)
        btnSaveAlert.Name = "btnSaveAlert"
        btnSaveAlert.Size = New Size(162, 43)
        btnSaveAlert.TabIndex = 5
        btnSaveAlert.Text = "Set Alert"
        btnSaveAlert.UseVisualStyleBackColor = True
        ' 
        ' frmNotifyAlerts
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(343, 318)
        Controls.Add(btnSaveAlert)
        Controls.Add(txtLimitAmount)
        Controls.Add(cmbCategory)
        Controls.Add(lblCategory)
        Controls.Add(lblLimit)
        Controls.Add(lblTitle)
        Name = "frmNotifyAlerts"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Notify Alerts"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblLimit As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents txtLimitAmount As TextBox
    Friend WithEvents btnSaveAlert As Button
End Class
