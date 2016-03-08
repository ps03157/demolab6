Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class FrmCapNhatKH
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=PS03157.mssql.somee.com;packet size=4096;user id=quangtnps03157_SQLLogin_1;pwd=lt1n7y1mn9;data source=PS03157.mssql.somee.com;persist security info=False;initial catalog=PS03157"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã khách hàng', TenKH as 'Tên khách hàng', Email as 'Email', SDT as 'Số điện thoại', DiaChi as 'Địa Chỉ' from KHACHHANG where MaKH='" & txtMaKH.Text & "'", connect)
        Try
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgvKH.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvKH.DataSource = db.DefaultView
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

    Private Sub dgvKhachhang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKH.CellContentClick
        Dim click As Integer = dgvKH.CurrentCell.RowIndex
        txtMaKH.Text = dgvKH.Item(0, click).Value
        txtTenKH.Text = dgvKH.Item(1, click).Value
        txtEmail.Text = dgvKH.Item(2, click).Value
        txtSĐT.Text = dgvKH.Item(3, click).Value
        txtDiaChi.Text = dgvKH.Item(4, click).Value
    End Sub

    'sự kiện làm mới
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã khách hàng', TenKH as 'Tên khách hàng', Email as 'Email', SDT as 'Số điện thoại', DiaChi as 'Địa Chỉ' from KHACHHANG", conn)
        conn.Open()
        load.Fill(db)
        dgvKH.DataSource = db.DefaultView
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into KHACHHANG values(@MaKH,@TenKH,@Email,@SDT,@DiaChi)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtMaKH.Focus()
            If txtMaKH.Text = "" Then
                MessageBox.Show("Vui lòng nhập mã khách hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMaKH.Focus()
                If txtTenKH.Text = "" Then
                    MessageBox.Show("Vui lòng nhập tên khách hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTenKH.Focus()
                    If txtEmail.Text = "" Then
                        MessageBox.Show("Vui lòng nhập Email", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtEmail.Focus()
                        If txtSĐT.Text = "" Then
                            MessageBox.Show("Vui lòng nhập số điện thoại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtSĐT.Focus()
                            If txtDiaChi.Text = "" Then
                                MessageBox.Show("Vui lòng nhập địa chỉ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else

                                save.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
                                save.Parameters.AddWithValue("@TenKH", txtTenKH.Text)
                                save.Parameters.AddWithValue("@Email", txtEmail.Text)
                                save.Parameters.AddWithValue("@SDT", txtSĐT.Text)
                                save.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
                                save.ExecuteNonQuery()
                                MessageBox.Show("Lưu thành công")
                                'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                                txtMaKH.Text = Nothing
                                txtTenKH.Text = Nothing
                                txtEmail.Text = Nothing
                                txtSĐT.Text = Nothing
                                txtDiaChi.Text = Nothing
                            End If
                        End If
                    End If
                End If
            End If

        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã khách hàng", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã khách hàng', TenKH as 'Tên khách hàng', Email as 'Email', SDT as 'Số điện thoại', DiaChi as 'Địa Chỉ' from KHACHHANG", conn)
        db.Clear()
        refesh.Fill(db)
        dgvKH.DataSource = db.DefaultView
    End Sub

    Private Sub FrmCapNhatKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã khách hàng', TenKH as 'Tên khách hàng', Email as 'Email', SDT as 'Số điện thoại', DiaChi as 'Địa Chỉ' from KHACHHANG", conn)
        conn.Open()
        load.Fill(db)
        dgvKH.DataSource = db.DefaultView
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click

        Try
            txtMaKH.Focus()
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMaKH.Focus()
                If txtTenKH.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTenKH.Focus()
                    If txtEmail.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập Email", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtEmail.Focus()
                        If txtSĐT.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtSĐT.Focus()
                            If txtDiaChi.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                Dim sql As String = <sql>
                                                    update KHACHHANG
                                                    set  TenKH=N'{0}', Email= '{1}', SDT= '{2}' , DiaChi= N'{3}'
                                                    where MaKH='{4}' 
                                                </sql>
                                sql = String.Format(sql, txtTenKH.Text, txtEmail.Text, txtSĐT.Text, txtDiaChi.Text, txtMaKH.Text)
                                excutenonquery(sql)


                                MessageBox.Show("Cập nhật thành công")
                                txtMaKH.Text = Nothing
                                txtTenKH.Text = Nothing
                                txtEmail.Text = Nothing
                                txtSĐT.Text = Nothing
                                txtDiaChi.Text = Nothing
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvKH.DataSource = db
        dgvKH.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim delquery As String = "delete from KHACHHANG where MaKH=@MaKH"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        'Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'conn.Open()
        Try
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtMaKH.Focus()
            Else
                MessageBox.Show("Xóa thành công")
                Dim sql As String = <sql>
                        delete from khachhang where makh = '{0}'
                                </sql>
                sql = String.Format(sql, txtMaKH.Text)
                excutenonquery(sql)
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã sản phẩm cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng
        db.Clear()
        dgvKH.DataSource = db
        dgvKH.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class