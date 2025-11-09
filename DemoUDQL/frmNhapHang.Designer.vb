<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNhapHang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lTongTien = New Label()
        lChiNhanh = New Label()
        Label3 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        bXoa = New Button()
        bTao = New Button()
        bCapNhat = New Button()
        bThem = New Button()
        dtpNgay = New DateTimePicker()
        tbGhiChu = New TextBox()
        tbSoLuongNhap = New TextBox()
        tbGiaNhap = New TextBox()
        tbMaSanPham = New TextBox()
        dgvDSChiTiet = New DataGridView()
        dgvDSTonKho = New DataGridView()
        tbKhuyenMai = New TextBox()
        Label4 = New Label()
        CType(dgvDSChiTiet, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvDSTonKho, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lTongTien
        ' 
        lTongTien.AutoSize = True
        lTongTien.Location = New Point(834, 228)
        lTongTien.Name = "lTongTien"
        lTongTien.Size = New Size(74, 20)
        lTongTien.TabIndex = 16
        lTongTien.Text = "Tong Tien"
        ' 
        ' lChiNhanh
        ' 
        lChiNhanh.AutoSize = True
        lChiNhanh.Location = New Point(834, 15)
        lChiNhanh.Name = "lChiNhanh"
        lChiNhanh.Size = New Size(77, 20)
        lChiNhanh.TabIndex = 22
        lChiNhanh.Text = "Chi Nhanh"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(448, 165)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 20)
        Label3.TabIndex = 21
        Label3.Text = "Ghi chu:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(666, 77)
        Label7.Name = "Label7"
        Label7.Size = New Size(111, 20)
        Label7.TabIndex = 20
        Label7.Text = "So Luong Nhap"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(448, 122)
        Label6.Name = "Label6"
        Label6.Size = New Size(74, 20)
        Label6.TabIndex = 19
        Label6.Text = "Gia Nhap:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(448, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 20)
        Label2.TabIndex = 18
        Label2.Text = "Ma San Pham"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(448, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 20)
        Label1.TabIndex = 17
        Label1.Text = "Ngay:"
        ' 
        ' bXoa
        ' 
        bXoa.Location = New Point(415, 238)
        bXoa.Name = "bXoa"
        bXoa.Size = New Size(62, 34)
        bXoa.TabIndex = 23
        bXoa.Text = "<"
        bXoa.UseVisualStyleBackColor = True
        ' 
        ' bTao
        ' 
        bTao.Location = New Point(821, 329)
        bTao.Name = "bTao"
        bTao.Size = New Size(90, 34)
        bTao.TabIndex = 25
        bTao.Text = "Tao"
        bTao.UseVisualStyleBackColor = True
        ' 
        ' bCapNhat
        ' 
        bCapNhat.Location = New Point(821, 265)
        bCapNhat.Name = "bCapNhat"
        bCapNhat.Size = New Size(87, 34)
        bCapNhat.TabIndex = 24
        bCapNhat.Text = "Cap nhat"
        bCapNhat.UseVisualStyleBackColor = True
        ' 
        ' bThem
        ' 
        bThem.Location = New Point(415, 198)
        bThem.Name = "bThem"
        bThem.Size = New Size(62, 34)
        bThem.TabIndex = 15
        bThem.Text = ">"
        bThem.UseVisualStyleBackColor = True
        ' 
        ' dtpNgay
        ' 
        dtpNgay.Location = New Point(540, 25)
        dtpNgay.Name = "dtpNgay"
        dtpNgay.Size = New Size(243, 27)
        dtpNgay.TabIndex = 13
        ' 
        ' tbGhiChu
        ' 
        tbGhiChu.Location = New Point(540, 165)
        tbGhiChu.Name = "tbGhiChu"
        tbGhiChu.Size = New Size(368, 27)
        tbGhiChu.TabIndex = 14
        ' 
        ' tbSoLuongNhap
        ' 
        tbSoLuongNhap.Location = New Point(799, 74)
        tbSoLuongNhap.Name = "tbSoLuongNhap"
        tbSoLuongNhap.Size = New Size(89, 27)
        tbSoLuongNhap.TabIndex = 11
        ' 
        ' tbGiaNhap
        ' 
        tbGiaNhap.Location = New Point(540, 122)
        tbGiaNhap.Name = "tbGiaNhap"
        tbGiaNhap.Size = New Size(125, 27)
        tbGiaNhap.TabIndex = 12
        ' 
        ' tbMaSanPham
        ' 
        tbMaSanPham.Location = New Point(553, 74)
        tbMaSanPham.Name = "tbMaSanPham"
        tbMaSanPham.Size = New Size(107, 27)
        tbMaSanPham.TabIndex = 9
        ' 
        ' dgvDSChiTiet
        ' 
        dgvDSChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDSChiTiet.Location = New Point(483, 198)
        dgvDSChiTiet.Name = "dgvDSChiTiet"
        dgvDSChiTiet.RowHeadersWidth = 51
        dgvDSChiTiet.Size = New Size(300, 168)
        dgvDSChiTiet.TabIndex = 10
        ' 
        ' dgvDSTonKho
        ' 
        dgvDSTonKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDSTonKho.Location = New Point(-3, 15)
        dgvDSTonKho.Name = "dgvDSTonKho"
        dgvDSTonKho.RowHeadersWidth = 51
        dgvDSTonKho.Size = New Size(412, 351)
        dgvDSTonKho.TabIndex = 8
        ' 
        ' tbKhuyenMai
        ' 
        tbKhuyenMai.Location = New Point(799, 119)
        tbKhuyenMai.Name = "tbKhuyenMai"
        tbKhuyenMai.Size = New Size(89, 27)
        tbKhuyenMai.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(691, 125)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 20)
        Label4.TabIndex = 20
        Label4.Text = "Khuyen Mai"
        ' 
        ' frmNhapHang
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(940, 381)
        Controls.Add(lTongTien)
        Controls.Add(lChiNhanh)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(bXoa)
        Controls.Add(bTao)
        Controls.Add(bCapNhat)
        Controls.Add(bThem)
        Controls.Add(dtpNgay)
        Controls.Add(tbKhuyenMai)
        Controls.Add(tbGhiChu)
        Controls.Add(tbSoLuongNhap)
        Controls.Add(tbGiaNhap)
        Controls.Add(tbMaSanPham)
        Controls.Add(dgvDSChiTiet)
        Controls.Add(dgvDSTonKho)
        Name = "frmNhapHang"
        Text = "frmNhapHang"
        CType(dgvDSChiTiet, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvDSTonKho, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lTongTien As Label
    Friend WithEvents lChiNhanh As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bXoa As Button
    Friend WithEvents bTao As Button
    Friend WithEvents bCapNhat As Button
    Friend WithEvents bThem As Button
    Friend WithEvents dtpNgay As DateTimePicker
    Friend WithEvents tbGhiChu As TextBox
    Friend WithEvents tbSoLuongNhap As TextBox
    Friend WithEvents tbGiaNhap As TextBox
    Friend WithEvents tbMaSanPham As TextBox
    Friend WithEvents dgvDSChiTiet As DataGridView
    Friend WithEvents dgvDSTonKho As DataGridView
    Friend WithEvents tbKhuyenMai As TextBox
    Friend WithEvents Label4 As Label
End Class
