﻿Imports System.Data.OleDb

Public Class ClsLogin

    Public Function Validation(user As TextBox, pass As TextBox) As Boolean
        If user.Text = "" Then
            MsgBox("Harap Isi Username!")
            user.Select()
            Return False
        ElseIf pass.Text = "" Then
            MsgBox("Harap Isi Password!")
            pass.Select()
            Return False
        End If

        Return True
    End Function

    Public Function CheckDuplicate(user As TextBox) As Boolean
        cmd = New OleDbCommand("SELECT [Nama] FROM [User] WHERE [Nama] = @Nama", conn)
        cmd.Parameters.Add(New OleDbParameter("@Nama", user.Text))
        conn.Open()
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Return True
        End If

        dr.Close() : cmd.Dispose() : conn.Close()
        Return False
    End Function

    Public Sub Login(user As TextBox, pass As TextBox, pengunjung As RadioButton, pakar As RadioButton)
        cmd = New OleDbCommand("SELECT * FROM [User] WHERE [Username] = @User AND [Password] = @Pass", conn)
        cmd.Parameters.Add(New OleDbParameter("@User", user.Text))
        cmd.Parameters.Add(New OleDbParameter("@Pass", pass.Text))
        conn.Open()
        dr = cmd.ExecuteReader
        dr.Read()

        If dr.HasRows Then
            If dr.Item(3).ToString = "Pakar" And pakar.Checked = True Then
                TypeLogin(pengunjung, pakar)
            ElseIf dr.Item(3).ToString <> "Pakar" And pakar.Checked = True Then
                MsgBox("User Ini Bukan Seorang Pakar!", MsgBoxStyle.Exclamation, "Bukan Pakar!")
            Else
                TypeLogin(pengunjung, pakar)
            End If
        Else
            dr.Close() : cmd.Dispose() : conn.Close()
            ' WIP : Check User Sudah Ada Atau Belum
            If CheckDuplicate(user) = False Then
                MsgBox("User Tidak Ditemukan!", MsgBoxStyle.Exclamation, "User Tidak Ditemukan")
                Dim result = MsgBox("Ingin Mendaftar User Baru?", MsgBoxStyle.YesNo, "User Tidak Ditemukan")
                If result = MsgBoxResult.Yes Then
                    CreateUser(user)
                End If
            End If
        End If

        cmd.Dispose() : conn.Close()
    End Sub

    Public Sub TypeLogin(pengunjung As RadioButton, pakar As RadioButton)
        FrmLogin.Hide()
        FrmMain.LoginToolStripMenuItem.Visible = False

        If pengunjung.Checked = True Then
            FrmMain.DiagnosaToolStripMenuItem.Visible = True
        ElseIf pakar.Checked = True Then
            FrmMain.DiagnosaToolStripMenuItem.Visible = True
            FrmMain.DaftarObatToolStripMenuItem.Visible = True
            FrmMain.DaftarPengunjungToolStripMenuItem.Visible = True
        End If
    End Sub

    Public Sub CreateNewUser(user As TextBox, pass As TextBox)
        cmd = New OleDbCommand("INSERT INTO [User] (Username, Password, Type) VALUES (@Nama, @Pass, 'Pengunjung')", conn)
        cmd.Parameters.Add(New OleDbParameter("@Nama", user.Text))
        cmd.Parameters.Add(New OleDbParameter("Pass", pass.Text))
        conn.Open() : cmd.ExecuteNonQuery()
        cmd.Dispose() : conn.Close()
        MsgBox("User Baru Telah Dibuat, Anda Sudah Bisa Login Sekarang.", MsgBoxStyle.Information, "User Berhasil Dibuat")
        FrmDaftar.Close()
        FrmLogin.txtUser.Text = user.Text
        FrmLogin.txtPass.Text = pass.Text
        FrmLogin.Show()
    End Sub

    Public Sub CreateUser(user As TextBox)
        FrmDaftar.txtNama.Text = user.Text
        FrmDaftar.txtNama.ReadOnly = True
        FrmLogin.Close()
        FrmDaftar.MdiParent = FrmMain
        FrmDaftar.Show()
    End Sub

End Class