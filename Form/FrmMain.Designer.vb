<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DiagnosaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarObatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarPengunjungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GejalaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DiagnosaToolStripMenuItem, Me.GejalaToolStripMenuItem, Me.DaftarObatToolStripMenuItem, Me.DaftarPengunjungToolStripMenuItem, Me.LoginToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DiagnosaToolStripMenuItem
        '
        Me.DiagnosaToolStripMenuItem.Name = "DiagnosaToolStripMenuItem"
        Me.DiagnosaToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.DiagnosaToolStripMenuItem.Text = "Diagnosa"
        Me.DiagnosaToolStripMenuItem.Visible = False
        '
        'DaftarObatToolStripMenuItem
        '
        Me.DaftarObatToolStripMenuItem.Name = "DaftarObatToolStripMenuItem"
        Me.DaftarObatToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.DaftarObatToolStripMenuItem.Text = "Database Obat"
        Me.DaftarObatToolStripMenuItem.Visible = False
        '
        'DaftarPengunjungToolStripMenuItem
        '
        Me.DaftarPengunjungToolStripMenuItem.Name = "DaftarPengunjungToolStripMenuItem"
        Me.DaftarPengunjungToolStripMenuItem.Size = New System.Drawing.Size(119, 20)
        Me.DaftarPengunjungToolStripMenuItem.Text = "Daftar Pengunjung"
        Me.DaftarPengunjungToolStripMenuItem.Visible = False
        '
        'GejalaToolStripMenuItem
        '
        Me.GejalaToolStripMenuItem.Name = "GejalaToolStripMenuItem"
        Me.GejalaToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.GejalaToolStripMenuItem.Text = "Gejala"
        Me.GejalaToolStripMenuItem.Visible = False
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DiagnosaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DaftarObatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DaftarPengunjungToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GejalaToolStripMenuItem As ToolStripMenuItem
End Class
