Imports System.Data.OleDb

Public Class ClsPakar

    Public Sub ShowGejala(dgv As DataGridView)
        dt = LoadTable("SELECT * FROM [Gejala]")
        dgv.DataSource = dt
    End Sub

    Public Sub InsertGejala(dgv As DataGridView)
        cmd = New OleDbCommand("INSERT INTO [Gejala] ('Pertanyaan','Ya', 'Tidak') VALUES (@Pertanyaan, @Ya, @Tidak)", conn)
        cmd.Parameters.Add(New OleDbParameter("@Pertanyaan", ""))
        cmd.Parameters.Add(New OleDbParameter("@Ya", ""))
        cmd.Parameters.Add(New OleDbParameter("@Tidak", ""))
        conn.Open() : cmd.ExecuteNonQuery()
        cmd.Dispose() : conn.Close()
    End Sub

    Public Sub EditGejala()
        cmd = New OleDbCommand("UPDATE [Gejala] SET [Pertanyaan] = @Pertanyaan, [Ya] =  @Ya, [Tidak] = @Tidak WHERE [Kode] = @Kode", conn)
        cmd.Parameters.Add(New OleDbParameter("", ""))
        cmd.Parameters.Add(New OleDbParameter("", ""))
        cmd.Parameters.Add(New OleDbParameter("", ""))
        cmd.Parameters.Add(New OleDbParameter("", ""))
        conn.Open() : cmd.ExecuteNonQuery()
        cmd.Dispose() : conn.Close()
    End Sub

End Class