<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTonKho
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
        dgvDSTonKho = New DataGridView()
        bCapNhat = New Button()
        bTao = New Button()
        cbChiNhanh = New ComboBox()
        dtpNgayHienTai = New DateTimePicker()
        tbTimKiem = New TextBox()
        CType(dgvDSTonKho, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvDSTonKho
        ' 
        dgvDSTonKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDSTonKho.Location = New Point(24, 59)
        dgvDSTonKho.Name = "dgvDSTonKho"
        dgvDSTonKho.RowHeadersWidth = 51
        dgvDSTonKho.Size = New Size(753, 376)
        dgvDSTonKho.TabIndex = 10
        ' 
        ' bCapNhat
        ' 
        bCapNhat.Location = New Point(683, 19)
        bCapNhat.Name = "bCapNhat"
        bCapNhat.Size = New Size(94, 29)
        bCapNhat.TabIndex = 8
        bCapNhat.Text = "Cap nhat"
        bCapNhat.UseVisualStyleBackColor = True
        ' 
        ' bTao
        ' 
        bTao.Location = New Point(568, 19)
        bTao.Name = "bTao"
        bTao.Size = New Size(94, 29)
        bTao.TabIndex = 9
        bTao.Text = "Tao don"
        bTao.UseVisualStyleBackColor = True
        ' 
        ' cbChiNhanh
        ' 
        cbChiNhanh.FormattingEnabled = True
        cbChiNhanh.Location = New Point(411, 19)
        cbChiNhanh.Name = "cbChiNhanh"
        cbChiNhanh.Size = New Size(151, 28)
        cbChiNhanh.TabIndex = 7
        ' 
        ' dtpNgayHienTai
        ' 
        dtpNgayHienTai.CustomFormat = "yyyy-MM-dd"
        dtpNgayHienTai.Location = New Point(164, 17)
        dtpNgayHienTai.Name = "dtpNgayHienTai"
        dtpNgayHienTai.Size = New Size(225, 27)
        dtpNgayHienTai.TabIndex = 6
        ' 
        ' tbTimKiem
        ' 
        tbTimKiem.Location = New Point(24, 16)
        tbTimKiem.Name = "tbTimKiem"
        tbTimKiem.PlaceholderText = "Enter dh_ma"
        tbTimKiem.Size = New Size(125, 27)
        tbTimKiem.TabIndex = 5
        ' 
        ' frmTonKho
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgvDSTonKho)
        Controls.Add(bCapNhat)
        Controls.Add(bTao)
        Controls.Add(cbChiNhanh)
        Controls.Add(dtpNgayHienTai)
        Controls.Add(tbTimKiem)
        Name = "frmTonKho"
        Text = "frmTonKho"
        CType(dgvDSTonKho, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvDSTonKho As DataGridView
    Friend WithEvents bCapNhat As Button
    Friend WithEvents bTao As Button
    Friend WithEvents cbChiNhanh As ComboBox
    Friend WithEvents dtpNgayHienTai As DateTimePicker
    Friend WithEvents tbTimKiem As TextBox
End Class
