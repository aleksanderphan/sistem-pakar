﻿Public Class FrmLogin

    Dim l As New ClsLogin

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If l.Validation(txtUser, txtPass) = True Then
            If rdbPengunjung.Checked = True Then
                'WIP : Class Check Daftar Pengunjung
                'WIP : Show Form Untuk Mendaftarkan Diri Sebagai Pasien Jika Belum Terdaftar
            End If

            l.Login(txtUser, txtPass, rdbPengunjung, rdbPakar)
        End If
    End Sub

    Private Sub RdbPengunjung_CheckedChanged(sender As Object, e As EventArgs) Handles rdbPengunjung.CheckedChanged
        grpLogin.Text = "Login Sebagai Pengunjung"
    End Sub

    Private Sub RdbPakar_CheckedChanged(sender As Object, e As EventArgs) Handles rdbPakar.CheckedChanged
        grpLogin.Text = "Login Sebagai Pakar"
    End Sub
End Class