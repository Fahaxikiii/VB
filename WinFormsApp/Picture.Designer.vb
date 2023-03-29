<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Picture
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Picture))
        PictureBox1 = New PictureBox()
        ToolTip1 = New ToolTip(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(88, 12)
        PictureBox1.MaximumSize = New Size(900, 600)
        PictureBox1.MinimumSize = New Size(900, 600)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(900, 600)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' ToolTip1
        ' 
        ToolTip1.AutoPopDelay = 0
        ToolTip1.InitialDelay = 0
        ToolTip1.ReshowDelay = 100
        ' 
        ' Picture
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1199, 682)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(920, 620)
        Name = "Picture"
        Text = "Picture"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
