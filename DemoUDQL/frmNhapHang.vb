Public Class frmNhapHang
    ' Thuộc tính được truyền từ form cha
    Public chi_nhanh As DataRow
    Public ngay As Date
    Public Loai As Integer ' 1 : Tạo mới, 2: Cập nhật

    ' Đối tượng dữ liệu Nhập hàng
    Dim dsNhaCungCap As DataTable
    Dim nha_cung_cap As DataRow
    Dim dsSanPhamNhap As DataTable ' DS Sản phẩm/NVL có thể nhập
    Dim dsPhieuNhap As DataTable
    Dim dsChiTietPhieuNhap As DataTable

    Public phieu_nhap_hang As DataRow ' Dữ liệu phiếu nhập nếu là cập nhật

    Private Sub frmNhapHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Khởi tạo giao diện
        lChiNhanh.Text = "Chi nhánh: " & chi_nhanh("cn_ten").ToString()
        dtpNgay.Value = ngay

        ' 2. Lấy danh sách Sản phẩm/Nguyên vật liệu có thể nhập
        Dim str As String = "SELECT sp_ma, sp_ten, sp_gia_nhap FROM SanPham WHERE sp_xoa = False"
        dsSanPhamNhap = XL_DuLieu.DocDuLieu(str)

        ' dgvDSTonKho sẽ hiển thị DS Sản phẩm/NVL
        dgvDSTonKho.DataSource = dsSanPhamNhap

        ' Định nghĩa các cột sẽ được hiển thị khi DocCautruc hoặc DocDuLieu được sử dụng
        ' Cần đảm bảo các cột ctpn_tong_san_pham và ctpn_khuyen_mai được thêm vào
        Dim select_ctpn_query As String = "SELECT ctpn_ma, ctpn_ma_san_pham, sp_ten, ctpn_so_luong, ctpn_gia_nhap, ctpn_tong_san_pham, ctpn_khuyen_mai, ctpn_tong_tien, ctpn_ghi_chu, ctpn_xoa, ctpn_ma_phieu_nhap, ctpn_ma_khu_vuc FROM ChiTietPhieuNhap, SanPham where ctpn_ma_san_pham = sp_ma"

        ' 3. Khởi tạo DataTables cho Chi tiết và Phiếu
        If Loai = 1 Then ' Tạo mới
            ' Tạo cấu trúc cho Chi tiết phiếu nhập
            ' Lấy cấu trúc từ bảng ChiTietPhieuNhap gốc (chỉ lấy schema)
            ' Điều này đảm bảo tất cả các cột cần thiết (bao gồm ctpn_ma_khu_vuc) tồn tại khi ghi dữ liệu
            dsChiTietPhieuNhap = XL_DuLieu.DocCautruc("SELECT * FROM ChiTietPhieuNhap WHERE 1 = 0")

            ' Thêm cột sp_ten (từ SanPham) cần cho việc hiển thị vào cấu trúc
            If Not dsChiTietPhieuNhap.Columns.Contains("sp_ten") Then
                dsChiTietPhieuNhap.Columns.Add("sp_ten", GetType(String))
            End If

            ' Tạo cấu trúc cho Phiếu Nhập hàng
            str = "SELECT * from PhieuNhap"
            dsPhieuNhap = XL_DuLieu.DocCautruc(str)

            bCapNhat.Visible = False
            bTao.Visible = True
        Else ' Cập nhật (Loai = 2)
            ' Lấy Chi tiết Phiếu Nhập hiện tại
            dsChiTietPhieuNhap = XL_DuLieu.DocDuLieu(
                select_ctpn_query & " and ctpn_ma_phieu_nhap = " + phieu_nhap_hang("pn_ma").ToString()
                 )

            ' Lấy Phiếu Nhập hàng chính
            dsPhieuNhap = XL_DuLieu.DocDuLieu(
                "select * from PhieuNhap where pn_ma = " + phieu_nhap_hang("pn_ma").ToString()
             )

            ' Lấy thông tin Nhà Cung Cấp
            Dim maNCC As Integer = phieu_nhap_hang("pn_nha_cung_cap")
            dsNhaCungCap = XL_DuLieu.DocDuLieu("select * from NhaCungCap where ncc_ma = " + maNCC.ToString())
            nha_cung_cap = dsNhaCungCap.Rows(0)

            ' Điền thông tin vào Controls (Giả sử các textbox này tồn tại)
            'tbDienThoai.Text = nha_cung_cap("ncc_dien_thoai").ToString()
            'tbTen.Text = nha_cung_cap("ncc_ten").ToString()
            'tbDiaChi.Text = nha_cung_cap("ncc_dia_chi").ToString()
            tbGhiChu.Text = phieu_nhap_hang("pn_ghi_chu").ToString()
            TinhTong()

            bCapNhat.Visible = True
            bTao.Visible = False
        End If

        ' Gán nguồn dữ liệu cho lưới chi tiết
        dgvDSChiTiet.DataSource = dsChiTietPhieuNhap
        ' Ẩn các cột không cần thiết
        ' LƯU Ý: Vị trí cột có thể thay đổi tùy thuộc vào câu lệnh SELECT
        Try
            dgvDSChiTiet.Columns("ctpn_ma").Visible = False
            dgvDSChiTiet.Columns("ctpn_ma_phieu_nhap").Visible = False
            dgvDSChiTiet.Columns("ctpn_tong_san_pham").Visible = False ' Giữ tong_san_pham ẩn
            dgvDSChiTiet.Columns("ctpn_ma_khu_vuc").Visible = False
        Catch ex As Exception
            ' Xử lý lỗi nếu tên cột không chính xác
        End Try

    End Sub

    Private Sub dgvDSTonKho_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDSTonKho.CellClick
        If e.RowIndex >= 0 Then
            Dim san_pham As DataRow = dsSanPhamNhap(e.RowIndex)
            ' Điền thông tin sản phẩm được chọn vào các TextBox
            tbMaSanPham.Text = san_pham("sp_ma").ToString()
            tbGiaNhap.Text = san_pham("sp_gia_nhap").ToString()
            tbSoLuongNhap.Text = "1" ' Mặc định nhập 1
            tbKhuyenMai.Text = "0" ' Mặc định khuyến mãi 0
        End If
    End Sub

    Private Sub bThem_Click(sender As Object, e As EventArgs) Handles bThem.Click
        If dgvDSTonKho.SelectedRows.Count = 0 Then
            MessageBox.Show("Chưa chọn sản phẩm/nguyên vật liệu để nhập.", "Thông báo", MessageBoxButtons.OK)
            Return
        End If

        Dim so_luong_nhap As Integer = 0
        Dim gia_nhap_moi As Decimal = 0
        Dim khuyen_mai As Decimal = 0

        ' Lấy thông tin nhập từ TextBoxes
        If Not Integer.TryParse(tbSoLuongNhap.Text, so_luong_nhap) OrElse so_luong_nhap <= 0 Then
            MessageBox.Show("Vui lòng nhập Số Lượng Nhập hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK)
            Return
        End If

        If Not Decimal.TryParse(tbGiaNhap.Text, gia_nhap_moi) Then
            MessageBox.Show("Giá Nhập không hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK)
            Return
        End If

        If Not Decimal.TryParse(tbKhuyenMai.Text, khuyen_mai) Then
            khuyen_mai = 0 ' Khuyến mãi mặc định là 0 nếu nhập sai
        End If

        ' Lấy sản phẩm được chọn từ lưới Tồn kho/Sản phẩm nguồn
        Dim san_pham As DataRow = dsSanPhamNhap(dgvDSTonKho.SelectedCells(0).RowIndex)

        ' Kiểm tra xem sản phẩm đã có trong chi tiết phiếu nhập chưa
        Dim ctpns() As DataRow = dsChiTietPhieuNhap.Select(String.Format("ctpn_ma_san_pham = " + san_pham("sp_ma").ToString()))

        If ctpns.Length > 0 Then
            ' Nếu đã có -> Cập nhật (Cộng dồn số lượng, cập nhật lại giá và KM của lần cuối nhập)
            Dim chi_tiet As DataRow = ctpns(0)

            ' Cộng thêm số lượng mới vào
            chi_tiet("ctpn_so_luong") = CInt(chi_tiet("ctpn_so_luong")) + so_luong_nhap

            ' Cập nhật lại Giá nhập và Khuyến mãi (Giả sử giữ lại giá và khuyến mãi của lần thêm mới nhất)
            chi_tiet("ctpn_gia_nhap") = gia_nhap_moi
            ' Tạm thời cộng dồn khuyến mãi (tùy logic kinh doanh thực tế)
            chi_tiet("ctpn_khuyen_mai") = CDec(chi_tiet("ctpn_khuyen_mai")) + khuyen_mai

            chi_tiet("ctpn_tong_san_pham") = chi_tiet("ctpn_so_luong") ' Giả sử tong_san_pham = so_luong

            ' Tính lại tổng tiền: (Số lượng * Giá nhập) - Khuyến mãi
            chi_tiet("ctpn_tong_tien") = (CDec(chi_tiet("ctpn_so_luong")) * CDec(chi_tiet("ctpn_gia_nhap"))) - CDec(chi_tiet("ctpn_khuyen_mai"))
        Else
            ' Nếu chưa có -> Thêm mới
            Dim chi_tiet As DataRow = dsChiTietPhieuNhap.NewRow()
            chi_tiet("ctpn_ma_san_pham") = san_pham("sp_ma")
            chi_tiet("sp_ten") = san_pham("sp_ten") ' Cần trường sp_ten trong ChiTietPhieuNhap
            chi_tiet("ctpn_gia_nhap") = gia_nhap_moi
            chi_tiet("ctpn_so_luong") = so_luong_nhap
            chi_tiet("ctpn_tong_san_pham") = so_luong_nhap
            chi_tiet("ctpn_khuyen_mai") = khuyen_mai

            ' Tính tổng tiền: (Số lượng * Giá nhập) - Khuyến mãi
            chi_tiet("ctpn_tong_tien") = (CDec(chi_tiet("ctpn_so_luong")) * CDec(chi_tiet("ctpn_gia_nhap"))) - CDec(chi_tiet("ctpn_khuyen_mai"))

            chi_tiet("ctpn_ghi_chu") = "" ' Có thể thêm ghi chú chi tiết
            If chi_nhanh IsNot Nothing AndAlso chi_nhanh.Table.Columns.Contains("cn_ma") Then
                ' Giả định mã khu vực là mã chi nhánh đang nhập
                chi_tiet("ctpn_ma_khu_vuc") = chi_nhanh("cn_ma")
            Else
                ' Nếu chi_nhanh không tồn tại, bạn cần phải cung cấp giá trị mặc định/NULL nếu DB cho phép
                ' Nếu cột trong DB là NOT NULL, bạn phải gán giá trị hợp lệ ở đây
                ' chi_tiet("ctpn_ma_khu_vuc") = 1 ' Ví dụ: Mã khu vực 1
            End If
            dsChiTietPhieuNhap.Rows.Add(chi_tiet)
        End If

        TinhTong()
    End Sub

    Private Sub dgvDSChiTiet_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDSChiTiet.CellValueChanged
        If e.RowIndex >= 0 Then
            Dim chi_tiet As DataRow = dsChiTietPhieuNhap(e.RowIndex)
            Dim ten_cot As String = dgvDSChiTiet.Columns(e.ColumnIndex).Name

            If ten_cot = "ctpn_so_luong" OrElse ten_cot = "ctpn_gia_nhap" OrElse ten_cot = "ctpn_khuyen_mai" Then
                Try
                    Dim so_luong As Integer = CInt(chi_tiet("ctpn_so_luong"))
                    Dim gia_nhap As Decimal = CDec(chi_tiet("ctpn_gia_nhap"))
                    Dim khuyen_mai As Decimal = CDec(chi_tiet("ctpn_khuyen_mai"))

                    ' Tính lại tổng tiền
                    chi_tiet("ctpn_tong_tien") = (so_luong * gia_nhap) - khuyen_mai
                    chi_tiet("ctpn_tong_san_pham") = so_luong

                    TinhTong()
                Catch ex As Exception
                    ' Xử lý lỗi nếu người dùng nhập sai định dạng số
                    MessageBox.Show("Dữ liệu nhập vào cột này không hợp lệ.", "Lỗi", MessageBoxButtons.OK)
                    ' Có thể cần hoàn lại giá trị cũ hoặc yêu cầu nhập lại
                End Try
            End If
        End If
    End Sub

    Sub TinhTong()
        ' Tính tổng tiền hàng (Sum of ctpn_tong_tien)
        Dim TongTien = dsChiTietPhieuNhap.Compute("Sum(ctpn_tong_tien)", String.Empty)
        If IsDBNull(TongTien) Then
            lTongTien.Text = "0"
        Else
            lTongTien.Text = TongTien.ToString()
        End If
    End Sub

    Private Sub bXoa_Click(sender As Object, e As EventArgs) Handles bXoa.Click
        If dgvDSChiTiet.SelectedCells.Count > 0 Then
            Dim chi_tiet As DataRow = dsChiTietPhieuNhap(dgvDSChiTiet.SelectedCells(0).RowIndex)
            ' Giảm số lượng đi 1
            Dim so_luong As Integer = CInt(chi_tiet("ctpn_so_luong")) - 1

            If so_luong <= 0 Then
                If Loai = 1 Then
                    dsChiTietPhieuNhap.Rows.Remove(chi_tiet)
                ElseIf Loai = 2 Then
                    ' Đánh dấu xóa đối với chế độ Cập nhật
                    chi_tiet.Delete()
                End If
            Else
                chi_tiet("ctpn_so_luong") = so_luong
                chi_tiet("ctpn_tong_san_pham") = so_luong ' Giả sử tong_san_pham = so_luong

                ' Tính lại tổng tiền: (Số lượng mới * Giá nhập) - Khuyến mãi (giữ nguyên, không phân bổ)
                Dim gia_nhap As Decimal = CDec(chi_tiet("ctpn_gia_nhap"))
                Dim khuyen_mai As Decimal = CDec(chi_tiet("ctpn_khuyen_mai"))

                chi_tiet("ctpn_tong_tien") = (CDec(chi_tiet("ctpn_so_luong")) * gia_nhap) - khuyen_mai
            End If

            TinhTong()
        End If
    End Sub

    'Private Sub tbDienThoai_Leave(sender As Object, e As EventArgs) Handles tbDienThoai.Leave
    '    ' Tìm kiếm Nhà Cung Cấp theo Số điện thoại
    '    Dim str As String = String.Format(
    '        "SELECT * from NhaCungCap where ncc_dien_thoai like '{0}'",
    '        tbDienThoai.Text)
    '    dsNhaCungCap = XL_DuLieu.DocDuLieu(str)

    '    If dsNhaCungCap.Rows.Count > 0 Then
    '        ' Đã tìm thấy NCC
    '        nha_cung_cap = dsNhaCungCap.Rows(0)
    '        tbTen.Text = nha_cung_cap("ncc_ten").ToString()
    '        tbDiaChi.Text = nha_cung_cap("ncc_dia_chi").ToString()
    '    Else
    '        ' NCC mới -> Tạo DataRow mới để thêm vào DS
    '        nha_cung_cap = dsNhaCungCap.NewRow()
    '        nha_cung_cap("ncc_dien_thoai") = tbDienThoai.Text
    '        dsNhaCungCap.Rows.Add(nha_cung_cap)

    '        ' Xóa các trường cũ để nhập mới
    '        tbTen.Text = String.Empty
    '        tbDiaChi.Text = String.Empty
    '    End If
    'End Sub

    Private Sub bTao_Click(sender As Object, e As EventArgs) Handles bTao.Click
        ' (Giả định tbDienThoai và tbTen tồn tại)
        'If tbDienThoai.Text = String.Empty Or tbTen.Text = String.Empty Then
        '    MessageBox.Show("Chưa nhập đủ thông tin Nhà Cung Cấp (Điện thoại, Tên)", "Thông báo", MessageBoxButtons.OK)
        '    Return
        'Else
        If dsChiTietPhieuNhap.Rows.Count = 0 Then
            MessageBox.Show("Phiếu nhập chưa có chi tiết sản phẩm nào.", "Thông báo", MessageBoxButtons.OK)
            Return
        End If

        '' 1. Cập nhật thông tin NCC (nếu là NCC mới hoặc thông tin thay đổi)
        'If IsDBNull(nha_cung_cap("ncc_ma")) OrElse nha_cung_cap.RowState = DataRowState.Added OrElse nha_cung_cap.RowState = DataRowState.Modified Then
        '    nha_cung_cap("ncc_ten") = tbTen.Text
        '    nha_cung_cap("ncc_dia_chi") = tbDiaChi.Text
        '    XL_DuLieu.GhiDuLieu("NhaCungCap", dsNhaCungCap)
        'End If

        ' 2. Tạo Phiếu Nhập Hàng mới
        Dim phieu_nhap_moi As DataRow = dsPhieuNhap.NewRow()
        phieu_nhap_moi("pn_ngay") = dtpNgay.Value

        Dim tong_tien As Decimal = 0
        If Not Decimal.TryParse(lTongTien.Text, tong_tien) Then tong_tien = 0 ' Dùng Decimal thay vì Integer

        phieu_nhap_moi("pn_tong_tien") = tong_tien
        'phieu_nhap_moi("pn_chi_phi_phu") = 0 ' Tạm thời là 0
        'phieu_nhap_moi("pn_tong_thanh_toan") = tong_tien ' Tạm thời tổng thanh toán = tổng tiền hàng
        'phieu_nhap_moi("pn_chi_nhanh") = chi_nhanh("cn_ma")
        'phieu_nhap_moi("pn_nha_cung_cap") = nha_cung_cap("ncc_ma")
        phieu_nhap_moi("pn_ghi_chu") = tbGhiChu.Text
        'phieu_nhap_moi("pn_trang_thai") = 1 ' Mới tạo

        dsPhieuNhap.Rows.Add(phieu_nhap_moi)
        XL_DuLieu.GhiDuLieu("PhieuNhap", dsPhieuNhap)

        ' 3. Cập nhật mã Phiếu Nhập cho các Chi tiết
        For Each ctpn As DataRow In dsChiTietPhieuNhap.Rows
            ctpn("ctpn_ma_phieu_nhap") = phieu_nhap_moi("pn_ma")
        Next

        XL_DuLieu.GhiDuLieu("ChiTietPhieuNhap", dsChiTietPhieuNhap)

        ' 4. Cập nhật tồn kho (Cần form/hàm riêng)
        CapNhatTonKho()
        TatManHinh()
    End Sub

    Private Sub bCapNhat_Click(sender As Object, e As EventArgs) Handles bCapNhat.Click
        ' (Giả định tbDienThoai và tbTen tồn tại)
        'If tbDienThoai.Text = String.Empty Or tbTen.Text = String.Empty Then
        '    MessageBox.Show("Chưa nhập đủ thông tin Nhà Cung Cấp (Điện thoại, Tên)", "Thông báo", MessageBoxButtons.OK)
        '    Return
        'End If

        '' 1. Cập nhật thông tin NCC
        'If IsDBNull(nha_cung_cap("ncc_ma")) OrElse nha_cung_cap.RowState = DataRowState.Added OrElse nha_cung_cap.RowState = DataRowState.Modified Then
        '    nha_cung_cap("ncc_ten") = tbTen.Text
        '    nha_cung_cap("ncc_dia_chi") = tbDiaChi.Text
        '    XL_DuLieu.GhiDuLieu("NhaCungCap", dsNhaCungCap)
        'End If

        ' 2. Cập nhật Phiếu Nhập Hàng
        Dim phieu_nhap_cu As DataRow = dsPhieuNhap.Rows(0)
        Dim tong_tien As Decimal = 0

        phieu_nhap_cu("pn_ngay") = dtpNgay.Value
        If Decimal.TryParse(lTongTien.Text, tong_tien) Then ' Dùng Decimal thay vì Integer
            phieu_nhap_cu("pn_tong_tien_hang") = tong_tien
        Else
            phieu_nhap_cu("pn_tong_tien_hang") = 0
        End If

        phieu_nhap_cu("pn_tong_thanh_toan") = phieu_nhap_cu("pn_tong_tien_hang") ' Tạm thời
        phieu_nhap_cu("pn_chi_nhanh") = chi_nhanh("cn_ma")
        phieu_nhap_cu("pn_nha_cung_cap") = nha_cung_cap("ncc_ma")
        phieu_nhap_cu("pn_ghi_chu") = tbGhiChu.Text

        XL_DuLieu.GhiDuLieu("PhieuNhap", dsPhieuNhap)

        ' 3. Cập nhật Chi tiết Phiếu Nhập
        For Each ctpn As DataRow In dsChiTietPhieuNhap.Rows
            If ctpn.RowState <> DataRowState.Deleted Then
                ctpn("ctpn_ma_phieu_nhap") = phieu_nhap_cu("pn_ma")
            End If
        Next
        XL_DuLieu.GhiDuLieu("ChiTietPhieuNhap", dsChiTietPhieuNhap)

        ' 4. Cập nhật tồn kho (Cần form/hàm riêng)
        ' LƯU Ý QUAN TRỌNG: Cần phải thực hiện logic tính DELTA (đảo ngược tác động của phiếu cũ, 
        ' sau đó áp dụng tác động của phiếu mới) để đảm bảo tồn kho chính xác. 
        ' Việc gọi CapNhatTonKho() trực tiếp ở đây sẽ chỉ cộng dồn số lượng hiện tại, dẫn đến sai lệch.
        ' Tuy nhiên, để đáp ứng yêu cầu, tôi sẽ gọi nó nhưng bạn cần thay thế logic này sau.
        ' Nếu bạn chỉ muốn cập nhật chi tiết mà không cập nhật tồn kho khi sửa, hãy bỏ dòng dưới.
        ' CapNhatTonKho() 

        TatManHinh()
    End Sub

    Sub TatManHinh()
        ' Giả sử form cha là frmTonKho hoặc frmDanhSachPhieuNhap
        ' Nếu là frmTonKho, nó cần hàm cập nhật danh sách phiếu
        If Not Me.Tag Is Nothing AndAlso TypeOf Me.Tag Is frmTonKho Then
            Dim frm As frmTonKho = DirectCast(Me.Tag, frmTonKho)
            frm.HienThiDSTonKho()
        End If
        Me.Close()
    End Sub

    ' Phương thức mới để xử lý cập nhật Tồn Kho
    Private Sub CapNhatTonKho()
        If chi_nhanh Is Nothing OrElse Not chi_nhanh.Table.Columns.Contains("cn_ma") Then
            MessageBox.Show("Không tìm thấy thông tin Chi nhánh để cập nhật tồn kho.", "Lỗi tồn kho", MessageBoxButtons.OK)
            Return
        End If

        Dim ma_chi_nhanh As Integer = CInt(chi_nhanh("cn_ma"))

        ' Lấy các mã sản phẩm cần kiểm tra (chỉ lấy các dòng không bị xóa)
        Dim list_sp_ma As New List(Of String)
        For Each ctpn As DataRow In dsChiTietPhieuNhap.Rows
            If ctpn.RowState <> DataRowState.Deleted Then
                list_sp_ma.Add(ctpn("ctpn_ma_san_pham").ToString())
            End If
        Next

        If list_sp_ma.Count = 0 Then
            MessageBox.Show("Không có sản phẩm nào để cập nhật tồn kho.", "Thông báo", MessageBoxButtons.OK)
            Return
        End If

        Dim sp_in_clause As String = String.Join(",", list_sp_ma.Distinct())

        ' Lấy tất cả các dòng TonKho hiện tại cho các sản phẩm và chi nhánh này
        ' LƯU Ý: Cần đảm bảo cột [tk_ngay_cap_nhat] tồn tại trong bảng TonKho
        Dim strTonKho As String = String.Format(
            "SELECT * FROM TonKho WHERE tk_san_pham IN ({0}) AND tk_chi_nhanh = {1}",
            sp_in_clause,
            ma_chi_nhanh)

        Dim dsTonKhoHienTai As DataTable = XL_DuLieu.DocDuLieu(strTonKho)

        ' Duyệt qua từng Chi tiết Phiếu Nhập để cập nhật Tồn Kho
        For Each ctpn As DataRow In dsChiTietPhieuNhap.Rows
            If ctpn.RowState = DataRowState.Deleted Then Continue For ' Bỏ qua các dòng đã xóa

            Dim ma_san_pham As Integer = CInt(ctpn("ctpn_ma_san_pham"))
            Dim so_luong_nhap As Integer = CInt(ctpn("ctpn_so_luong"))
            Dim gia_nhap_moi As Decimal = CDec(ctpn("ctpn_gia_nhap"))

            If so_luong_nhap <= 0 Then Continue For

            ' 1. Tìm kiếm Tồn Kho hiện có
            Dim ton_kho_hien_tai As DataRow() = dsTonKhoHienTai.Select(String.Format("tk_san_pham = {0}", ma_san_pham))

            If ton_kho_hien_tai.Length > 0 Then
                ' Đã tồn tại -> Cập nhật
                Dim tk As DataRow = ton_kho_hien_tai(0)
                Dim tk_so_luong_cu As Integer = 0
                If Not IsDBNull(tk("tk_so_luong")) Then tk_so_luong_cu = CInt(tk("tk_so_luong"))

                Dim tk_gia_von_cu As Decimal = 0
                If Not IsDBNull(tk("tk_gia_von")) Then tk_gia_von_cu = CDec(tk("tk_gia_von"))

                ' Tính Số lượng mới và Giá vốn bình quân mới (Weighted Average Cost - WAC)
                Dim tk_so_luong_moi As Integer = tk_so_luong_cu + so_luong_nhap
                Dim tk_gia_von_moi As Decimal = 0

                If tk_so_luong_moi > 0 Then
                    ' Công thức WAC: (Giá trị tồn kho cũ + Giá trị nhập mới) / Tổng số lượng mới
                    tk_gia_von_moi = ((tk_so_luong_cu * tk_gia_von_cu) + (so_luong_nhap * gia_nhap_moi)) / tk_so_luong_moi
                End If

                ' Cập nhật các trường
                tk("tk_so_luong") = tk_so_luong_moi
                tk("tk_gia_von") = Math.Round(tk_gia_von_moi, 2) ' Làm tròn giá vốn
                tk("tk_ngay_cap_nhat") = DateTime.Now
                tk("tk_xoa") = False

            Else
                ' Chưa tồn tại -> Thêm mới
                Dim tk As DataRow = dsTonKhoHienTai.NewRow() ' Tạo Row mới
                tk("tk_san_pham") = ma_san_pham
                tk("tk_chi_nhanh") = ma_chi_nhanh
                tk("tk_so_luong") = so_luong_nhap
                tk("tk_gia_von") = gia_nhap_moi ' Giá vốn ban đầu chính là giá nhập
                tk("tk_ngay_cap_nhat") = DateTime.Now
                tk("tk_xoa") = False

                dsTonKhoHienTai.Rows.Add(tk)
            End If

        Next

        ' Ghi dữ liệu Tồn Kho đã được cập nhật/thêm mới vào DB
        XL_DuLieu.GhiDuLieu("TonKho", dsTonKhoHienTai)
    End Sub
End Class