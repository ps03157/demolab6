<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KháchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CậpNhậtKHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XemKHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CậpNhậpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XemSPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LiênHệToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuayLạiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KháchToolStripMenuItem, Me.SảnPhẩmToolStripMenuItem, Me.LiênHệToolStripMenuItem, Me.QuayLạiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(702, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KháchToolStripMenuItem
        '
        Me.KháchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CậpNhậtKHToolStripMenuItem, Me.XemKHToolStripMenuItem})
        Me.KháchToolStripMenuItem.Name = "KháchToolStripMenuItem"
        Me.KháchToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.KháchToolStripMenuItem.Text = "Khách Hàng"
        '
        'CậpNhậtKHToolStripMenuItem
        '
        Me.CậpNhậtKHToolStripMenuItem.Name = "CậpNhậtKHToolStripMenuItem"
        Me.CậpNhậtKHToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.CậpNhậtKHToolStripMenuItem.Text = "Cập nhật KH"
        '
        'XemKHToolStripMenuItem
        '
        Me.XemKHToolStripMenuItem.Name = "XemKHToolStripMenuItem"
        Me.XemKHToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.XemKHToolStripMenuItem.Text = "Xem KH"
        '
        'SảnPhẩmToolStripMenuItem
        '
        Me.SảnPhẩmToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CậpNhậpToolStripMenuItem, Me.XemSPToolStripMenuItem})
        Me.SảnPhẩmToolStripMenuItem.Name = "SảnPhẩmToolStripMenuItem"
        Me.SảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.SảnPhẩmToolStripMenuItem.Text = "Sản Phẩm"
        '
        'CậpNhậpToolStripMenuItem
        '
        Me.CậpNhậpToolStripMenuItem.Name = "CậpNhậpToolStripMenuItem"
        Me.CậpNhậpToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.CậpNhậpToolStripMenuItem.Text = "Cập nhật SP"
        '
        'XemSPToolStripMenuItem
        '
        Me.XemSPToolStripMenuItem.Name = "XemSPToolStripMenuItem"
        Me.XemSPToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.XemSPToolStripMenuItem.Text = "Xem SP"
        '
        'LiênHệToolStripMenuItem
        '
        Me.LiênHệToolStripMenuItem.Name = "LiênHệToolStripMenuItem"
        Me.LiênHệToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.LiênHệToolStripMenuItem.Text = "Giới Thiệu"
        '
        'QuayLạiToolStripMenuItem
        '
        Me.QuayLạiToolStripMenuItem.Name = "QuayLạiToolStripMenuItem"
        Me.QuayLạiToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.QuayLạiToolStripMenuItem.Text = "Quay Lại"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 417)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "PS03157"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 433)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(231, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Bài làm thuộc bản quyền của Trần Nhật Quang"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.QuanLyBanHang_PS03157.My.Resources.Resources.Welcome_With_3D_Fonts
        Me.PictureBox2.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(702, 234)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 259)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(702, 149)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 449)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMain"
        Me.Text = "Main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KháchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SảnPhẩmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LiênHệToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CậpNhậtKHToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XemKHToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CậpNhậpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XemSPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents QuayLạiToolStripMenuItem As ToolStripMenuItem
End Class
