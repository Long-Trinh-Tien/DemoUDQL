Public Class frmTonKho
    Public nhanVien As DataRow
    Dim dsChiNhanh As DataTable

    Private Sub frmTonKho_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Khởi tạo tạm nhân viên (Tương tự frmBanHang)
        Dim dsNhanVien As DataTable = XL_DuLieu.DocCautruc("SELECT * FROM NhanVien where nv_xoa = false")
        nhanVien = dsNhanVien.NewRow()
        nhanVien("nv_ma") = 1 ' Giả sử NV có mã 1

        HienThiDSChiNhanh()
        HienThiDSTonKho() ' Thay thế HienThiDSDonHang
    End Sub

    Sub HienThiDSChiNhanh()
        ' Lấy danh sách chi nhánh mà nhân viên đang làm việc dựa trên ngày hiện tại
        Dim str As String = String.Format(
            "SELECT distinct cn_ma ,cn_ten, nvcn_ngay_ap_dung from ChiNhanh, NhanVienChiNhanh
            where nvcn_chi_nhanh = cn_ma and nvcn_nhan_vien = {0} and nvcn_ngay_ap_dung <= #{1}#",
            nhanVien("nv_ma"), dtpNgayHienTai.Value.ToString("yyyy-MM-dd"))
        dsChiNhanh = XL_DuLieu.DocDuLieu(str)
        cbChiNhanh.ValueMember = "cn_ma"
        cbChiNhanh.DisplayMember = "cn_ten"
        cbChiNhanh.DataSource = dsChiNhanh
    End Sub

    Public Sub HienThiDSTonKho_TimKiem()
        If cbChiNhanh.SelectedIndex < 0 Then
            Return
        End If

        Dim tenSPTimKiem As String = tbTimKiem.Text.Trim()
        Dim searchCondition As String = ""

        ' Tim kiem theo ten san pham hoac ma san pham
        If Not String.IsNullOrEmpty(tenSPTimKiem) Then
            searchCondition = String.Format(" AND (sp_ten LIKE '%{0}%' OR CStr(sp_code) LIKE '%{0}%')", tenSPTimKiem)
        End If

        ' Truy vấn lấy tồn kho theo Chi nhánh và Ngày (chỉ lấy tồn kho hiện tại)
        ' *Lưu ý: Bảng TonKho không có trường ngày, nên ta chỉ lấy dữ liệu tồn kho hiện tại và lọc theo Chi nhánh
        Dim str As String = String.Format(
        "SELECT TonKho.*, SanPham.sp_ten, SanPham.sp_code
        FROM TonKho, SanPham
        WHERE TonKho.tk_san_pham = SanPham.sp_ma 
        AND TonKho.tk_chi_nhanh = {0} AND TonKho.tk_xoa = false {1}
        ORDER BY SanPham.sp_ten",
        cbChiNhanh.SelectedValue, searchCondition)

        dgvDSTonKho.DataSource = XL_DuLieu.DocDuLieu(str) ' Giả sử tên DataGridView là dgvDSTonKho
    End Sub

    Public Sub HienThiDSTonKho()
        If cbChiNhanh.SelectedIndex < 0 Then
            Return
        End If

        ' Truy vấn lấy tồn kho hiện tại theo Chi nhánh
        Dim str As String = String.Format(
            "SELECT TonKho.*, SanPham.sp_ten, SanPham.sp_code
            FROM TonKho, SanPham
            WHERE TonKho.tk_san_pham = SanPham.sp_ma 
            AND TonKho.tk_chi_nhanh = {0} AND TonKho.tk_xoa = false
            ORDER BY SanPham.sp_ten",
            cbChiNhanh.SelectedValue)

        dgvDSTonKho.DataSource = XL_DuLieu.DocDuLieu(str) ' Giả sử tên DataGridView là dgvDSTonKho
    End Sub

    ' --- Xử lý sự kiện ---

    Private Sub dtpNgayHienTai_ValueChanged(sender As Object, e As EventArgs) Handles dtpNgayHienTai.ValueChanged
        ' Ở form Tồn Kho, việc thay đổi ngày chỉ cần cập nhật danh sách Chi Nhánh 
        ' (vì Chi nhánh làm việc có thể thay đổi theo ngày)
        HienThiDSChiNhanh()
        HienThiDSTonKho() ' Hiển thị lại tồn kho cho Chi nhánh mới
    End Sub

    Private Sub cbChiNhanh_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbChiNhanh.SelectedIndexChanged
        ' Khi chọn Chi nhánh khác, cần hiển thị lại danh sách Tồn kho của Chi nhánh đó
        HienThiDSTonKho()
    End Sub

    Private Sub tbTimKiem_TextChanged(sender As Object, e As EventArgs) Handles tbTimKiem.TextChanged
        ' Khi gõ tìm kiếm, gọi hàm tìm kiếm có điều kiện
        HienThiDSTonKho_TimKiem()
    End Sub

    Private Sub bTao_Click(sender As Object, e As EventArgs) Handles bTao.Click
        If cbChiNhanh.SelectedIndex < 0 Then
            MessageBox.Show("Chưa có chi nhánh nào được chọn.", "Thông báo", MessageBoxButtons.OK)
            Return
        End If

        ' Nút 'Tạo' trong form Tồn Kho thường dùng để tạo Phiếu Nhập hàng (nhập kho) 
        ' Hoặc Phiếu Điều chỉnh Tồn kho (kiểm kê)

        ' *Giả sử bạn muốn tạo Phiếu Nhập hàng (vì nó là thao tác thay đổi tồn kho chủ yếu)*
        Dim chi_nhanh_hien_tai As DataRow = dsChiNhanh.Rows(cbChiNhanh.SelectedIndex)

        ' Cần mở một Form khác (ví dụ: frmPhieuNhap) để nhập chi tiết
        Dim frm As frmNhapHang = New frmNhapHang()
        frm.chi_nhanh = chi_nhanh_hien_tai
        frm.ngay = dtpNgayHienTai.Value
        frm.Loai = 1 ' Loai 1: Tạo mới
        frm.Tag = Me
        frm.Show()

        'MessageBox.Show("Chức năng Tạo Phiếu Nhập (hoặc Phiếu Điều chỉnh Tồn kho) cần mở form tương ứng.", "Thông báo", MessageBoxButtons.OK)

    End Sub

    Private Sub bCapNhat_Click(sender As Object, e As EventArgs) Handles bCapNhat.Click
        ' Nút 'Cập nhật' trong form Tồn Kho thường dùng để chỉnh sửa thông tin tồn kho 
        ' (ví dụ: thay đổi giá vốn, số lượng tồn kho) hoặc mở phiếu đã nhập/điều chỉnh để sửa.

        If dgvDSTonKho.SelectedCells.Count <= 0 Then
            MessageBox.Show("Vui lòng chọn một dòng Tồn kho để cập nhật.", "Thông báo", MessageBoxButtons.OK)
            Return
        End If

        Dim tkv As DataRowView = dgvDSTonKho.Rows(dgvDSTonKho.SelectedCells(0).RowIndex).DataBoundItem
        Dim ton_kho_hien_tai As DataRow = tkv.Row
        Dim chi_nhanh_hien_tai As DataRow = dsChiNhanh.Rows(cbChiNhanh.SelectedIndex)

        ' Cần mở một Form khác (ví dụ: frmChiTietTonKho) để chỉnh sửa
        Dim frm As frmNhapHang = New frmNhapHang()
        frm.chi_nhanh = chi_nhanh_hien_tai
        frm.phieu_nhap_hang = ton_kho_hien_tai
        frm.ngay = dtpNgayHienTai.Value
        frm.Loai = 2 ' Loai 2: Cập nhật
        frm.Tag = Me
        frm.Show()

        'MessageBox.Show("Chức năng Cập nhật Tồn kho (hoặc sửa Phiếu Nhập/Điều chỉnh) cần mở form tương ứng.", "Thông báo", MessageBoxButtons.OK)
    End Sub
End Class