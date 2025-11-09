Public Class frmDonHang
    Public sp_menu As Integer
    Public chi_nhanh As DataRow
    Public ngay As Date
    Dim dsKhachHang As DataTable
    Dim khach_hang As DataRow
    Dim dsSanPham As DataTable
    Dim dsDonHang As DataTable
    Dim dsChiTietDonHang As DataTable

    Public Loai As Integer '1 : moi, 3: cap nhat
    Public don_hang As DataRow
    Private Sub frmDonHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lChiNhanh.Text = "Chi nhanh: " & chi_nhanh("cn_ten").ToString()
        dtpNgay.Value = ngay

        Dim str As String = String.Format(
            "SELECT sp_ma, sp_ten, bgct_gia from BangGiaChiTiet, SanPham
            where 'bgct_mon_an = sp_ma and bgct_menu = {0}'",
            sp_menu)
        dsSanPham = XL_DuLieu.DocDuLieu(str)
        dgvDSSanPham.DataSource = dsSanPham

        If Loai = 1 Then
            str = String.Format(
                "SELECT ctdh_ma, ctdh_ma_san_pham, sp_ten, ctdh_so_luong, ctdh_gia, 
                ctdh_tong_san_pham, ctdh_khuyen_mai ,ctdh_tong_tien, ctdh_ghi_chu, ctdh_xoa, ctdh_ma_don_hang
                from ChiTietDonHang, SanPham where ctdh_ma_san_pham = sp_ma"
            )
            dsChiTietDonHang = XL_DuLieu.DocCautruc(str)

            str = String.Format("select * from DonHang")
            dsDonHang = XL_DuLieu.DocCautruc(str)
            bCapNhat.Visible = False
            bTao.Visible = True
        Else
            dsChiTietDonHang = XL_DuLieu.DocDuLieu(
                "SELECT ctdh_ma, ctdh_ma_san_pham, sp_ten, ctdh_so_luong, ctdh_gia, 
                ctdh_tong_san_pham, ctdh_khuyen_mai ,ctdh_tong_tien, ctdh_ghi_chu, ctdh_xoa, ctdh_ma_don_hang
                from ChiTietDonHang, SanPham where ctdh_ma_san_pham = sp_ma and ctdh_ma_don_hang = " + don_hang("dh_ma").ToString()
                 )

            dsDonHang = XL_DuLieu.DocDuLieu(
                "select * from DonHang where dh_ma = " + don_hang("dh_ma").ToString()
            )
            dsKhachHang = XL_DuLieu.DocDuLieu("select * from KhachHang where kh_ma = " + don_hang("dh_khach_hang").ToString())
            khach_hang = dsKhachHang.Rows(0)
            tbDienThoai.Text = khach_hang("kh_dien_thoai").ToString()
            tbTen.Text = khach_hang("kh_ten").ToString()
            tbDiaChi.Text = khach_hang("kh_dia_chi").ToString()
            tbGhiChu.Text = don_hang("dh_ghi_chu").ToString()
            TinhTong()

            bCapNhat.Visible = True
            bTao.Visible = False
        End If
        dgvDSChiTiet.DataSource = dsChiTietDonHang
        dgvDSChiTiet.Columns(0).Visible = False 'ctdh_ma
        dgvDSChiTiet.Columns(9).Visible = False 'ctdh_ma_don_hang
    End Sub
    Private Sub bThem_Click(sender As Object, e As EventArgs) Handles bThem.Click
        If dgvDSSanPham.SelectedRows.Count = 0 Then
            MessageBox.Show("Chua chon mon an", "Thong bao", MessageBoxButtons.OK)
            Return
        End If
        Dim san_pham As DataRow = dsSanPham(dgvDSSanPham.SelectedCells(0).RowIndex)
        Dim ctdhs() As DataRow = dsChiTietDonHang.Select(String.Format("ctdh_ma_san_pham = " + san_pham("sp_ma").ToString()))
        ' --- Lấy tồn kho hiện tại ---
        Dim strQuery As String = String.Format(
        "SELECT tk_so_luong FROM TonKho WHERE tk_san_pham = {0} AND tk_chi_nhanh = {1}",
        san_pham("sp_ma"), chi_nhanh("cn_ma"))
        Dim dsTonKho As DataTable = XL_DuLieu.DocDuLieu(strQuery)

        If dsTonKho Is Nothing OrElse dsTonKho.Rows.Count = 0 Then
            MessageBox.Show("Sản phẩm mã " & san_pham("sp_ma") & " không tồn tại trong kho chi nhánh.", "Cảnh báo tồn kho", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim ton_hien_tai As Integer = CInt(dsTonKho.Rows(0)("tk_so_luong"))


        If ctdhs.Length > 0 Then
            Dim chi_tiet As DataRow = ctdhs(0)
            Dim so_luong_moi As Integer = CInt(chi_tiet("ctdh_so_luong")) + 1

            If so_luong_moi > ton_hien_tai Then
                MessageBox.Show("Không đủ tồn kho cho sản phẩm mã " & san_pham("sp_ma") &
                            vbCrLf & "Tồn hiện tại: " & ton_hien_tai &
                            vbCrLf & "Số lượng yêu cầu: " & so_luong_moi,
                            "Lỗi tồn kho", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            chi_tiet("ctdh_so_luong") = so_luong_moi
            chi_tiet("ctdh_tong_tien") = chi_tiet("ctdh_so_luong") * chi_tiet("ctdh_gia")
            chi_tiet("ctdh_tong_san_pham") = chi_tiet("ctdh_tong_tien")
            chi_tiet("ctdh_khuyen_mai") = 0
        Else
            ' Nếu thêm mới thì kiểm tra tồn kho >= 1
            If ton_hien_tai < 1 Then
                MessageBox.Show("Không đủ tồn kho cho sản phẩm mã " & san_pham("sp_ma"),
                            "Lỗi tồn kho", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim chi_tiet As DataRow = dsChiTietDonHang.NewRow()
            chi_tiet("ctdh_ma_san_pham") = san_pham("sp_ma")
            chi_tiet("ctdh_gia") = san_pham("bgct_gia")
            chi_tiet("ctdh_so_luong") = 1
            'chi_tiet("ctdh_ten_san_pham") = san_pham("sp_ten")
            chi_tiet("ctdh_tong_tien") = chi_tiet("ctdh_so_luong") * chi_tiet("ctdh_gia")
            chi_tiet("ctdh_tong_san_pham") = chi_tiet("ctdh_tong_tien")
            chi_tiet("ctdh_khuyen_mai") = 0
            dsChiTietDonHang.Rows.Add(chi_tiet)
        End If
        TinhTong()
    End Sub

    Sub TinhTong()
        Dim TongTien = dsChiTietDonHang.Compute("Sum(ctdh_tong_tien)", String.Empty)
        lTongTien.Text = TongTien.ToString()
    End Sub

    Private Sub bXoa_Click(sender As Object, e As EventArgs) Handles bXoa.Click
        If dgvDSChiTiet.SelectedCells.Count > 0 Then
            Dim chi_tiet As DataRow = dsChiTietDonHang(dgvDSChiTiet.SelectedCells(0).RowIndex)
            Dim so_luong As Integer = chi_tiet("ctdh_so_luong") - 1
            If so_luong <= 0 Then
                If Loai = 1 Then
                    dsChiTietDonHang.Rows.Remove(chi_tiet)
                ElseIf Loai = 2 Then
                    chi_tiet.Delete()
                End If
            Else
                chi_tiet("ctdh_so_luong") = so_luong
                chi_tiet("ctdh_tong_tien") = chi_tiet("ctdh_so_luong") * chi_tiet("ctdh_gia")
                chi_tiet("ctdh_tong_san_pham") = chi_tiet("ctdh_tong_tien")
                chi_tiet("ctdh_khuyen_mai") = 0
            End If
            TinhTong()
        End If
    End Sub

    Private Sub bTao_Click(sender As Object, e As EventArgs) Handles bTao.Click
        If tbDienThoai.Text = String.Empty Or tbTen.Text = String.Empty Then
            MessageBox.Show("Chua nhap so dien thoai", "Thong bao", MessageBoxButtons.OK)
            Return
        ElseIf IsDBNull(khach_hang("kh_ma")) Then
            khach_hang("kh_ten") = tbTen.Text
            khach_hang("kh_dia_chi") = tbDiaChi.Text
            XL_DuLieu.GhiDuLieu("KhachHang", dsKhachHang)
        End If

        Dim don_hang As DataRow = dsDonHang.NewRow()
        don_hang("dh_ngay") = dtpNgay.Value
        don_hang("dh_tong_san_pham") = Int32.Parse(lTongTien.Text)
        don_hang("dh_tong_khuyen_mai") = 0
        don_hang("dh_tong_tien") = don_hang("dh_tong_san_pham") - don_hang("dh_tong_khuyen_mai")
        'don_hang("dh_dien_thoai") = tbDienThoai.Text
        'don_hang("dh_ten_khach_hang") = tbTen.Text
        don_hang("dh_chi_nhanh") = chi_nhanh("cn_ma")
        don_hang("dh_khach_hang") = khach_hang("kh_ma")
        don_hang("dh_ghi_chu") = tbGhiChu.Text
        don_hang("dh_trang_thai") = 1

        dsDonHang.Rows.Add(don_hang)
        XL_DuLieu.GhiDuLieu("DonHang", dsDonHang)
        For Each ctdh As DataRow In dsChiTietDonHang.Rows
            ctdh("ctdh_ma_don_hang") = don_hang("dh_ma")
        Next
        ' --- CẬP NHẬT TỒN KHO ---
        If Not IsNothing(Me.Tag) AndAlso TypeOf Me.Tag Is frmBanHang Then
            Dim frmBanHangParent As frmBanHang = CType(Me.Tag, frmBanHang)

            ' Gọi hàm cập nhật tồn kho
            Dim ok As Boolean = frmBanHangParent.CapNhatTonKhoBanHang(dsChiTietDonHang)

            If Not ok Then
                ' Nếu lỗi tồn kho thì không ghi dữ liệu chi tiết đơn hàng
                Exit Sub
            End If
        End If
        ' ------------------------------------------
        XL_DuLieu.GhiDuLieu("ChiTietDonHang", dsChiTietDonHang)

        TatManHinh()
    End Sub

    Sub TatManHinh()
        Dim frm As frmBanHang = Me.Tag
        frm.HienThiDSDonHang()
        Me.Close()
    End Sub

    Private Sub bCapNhat_Click(sender As Object, e As EventArgs) Handles bCapNhat.Click
        If tbDienThoai.Text = String.Empty Or tbTen.Text = String.Empty Then
            MessageBox.Show("Chua nhap so dien thoai", "Thong bao", MessageBoxButtons.OK)
            Return
        ElseIf IsDBNull(khach_hang("kh_ma")) Then
            khach_hang("kh_ten") = tbTen.Text
            khach_hang("kh_dia_chi") = tbDiaChi.Text
            XL_DuLieu.GhiDuLieu("KhachHang", dsKhachHang)
        End If

        Dim don_hang = dsDonHang.Rows(0)
        Dim tong_tien_so As Integer
        don_hang("dh_ngay") = dtpNgay.Value
        If Integer.TryParse(lTongTien.Text, tong_tien_so) Then
            don_hang("dh_tong_san_pham") = tong_tien_so
        Else
            don_hang("dh_tong_san_pham") = 0
        End If
        don_hang("dh_tong_khuyen_mai") = 0
        don_hang("dh_tong_tien") = don_hang("dh_tong_san_pham") - don_hang("dh_tong_khuyen_mai")
        'don_hang("dh_dien_thoai") = tbDienThoai.Text
        'don_hang("dh_ten_khach_hang") = tbTen.Text
        don_hang("dh_chi_nhanh") = chi_nhanh("cn_ma")
        don_hang("dh_khach_hang") = khach_hang("kh_ma")
        don_hang("dh_ghi_chu") = tbGhiChu.Text

        XL_DuLieu.GhiDuLieu("DonHang", dsDonHang)

        For Each ctdh As DataRow In dsChiTietDonHang.Rows
            If ctdh.RowState <> DataRowState.Deleted Then
                ctdh("ctdh_ma_don_hang") = don_hang("dh_ma")
            End If
        Next
        XL_DuLieu.GhiDuLieu("ChiTietDonHang", dsChiTietDonHang)
        TatManHinh()
    End Sub

    Private Sub tbDienThoai_Leave(sender As Object, e As EventArgs) Handles tbDienThoai.Leave
        Dim str As String = String.Format(
            "SELECT * from KhachHang where kh_dien_thoai like '{0}'",
            tbDienThoai.Text)
        dsKhachHang = XL_DuLieu.DocDuLieu(str)
        If dsKhachHang.Rows.Count > 0 Then
            khach_hang = dsKhachHang.Rows(0)
            tbTen.Text = khach_hang("kh_ten").ToString()
            tbDiaChi.Text = khach_hang("kh_dia_chi").ToString()
        Else
            khach_hang = dsKhachHang.NewRow()
            khach_hang("kh_dien_thoai") = tbDienThoai.Text
            dsKhachHang.Rows.Add(khach_hang)
        End If
    End Sub
End Class