Imports System.Data.OleDb

Public Class ClsPakar

    Public Sub ShowGejala(dgv As DataGridView)
        dt = LoadTable("SELECT * FROM [Gejala]")
        dgv.DataSource = dt
    End Sub

    Public Sub InsertGejala(q As TextBox, ya As ComboBox, tdk As ComboBox)
        cmd = New OleDbCommand("INSERT INTO [Gejala] ('Pertanyaan','Ya', 'Tidak') VALUES (@Pertanyaan, @Ya, @Tidak)", conn)
        cmd.Parameters.Add(New OleDbParameter("@Pertanyaan", q.Text))
        cmd.Parameters.Add(New OleDbParameter("@Ya", ya.Text))
        cmd.Parameters.Add(New OleDbParameter("@Tidak", tdk.Text))
        conn.Open() : cmd.ExecuteNonQuery()
        cmd.Dispose() : conn.Close()
    End Sub

    Public Sub EditGejala(q As TextBox, ya As ComboBox, tdk As ComboBox, kode As TextBox)
        cmd = New OleDbCommand("UPDATE [Gejala] SET [Pertanyaan] = @Pertanyaan, [Ya] =  @Ya, [Tidak] = @Tidak WHERE [Kode] = @Kode", conn)
        cmd.Parameters.Add(New OleDbParameter("@Pertanyaan", q.Text))
        cmd.Parameters.Add(New OleDbParameter("@Ya", ya.Text))
        cmd.Parameters.Add(New OleDbParameter("@Tidak", tdk.Text))
        cmd.Parameters.Add(New OleDbParameter("@Kode", kode.Text))
        conn.Open() : cmd.ExecuteNonQuery()
        cmd.Dispose() : conn.Close()
    End Sub

    Public Sub LoadSolusi(cbo As ComboBox)
        dt2 = LoadTable2("SELECT * FROM [Solusi]")
        cbo.ValueMember = "Kode"
        cbo.DisplayMember = "JenisPenyakit"
        cbo.DataSource = dt2
    End Sub

End Class