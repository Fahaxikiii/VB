<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(LoginForm))
        UsernameTextBox = New TextBox()
        PasswordTextBox = New TextBox()
        LoginButton = New Button()
        RegisterButton = New Button()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        UsernameTextBox.Font = New Font("楷体", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        UsernameTextBox.Location = New Point(243, 99)
        UsernameTextBox.MaximumSize = New Size(200, 30)
        UsernameTextBox.MinimumSize = New Size(200, 30)
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(200, 30)
        UsernameTextBox.TabIndex = 0
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        PasswordTextBox.Font = New Font("楷体", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        PasswordTextBox.Location = New Point(243, 150)
        PasswordTextBox.MaximumSize = New Size(200, 30)
        PasswordTextBox.MinimumSize = New Size(200, 30)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.PasswordChar = "*"c
        PasswordTextBox.Size = New Size(200, 30)
        PasswordTextBox.TabIndex = 1
        ' 
        ' LoginButton
        ' 
        LoginButton.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        LoginButton.Font = New Font("楷体", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        LoginButton.Location = New Point(189, 204)
        LoginButton.Name = "LoginButton"
        LoginButton.Size = New Size(94, 29)
        LoginButton.TabIndex = 2
        LoginButton.Text = "登录"
        LoginButton.UseVisualStyleBackColor = False
        ' 
        ' RegisterButton
        ' 
        RegisterButton.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        RegisterButton.Font = New Font("楷体", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        RegisterButton.Location = New Point(331, 204)
        RegisterButton.Name = "RegisterButton"
        RegisterButton.Size = New Size(94, 29)
        RegisterButton.TabIndex = 3
        RegisterButton.Text = "注册"
        RegisterButton.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("楷体", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(138, 99)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 28)
        Label1.TabIndex = 4
        Label1.Text = "用户名"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("楷体", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(167, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 28)
        Label2.TabIndex = 5
        Label2.Text = "密码"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.QQ图片20230328234856
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(662, 333)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(RegisterButton)
        Controls.Add(LoginButton)
        Controls.Add(PasswordTextBox)
        Controls.Add(UsernameTextBox)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximumSize = New Size(680, 380)
        MinimumSize = New Size(680, 380)
        Name = "LoginForm"
        Text = "登录"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents LoginButton As Button
    Friend WithEvents RegisterButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
