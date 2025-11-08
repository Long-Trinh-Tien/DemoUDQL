Public Class frmMain
    Dim dsForm As List(Of Form)
    Dim NhanVien As DataRow

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsForm = New List(Of Form)()
        Me.Hide()
        Dim frm As frmDangNhap = New frmDangNhap()
        Dim dr As DialogResult = frm.ShowDialog()
        If dr = DialogResult.OK Then
            NhanVien = frm.NhanVien
            Me.Show()
        Else
            Me.Close()
        End If
    End Sub

    Function TimForm(type As Type)
        For Each frm In dsForm
            If frm.GetType() Is type Then
                If frm.IsDisposed = True Then
                    dsForm.Remove(frm)
                    frm = Nothing
                End If
                Return frm
            End If
        Next
        Return Nothing
    End Function
    Private Sub LoaiSanPhamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoaiSanPhamToolStripMenuItem.Click
        Dim frm As Form = TimForm(frmLoaiSanPham.GetType())
        If frm IsNot Nothing Then
            frm.Activate()
            frm.Show()
            Return
        End If

        Dim frm1 As frmLoaiSanPham = New frmLoaiSanPham()
        frm1.MdiParent = Me
        frm1.WindowState = FormWindowState.Maximized
        frm1.Show()
        dsForm.Add(frm1)
    End Sub

    Private Sub OpenForm(Of T As {Form, New})()
        Dim frm As Form = TimForm(GetType(T))
        If frm IsNot Nothing Then
            frm.Activate()
            frm.Show()
            Return
        End If

        Dim newFrm As New T()
        newFrm.MdiParent = Me
        newFrm.WindowState = FormWindowState.Maximized
        newFrm.Show()
        dsForm.Add(newFrm)
    End Sub

    Private Sub ThongTinPhanMemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThongTinPhanMemToolStripMenuItem.Click
        OpenForm(Of frmThongTinPhanMem)()
    End Sub

    Private Sub SanPhamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SanPhamToolStripMenuItem.Click
        OpenForm(Of frmSanPham)()
    End Sub

    Private Sub NhanVienToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhanVienToolStripMenuItem.Click
        OpenForm(Of frmNhanVien)()
    End Sub

    Private Sub KhachHangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KhachHangToolStripMenuItem.Click
        OpenForm(Of frmKhachHang)()
    End Sub

    Private Sub NhaCungCapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhaCungCapToolStripMenuItem.Click
        OpenForm(Of frmNhaCungCap)()
    End Sub

    Private Sub DanhSachDonHangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSachDonHangToolStripMenuItem.Click
        OpenForm(Of frmDanhSachDonHang)()
    End Sub

    Private Sub DanhSachPhieuChiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSachPhieuChiToolStripMenuItem.Click
        OpenForm(Of frmDanhSachPhieuChi)()
    End Sub

    Private Sub DanhSachPhieuNhapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSachPhieuNhapToolStripMenuItem.Click
        OpenForm(Of frmDanhSachPhieuNhap)()
    End Sub

    Private Sub BanHangToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BanHangToolStripMenuItem1.Click
        OpenForm(Of frmBanHang)()
    End Sub

    Private Sub DangNhapToolStripMenuItem_Click(sender As Object, e As EventArgs)
        OpenForm(Of frmDangNhap)()
    End Sub

    Private Sub ThongKeDoanhThuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThongKeDoanhThuToolStripMenuItem.Click
        OpenForm(Of frmThongKeDoanhThu)()
    End Sub
End Class
