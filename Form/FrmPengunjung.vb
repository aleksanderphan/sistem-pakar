Public Class FrmPengunjung

    Dim p As New ClsPengunjung

    Private Sub FrmPengunjung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        p.LoadDB(dgvPengunjung)
    End Sub
End Class