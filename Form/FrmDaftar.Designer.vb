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
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.txtUsia = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblUsia = New System.Windows.Forms.Label()
        Me.lblNIK = New System.Windows.Forms.Label()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.grpForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpForm
        '
        Me.grpForm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpForm.Controls.Add(Me.TextBox5)
        Me.grpForm.Controls.Add(Me.txtUsia)
        Me.grpForm.Controls.Add(Me.TextBox3)
        Me.grpForm.Controls.Add(Me.lblUsia)
        Me.grpForm.Controls.Add(Me.lblNIK)
        Me.grpForm.Controls.Add(Me.lblAlamat)
        Me.grpForm.Controls.Add(Me.TextBox1)
        Me.grpForm.Controls.Add(Me.lblNama)
        Me.grpForm.Location = New System.Drawing.Point(12, 12)
        Me.grpForm.Name = "grpForm"
        Me.grpForm.Size = New System.Drawing.Size(313, 142)
        Me.grpForm.TabIndex = 0
        Me.grpForm.TabStop = False
        Me.grpForm.Text = "Form Pengunjung"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(98, 104)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(200, 20)
        Me.TextBox5.TabIndex = 9
        '
        'txtUsia
        '
        Me.txtUsia.Location = New System.Drawing.Point(98, 78)
        Me.txtUsia.MaxLength = 2
        Me.txtUsia.Name = "txtUsia"
        Me.txtUsia.Size = New System.Drawing.Size(200, 20)
        Me.txtUsia.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(98, 52)
        Me.TextBox3.MaxLength = 16
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(200, 20)
        Me.TextBox3.TabIndex = 7
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(98, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 20)
        Me.TextBox1.TabIndex = 1
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
        'FrmDaftar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 166)
        Me.Controls.Add(Me.grpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmDaftar"
        Me.Text = "Daftar Pengunjung"
        Me.grpForm.ResumeLayout(False)
        Me.grpForm.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpForm As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents txtUsia As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents lblUsia As Label
    Friend WithEvents lblNIK As Label
End Class
