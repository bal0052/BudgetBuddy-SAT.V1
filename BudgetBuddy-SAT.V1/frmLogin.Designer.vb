<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        TabControl1 = New TabControl()
        tabMain = New TabPage()
        CheckBox1 = New CheckBox()
        btnLogin = New Button()
        txtLoginPassword = New TextBox()
        Label3 = New Label()
        txtLoginEmail = New TextBox()
        Label2 = New Label()
        TabPage2 = New TabPage()
        btnRegister = New Button()
        txtRegPassword = New TextBox()
        Label6 = New Label()
        txtRegEmail = New TextBox()
        Label5 = New Label()
        txtRegName = New TextBox()
        Label4 = New Label()
        TabControl1.SuspendLayout()
        tabMain.SuspendLayout()
        TabPage2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        Label1.Location = New Point(89, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(192, 37)
        Label1.TabIndex = 0
        Label1.Text = "BudgetBuddy"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tabMain)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(89, 116)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(200, 277)
        TabControl1.TabIndex = 1
        ' 
        ' tabMain
        ' 
        tabMain.BackColor = Color.White
        tabMain.Controls.Add(CheckBox1)
        tabMain.Controls.Add(btnLogin)
        tabMain.Controls.Add(txtLoginPassword)
        tabMain.Controls.Add(Label3)
        tabMain.Controls.Add(txtLoginEmail)
        tabMain.Controls.Add(Label2)
        tabMain.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tabMain.ForeColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        tabMain.Location = New Point(4, 24)
        tabMain.Name = "tabMain"
        tabMain.Padding = New Padding(3)
        tabMain.Size = New Size(192, 249)
        tabMain.TabIndex = 0
        tabMain.Text = "Login"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(31, 158)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(140, 25)
        CheckBox1.TabIndex = 5
        CheckBox1.Text = "Remember Me"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.AutoSize = True
        btnLogin.Location = New Point(52, 189)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(97, 44)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtLoginPassword
        ' 
        txtLoginPassword.Location = New Point(20, 123)
        txtLoginPassword.Name = "txtLoginPassword"
        txtLoginPassword.Size = New Size(166, 29)
        txtLoginPassword.TabIndex = 3
        txtLoginPassword.UseSystemPasswordChar = True
        ' 
        ' Label3
        ' 
        Label3.Location = New Point(6, 88)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 32)
        Label3.TabIndex = 2
        Label3.Text = "Password:"
        ' 
        ' txtLoginEmail
        ' 
        txtLoginEmail.Location = New Point(20, 40)
        txtLoginEmail.Name = "txtLoginEmail"
        txtLoginEmail.Size = New Size(166, 29)
        txtLoginEmail.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(6, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 27)
        Label2.TabIndex = 0
        Label2.Text = "Email:"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(btnRegister)
        TabPage2.Controls.Add(txtRegPassword)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(txtRegEmail)
        TabPage2.Controls.Add(Label5)
        TabPage2.Controls.Add(txtRegName)
        TabPage2.Controls.Add(Label4)
        TabPage2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TabPage2.ForeColor = Color.FromArgb(CByte(93), CByte(111), CByte(204))
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(192, 249)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Register"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' btnRegister
        ' 
        btnRegister.Location = New Point(51, 199)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(98, 44)
        btnRegister.TabIndex = 6
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' txtRegPassword
        ' 
        txtRegPassword.Location = New Point(27, 164)
        txtRegPassword.Name = "txtRegPassword"
        txtRegPassword.Size = New Size(159, 29)
        txtRegPassword.TabIndex = 5
        txtRegPassword.UseSystemPasswordChar = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(15, 140)
        Label6.Name = "Label6"
        Label6.Size = New Size(82, 21)
        Label6.TabIndex = 4
        Label6.Text = "Password"
        ' 
        ' txtRegEmail
        ' 
        txtRegEmail.Location = New Point(27, 97)
        txtRegEmail.Name = "txtRegEmail"
        txtRegEmail.Size = New Size(159, 29)
        txtRegEmail.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(15, 73)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 21)
        Label5.TabIndex = 2
        Label5.Text = "Email:"
        ' 
        ' txtRegName
        ' 
        txtRegName.Location = New Point(27, 41)
        txtRegName.Name = "txtRegName"
        txtRegName.Size = New Size(159, 29)
        txtRegName.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.Location = New Point(15, 15)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 23)
        Label4.TabIndex = 0
        Label4.Text = "Name:"
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(384, 461)
        Controls.Add(TabControl1)
        Controls.Add(Label1)
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmLogin"
        TabControl1.ResumeLayout(False)
        tabMain.ResumeLayout(False)
        tabMain.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabMain As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtLoginPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLoginEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txtRegName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRegPassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRegEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnRegister As Button
End Class
