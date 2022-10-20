Imports System.Data.OleDb

Public Class ClsObat

    Public Sub LoadDB(dgv As DataGridView)
        dt = LoadTable("SELECT [Kode], [Nama], [Harga] FROM [Obat] ORDER BY [ID] ASC")
        dgv.DataSource = dt
    End Sub

    Public Function CheckDuplicate() As Boolean
        cmd = New OleDbCommand("SELECT [Nama] FROM [Obat]", conn)
        conn.Open()
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Return True
        End If

        dr.Close() : cmd.Dispose() : conn.Close()
        Return False
    End Function

    Public Sub Insert()
        If CheckDuplicate() = False Then
            cmd = New OleDbCommand("INSERT INTO [Obat] ([Nama], [Harga]) VALUES (@Nama, @Harga)", conn)
            cmd.Parameters.Add(New OleDbParameter("@Nama", ""))
            cmd.Parameters.Add(New OleDbParameter("@Harga", ""))
        Else
            MsgBox("Obat Sudah Ada!", MsgBoxStyle.Critical, "Obat Sudah Ada")
        End If
    End Sub

    Public Sub Delete(dgv As DataGridView)
        cmd = New OleDbCommand("DELETE FROM [Obat] WHERE [Kode] = @Kode", conn)
        cmd.Parameters.Add(New OleDbParameter("@Kode", dgv.SelectedRows(0).Cells(0).Value))
        conn.Open()
        cmd.ExecuteNonQuery()
        cmd.Dispose() : conn.Close()
    End Sub

End Class