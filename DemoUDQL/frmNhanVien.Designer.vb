<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNhanVien
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
        tbTimKiem = New TextBox()
        tbTaiKhoan = New TextBox()
        tbMatKhau = New TextBox()
        bThem = New Button()
        bCapNhat = New Button()
        bXoa = New Button()
        rbNam = New RadioButton()
        rbNu = New RadioButton()
        cbHienThiXoa = New CheckBox()
        bPhucHoi = New Button()
        dgvDanhSach = New DataGridView()
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        tbDiaChi = New TextBox()
        tbTen = New TextBox()
        Panel1 = New Panel()
        cbLoaiNhanVien = New ComboBox()
        bCapNhatRole = New Button()
        lIsAdmin = New Label()
        Label5 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        CType(dgvDanhSach, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' tbTimKiem
        ' 
        tbTimKiem.Anchor = AnchorStyles.None
        tbTimKiem.Location = New Point(162, 11)
        tbTimKiem.Name = "tbTimKiem"
        tbTimKiem.PlaceholderText = "Enter name to search"
        tbTimKiem.Size = New Size(316, 27)
        tbTimKiem.TabIndex = 0
        ' 
        ' tbTaiKhoan
        ' 
        tbTaiKhoan.Location = New Point(289, 245)
        tbTaiKhoan.Name = "tbTaiKhoan"
        tbTaiKhoan.Size = New Size(125, 27)
        tbTaiKhoan.TabIndex = 1
        ' 
        ' tbMatKhau
        ' 
        tbMatKhau.Location = New Point(289, 295)
        tbMatKhau.Name = "tbMatKhau"
        tbMatKhau.PasswordChar = "*"c
        tbMatKhau.Size = New Size(125, 27)
        tbMatKhau.TabIndex = 1
        ' 
        ' bThem
        ' 
        bThem.Location = New Point(156, 344)
        bThem.Name = "bThem"
        bThem.Size = New Size(94, 29)
        bThem.TabIndex = 2
        bThem.Text = "Them"
        bThem.UseVisualStyleBackColor = True
        ' 
        ' bCapNhat
        ' 
        bCapNhat.Location = New Point(294, 344)
        bCapNhat.Name = "bCapNhat"
        bCapNhat.Size = New Size(94, 29)
        bCapNhat.TabIndex = 2
        bCapNhat.Text = "Cap nhat"
        bCapNhat.UseVisualStyleBackColor = True
        ' 
        ' bXoa
        ' 
        bXoa.Location = New Point(412, 344)
        bXoa.Name = "bXoa"
        bXoa.Size = New Size(94, 29)
        bXoa.TabIndex = 2
        bXoa.Text = "Xoa"
        bXoa.UseVisualStyleBackColor = True
        ' 
        ' rbNam
        ' 
        rbNam.AutoSize = True
        rbNam.Location = New Point(43, 38)
        rbNam.Name = "rbNam"
        rbNam.Size = New Size(62, 24)
        rbNam.TabIndex = 3
        rbNam.TabStop = True
        rbNam.Text = "Nam"
        rbNam.UseVisualStyleBackColor = True
        ' 
        ' rbNu
        ' 
        rbNu.AutoSize = True
        rbNu.Location = New Point(190, 36)
        rbNu.Name = "rbNu"
        rbNu.Size = New Size(49, 24)
        rbNu.TabIndex = 3
        rbNu.TabStop = True
        rbNu.Text = "Nu"
        rbNu.UseVisualStyleBackColor = True
        ' 
        ' cbHienThiXoa
        ' 
        cbHienThiXoa.AutoSize = True
        cbHienThiXoa.Location = New Point(161, 396)
        cbHienThiXoa.Name = "cbHienThiXoa"
        cbHienThiXoa.Size = New Size(221, 24)
        cbHienThiXoa.TabIndex = 4
        cbHienThiXoa.Text = "Hien thi cac nhan vien bi xoa"
        cbHienThiXoa.UseVisualStyleBackColor = True
        ' 
        ' bPhucHoi
        ' 
        bPhucHoi.Location = New Point(385, 391)
        bPhucHoi.Name = "bPhucHoi"
        bPhucHoi.Size = New Size(94, 29)
        bPhucHoi.TabIndex = 2
        bPhucHoi.Text = "Phuc hoi"
        bPhucHoi.UseVisualStyleBackColor = True
        ' 
        ' dgvDanhSach
        ' 
        dgvDanhSach.AllowUserToAddRows = False
        dgvDanhSach.AllowUserToDeleteRows = False
        dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDanhSach.Dock = DockStyle.Fill
        dgvDanhSach.Location = New Point(3, 52)
        dgvDanhSach.Name = "dgvDanhSach"
        dgvDanhSach.RowHeadersWidth = 51
        dgvDanhSach.Size = New Size(634, 395)
        dgvDanhSach.TabIndex = 5
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbNam)
        GroupBox1.Controls.Add(rbNu)
        GroupBox1.Location = New Point(145, 107)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(361, 93)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "Gioi tinh"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(150, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(35, 20)
        Label1.TabIndex = 7
        Label1.Text = "Ten:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(150, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 20)
        Label2.TabIndex = 7
        Label2.Text = "Dia chi:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(150, 245)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 20)
        Label3.TabIndex = 7
        Label3.Text = "Tai khoan:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(150, 295)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 20)
        Label4.TabIndex = 7
        Label4.Text = "Mat khau:"
        ' 
        ' tbDiaChi
        ' 
        tbDiaChi.Location = New Point(289, 64)
        tbDiaChi.Name = "tbDiaChi"
        tbDiaChi.Size = New Size(125, 27)
        tbDiaChi.TabIndex = 1
        ' 
        ' tbTen
        ' 
        tbTen.Location = New Point(289, 19)
        tbTen.Name = "tbTen"
        tbTen.Size = New Size(125, 27)
        tbTen.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(cbLoaiNhanVien)
        Panel1.Controls.Add(bCapNhatRole)
        Panel1.Controls.Add(bXoa)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(tbTen)
        Panel1.Controls.Add(lIsAdmin)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(tbDiaChi)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(tbTaiKhoan)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(tbMatKhau)
        Panel1.Controls.Add(GroupBox1)
        Panel1.Controls.Add(bThem)
        Panel1.Controls.Add(bCapNhat)
        Panel1.Controls.Add(cbHienThiXoa)
        Panel1.Controls.Add(bPhucHoi)
        Panel1.Location = New Point(643, 3)
        Panel1.Name = "Panel1"
        TableLayoutPanel1.SetRowSpan(Panel1, 2)
        Panel1.Size = New Size(635, 444)
        Panel1.TabIndex = 8
        ' 
        ' cbLoaiNhanVien
        ' 
        cbLoaiNhanVien.FormattingEnabled = True
        cbLoaiNhanVien.Location = New Point(289, 206)
        cbLoaiNhanVien.Name = "cbLoaiNhanVien"
        cbLoaiNhanVien.Size = New Size(125, 28)
        cbLoaiNhanVien.TabIndex = 8
        ' 
        ' bCapNhatRole
        ' 
        bCapNhatRole.Location = New Point(438, 205)
        bCapNhatRole.Name = "bCapNhatRole"
        bCapNhatRole.Size = New Size(123, 29)
        bCapNhatRole.TabIndex = 2
        bCapNhatRole.Text = "Cap nhat role"
        bCapNhatRole.UseVisualStyleBackColor = True
        ' 
        ' lIsAdmin
        ' 
        lIsAdmin.AutoSize = True
        lIsAdmin.Location = New Point(495, 15)
        lIsAdmin.Name = "lIsAdmin"
        lIsAdmin.Size = New Size(94, 20)
        lIsAdmin.TabIndex = 7
        lIsAdmin.Text = "Admin role ?"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(150, 209)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 20)
        Label5.TabIndex = 7
        Label5.Text = "Loai User:"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.Controls.Add(dgvDanhSach, 0, 1)
        TableLayoutPanel1.Controls.Add(Panel1, 1, 0)
        TableLayoutPanel1.Controls.Add(tbTimKiem, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10.8888893F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 89.1111145F))
        TableLayoutPanel1.Size = New Size(1281, 450)
        TableLayoutPanel1.TabIndex = 9
        ' 
        ' frmNhanVien
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1281, 450)
        Controls.Add(TableLayoutPanel1)
        Name = "frmNhanVien"
        Text = "frmNhanVien"
        CType(dgvDanhSach, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tbTimKiem As TextBox
    Friend WithEvents tbTaiKhoan As TextBox
    Friend WithEvents tbMatKhau As TextBox
    Friend WithEvents bThem As Button
    Friend WithEvents bCapNhat As Button
    Friend WithEvents bXoa As Button
    Friend WithEvents rbNam As RadioButton
    Friend WithEvents rbNu As RadioButton
    Friend WithEvents cbHienThiXoa As CheckBox
    Friend WithEvents bPhucHoi As Button
    Friend WithEvents dgvDanhSach As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbDiaChi As TextBox
    Friend WithEvents tbTen As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents cbLoaiNhanVien As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lIsAdmin As Label
    Friend WithEvents bCapNhatRole As Button
End Class
