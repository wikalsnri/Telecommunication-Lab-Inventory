Public Class FormKomponen

    Private Sub FormKomponen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadKategori()
        LoadLokasi()
        LoadKondisi()
        LoadDataKomponen()
        lblnamauser.Text = LoggedUserName
        lblroleuser.Text = LoggedUserRole
    End Sub

    Private Sub LoadKategori()
        Dim dt As DataTable = GetDataTable("SELECT idkate, namakate FROM tbkategori")

        cmbKategori.DataSource = dt
        cmbKategori.ValueMember = "idkate"
        cmbKategori.DisplayMember = "namakate"
    End Sub

    Private Sub LoadLokasi()
        Dim dt As DataTable = GetDataTable("SELECT idlok, ruangan FROM tblokasi")

        cmbLokasi.DataSource = dt
        cmbLokasi.ValueMember = "idlok"
        cmbLokasi.DisplayMember = "ruangan"
    End Sub

    Private Sub LoadKondisi()
        cmbKondisi.Items.Clear()
        cmbKondisi.Items.Add("Baik")
        cmbKondisi.Items.Add("Rusak Ringan")
        cmbKondisi.Items.Add("Rusak Berat")
    End Sub

    Private Sub LoadDataKomponen()
        Dim k As New ClassKomponen
        dgvKomponen.DataSource = k.GetAllKomponen()
    End Sub

    Private Sub dgvkomponen_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvkomponen.CellContentClick
        If e.RowIndex >= 0 Then
            Dim r As DataGridViewRow = dgvkomponen.Rows(e.RowIndex)

            txtID.Text = r.Cells("idkomp").Value.ToString()
            txtNama.Text = r.Cells("namakomp").Value.ToString()
            cmbkategori.SelectedValue = r.Cells("kateid").Value.ToString()
            cmblokasi.SelectedValue = r.Cells("lokasiid").Value.ToString()
            txtjumlah.Text = r.Cells("jumlah").Value.ToString()
            cmbkondisi.Text = r.Cells("kondisi").Value.ToString()
            txtketerangan.Text = r.Cells("keterangan").Value.ToString()
        End If
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        Dim k As New ClassKomponen With {
        .IdKomp = txtid.Text,
        .NamaKomp = txtnama.Text,
        .KateID = cmbkategori.SelectedValue,
        .LokasiID = cmblokasi.SelectedValue,
        .Jumlah = Val(txtjumlah.Text),
        .Kondisi = cmbkondisi.Text,
        .Keterangan = txtketerangan.Text
    }

        If k.InsertKomponen() Then
            MsgBox("Data komponen berhasil ditambahkan!")
            LoadDataKomponen()
            ClearForm()
        End If
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        Dim k As New ClassKomponen With {
       .IdKomp = txtid.Text,
       .NamaKomp = txtnama.Text,
       .KateID = cmbkategori.SelectedValue,
       .LokasiID = cmblokasi.SelectedValue,
       .Jumlah = Val(txtjumlah.Text),
       .Kondisi = cmbkondisi.Text,
       .Keterangan = txtketerangan.Text
   }

        If k.UpdateKomponen() Then
            MsgBox("Data komponen berhasil diperbarui!")
            LoadDataKomponen()
        End If
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        If txtid.Text = "" Then
            MsgBox("Pilih data terlebih dahulu!")
            Exit Sub
        End If

        Dim k As New ClassKomponen With {.IdKomp = txtid.Text}

        If k.DeleteKomponen() Then
            MsgBox("Data komponen berhasil dihapus!")
            LoadDataKomponen()
            ClearForm()
        End If
    End Sub

    Private Sub btncari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncari.Click
        Dim key As String = txtcari.Text

        Dim q As String =
            "SELECT * FROM tbkomponen WHERE " &
            "idkomp LIKE '%" & key & "%' OR " &
            "namakomp LIKE '%" & key & "%' OR " &
            "kondisi LIKE '%" & key & "%'"

        dgvkomponen.DataSource = GetDataTable(q)
    End Sub

    Private Sub ClearForm()
        txtID.Clear()
        txtNama.Clear()
        txtJumlah.Clear()
        txtKeterangan.Clear()

        cmbKategori.SelectedIndex = -1
        cmbLokasi.SelectedIndex = -1
        cmbKondisi.SelectedIndex = -1

        txtCari.Clear()
    End Sub


    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        ClearForm()
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        LoadDataKomponen()
        ClearForm()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dashboard.Show()
        Me.Close()
    End Sub
End Class