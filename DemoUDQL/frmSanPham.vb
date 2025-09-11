Public Class frmSanPham
    Dim dsSanPham As DataTable
    Dim dsSanPhamView As DataView
    Dim dsLoaiSanPham As DataTable

    Sub HienThiLoaiSanPham()
        Dim truy_van As String = "SELECT sp_ma, sp_code, sp_ten, lsp_ten, sp_mo_ta, sp_loai, sp_xoa FROM SanPham, LoaiSanPham where sp_loai = lsp_ma and sp_xoa = " + cbHienThiXoa.Checked.ToString().ToLower()
        dsSanPham = XL_DuLieu.DocDuLieu(truy_van)
        dsSanPhamView = New DataView(dsSanPham)
        dgvSanPham.DataSource = dsSanPhamView
        dgvSanPham.Columns(0).Visible = False
        dgvSanPham.Columns(5).Visible = False
        dgvSanPham.Columns(6).Visible = False

    End Sub
    Private Sub frmSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim truy_van As String = "SELECT * FROM LoaiSanPham where lsp_xoa = false"
        dsLoaiSanPham = XL_DuLieu.DocDuLieu(truy_van)
        cbLoaiSanPham.DataSource = dsLoaiSanPham
        cbLoaiSanPham.DisplayMember = "lsp_ten"
        cbLoaiSanPham.ValueMember = "lsp_ma"

        HienThiLoaiSanPham()
        bPhucHoi.Enabled = False
    End Sub

    Private Sub bThem_Click(sender As Object, e As EventArgs) Handles bThem.Click
        Dim sanPham As DataRow = dsSanPham.NewRow()
        sanPham("sp_code") = tbMa.Text
        sanPham("sp_ten") = tbTen.Text
        sanPham("sp_mo_ta") = tbMoTa.Text
        sanPham("sp_loai") = cbLoaiSanPham.Items(cbLoaiSanPham.SelectedIndex).Item("lsp_ma")
        sanPham("lsp_ten") = cbLoaiSanPham.Items(cbLoaiSanPham.SelectedIndex).Item("lsp_ten")
        sanPham("sp_xoa") = False
        dsSanPham.Rows.Add(sanPham)
        XL_DuLieu.GhiDuLieu("SanPham", dsSanPham)
        MessageBox.Show("Thêm sản phẩm thành công", "Thong bao", MessageBoxButtons.OK)
    End Sub

    Private Sub bCapNhat_Click(sender As Object, e As EventArgs) Handles bCapNhat.Click
        If dgvSanPham.SelectedCells.Count > 0 Then
            Dim row_index As Integer = dgvSanPham.SelectedCells(0).RowIndex
            Dim sanPhamView As DataRowView = dgvSanPham.Rows(row_index).DataBoundItem
            Dim sanPham As DataRow = sanPhamView.Row
            sanPham("sp_code") = tbMa.Text
            sanPham("sp_ten") = tbTen.Text
            sanPham("sp_mo_ta") = tbMoTa.Text
            sanPham("sp_loai") = cbLoaiSanPham.Items(cbLoaiSanPham.SelectedIndex).Item("lsp_ma")
            sanPham("lsp_ten") = cbLoaiSanPham.Items(cbLoaiSanPham.SelectedIndex).Item("lsp_ten")
            XL_DuLieu.GhiDuLieu("SanPham", dsSanPham)
            MessageBox.Show("Da cap nhat loai san pham", "Thong bao", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub bXoa_Click(sender As Object, e As EventArgs) Handles bXoa.Click
        If dgvSanPham.SelectedCells.Count > 0 Then
            Dim row_index As Integer = dgvSanPham.SelectedCells(0).RowIndex
            Dim sanPhamView As DataRowView = dgvSanPham.Rows(row_index).DataBoundItem
            Dim sanPham As DataRow = sanPhamView.Row
            Dim chuoi As String = String.Format("Ban co muon xoa san pham {0} khong?", sanPham("sp_ten"))
            Dim luaChon As DialogResult = MessageBox.Show(chuoi, "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If luaChon = DialogResult.No Then
                Return
            End If
            sanPham("sp_xoa") = True
            XL_DuLieu.GhiDuLieu("SanPham", dsSanPham)
            MessageBox.Show("Da xoa san pham", "Thong bao", MessageBoxButtons.OK)
            dsSanPham.Rows.Remove(sanPham)
            dgvSanPham.Refresh()
        End If
    End Sub

    Private Sub tbTimKiem_TextChanged(sender As Object, e As EventArgs) Handles tbTimKiem.TextChanged
        If tbTimKiem.Text = "" Then
            dsSanPhamView.RowFilter = ""
        Else
            dsSanPhamView.RowFilter = String.Format("sp_ten LIKE '%{0}%' OR sp_code LIKE '%{0}%'", tbTimKiem.Text)
        End If
    End Sub

    Private Sub dgvSanPham_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSanPham.CellClick
        If dgvSanPham.SelectedCells.Count > 0 Then
            Dim row As Integer = dgvSanPham.SelectedCells(0).RowIndex
            Dim sanPhamView As DataRowView = dgvSanPham.Rows(row).DataBoundItem
            Dim sanPham As DataRow = sanPhamView.Row
            tbMa.Text = dgvSanPham.Rows(row).Cells(1).Value.ToString()
            tbTen.Text = dgvSanPham.Rows(row).Cells(2).Value.ToString()
            'cbLoaiSanPham.SelectedIndex = cbLoaiSanPham.FindStringExact(dgvSanPham.Rows(row).Cells(3).Value.ToString())
            tbMoTa.Text = dgvSanPham.Rows(row).Cells(4).Value.ToString()
            cbLoaiSanPham.SelectedValue = sanPham("sp_loai")
        End If
    End Sub

    Private Sub cbHienThiXoa_CheckedChanged(sender As Object, e As EventArgs) Handles cbHienThiXoa.CheckedChanged
        HienThiLoaiSanPham()

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
        If dgvSanPham.SelectedCells.Count > 0 Then
            Dim row_index As Integer = dgvSanPham.SelectedCells(0).RowIndex
            Dim sanPhamView As DataRowView = dgvSanPham.Rows(row_index).DataBoundItem
            Dim sanPham As DataRow = sanPhamView.Row
            Dim chuoi As String = String.Format("Ban co muon phuc hoi san pham {0} khong?", sanPham("sp_ten"))
            Dim luaChon As DialogResult = MessageBox.Show(chuoi, "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If luaChon = DialogResult.No Then
                Return
            End If
            sanPham("sp_xoa") = False
            XL_DuLieu.GhiDuLieu("SanPham", dsSanPham)
            MessageBox.Show("Da phuc hoi san pham", "Thong bao", MessageBoxButtons.OK)
            dsSanPham.Rows.Remove(sanPham)
            dgvSanPham.Refresh()
        End If
    End Sub
End Class