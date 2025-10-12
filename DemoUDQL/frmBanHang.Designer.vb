<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBanHang
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
        tbTimKiem = New TextBox()
        dtpNgayHienTai = New DateTimePicker()
        cbChiNhanh = New ComboBox()
        bTao = New Button()
        bCapNhat = New Button()
        dgvDSDonHang = New DataGridView()
        CType(dgvDSDonHang, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tbTimKiem
        ' 
        tbTimKiem.Location = New Point(12, 3)
        tbTimKiem.Name = "tbTimKiem"
        tbTimKiem.PlaceholderText = "Enter dh_ma"
        tbTimKiem.Size = New Size(125, 27)
        tbTimKiem.TabIndex = 0
        ' 
        ' dtpNgayHienTai
        ' 
        dtpNgayHienTai.CustomFormat = "yyyy-MM-dd"
        dtpNgayHienTai.Location = New Point(152, 4)
        dtpNgayHienTai.Name = "dtpNgayHienTai"
        dtpNgayHienTai.Size = New Size(225, 27)
        dtpNgayHienTai.TabIndex = 1
        ' 
        ' cbChiNhanh
        ' 
        cbChiNhanh.FormattingEnabled = True
        cbChiNhanh.Location = New Point(399, 6)
        cbChiNhanh.Name = "cbChiNhanh"
        cbChiNhanh.Size = New Size(151, 28)
        cbChiNhanh.TabIndex = 2
        ' 
        ' bTao
        ' 
        bTao.Location = New Point(556, 6)
        bTao.Name = "bTao"
        bTao.Size = New Size(94, 29)
        bTao.TabIndex = 3
        bTao.Text = "Tao don"
        bTao.UseVisualStyleBackColor = True
        ' 
        ' bCapNhat
        ' 
        bCapNhat.Location = New Point(671, 6)
        bCapNhat.Name = "bCapNhat"
        bCapNhat.Size = New Size(94, 29)
        bCapNhat.TabIndex = 3
        bCapNhat.Text = "Cap nhat"
        bCapNhat.UseVisualStyleBackColor = True
        ' 
        ' dgvDSDonHang
        ' 
        dgvDSDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDSDonHang.Location = New Point(12, 46)
        dgvDSDonHang.Name = "dgvDSDonHang"
        dgvDSDonHang.RowHeadersWidth = 51
        dgvDSDonHang.Size = New Size(753, 376)
        dgvDSDonHang.TabIndex = 4
        ' 
        ' frmBanHang
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgvDSDonHang)
        Controls.Add(bCapNhat)
        Controls.Add(bTao)
        Controls.Add(cbChiNhanh)
        Controls.Add(dtpNgayHienTai)
        Controls.Add(tbTimKiem)
        Name = "frmBanHang"
        Text = "frmBanHang"
        CType(dgvDSDonHang, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tbTimKiem As TextBox
    Friend WithEvents dtpNgayHienTai As DateTimePicker
    Friend WithEvents cbChiNhanh As ComboBox
    Friend WithEvents bTao As Button
    Friend WithEvents bCapNhat As Button
    Friend WithEvents dgvDSDonHang As DataGridView
End Class
