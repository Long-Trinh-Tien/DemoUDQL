Public Class frmKhachHang

    ' Khai báo biến cần thiết
    Dim dsKhachHang As DataTable
    Dim dsKhachHangView As DataView

    ' --- PHƯƠNG THỨC HIỂN THỊ DỮ LIỆU ---
    Sub HienThiDSKhachHang()
        ' Truy vấn lấy tất cả thông tin Khách Hàng.
        ' Sử dụng String.Format cho truy vấn để tránh lỗi boolean
        Dim isDeleted As String = cbHienThiXoa.Checked.ToString().ToLower()
        ' Đảm bảo rằng True/False được đặt trong dấu ' ' nếu CSDL yêu cầu (ví dụ: MS Access Yes/No field)
        ' Nhưng theo phong cách mã cũ, tôi sẽ giữ nguyên .ToLower() và giả định CSDL hiểu.

        Dim truy_van As String = String.Format("SELECT kh_ma, kh_code, kh_ten, kh_dien_thoai, kh_dia_chi, kh_xoa from KhachHang where kh_xoa = {0}", isDeleted)

        dsKhachHang = XL_DuLieu.DocDuLieu(truy_van)
        dsKhachHangView = New DataView(dsKhachHang)
        dgvDanhSach.DataSource = dsKhachHangView

        ' Ẩn các cột không cần hiển thị trên DataGridView
        If dgvDanhSach.Columns.Contains("kh_ma") Then dgvDanhSach.Columns("kh_ma").Visible = False
        If dgvDanhSach.Columns.Contains("kh_xoa") Then dgvDanhSach.Columns("kh_xoa").Visible = False

        ' Đổi tên Header cho dễ nhìn
        If dgvDanhSach.Columns.Contains("kh_code") Then dgvDanhSach.Columns("kh_code").HeaderText = "Mã KH"
        If dgvDanhSach.Columns.Contains("kh_ten") Then dgvDanhSach.Columns("kh_ten").HeaderText = "Tên Khách Hàng"
        If dgvDanhSach.Columns.Contains("kh_dien_thoai") Then dgvDanhSach.Columns("kh_dien_thoai").HeaderText = "Điện Thoại"
        If dgvDanhSach.Columns.Contains("kh_dia_chi") Then dgvDanhSach.Columns("kh_dia_chi").HeaderText = "Địa Chỉ"

    End Sub

    ' --- XỬ LÝ SỰ KIỆN FORM LOAD ---
    Private Sub frmKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HienThiDSKhachHang()
        bPhucHoi.Enabled = False ' Mặc định nút phục hồi bị khóa
    End Sub

    ' --- NÚT THÊM KHÁCH HÀNG ---
    Private Sub bThem_Click(sender As Object, e As EventArgs) Handles bThem.Click
        If tbCode.Text.Trim() = "" Or tbTen.Text.Trim() = "" Then
            MessageBox.Show("Vui lòng nhập Mã và Tên khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' 1. Tạo hàng dữ liệu mới trong DataTable
        Dim khachHang As DataRow = dsKhachHang.NewRow()

        ' 2. Gán giá trị từ TextBox và các Control khác
        khachHang("kh_code") = tbCode.Text ' SỬA TÊN CONTROL
        khachHang("kh_ten") = tbTen.Text
        khachHang("kh_dien_thoai") = tbDienThoai.Text
        khachHang("kh_dia_chi") = tbDiaChi.Text
        khachHang("kh_xoa") = False ' Mặc định chưa xóa

        ' 3. Thêm vào DataTable và ghi xuống CSDL
        dsKhachHang.Rows.Add(khachHang)
        XL_DuLieu.GhiDuLieu("KhachHang", dsKhachHang) ' Ghi vào bảng KhachHang

        MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK)

        ' **FIX LOGIC: Cần gọi lại HienThiDSKhachHang() hoặc Clear các trường nhập liệu**
        HienThiDSKhachHang()
        ClearInputFields()
    End Sub

    ' --- NÚT CẬP NHẬT KHÁCH HÀNG ---
    Private Sub bCapNhat_Click(sender As Object, e As EventArgs) Handles bCapNhat.Click
        If dgvDanhSach.SelectedCells.Count > 0 Then
            Dim row_index As Integer = dgvDanhSach.SelectedCells(0).RowIndex
            Dim khachHangView As DataRowView = dgvDanhSach.Rows(row_index).DataBoundItem
            Dim khachHang As DataRow = khachHangView.Row

            ' 1. Cập nhật các trường thông tin
            khachHang("kh_code") = tbCode.Text ' Thêm cập nhật Code
            khachHang("kh_ten") = tbTen.Text
            khachHang("kh_dien_thoai") = tbDienThoai.Text
            khachHang("kh_dia_chi") = tbDiaChi.Text

            ' 2. Ghi dữ liệu xuống CSDL (chỉ ghi bảng KhachHang)
            XL_DuLieu.GhiDuLieu("KhachHang", dsKhachHang)

            MessageBox.Show("Đã cập nhật khách hàng", "Thông báo", MessageBoxButtons.OK)
            ' **FIX LOGIC: Đảm bảo DataGridView làm mới để hiển thị giá trị cập nhật**
            dgvDanhSach.Refresh()
        End If
    End Sub

    ' --- NÚT XÓA (Xóa mềm bằng cách đặt kh_xoa = True) ---
    Private Sub bXoa_Click(sender As Object, e As EventArgs) Handles bXoa.Click
        If dgvDanhSach.SelectedCells.Count > 0 Then
            Dim row_index As Integer = dgvDanhSach.SelectedCells(0).RowIndex
            Dim khachHangView As DataRowView = dgvDanhSach.Rows(row_index).DataBoundItem
            Dim khachHang As DataRow = khachHangView.Row

            Dim chuoi As String = String.Format("Bạn có muốn xóa khách hàng {0} không?", khachHang("kh_ten"))
            Dim luaChon As DialogResult = MessageBox.Show(chuoi, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If luaChon = DialogResult.No Then Return

            ' Xóa mềm: đặt cờ xóa = True
            khachHang("kh_xoa") = True
            XL_DuLieu.GhiDuLieu("KhachHang", dsKhachHang)

            MessageBox.Show("Đã xóa khách hàng", "Thông báo", MessageBoxButtons.OK)

            ' Tùy chọn: Xóa khỏi DataView nếu không hiển thị các bản ghi đã xóa
            If cbHienThiXoa.Checked = False Then
                ' **FIX LOGIC: Sử dụng Delete() trên DataRowView để xóa khỏi View mà không xóa khỏi DataTable**
                khachHangView.Delete()
            End If

            ' **FIX LOGIC: Làm sạch các trường nhập liệu sau khi xóa**
            ClearInputFields()
            dgvDanhSach.Refresh()
        End If
    End Sub

    ' --- NÚT PHỤC HỒI KHÁCH HÀNG ---
    Private Sub bPhucHoi_Click(sender As Object, e As EventArgs) Handles bPhucHoi.Click
        If dgvDanhSach.SelectedCells.Count > 0 Then
            Dim row_index As Integer = dgvDanhSach.SelectedCells(0).RowIndex
            Dim khachHangView As DataRowView = dgvDanhSach.Rows(row_index).DataBoundItem
            Dim khachHang As DataRow = khachHangView.Row

            Dim chuoi As String = String.Format("Bạn có muốn phục hồi khách hàng {0} không?", khachHang("kh_ten"))
            Dim luaChon As DialogResult = MessageBox.Show(chuoi, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If luaChon = DialogResult.No Then Return

            ' Phục hồi: đặt cờ xóa = False
            khachHang("kh_xoa") = False
            XL_DuLieu.GhiDuLieu("KhachHang", dsKhachHang)

            MessageBox.Show("Đã phục hồi khách hàng", "Thông báo", MessageBoxButtons.OK)

            ' Xóa khỏi DataView (vì đã phục hồi, nó sẽ không còn thuộc nhóm bị xóa)
            khachHangView.Delete() ' FIX LOGIC: Sử dụng Delete() trên DataRowView

            ClearInputFields()
            dgvDanhSach.Refresh()
        End If
    End Sub

    ' --- THAY ĐỔI CHECKBOX HIỂN THỊ XÓA ---
    Private Sub cbHienThiXoa_CheckedChanged(sender As Object, e As EventArgs) Handles cbHienThiXoa.CheckedChanged
        HienThiDSKhachHang() ' Tải lại dữ liệu theo trạng thái mới
        ClearInputFields() ' Làm sạch form nhập liệu

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

    ' --- TÌM KIẾM THEO TÊN/ĐỊA CHỈ ---
    Private Sub tbTimKiem_TextChanged(sender As Object, e As EventArgs) Handles tbTimKiem.TextChanged
        If tbTimKiem.Text.Trim() = "" Then
            dsKhachHangView.RowFilter = ""
        Else
            ' Lọc theo Tên, Mã Code hoặc Địa chỉ (sử dụng OR)
            ' SỬA LỖI: Thêm Trim() để xử lý ký tự trắng thừa
            Dim filterText As String = tbTimKiem.Text.Trim()
            dsKhachHangView.RowFilter = String.Format("kh_ten LIKE '%{0}%' OR kh_code LIKE '%{0}%' OR kh_dia_chi LIKE '%{0}%'", filterText)
        End If
    End Sub

    ' --- HIỂN THỊ CHI TIẾT KHI CLICK VÀO HÀNG ---
    Private Sub dgvDanhSach_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSach.CellClick
        If e.RowIndex >= 0 Then ' Thêm kiểm tra tránh click vào header
            Dim khachHangView As DataRowView = dgvDanhSach.Rows(e.RowIndex).DataBoundItem

            If khachHangView IsNot Nothing Then
                Dim khachHang As DataRow = khachHangView.Row

                ' Hiển thị dữ liệu lên các TextBox
                ' **SỬA LỖI: Đồng bộ tên Control: tbMaCode -> tbCode**
                tbCode.Text = khachHang("kh_code").ToString()
                tbTen.Text = khachHang("kh_ten").ToString()
                tbDienThoai.Text = khachHang("kh_dien_thoai").ToString()
                tbDiaChi.Text = khachHang("kh_dia_chi").ToString()
            End If
        End If
    End Sub

    ' --- THÊM SUB ROUTINE ĐỂ LÀM SẠCH TRƯỜNG NHẬP LIỆU ---
    Private Sub ClearInputFields()
        tbCode.Clear()
        tbTen.Clear()
        tbDienThoai.Clear()
        tbDiaChi.Clear()
        tbCode.Focus()
    End Sub

End Class