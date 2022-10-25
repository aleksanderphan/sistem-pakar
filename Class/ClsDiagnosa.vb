Imports System.Data.OleDb

Public Class ClsDiagnosa

    Dim no As Integer = 1
    Dim vUser As String = FrmLogin.txtUser.Text

    Public Sub ShowGejala(txt As RichTextBox)
        cmdg = New OleDbCommand("SELECT * FROM [Gejala] WHERE [Kode] = " & no & "", conn)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        drg = cmdg.ExecuteReader
        If drg.HasRows Then
            Do While drg.Read
                txt.Text = drg.Item(1).ToString
            Loop
        End If
        cmdg.Dispose()
    End Sub

    Public Sub GejalaYa(rtxt As RichTextBox)
        cmdy = New OleDbCommand("SELECT * FROM [Gejala] WHERE [Kode] = " & no & "", conny)
        If conny.State = ConnectionState.Closed Then
            conny.Open()
        End If

        dry = cmdy.ExecuteReader
        If dry.HasRows Then
            Do While dry.Read
                GejalaDB(dry.Item(2).ToString, rtxt)
            Loop
        End If
        cmdy.Dispose() : conny.Close()
    End Sub

    Public Sub GejalaTidak(rtxt As RichTextBox)
        cmdt = New OleDbCommand("SELECT * FROM [Gejala] WHERE [Kode] = " & no & "", connt)
        If connt.State = ConnectionState.Closed Then
            connt.Open()
        End If

        drt = cmdt.ExecuteReader
        If drt.HasRows Then
            Do While drt.Read
                GejalaDB(drt.Item(3).ToString, rtxt)
            Loop
        End If
        cmdt.Dispose() : connt.Close()
    End Sub

    Public Sub ShowSolusi(txt As String)
        Dim namaGejala As String = ""
        Dim namaObat As String = ""
        cmds = New OleDbCommand("SELECT * FROM [Solusi] WHERE [Kode] = " & txt & "", conn)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        drs = cmds.ExecuteReader
        If drs.HasRows Then
            Do While drs.Read
                namaGejala = drs.Item(1).ToString
                namaObat = drs.Item(3).ToString
                MsgBox("Anda " & namaGejala & vbCrLf & "Disarankan Berobat Dengan : " & vbCrLf & SelectObat(namaObat), MsgBoxStyle.Information, "Hasil Diagnosa")
            Loop
        End If
        cmds.Dispose()

        Dim result = MsgBox("Mau Menyimpan Hasil Diagnosa Anda?", MsgBoxStyle.YesNo, "Hasil Diagnosa")
        If result = MsgBoxResult.Yes Then
            InsertHasil(namaGejala, SelectObat(namaObat))
            MsgBox("Tersimpan", MsgBoxStyle.Information, "Hasil Diagnosa Tersimpan")
            FrmDiagnosa.Close()
            FrmHasilDiagnosa.Show()
        Else
            FrmDiagnosa.Close()
        End If
    End Sub

    Public Sub GejalaDB(txt As String, rtxt As RichTextBox)
        If txt.Substring(0, 1) = "G" Then 'Jika Awalan Kode "G" Lanjut Ke Gejala Berikutnya
            no += 1
            ShowGejala(rtxt)
        ElseIf txt.Substring(0, 1) = "S" Then 'Jika Awalan Kode "S" Tampilkan Solusi
            ShowSolusi(txt.Remove(0, 1))
        End If
    End Sub

    Public Function SelectObat(obat As String) As String
        Dim lObat As New List(Of String)
        Dim substrings = obat.Split(","c)
        For i = 0 To substrings.GetUpperBound(0)
            substrings(i) = CInt(substrings(i).Substring(1, 1))
        Next
        Dim strJoin = String.Join(", ", substrings)
        cmdl = New OleDbCommand("SELECT * FROM [Obat] WHERE [Kode] IN (" & strJoin & ")", conn2)
        If conn2.State = ConnectionState.Closed Then
            conn2.Open()
        End If
        drl = cmdl.ExecuteReader
        If drl.HasRows Then
            Do While drl.Read
                lObat.Add(drl.Item(1).ToString)
            Loop
        End If

        drl.Close() : cmdl.Dispose() : conn2.Close()
        Return String.Join(", ", lObat.ToArray)
    End Function

    Public Sub InsertHasil(hasil As String, obat As String)
        vUser = FrmLogin.txtUser.Text
        cmd = New OleDbCommand("INSERT INTO [Hasil Diagnosa] ([Nama], [Hasil], [Obat]) VALUES (@Nama, @Hasil, @Obat)", conn2)
        cmd.Parameters.Add(New OleDbParameter("@Nama", FrmLogin.txtUser.Text))
        cmd.Parameters.Add(New OleDbParameter("@Hasil", hasil))
        cmd.Parameters.Add(New OleDbParameter("@Obat", obat))
        If conn2.State = ConnectionState.Closed Then
            conn2.Open()
        End If
        cmd.ExecuteNonQuery()
        cmd.Dispose() : conn2.Close()
    End Sub

    Public Sub LoadHasilDiagnosa(dgv As DataGridView)
        dt = LoadTable("SELECT * FROM [Hasil Diagnosa] WHERE [Nama] = '" & vUser & "'")
        dgv.DataSource = dt
    End Sub

End Class