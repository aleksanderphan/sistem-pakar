Public Class FrmHasilDiagnosa

    Dim d As New ClsDiagnosa

    Private Sub FrmHasilDiagnosa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        d.LoadHasilDiagnosa(dgvHasilDiagnosa)
    End Sub
End Class