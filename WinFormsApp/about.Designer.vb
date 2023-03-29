<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class about
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(about))
        PictureBox1 = New PictureBox()
        RichTextBox1 = New RichTextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.有雪_90x90
        PictureBox1.Location = New Point(37, 36)
        PictureBox1.MaximumSize = New Size(90, 90)
        PictureBox1.MinimumSize = New Size(90, 90)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(90, 90)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = SystemColors.ButtonFace
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("楷体", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        RichTextBox1.Location = New Point(161, 54)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ReadOnly = True
        RichTextBox1.Size = New Size(485, 237)
        RichTextBox1.TabIndex = 1
        RichTextBox1.Text = "本程序采用VB.NET编写，用于求解材料的疲劳寿命以及绘制相应的疲劳寿命曲线。"
        ' 
        ' about
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        ClientSize = New Size(702, 353)
        Controls.Add(RichTextBox1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximumSize = New Size(720, 400)
        MinimumSize = New Size(720, 400)
        Name = "about"
        Text = "关于"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
