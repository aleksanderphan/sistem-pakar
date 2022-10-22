Imports System.Data.OleDb

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
        cmds = New OleDbCommand("SELECT * FROM [Solusi] WHERE [Kode] = " & txt & "", conn)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        drs = cmds.ExecuteReader
        If drs.HasRows Then
            Do While drs.Read
                MsgBox("Anda " & drs.Item(1).ToString, MsgBoxStyle.Information, "Hasil Diagnosa")
            Loop
        End If
        cmds.Dispose()

        Dim result = MsgBox("Mau Menyimpan Hasil Diagnosa Anda?", MsgBoxStyle.YesNo, "Hasil Diagnosa")
        If result = MsgBoxResult.Yes Then
            'WIP : Proses Untuk Menyimpan Hasil Diagnosa Ke Tabel HasilDiagnosa
            MsgBox("Tersimpan", MsgBoxStyle.Information, "Hasil Diagnosa Tersimpan")
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

End Class