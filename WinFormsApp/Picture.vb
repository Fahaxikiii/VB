Public Class Picture
    Inherits Form
    Private xValues() As Double
    Private yValues() As Double
    Private equationText As String
    Private Sub Picture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 计算窗口位置并将其设置为屏幕中心位置
        Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height
        Me.Location = New Point((screenWidth - Me.Width) \ 2, (screenHeight - Me.Height) \ 2)
    End Sub
    Public Sub New(xValues() As Double, yValues() As Double, equationText As String)
        Me.xValues = xValues
        Me.yValues = yValues
        Me.ClientSize = New Size(600, 600)
        Me.Text = "疲劳寿命曲线"
        Me.equationText = equationText
    End Sub
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        '创建画布'
        Dim g As Graphics = e.Graphics
        Dim plotArea As New RectangleF(50, 50, Me.ClientSize.Width - 100, Me.ClientSize.Height - 100)
        '绘制坐标轴'
        Dim xAxis As New Pen(Color.Black, 2)
        Dim yAxis As New Pen(Color.Black, 2)
        g.DrawLine(xAxis, plotArea.Left, plotArea.Bottom, plotArea.Right, plotArea.Bottom)
        g.DrawLine(yAxis, plotArea.Left, plotArea.Bottom, plotArea.Left, plotArea.Top)
        ' 绘制坐标轴标签
        Dim font As Font = New Font("宋体", 10)
        g.DrawString("应力幅值/MPa", font, Brushes.Black, plotArea.Right - 80, plotArea.Bottom + 10)
        g.DrawString("失效循环数/N", font, Brushes.Black, plotArea.Left - 40, plotArea.Top - 20)
        g.DrawString("O", font, Brushes.Black, plotArea.Left - 13, plotArea.Bottom)
        '绘制数据点'
        Dim curvePen As New Pen(Color.Blue, 2)
        For i As Integer = 0 To 99
            Dim x1 As Single = plotArea.Left + (xValues(i) - xValues(0)) / (xValues(99) - xValues(0)) * plotArea.Width
            Dim y1 As Single = plotArea.Bottom - (yValues(i) - yValues(0)) / (yValues(99) - yValues(0)) * plotArea.Height
            Dim x2 As Single = plotArea.Left + (xValues(i + 1) - xValues(0)) / (xValues(99) - xValues(0)) * plotArea.Width
            Dim y2 As Single = plotArea.Bottom - (yValues(i + 1) - yValues(0)) / (yValues(99) - yValues(0)) * plotArea.Height
            g.DrawLine(curvePen, x1, y1, x2, y2)
        Next
        '显示曲线方程'
        Dim equationFont As New Font("Arial", 12)
        Dim equationBrush As New SolidBrush(Color.Black)
        Dim equationFormat As New StringFormat()
        equationFormat.Alignment = StringAlignment.Center
        g.DrawString(equationText, equationFont, equationBrush, plotArea.Left + plotArea.Width / 2, plotArea.Top + plotArea.Height + 10, equationFormat)
    End Sub
End Class

