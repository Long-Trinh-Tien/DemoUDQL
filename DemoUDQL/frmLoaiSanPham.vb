Public Class frmLoaiSanPham
    Private dsLoaiSanPham As DataTable
    Private Sub frmLoaiSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim truy_van As String = "SELECT * FROM LoaiSanPham where lsp_xoa = false"
        dsLoaiSanPham = XL_DuLieu.DocDuLieu(truy_van)
        dgvLoaiSanPham.DataSource = dsLoaiSanPham
        dgvLoaiSanPham.Columns(0).Visible = False
        dgvLoaiSanPham.Columns(4).Visible = False
        dgvLoaiSanPham.Columns(1).HeaderText = "Ma"
        dgvLoaiSanPham.Columns(2).HeaderText = "Ten"
        dgvLoaiSanPham.Columns(3).HeaderText = "Mo Ta"
    End Sub

    Private Sub bThem_Click(sender As Object, e As EventArgs) Handles bThem.Click
        Dim LoaiSanPham As DataRow = dsLoaiSanPham.NewRow()
        LoaiSanPham("lsp_code") = tbMa.Text
        LoaiSanPham("lsp_ten") = tbTen.Text
        LoaiSanPham("lsp_mo_ta") = tbMoTa.Text
        LoaiSanPham("lsp_xoa") = False
        dsLoaiSanPham.Rows.Add(LoaiSanPham)
        XL_DuLieu.GhiDuLieu("LoaiSanPham", dsLoaiSanPham)
        MessageBox.Show("Da them loai san pham", "Thong bao", MessageBoxButtons.OK)
        dgvLoaiSanPham.Refresh()
    End Sub

    Private Sub dgvLoaiSanPham_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLoaiSanPham.CellClick
        If dgvLoaiSanPham.SelectedCells.Count > 0 Then
            Dim row_index As Integer = dgvLoaiSanPham.SelectedCells(0).RowIndex
            tbMa.Text = dgvLoaiSanPham.Rows(row_index).Cells(1).Value.ToString()
            tbTen.Text = dgvLoaiSanPham.Rows(row_index).Cells(2).Value.ToString()
            tbMoTa.Text = dgvLoaiSanPham.Rows(row_index).Cells(3).Value.ToString()
        End If
    End Sub

    Private Sub bCapNhat_Click(sender As Object, e As EventArgs) Handles bCapNhat.Click
        If dgvLoaiSanPham.SelectedCells.Count > 0 Then
            Dim row_index As Integer = dgvLoaiSanPham.SelectedCells(0).RowIndex
            Dim loaiSanPhamView As DataRowView = dgvLoaiSanPham.Rows(row_index).DataBoundItem
            Dim loaiSanPham As DataRow = loaiSanPhamView.Row
            loaiSanPham("lsp_code") = tbMa.Text
            loaiSanPham("lsp_ten") = tbTen.Text
            loaiSanPham("lsp_mo_ta") = tbMoTa.Text
            XL_DuLieu.GhiDuLieu("LoaiSanPham", dsLoaiSanPham)
            MessageBox.Show("Da cap nhat loai san pham", "Thong bao", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub bXoa_Click(sender As Object, e As EventArgs) Handles bXoa.Click
        If dgvLoaiSanPham.SelectedCells.Count > 0 Then
            Dim row_index As Integer = dgvLoaiSanPham.SelectedCells(0).RowIndex
            Dim loaiSanPhamView As DataRowView = dgvLoaiSanPham.Rows(row_index).DataBoundItem
            Dim loaiSanPham As DataRow = loaiSanPhamView.Row
            loaiSanPham("lsp_xoa") = True
            XL_DuLieu.GhiDuLieu("LoaiSanPham", dsLoaiSanPham)
            MessageBox.Show("Da xoa loai san pham", "Thong bao", MessageBoxButtons.OK)
            dsLoaiSanPham.Rows.Remove(loaiSanPham)
            dgvLoaiSanPham.Refresh()
        End If
    End Sub
End Class