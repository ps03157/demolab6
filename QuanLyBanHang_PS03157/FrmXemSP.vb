Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class FrmXemSP
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=PS03157.mssql.somee.com;packet size=4096;user id=quangtnps03157_SQLLogin_1;pwd=lt1n7y1mn9;data source=PS03157.mssql.somee.com;persist security info=False;initial catalog=PS03157"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select MaSP as 'Mã sản phẩm', TenSP as 'Tên sản phẩm', NgaySX as 'Ngày sản xuất', HangSX as 'Hãng sản xuất' from SANPHAM where MaSP='" & txtMaSP.Text & "'", connect)
        Try
            If txtMaSP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgvXemSP.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvXemSP.DataSource = db.DefaultView
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

    Private Sub dgvSanpham_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvXemSP.CellContentClick
        Dim click As Integer = dgvXemSP.CurrentCell.RowIndex
        txtMaSP.Text = dgvXemSP.Item(0, click).Value
    End Sub

    'sự kiện làm mới
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MaSP as 'Mã sản phẩm', TenSP as 'Tên sản phẩm', NgaySX as 'Ngày sản xuất', HangSX as 'Hãng sản xuất' from SANPHAM", conn)
        conn.Open()
        load.Fill(db)
        dgvXemSP.DataSource = db.DefaultView
    End Sub

    Private Sub btnXemAll_Click(sender As Object, e As EventArgs) Handles btnXemAll.Click
        Dim hienthi As New LoadAll
        dgvXemSP.DataSource = hienthi.LoadSP.Tables(0)
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub
End Class