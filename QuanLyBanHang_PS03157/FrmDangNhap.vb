Public Class FrmDangNhap

    Private Sub FrmDangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtTenDN_TextChanged(sender As Object, e As EventArgs) Handles txtTenDN.TextChanged

    End Sub

    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        If txtTenDN.Text = "" Or txtMatKhau.Text = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If txtTenDN.Text = "quangtnps03157" And txtMatKhau.Text = "quangtnps03157" Then
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FrmMain.Show()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub btnHuyBo_Click(sender As Object, e As EventArgs) Handles btnHuyBo.Click
        Me.Close()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class
