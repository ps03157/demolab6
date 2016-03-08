<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDangNhap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDangNhap))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.chkLuuTK = New System.Windows.Forms.CheckBox()
        Me.btnHuyBo = New System.Windows.Forms.Button()
        Me.btnDangNhap = New System.Windows.Forms.Button()
        Me.txtMatKhau = New System.Windows.Forms.TextBox()
        Me.txtTenDN = New System.Windows.Forms.TextBox()
        Me.lblMatKhau = New System.Windows.Forms.Label()
        Me.lblTenDN = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 321)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(231, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Bài làm thuộc bản quyền của Trần Nhật Quang"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 305)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "PS03157"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightSalmon
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.chkLuuTK)
        Me.TabPage1.Controls.Add(Me.btnHuyBo)
        Me.TabPage1.Controls.Add(Me.btnDangNhap)
        Me.TabPage1.Controls.Add(Me.txtMatKhau)
        Me.TabPage1.Controls.Add(Me.txtTenDN)
        Me.TabPage1.Controls.Add(Me.lblMatKhau)
        Me.TabPage1.Controls.Add(Me.lblTenDN)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(622, 275)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Đăng Nhập"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.QuanLyBanHang_PS03157.My.Resources.Resources.images
        Me.PictureBox1.Location = New System.Drawing.Point(24, 77)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(146, 149)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'chkLuuTK
        '
        Me.chkLuuTK.AutoSize = True
        Me.chkLuuTK.Location = New System.Drawing.Point(295, 177)
        Me.chkLuuTK.Name = "chkLuuTK"
        Me.chkLuuTK.Size = New System.Drawing.Size(91, 17)
        Me.chkLuuTK.TabIndex = 9
        Me.chkLuuTK.Text = "Lưu tài khoản"
        Me.chkLuuTK.UseVisualStyleBackColor = True
        '
        'btnHuyBo
        '
        Me.btnHuyBo.Location = New System.Drawing.Point(505, 202)
        Me.btnHuyBo.Name = "btnHuyBo"
        Me.btnHuyBo.Size = New System.Drawing.Size(75, 39)
        Me.btnHuyBo.TabIndex = 8
        Me.btnHuyBo.Text = "Huỷ Bỏ"
        Me.btnHuyBo.UseVisualStyleBackColor = True
        '
        'btnDangNhap
        '
        Me.btnDangNhap.Location = New System.Drawing.Point(295, 202)
        Me.btnDangNhap.Name = "btnDangNhap"
        Me.btnDangNhap.Size = New System.Drawing.Size(75, 39)
        Me.btnDangNhap.TabIndex = 7
        Me.btnDangNhap.Text = "Đăng Nhập"
        Me.btnDangNhap.UseVisualStyleBackColor = True
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Location = New System.Drawing.Point(295, 141)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMatKhau.Size = New System.Drawing.Size(285, 20)
        Me.txtMatKhau.TabIndex = 4
        Me.txtMatKhau.Text = "quangtnps03157"
        '
        'txtTenDN
        '
        Me.txtTenDN.Location = New System.Drawing.Point(295, 94)
        Me.txtTenDN.Name = "txtTenDN"
        Me.txtTenDN.Size = New System.Drawing.Size(285, 20)
        Me.txtTenDN.TabIndex = 3
        Me.txtTenDN.Text = "quangtnps03157"
        '
        'lblMatKhau
        '
        Me.lblMatKhau.AutoSize = True
        Me.lblMatKhau.Location = New System.Drawing.Point(178, 144)
        Me.lblMatKhau.Name = "lblMatKhau"
        Me.lblMatKhau.Size = New System.Drawing.Size(56, 13)
        Me.lblMatKhau.TabIndex = 2
        Me.lblMatKhau.Text = "Mật Khẩu:"
        Me.lblMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTenDN
        '
        Me.lblTenDN.AutoSize = True
        Me.lblTenDN.Location = New System.Drawing.Point(176, 97)
        Me.lblTenDN.Name = "lblTenDN"
        Me.lblTenDN.Size = New System.Drawing.Size(87, 13)
        Me.lblTenDN.TabIndex = 1
        Me.lblTenDN.Text = "Tên Đăng Nhập:"
        Me.lblTenDN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(109, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(395, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Chào Mừng Đến Với Cửa Hàng Điện Thoại"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(-4, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(630, 301)
        Me.TabControl1.TabIndex = 0
        '
        'FrmDangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 343)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDangNhap"
        Me.Text = "Đăng Nhập"
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents chkLuuTK As CheckBox
    Friend WithEvents btnHuyBo As Button
    Friend WithEvents btnDangNhap As Button
    Friend WithEvents txtMatKhau As TextBox
    Friend WithEvents txtTenDN As TextBox
    Friend WithEvents lblMatKhau As Label
    Friend WithEvents lblTenDN As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents PictureBox1 As PictureBox
End Class
