Imports System.Data.OleDb

Public Class ClsPengunjung

    Public Sub LoadDB(dgv As DataGridView)
        dt = LoadTable("SELECT * FROM [Pengunjung]")
        dgv.DataSource = dt
    End Sub

    Public Sub InsertPengunjung(nama As TextBox, usia As TextBox, jk As TextBox) 'Insert Data Pengunjung Baru
        cmd = New OleDbCommand("INSERT INTO [Pengunjung] ([Nama], [Usia]) VALUES (@Nama, @Usia)", conn)
        cmd.Parameters.Add(New OleDbParameter("@Nama", ""))
        cmd.Parameters.Add(New OleDbParameter("@Usia", ""))

        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
End Class