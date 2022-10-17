<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDiagnosa
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpGejala = New DevExpress.XtraEditors.GroupControl()
        Me.txtGejala = New System.Windows.Forms.RichTextBox()
        Me.btnYa = New DevExpress.XtraEditors.SimpleButton()
        Me.btnTidak = New DevExpress.XtraEditors.SimpleButton()
        Me.grpSuhu = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSuhu = New DevExpress.XtraEditors.TextEdit()
        CType(Me.grpGejala, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGejala.SuspendLayout()
        CType(Me.grpSuhu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSuhu.SuspendLayout()
        CType(Me.txtSuhu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGejala
        '
        Me.grpGejala.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpGejala.Controls.Add(Me.txtGejala)
        Me.grpGejala.Location = New System.Drawing.Point(12, 12)
        Me.grpGejala.Name = "grpGejala"
        Me.grpGejala.Size = New System.Drawing.Size(725, 299)
        Me.grpGejala.TabIndex = 0
        Me.grpGejala.Text = "Gejala"
        '
        'txtGejala
        '
        Me.txtGejala.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGejala.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGejala.Location = New System.Drawing.Point(5, 26)
        Me.txtGejala.Name = "txtGejala"
        Me.txtGejala.ReadOnly = True
        Me.txtGejala.Size = New System.Drawing.Size(715, 268)
        Me.txtGejala.TabIndex = 0
        Me.txtGejala.Text = ""
        '
        'btnYa
        '
        Me.btnYa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnYa.Location = New System.Drawing.Point(657, 317)
        Me.btnYa.Name = "btnYa"
        Me.btnYa.Size = New System.Drawing.Size(75, 23)
        Me.btnYa.TabIndex = 1
        Me.btnYa.Text = "Iya"
        '
        'btnTidak
        '
        Me.btnTidak.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTidak.Location = New System.Drawing.Point(576, 317)
        Me.btnTidak.Name = "btnTidak"
        Me.btnTidak.Size = New System.Drawing.Size(75, 23)
        Me.btnTidak.TabIndex = 2
        Me.btnTidak.Text = "Tidak"
        '
        'grpSuhu
        '
        Me.grpSuhu.Controls.Add(Me.LabelControl1)
        Me.grpSuhu.Controls.Add(Me.txtSuhu)
        Me.grpSuhu.Location = New System.Drawing.Point(12, 317)
        Me.grpSuhu.Name = "grpSuhu"
        Me.grpSuhu.Size = New System.Drawing.Size(200, 54)
        Me.grpSuhu.TabIndex = 4
        Me.grpSuhu.Text = "Suhu Badan (°C)"
        Me.grpSuhu.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(175, 29)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(13, 13)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "°C"
        '
        'txtSuhu
        '
        Me.txtSuhu.Location = New System.Drawing.Point(5, 26)
        Me.txtSuhu.Name = "txtSuhu"
        Me.txtSuhu.Size = New System.Drawing.Size(164, 20)
        Me.txtSuhu.TabIndex = 3
        '
        'FrmDiagnosa
        '
        Me.AcceptButton = Me.btnYa
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 465)
        Me.Controls.Add(Me.grpSuhu)
        Me.Controls.Add(Me.btnTidak)
        Me.Controls.Add(Me.btnYa)
        Me.Controls.Add(Me.grpGejala)
        Me.Name = "FrmDiagnosa"
        Me.Text = "Diagnosa Mandiri"
        CType(Me.grpGejala, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGejala.ResumeLayout(False)
        CType(Me.grpSuhu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSuhu.ResumeLayout(False)
        Me.grpSuhu.PerformLayout()
        CType(Me.txtSuhu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpGejala As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtGejala As RichTextBox
    Friend WithEvents btnYa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTidak As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSuhu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grpSuhu As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
