Imports System.ComponentModel
Imports System.Text

Partial Public Class FrmMain
    Public Sub New()
        InitializeComponent()
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

    Private Sub PengunjungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengunjungToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of FrmPengunjung).Any Then
            FrmPengunjung.Select()
        Else
            FrmPengunjung.MdiParent = Me
            FrmPengunjung.Show()
        End If
    End Sub
End Class