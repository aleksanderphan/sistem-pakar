<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.rdbPengunjung = New System.Windows.Forms.RadioButton()
        Me.rdbPakar = New System.Windows.Forms.RadioButton()
        Me.btnLogin = New DevExpress.XtraEditors.SimpleButton()
        Me.grpUser = New DevExpress.XtraEditors.GroupControl()
        Me.txtPass = New DevExpress.XtraEditors.TextEdit()
        Me.txtUser = New DevExpress.XtraEditors.TextEdit()
        Me.lblPassword = New DevExpress.XtraEditors.LabelControl()
        Me.lblUsername = New DevExpress.XtraEditors.LabelControl()
        CType(Me.grpUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpUser.SuspendLayout()
        CType(Me.txtPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdbPengunjung
        '
        Me.rdbPengunjung.AutoSize = True
        Me.rdbPengunjung.Checked = True
        Me.rdbPengunjung.Location = New System.Drawing.Point(12, 140)
        Me.rdbPengunjung.Name = "rdbPengunjung"
        Me.rdbPengunjung.Size = New System.Drawing.Size(82, 17)
        Me.rdbPengunjung.TabIndex = 2
        Me.rdbPengunjung.TabStop = True
        Me.rdbPengunjung.Text = "Pengunjung"
        Me.rdbPengunjung.UseVisualStyleBackColor = True
        '
        'rdbPakar
        '
        Me.rdbPakar.AutoSize = True
        Me.rdbPakar.Location = New System.Drawing.Point(100, 140)
        Me.rdbPakar.Name = "rdbPakar"
        Me.rdbPakar.Size = New System.Drawing.Size(52, 17)
        Me.rdbPakar.TabIndex = 3
        Me.rdbPakar.Text = "Pakar"
        Me.rdbPakar.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(211, 137)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        '
        'grpUser
        '
        Me.grpUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpUser.Controls.Add(Me.txtPass)
        Me.grpUser.Controls.Add(Me.txtUser)
        Me.grpUser.Controls.Add(Me.lblPassword)
        Me.grpUser.Controls.Add(Me.lblUsername)
        Me.grpUser.Location = New System.Drawing.Point(12, 12)
        Me.grpUser.Name = "grpUser"
        Me.grpUser.Size = New System.Drawing.Size(274, 119)
        Me.grpUser.TabIndex = 1
        Me.grpUser.Text = "Login Sebagai Pengunjung"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(5, 90)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Properties.UseSystemPasswordChar = True
        Me.txtPass.Size = New System.Drawing.Size(264, 20)
        Me.txtPass.TabIndex = 3
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(5, 45)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(264, 20)
        Me.txtUser.TabIndex = 2
        '
        'lblPassword
        '
        Me.lblPassword.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPassword.Appearance.Options.UseFont = True
        Me.lblPassword.Location = New System.Drawing.Point(5, 71)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(60, 13)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password :"
        '
        'lblUsername
        '
        Me.lblUsername.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblUsername.Appearance.Options.UseFont = True
        Me.lblUsername.Location = New System.Drawing.Point(5, 26)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(64, 13)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username :"
        '
        'FrmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 169)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.rdbPakar)
        Me.Controls.Add(Me.rdbPengunjung)
        Me.Controls.Add(Me.grpUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.Image = CType(resources.GetObject("FrmLogin.IconOptions.Image"), System.Drawing.Image)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.grpUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpUser.ResumeLayout(False)
        Me.grpUser.PerformLayout()
        CType(Me.txtPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpUser As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rdbPengunjung As RadioButton
    Friend WithEvents rdbPakar As RadioButton
    Friend WithEvents btnLogin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblPassword As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblUsername As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUser As DevExpress.XtraEditors.TextEdit
End Class
