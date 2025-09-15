Public Class frmNhanVien

    Dim dsNhanVien As DataTable
    Dim dsNhanVienView As DataView
    Dim dsTaiKhoan As DataTable
    Sub HienThiDSNhanVien()
        Dim truy_van As String = "SELECT nv_ma, nv_ten, nv_dia_chi, nv_gioi_tinh, nv_xoa, nv_ma_tai_khoan, tk_tai_khoan, tk_mat_khau from NhanVien, TaiKhoan where nv_ma_tai_khoan = tk_ma and nv_xoa = " + cbHienThiXoa.Checked.ToString().ToLower()
        dsNhanVien = XL_DuLieu.DocDuLieu(truy_van)
        dsNhanVienView = New DataView(dsNhanVien)
        dgvDanhSach.DataSource = dsNhanVienView
        dgvDanhSach.Columns(0).Visible = False
        dgvDanhSach.Columns(4).Visible = False
        dgvDanhSach.Columns(5).Visible = False
        dgvDanhSach.Columns(7).Visible = False

        dgvDanhSach.Columns(3).HeaderText = "Nam"

    End Sub

    Private Sub frmNhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HienThiDSNhanVien()
        dsTaiKhoan = XL_DuLieu.DocCautruc("SELECT * FROM TaiKhoan")
    End Sub

    Private Sub bThem_Click(sender As Object, e As EventArgs) Handles bThem.Click
        Dim taiKhoan As DataRow = dsTaiKhoan.NewRow()
        taiKhoan("tk_tai_khoan") = tbTaiKhoan.Text
        taiKhoan("tk_mat_khau") = Util.getHash(tbMatKhau.Text)
        taiKhoan("tk_xoa") = False

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

        dsNhanVien.Rows.Add(nhanVien)
        XL_DuLieu.GhiDuLieu("NhanVien", dsNhanVien)
        MessageBox.Show("Thêm nhân viên thành công", "Thong bao", MessageBoxButtons.OK)
        dsTaiKhoan.Rows.Remove(taiKhoan)
    End Sub

    Private Sub dgvDanhSach_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSach.CellContentClick
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
        End If
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

            XL_DuLieu.GhiDuLieu("nhanVien", dsNhanVien)

            dsTaiKhoan = XL_DuLieu.DocDuLieu("SELECT * FROM TaiKhoan where tk_ma = " + nhanVien("nv_ma_tai_khoan").ToString())
            Dim taiKhoan As DataRow = dsTaiKhoan.Rows(0)
            taiKhoan("tk_mat_khau") = nhanVien("tk_mat_khau")

            XL_DuLieu.GhiDuLieu("TaiKhoan", dsTaiKhoan)
            MessageBox.Show("Da cap nhat", "Thong bao", MessageBoxButtons.OK)
            dsTaiKhoan.Rows.Remove(taiKhoan)
        End If
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
            bPhucHoi.Enabled = True

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
End Class