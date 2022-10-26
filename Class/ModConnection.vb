Imports System.Data.OleDb

Module ModConnection

    Public conn, conny, connt, conn2, connc As New OleDbConnection(My.Settings.DBSistemPakarConnectionString)
    Public cmd, cmdy, cmdt, cmdg, cmds, cmdl, cmdc As New OleDbCommand
    Public dt, dt2, dt3 As New DataTable
    Public ds, ds2, ds3 As New DataSet
    Public da, da2, da3 As New OleDbDataAdapter
    Public dr, dry, drt, drg, drs, drl, drc As OleDbDataReader

    Public Function LoadTable(query As String) As DataTable
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Try
            da = New OleDbDataAdapter(query, conn)
            dt.Clear()
            da.Fill(dt)
            da = Nothing
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        conn.Close()
        Return dt
    End Function

    Public Function LoadTable2(query As String) As DataTable
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Try
            da2 = New OleDbDataAdapter(query, conn)
            dt2.Clear()
            da2.Fill(dt2)
            da2 = Nothing
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        conn.Close()
        Return dt2
    End Function

    Public Function LoadTable3(query As String) As DataTable
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Try
            da3 = New OleDbDataAdapter(query, conn)
            dt3.Clear()
            da3.Fill(dt3)
            da3 = Nothing
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        conn.Close()
        Return dt3
    End Function

End Module