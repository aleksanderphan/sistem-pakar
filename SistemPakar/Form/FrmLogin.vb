Public Class FrmLogin
    Private Sub RdbPengunjung_CheckedChanged(sender As Object, e As EventArgs) Handles rdbPengunjung.CheckedChanged
        grpUser.Text = "Login Sebagai Pengunjung"
        grpUser.CaptionImageOptions.Image = My.Resources.customer_16x16
    End Sub

    Private Sub RdbPakar_CheckedChanged(sender As Object, e As EventArgs) Handles rdbPakar.CheckedChanged
        grpUser.Text = "Login Sebagai Pakar"
        grpUser.CaptionImageOptions.Image = My.Resources.employee_16x16
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Validation() = True Then
            Me.Close()
            FrmMain.DiagnosaToolStripMenuItem.Enabled = True
            FrmMain.PengunjungToolStripMenuItem.Enabled = True
            FrmMain.LoginToolStripMenuItem.Visible = False
        End If
    End Sub

    Public Function Validation() As Boolean
        If txtUser.Text = "" Then
            MsgBox("Harap Isi Username!")
            Return False
        Else
            Return True
        End If

        If txtPass.Text = "" Then
            MsgBox("Harap Isi Password!")
            Return False
        Else
            Return True
        End If
    End Function

End Class