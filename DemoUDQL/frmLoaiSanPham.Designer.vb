<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoaiSanPham
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        dgvLoaiSanPham = New DataGridView()
        tbMa = New TextBox()
        Label1 = New Label()
        tbTen = New TextBox()
        Label2 = New Label()
        tbMoTa = New TextBox()
        Label3 = New Label()
        bThem = New Button()
        bCapNhat = New Button()
        bXoa = New Button()
        Panel1 = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        CType(dgvLoaiSanPham, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvLoaiSanPham
        ' 
        dgvLoaiSanPham.AllowUserToAddRows = False
        dgvLoaiSanPham.AllowUserToDeleteRows = False
        dgvLoaiSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvLoaiSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLoaiSanPham.Dock = DockStyle.Fill
        dgvLoaiSanPham.Location = New Point(3, 3)
        dgvLoaiSanPham.Name = "dgvLoaiSanPham"
        dgvLoaiSanPham.RowHeadersWidth = 51
        dgvLoaiSanPham.Size = New Size(608, 444)
        dgvLoaiSanPham.TabIndex = 6
        ' 
        ' tbMa
        ' 
        tbMa.Location = New Point(142, 15)
        tbMa.Name = "tbMa"
        tbMa.Size = New Size(125, 27)
        tbMa.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(18, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(33, 20)
        Label1.TabIndex = 2
        Label1.Text = "Ma:"
        ' 
        ' tbTen
        ' 
        tbTen.Location = New Point(142, 79)
        tbTen.Name = "tbTen"
        tbTen.Size = New Size(125, 27)
        tbTen.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(18, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(35, 20)
        Label2.TabIndex = 2
        Label2.Text = "Ten:"
        ' 
        ' tbMoTa
        ' 
        tbMoTa.Location = New Point(142, 152)
        tbMoTa.Name = "tbMoTa"
        tbMoTa.Size = New Size(125, 27)
        tbMoTa.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(18, 155)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 20)
        Label3.TabIndex = 2
        Label3.Text = "Mo ta:"
        ' 
        ' bThem
        ' 
        bThem.Location = New Point(15, 217)
        bThem.Name = "bThem"
        bThem.Size = New Size(94, 29)
        bThem.TabIndex = 3
        bThem.Text = "Them"
        bThem.UseVisualStyleBackColor = True
        ' 
        ' bCapNhat
        ' 
        bCapNhat.Location = New Point(142, 217)
        bCapNhat.Name = "bCapNhat"
        bCapNhat.Size = New Size(94, 29)
        bCapNhat.TabIndex = 4
        bCapNhat.Text = "Cap nhat"
        bCapNhat.UseVisualStyleBackColor = True
        ' 
        ' bXoa
        ' 
        bXoa.Location = New Point(267, 217)
        bXoa.Name = "bXoa"
        bXoa.Size = New Size(94, 29)
        bXoa.TabIndex = 5
        bXoa.Text = "Xoa"
        bXoa.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.Controls.Add(bXoa)
        Panel1.Controls.Add(tbMa)
        Panel1.Controls.Add(bCapNhat)
        Panel1.Controls.Add(tbTen)
        Panel1.Controls.Add(bThem)
        Panel1.Controls.Add(tbMoTa)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(735, 96)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(371, 258)
        Panel1.TabIndex = 7
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(dgvLoaiSanPham, 0, 0)
        TableLayoutPanel1.Controls.Add(Panel1, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(1228, 450)
        TableLayoutPanel1.TabIndex = 8
        ' 
        ' frmLoaiSanPham
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1228, 450)
        Controls.Add(TableLayoutPanel1)
        Name = "frmLoaiSanPham"
        Text = "frmLoaiSanPham"
        CType(dgvLoaiSanPham, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvLoaiSanPham As DataGridView
    Friend WithEvents tbMa As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbTen As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbMoTa As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents bThem As Button
    Friend WithEvents bCapNhat As Button
    Friend WithEvents bXoa As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
