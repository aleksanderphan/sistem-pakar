Public Class FrmDiagnosa

    Dim d As New ClsDiagnosa

    Private Sub FrmDiagnosa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        d.ShowGejala(rtxtGejala)
    End Sub

    Private Sub BtnYa_Click(sender As Object, e As EventArgs) Handles btnYa.Click
        d.GejalaYa(rtxtGejala)
    End Sub

    Private Sub BtnTidak_Click(sender As Object, e As EventArgs) Handles btnTidak.Click
        d.GejalaTidak(rtxtGejala)
    End Sub
End Class