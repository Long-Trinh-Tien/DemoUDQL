Imports System.IO
Public Class frmBackup

    ' Định nghĩa chuỗi kết nối (Cần lấy đường dẫn tuyệt đối của file)
    ' Giả định file CuaHangTapHoa.accdb nằm cùng thư mục với file thực thi (.exe)
    Private Const DB_NAME As String = "CuaHangTapHoa.accdb"

    Private Sub bBackup_Click(sender As Object, e As EventArgs) Handles bBackup.Click
        ' BƯỚC 1: Xác định đường dẫn file Database gốc (file cần sao lưu)
        Dim sourcePath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DB_NAME)

        ' Kiểm tra xem file database gốc có tồn tại không
        If Not File.Exists(sourcePath) Then
            MessageBox.Show($"Không tìm thấy file Database gốc: {sourcePath}. Vui lòng kiểm tra lại đường dẫn.", "Lỗi Sao Lưu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' BƯỚC 2: Mở hộp thoại chọn thư mục lưu trữ (FolderBrowserDialog)
        Using fbd As New FolderBrowserDialog()
            fbd.Description = "Chọn thư mục bạn muốn lưu file sao lưu Database."
            fbd.ShowNewFolderButton = True ' Cho phép tạo thư mục mới

            ' Thiết lập thư mục ban đầu là Desktop hoặc Documents (tùy chọn)
            fbd.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

            If fbd.ShowDialog() = DialogResult.OK Then

                Dim destinationFolder As String = fbd.SelectedPath

                ' BƯỚC 3: Tạo tên file sao lưu mới
                ' Tên file sẽ là: CuaHangTapHoa_yyyyMMdd_HHmmss.accdb
                Dim backupFileName As String = $"CuaHangTapHoa_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.accdb"
                Dim destinationPath As String = Path.Combine(destinationFolder, backupFileName)

                Try
                    ' BƯỚC 4: Thực hiện sao chép file database
                    File.Copy(sourcePath, destinationPath)

                    MessageBox.Show($"Sao lưu Database thành công!{vbCrLf}Đã lưu tại: {destinationPath}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As IOException
                    ' Xử lý lỗi nếu file đang được sử dụng hoặc lỗi IO khác
                    MessageBox.Show($"Lỗi I/O khi sao lưu file. Đảm bảo file database không bị mở bởi ứng dụng khác.{vbCrLf}Chi tiết lỗi: {ex.Message}", "Lỗi Sao Lưu", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Catch ex As Exception
                    ' Xử lý các lỗi khác
                    MessageBox.Show($"Đã xảy ra lỗi không xác định khi sao lưu Database.{vbCrLf}Chi tiết lỗi: {ex.Message}", "Lỗi Sao Lưu", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("Đã hủy thao tác sao lưu Database.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using
    End Sub

    Private Sub bRestore_Click(sender As Object, e As EventArgs) Handles bRestore.Click
        ' BƯỚC 1: Mở hộp thoại chọn file Database sao lưu (OpenFileDialog)
        Using ofd As New OpenFileDialog()
            ofd.Filter = "File Access Database (*.accdb)|*.accdb"
            ofd.Title = "Chọn file Database sao lưu để khôi phục"
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

            If ofd.ShowDialog() = DialogResult.OK Then
                Dim sourceBackupPath As String = ofd.FileName
                Dim destinationPath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DB_NAME)

                ' BƯỚC 2: Hiển thị thông báo xác nhận TRƯỚC KHI GHI ĐÈ
                Dim confirmResult As DialogResult = MessageBox.Show(
                    $"Bạn có chắc chắn muốn khôi phục Database từ file:{vbCrLf}{sourceBackupPath}{vbCrLf}{vbCrLf}Thao tác này sẽ GHI ĐÈ file {DB_NAME} hiện tại trong thư mục chương trình.",
                    "Xác Nhận Khôi Phục",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                )

                If confirmResult = DialogResult.Yes Then
                    Try
                        ' BƯỚC 3: Thực hiện sao chép (ghi đè file)
                        ' True cho phép ghi đè (overwrite) file đích
                        File.Copy(sourceBackupPath, destinationPath, overwrite:=True)

                        MessageBox.Show(
                            $"Khôi phục Database thành công!{vbCrLf}File mới đã được ghi đè vào: {destinationPath}{vbCrLf}{vbCrLf}Vui lòng KHỞI ĐỘNG LẠI chương trình để sử dụng dữ liệu mới.",
                            "Thông Báo Khôi Phục",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        )
                    Catch ex As IOException
                        ' Xử lý lỗi nếu file đang được sử dụng hoặc lỗi IO khác
                        MessageBox.Show($"Lỗi I/O khi khôi phục file. Đảm bảo file database không bị mở bởi ứng dụng khác.{vbCrLf}Chi tiết lỗi: {ex.Message}", "Lỗi Khôi Phục", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Catch ex As Exception
                        ' Xử lý các lỗi khác
                        MessageBox.Show($"Đã xảy ra lỗi không xác định khi khôi phục Database.{vbCrLf}Chi tiết lỗi: {ex.Message}", "Lỗi Khôi Phục", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Else
                    MessageBox.Show("Đã hủy thao tác Khôi phục Database.", "Thông Báo Khôi Phục", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End Using
    End Sub
End Class