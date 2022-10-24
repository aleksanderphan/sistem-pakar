<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPengunjung
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
        Me.dgvPengunjung = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TambahPengunjungBaruToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvPengunjung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPengunjung
        '
        Me.dgvPengunjung.AllowUserToAddRows = False
        Me.dgvPengunjung.AllowUserToDeleteRows = False
        Me.dgvPengunjung.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPengunjung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPengunjung.Location = New System.Drawing.Point(12, 27)
        Me.dgvPengunjung.Name = "dgvPengunjung"
        Me.dgvPengunjung.ReadOnly = True
        Me.dgvPengunjung.Size = New System.Drawing.Size(308, 211)
        Me.dgvPengunjung.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahPengunjungBaruToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(332, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TambahPengunjungBaruToolStripMenuItem
        '
        Me.TambahPengunjungBaruToolStripMenuItem.Name = "TambahPengunjungBaruToolStripMenuItem"
        Me.TambahPengunjungBaruToolStripMenuItem.Size = New System.Drawing.Size(156, 20)
        Me.TambahPengunjungBaruToolStripMenuItem.Text = "Tambah Pengunjung Baru"
        '
        'FrmPengunjung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 250)
        Me.Controls.Add(Me.dgvPengunjung)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmPengunjung"
        Me.Text = "Daftar Pengunjung"
        CType(Me.dgvPengunjung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvPengunjung As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TambahPengunjungBaruToolStripMenuItem As ToolStripMenuItem
End Class
