Public Class FrmPengunjung

    Dim pe As New ClsPengunjung

    Private Sub FrmPengunjung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pe.LoadDB(dgvPengunjung)
    End Sub

    Private Sub TambahPengunjungBaruToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles TambahPengunjungBaruToolStripMenuItem.Click
        FrmDaftar.Show()
    End Sub
End Class