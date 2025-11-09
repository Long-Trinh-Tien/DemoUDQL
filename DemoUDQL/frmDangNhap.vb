Public Class frmDangNhap
    Public NhanVien As DataRow
    ' Property để kiểm tra quyền admin
    Public ReadOnly Property isAdmin As Boolean
        Get
            If NhanVien Is Nothing Then Return False
            Return CInt(NhanVien("nv_ma_loai_nhan_vien")) = 1 '1 is admin
        End Get
    End Property
    Private Sub bDangNhap_Click(sender As Object, e As EventArgs) Handles bDangNhap.Click
        Dim TenDangNhap As String = tbTenDangNhap.Text
        Dim MatKhau As String = Util.getHash(tbMatKhau.Text)
        Dim sql As String = String.Format("Select TaiKhoan.*, NhanVien.* from NhanVien, TaiKhoan 
            where tk_ma = nv_ma_tai_khoan and tk_tai_khoan = '{0}' and nv_xoa = false", TenDangNhap)
        Dim dsNhanVien As DataTable = XL_DuLieu.DocDuLieu(sql)
        If dsNhanVien.Rows.Count = 1 Then
            NhanVien = dsNhanVien.Rows(0)
            If MatKhau = NhanVien("tk_mat_khau") And NhanVien("tk_dang_nhap_loi") <= 5 Then
                NhanVien("tk_dang_nhap_loi") = 0
                lKetQua.Text = "Done!!!"
                XL_DuLieu.GhiDuLieu("TaiKhoan", dsNhanVien)
                Me.DialogResult = DialogResult.OK
            Else
                NhanVien("tk_dang_nhap_loi") = NhanVien("tk_dang_nhap_loi") + 1
                XL_DuLieu.GhiDuLieu("TaiKhoan", dsNhanVien)
                lKetQua.Text = "Ten dang nhap/Mat khau khong dung!!!"
            End If
        End If

    End Sub

    Private Sub bThoat_Click(sender As Object, e As EventArgs) Handles bThoat.Click
        Me.Close()
    End Sub

End Class