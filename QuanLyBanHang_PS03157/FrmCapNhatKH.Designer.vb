<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCapNhatKH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCapNhatKH))
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.dgvKH = New System.Windows.Forms.DataGridView()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtSĐT = New System.Windows.Forms.TextBox()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        CType(Me.dgvKH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(106, 66)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(137, 20)
        Me.txtEmail.TabIndex = 20
        '
        'dgvKH
        '
        Me.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKH.Location = New System.Drawing.Point(18, 243)
        Me.dgvKH.Name = "dgvKH"
        Me.dgvKH.Size = New System.Drawing.Size(543, 209)
        Me.dgvKH.TabIndex = 19
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(106, 115)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(137, 20)
        Me.txtDiaChi.TabIndex = 12
        '
        'txtSĐT
        '
        Me.txtSĐT.Location = New System.Drawing.Point(106, 89)
        Me.txtSĐT.Name = "txtSĐT"
        Me.txtSĐT.Size = New System.Drawing.Size(137, 20)
        Me.txtSĐT.TabIndex = 13
        '
        'txtTenKH
        '
        Me.txtTenKH.Location = New System.Drawing.Point(106, 38)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(137, 20)
        Me.txtTenKH.TabIndex = 14
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(106, 12)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(137, 20)
        Me.txtMaKH.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Địa chỉ:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Email:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "SĐT:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Tên khách hàng:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Mã khách hàng:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.QuanLyBanHang_PS03157.My.Resources.Resources.wrong_295503_960_720
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(302, 157)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 65)
        Me.Button1.TabIndex = 21
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.BackgroundImage = Global.QuanLyBanHang_PS03157.My.Resources.Resources.trash_recycle_bin_empty
        Me.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnXoa.Location = New System.Drawing.Point(231, 157)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(65, 65)
        Me.btnXoa.TabIndex = 16
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.BackgroundImage = Global.QuanLyBanHang_PS03157.My.Resources.Resources.add_icon2
        Me.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThem.Location = New System.Drawing.Point(89, 157)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(65, 65)
        Me.btnThem.TabIndex = 17
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.BackgroundImage = Global.QuanLyBanHang_PS03157.My.Resources.Resources.pencil_160872_960_720
        Me.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSua.Location = New System.Drawing.Point(160, 157)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(65, 65)
        Me.btnSua.TabIndex = 18
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.BackgroundImage = Global.QuanLyBanHang_PS03157.My.Resources.Resources.magnifier_1093184_960_720
        Me.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLoad.Location = New System.Drawing.Point(18, 157)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(65, 65)
        Me.btnLoad.TabIndex = 11
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'FrmCapNhatKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSalmon
        Me.ClientSize = New System.Drawing.Size(583, 469)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.dgvKH)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.txtSĐT)
        Me.Controls.Add(Me.txtTenKH)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCapNhatKH"
        Me.Text = "Cập Nhật Khách Hàng"
        CType(Me.dgvKH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEmail As TextBox
    Friend WithEvents dgvKH As DataGridView
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents txtSĐT As TextBox
    Friend WithEvents txtTenKH As TextBox
    Friend WithEvents txtMaKH As TextBox
    Friend WithEvents btnLoad As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
