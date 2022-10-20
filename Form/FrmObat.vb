Public Class FrmObat

    Dim o As New ClsObat

    Private Sub FrmObat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        o.LoadDB(dgvObat)
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
            txtNamaObat.Text = dgvObat.SelectedRows(0).Cells(1).Value
            txtHarga.Text = dgvObat.SelectedRows(0).Cells(2).Value
        Else
            txtNamaObat.Text = dgvObat.SelectedRows(0).Cells(1).Value
            txtHarga.Text = dgvObat.SelectedRows(0).Cells(2).Value
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
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
                MsgBox("Perubahan Tersimpan!", MsgBoxStyle.Information, "Perubahan Tersimpan")
            Else
                MsgBox("Perubahan Dibatalkan!", MsgBoxStyle.Information, "Perubahan Dibatalkan")
            End If
        ElseIf btnInsert.Enabled = True Then
            Dim result = MsgBox("Yakin Untuk Menyimpan Obat Baru?", MsgBoxStyle.YesNo, "Konfirmasi Penambahan Obat")
            If result = MsgBoxResult.Yes Then
                MsgBox("Obat Baru Ditambahkan!", MsgBoxStyle.Information, "Obat Baru Ditambahkan")
            Else
                MsgBox("Penambahan Obat Dibatalkan!", MsgBoxStyle.Information, "Penambahan Obat Dibatalkan")
            End If
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        txtNamaObat.ReadOnly = False
        txtHarga.ReadOnly = False
        btnSave.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
    End Sub
End Class