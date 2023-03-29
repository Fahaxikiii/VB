Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class LoginForm
    Private users As New Dictionary(Of String, String)
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 计算窗口位置并将其设置为屏幕中心位置
        Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height
        Me.Location = New Point((screenWidth - Me.Width) \ 2, (screenHeight - Me.Height) \ 2)
        ' 读取已保存的用户名和密码
        If File.Exists("users.txt") Then
            For Each line As String In File.ReadLines("users.txt")
                Dim parts() As String = line.Split(",")
                users(parts(0)) = parts(1)
            Next
        End If
    End Sub
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        ' 检查用户名和密码是否正确
        Dim countmain As New count
        If users.ContainsKey(UsernameTextBox.Text) AndAlso users(UsernameTextBox.Text) = PasswordTextBox.Text Then
            MessageBox.Show("登录成功,欢迎回来！")
            countmain.Show()
            Me.Hide()
        Else
            MessageBox.Show("用户名或密码错误")
        End If
    End Sub
    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        ' 点击注册跳转到注册界面
        Dim registerForm As New RegistrationForm(users)
        registerForm.ShowDialog()
    End Sub


    Private Sub UsernameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UsernameTextBox.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then ' 如果按下的是回车键
            e.Handled = True ' 防止出现“叮咚”声
            Me.SelectNextControl(UsernameTextBox, True, True, True, True) ' 跳转到下一个控件（即TextBox2）
        End If
    End Sub

    Private Sub PasswordTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles PasswordTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoginButton.PerformClick()
        End If
    End Sub

    '    Private Sub LoginForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    '' 判断关闭原因是否为用户单击关闭按钮
    '   If e.CloseReason = CloseReason.UserClosing Then
    '            ' 如果是，退出整个应用程序
    '            Application.Exit()
    '    End If
    '   End Sub

End Class


