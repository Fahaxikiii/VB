<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class count
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(count))
        btnCalculate = New Button()
        StressRangetxt = New Label()
        txtStressRange = New TextBox()
        MeanStresstxt = New Label()
        txtMeanStress = New TextBox()
        txtCyclesToFailure = New TextBox()
        txtEnduranceLimit = New TextBox()
        txtFatigueStrengthExponent = New TextBox()
        CyclesToFailuretxt = New Label()
        EnduranceLimittxt = New Label()
        FatigueStrengthExponenttxt = New Label()
        Label1 = New Label()
        txtFatigueLife = New TextBox()
        Button2 = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        MenuStrip1 = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        打开ToolStripMenuItem = New ToolStripMenuItem()
        保存ToolStripMenuItem = New ToolStripMenuItem()
        退出ToolStripMenuItem = New ToolStripMenuItem()
        帮助ToolStripMenuItem = New ToolStripMenuItem()
        关于ToolStripMenuItem = New ToolStripMenuItem()
        Label7 = New Label()
        TextBox1 = New TextBox()
        RichTextBox1 = New RichTextBox()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Anchor = AnchorStyles.None
        btnCalculate.BackColor = Color.Cyan
        btnCalculate.Font = New Font("宋体", 15F, FontStyle.Bold, GraphicsUnit.Point)
        btnCalculate.Location = New Point(511, 437)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(94, 29)
        btnCalculate.TabIndex = 6
        btnCalculate.Text = "计算"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' StressRangetxt
        ' 
        StressRangetxt.Anchor = AnchorStyles.None
        StressRangetxt.AutoSize = True
        StressRangetxt.BackColor = Color.Cyan
        StressRangetxt.Font = New Font("宋体", 15F, FontStyle.Bold, GraphicsUnit.Point)
        StressRangetxt.Location = New Point(489, 170)
        StressRangetxt.Name = "StressRangetxt"
        StressRangetxt.Size = New Size(116, 25)
        StressRangetxt.TabIndex = 1
        StressRangetxt.Text = "应力幅值"
        ' 
        ' txtStressRange
        ' 
        txtStressRange.Anchor = AnchorStyles.None
        txtStressRange.BackColor = Color.Cyan
        txtStressRange.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtStressRange.ImeMode = ImeMode.Off
        txtStressRange.Location = New Point(616, 167)
        txtStressRange.Name = "txtStressRange"
        txtStressRange.PlaceholderText = "请输入"
        txtStressRange.Size = New Size(125, 30)
        txtStressRange.TabIndex = 1
        ' 
        ' MeanStresstxt
        ' 
        MeanStresstxt.Anchor = AnchorStyles.None
        MeanStresstxt.AutoSize = True
        MeanStresstxt.BackColor = Color.Cyan
        MeanStresstxt.Font = New Font("宋体", 15F, FontStyle.Bold, GraphicsUnit.Point)
        MeanStresstxt.Location = New Point(489, 220)
        MeanStresstxt.Name = "MeanStresstxt"
        MeanStresstxt.Size = New Size(116, 25)
        MeanStresstxt.TabIndex = 3
        MeanStresstxt.Text = "平均应力"
        ' 
        ' txtMeanStress
        ' 
        txtMeanStress.Anchor = AnchorStyles.None
        txtMeanStress.BackColor = Color.Cyan
        txtMeanStress.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtMeanStress.Location = New Point(616, 217)
        txtMeanStress.Name = "txtMeanStress"
        txtMeanStress.PlaceholderText = "请输入"
        txtMeanStress.Size = New Size(125, 30)
        txtMeanStress.TabIndex = 2
        ' 
        ' txtCyclesToFailure
        ' 
        txtCyclesToFailure.Anchor = AnchorStyles.None
        txtCyclesToFailure.BackColor = Color.Cyan
        txtCyclesToFailure.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtCyclesToFailure.Location = New Point(616, 267)
        txtCyclesToFailure.Name = "txtCyclesToFailure"
        txtCyclesToFailure.PlaceholderText = "请输入"
        txtCyclesToFailure.Size = New Size(125, 30)
        txtCyclesToFailure.TabIndex = 3
        ' 
        ' txtEnduranceLimit
        ' 
        txtEnduranceLimit.Anchor = AnchorStyles.None
        txtEnduranceLimit.BackColor = Color.Cyan
        txtEnduranceLimit.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtEnduranceLimit.Location = New Point(616, 317)
        txtEnduranceLimit.Name = "txtEnduranceLimit"
        txtEnduranceLimit.PlaceholderText = "请输入"
        txtEnduranceLimit.Size = New Size(125, 30)
        txtEnduranceLimit.TabIndex = 4
        ' 
        ' txtFatigueStrengthExponent
        ' 
        txtFatigueStrengthExponent.Anchor = AnchorStyles.None
        txtFatigueStrengthExponent.BackColor = Color.Cyan
        txtFatigueStrengthExponent.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtFatigueStrengthExponent.Location = New Point(616, 367)
        txtFatigueStrengthExponent.Name = "txtFatigueStrengthExponent"
        txtFatigueStrengthExponent.PlaceholderText = "请输入"
        txtFatigueStrengthExponent.Size = New Size(125, 30)
        txtFatigueStrengthExponent.TabIndex = 5
        ' 
        ' CyclesToFailuretxt
        ' 
        CyclesToFailuretxt.Anchor = AnchorStyles.None
        CyclesToFailuretxt.AutoSize = True
        CyclesToFailuretxt.BackColor = Color.Cyan
        CyclesToFailuretxt.Font = New Font("宋体", 15F, FontStyle.Bold, GraphicsUnit.Point)
        CyclesToFailuretxt.Location = New Point(463, 270)
        CyclesToFailuretxt.Name = "CyclesToFailuretxt"
        CyclesToFailuretxt.Size = New Size(142, 25)
        CyclesToFailuretxt.TabIndex = 8
        CyclesToFailuretxt.Text = "失效循环数"
        ' 
        ' EnduranceLimittxt
        ' 
        EnduranceLimittxt.Anchor = AnchorStyles.None
        EnduranceLimittxt.AutoSize = True
        EnduranceLimittxt.BackColor = Color.Cyan
        EnduranceLimittxt.Font = New Font("宋体", 15F, FontStyle.Bold, GraphicsUnit.Point)
        EnduranceLimittxt.Location = New Point(489, 320)
        EnduranceLimittxt.Name = "EnduranceLimittxt"
        EnduranceLimittxt.Size = New Size(116, 25)
        EnduranceLimittxt.TabIndex = 9
        EnduranceLimittxt.Text = "耐久极限"
        ' 
        ' FatigueStrengthExponenttxt
        ' 
        FatigueStrengthExponenttxt.Anchor = AnchorStyles.None
        FatigueStrengthExponenttxt.AutoSize = True
        FatigueStrengthExponenttxt.BackColor = Color.Cyan
        FatigueStrengthExponenttxt.Font = New Font("宋体", 15F, FontStyle.Bold, GraphicsUnit.Point)
        FatigueStrengthExponenttxt.Location = New Point(437, 370)
        FatigueStrengthExponenttxt.Name = "FatigueStrengthExponenttxt"
        FatigueStrengthExponenttxt.Size = New Size(168, 25)
        FatigueStrengthExponenttxt.TabIndex = 10
        FatigueStrengthExponenttxt.Text = "疲劳强度指数"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.BackColor = Color.Cyan
        Label1.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(759, 170)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 25)
        Label1.TabIndex = 11
        Label1.Text = "MPa"
        ' 
        ' txtFatigueLife
        ' 
        txtFatigueLife.Anchor = AnchorStyles.None
        txtFatigueLife.BackColor = Color.Cyan
        txtFatigueLife.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtFatigueLife.ImeMode = ImeMode.NoControl
        txtFatigueLife.Location = New Point(616, 504)
        txtFatigueLife.Name = "txtFatigueLife"
        txtFatigueLife.PlaceholderText = "结果"
        txtFatigueLife.ReadOnly = True
        txtFatigueLife.Size = New Size(286, 30)
        txtFatigueLife.TabIndex = 12
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.None
        Button2.BackColor = Color.Cyan
        Button2.Font = New Font("宋体", 15F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(727, 437)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 7
        Button2.Text = "绘图"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.BackColor = Color.Cyan
        Label3.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(759, 220)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 25)
        Label3.TabIndex = 15
        Label3.Text = "MPa"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.BackColor = Color.Cyan
        Label4.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(759, 320)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 25)
        Label4.TabIndex = 16
        Label4.Text = "MPa"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.BackColor = Color.Cyan
        Label5.Font = New Font("宋体", 15F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(489, 507)
        Label5.Name = "Label5"
        Label5.Size = New Size(116, 25)
        Label5.TabIndex = 17
        Label5.Text = "疲劳寿命"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.BackColor = Color.Cyan
        Label6.Font = New Font("宋体", 15F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(922, 507)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 25)
        Label6.TabIndex = 18
        Label6.Text = "循环"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, 帮助ToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1062, 28)
        MenuStrip1.TabIndex = 20
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {打开ToolStripMenuItem, 保存ToolStripMenuItem, 退出ToolStripMenuItem})
        ToolStripMenuItem1.Image = My.Resources.Resources.菜单
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(73, 24)
        ToolStripMenuItem1.Text = "菜单"
        ' 
        ' 打开ToolStripMenuItem
        ' 
        打开ToolStripMenuItem.Image = My.Resources.Resources.打开
        打开ToolStripMenuItem.Name = "打开ToolStripMenuItem"
        打开ToolStripMenuItem.Size = New Size(122, 26)
        打开ToolStripMenuItem.Text = "打开"
        ' 
        ' 保存ToolStripMenuItem
        ' 
        保存ToolStripMenuItem.Image = My.Resources.Resources.保存
        保存ToolStripMenuItem.Name = "保存ToolStripMenuItem"
        保存ToolStripMenuItem.Size = New Size(122, 26)
        保存ToolStripMenuItem.Text = "保存"
        ' 
        ' 退出ToolStripMenuItem
        ' 
        退出ToolStripMenuItem.Image = My.Resources.Resources.退出
        退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        退出ToolStripMenuItem.Size = New Size(122, 26)
        退出ToolStripMenuItem.Text = "退出"
        ' 
        ' 帮助ToolStripMenuItem
        ' 
        帮助ToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {关于ToolStripMenuItem})
        帮助ToolStripMenuItem.Image = My.Resources.Resources.帮助
        帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem"
        帮助ToolStripMenuItem.Size = New Size(73, 24)
        帮助ToolStripMenuItem.Text = "帮助"
        ' 
        ' 关于ToolStripMenuItem
        ' 
        关于ToolStripMenuItem.Image = My.Resources.Resources.关于我们
        关于ToolStripMenuItem.Name = "关于ToolStripMenuItem"
        关于ToolStripMenuItem.Size = New Size(122, 26)
        关于ToolStripMenuItem.Text = "关于"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.BackColor = Color.Cyan
        Label7.Font = New Font("宋体", 15F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(541, 120)
        Label7.Name = "Label7"
        Label7.Size = New Size(64, 25)
        Label7.TabIndex = 21
        Label7.Text = "材料"
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.None
        TextBox1.BackColor = Color.Cyan
        TextBox1.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(616, 117)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "请输入"
        TextBox1.Size = New Size(125, 30)
        TextBox1.TabIndex = 0
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Anchor = AnchorStyles.None
        RichTextBox1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        RichTextBox1.BorderStyle = BorderStyle.FixedSingle
        RichTextBox1.Font = New Font("楷体", 12F, FontStyle.Bold, GraphicsUnit.Point)
        RichTextBox1.Location = New Point(83, 120)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ReadOnly = True
        RichTextBox1.Size = New Size(318, 414)
        RichTextBox1.TabIndex = 22
        RichTextBox1.Text = vbLf & "    应力幅值、平均应力和失效循环数是计算疲劳寿命和绘制疲劳寿命曲线的必要参数，而耐久极限和疲劳强度指数是材料的力学性质参数，需要提前获得。" & vbLf & vbLf & "    程序中，根据输入的应力幅值和平均应力，以及材料的耐久极限和疲劳强度指数，可以计算出材料的疲劳寿命，并将计算结果显示在程序界面上。同时，程序还会绘制疲劳寿命曲线，以便更直观地观察材料的疲劳行为。"
        ' 
        ' count
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        BackgroundImage = My.Resources.Resources.E82A1FBD61F2D0F632C33C365605DA7F
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1062, 673)
        Controls.Add(RichTextBox1)
        Controls.Add(TextBox1)
        Controls.Add(Label7)
        Controls.Add(MenuStrip1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Button2)
        Controls.Add(txtStressRange)
        Controls.Add(txtMeanStress)
        Controls.Add(txtCyclesToFailure)
        Controls.Add(txtEnduranceLimit)
        Controls.Add(txtFatigueStrengthExponent)
        Controls.Add(btnCalculate)
        Controls.Add(txtFatigueLife)
        Controls.Add(Label1)
        Controls.Add(FatigueStrengthExponenttxt)
        Controls.Add(EnduranceLimittxt)
        Controls.Add(CyclesToFailuretxt)
        Controls.Add(MeanStresstxt)
        Controls.Add(StressRangetxt)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        ImeMode = ImeMode.On
        MainMenuStrip = MenuStrip1
        MaximumSize = New Size(1080, 720)
        MinimumSize = New Size(1080, 720)
        Name = "count"
        Text = "材料的疲劳寿命及其曲线"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents StressRangetxt As Label
    Friend WithEvents MeanStresstxt As Label
    Friend WithEvents txtMeanStress As TextBox
    Friend WithEvents txtCyclesToFailure As TextBox
    Friend WithEvents txtEnduranceLimit As TextBox
    Friend WithEvents txtFatigueStrengthExponent As TextBox
    Friend WithEvents CyclesToFailuretxt As Label
    Friend WithEvents EnduranceLimittxt As Label
    Friend WithEvents FatigueStrengthExponenttxt As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFatigueLife As TextBox
    Friend WithEvents txtStressRange As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 打开ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 保存ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 帮助ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 关于ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
