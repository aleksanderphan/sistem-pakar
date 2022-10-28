Imports System.Data.OleDb

Public Class ClsPengunjung

    Public Sub LoadDB(dgv As DataGridView)
        dt2 = LoadTable2("SELECT * FROM [Pengunjung]")
        dgv.DataSource = dt2
    End Sub

    Public Function CheckPengunjung(nik As TextBox) As Boolean
        cmd = New OleDbCommand("SELECT [NIK] FROM [Pengunjung] WHERE [NIK] = @NIK", conn)
        cmd.Parameters.Add(New OleDbParameter("@NIK", nik.Text))
        conn.Open()
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Return True
        End If

        dr.Close() : cmd.Dispose() : conn.Close()
        Return False
    End Function
End Class