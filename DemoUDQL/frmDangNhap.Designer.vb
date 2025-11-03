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
        tbTenDangNhap.Location = New Point(253, 65)
        tbTenDangNhap.Name = "tbTenDangNhap"
        tbTenDangNhap.Size = New Size(246, 27)
        tbTenDangNhap.TabIndex = 0
        ' 
        ' tbMatKhau
        ' 
        tbMatKhau.Location = New Point(253, 137)
        tbMatKhau.Name = "tbMatKhau"
        tbMatKhau.PasswordChar = "*"c
        tbMatKhau.Size = New Size(246, 27)
        tbMatKhau.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(143, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 1
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(136, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 20)
        Label2.TabIndex = 1
        Label2.Text = "Ten Dang Nhap"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(136, 140)
        Label9.Name = "Label9"
        Label9.Size = New Size(72, 20)
        Label9.TabIndex = 1
        Label9.Text = "Mat Khau"
        ' 
        ' bDangNhap
        ' 
        bDangNhap.Location = New Point(590, 63)
        bDangNhap.Name = "bDangNhap"
        bDangNhap.Size = New Size(94, 29)
        bDangNhap.TabIndex = 2
        bDangNhap.Text = "Dang nhap"
        bDangNhap.UseVisualStyleBackColor = True
        ' 
        ' bThoat
        ' 
        bThoat.Location = New Point(590, 140)
        bThoat.Name = "bThoat"
        bThoat.Size = New Size(94, 29)
        bThoat.TabIndex = 2
        bThoat.Text = "Thoat"
        bThoat.UseVisualStyleBackColor = True
        ' 
        ' lKetQua
        ' 
        lKetQua.AutoSize = True
        lKetQua.Location = New Point(334, 223)
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
