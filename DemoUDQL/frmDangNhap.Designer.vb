<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangNhap
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
        tbTenDangNhap = New TextBox()
        tbMatKhau = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label9 = New Label()
        bDangNhap = New Button()
        bThoat = New Button()
        lKetQua = New Label()
        SuspendLayout()
        ' 
        ' tbTenDangNhap
        ' 
        tbTenDangNhap.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tbTenDangNhap.Location = New Point(258, 121)
        tbTenDangNhap.Name = "tbTenDangNhap"
        tbTenDangNhap.Size = New Size(246, 27)
        tbTenDangNhap.TabIndex = 0
        tbTenDangNhap.Text = "test2"
        ' 
        ' tbMatKhau
        ' 
        tbMatKhau.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tbMatKhau.Location = New Point(258, 193)
        tbMatKhau.Name = "tbMatKhau"
        tbMatKhau.PasswordChar = "*"c
        tbMatKhau.Size = New Size(246, 27)
        tbMatKhau.TabIndex = 0
        tbMatKhau.Text = "1"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Location = New Point(148, 123)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 1
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Location = New Point(141, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 20)
        Label2.TabIndex = 1
        Label2.Text = "Ten Dang Nhap"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Location = New Point(141, 196)
        Label9.Name = "Label9"
        Label9.Size = New Size(72, 20)
        Label9.TabIndex = 1
        Label9.Text = "Mat Khau"
        ' 
        ' bDangNhap
        ' 
        bDangNhap.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        bDangNhap.Location = New Point(595, 119)
        bDangNhap.Name = "bDangNhap"
        bDangNhap.Size = New Size(94, 29)
        bDangNhap.TabIndex = 2
        bDangNhap.Text = "Dang nhap"
        bDangNhap.UseVisualStyleBackColor = True
        ' 
        ' bThoat
        ' 
        bThoat.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        bThoat.Location = New Point(595, 196)
        bThoat.Name = "bThoat"
        bThoat.Size = New Size(94, 29)
        bThoat.TabIndex = 2
        bThoat.Text = "Thoat"
        bThoat.UseVisualStyleBackColor = True
        ' 
        ' lKetQua
        ' 
        lKetQua.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lKetQua.AutoSize = True
        lKetQua.Location = New Point(339, 279)
        lKetQua.Name = "lKetQua"
        lKetQua.Size = New Size(82, 20)
        lKetQua.TabIndex = 1
        lKetQua.Text = "Login Page"
        ' 
        ' frmDangNhap
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(bThoat)
        Controls.Add(bDangNhap)
        Controls.Add(lKetQua)
        Controls.Add(Label9)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(tbMatKhau)
        Controls.Add(tbTenDangNhap)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmDangNhap"
        Text = "frmDangNhap"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tbTenDangNhap As TextBox
    Friend WithEvents tbMatKhau As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents bDangNhap As Button
    Friend WithEvents bThoat As Button
    Friend WithEvents lKetQua As Label
End Class
