Imports System.Data.OleDb

Module ModConnection

    Public conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DBSistemPakar.accdb")
    Public cmd, cmdy, cmdt, cmdg, cmds As New OleDbCommand
    Public dt As New DataTable
    Public ds As New DataSet
    Public da As New OleDbDataAdapter
    Public dr, dry, drt, drg, drs As OleDbDataReader

    Public Function LoadTable(query As String) As DataTable
        conn.Open()
        Try
            cmd = New OleDbCommand(query, conn)
            dr = cmd.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        dt.Load(dr)
        cmd.Dispose() : dr.Close() : conn.Close()
        Return dt
    End Function
End Module