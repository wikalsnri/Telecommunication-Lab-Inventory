Imports MySql.Data.MySqlClient

Public Class ClassKategori
    Public Property IdKate As String
    Public Property NamaKate As String

    '=====================================
    ' INSERT
    '=====================================
    Public Function InsertKategori() As Boolean
        Dim q As String =
            "INSERT INTO tbkategori (idkate, namakate) VALUES (" &
            "'" & IdKate & "'," &
            "'" & NamaKate & "')"

        Try
            Dim cmd As New MySqlCommand(q, conn)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    '=====================================
    ' UPDATE
    '=====================================
    Public Function UpdateKategori() As Boolean
        Dim q As String =
            "UPDATE tbkategori SET " &
            "namakate='" & NamaKate & "' " &
            "WHERE idkate='" & IdKate & "'"

        Try
            Dim cmd As New MySqlCommand(q, conn)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    '=====================================
    ' DELETE
    '=====================================
    Public Function DeleteKategori() As Boolean
        Dim q As String = "DELETE FROM tbkategori WHERE idkate='" & IdKate & "'"

        Try
            Dim cmd As New MySqlCommand(q, conn)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    '=====================================
    ' READ ALL
    '=====================================
    Public Function GetAllKategori() As DataTable
        Return GetDataTable("SELECT * FROM tbkategori ORDER BY idkate")
    End Function

End Class