Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Collections.Generic
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Net.WebRequestMethods
Imports Microsoft.VisualBasic.ApplicationServices
Public Class RegistrationForm
    Private users As Dictionary(Of String, String)
    Private Sub RegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 计算窗口位置并将其设置为屏幕中心位置
        Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height
        Me.Location = New Point((screenWidth - Me.Width) \ 2, (screenHeight - Me.Height) \ 2)
    End Sub
    Public Sub New(users As Dictionary(Of String, String))
        InitializeComponent()
        Me.users = users
    End Sub
    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        ' 添加新用户
        If Not users.ContainsKey(UsernameTextBox.Text) Then
            users(UsernameTextBox.Text) = PasswordTextBox.Text
            MessageBox.Show("注册成功")
            Close()
        Else
            MessageBox.Show("用户名已存在")
        End If
    End Sub
    Private Sub LoginForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' 保存用户名和密码到本地文件
        Using writer As New StreamWriter("users.txt")
            For Each pair As KeyValuePair(Of String, String) In users
                writer.WriteLine($"{pair.Key},{pair.Value}")
            Next
        End Using
    End Sub
End Class


