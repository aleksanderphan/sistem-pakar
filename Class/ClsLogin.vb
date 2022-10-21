Imports System.Data.OleDb

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
            MsgBox("User Tidak Ditemukan!", MsgBoxStyle.Exclamation, "User Tidak Ditemukan")
        End If

        cmd.Dispose() : conn.Close()
    End Sub

    Public Sub TypeLogin(pengunjung As RadioButton, pakar As RadioButton)
        FrmLogin.Close()
        FrmMain.LoginToolStripMenuItem.Visible = False

        If pengunjung.Checked = True Then
            FrmMain.DiagnosaToolStripMenuItem.Visible = True
        ElseIf pakar.Checked = True Then
            FrmMain.DiagnosaToolStripMenuItem.Visible = True
            FrmMain.DaftarObatToolStripMenuItem.Visible = True
            FrmMain.DaftarPengunjungToolStripMenuItem.Visible = True
        End If
    End Sub

End Class