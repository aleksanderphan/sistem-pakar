<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmObat
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
        Me.dgvObat = New System.Windows.Forms.DataGridView()
        Me.grpObat = New System.Windows.Forms.GroupBox()
        Me.grpDetail = New System.Windows.Forms.GroupBox()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.lblNamaObat = New System.Windows.Forms.Label()
        Me.txtNamaObat = New System.Windows.Forms.TextBox()
        Me.grpFungsi = New System.Windows.Forms.GroupBox()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        CType(Me.dgvObat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpObat.SuspendLayout()
        Me.grpDetail.SuspendLayout()
        Me.grpFungsi.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvObat
        '
        Me.dgvObat.AllowUserToAddRows = False
        Me.dgvObat.AllowUserToDeleteRows = False
        Me.dgvObat.AllowUserToOrderColumns = True
        Me.dgvObat.AllowUserToResizeRows = False
        Me.dgvObat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvObat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvObat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvObat.Location = New System.Drawing.Point(6, 19)
        Me.dgvObat.MultiSelect = False
        Me.dgvObat.Name = "dgvObat"
        Me.dgvObat.ReadOnly = True
        Me.dgvObat.RowHeadersVisible = False
        Me.dgvObat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvObat.Size = New System.Drawing.Size(361, 401)
        Me.dgvObat.TabIndex = 0
        Me.dgvObat.TabStop = False
        '
        'grpObat
        '
        Me.grpObat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpObat.Controls.Add(Me.dgvObat)
        Me.grpObat.Location = New System.Drawing.Point(12, 12)
        Me.grpObat.Name = "grpObat"
        Me.grpObat.Size = New System.Drawing.Size(373, 426)
        Me.grpObat.TabIndex = 1
        Me.grpObat.TabStop = False
        Me.grpObat.Text = "Daftar Obat"
        '
        'grpDetail
        '
        Me.grpDetail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDetail.Controls.Add(Me.txtKode)
        Me.grpDetail.Controls.Add(Me.txtHarga)
        Me.grpDetail.Controls.Add(Me.lblHarga)
        Me.grpDetail.Controls.Add(Me.lblNamaObat)
        Me.grpDetail.Controls.Add(Me.txtNamaObat)
        Me.grpDetail.Location = New System.Drawing.Point(391, 12)
        Me.grpDetail.Name = "grpDetail"
        Me.grpDetail.Size = New System.Drawing.Size(397, 120)
        Me.grpDetail.TabIndex = 2
        Me.grpDetail.TabStop = False
        Me.grpDetail.Text = "Detail"
        '
        'txtKode
        '
        Me.txtKode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKode.Enabled = False
        Me.txtKode.Location = New System.Drawing.Point(366, 11)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.ReadOnly = True
        Me.txtKode.Size = New System.Drawing.Size(25, 20)
        Me.txtKode.TabIndex = 9
        Me.txtKode.TabStop = False
        Me.txtKode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHarga
        '
        Me.txtHarga.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHarga.Location = New System.Drawing.Point(80, 86)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.ReadOnly = True
        Me.txtHarga.Size = New System.Drawing.Size(311, 20)
        Me.txtHarga.TabIndex = 1
        '
        'lblHarga
        '
        Me.lblHarga.AutoSize = True
        Me.lblHarga.Location = New System.Drawing.Point(6, 89)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(68, 13)
        Me.lblHarga.TabIndex = 2
        Me.lblHarga.Text = "Harga Obat :"
        '
        'lblNamaObat
        '
        Me.lblNamaObat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNamaObat.AutoSize = True
        Me.lblNamaObat.Location = New System.Drawing.Point(6, 21)
        Me.lblNamaObat.Name = "lblNamaObat"
        Me.lblNamaObat.Size = New System.Drawing.Size(67, 13)
        Me.lblNamaObat.TabIndex = 1
        Me.lblNamaObat.Text = "Nama Obat :"
        '
        'txtNamaObat
        '
        Me.txtNamaObat.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNamaObat.Location = New System.Drawing.Point(6, 37)
        Me.txtNamaObat.Multiline = True
        Me.txtNamaObat.Name = "txtNamaObat"
        Me.txtNamaObat.ReadOnly = True
        Me.txtNamaObat.Size = New System.Drawing.Size(385, 40)
        Me.txtNamaObat.TabIndex = 0
        '
        'grpFungsi
        '
        Me.grpFungsi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFungsi.Controls.Add(Me.btnInsert)
        Me.grpFungsi.Controls.Add(Me.btnDelete)
        Me.grpFungsi.Controls.Add(Me.btnSave)
        Me.grpFungsi.Controls.Add(Me.btnEdit)
        Me.grpFungsi.Location = New System.Drawing.Point(391, 138)
        Me.grpFungsi.Name = "grpFungsi"
        Me.grpFungsi.Size = New System.Drawing.Size(397, 55)
        Me.grpFungsi.TabIndex = 3
        Me.grpFungsi.TabStop = False
        Me.grpFungsi.Text = "Fungsi"
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(6, 19)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 0
        Me.btnInsert.Text = "Baru"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(235, 19)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Hapus"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(316, 19)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Simpan"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(87, 19)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'FrmObat
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grpFungsi)
        Me.Controls.Add(Me.grpDetail)
        Me.Controls.Add(Me.grpObat)
        Me.Name = "FrmObat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Database Obat"
        CType(Me.dgvObat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpObat.ResumeLayout(False)
        Me.grpDetail.ResumeLayout(False)
        Me.grpDetail.PerformLayout()
        Me.grpFungsi.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvObat As DataGridView
    Friend WithEvents grpObat As GroupBox
    Friend WithEvents grpDetail As GroupBox
    Friend WithEvents txtNamaObat As TextBox
    Friend WithEvents lblNamaObat As Label
    Friend WithEvents grpFungsi As GroupBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents lblHarga As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents txtKode As TextBox
End Class
