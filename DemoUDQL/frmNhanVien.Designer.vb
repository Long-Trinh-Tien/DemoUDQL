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
        tbTen = New TextBox()
        tbDiaChi = New TextBox()
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
        CType(dgvDanhSach, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' tbTimKiem
        ' 
        tbTimKiem.Location = New Point(12, 12)
        tbTimKiem.Name = "tbTimKiem"
        tbTimKiem.Size = New Size(316, 27)
        tbTimKiem.TabIndex = 0
        ' 
        ' tbTen
        ' 
        tbTen.Location = New Point(524, 14)
        tbTen.Name = "tbTen"
        tbTen.Size = New Size(125, 27)
        tbTen.TabIndex = 1
        ' 
        ' tbDiaChi
        ' 
        tbDiaChi.Location = New Point(524, 59)
        tbDiaChi.Name = "tbDiaChi"
        tbDiaChi.Size = New Size(125, 27)
        tbDiaChi.TabIndex = 1
        ' 
        ' tbTaiKhoan
        ' 
        tbTaiKhoan.Location = New Point(524, 201)
        tbTaiKhoan.Name = "tbTaiKhoan"
        tbTaiKhoan.Size = New Size(125, 27)
        tbTaiKhoan.TabIndex = 1
        ' 
        ' tbMatKhau
        ' 
        tbMatKhau.Location = New Point(524, 251)
        tbMatKhau.Name = "tbMatKhau"
        tbMatKhau.PasswordChar = "*"c
        tbMatKhau.Size = New Size(125, 27)
        tbMatKhau.TabIndex = 1
        ' 
        ' bThem
        ' 
        bThem.Location = New Point(391, 323)
        bThem.Name = "bThem"
        bThem.Size = New Size(94, 29)
        bThem.TabIndex = 2
        bThem.Text = "Them"
        bThem.UseVisualStyleBackColor = True
        ' 
        ' bCapNhat
        ' 
        bCapNhat.Location = New Point(529, 323)
        bCapNhat.Name = "bCapNhat"
        bCapNhat.Size = New Size(94, 29)
        bCapNhat.TabIndex = 2
        bCapNhat.Text = "Cap nhat"
        bCapNhat.UseVisualStyleBackColor = True
        ' 
        ' bXoa
        ' 
        bXoa.Location = New Point(647, 323)
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
        cbHienThiXoa.Location = New Point(396, 391)
        cbHienThiXoa.Name = "cbHienThiXoa"
        cbHienThiXoa.Size = New Size(221, 24)
        cbHienThiXoa.TabIndex = 4
        cbHienThiXoa.Text = "Hien thi cac nhan vien bi xoa"
        cbHienThiXoa.UseVisualStyleBackColor = True
        ' 
        ' bPhucHoi
        ' 
        bPhucHoi.Location = New Point(620, 386)
        bPhucHoi.Name = "bPhucHoi"
        bPhucHoi.Size = New Size(94, 29)
        bPhucHoi.TabIndex = 2
        bPhucHoi.Text = "Phuc hoi"
        bPhucHoi.UseVisualStyleBackColor = True
        ' 
        ' dgvDanhSach
        ' 
        dgvDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDanhSach.Location = New Point(12, 66)
        dgvDanhSach.Name = "dgvDanhSach"
        dgvDanhSach.RowHeadersWidth = 51
        dgvDanhSach.Size = New Size(316, 372)
        dgvDanhSach.TabIndex = 5
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbNam)
        GroupBox1.Controls.Add(rbNu)
        GroupBox1.Location = New Point(380, 102)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(361, 93)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "Gioi tinh"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(385, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(35, 20)
        Label1.TabIndex = 7
        Label1.Text = "Ten:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(385, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 20)
        Label2.TabIndex = 7
        Label2.Text = "Dia chi:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(385, 201)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 20)
        Label3.TabIndex = 7
        Label3.Text = "Tai khoan:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(385, 251)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 20)
        Label4.TabIndex = 7
        Label4.Text = "Mat khau:"
        ' 
        ' frmNhanVien
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Controls.Add(dgvDanhSach)
        Controls.Add(cbHienThiXoa)
        Controls.Add(bXoa)
        Controls.Add(bPhucHoi)
        Controls.Add(bCapNhat)
        Controls.Add(bThem)
        Controls.Add(tbMatKhau)
        Controls.Add(tbTaiKhoan)
        Controls.Add(tbDiaChi)
        Controls.Add(tbTen)
        Controls.Add(tbTimKiem)
        Name = "frmNhanVien"
        Text = "frmNhanVien"
        CType(dgvDanhSach, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tbTimKiem As TextBox
    Friend WithEvents tbTen As TextBox
    Friend WithEvents tbDiaChi As TextBox
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
End Class
