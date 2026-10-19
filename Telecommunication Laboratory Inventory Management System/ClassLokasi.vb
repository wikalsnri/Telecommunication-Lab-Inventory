Public Class ClassLokasi
    Public Property IdLok As String
    Public Property Ruangan As String
    Public Property Rak As String

    '=====================================
    ' INSERT
    '=====================================
    Public Function InsertLokasi() As Boolean
        Dim q As String =
            "INSERT INTO tblokasi (idlok, ruangan, rak) VALUES (" &
            "'" & IdLok & "'," &
            "'" & Ruangan & "'," &
            "'" & Rak & "')"

        Return ExecuteNonQuery(q)
    End Function

    '=====================================
    ' UPDATE
    '=====================================
    Public Function UpdateLokasi() As Boolean
        Dim q As String =
            "UPDATE tblokasi SET " &
            "ruangan='" & Ruangan & "', " &
            "rak='" & Rak & "' " &
            "WHERE idlok='" & IdLok & "'"

        Return ExecuteNonQuery(q)
    End Function

    '=====================================
    ' DELETE
    '=====================================
    Public Function DeleteLokasi() As Boolean
        Dim q As String = "DELETE FROM tblokasi WHERE idlok='" & IdLok & "'"
        Return ExecuteNonQuery(q)
    End Function

    '=====================================
    ' READ ALL
    '=====================================
    Public Function GetAllLokasi() As DataTable
        Return GetDataTable("SELECT * FROM tblokasi ORDER BY idlok")
    End Function
End Class
