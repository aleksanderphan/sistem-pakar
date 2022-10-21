Public Class FrmObat

    Dim o As New ClsObat

    Private Sub FrmObat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        o.LoadDB(dgvObat)
        txtKode.Text = dgvObat.SelectedRows(0).Cells(0).Value
        txtNamaObat.Text = dgvObat.SelectedRows(0).Cells(1).Value
        txtHarga.Text = dgvObat.SelectedRows(0).Cells(2).Value
    End Sub

    Private Sub DgvObat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvObat.CellClick
        If btnEdit.Enabled = False Or btnInsert.Enabled = False Then
            btnEdit.Enabled = True
            btnInsert.Enabled = True
            txtNamaObat.ReadOnly = True
            txtHarga.ReadOnly = True
            btnSave.Enabled = False
            txtKode.Text = dgvObat.SelectedRows(0).Cells(0).Value
            txtNamaObat.Text = dgvObat.SelectedRows(0).Cells(1).Value
            txtHarga.Text = dgvObat.SelectedRows(0).Cells(2).Value
        Else
            txtKode.Text = dgvObat.SelectedRows(0).Cells(0).Value
            txtNamaObat.Text = dgvObat.SelectedRows(0).Cells(1).Value
            txtHarga.Text = dgvObat.SelectedRows(0).Cells(2).Value
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        dgvObat.ClearSelection()
        txtNamaObat.Select()
        txtNamaObat.ReadOnly = False
        txtHarga.ReadOnly = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnInsert.Enabled = False
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If btnEdit.Enabled = True Then
            Dim result = MsgBox("Yakin Untuk Menyimpan Perubahan?", MsgBoxStyle.YesNo, "Konfirmasi Perubahan")
            If result = MsgBoxResult.Yes Then
                o.Edit(dgvObat, txtKode, txtNamaObat, txtHarga)
                MsgBox("Perubahan Tersimpan!", MsgBoxStyle.Information, "Perubahan Tersimpan")
            Else
                MsgBox("Perubahan Dibatalkan!", MsgBoxStyle.Information, "Perubahan Dibatalkan")
            End If
        ElseIf btnInsert.Enabled = True Then
            Dim result = MsgBox("Yakin Untuk Menambah Obat Baru?", MsgBoxStyle.YesNo, "Konfirmasi Penambahan Obat")
            If result = MsgBoxResult.Yes Then
                o.Insert(dgvObat, txtNamaObat, txtHarga)
                MsgBox("Obat Baru Ditambahkan!", MsgBoxStyle.Information, "Obat Baru Ditambahkan")
            Else
                MsgBox("Penambahan Obat Dibatalkan!", MsgBoxStyle.Information, "Penambahan Obat Dibatalkan")
            End If
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result = MsgBox("Yakin Untuk Menghapus Obat Ini?", MsgBoxStyle.YesNo, "Konfirmasi Penghapusan")
        If result = MsgBoxResult.Yes Then
            o.Delete(dgvObat)
            MsgBox("Obat Telah Dihapus!", MsgBoxStyle.Information, "Obat Telah Dihapus")
        Else
            MsgBox("Penghapusan Obat Dibatalkan!", MsgBoxStyle.Information, "Penghapusan Obat Dibatalkan")
        End If
    End Sub

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        dgvObat.ClearSelection()
        txtNamaObat.Select()
        txtNamaObat.ReadOnly = False
        txtHarga.ReadOnly = False
        txtKode.Text = String.Empty
        txtNamaObat.Text = String.Empty
        txtHarga.Text = String.Empty
        btnSave.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        txtKode.Visible = False
    End Sub
End Class