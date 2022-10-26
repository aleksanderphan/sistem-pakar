<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGejala
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
        Me.grpGejala = New System.Windows.Forms.GroupBox()
        Me.dgvGejala = New System.Windows.Forms.DataGridView()
        Me.grpFunction = New System.Windows.Forms.GroupBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.lblYa = New System.Windows.Forms.Label()
        Me.lblTidak = New System.Windows.Forms.Label()
        Me.grpQnA = New System.Windows.Forms.GroupBox()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.lblQ = New System.Windows.Forms.Label()
        Me.txtQ = New System.Windows.Forms.TextBox()
        Me.cboJikaTidak = New System.Windows.Forms.ComboBox()
        Me.cboJikaYa = New System.Windows.Forms.ComboBox()
        Me.grpGejala.SuspendLayout()
        CType(Me.dgvGejala, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFunction.SuspendLayout()
        Me.grpQnA.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpGejala
        '
        Me.grpGejala.Controls.Add(Me.dgvGejala)
        Me.grpGejala.Location = New System.Drawing.Point(12, 12)
        Me.grpGejala.Name = "grpGejala"
        Me.grpGejala.Size = New System.Drawing.Size(468, 288)
        Me.grpGejala.TabIndex = 0
        Me.grpGejala.TabStop = False
        Me.grpGejala.Text = "Daftar Gejala"
        '
        'dgvGejala
        '
        Me.dgvGejala.AllowUserToAddRows = False
        Me.dgvGejala.AllowUserToDeleteRows = False
        Me.dgvGejala.AllowUserToResizeRows = False
        Me.dgvGejala.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvGejala.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvGejala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGejala.Location = New System.Drawing.Point(6, 19)
        Me.dgvGejala.MultiSelect = False
        Me.dgvGejala.Name = "dgvGejala"
        Me.dgvGejala.ReadOnly = True
        Me.dgvGejala.RowHeadersVisible = False
        Me.dgvGejala.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGejala.Size = New System.Drawing.Size(456, 263)
        Me.dgvGejala.TabIndex = 1
        '
        'grpFunction
        '
        Me.grpFunction.Controls.Add(Me.btnConfirm)
        Me.grpFunction.Controls.Add(Me.btnEdit)
        Me.grpFunction.Controls.Add(Me.btnDelete)
        Me.grpFunction.Controls.Add(Me.btnNew)
        Me.grpFunction.Location = New System.Drawing.Point(486, 147)
        Me.grpFunction.Name = "grpFunction"
        Me.grpFunction.Size = New System.Drawing.Size(174, 78)
        Me.grpFunction.TabIndex = 1
        Me.grpFunction.TabStop = False
        Me.grpFunction.Text = "Fungsi"
        '
        'btnConfirm
        '
        Me.btnConfirm.Enabled = False
        Me.btnConfirm.Location = New System.Drawing.Point(93, 48)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirm.TabIndex = 3
        Me.btnConfirm.Text = "Simpan"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(93, 19)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(6, 48)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Hapus"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(6, 19)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "Baru"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'lblYa
        '
        Me.lblYa.AutoSize = True
        Me.lblYa.Location = New System.Drawing.Point(99, 86)
        Me.lblYa.Name = "lblYa"
        Me.lblYa.Size = New System.Drawing.Size(48, 13)
        Me.lblYa.TabIndex = 4
        Me.lblYa.Text = "Jika Ya :"
        '
        'lblTidak
        '
        Me.lblTidak.AutoSize = True
        Me.lblTidak.Location = New System.Drawing.Point(199, 86)
        Me.lblTidak.Name = "lblTidak"
        Me.lblTidak.Size = New System.Drawing.Size(62, 13)
        Me.lblTidak.TabIndex = 5
        Me.lblTidak.Text = "Jika Tidak :"
        '
        'grpQnA
        '
        Me.grpQnA.Controls.Add(Me.txtKode)
        Me.grpQnA.Controls.Add(Me.lblQ)
        Me.grpQnA.Controls.Add(Me.txtQ)
        Me.grpQnA.Controls.Add(Me.cboJikaTidak)
        Me.grpQnA.Controls.Add(Me.cboJikaYa)
        Me.grpQnA.Controls.Add(Me.lblYa)
        Me.grpQnA.Controls.Add(Me.lblTidak)
        Me.grpQnA.Location = New System.Drawing.Point(486, 12)
        Me.grpQnA.Name = "grpQnA"
        Me.grpQnA.Size = New System.Drawing.Size(302, 129)
        Me.grpQnA.TabIndex = 6
        Me.grpQnA.TabStop = False
        Me.grpQnA.Text = "Pertanyaan Gejala"
        '
        'txtKode
        '
        Me.txtKode.Location = New System.Drawing.Point(276, 11)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.ReadOnly = True
        Me.txtKode.Size = New System.Drawing.Size(20, 20)
        Me.txtKode.TabIndex = 11
        Me.txtKode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblQ
        '
        Me.lblQ.AutoSize = True
        Me.lblQ.Location = New System.Drawing.Point(6, 18)
        Me.lblQ.Name = "lblQ"
        Me.lblQ.Size = New System.Drawing.Size(67, 13)
        Me.lblQ.TabIndex = 10
        Me.lblQ.Text = "Pertanyaan :"
        '
        'txtQ
        '
        Me.txtQ.Location = New System.Drawing.Point(6, 34)
        Me.txtQ.Multiline = True
        Me.txtQ.Name = "txtQ"
        Me.txtQ.Size = New System.Drawing.Size(290, 40)
        Me.txtQ.TabIndex = 9
        '
        'cboJikaTidak
        '
        Me.cboJikaTidak.FormattingEnabled = True
        Me.cboJikaTidak.Location = New System.Drawing.Point(202, 102)
        Me.cboJikaTidak.Name = "cboJikaTidak"
        Me.cboJikaTidak.Size = New System.Drawing.Size(94, 21)
        Me.cboJikaTidak.TabIndex = 8
        '
        'cboJikaYa
        '
        Me.cboJikaYa.FormattingEnabled = True
        Me.cboJikaYa.Location = New System.Drawing.Point(102, 102)
        Me.cboJikaYa.Name = "cboJikaYa"
        Me.cboJikaYa.Size = New System.Drawing.Size(94, 21)
        Me.cboJikaYa.TabIndex = 7
        '
        'FrmGejala
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grpQnA)
        Me.Controls.Add(Me.grpFunction)
        Me.Controls.Add(Me.grpGejala)
        Me.Name = "FrmGejala"
        Me.Text = "Master Gejala"
        Me.grpGejala.ResumeLayout(False)
        CType(Me.dgvGejala, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFunction.ResumeLayout(False)
        Me.grpQnA.ResumeLayout(False)
        Me.grpQnA.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpGejala As GroupBox
    Friend WithEvents dgvGejala As DataGridView
    Friend WithEvents grpFunction As GroupBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblYa As Label
    Friend WithEvents lblTidak As Label
    Friend WithEvents grpQnA As GroupBox
    Friend WithEvents cboJikaTidak As ComboBox
    Friend WithEvents cboJikaYa As ComboBox
    Friend WithEvents lblQ As Label
    Friend WithEvents txtQ As TextBox
    Friend WithEvents txtKode As TextBox
End Class
