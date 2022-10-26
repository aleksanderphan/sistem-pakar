Public Class FrmGejala

    Dim pa As New ClsPakar

    Private Sub FrmGejala_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pa.ShowGejala(dgvGejala)
        pa.LoadSolusi(cboJikaYa)
        pa.LoadSolusi(cboJikaTidak)
        txtKode.Text = dgvGejala.SelectedRows(0).Cells(0).Value
        txtQ.Text = dgvGejala.SelectedRows(0).Cells(1).Value
        cboJikaYa.Text = dgvGejala.SelectedRows(0).Cells(2).Value
        cboJikaTidak.Text = dgvGejala.SelectedRows(0).Cells(3).Value
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Empty()
        btnConfirm.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        txtQ.Text = dgvGejala.SelectedRows(0).Cells(1).Value
        cboJikaYa.Text = dgvGejala.SelectedRows(0).Cells(2).Value
        cboJikaTidak.Text = dgvGejala.SelectedRows(0).Cells(3).Value
        btnConfirm.Enabled = True
        btnNew.Enabled = False
        btnDelete.Enabled = False
        dgvGejala.ClearSelection()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub

    Private Sub DgvGejala_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGejala.CellClick
        txtKode.Text = dgvGejala.SelectedRows(0).Cells(0).Value
        txtQ.Text = dgvGejala.SelectedRows(0).Cells(1).Value
        cboJikaYa.Text = dgvGejala.SelectedRows(0).Cells(2).Value
        cboJikaTidak.Text = dgvGejala.SelectedRows(0).Cells(3).Value
    End Sub

    Public Sub Empty()
        txtQ.Text = String.Empty
        cboJikaYa.SelectedIndex = -1
        cboJikaTidak.SelectedIndex = -1
        dgvGejala.ClearSelection()
    End Sub

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If btnNew.Enabled = True Then
            pa.InsertGejala(txtQ, cboJikaYa, cboJikaTidak)
        ElseIf btnEdit.Enabled = True Then
            pa.EditGejala(txtQ, cboJikaYa, cboJikaTidak, txtKode)
        End If
    End Sub
End Class