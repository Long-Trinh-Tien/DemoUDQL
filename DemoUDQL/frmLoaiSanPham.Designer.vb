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
        CType(dgvLoaiSanPham, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvLoaiSanPham
        ' 
        dgvLoaiSanPham.AllowUserToAddRows = False
        dgvLoaiSanPham.AllowUserToDeleteRows = False
        dgvLoaiSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLoaiSanPham.Location = New Point(3, 3)
        dgvLoaiSanPham.Name = "dgvLoaiSanPham"
        dgvLoaiSanPham.RowHeadersWidth = 51
        dgvLoaiSanPham.Size = New Size(331, 445)
        dgvLoaiSanPham.TabIndex = 6
        ' 
        ' tbMa
        ' 
        tbMa.Location = New Point(491, 23)
        tbMa.Name = "tbMa"
        tbMa.Size = New Size(125, 27)
        tbMa.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(367, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(33, 20)
        Label1.TabIndex = 2
        Label1.Text = "Ma:"
        ' 
        ' tbTen
        ' 
        tbTen.Location = New Point(491, 87)
        tbTen.Name = "tbTen"
        tbTen.Size = New Size(125, 27)
        tbTen.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(367, 90)
        Label2.Name = "Label2"
        Label2.Size = New Size(35, 20)
        Label2.TabIndex = 2
        Label2.Text = "Ten:"
        ' 
        ' tbMoTa
        ' 
        tbMoTa.Location = New Point(491, 160)
        tbMoTa.Name = "tbMoTa"
        tbMoTa.Size = New Size(125, 27)
        tbMoTa.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(367, 163)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 20)
        Label3.TabIndex = 2
        Label3.Text = "Mo ta:"
        ' 
        ' bThem
        ' 
        bThem.Location = New Point(364, 225)
        bThem.Name = "bThem"
        bThem.Size = New Size(94, 29)
        bThem.TabIndex = 3
        bThem.Text = "Them"
        bThem.UseVisualStyleBackColor = True
        ' 
        ' bCapNhat
        ' 
        bCapNhat.Location = New Point(491, 225)
        bCapNhat.Name = "bCapNhat"
        bCapNhat.Size = New Size(94, 29)
        bCapNhat.TabIndex = 4
        bCapNhat.Text = "Cap nhat"
        bCapNhat.UseVisualStyleBackColor = True
        ' 
        ' bXoa
        ' 
        bXoa.Location = New Point(616, 225)
        bXoa.Name = "bXoa"
        bXoa.Size = New Size(94, 29)
        bXoa.TabIndex = 5
        bXoa.Text = "Xoa"
        bXoa.UseVisualStyleBackColor = True
        ' 
        ' frmLoaiSanPham
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(bXoa)
        Controls.Add(bCapNhat)
        Controls.Add(bThem)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(tbMoTa)
        Controls.Add(tbTen)
        Controls.Add(tbMa)
        Controls.Add(dgvLoaiSanPham)
        Name = "frmLoaiSanPham"
        Text = "frmLoaiSanPham"
        CType(dgvLoaiSanPham, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
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
End Class
