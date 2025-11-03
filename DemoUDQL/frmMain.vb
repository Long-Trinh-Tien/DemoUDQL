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
        Dim frm As Form = TimForm(frmThongTinPhanMem.GetType())
        If frm IsNot Nothing Then
            frm.Activate()
            frm.Show()
            Return
        End If

        Dim frm1 As frmThongTinPhanMem = New frmThongTinPhanMem()
        frm1.MdiParent = Me
        frm1.WindowState = FormWindowState.Maximized
        frm1.Show()
        dsForm.Add(frm1)
    End Sub

    Private Sub SanPhamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SanPhamToolStripMenuItem.Click
        Dim frm As Form = TimForm(frmSanPham.GetType())
        If frm IsNot Nothing Then
            frm.Activate()
            frm.Show()
            Return
        End If

        Dim frm1 As frmSanPham = New frmSanPham()
        frm1.MdiParent = Me
        frm1.WindowState = FormWindowState.Maximized
        frm1.Show()
        dsForm.Add(frm1)
    End Sub

    Private Sub LoaiNguyenLieuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoaiNguyenLieuToolStripMenuItem.Click
        Dim frm As Form = TimForm(frmLoaiNguyenLieu.GetType())
        If frm IsNot Nothing Then
            frm.Activate()
            frm.Show()
            Return
        End If

        Dim frm1 As frmLoaiNguyenLieu = New frmLoaiNguyenLieu()
        frm1.MdiParent = Me
        frm1.WindowState = FormWindowState.Maximized
        frm1.Show()
        dsForm.Add(frm1)
    End Sub

    Private Sub NguyenLieuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NguyenLieuToolStripMenuItem.Click
        Dim frm As Form = TimForm(frmNguyenLieu.GetType())
        If frm IsNot Nothing Then
            frm.Activate()
            frm.Show()
            Return
        End If

        Dim frm1 As frmNguyenLieu = New frmNguyenLieu()
        frm1.MdiParent = Me
        frm1.WindowState = FormWindowState.Maximized
        frm1.Show()
        dsForm.Add(frm1)
    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        Dim frm As Form = TimForm(frmMenu.GetType())
        If frm IsNot Nothing Then
            frm.Activate()
            frm.Show()
            Return
        End If

        Dim frm1 As frmMenu = New frmMenu()
        frm1.MdiParent = Me
        frm1.WindowState = FormWindowState.Maximized
        frm1.Show()
        dsForm.Add(frm1)
    End Sub

    Private Sub NguyenLieuVaMonAnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NguyenLieuVaMonAnToolStripMenuItem.Click
        Dim frm As Form = TimForm(frmNguyenLieuVaMonAn.GetType())
        If frm IsNot Nothing Then
            frm.Activate()
            frm.Show()
            Return
        End If

        Dim frm1 As frmNguyenLieuVaMonAn = New frmNguyenLieuVaMonAn()
        frm1.MdiParent = Me
        frm1.WindowState = FormWindowState.Maximized
        frm1.Show()
        dsForm.Add(frm1)
    End Sub

    Private Sub NhanVienToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhanVienToolStripMenuItem.Click
        Dim frm As Form = TimForm(frmNhanVien.GetType())
        If frm IsNot Nothing Then
            frm.Activate()
            frm.Show()
            Return
        End If

        Dim frm1 As frmNhanVien = New frmNhanVien()
        frm1.MdiParent = Me
        frm1.WindowState = FormWindowState.Maximized
        frm1.Show()
        dsForm.Add(frm1)
    End Sub

    Private Sub KhachHangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KhachHangToolStripMenuItem.Click
        Dim frm As Form = TimForm(frmKhachHang.GetType())
        If frm IsNot Nothing Then
            frm.Activate()
            frm.Show()
            Return
        End If

        Dim frm1 As frmKhachHang = New frmKhachHang()
        frm1.MdiParent = Me
        frm1.WindowState = FormWindowState.Maximized
        frm1.Show()
        dsForm.Add(frm1)
    End Sub

    Private Sub NhaCungCapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhaCungCapToolStripMenuItem.Click
        Dim frm As Form = TimForm(frmNhaCungCap.GetType())
        If frm IsNot Nothing Then
            frm.Activate()
            frm.Show()
            Return
        End If

        Dim frm1 As frmNhaCungCap = New frmNhaCungCap()
        frm1.MdiParent = Me
        frm1.WindowState = FormWindowState.Maximized
        frm1.Show()
        dsForm.Add(frm1)
    End Sub

    Private Sub DanhSachDonHangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSachDonHangToolStripMenuItem.Click
        Dim frm As Form = TimForm(frmDanhSachDonHang.GetType())
        If frm IsNot Nothing Then
            frm.Activate()
            frm.Show()
            Return
        End If

        Dim frm1 As frmDanhSachDonHang = New frmDanhSachDonHang()
        frm1.MdiParent = Me
        frm1.WindowState = FormWindowState.Maximized
        frm1.Show()
        dsForm.Add(frm1)
    End Sub

    Private Sub DanhSachPhieuChiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSachPhieuChiToolStripMenuItem.Click
        Dim frm As Form = TimForm(frmDanhSachPhieuChi.GetType())
        If frm IsNot Nothing Then
            frm.Activate()
            frm.Show()
            Return
        End If

        Dim frm1 As frmDanhSachPhieuChi = New frmDanhSachPhieuChi()
        frm1.MdiParent = Me
        frm1.WindowState = FormWindowState.Maximized
        frm1.Show()
        dsForm.Add(frm1)
    End Sub

    Private Sub DanhSachPhieuNhapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSachPhieuNhapToolStripMenuItem.Click
        Dim frm As Form = TimForm(frmDanhSachPhieuNhap.GetType())
        If frm IsNot Nothing Then
            frm.Activate()
            frm.Show()
            Return
        End If

        Dim frm1 As frmDanhSachPhieuNhap = New frmDanhSachPhieuNhap()
        frm1.MdiParent = Me
        frm1.WindowState = FormWindowState.Maximized
        frm1.Show()
        dsForm.Add(frm1)
    End Sub

    Private Sub BanHangToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BanHangToolStripMenuItem1.Click
        Dim frm As Form = TimForm(frmBanHang.GetType())
        If frm IsNot Nothing Then
            frm.Activate()
            frm.Show()
            Return
        End If

        Dim frm1 As frmBanHang = New frmBanHang()
        frm1.MdiParent = Me
        frm1.WindowState = FormWindowState.Maximized
        frm1.Show()
        dsForm.Add(frm1)
    End Sub

    Private Sub DangNhapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DangNhapToolStripMenuItem.Click
        OpenForm(Of frmDangNhap)()
    End Sub
End Class
