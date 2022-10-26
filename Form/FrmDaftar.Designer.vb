<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDaftar
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
        Me.grpForm = New System.Windows.Forms.GroupBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtUsia = New System.Windows.Forms.TextBox()
        Me.txtNIK = New System.Windows.Forms.TextBox()
        Me.lblUsia = New System.Windows.Forms.Label()
        Me.lblNIK = New System.Windows.Forms.Label()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblJK = New System.Windows.Forms.Label()
        Me.cboJK = New System.Windows.Forms.ComboBox()
        Me.grpForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpForm
        '
        Me.grpForm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpForm.Controls.Add(Me.cboJK)
        Me.grpForm.Controls.Add(Me.lblJK)
        Me.grpForm.Controls.Add(Me.txtPass)
        Me.grpForm.Controls.Add(Me.lblPass)
        Me.grpForm.Controls.Add(Me.txtAlamat)
        Me.grpForm.Controls.Add(Me.txtUsia)
        Me.grpForm.Controls.Add(Me.txtNIK)
        Me.grpForm.Controls.Add(Me.lblUsia)
        Me.grpForm.Controls.Add(Me.lblNIK)
        Me.grpForm.Controls.Add(Me.lblAlamat)
        Me.grpForm.Controls.Add(Me.txtNama)
        Me.grpForm.Controls.Add(Me.lblNama)
        Me.grpForm.Location = New System.Drawing.Point(12, 12)
        Me.grpForm.Name = "grpForm"
        Me.grpForm.Size = New System.Drawing.Size(313, 163)
        Me.grpForm.TabIndex = 0
        Me.grpForm.TabStop = False
        Me.grpForm.Text = "Form Pendaftaran"
        '
        'txtPass
        '
        Me.txtPass.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPass.Location = New System.Drawing.Point(98, 130)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPass.Size = New System.Drawing.Size(200, 20)
        Me.txtPass.TabIndex = 11
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(33, 133)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(59, 13)
        Me.lblPass.TabIndex = 10
        Me.lblPass.Text = "Password :"
        '
        'txtAlamat
        '
        Me.txtAlamat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAlamat.Location = New System.Drawing.Point(98, 104)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(200, 20)
        Me.txtAlamat.TabIndex = 9
        '
        'txtUsia
        '
        Me.txtUsia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUsia.Location = New System.Drawing.Point(98, 78)
        Me.txtUsia.MaxLength = 2
        Me.txtUsia.Name = "txtUsia"
        Me.txtUsia.Size = New System.Drawing.Size(66, 20)
        Me.txtUsia.TabIndex = 8
        '
        'txtNIK
        '
        Me.txtNIK.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNIK.Location = New System.Drawing.Point(98, 52)
        Me.txtNIK.MaxLength = 16
        Me.txtNIK.Name = "txtNIK"
        Me.txtNIK.Size = New System.Drawing.Size(200, 20)
        Me.txtNIK.TabIndex = 7
        '
        'lblUsia
        '
        Me.lblUsia.AutoSize = True
        Me.lblUsia.Location = New System.Drawing.Point(58, 81)
        Me.lblUsia.Name = "lblUsia"
        Me.lblUsia.Size = New System.Drawing.Size(34, 13)
        Me.lblUsia.TabIndex = 5
        Me.lblUsia.Text = "Usia :"
        '
        'lblNIK
        '
        Me.lblNIK.AutoSize = True
        Me.lblNIK.Location = New System.Drawing.Point(61, 55)
        Me.lblNIK.Name = "lblNIK"
        Me.lblNIK.Size = New System.Drawing.Size(31, 13)
        Me.lblNIK.TabIndex = 4
        Me.lblNIK.Text = "NIK :"
        '
        'lblAlamat
        '
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Location = New System.Drawing.Point(47, 107)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(45, 13)
        Me.lblAlamat.TabIndex = 2
        Me.lblAlamat.Text = "Alamat :"
        '
        'txtNama
        '
        Me.txtNama.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNama.Location = New System.Drawing.Point(98, 26)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(200, 20)
        Me.txtNama.TabIndex = 1
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(6, 29)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(86, 13)
        Me.lblNama.TabIndex = 0
        Me.lblNama.Text = "Nama Lengkap :"
        '
        'btnCreate
        '
        Me.btnCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreate.Location = New System.Drawing.Point(250, 181)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 1
        Me.btnCreate.Text = "Daftar"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Location = New System.Drawing.Point(169, 181)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblJK
        '
        Me.lblJK.AutoSize = True
        Me.lblJK.Location = New System.Drawing.Point(170, 81)
        Me.lblJK.Name = "lblJK"
        Me.lblJK.Size = New System.Drawing.Size(77, 13)
        Me.lblJK.TabIndex = 12
        Me.lblJK.Text = "Jenis Kelamin :"
        '
        'cboJK
        '
        Me.cboJK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboJK.FormattingEnabled = True
        Me.cboJK.Items.AddRange(New Object() {"Pria", "Wanita"})
        Me.cboJK.Location = New System.Drawing.Point(253, 77)
        Me.cboJK.Name = "cboJK"
        Me.cboJK.Size = New System.Drawing.Size(45, 21)
        Me.cboJK.TabIndex = 13
        '
        'FrmDaftar
        '
        Me.AcceptButton = Me.btnCreate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 216)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.grpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmDaftar"
        Me.Text = "Daftar Pengunjung"
        Me.grpForm.ResumeLayout(False)
        Me.grpForm.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpForm As GroupBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtUsia As TextBox
    Friend WithEvents txtNIK As TextBox
    Friend WithEvents lblUsia As Label
    Friend WithEvents lblNIK As Label
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtPass As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents cboJK As ComboBox
    Friend WithEvents lblJK As Label
End Class
