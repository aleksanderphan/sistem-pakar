Public Class FrmObat

    Dim o As New ClsObat

    Private Sub FrmObat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        o.LoadDB(dgvObat)
        txtNamaObat.Text = dgvObat.SelectedRows(0).Cells(1).Value
        txtHarga.Text = dgvObat.SelectedRows(0).Cells(2).Value
    End Sub

    Private Sub DgvObat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvObat.CellClick
        If btnEdit.Enabled = False Then
            btnEdit.Enabled = True
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
        btnEdit.Enabled = False
        txtNamaObat.ReadOnly = False
        txtHarga.ReadOnly = False
        btnSave.Enabled = True
    End Sub
End Class