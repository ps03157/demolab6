Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class LoadAll
    Public Function LoadSP() As DataSet
        Dim chuoiketnoi As String = "workstation id=PS03157.mssql.somee.com;packet size=4096;user id=quangtnps03157_SQLLogin_1;pwd=lt1n7y1mn9;data source=PS03157.mssql.somee.com;persist security info=False;initial catalog=PS03157"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadSPham As New SqlDataAdapter("select MaSP as 'Mã sản phẩm' ,TenSP as 'Tên sản phẩm', NgaySX as 'Ngày sản xuất', HangSX as 'Hãng sản xuất' from SANPHAM", conn)
        Dim db As New DataSet
        conn.Open()
        LoadSPham.Fill(db)
        conn.Close()
        Return db
    End Function

    Public Function LoadKH() As DataSet
        Dim chuoiketnoi As String = "workstation id=PS03157.mssql.somee.com;packet size=4096;user id=quangtnps03157_SQLLogin_1;pwd=lt1n7y1mn9;data source=PS03157.mssql.somee.com;persist security info=False;initial catalog=PS03157"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadKHang As New SqlDataAdapter("select MaKH as 'Mã khách hàng', TenKH as 'Tên khách hàng', Email as 'Email', SDT as 'SĐT', DiaChi as 'Địa Chỉ' from KHACHHANG", conn)
        Dim db As New DataSet
        conn.Open()
        LoadKHang.Fill(db)
        conn.Close()
        Return db
    End Function
End Class
