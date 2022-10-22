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
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.grpForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpForm
        '
        Me.grpForm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpForm.Controls.Add(Me.TextBox5)
        Me.grpForm.Controls.Add(Me.TextBox4)
        Me.grpForm.Controls.Add(Me.TextBox3)
        Me.grpForm.Controls.Add(Me.Label3)
        Me.grpForm.Controls.Add(Me.Label2)
        Me.grpForm.Controls.Add(Me.Label1)
        Me.grpForm.Controls.Add(Me.TextBox2)
        Me.grpForm.Controls.Add(Me.lblAlamat)
        Me.grpForm.Controls.Add(Me.TextBox1)
        Me.grpForm.Controls.Add(Me.lblNama)
        Me.grpForm.Location = New System.Drawing.Point(12, 12)
        Me.grpForm.Name = "grpForm"
        Me.grpForm.Size = New System.Drawing.Size(531, 359)
        Me.grpForm.TabIndex = 0
        Me.grpForm.TabStop = False
        Me.grpForm.Text = "Form Pengunjung"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(98, 61)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 20)
        Me.TextBox2.TabIndex = 3
        '
        'lblAlamat
        '
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Location = New System.Drawing.Point(47, 64)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Label3"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(67, 135)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(200, 20)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(67, 162)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(200, 20)
        Me.TextBox4.TabIndex = 8
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(67, 188)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(200, 20)
        Me.TextBox5.TabIndex = 9
        '
        'FrmDaftar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 383)
        Me.Controls.Add(Me.grpForm)
        Me.Name = "FrmDaftar"
        Me.Text = "Daftar Pengunjung"
        Me.grpForm.ResumeLayout(False)
        Me.grpForm.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpForm As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblNama As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblAlamat As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
