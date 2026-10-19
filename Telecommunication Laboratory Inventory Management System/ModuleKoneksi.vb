Imports MySql.Data.MySqlClient
Imports System.Data

Module Koneksi
    Public Conn As MySqlConnection
    Public Cmd As MySqlCommand
    Public Da As MySqlDataAdapter

    '====================================
    ' OPEN CONNECTION
    '====================================
    Public Sub bukakoneksi()
        Try
            If Conn Is Nothing Then
                Conn = New MySqlConnection("server=localhost;user id=root;password=;database=dbinventarislabtelkom")
            End If

            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If

        Catch ex As Exception
            MsgBox("Gagal konek database: " & ex.Message)
        End Try
    End Sub

    '====================================
    ' EXECUTE NON QUERY (INSERT/UPDATE/DELETE)
    '====================================
    Public Function ExecuteNonQuery(ByVal q As String) As Boolean
        Try
            bukakoneksi()
            Cmd = New MySqlCommand(q, Conn)
            Cmd.ExecuteNonQuery()
            Return True

        Catch ex As Exception
            MsgBox("Query Error: " & ex.Message)
            Return False
        End Try
    End Function

    '====================================
    ' EXECUTE SELECT → RETURN DATATABLE
    '====================================
    Public Function GetDataTable(ByVal q As String) As DataTable
        Try
            bukakoneksi()
            Da = New MySqlDataAdapter(q, Conn)
            Dim dt As New DataTable
            Da.Fill(dt)
            Return dt

        Catch ex As Exception
            MsgBox("Load Data Error: " & ex.Message)
            Return Nothing
        End Try
    End Function

End Module