Imports System.IO

Public Class count
    Private Sub count_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 计算窗口位置并将其设置为屏幕中心位置
        Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height
        Me.Location = New Point((screenWidth - Me.Width) \ 2, (screenHeight - Me.Height) \ 2)
    End Sub
    Private Sub LoginForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' 判断关闭原因是否为用户单击关闭按钮
        If e.CloseReason = CloseReason.UserClosing Then
            ' 如果是，退出整个应用程序
            Application.Exit()
        End If
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then ' 如果按下的是回车键
            e.Handled = True ' 防止出现“叮咚”声
            Me.SelectNextControl(TextBox1, True, True, True, True) ' 跳转到下一个控件（即txtStressRange）
        End If
    End Sub
    Private Sub txtStressRange_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStressRange.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then ' 如果按下的是回车键
            '判断是否输入的是double类型
            Dim stressAmplitude As Double '应力幅值，单位MPa
            If Double.TryParse(Me.txtStressRange.Text, stressAmplitude) Then
                ' 转换成功，可以继续使用stressAmplitude变量
            Else
                ' 转换失败，提示用户输入正确的数字格式
                MessageBox.Show("请输入正确的应力幅值")
            End If
            e.Handled = True ' 防止出现“叮咚”声
            Me.SelectNextControl(txtStressRange, True, True, True, True) ' 跳转到下一个控件（即txtMeanStress）
        End If
    End Sub
    Private Sub txtMeanStress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMeanStress.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then ' 如果按下的是回车键
            Dim meanStress As Double '平均应力，单位MPa
            If Double.TryParse(Me.txtMeanStress.Text, meanStress) Then
                ' 转换成功，可以继续使用meanStress变量
            Else
                ' 转换失败，提示用户输入正确的数字格式
                MessageBox.Show("请输入正确的平均应力")
            End If
            e.Handled = True ' 防止出现“叮咚”声
            Me.SelectNextControl(txtMeanStress, True, True, True, True) ' 跳转到下一个控件（即txtCyclesToFailure）
        End If
    End Sub
    Private Sub txtCyclesToFailure_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCyclesToFailure.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then ' 如果按下的是回车键
            Dim cyclesToFailure As Double '失效循环数
            If Double.TryParse(Me.txtCyclesToFailure.Text, cyclesToFailure) Then
                ' 转换成功，可以继续使用cyclesToFailure变量
            Else
                ' 转换失败，提示用户输入正确的数字格式
                MessageBox.Show("请输入正确的失效循环数")
            End If
            e.Handled = True ' 防止出现“叮咚”声
            Me.SelectNextControl(txtCyclesToFailure, True, True, True, True) ' 跳转到下一个控件（即txtEnduranceLimit）
        End If
    End Sub
    Private Sub txtEnduranceLimit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEnduranceLimit.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then ' 如果按下的是回车键
            Dim enduranceLimit As Double '耐久极限，单位MPa
            If Double.TryParse(Me.txtEnduranceLimit.Text, enduranceLimit) Then
                ' 转换成功，可以继续使用enduranceLimit变量
            Else
                ' 转换失败，提示用户输入正确的数字格式
                MessageBox.Show("请输入正确的耐久极限")
            End If
            e.Handled = True ' 防止出现“叮咚”声
            Me.SelectNextControl(txtEnduranceLimit, True, True, True, True) ' 跳转到下一个控件（即TextBox2）
        End If
    End Sub
    Private Sub txtFatigueStrengthExponent_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFatigueStrengthExponent.KeyDown
        If e.KeyCode = Keys.Enter Then ' 如果按下的是回车键
            Dim fatigueStrengthIndex As Double  '疲劳强度指数
            If Double.TryParse(Me.txtFatigueStrengthExponent.Text, fatigueStrengthIndex) Then
                ' 转换成功，可以继续使用fatigueStrengthIndex变量
            Else
                ' 转换失败，提示用户输入正确的数字格式
                MessageBox.Show("请输入正确的疲劳强度指数")
            End If
            btnCalculate.PerformClick() ' 跳转到下一个控件（即btnCalculate）
        End If
    End Sub
    Private Sub btnCalculate_Click_1(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' 输入变量
        Dim stressAmplitude As Double = CDbl(txtStressRange.Text) ' 应力幅值，单位MPa
        Dim meanStress As Double = CDbl(txtMeanStress.Text) ' 平均应力，单位MPa
        Dim cyclesToFailure As Double = CDbl(txtCyclesToFailure.Text) ' 失效循环数
        ' 材料参数
        Dim enduranceLimit As Double = CDbl(txtEnduranceLimit.Text) ' 耐久极限，单位MPa
        Dim fatigueStrengthIndex As Double = CDbl(txtFatigueStrengthExponent.Text) ' 疲劳强度指数
        '计算疲劳寿命'
        Dim fatigueLife As Double = (enduranceLimit / stressAmplitude) ^ (1 / fatigueStrengthIndex) * cyclesToFailure ^ (1 / fatigueStrengthIndex) * (1 + meanStress / enduranceLimit) ^ (1 / fatigueStrengthIndex)
        '显示计算结果'
        txtFatigueLife.Text = fatigueLife.ToString()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '绘制疲劳寿命曲线'
        Dim stressAmplitude As Double = CDbl(txtStressRange.Text)
        Dim enduranceLimit As Double = CDbl(txtEnduranceLimit.Text)
        Dim fatigueStrengthIndex As Double = CDbl(txtFatigueStrengthExponent.Text)
        Dim xValues(100) As Double
        Dim yValues(100) As Double
        '计算数据点'
        For i As Integer = 0 To 100
            xValues(i) = (i + 1) * enduranceLimit / 100
            yValues(i) = (xValues(i) / stressAmplitude) ^ fatigueStrengthIndex
        Next
        Dim equationText As String = "y = (x / " & stressAmplitude.ToString() & ") ^ " & fatigueStrengthIndex.ToString()
        '创建新窗口'
        Dim graphForm As New Picture(xValues, yValues, equationText)
        ' 创建一个窗口并添加一个进度条和文字
        Dim progressForm As New Form()
        progressForm.Size = New Size(300, 60)
        progressForm.StartPosition = FormStartPosition.CenterScreen
        progressForm.FormBorderStyle = FormBorderStyle.FixedDialog
        progressForm.ControlBox = False
        Dim progressBar As New ProgressBar()
        progressBar.Dock = DockStyle.Bottom
        progressBar.Minimum = 0
        progressBar.Maximum = 100
        progressBar.Value = 0
        progressForm.Controls.Add(progressBar)
        Dim label As New Label()
        label.Text = "绘制中，请稍候..."
        label.Dock = DockStyle.Top
        label.TextAlign = ContentAlignment.MiddleCenter
        progressForm.Controls.Add(label)
        ' 创建一个计时器，并在其中计算疲劳寿命和更新进度条
        Dim timer As New Timer()
        timer.Interval = 10
        AddHandler timer.Tick, Sub()
                                   ' 更新进度条
                                   progressBar.Value += 1
                                   If progressBar.Value >= progressBar.Maximum Then
                                       ' 停止计时器，并关闭窗口
                                       timer.Stop()
                                       progressForm.Close()
                                       label.Text = "绘制成功！"
                                       ' 打开绘制图片的窗口
                                       graphForm.ShowDialog()
                                   End If
                               End Sub
        timer.Start()
        ' 显示进度条窗口，并等待用户关闭窗口
        progressForm.Show(Me)
        ' 绘图完成后关闭进度条窗口
    End Sub
    Private Sub 关于ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于ToolStripMenuItem.Click
        Dim about As New about
        about.ShowDialog()
    End Sub
    Private Sub 保存ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 保存ToolStripMenuItem.Click
        Dim name As String = TextBox1.Text
        Dim stressAmplitude As Double = CDbl(txtStressRange.Text)
        Dim meanStress As Double = CDbl(txtMeanStress.Text)
        Dim cyclesToFailure As Double = CDbl(txtCyclesToFailure.Text)
        Dim enduranceLimit As Double = CDbl(txtEnduranceLimit.Text)
        Dim fatigueStrengthIndex As Double = CDbl(txtFatigueStrengthExponent.Text)
        Dim fatigueLife As Double = (enduranceLimit / stressAmplitude) ^ (1 / fatigueStrengthIndex) * cyclesToFailure ^ (1 / fatigueStrengthIndex) * (1 + meanStress / enduranceLimit) ^ (1 / fatigueStrengthIndex)
        Dim xValues(100) As Double
        Dim yValues(100) As Double
        '计算数据点'
        For i As Integer = 0 To 100
            xValues(i) = (i + 1) * enduranceLimit / 100
            yValues(i) = (xValues(i) / stressAmplitude) ^ fatigueStrengthIndex
        Next
        Dim equationText As String = "y = (x / " & stressAmplitude.ToString() & ") ^ " & fatigueStrengthIndex.ToString()
        ' 打开文件对话框，让用户选择保存的文件
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "文本文件 (*.txt)|*.txt|所有文件 (*.*)|*.*"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            ' 打开文件流并创建 StreamWriter 对象
            Using fileStream As New FileStream(saveFileDialog.FileName, FileMode.Create)
                Using writer As New StreamWriter(fileStream)
                    ' 写入数据到文件中
                    writer.WriteLine("材料名称: " & name)
                    writer.WriteLine("应力幅值(MPa): " & stressAmplitude)
                    writer.WriteLine("平均应力(MPa): " & meanStress)
                    writer.WriteLine("失效循环数: " & cyclesToFailure)
                    writer.WriteLine("耐久极限(MPa): " & enduranceLimit)
                    writer.WriteLine("疲劳强度指数: " & fatigueStrengthIndex)
                    writer.WriteLine("疲劳寿命(循环): " & fatigueLife)
                    writer.WriteLine("疲劳寿命方程: " & equationText)
                End Using
            End Using
        End If
    End Sub
    Private Sub 退出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub 打开ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 打开ToolStripMenuItem.Click
        ' 打开文件对话框，让用户选择要打开的文件
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "文本文件 (*.txt)|*.txt|所有文件 (*.*)|*.*"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' 打开文件流并创建 StreamReader 对象
            Using fileStream As New FileStream(openFileDialog.FileName, FileMode.Open)
                Using reader As New StreamReader(fileStream)
                    ' 逐行读取文件中的数据，并将它们设置到输入框中
                    TextBox1.Text = reader.ReadLine().Split(":")(1).Trim()
                    txtStressRange.Text = reader.ReadLine().Split(":")(1).Trim()
                    txtMeanStress.Text = reader.ReadLine().Split(":")(1).Trim()
                    txtCyclesToFailure.Text = reader.ReadLine().Split(":")(1).Trim()
                    txtEnduranceLimit.Text = reader.ReadLine().Split(":")(1).Trim()
                    txtFatigueStrengthExponent.Text = reader.ReadLine().Split(":")(1).Trim()
                    txtFatigueLife.Text = reader.ReadLine().Split(":")(1).Trim()
                End Using
            End Using
        End If
    End Sub
End Class
