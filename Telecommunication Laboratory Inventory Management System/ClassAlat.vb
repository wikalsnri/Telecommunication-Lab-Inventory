Imports MySql.Data.MySqlClient

Public Class ClassAlat
    Public Property IdAlat As String
    Public Property NamaAlat As String
    Public Property KateId As String
    Public Property LokasiId As String
    Public Property Jumlah As Integer
    Public Property Kondisi As String
    Public Property Keterangan As String

    '=============================
    ' INSERT ALAT
    '=============================
    Public Function InsertAlat() As Boolean
        Dim q As String =
            "INSERT INTO tbalat (idalat, namaalat, kateid, lokasiid, jumlah, kondisi, keterangan) VALUES (" &
            "'" & IdAlat & "'," &
            "'" & NamaAlat & "'," &
            "'" & KateId & "'," &
            "'" & LokasiId & "'," &
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
    ' UPDATE ALAT
    '=============================
    Public Function UpdateAlat() As Boolean
        Dim q As String =
            "UPDATE tbalat SET " &
            "namaalat='" & NamaAlat & "', " &
            "kateid='" & KateId & "', " &
            "lokasiid='" & LokasiId & "', " &
            "jumlah='" & Jumlah & "', " &
            "kondisi='" & Kondisi & "', " &
            "keterangan='" & Keterangan & "' " &
            "WHERE idalat='" & IdAlat & "'"

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
    ' DELETE ALAT
    '=============================
    Public Function DeleteAlat() As Boolean
        Dim q As String = "DELETE FROM tbalat WHERE idalat='" & IdAlat & "'"

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
    ' GET DATA ALAT
    '=============================
    Public Function GetAllAlat() As DataTable
        Return GetDataTable("SELECT * FROM tbalat ORDER BY idalat")
    End Function

End Class