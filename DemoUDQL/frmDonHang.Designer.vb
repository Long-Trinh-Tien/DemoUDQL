<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDonHang
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
        dgvDSSanPham = New DataGridView()
        dgvDSChiTiet = New DataGridView()
        tbDienThoai = New TextBox()
        tbGhiChu = New TextBox()
        dtpNgay = New DateTimePicker()
        bThem = New Button()
        bXoa = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lChiNhanh = New Label()
        lTongTien = New Label()
        bCapNhat = New Button()
        bTao = New Button()
        tbDiaChi = New TextBox()
        Label6 = New Label()
        tbTen = New TextBox()
        Label7 = New Label()
        CType(dgvDSSanPham, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvDSChiTiet, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvDSSanPham
        ' 
        dgvDSSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDSSanPham.Location = New Point(2, 12)
        dgvDSSanPham.Name = "dgvDSSanPham"
        dgvDSSanPham.RowHeadersWidth = 51
        dgvDSSanPham.Size = New Size(412, 351)
        dgvDSSanPham.TabIndex = 0
        ' 
        ' dgvDSChiTiet
        ' 
        dgvDSChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDSChiTiet.Location = New Point(488, 195)
        dgvDSChiTiet.Name = "dgvDSChiTiet"
        dgvDSChiTiet.RowHeadersWidth = 51
        dgvDSChiTiet.Size = New Size(300, 168)
        dgvDSChiTiet.TabIndex = 0
        ' 
        ' tbDienThoai
        ' 
        tbDienThoai.Location = New Point(545, 74)
        tbDienThoai.Name = "tbDienThoai"
        tbDienThoai.Size = New Size(89, 27)
        tbDienThoai.TabIndex = 0
        ' 
        ' tbGhiChu
        ' 
        tbGhiChu.Location = New Point(545, 162)
        tbGhiChu.Name = "tbGhiChu"
        tbGhiChu.Size = New Size(368, 27)
        tbGhiChu.TabIndex = 3
        ' 
        ' dtpNgay
        ' 
        dtpNgay.Location = New Point(545, 22)
        dtpNgay.Name = "dtpNgay"
        dtpNgay.Size = New Size(243, 27)
        dtpNgay.TabIndex = 2
        ' 
        ' bThem
        ' 
        bThem.Location = New Point(420, 195)
        bThem.Name = "bThem"
        bThem.Size = New Size(62, 34)
        bThem.TabIndex = 4
        bThem.Text = ">"
        bThem.UseVisualStyleBackColor = True
        ' 
        ' bXoa
        ' 
        bXoa.Location = New Point(420, 235)
        bXoa.Name = "bXoa"
        bXoa.Size = New Size(62, 34)
        bXoa.TabIndex = 5
        bXoa.Text = "<"
        bXoa.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(453, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 20)
        Label1.TabIndex = 4
        Label1.Text = "Ngay:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(453, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 20)
        Label2.TabIndex = 4
        Label2.Text = "Dien Thoai"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(453, 162)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 20)
        Label3.TabIndex = 4
        Label3.Text = "Ghi chu:"
        ' 
        ' lChiNhanh
        ' 
        lChiNhanh.AutoSize = True
        lChiNhanh.Location = New Point(839, 12)
        lChiNhanh.Name = "lChiNhanh"
        lChiNhanh.Size = New Size(77, 20)
        lChiNhanh.TabIndex = 4
        lChiNhanh.Text = "Chi Nhanh"
        ' 
        ' lTongTien
        ' 
        lTongTien.AutoSize = True
        lTongTien.Location = New Point(839, 381)
        lTongTien.Name = "lTongTien"
        lTongTien.Size = New Size(74, 20)
        lTongTien.TabIndex = 4
        lTongTien.Text = "Tong Tien"
        ' 
        ' bCapNhat
        ' 
        bCapNhat.Location = New Point(826, 418)
        bCapNhat.Name = "bCapNhat"
        bCapNhat.Size = New Size(87, 34)
        bCapNhat.TabIndex = 6
        bCapNhat.Text = "Cap nhat"
        bCapNhat.UseVisualStyleBackColor = True
        ' 
        ' bTao
        ' 
        bTao.Location = New Point(826, 482)
        bTao.Name = "bTao"
        bTao.Size = New Size(90, 34)
        bTao.TabIndex = 7
        bTao.Text = "Tao"
        bTao.UseVisualStyleBackColor = True
        ' 
        ' tbDiaChi
        ' 
        tbDiaChi.Location = New Point(545, 119)
        tbDiaChi.Name = "tbDiaChi"
        tbDiaChi.Size = New Size(368, 27)
        tbDiaChi.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(453, 119)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 20)
        Label6.TabIndex = 4
        Label6.Text = "Dia Chi:"
        ' 
        ' tbTen
        ' 
        tbTen.Location = New Point(763, 74)
        tbTen.Name = "tbTen"
        tbTen.Size = New Size(89, 27)
        tbTen.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(671, 74)
        Label7.Name = "Label7"
        Label7.Size = New Size(56, 20)
        Label7.TabIndex = 4
        Label7.Text = "Ten KH"
        ' 
        ' frmDonHang
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(926, 552)
        Controls.Add(lTongTien)
        Controls.Add(lChiNhanh)
        Controls.Add(Label3)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(bXoa)
        Controls.Add(bTao)
        Controls.Add(bCapNhat)
        Controls.Add(bThem)
        Controls.Add(dtpNgay)
        Controls.Add(tbGhiChu)
        Controls.Add(tbTen)
        Controls.Add(tbDiaChi)
        Controls.Add(tbDienThoai)
        Controls.Add(dgvDSChiTiet)
        Controls.Add(dgvDSSanPham)
        Name = "frmDonHang"
        Text = "frmDonHang"
        CType(dgvDSSanPham, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvDSChiTiet, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvDSSanPham As DataGridView
    Friend WithEvents dgvDSChiTiet As DataGridView
    Friend WithEvents tbDienThoai As TextBox
    Friend WithEvents tbGhiChu As TextBox
    Friend WithEvents dtpNgay As DateTimePicker
    Friend WithEvents bThem As Button
    Friend WithEvents bXoa As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lChiNhanh As Label
    Friend WithEvents lTongTien As Label
    Friend WithEvents bCapNhat As Button
    Friend WithEvents bTao As Button
    Friend WithEvents tbDiaChi As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbTen As TextBox
    Friend WithEvents Label7 As Label
End Class
