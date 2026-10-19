Public Class FormLaporan

    Private Sub FormLaporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadJenisLaporan()
        LoadTipeItem()
        ResetFilter()
        lblnamauser.Text = LoggedUserName
        lblroleuser.Text = LoggedUserRole
    End Sub

    Private Sub LoadJenisLaporan()
        cmbJenisLaporan.Items.Clear()
        cmbJenisLaporan.Items.Add("Semua Transaksi")
        cmbJenisLaporan.Items.Add("Peminjaman Saja")
        cmbJenisLaporan.Items.Add("Pengembalian Saja")
        cmbJenisLaporan.SelectedIndex = 0
    End Sub

    Private Sub LoadTipeItem()
        cmbTipeItem.Items.Clear()
        cmbTipeItem.Items.Add("Semua")
        cmbTipeItem.Items.Add("Alat")
        cmbTipeItem.Items.Add("Komponen")
        cmbTipeItem.SelectedIndex = 0
    End Sub

    Private Sub ResetFilter()
        dtAwal.Value = Today.AddMonths(-1)
        dtAkhir.Value = Today
        dgvLaporan.DataSource = Nothing
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        ResetFilter()
    End Sub

    Private Sub btntampilkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntampilkan.Click
        LoadLaporan()
    End Sub

    Private Sub LoadLaporan()
        Dim sql As String =
            "SELECT t.idtransaksi, t.tipeitem, " &
            "CASE WHEN t.tipeitem='Alat' THEN a.namaalat ELSE k.namakomp END AS nama_item, " &
            "t.jumlah, t.peminjam, t.tglpinjam, t.tglkembali, t.iduser " &
            "FROM tbtransaksi t " &
            "LEFT JOIN tbalat a ON t.iditem = a.idalat AND t.tipeitem='Alat' " &
            "LEFT JOIN tbkomponen k ON t.iditem = k.idkomp AND t.tipeitem='Komponen' " &
            "WHERE 1=1 "

        ' Filter jenis laporan
        Select Case cmbjenislaporan.Text
            Case "Peminjaman Saja"
                sql &= " AND t.tglkembali IS NULL"
            Case "Pengembalian Saja"
                sql &= " AND t.tglkembali IS NOT NULL"
        End Select

        ' Filter tanggal
        sql &= " AND t.tglpinjam BETWEEN '" &
         dtawal.Value.ToString("yyyy-MM-dd") &
         "' AND '" &
         dtakhir.Value.ToString("yyyy-MM-dd") &
         "'"

        ' Filter tipe item
        If cmbtipeitem.Text = "Alat" Then
            sql &= " AND t.tipeitem='Alat'"
        ElseIf cmbtipeitem.Text = "Komponen" Then
            sql &= " AND t.tipeitem='Komponen'"
        End If

        sql &= " ORDER BY t.idtransaksi DESC"

        dgvlaporan.DataSource = GetDataTable(sql)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dashboard.Show()
        Me.Close()
    End Sub
End Class