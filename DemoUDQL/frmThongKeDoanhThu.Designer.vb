<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThongKeDoanhThu
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
        DateTimePicker1 = New DateTimePicker()
        dgvDanhSach = New DataGridView()
        CType(dgvDanhSach, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CustomFormat = "MM/yyyy"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(12, 12)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.ShowUpDown = True
        DateTimePicker1.Size = New Size(155, 27)
        DateTimePicker1.TabIndex = 0
        ' 
        ' dgvDanhSach
        ' 
        dgvDanhSach.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDanhSach.Location = New Point(12, 47)
        dgvDanhSach.Name = "dgvDanhSach"
        dgvDanhSach.RowHeadersWidth = 51
        dgvDanhSach.Size = New Size(776, 391)
        dgvDanhSach.TabIndex = 1
        ' 
        ' frmThongKeDoanhThu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgvDanhSach)
        Controls.Add(DateTimePicker1)
        Name = "frmThongKeDoanhThu"
        Text = "frmThongKeDoanhThu"
        CType(dgvDanhSach, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents dgvDanhSach As DataGridView
End Class
