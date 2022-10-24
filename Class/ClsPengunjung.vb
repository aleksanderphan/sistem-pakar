Imports System.Data.OleDb

Public Class ClsPengunjung

    Public Sub LoadDB(dgv As DataGridView)
        dt = LoadTable("SELECT * FROM [Pengunjung]")
        dgv.DataSource = dt
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

    Public Sub InsertPengunjung(nama As TextBox, nik As TextBox, usia As TextBox, jk As ComboBox, alamat As TextBox) 'Insert Data Pengunjung Baru
        cmd = New OleDbCommand("INSERT INTO [Pengunjung] ([Nama], [NIK], [Usia], [Jenis Kelamin], [Alamat]) VALUES (@Nama, @NIK, @Usia, @JK, @Alamat)", conn)
        cmd.Parameters.Add(New OleDbParameter("@Nama", nama.Text))
        cmd.Parameters.Add(New OleDbParameter("@NIK", nik.Text))
        cmd.Parameters.Add(New OleDbParameter("@Usia", usia.Text))
        cmd.Parameters.Add(New OleDbParameter("@JK", jk.Text))
        cmd.Parameters.Add(New OleDbParameter("@Alamat", alamat.Text))
        conn.Open() : cmd.ExecuteNonQuery()
        cmd.Dispose() : conn.Close()
    End Sub

End Class