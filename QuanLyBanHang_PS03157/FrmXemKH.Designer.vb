<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmXemKH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmXemKH))
        Me.btnDong = New System.Windows.Forms.Button()
        Me.btnXemAll = New System.Windows.Forms.Button()
        Me.btnXem = New System.Windows.Forms.Button()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.lblMaKH = New System.Windows.Forms.Label()
        Me.dgvXemKH = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.btnXemTenKH = New System.Windows.Forms.Button()
        CType(Me.dgvXemKH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(374, 110)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(85, 35)
        Me.btnDong.TabIndex = 10
        Me.btnDong.Text = "Close"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'btnXemAll
        '
        Me.btnXemAll.Location = New System.Drawing.Point(248, 110)
        Me.btnXemAll.Name = "btnXemAll"
        Me.btnXemAll.Size = New System.Drawing.Size(85, 35)
        Me.btnXemAll.TabIndex = 7
        Me.btnXemAll.Text = "View All"
        Me.btnXemAll.UseVisualStyleBackColor = True
        '
        'btnXem
        '
        Me.btnXem.Location = New System.Drawing.Point(12, 110)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(85, 35)
        Me.btnXem.TabIndex = 8
        Me.btnXem.Text = "View"
        Me.btnXem.UseVisualStyleBackColor = True
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(248, 16)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(160, 20)
        Me.txtMaKH.TabIndex = 6
        '
        'lblMaKH
        '
        Me.lblMaKH.AutoSize = True
        Me.lblMaKH.Location = New System.Drawing.Point(119, 19)
        Me.lblMaKH.Name = "lblMaKH"
        Me.lblMaKH.Size = New System.Drawing.Size(88, 13)
        Me.lblMaKH.TabIndex = 5
        Me.lblMaKH.Text = "Mã Khách Hàng:"
        '
        'dgvXemKH
        '
        Me.dgvXemKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvXemKH.Location = New System.Drawing.Point(12, 179)
        Me.dgvXemKH.Name = "dgvXemKH"
        Me.dgvXemKH.Size = New System.Drawing.Size(543, 232)
        Me.dgvXemKH.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(119, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Tên Khách Hàng:"
        '
        'txtTenKH
        '
        Me.txtTenKH.Location = New System.Drawing.Point(248, 59)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(160, 20)
        Me.txtTenKH.TabIndex = 22
        '
        'btnXemTenKH
        '
        Me.btnXemTenKH.Location = New System.Drawing.Point(122, 110)
        Me.btnXemTenKH.Name = "btnXemTenKH"
        Me.btnXemTenKH.Size = New System.Drawing.Size(89, 35)
        Me.btnXemTenKH.TabIndex = 23
        Me.btnXemTenKH.Text = "View By Name"
        Me.btnXemTenKH.UseVisualStyleBackColor = True
        '
        'FrmXemKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSalmon
        Me.ClientSize = New System.Drawing.Size(577, 423)
        Me.Controls.Add(Me.btnXemTenKH)
        Me.Controls.Add(Me.txtTenKH)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvXemKH)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnXemAll)
        Me.Controls.Add(Me.btnXem)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.lblMaKH)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmXemKH"
        Me.Text = "FrmXemKH"
        CType(Me.dgvXemKH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDong As Button
    Friend WithEvents btnXemAll As Button
    Friend WithEvents btnXem As Button
    Friend WithEvents txtMaKH As TextBox
    Friend WithEvents lblMaKH As Label
    Friend WithEvents dgvXemKH As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTenKH As TextBox
    Friend WithEvents btnXemTenKH As Button
End Class
