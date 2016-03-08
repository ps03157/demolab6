Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class FrmXemKH
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=PS03157.mssql.somee.com;packet size=4096;user id=quangtnps03157_SQLLogin_1;pwd=lt1n7y1mn9;data source=PS03157.mssql.somee.com;persist security info=False;initial catalog=PS03157"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã khách hàng', TenKH as 'Tên khách hàng', Email as 'Email', SDT as 'Số điện thoại', DiaChi as 'Địa Chỉ' from KHACHHANG where MaKH='" & txtMaKH.Text & "'", connect)
        Try
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgvXemKH.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvXemKH.DataSource = db.DefaultView
                    txtMaKH.Text = Nothing
                Else
                    MessageBox.Show("Không tìm thấy")
                    txtMaKH.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvKhachhang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvXemKH.CellContentClick
        Dim click As Integer = dgvXemKH.CurrentCell.RowIndex
        txtMaKH.Text = dgvXemKH.Item(0, click).Value
    End Sub

    'sự kiện làm mới
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã khách hàng', TenKH as 'Tên khách hàng', Email as 'Email', SDT as 'Số điện thoại', DiaChi as 'Địa chỉ' from KHACHHANG", conn)
        conn.Open()
        load.Fill(db)
        dgvXemKH.DataSource = db.DefaultView
    End Sub

    Private Sub btnXemAll_Click(sender As Object, e As EventArgs) Handles btnXemAll.Click
        Dim hienthi As New LoadAll
        dgvXemKH.DataSource = hienthi.LoadKH.Tables(0)
    End Sub

    Private Sub btnXemTenKH_Click(sender As Object, e As EventArgs) Handles btnXemTenKH.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim Xem As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã khách hàng', TenKH as 'Tên khách hàng', Email as 'Email', SDT as 'Số điện thoại',
        DiaChi as 'Địa Chỉ' from KHACHHANG where TenKH like N'%" & txtTenKH.Text & "%'", connect)
        Try
            If txtTenKH.Text = "" Then
                MessageBox.Show("Bạn cần nhập tên khách hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgvXemKH.DataSource = Nothing
                Xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvXemKH.DataSource = db.DefaultView
                    txtTenKH.Text = Nothing
                Else
                    MessageBox.Show("Không tìm thấy")
                    txtTenKH.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvKhachhang1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvXemKH.CellContentClick
        Dim click As Integer = dgvXemKH.CurrentCell.RowIndex
        txtTenKH.Text = dgvXemKH.Item(0, click).Value
    End Sub
End Class