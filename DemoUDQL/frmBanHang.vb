Public Class frmBanHang
    Public nhanVien As DataRow
    Dim dsChiNhanh As DataTable

    Private Sub frmBanHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dsNhanVien As DataTable = XL_DuLieu.DocCautruc("SELECT * FROM NhanVien where nv_xoa = false")
        nhanVien = dsNhanVien.NewRow()
        nhanVien("nv_ma") = 1
        HienThiDSChiNhanh()
        HienThiDSDonHang()
    End Sub

    Sub HienThiDSChiNhanh()
        Dim str As String = String.Format(
            "SELECT distinct cn_ma ,cn_ten, nvcn_ngay_ap_dung from ChiNhanh, NhanVienChiNhanh
            where nvcn_chi_nhanh = cn_ma and nvcn_nhan_vien = {0} and nvcn_ngay_ap_dung <= #{1}#",
                        nhanVien("nv_ma"), dtpNgayHienTai.Value.ToString("yyyy-MM-dd"))
        dsChiNhanh = XL_DuLieu.DocDuLieu(str)
        cbChiNhanh.ValueMember = "cn_ma"
        cbChiNhanh.DisplayMember = "cn_ten"
        cbChiNhanh.DataSource = dsChiNhanh
    End Sub

    Public Sub HienThiDSDonHang_TimKiem()
        If cbChiNhanh.SelectedIndex < 0 Then
            Return
        End If

        Dim maDonHangTimKiem As String = tbTimKiem.Text.Trim()

        Dim searchCondition As String = ""
        If Not String.IsNullOrEmpty(maDonHangTimKiem) Then
            searchCondition = String.Format(" AND CStr(dh_ma) LIKE '%{0}%'", maDonHangTimKiem)
        End If

        Dim str As String = String.Format(
        "SELECT *
         FROM DonHang, ChiNhanh, TrangThaiDonHang
         where cn_ma = dh_chi_nhanh and ttdh_ma = dh_trang_thai
         and dh_chi_nhanh = {0} and DateValue(dh_ngay) = #{1}# {2}",
        cbChiNhanh.SelectedValue, dtpNgayHienTai.Value.ToString("yyyy-MM-dd"), searchCondition)

        dgvDSDonHang.DataSource = XL_DuLieu.DocDuLieu(str)
    End Sub

    Public Sub HienThiDSDonHang()
        If cbChiNhanh.SelectedIndex < 0 Then
            Return
        End If
        Dim str As String = String.Format(
            "SELECT *
            FROM DonHang, ChiNhanh, TrangThaiDonHang
            where cn_ma = dh_chi_nhanh and ttdh_ma = dh_trang_thai
            and dh_chi_nhanh = {0} and DateValue(dh_ngay) = #{1}#",
            cbChiNhanh.SelectedValue, dtpNgayHienTai.Value.ToString("yyyy-MM-dd"))
        dgvDSDonHang.DataSource = XL_DuLieu.DocDuLieu(str)
    End Sub

    Private Sub dtpNgayHienTai_ValueChanged(sender As Object, e As EventArgs) Handles dtpNgayHienTai.ValueChanged
        HienThiDSChiNhanh()
    End Sub

    Private Sub cbChiNhanh_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbChiNhanh.SelectedIndexChanged
        HienThiDSDonHang()
    End Sub

    Private Sub bTao_Click(sender As Object, e As EventArgs) Handles bTao.Click
        If cbChiNhanh.SelectedIndex < 0 Then
            MessageBox.Show("Chưa có chi nhánh nào được gán cho nhân viên này", "Thông báo", MessageBoxButtons.OK)
            Return
        End If
        Dim str As String = String.Format(
            "SELECT *
            FROM MenuChiNhanh
            where mcn_ngay_ap_dung <= #{0}# and mcn_chi_nhanh = {1}",
            dtpNgayHienTai.Value.ToString("yyyy-MM-dd"), cbChiNhanh.SelectedItem("cn_ma"))
        Dim temp As DataTable = XL_DuLieu.DocDuLieu(str)
        If temp.Rows.Count <= 0 Then
            MessageBox.Show("Chi nhánh này chưa có menu nào được áp dụng vào ngày " & dtpNgayHienTai.Value.ToString("dd/MM/yyyy"), "Thông báo", MessageBoxButtons.OK)
            Return
        End If
        Dim frm As frmDonHang = New frmDonHang()
        frm.sp_menu = temp.Rows(0)("mcn_menu")
        frm.chi_nhanh = dsChiNhanh.Rows(cbChiNhanh.SelectedIndex)
        frm.ngay = dtpNgayHienTai.Value
        frm.Loai = 1
        frm.Tag = Me
        frm.Show()
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bCapNhat_Click(sender As Object, e As EventArgs) Handles bCapNhat.Click
        If cbChiNhanh.SelectedIndex >= 0 Then
            Dim str As String = String.Format(
                "SELECT *
                FROM MenuChiNhanh
                where mcn_ngay_ap_dung <= #{0}# and mcn_chi_nhanh = {1}
                ORDER By mcn_ngay_ap_dung DESC",
                dtpNgayHienTai.Value.ToString("yyyy-MM-dd"), cbChiNhanh.SelectedItem("cn_ma"))
            Dim temp As DataTable = XL_DuLieu.DocDuLieu(str)
            If temp.Rows.Count > 0 Then
                Dim frm As frmDonHang = New frmDonHang()
                frm.sp_menu = temp.Rows(0)("mcn_menu")
                frm.chi_nhanh = dsChiNhanh.Rows(cbChiNhanh.SelectedIndex)
                frm.ngay = dtpNgayHienTai.Value
                frm.Loai = 2
                frm.Tag = Me
                If dgvDSDonHang.SelectedCells.Count > 0 Then
                    Dim dhv As DataRowView = dgvDSDonHang.Rows(dgvDSDonHang.SelectedCells(0).RowIndex).DataBoundItem
                    Dim don_hang As DataRow = dhv.Row
                    frm.don_hang = don_hang
                    frm.Show()
                    frm.WindowState = FormWindowState.Maximized
                End If
            Else
                MessageBox.Show("Chi nhánh này chưa có menu nào được áp dụng vào ngày " & dtpNgayHienTai.Value.ToString("dd/MM/yyyy"), "Thoại báo", MessageBoxButtons.OK)
            End If
        End If
    End Sub

    Private Sub tbTimKiem_TextChanged(sender As Object, e As EventArgs) Handles tbTimKiem.TextChanged
        HienThiDSDonHang_TimKiem()
    End Sub

    ' --- LOGIC CẬP NHẬT TỒN KHO ---
    Function CapNhatTonKhoBanHang(ByVal dsChiTiet As DataTable) As Boolean
        Dim cn_ma As Int32 = cbChiNhanh.SelectedItem("cn_ma")

        For Each ctdh As DataRow In dsChiTiet.Rows
            ' Chi tru ton kho doi voi cac dong KHONG bi xoa hoan toan (DataRowState <> Deleted)
            If ctdh.RowState <> DataRowState.Deleted Then
                Dim sp_ma As Integer = CInt(ctdh("ctdh_ma_san_pham"))
                Dim so_luong_giam As Integer = CInt(ctdh("ctdh_so_luong"))

                ' 1. Doc TonKho hien tai
                Dim strQuery As String = String.Format(
                    "SELECT * FROM TonKho WHERE tk_san_pham = {0} AND tk_chi_nhanh = {1}",
                    sp_ma, cn_ma)
                Dim dsTonKho As DataTable = XL_DuLieu.DocDuLieu(strQuery)

                If dsTonKho Is Nothing OrElse dsTonKho.Rows.Count = 0 Then
                    MessageBox.Show("Sản phẩm mã " & sp_ma & " không tồn tại trong kho chi nhánh để bán.", "Cảnh báo tồn kho", MessageBoxButtons.OK)
                    Continue For
                End If

                ' 2. Kiểm tra số lượng
                Dim tk_row As DataRow = dsTonKho.Rows(0)
                Dim ton_hien_tai As Integer = CInt(tk_row("tk_so_luong"))

                If ton_hien_tai - so_luong_giam < 0 Then
                    MessageBox.Show("Sản phẩm mã " & sp_ma & " không đủ tồn kho để bán." &
                                vbCrLf & "Tồn hiện tại: " & ton_hien_tai &
                                vbCrLf & "Số lượng yêu cầu: " & so_luong_giam,
                                "Lỗi tồn kho", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If

                ' 3. Cập nhật số lượng
                tk_row("tk_so_luong") = ton_hien_tai - so_luong_giam
                tk_row("tk_ngay_cap_nhat") = DateTime.Now

                XL_DuLieu.GhiDuLieu("TonKho", dsTonKho)
            End If
        Next
        Return True
    End Function
    ' ------------------------------
End Class