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
        Me.lblNamaObat = New System.Windows.Forms.Label()
        Me.txtNamaObat = New System.Windows.Forms.TextBox()
        Me.grpFungsi = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
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
        Me.grpDetail.Controls.Add(Me.txtHarga)
        Me.grpDetail.Controls.Add(Me.lblHarga)
        Me.grpDetail.Controls.Add(Me.lblNamaObat)
        Me.grpDetail.Controls.Add(Me.txtNamaObat)
        Me.grpDetail.Location = New System.Drawing.Point(391, 12)
        Me.grpDetail.Name = "grpDetail"
        Me.grpDetail.Size = New System.Drawing.Size(397, 125)
        Me.grpDetail.TabIndex = 2
        Me.grpDetail.TabStop = False
        Me.grpDetail.Text = "Detail"
        '
        'lblNamaObat
        '
        Me.lblNamaObat.AutoSize = True
        Me.lblNamaObat.Location = New System.Drawing.Point(6, 19)
        Me.lblNamaObat.Name = "lblNamaObat"
        Me.lblNamaObat.Size = New System.Drawing.Size(67, 13)
        Me.lblNamaObat.TabIndex = 1
        Me.lblNamaObat.Text = "Nama Obat :"
        '
        'txtNamaObat
        '
        Me.txtNamaObat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNamaObat.Location = New System.Drawing.Point(6, 35)
        Me.txtNamaObat.Multiline = True
        Me.txtNamaObat.Name = "txtNamaObat"
        Me.txtNamaObat.ReadOnly = True
        Me.txtNamaObat.Size = New System.Drawing.Size(385, 40)
        Me.txtNamaObat.TabIndex = 0
        Me.txtNamaObat.TabStop = False
        '
        'grpFungsi
        '
        Me.grpFungsi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFungsi.Controls.Add(Me.btnSave)
        Me.grpFungsi.Controls.Add(Me.btnEdit)
        Me.grpFungsi.Location = New System.Drawing.Point(391, 143)
        Me.grpFungsi.Name = "grpFungsi"
        Me.grpFungsi.Size = New System.Drawing.Size(397, 55)
        Me.grpFungsi.TabIndex = 3
        Me.grpFungsi.TabStop = False
        Me.grpFungsi.Text = "Fungsi"
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(87, 19)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Simpan"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(6, 19)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 0
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'lblHarga
        '
        Me.lblHarga.AutoSize = True
        Me.lblHarga.Location = New System.Drawing.Point(6, 97)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(68, 13)
        Me.lblHarga.TabIndex = 2
        Me.lblHarga.Text = "Harga Obat :"
        '
        'txtHarga
        '
        Me.txtHarga.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHarga.Location = New System.Drawing.Point(80, 94)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.ReadOnly = True
        Me.txtHarga.Size = New System.Drawing.Size(311, 20)
        Me.txtHarga.TabIndex = 3
        Me.txtHarga.TabStop = False
        '
        'FrmObat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grpFungsi)
        Me.Controls.Add(Me.grpDetail)
        Me.Controls.Add(Me.grpObat)
        Me.Name = "FrmObat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Obat"
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
End Class
