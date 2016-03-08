<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCapNhatSP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCapNhatSP))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dgvSP = New System.Windows.Forms.DataGridView()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.txtHangSX = New System.Windows.Forms.TextBox()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNgaySX = New System.Windows.Forms.TextBox()
        Me.btnXoa = New System.Windows.Forms.Button()
        CType(Me.dgvSP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackgroundImage = Global.QuanLyBanHang_PS03157.My.Resources.Resources.wrong_295503_960_720
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.Location = New System.Drawing.Point(353, 130)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(65, 65)
        Me.btnBack.TabIndex = 37
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'dgvSP
        '
        Me.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSP.Location = New System.Drawing.Point(21, 228)
        Me.dgvSP.Name = "dgvSP"
        Me.dgvSP.Size = New System.Drawing.Size(445, 209)
        Me.dgvSP.TabIndex = 35
        '
        'btnThem
        '
        Me.btnThem.BackgroundImage = Global.QuanLyBanHang_PS03157.My.Resources.Resources.add_icon
        Me.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThem.Location = New System.Drawing.Point(110, 130)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(65, 65)
        Me.btnThem.TabIndex = 33
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.BackgroundImage = Global.QuanLyBanHang_PS03157.My.Resources.Resources.pencil_160872_960_720
        Me.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSua.Location = New System.Drawing.Point(191, 130)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(65, 65)
        Me.btnSua.TabIndex = 34
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'txtHangSX
        '
        Me.txtHangSX.Location = New System.Drawing.Point(110, 89)
        Me.txtHangSX.Name = "txtHangSX"
        Me.txtHangSX.Size = New System.Drawing.Size(199, 20)
        Me.txtHangSX.TabIndex = 29
        '
        'txtTenSP
        '
        Me.txtTenSP.Location = New System.Drawing.Point(110, 38)
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.Size = New System.Drawing.Size(199, 20)
        Me.txtTenSP.TabIndex = 30
        '
        'txtMaSP
        '
        Me.txtMaSP.Location = New System.Drawing.Point(110, 12)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(199, 20)
        Me.txtMaSP.TabIndex = 31
        '
        'btnLoad
        '
        Me.btnLoad.BackgroundImage = Global.QuanLyBanHang_PS03157.My.Resources.Resources.magnifier_1093184_960_720
        Me.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLoad.Location = New System.Drawing.Point(25, 130)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(65, 65)
        Me.btnLoad.TabIndex = 27
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "NgaySX:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "HangSX:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Tên sản phẩm:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Mã sản phẩm:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNgaySX
        '
        Me.txtNgaySX.Location = New System.Drawing.Point(110, 63)
        Me.txtNgaySX.Name = "txtNgaySX"
        Me.txtNgaySX.Size = New System.Drawing.Size(199, 20)
        Me.txtNgaySX.TabIndex = 38
        '
        'btnXoa
        '
        Me.btnXoa.BackgroundImage = Global.QuanLyBanHang_PS03157.My.Resources.Resources.trash_recycle_bin_empty
        Me.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnXoa.Location = New System.Drawing.Point(272, 130)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(65, 65)
        Me.btnXoa.TabIndex = 39
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'FrmCapNhatSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSalmon
        Me.ClientSize = New System.Drawing.Size(488, 453)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.txtNgaySX)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvSP)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.txtHangSX)
        Me.Controls.Add(Me.txtTenSP)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCapNhatSP"
        Me.Text = "Cập Nhật Sản Phẩm"
        CType(Me.dgvSP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents dgvSP As DataGridView
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents txtHangSX As TextBox
    Friend WithEvents txtTenSP As TextBox
    Friend WithEvents txtMaSP As TextBox
    Friend WithEvents btnLoad As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNgaySX As TextBox
End Class
