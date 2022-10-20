Imports System.Data.OleDb

Public Class ClsObat

    Public Sub LoadDB(dgv As DataGridView)
        dt = LoadTable("SELECT [Kode], [Nama], [Harga] FROM [Obat] ORDER BY [ID] ASC")
        dgv.DataSource = dt
    End Sub

End Class
