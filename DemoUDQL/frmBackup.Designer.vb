<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackup
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
        bBackup = New Button()
        bRestore = New Button()
        lStatus = New Label()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' bBackup
        ' 
        bBackup.Location = New Point(31, 81)
        bBackup.Name = "bBackup"
        bBackup.Size = New Size(94, 29)
        bBackup.TabIndex = 0
        bBackup.Text = "Backup"
        bBackup.UseVisualStyleBackColor = True
        ' 
        ' bRestore
        ' 
        bRestore.Location = New Point(31, 147)
        bRestore.Name = "bRestore"
        bRestore.Size = New Size(94, 29)
        bRestore.TabIndex = 0
        bRestore.Text = "Restore"
        bRestore.UseVisualStyleBackColor = True
        ' 
        ' lStatus
        ' 
        lStatus.AutoSize = True
        lStatus.Location = New Point(52, 20)
        lStatus.Name = "lStatus"
        lStatus.Size = New Size(49, 20)
        lStatus.TabIndex = 0
        lStatus.Text = "Status"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.Controls.Add(lStatus)
        Panel1.Controls.Add(bRestore)
        Panel1.Controls.Add(bBackup)
        Panel1.Location = New Point(284, 113)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(165, 208)
        Panel1.TabIndex = 1
        ' 
        ' frmBackup
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Name = "frmBackup"
        Text = "frmBackup"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents bBackup As Button
    Friend WithEvents bRestore As Button
    Friend WithEvents lStatus As Label
    Friend WithEvents Panel1 As Panel
End Class
