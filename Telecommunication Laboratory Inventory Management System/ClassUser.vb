Public Class ClassUser
    Public Property IdUser As String
    Public Property Username As String
    Public Property Password As String
    Public Property NamaLengkap As String
    Public Property Role As String

    '=========================
    ' INSERT USER
    '=========================
    Public Function InsertUser() As Boolean
        Dim q As String =
            "INSERT INTO tbuser (iduser, username, password, namalengkap, role) VALUES (" &
            "'" & IdUser & "'," &
            "'" & Username & "'," &
            "'" & Password & "'," &
            "'" & NamaLengkap & "'," &
            "'" & Role & "')"

        Return ExecuteNonQuery(q)
    End Function

    '=========================
    ' UPDATE USER
    '=========================
    Public Function UpdateUser() As Boolean
        Dim q As String =
            "UPDATE tbuser SET " &
            "username='" & Username & "', " &
            "password='" & Password & "', " &
            "namalengkap='" & NamaLengkap & "', " &
            "role='" & Role & "' " &
            "WHERE iduser='" & IdUser & "'"

        Return ExecuteNonQuery(q)
    End Function

    '=========================
    ' DELETE USER
    '=========================
    Public Function DeleteUser() As Boolean
        Dim q As String = "DELETE FROM tbuser WHERE iduser='" & IdUser & "'"
        Return ExecuteNonQuery(q)
    End Function

    '=========================
    ' GET ALL USERS (untuk DataGridView)
    '=========================
    Public Function GetAllUsers() As DataTable
        Return GetDataTable("SELECT * FROM tbuser ORDER BY iduser")
    End Function

End Class