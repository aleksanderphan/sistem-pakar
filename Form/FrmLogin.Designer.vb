<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.grpLogin = New System.Windows.Forms.GroupBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.rdbPengunjung = New System.Windows.Forms.RadioButton()
        Me.rdbPakar = New System.Windows.Forms.RadioButton()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.grpLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpLogin
        '
        Me.grpLogin.Controls.Add(Me.txtPass)
        Me.grpLogin.Controls.Add(Me.txtUser)
        Me.grpLogin.Controls.Add(Me.lblPass)
        Me.grpLogin.Controls.Add(Me.lblUser)
        Me.grpLogin.Location = New System.Drawing.Point(12, 12)
        Me.grpLogin.Name = "grpLogin"
        Me.grpLogin.Size = New System.Drawing.Size(260, 108)
        Me.grpLogin.TabIndex = 0
        Me.grpLogin.TabStop = False
        Me.grpLogin.Text = "Login Sebagai"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(9, 71)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPass.Size = New System.Drawing.Size(245, 20)
        Me.txtPass.TabIndex = 1
        '
        'txtUser
        '
        Me.txtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtUser.Location = New System.Drawing.Point(9, 32)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(245, 20)
        Me.txtUser.TabIndex = 0
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(6, 55)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(59, 13)
        Me.lblPass.TabIndex = 1
        Me.lblPass.Text = "Password :"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(6, 16)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(61, 13)
        Me.lblUser.TabIndex = 0
        Me.lblUser.Text = "Username :"
        '
        'rdbPengunjung
        '
        Me.rdbPengunjung.AutoSize = True
        Me.rdbPengunjung.Location = New System.Drawing.Point(12, 129)
        Me.rdbPengunjung.Name = "rdbPengunjung"
        Me.rdbPengunjung.Size = New System.Drawing.Size(82, 17)
        Me.rdbPengunjung.TabIndex = 4
        Me.rdbPengunjung.Text = "Pengunjung"
        Me.rdbPengunjung.UseVisualStyleBackColor = True
        '
        'rdbPakar
        '
        Me.rdbPakar.AutoSize = True
        Me.rdbPakar.Checked = True
        Me.rdbPakar.Location = New System.Drawing.Point(100, 129)
        Me.rdbPakar.Name = "rdbPakar"
        Me.rdbPakar.Size = New System.Drawing.Size(53, 17)
        Me.rdbPakar.TabIndex = 5
        Me.rdbPakar.TabStop = True
        Me.rdbPakar.Text = "Pakar"
        Me.rdbPakar.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(197, 126)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'FrmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 161)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.rdbPakar)
        Me.Controls.Add(Me.rdbPengunjung)
        Me.Controls.Add(Me.grpLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.grpLogin.ResumeLayout(False)
        Me.grpLogin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpLogin As GroupBox
    Friend WithEvents rdbPengunjung As RadioButton
    Friend WithEvents rdbPakar As RadioButton
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents lblUser As Label
End Class
