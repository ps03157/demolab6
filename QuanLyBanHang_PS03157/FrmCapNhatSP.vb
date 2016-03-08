Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class FrmCapNhatSP
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=PS03157.mssql.somee.com;packet size=4096;user id=quangtnps03157_SQLLogin_1;pwd=lt1n7y1mn9;data source=PS03157.mssql.somee.com;persist security info=False;initial catalog=PS03157"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub dgvKH_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSP.CellContentClick

    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into SANPHAM values(@MaSP,@TenSP,@NgaySX,@HangSX)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtMaSP.Focus()
            If txtMaSP.Text = "" Then
                MessageBox.Show("Vui lòng nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMaSP.Focus()
                If txtTenSP.Text = "" Then
                    MessageBox.Show("Vui lòng nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTenSP.Focus()
                    If txtNgaySX.Text = "" Then
                        MessageBox.Show("Vui lòng nhập ngày sản xuất", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtNgaySX.Focus()
                        If txtHangSX.Text = "" Then
                            MessageBox.Show("Vui lòng nhập hãng sản xuất", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            save.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
                            save.Parameters.AddWithValue("@TenSP", txtTenSP.Text)
                            save.Parameters.AddWithValue("@NgaySX", txtNgaySX.Text)
                            save.Parameters.AddWithValue("@HangSX", txtHangSX.Text)
                            save.ExecuteNonQuery()
                            MessageBox.Show("Lưu thành công")
                            'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                            txtMaSP.Text = Nothing
                            txtTenSP.Text = Nothing
                            txtNgaySX.Text = Nothing
                            txtHangSX.Text = Nothing
                        End If
                    End If
                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã sản phẩm", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaSP as 'Mã sản phẩm', TenSP as 'Tên sản phẩm', NgaySX as 'Ngày sản xuất', HangSX as 'Hãng sản xuất' from SANPHAM", conn)
        db.Clear()
        refesh.Fill(db)
        dgvSP.DataSource = db.DefaultView
    End Sub




    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select MaSP as 'Mã sản phẩm', TenSP as 'Tên sản phẩm', NgaySX as 'Ngày sản xuất', HangSX as 'Hãng sản xuất' from SANPHAM where MaSP='" & txtMaSP.Text & "'", connect)
        Try
            If txtMaSP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgvSP.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvSP.DataSource = db.DefaultView
                    txtMaSP.Text = Nothing
                Else
                    MessageBox.Show("Không tìm thấy")
                    txtMaSP.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub dgvSanpham_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSP.CellContentClick
        Dim click As Integer = dgvSP.CurrentCell.RowIndex
        txtMaSP.Text = dgvSP.Item(0, click).Value
        txtTenSP.Text = dgvSP.Item(1, click).Value
        txtNgaySX.Text = dgvSP.Item(2, click).Value
        txtHangSX.Text = dgvSP.Item(3, click).Value
    End Sub
    'sự kiện làm mới
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MaSP as 'Mã sản phẩm', TenSP as 'Tên sản phẩm', NgaySX as 'Ngày sản xuất', HangSX as 'Hãng sản xuất' from SANPHAM", conn)
        conn.Open()
        load.Fill(db)
        dgvSP.DataSource = db.DefaultView
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FrmMain.Show()
        Me.Hide()
    End Sub


    Private Sub btnCapnhat_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        'Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        'Dim updatequery As String = "update SANPHAM set MaSP=@MaSP, TenSP=@TenSP, NgaySX=@NgaySX, HangSX=@HangSX where MaSP=@MaSP"
        'Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        'conn.Open()
        Try
            txtMaSP.Focus()
            If txtMaSP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMaSP.Focus()
                If txtTenSP.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTenSP.Focus()
                    If txtNgaySX.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập ngày sản xuất", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtNgaySX.Focus()
                        If txtHangSX.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập hãng sản xuất", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            'addupdate.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
                            'addupdate.Parameters.AddWithValue("@TenSP", txtTenSP.Text)
                            'addupdate.Parameters.AddWithValue("@NgaySX", txtNgaySX.Text)
                            'addupdate.Parameters.AddWithValue("@HangSX", txtHangSX.Text)
                            'addupdate.ExecuteNonQuery()
                            'conn.Close() 'đóng kết nối
                            Dim sql As String = <sql>
                                                    update sanpham
                                                    set  TenSP=N'{0}', NgaySX= '{1}', HangSX= '{2}' 
                                                    where MaSP='{3}' 
                                                </sql>
                            sql = String.Format(sql, txtTenSP.Text, txtNgaySX.Text, txtHangSX.Text, txtMaSP.Text)
                            excutenonquery(sql)


                            MessageBox.Show("Cập nhật thành công")
                            txtMaSP.Text = Nothing
                            txtTenSP.Text = Nothing
                            txtNgaySX.Text = Nothing
                            txtHangSX.Text = Nothing
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvSP.DataSource = db
        dgvSP.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub FrmCapNhatSP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MaSP as 'Mã sản phẩm', TenSP as 'Tên sản phẩm', NgaySX as 'Ngày sản xuất', HangSX as 'Hãng sản xuất' from SANPHAM", conn)
        conn.Open()
        load.Fill(db)
        dgvSP.DataSource = db.DefaultView
    End Sub




    Private Sub btnXoa_Click_1(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim delquery As String = "delete from SANPHAM where MaSP=@MaSP"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        'Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        Try
            If txtMaSP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtMaSP.Focus()
            Else
                'If resulft = Windows.Forms.DialogResult.Yes Then
                'delete.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
                '        delete.ExecuteNonQuery()
                '        conn.Close()
                MessageBox.Show("Xóa thành công")
                '        'Sau khi xóa thành công, tự động làm mới các khung textbox
                '        txtMaSP.Text = Nothing
                '        txtTenSP.Text = Nothing
                '        txtNgaySX.Text = Nothing
                '        txtHangSX.Text = Nothing
                '        txtMaSP.

                Dim sql As String = <sql>
                        delete from sanpham where masp = '{0}'
                                </sql>
                sql = String.Format(sql, txtMaSP.Text)
                excutenonquery(sql)
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã sản phẩm cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng
        db.Clear()
        dgvSP.DataSource = db
        dgvSP.DataSource = Nothing
        LoadData()
    End Sub
End Class