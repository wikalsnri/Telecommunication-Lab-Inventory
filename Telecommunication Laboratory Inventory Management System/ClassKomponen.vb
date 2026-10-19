Imports MySql.Data.MySqlClient

Public Class ClassKomponen
    Public Property IdKomp As String
    Public Property NamaKomp As String
    Public Property KateID As String
    Public Property LokasiID As String
    Public Property Jumlah As Integer
    Public Property Kondisi As String
    Public Property Keterangan As String

    '=============================
    ' INSERT
    '=============================
    Public Function InsertKomponen() As Boolean
        Dim q As String =
            "INSERT INTO tbkomponen (idkomp, namakomp, kateid, lokasiid, jumlah, kondisi, keterangan) VALUES (" &
            "'" & IdKomp & "'," &
            "'" & NamaKomp & "'," &
            "'" & KateID & "'," &
            "'" & LokasiID & "'," &
            "'" & Jumlah & "'," &
            "'" & Kondisi & "'," &
            "'" & Keterangan & "')"

        Try
            Dim cmd As New MySqlCommand(q, conn)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    '=============================
    ' UPDATE
    '=============================
    Public Function UpdateKomponen() As Boolean
        Dim q As String =
            "UPDATE tbkomponen SET " &
            "namakomp='" & NamaKomp & "', " &
            "kateid='" & KateID & "', " &
            "lokasiid='" & LokasiID & "', " &
            "jumlah='" & Jumlah & "', " &
            "kondisi='" & Kondisi & "', " &
            "keterangan='" & Keterangan & "' " &
            "WHERE idkomp='" & IdKomp & "'"

        Try
            Dim cmd As New MySqlCommand(q, conn)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    '=============================
    ' DELETE
    '=============================
    Public Function DeleteKomponen() As Boolean
        Dim q As String = "DELETE FROM tbkomponen WHERE idkomp='" & IdKomp & "'"

        Try
            Dim cmd As New MySqlCommand(q, conn)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    '=============================
    ' READ ALL
    '=============================
    Public Function GetAllKomponen() As DataTable
        Return GetDataTable("SELECT * FROM tbkomponen ORDER BY idkomp")
    End Function

End Class