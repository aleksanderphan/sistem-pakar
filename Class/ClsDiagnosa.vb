﻿Imports System.Data.OleDb

Public Class ClsDiagnosa

    Dim no As Integer = 1

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
        cmdy = New OleDbCommand("SELECT * FROM [Gejala] WHERE [Kode] = " & no & "", conn)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        dry = cmdy.ExecuteReader
        If dry.HasRows Then
            Do While dry.Read
                GejalaDB(dry.Item(2).ToString, rtxt)
            Loop
        End If
        cmdy.Dispose() : conn.Close()
    End Sub

    Public Sub GejalaTidak(rtxt As RichTextBox)
        cmdt = New OleDbCommand("SELECT * FROM [Gejala] WHERE [Kode] = " & no & "", conn)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        drt = cmdt.ExecuteReader
        If drt.HasRows Then
            Do While drt.Read
                GejalaDB(drt.Item(3).ToString, rtxt)
            Loop
        End If
        cmdt.Dispose() : conn.Close()
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
                MsgBox("Anda " & namaGejala & vbCrLf & "Disarankan Berobat Dengan : " & namaObat, MsgBoxStyle.Information, "Hasil Diagnosa")
            Loop
        End If
        cmds.Dispose()

        Dim result = MsgBox("Mau Menyimpan Hasil Diagnosa Anda?", MsgBoxStyle.YesNo, "Hasil Diagnosa")
        If result = MsgBoxResult.Yes Then
            'WIP : 
            InsertHasil(namaGejala, SelectObat(namaObat))
            MsgBox("Tersimpan", MsgBoxStyle.Information, "Hasil Diagnosa Tersimpan")
            FrmDiagnosa.Close()
            FrmHasilDiagnosa.Show()
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
            substrings(i) = "'" & substrings(i).Trim() & "'"
        Next
        Dim strJoin = String.Join(", ", substrings)
        cmd = New OleDbCommand("SELECT [Nama] FROM [Obat] WHERE [Kode] IN (@Kode)", conn)
        cmd.Parameters.Add(New OleDbParameter("@Kode", strJoin))
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            lObat.Add(dr.Item(0).ToString)
        End If

        dr.Close() : cmd.Dispose() : conn.Close()
        Return String.Join(",", lObat.ToArray)
    End Function

    Public Sub InsertHasil(hasil As String, obat As String)
        cmd = New OleDbCommand("INSERT INTO [Hasil Diagnosa] ([Nama], [Hasil], [Obat]) VALUES (@Nama, @Hasil, @Obat)", conn)
        cmd.Parameters.Add(New OleDbParameter("@Nama", FrmLogin.txtUser.Text))
        cmd.Parameters.Add(New OleDbParameter("@Hasil", hasil))
        cmd.Parameters.Add(New OleDbParameter("@Obat", obat))
        conn.Open() : cmd.ExecuteNonQuery()
        cmd.Dispose() : conn.Close()
    End Sub

End Class