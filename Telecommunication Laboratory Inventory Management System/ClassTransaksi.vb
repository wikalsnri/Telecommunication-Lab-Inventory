Imports MySql.Data.MySqlClient

Public Class ClassTransaksi

    Public Property IdTransaksi As String
    Public Property TipeItem As String
    Public Property IdItem As String
    Public Property Jumlah As Integer
    Public Property Peminjam As String
    Public Property TglPinjam As String
    Public Property TglKembali As String
    Public Property Status As String
    Public Property KondisiKembali As String
    Public Property IdUser As String


    '=====================================
    ' INSERT PEMINJAMAN
    '=====================================
    Public Function InsertTransaksi() As Boolean
        Try
            bukaKoneksi()

            Dim q As String = "INSERT INTO tbtransaksi "
                (idtransaksi, tipeitem, iditem, jumlah, peminjam, tglpinjam, status, iduser)
            VALUES()
                (@id, @tipe, @item, @jumlah, @peminjam, @tglpinjam, 'Dipinjam', @user)"

            Dim cmd As New MySqlCommand(q, conn)
            cmd.Parameters.AddWithValue("@id", IdTransaksi)
            cmd.Parameters.AddWithValue("@tipe", TipeItem)
            cmd.Parameters.AddWithValue("@item", IdItem)
            cmd.Parameters.AddWithValue("@jumlah", Jumlah)
            cmd.Parameters.AddWithValue("@peminjam", Peminjam)
            cmd.Parameters.AddWithValue("@tglpinjam", TglPinjam)
            cmd.Parameters.AddWithValue("@user", IdUser)

            cmd.ExecuteNonQuery()
            Return True

        Catch ex As Exception
            MsgBox("Insert Error: " & ex.Message)
            Return False
        End Try
    End Function


    '=====================================
    ' UPDATE PENGEMBALIAN
    '=====================================
    Public Function UpdatePengembalian() As Boolean
        Try
            bukaKoneksi()

            Dim q As String = "UPDATE tbtransaksi SET"
                tglkembali=@tgl,
                kondisikembali=@kondisi,
                status='Dikembalikan'
                WHERE idtransaksi=@id"

            Dim cmd As New MySqlCommand(q, conn)
            cmd.Parameters.AddWithValue("@tgl", TglKembali)
            cmd.Parameters.AddWithValue("@kondisi", KondisiKembali)
            cmd.Parameters.AddWithValue("@id", IdTransaksi)

            cmd.ExecuteNonQuery()
            Return True

        Catch ex As Exception
            MsgBox("Update Error: " & ex.Message)
            Return False
        End Try
    End Function


    '=====================================
    ' READ ALL
    '=====================================
    Public Function GetAllTransaksi() As DataTable
        Return GetDataTable("SELECT * FROM tbtransaksi ORDER BY idtransaksi DESC")
    End Function

End Class
