<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSanPham
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
        bXoa = New Button()
        bCapNhat = New Button()
        bThem = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        tbMoTa = New TextBox()
        tbTen = New TextBox()
        tbMa = New TextBox()
        dgvSanPham = New DataGridView()
        tbTimKiem = New TextBox()
        cbLoaiSanPham = New ComboBox()
        Label4 = New Label()
        cbHienThiXoa = New CheckBox()
        bPhucHoi = New Button()
        Panel1 = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        CType(dgvSanPham, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' bXoa
        ' 
        bXoa.Location = New Point(260, 269)
        bXoa.Name = "bXoa"
        bXoa.Size = New Size(94, 29)
        bXoa.TabIndex = 15
        bXoa.Text = "Xoa"
        bXoa.UseVisualStyleBackColor = True
        ' 
        ' bCapNhat
        ' 
        bCapNhat.Location = New Point(135, 269)
        bCapNhat.Name = "bCapNhat"
        bCapNhat.Size = New Size(94, 29)
        bCapNhat.TabIndex = 14
        bCapNhat.Text = "Cap nhat"
        bCapNhat.UseVisualStyleBackColor = True
        ' 
        ' bThem
        ' 
        bThem.Location = New Point(8, 269)
        bThem.Name = "bThem"
        bThem.Size = New Size(94, 29)
        bThem.TabIndex = 13
        bThem.Text = "Them"
        bThem.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(11, 207)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 20)
        Label3.TabIndex = 9
        Label3.Text = "Mo ta:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(11, 134)
        Label2.Name = "Label2"
        Label2.Size = New Size(35, 20)
        Label2.TabIndex = 10
        Label2.Text = "Ten:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(11, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(33, 20)
        Label1.TabIndex = 11
        Label1.Text = "Ma:"
        ' 
        ' tbMoTa
        ' 
        tbMoTa.Location = New Point(135, 204)
        tbMoTa.Name = "tbMoTa"
        tbMoTa.Size = New Size(125, 27)
        tbMoTa.TabIndex = 12
        ' 
        ' tbTen
        ' 
        tbTen.Location = New Point(135, 131)
        tbTen.Name = "tbTen"
        tbTen.Size = New Size(125, 27)
        tbTen.TabIndex = 8
        ' 
        ' tbMa
        ' 
        tbMa.Location = New Point(135, 67)
        tbMa.Name = "tbMa"
        tbMa.Size = New Size(125, 27)
        tbMa.TabIndex = 7
        ' 
        ' dgvSanPham
        ' 
        dgvSanPham.AllowUserToAddRows = False
        dgvSanPham.AllowUserToDeleteRows = False
        dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSanPham.Dock = DockStyle.Fill
        dgvSanPham.Location = New Point(3, 54)
        dgvSanPham.Name = "dgvSanPham"
        dgvSanPham.RowHeadersWidth = 51
        dgvSanPham.Size = New Size(589, 393)
        dgvSanPham.TabIndex = 16
        ' 
        ' tbTimKiem
        ' 
        tbTimKiem.Anchor = AnchorStyles.Top
        tbTimKiem.Location = New Point(132, 3)
        tbTimKiem.Name = "tbTimKiem"
        tbTimKiem.Size = New Size(331, 27)
        tbTimKiem.TabIndex = 7
        ' 
        ' cbLoaiSanPham
        ' 
        cbLoaiSanPham.FormattingEnabled = True
        cbLoaiSanPham.Location = New Point(135, 9)
        cbLoaiSanPham.Name = "cbLoaiSanPham"
        cbLoaiSanPham.Size = New Size(125, 28)
        cbLoaiSanPham.TabIndex = 17
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(13, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 20)
        Label4.TabIndex = 11
        Label4.Text = "San pham:"
        ' 
        ' cbHienThiXoa
        ' 
        cbHienThiXoa.AutoSize = True
        cbHienThiXoa.Location = New Point(4, 334)
        cbHienThiXoa.Name = "cbHienThiXoa"
        cbHienThiXoa.Size = New Size(222, 24)
        cbHienThiXoa.TabIndex = 18
        cbHienThiXoa.Text = "Hien thi cac san pham bi xoa"
        cbHienThiXoa.UseVisualStyleBackColor = True
        ' 
        ' bPhucHoi
        ' 
        bPhucHoi.Location = New Point(260, 331)
        bPhucHoi.Name = "bPhucHoi"
        bPhucHoi.Size = New Size(94, 29)
        bPhucHoi.TabIndex = 19
        bPhucHoi.Text = "Phuc hoi"
        bPhucHoi.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.Controls.Add(bPhucHoi)
        Panel1.Controls.Add(cbHienThiXoa)
        Panel1.Controls.Add(cbLoaiSanPham)
        Panel1.Controls.Add(bXoa)
        Panel1.Controls.Add(bCapNhat)
        Panel1.Controls.Add(bThem)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(tbMoTa)
        Panel1.Controls.Add(tbTen)
        Panel1.Controls.Add(tbMa)
        Panel1.Location = New Point(708, 36)
        Panel1.Name = "Panel1"
        TableLayoutPanel1.SetRowSpan(Panel1, 2)
        Panel1.Size = New Size(369, 377)
        Panel1.TabIndex = 20
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(tbTimKiem, 0, 0)
        TableLayoutPanel1.Controls.Add(Panel1, 1, 0)
        TableLayoutPanel1.Controls.Add(dgvSanPham, 0, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 11.333333F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 88.6666641F))
        TableLayoutPanel1.Size = New Size(1190, 450)
        TableLayoutPanel1.TabIndex = 21
        ' 
        ' frmSanPham
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1190, 450)
        Controls.Add(TableLayoutPanel1)
        Name = "frmSanPham"
        Text = "frmSanPham"
        CType(dgvSanPham, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents bXoa As Button
    Friend WithEvents bCapNhat As Button
    Friend WithEvents bThem As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbMoTa As TextBox
    Friend WithEvents tbTen As TextBox
    Friend WithEvents tbMa As TextBox
    Friend WithEvents dgvSanPham As DataGridView
    Friend WithEvents tbTimKiem As TextBox
    Friend WithEvents cbLoaiSanPham As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbHienThiXoa As CheckBox
    Friend WithEvents bPhucHoi As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
