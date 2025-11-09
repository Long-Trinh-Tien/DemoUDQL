Public Class frmNhanVien

    Dim dsNhanVien As DataTable
    Dim dsNhanVienView As DataView
    Dim dsTaiKhoan As DataTable
    Dim dsLoaiNhanVien As DataTable
    Sub HienThiDSNhanVien()
        Dim truy_van As String = "SELECT nv_ma, nv_ten, nv_dia_chi, nv_gioi_tinh, nv_xoa, nv_ma_tai_khoan, tk_tai_khoan, tk_mat_khau, tk_dang_nhap_loi, lnv_ten, nv_ma_loai_nhan_vien
        from NhanVien, TaiKhoan, LoaiNhanVien
        where nv_ma_loai_nhan_vien = lnv_ma
        AND nv_ma_tai_khoan = tk_ma and nv_xoa = " + cbHienThiXoa.Checked.ToString().ToLower()
        dsNhanVien = XL_DuLieu.DocDuLieu(truy_van)
        dsNhanVienView = New DataView(dsNhanVien)
        dgvDanhSach.DataSource = dsNhanVienView
        dgvDanhSach.Columns(0).Visible = False
        dgvDanhSach.Columns(4).Visible = False
        dgvDanhSach.Columns(5).Visible = False
        dgvDanhSach.Columns(7).Visible = False
        dgvDanhSach.Columns(8).Visible = False
        dgvDanhSach.Columns("nv_ma_loai_nhan_vien").Visible = False

        dgvDanhSach.Columns(3).HeaderText = "Nam"
        dgvDanhSach.Columns("lnv_ten").HeaderText = "Loại NV"

    End Sub

    Private Sub frmNhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HienThiDSNhanVien()
        dsTaiKhoan = XL_DuLieu.DocCautruc("SELECT * FROM TaiKhoan")

        'Handle admin
        If Me.Tag = True Then
            lIsAdmin.Text = "Admin"
            cbLoaiNhanVien.Enabled = True
            bCapNhatRole.Enabled = True
        Else
            lIsAdmin.Text = "Non-Admin"
            cbLoaiNhanVien.Enabled = False
            bCapNhatRole.Enabled = False
        End If

        ' Tải danh sách Loại Nhân Viên và gán cho ComboBox
        dsLoaiNhanVien = XL_DuLieu.DocDuLieu("SELECT * FROM LoaiNhanVien")
        cbLoaiNhanVien.DataSource = dsLoaiNhanVien
        cbLoaiNhanVien.DisplayMember = "lnv_ten" ' Hiển thị Tên loại
        cbLoaiNhanVien.ValueMember = "lnv_ma"   ' Lấy giá trị ID loại
        'bPhucHoi.Enabled = False ' Mặc định nút Phục hồi bị tắt khi form load
    End Sub

    Private Sub bThem_Click(sender As Object, e As EventArgs) Handles bThem.Click
        Dim taiKhoan As DataRow = dsTaiKhoan.NewRow()
        taiKhoan("tk_tai_khoan") = tbTaiKhoan.Text
        taiKhoan("tk_mat_khau") = Util.getHash(tbMatKhau.Text)
        taiKhoan("tk_xoa") = False
        taiKhoan("tk_dang_nhap_loi") = 0

        dsTaiKhoan.Rows.Add(taiKhoan)
        XL_DuLieu.GhiDuLieu("TaiKhoan", dsTaiKhoan)

        Dim nhanVien As DataRow = dsNhanVien.NewRow()
        nhanVien("nv_ten") = tbTen.Text
        nhanVien("nv_dia_chi") = tbDiaChi.Text
        nhanVien("nv_gioi_tinh") = rbNam.Checked
        nhanVien("nv_xoa") = False
        nhanVien("nv_ma_tai_khoan") = taiKhoan("tk_ma")
        nhanVien("tk_tai_khoan") = taiKhoan("tk_tai_khoan")
        nhanVien("tk_mat_khau") = taiKhoan("tk_mat_khau")
        nhanVien("nv_ma_loai") = CInt(cbLoaiNhanVien.SelectedValue)


        dsNhanVien.Rows.Add(nhanVien)
        XL_DuLieu.GhiDuLieu("NhanVien", dsNhanVien)
        MessageBox.Show("Thêm nhân viên thành công", "Thong bao", MessageBoxButtons.OK)
        dsTaiKhoan.Rows.Remove(taiKhoan)
    End Sub

    Private Sub dgvDanhSach_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSach.CellContentClick
        'If dgvDanhSach.SelectedCells.Count > 0 Then
        '    Dim row As Integer = dgvDanhSach.SelectedCells(0).RowIndex
        '    Dim nhanVienView As DataRowView = dgvDanhSach.Rows(row).DataBoundItem
        '    Dim nhanVien As DataRow = nhanVienView.Row
        '    tbTen.Text = nhanVien("nv_ten")
        '    'cbLoainhanVien.SelectedIndex = cbLoainhanVien.FindStringExact(dgvDanhSach.Rows(row).Cells(3).Value.ToString())
        '    tbDiaChi.Text = nhanVien("nv_dia_chi")
        '    If nhanVien("nv_gioi_tinh") = True Then
        '        rbNam.Checked = True
        '    Else
        '        rbNu.Checked = True
        '    End If
        '    tbTaiKhoan.Text = nhanVien("tk_tai_khoan")
        'End If
    End Sub

    Private Sub bCapNhat_Click(sender As Object, e As EventArgs) Handles bCapNhat.Click
        If dgvDanhSach.SelectedCells.Count > 0 Then
            Dim row_index As Integer = dgvDanhSach.SelectedCells(0).RowIndex
            Dim nhanVienView As DataRowView = dgvDanhSach.Rows(row_index).DataBoundItem
            Dim nhanVien As DataRow = nhanVienView.Row

            If nhanVien("tk_tai_khoan") <> tbTaiKhoan.Text Then
                MessageBox.Show("Khong the cap nhat tai khoan : " + tbTaiKhoan.Text, "Thong bao", MessageBoxButtons.OK)
                Return
            End If

            nhanVien("nv_ten") = tbTen.Text
            nhanVien("nv_dia_chi") = tbDiaChi.Text
            nhanVien("nv_gioi_tinh") = rbNam.Checked
            nhanVien("tk_mat_khau") = Util.getHash(tbMatKhau.Text)
            nhanVien("nv_ma_loai_nhan_vien") = CInt(cbLoaiNhanVien.SelectedValue)

            XL_DuLieu.GhiDuLieu("nhanVien", dsNhanVien)

            dsTaiKhoan = XL_DuLieu.DocDuLieu("SELECT * FROM TaiKhoan where tk_ma = " + nhanVien("nv_ma_tai_khoan").ToString())
            Dim taiKhoan As DataRow = dsTaiKhoan.Rows(0)
            taiKhoan("tk_mat_khau") = nhanVien("tk_mat_khau")

            XL_DuLieu.GhiDuLieu("TaiKhoan", dsTaiKhoan)
            MessageBox.Show("Da cap nhat", "Thong bao", MessageBoxButtons.OK)
            dsTaiKhoan.Rows.Remove(taiKhoan)
        End If
        HienThiDSNhanVien()
    End Sub

    Private Sub bXoa_Click(sender As Object, e As EventArgs) Handles bXoa.Click
        If dgvDanhSach.SelectedCells.Count > 0 Then
            Dim row_index As Integer = dgvDanhSach.SelectedCells(0).RowIndex
            Dim nhanVienView As DataRowView = dgvDanhSach.Rows(row_index).DataBoundItem
            Dim nhanVien As DataRow = nhanVienView.Row

            Dim chuoi As String = String.Format("Ban co muon xoa nhan vien {0} khong?", nhanVien("nv_ten"))
            Dim luaChon As DialogResult = MessageBox.Show(chuoi, "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If luaChon = DialogResult.No Then
                Return
            End If
            nhanVien("nv_xoa") = True
            XL_DuLieu.GhiDuLieu("nhanVien", dsNhanVien)

            MessageBox.Show("Da xoa nhan vien", "Thong bao", MessageBoxButtons.OK)
            dsNhanVien.Rows.Remove(nhanVien)
            dgvDanhSach.Refresh()
        End If
    End Sub

    Private Sub cbHienThiXoa_CheckedChanged(sender As Object, e As EventArgs) Handles cbHienThiXoa.CheckedChanged
        HienThiDSNhanVien()

        If cbHienThiXoa.Checked Then
            'Check Admin Role
            If Me.Tag = True Then
                bPhucHoi.Enabled = True
            Else
                bPhucHoi.Enabled = False
            End If

            bThem.Enabled = False
            bCapNhat.Enabled = False
            bXoa.Enabled = False
        Else
            bPhucHoi.Enabled = False
            bThem.Enabled = True
            bCapNhat.Enabled = True
            bXoa.Enabled = True
        End If
    End Sub

    Private Sub bPhucHoi_Click(sender As Object, e As EventArgs) Handles bPhucHoi.Click
        If dgvDanhSach.SelectedCells.Count > 0 Then
            Dim row_index As Integer = dgvDanhSach.SelectedCells(0).RowIndex
            Dim nhanVienView As DataRowView = dgvDanhSach.Rows(row_index).DataBoundItem
            Dim nhanVien As DataRow = nhanVienView.Row
            Dim chuoi As String = String.Format("Ban co muon phuc hoi nhan vien {0} khong?", nhanVien("nv_ten"))
            Dim luaChon As DialogResult = MessageBox.Show(chuoi, "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If luaChon = DialogResult.No Then
                Return
            End If
            nhanVien("nv_xoa") = False
            XL_DuLieu.GhiDuLieu("nhanVien", dsNhanVien)
            MessageBox.Show("Da phuc hoi nhan vien", "Thong bao", MessageBoxButtons.OK)
            dsNhanVien.Rows.Remove(nhanVien)
            dgvDanhSach.Refresh()
        End If
    End Sub

    Private Sub tbTimKiem_TextChanged(sender As Object, e As EventArgs) Handles tbTimKiem.TextChanged
        If tbTimKiem.Text = "" Then
            dsNhanVienView.RowFilter = ""
        Else
            dsNhanVienView.RowFilter = String.Format("nv_ten LIKE '%{0}%' OR nv_dia_chi LIKE '%{0}%'", tbTimKiem.Text)
        End If
    End Sub

    Private Sub dgvDanhSach_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSach.CellClick
        If dgvDanhSach.SelectedCells.Count > 0 Then
            Dim row As Integer = dgvDanhSach.SelectedCells(0).RowIndex
            Dim nhanVienView As DataRowView = dgvDanhSach.Rows(row).DataBoundItem
            Dim nhanVien As DataRow = nhanVienView.Row
            tbTen.Text = nhanVien("nv_ten")
            'cbLoainhanVien.SelectedIndex = cbLoainhanVien.FindStringExact(dgvDanhSach.Rows(row).Cells(3).Value.ToString())
            tbDiaChi.Text = nhanVien("nv_dia_chi")
            If nhanVien("nv_gioi_tinh") = True Then
                rbNam.Checked = True
            Else
                rbNu.Checked = True
            End If
            tbTaiKhoan.Text = nhanVien("tk_tai_khoan")
            cbLoaiNhanVien.Text = nhanVien("lnv_ten")
        End If
    End Sub

    Private Sub bCapNhatRole_Click(sender As Object, e As EventArgs) Handles bCapNhatRole.Click
        If dgvDanhSach.SelectedCells.Count > 0 Then
            Dim row_index As Integer = dgvDanhSach.SelectedCells(0).RowIndex
            Dim nhanVienView As DataRowView = CType(dgvDanhSach.Rows(row_index).DataBoundItem, DataRowView)
            Dim nhanVien As DataRow = nhanVienView.Row

            Dim newRoleId As Integer = CInt(cbLoaiNhanVien.SelectedValue)
            Dim oldRoleId As Integer = CInt(nhanVien("nv_ma_loai_nhan_vien"))

            ' Kiểm tra xem Role có thực sự thay đổi không
            If newRoleId = oldRoleId Then
                MessageBox.Show("Vai trò chưa thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ' Cập nhật duy nhất trường nv_ma_loai_nhan_vien trong DataRow
            nhanVien("nv_ma_loai_nhan_vien") = newRoleId

            ' Ghi thay đổi vào Cơ sở dữ liệu (chỉ riêng cột này sẽ được cập nhật)
            XL_DuLieu.GhiDuLieu("NhanVien", dsNhanVien)

            MessageBox.Show("Cập nhật vai trò thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
        ' Hiển thị lại danh sách để cập nhật DataGridView
        HienThiDSNhanVien()
    End Sub
End Class