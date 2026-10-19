Public Class FormAlat

    Private Sub FormAlat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadKategori()
        LoadLokasi()
        LoadKondisi()
        LoadDataAlat()
        lblnamauser.Text = LoggedUserName
        lblroleuser.Text = LoggedUserRole
    End Sub

    Private Sub LoadDataAlat()
        Dim alat As New ClassAlat
        dgvAlat.DataSource = alat.GetAllAlat()
    End Sub

    Private Sub LoadKategori()
        Dim dt As DataTable = GetDataTable("SELECT * FROM tbkategori")
        cmbKategori.DataSource = dt
        cmbKategori.DisplayMember = "namakate"
        cmbKategori.ValueMember = "idkate"
    End Sub

    Private Sub LoadLokasi()
        Dim dt As DataTable = GetDataTable("SELECT * FROM tblokasi")
        cmbLokasi.DataSource = dt
        cmbLokasi.DisplayMember = "ruangan"
        cmbLokasi.ValueMember = "idlok"
    End Sub

    Private Sub LoadKondisi()
        cmbKondisi.Items.Clear()
        cmbKondisi.Items.Add("Baik")
        cmbkondisi.Items.Add("Rusak")
        cmbkondisi.Items.Add("Hilang")
    End Sub

    Private Sub ClearForm()
        txtIdAlat.Clear()
        txtNamaAlat.Clear()
        txtketerangan.Clear()
        txtKeterangan.Clear()
        cmbKategori.SelectedIndex = -1
        cmbLokasi.SelectedIndex = -1
        cmbKondisi.SelectedIndex = -1
        txtCari.Clear()
    End Sub

    Private Sub dgvalat_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvalat.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvalat.Rows(e.RowIndex)

            txtidalat.Text = row.Cells("idalat").Value.ToString()
            txtnamaalat.Text = row.Cells("namaalat").Value.ToString()
            cmbkategori.SelectedValue = row.Cells("kateid").Value.ToString()
            cmblokasi.SelectedValue = row.Cells("lokasiid").Value.ToString()
            txtjumlah.Text = row.Cells("jumlah").Value.ToString()
            cmbkondisi.Text = row.Cells("kondisi").Value.ToString()
            txtketerangan.Text = row.Cells("keterangan").Value.ToString()
        End If
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        Dim a As New ClassAlat With {
        .IdAlat = txtidalat.Text,
        .NamaAlat = txtnamaalat.Text,
        .KateId = cmbkategori.SelectedValue,
        .LokasiId = cmblokasi.SelectedValue,
        .Jumlah = Val(txtjumlah.Text),
        .Kondisi = cmbkondisi.Text,
        .Keterangan = txtketerangan.Text
    }

        If a.InsertAlat() Then
            MsgBox("Data alat berhasil ditambahkan!", vbInformation)
            LoadDataAlat()
            ClearForm()
        End If
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        Dim a As New ClassAlat With {
       .IdAlat = txtidalat.Text,
       .NamaAlat = txtnamaalat.Text,
       .KateId = cmbkategori.SelectedValue,
       .LokasiId = cmblokasi.SelectedValue,
       .Jumlah = Val(txtjumlah.Text),
       .Kondisi = cmbkondisi.Text,
       .Keterangan = txtketerangan.Text
   }

        If a.UpdateAlat() Then
            MsgBox("Data alat berhasil diupdate!", vbInformation)
            LoadDataAlat()
        End If
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        If txtidalat.Text = "" Then
            MsgBox("Pilih data terlebih dahulu!", vbExclamation)
            Exit Sub
        End If

        Dim a As New ClassAlat With {.IdAlat = txtidalat.Text}

        If a.DeleteAlat() Then
            MsgBox("Data alat berhasil dihapus!", vbInformation)
            LoadDataAlat()
            ClearForm()
        End If
    End Sub

    Private Sub btncari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncari.Click
        Dim keyword As String = txtcari.Text

        Dim query As String =
            "SELECT * FROM tbalat WHERE " &
            "idalat LIKE '%" & keyword & "%' OR " &
            "namaalat LIKE '%" & keyword & "%' OR " &
            "kondisi LIKE '%" & keyword & "%'"

        dgvalat.DataSource = GetDataTable(query)
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        LoadDataAlat()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dashboard.Show()
        Me.Close()
    End Sub
End Class