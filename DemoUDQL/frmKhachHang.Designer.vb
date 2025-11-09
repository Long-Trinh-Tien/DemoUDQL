<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKhachHang
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
        TableLayoutPanel1 = New TableLayoutPanel()
        dgvDanhSach = New DataGridView()
        Panel1 = New Panel()
        bXoa = New Button()
        Label4 = New Label()
        tbTen = New TextBox()
        Label3 = New Label()
        tbDiaChi = New TextBox()
        Label2 = New Label()
        tbCode = New TextBox()
        Label1 = New Label()
        tbDienThoai = New TextBox()
        bThem = New Button()
        bCapNhat = New Button()
        cbHienThiXoa = New CheckBox()
        bPhucHoi = New Button()
        tbTimKiem = New TextBox()
        TableLayoutPanel1.SuspendLayout()
        CType(dgvDanhSach, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(dgvDanhSach, 0, 1)
        TableLayoutPanel1.Controls.Add(Panel1, 1, 0)
        TableLayoutPanel1.Controls.Add(tbTimKiem, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10.8888893F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 89.1111145F))
        TableLayoutPanel1.Size = New Size(1242, 450)
        TableLayoutPanel1.TabIndex = 10
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
        dgvDanhSach.Size = New Size(615, 395)
        dgvDanhSach.TabIndex = 5
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(bXoa)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(tbTen)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(tbDiaChi)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(tbCode)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(tbDienThoai)
        Panel1.Controls.Add(bThem)
        Panel1.Controls.Add(bCapNhat)
        Panel1.Controls.Add(cbHienThiXoa)
        Panel1.Controls.Add(bPhucHoi)
        Panel1.Location = New Point(624, 3)
        Panel1.Name = "Panel1"
        TableLayoutPanel1.SetRowSpan(Panel1, 2)
        Panel1.Size = New Size(615, 444)
        Panel1.TabIndex = 8
        ' 
        ' bXoa
        ' 
        bXoa.Location = New Point(285, 240)
        bXoa.Name = "bXoa"
        bXoa.Size = New Size(94, 29)
        bXoa.TabIndex = 2
        bXoa.Text = "Xoa"
        bXoa.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(29, 163)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 20)
        Label4.TabIndex = 7
        Label4.Text = "Dien Thoai:"
        ' 
        ' tbTen
        ' 
        tbTen.Location = New Point(168, 17)
        tbTen.Name = "tbTen"
        tbTen.Size = New Size(125, 27)
        tbTen.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(29, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 20)
        Label3.TabIndex = 7
        Label3.Text = "Code:"
        ' 
        ' tbDiaChi
        ' 
        tbDiaChi.Location = New Point(168, 62)
        tbDiaChi.Name = "tbDiaChi"
        tbDiaChi.Size = New Size(125, 27)
        tbDiaChi.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(29, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 20)
        Label2.TabIndex = 7
        Label2.Text = "Dia chi:"
        ' 
        ' tbCode
        ' 
        tbCode.Location = New Point(168, 113)
        tbCode.Name = "tbCode"
        tbCode.Size = New Size(125, 27)
        tbCode.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(29, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(35, 20)
        Label1.TabIndex = 7
        Label1.Text = "Ten:"
        ' 
        ' tbDienThoai
        ' 
        tbDienThoai.Location = New Point(168, 163)
        tbDienThoai.Name = "tbDienThoai"
        tbDienThoai.Size = New Size(125, 27)
        tbDienThoai.TabIndex = 1
        ' 
        ' bThem
        ' 
        bThem.Location = New Point(29, 240)
        bThem.Name = "bThem"
        bThem.Size = New Size(94, 29)
        bThem.TabIndex = 2
        bThem.Text = "Them"
        bThem.UseVisualStyleBackColor = True
        ' 
        ' bCapNhat
        ' 
        bCapNhat.Location = New Point(167, 240)
        bCapNhat.Name = "bCapNhat"
        bCapNhat.Size = New Size(94, 29)
        bCapNhat.TabIndex = 2
        bCapNhat.Text = "Cap nhat"
        bCapNhat.UseVisualStyleBackColor = True
        ' 
        ' cbHienThiXoa
        ' 
        cbHienThiXoa.AutoSize = True
        cbHienThiXoa.Location = New Point(34, 308)
        cbHienThiXoa.Name = "cbHienThiXoa"
        cbHienThiXoa.Size = New Size(233, 24)
        cbHienThiXoa.TabIndex = 4
        cbHienThiXoa.Text = "Hien thi cac khach hang bi xoa"
        cbHienThiXoa.UseVisualStyleBackColor = True
        ' 
        ' bPhucHoi
        ' 
        bPhucHoi.Location = New Point(285, 303)
        bPhucHoi.Name = "bPhucHoi"
        bPhucHoi.Size = New Size(94, 29)
        bPhucHoi.TabIndex = 2
        bPhucHoi.Text = "Phuc hoi"
        bPhucHoi.UseVisualStyleBackColor = True
        ' 
        ' tbTimKiem
        ' 
        tbTimKiem.Anchor = AnchorStyles.None
        tbTimKiem.Location = New Point(152, 11)
        tbTimKiem.Name = "tbTimKiem"
        tbTimKiem.PlaceholderText = "Enter name to search"
        tbTimKiem.Size = New Size(316, 27)
        tbTimKiem.TabIndex = 0
        ' 
        ' frmKhachHang
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1242, 450)
        Controls.Add(TableLayoutPanel1)
        Name = "frmKhachHang"
        Text = "frmKhachHang"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(dgvDanhSach, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dgvDanhSach As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents bXoa As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents tbTen As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbDiaChi As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbCode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbDienThoai As TextBox
    Friend WithEvents bThem As Button
    Friend WithEvents bCapNhat As Button
    Friend WithEvents cbHienThiXoa As CheckBox
    Friend WithEvents bPhucHoi As Button
    Friend WithEvents tbTimKiem As TextBox
End Class
