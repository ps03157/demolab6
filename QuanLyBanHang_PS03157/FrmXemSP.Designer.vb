<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmXemSP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmXemSP))
        Me.btnDong = New System.Windows.Forms.Button()
        Me.btnXemAll = New System.Windows.Forms.Button()
        Me.btnXem = New System.Windows.Forms.Button()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvXemSP = New System.Windows.Forms.DataGridView()
        CType(Me.dgvXemSP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(367, 90)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(85, 35)
        Me.btnDong.TabIndex = 15
        Me.btnDong.Text = "Close"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'btnXemAll
        '
        Me.btnXemAll.Location = New System.Drawing.Point(207, 90)
        Me.btnXemAll.Name = "btnXemAll"
        Me.btnXemAll.Size = New System.Drawing.Size(85, 35)
        Me.btnXemAll.TabIndex = 13
        Me.btnXemAll.Text = "View All"
        Me.btnXemAll.UseVisualStyleBackColor = True
        '
        'btnXem
        '
        Me.btnXem.Location = New System.Drawing.Point(54, 90)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(85, 35)
        Me.btnXem.TabIndex = 14
        Me.btnXem.Text = "View"
        Me.btnXem.UseVisualStyleBackColor = True
        '
        'txtMaSP
        '
        Me.txtMaSP.Location = New System.Drawing.Point(207, 27)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(160, 20)
        Me.txtMaSP.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Mã Sản Phẩm:"
        '
        'dgvXemSP
        '
        Me.dgvXemSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvXemSP.Location = New System.Drawing.Point(28, 162)
        Me.dgvXemSP.Name = "dgvXemSP"
        Me.dgvXemSP.Size = New System.Drawing.Size(445, 209)
        Me.dgvXemSP.TabIndex = 36
        '
        'FrmXemSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSalmon
        Me.ClientSize = New System.Drawing.Size(504, 383)
        Me.Controls.Add(Me.dgvXemSP)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnXemAll)
        Me.Controls.Add(Me.btnXem)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmXemSP"
        Me.Text = "Xem Sản Phẩm"
        CType(Me.dgvXemSP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDong As Button
    Friend WithEvents btnXemAll As Button
    Friend WithEvents btnXem As Button
    Friend WithEvents txtMaSP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvXemSP As DataGridView
End Class
