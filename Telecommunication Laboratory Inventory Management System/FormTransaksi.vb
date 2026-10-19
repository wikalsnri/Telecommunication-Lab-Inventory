Imports MySql.Data.MySqlClient

Public Class FormTransaksi
    Private Sub FormTransaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtiduser.Text = LoggedUserID
        lblnamauser.Text = LoggedUserName
        lblroleuser.Text = LoggedUserRole

        LoadTipeItem()
        LoadKondisiKembali()
        LoadDataTransaksi()
    End Sub

    Private Sub LoadTipeItem()
        cmbTipeItem.Items.Clear()
        cmbTipeItem.Items.Add("Alat")
        cmbTipeItem.Items.Add("Komponen")
        cmbTipeItem.SelectedIndex = -1
    End Sub

    Private Sub LoadKondisiKembali()
        cmbKondisiKembali.Items.Clear()
        cmbKondisiKembali.Items.Add("Baik")
        cmbKondisiKembali.Items.Add("Rusak")
        cmbKondisiKembali.Items.Add("Hilang")
        cmbKondisiKembali.SelectedIndex = -1
    End Sub

    Private Sub cmbTipeItem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipeItem.SelectedIndexChanged

        If cmbTipeItem.SelectedIndex = -1 Then Exit Sub

        Dim q As String

        If cmbTipeItem.Text = "Alat" Then
            q = "SELECT idalat AS id, namaalat AS nama FROM tbalat"
        Else
            q = "SELECT idkomp AS id, namakomp AS nama FROM tbkomponen"
        End If

        Dim dt As DataTable = GetDataTable(q)

        cmbItem.DataSource = dt
        cmbItem.DisplayMember = "nama"
        cmbItem.ValueMember = "id"
        cmbItem.SelectedIndex = -1
    End Sub

    Private Sub btnPinjam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPinjam.Click

        If cmbItem.SelectedIndex = -1 Then
            MsgBox("Pilih item terlebih dahulu!", vbExclamation)
            Exit Sub
        End If

        Dim t As New ClassTransaksi With {
            .IdTransaksi = txtidpinjam.Text,
            .TipeItem = cmbTipeItem.Text,
            .IdItem = cmbItem.SelectedValue.ToString(),
            .Jumlah = Val(txtJumlah.Text),
            .Peminjam = txtPeminjam.Text,
            .TglPinjam = dtPinjam.Value.ToString("yyyy-MM-dd"),
            .IdUser = txtiduser.Text
        }

        If t.InsertTransaksi() Then
            MsgBox("Peminjaman berhasil dicatat!", vbInformation)
            LoadDataTransaksi()
            ClearPeminjaman()
        End If

    End Sub


    Private Sub btnKembalikan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKembalikan.Click

        If cmbKondisiKembali.SelectedIndex = -1 Then
            MsgBox("Pilih kondisi pengembalian!", vbExclamation)
            Exit Sub
        End If

        Dim t As New ClassTransaksi With {
            .IdTransaksi = txtidkembali.Text,
            .TglKembali = dtKembali.Value.ToString("yyyy-MM-dd"),
            .KondisiKembali = cmbKondisiKembali.Text
        }

        If t.UpdatePengembalian() Then
            MsgBox("Pengembalian berhasil dicatat!", vbInformation)
            LoadDataTransaksi()
            ClearPengembalian()
        End If

    End Sub


    Private Sub LoadDataTransaksi()
        dgvTransaksi.DataSource = GetDataTable(
            "SELECT * FROM tbtransaksi ORDER BY idtransaksi DESC"
        )
    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        dgvTransaksi.DataSource = GetDataTable(
            "SELECT * FROM tbtransaksi WHERE peminjam LIKE '%" & txtCari.Text & "%'"
        )
    End Sub


    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRefresh.Click
        txtCari.Clear()
        LoadDataTransaksi()
    End Sub


    Private Sub ClearPeminjaman()
        txtidpinjam.Clear()
        txtJumlah.Clear()
        txtPeminjam.Clear()
        cmbTipeItem.SelectedIndex = -1
        cmbItem.DataSource = Nothing
    End Sub

    Private Sub ClearPengembalian()
        txtidkembali.Clear()
        cmbKondisiKembali.SelectedIndex = -1
    End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dashboard.Show()
        Me.Close()
    End Sub
End Class