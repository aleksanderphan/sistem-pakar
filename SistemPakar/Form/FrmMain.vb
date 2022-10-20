Public Class FrmMain

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmLogin.ShowDialog()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        FrmLogin.ShowDialog()
    End Sub

    Private Sub DiagnosaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiagnosaToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of FrmDiagnosa).Any Then
            FrmDiagnosa.Select()
        Else
            FrmDiagnosa.MdiParent = Me
            FrmDiagnosa.Show()
        End If
    End Sub

    Private Sub DaftarObatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarObatToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of FrmObat).Any Then
            FrmObat.Select()
        Else
            FrmObat.MdiParent = Me
            FrmObat.Show()
        End If
    End Sub
End Class
