Imports System.Data.OleDb

Public Class ClsObat

    Public Sub LoadDB(dgv As DataGridView)
        dt = LoadTable("SELECT [Kode], [Nama], [Harga] FROM [Obat] ORDER BY [Kode] ASC")
        dgv.DataSource = dt
    End Sub

    Public Function CheckDuplicate(nama As TextBox) As Boolean
        cmd = New OleDbCommand("SELECT [Nama] FROM [Obat] WHERE [Nama] = @Nama", conn)
        cmd.Parameters.Add(New OleDbParameter("@Nama", nama.Text))
        conn.Open()
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Return True
        End If

        dr.Close() : cmd.Dispose() : conn.Close()
        Return False
    End Function

    Public Sub Insert(dgv As DataGridView, nama As TextBox, harga As TextBox)
        If CheckDuplicate(nama) = False Then
            cmd = New OleDbCommand("INSERT INTO [Obat] ([Nama], [Harga]) VALUES (@Nama, @Harga)", conn)
            cmd.Parameters.Add(New OleDbParameter("@Nama", nama.Text))
            cmd.Parameters.Add(New OleDbParameter("@Harga", harga.Text))
            conn.Open()
            cmd.ExecuteNonQuery()
            cmd.Dispose() : conn.Close()
            LoadDB(dgv)
        Else
            MsgBox("Obat Sudah Ada!", MsgBoxStyle.Critical, "Obat Sudah Ada")
        End If
    End Sub

    Public Sub Edit(dgv As DataGridView, kode As TextBox, nama As TextBox, harga As TextBox)
        If CheckDuplicate(nama) = False Then 'Tips : Parameter MS Access Berurut Sesuai Urutan Deklarasi, Bukan Urutan Nama
            cmd = New OleDbCommand("UPDATE [Obat] SET [Nama] = @Nama, [Harga] = @Harga WHERE [Kode] = @Kode", conn)
            cmd.Parameters.Add(New OleDbParameter("@Nama", nama.Text))
            cmd.Parameters.Add(New OleDbParameter("@Harga", harga.Text))
            cmd.Parameters.Add(New OleDbParameter("@Kode", kode.Text))
            conn.Open()
            cmd.ExecuteNonQuery()
            cmd.Dispose() : conn.Close()
            LoadDB(dgv)
        Else
            MsgBox("Obat Sudah Ada!", MsgBoxStyle.Critical, "Obat Sudah Ada")
        End If
    End Sub

    Public Sub Delete(dgv As DataGridView, kode As TextBox)
        cmd = New OleDbCommand("DELETE FROM [Obat] WHERE [Kode] = @Kode", conn)
        cmd.Parameters.Add(New OleDbParameter("@Kode", kode.Text))
        conn.Open()
        cmd.ExecuteNonQuery()
        cmd.Dispose() : conn.Close()
        LoadDB(dgv)
    End Sub

End Class