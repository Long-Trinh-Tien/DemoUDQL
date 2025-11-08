Imports System.Data.Common

Public Class frmThongKeDoanhThu
    Private Sub frmThongKeDoanhThu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HienThiDuLieu(DateTimePicker1.Value)
    End Sub

    Private Sub HienThiDuLieu(ByVal month As Date)
        'Take beginning and end of month as ngay1 and ngay2
        Dim ngay1 As Date = New Date(month.Year, month.Month, 1)
        Dim ngay2 As Date = New Date(month.Year, month.Month, DateTime.DaysInMonth(month.Year, month.Month))

        Dim sql As String
        sql = String.Format("Select DateValue(dh_ngay) as ngay, count(*) as so_luong ,sum(dh_tong_tien) as tong_tien
            from DonHang
            where dh_xoa = false and dh_ngay >= #{0}# and dh_ngay <= #{1}#
            group by DateValue(dh_ngay)",
                   ngay1.ToString("yyyy-MM-dd"), ngay2.ToString("yyyy-MM-dd"))

        dgvDanhSach.DataSource = XL_DuLieu.DocDuLieu(sql)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        HienThiDuLieu(DateTimePicker1.Value)
    End Sub
End Class