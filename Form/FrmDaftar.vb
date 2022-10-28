Public Class FrmDaftar

    Dim l As New ClsLogin
    Dim pe As New ClsPengunjung

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If txtNama.ReadOnly = True Then
            txtNIK.Text = String.Empty
            txtUsia.Text = String.Empty
            txtAlamat.Text = String.Empty
        Else
            txtNama.Text = String.Empty
            txtNIK.Text = String.Empty
            txtUsia.Text = String.Empty
            txtAlamat.Text = String.Empty
        End If
    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If Validation() = True Then
            l.CreateNewUser(txtNama, txtPass)
            l.CreatePengunjung(txtNama, txtNIK, txtUsia, cboJK, txtAlamat)
        End If
    End Sub

    Public Function Validation() As Boolean
        If txtNama.Text = "" Then
            MsgBox("Harap Isi Nama Anda!", MsgBoxStyle.Critical, "Nama Kosong")
            txtNama.Select()
            Return False
        End If

        If txtNIK.Text = "" Or txtNIK.Text.Length < 16 Then
            MsgBox("Harap Isi NIK Yang Valid!", MsgBoxStyle.Critical, "NIK Tidak Valid")
            txtNIK.Select()
            Return False
        End If

        If txtUsia.Text = "" Or txtUsia.Text < 1 Then
            MsgBox("Harap Isi Usia Yang Valid!", MsgBoxStyle.Critical, "Usia Tidak Valid")
            txtUsia.Select()
            Return False
        End If

        If cboJK.Text = "" Then
            MsgBox("Harap Pilih Jenis Kelamin!", MsgBoxStyle.Critical, "Jenis Kelamin Tidak Valid")
            cboJK.Select()
            Return False
        End If

        If txtAlamat.Text = "" Then
            MsgBox("Harap Isi Alamat Anda!", MsgBoxStyle.Critical, "Alamat Kosong")
            txtAlamat.Select()
            Return False
        End If

        If txtPass.Text = "" Then
            MsgBox("Password Tidak Boleh Kosong!", MsgBoxStyle.Critical, "Password Kosong")
            txtPass.Select()
            Return False
        End If

        Return True
    End Function

End Class