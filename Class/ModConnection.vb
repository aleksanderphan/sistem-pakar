﻿Imports System.Data.OleDb

Module ModConnection

    Public conn, conny, connt, conn2, connc As New OleDbConnection(My.Settings.DBSistemPakarConnectionString)
    Public cmd, cmdy, cmdt, cmdg, cmds, cmdl, cmdc As New OleDbCommand
    Public dt As New DataTable
    Public ds As New DataSet
    Public da As New OleDbDataAdapter
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

End Module