Public Class FormLokasi

    Private Sub FormLokasi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDataLokasi()
        lblnamauser.Text = LoggedUserName
        lblroleuser.Text = LoggedUserRole
    End Sub

    Private Sub LoadDataLokasi()
        Dim l As New ClassLokasi
        dgvLokasi.DataSource = l.GetAllLokasi()
    End Sub

    Private Sub ClearForm()
        txtID.Clear()
        txtRuangan.Clear()
        txtRak.Clear()
        txtCari.Clear()
    End Sub

    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        ClearForm()
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        LoadDataLokasi()
        ClearForm()
    End Sub

    Private Sub dgvlokasi_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvlokasi.CellContentClick
        If e.RowIndex >= 0 Then
            Dim r As DataGridViewRow = dgvlokasi.Rows(e.RowIndex)

            txtid.Text = r.Cells("idlok").Value.ToString()
            txtruangan.Text = r.Cells("ruangan").Value.ToString()
            txtrak.Text = r.Cells("rak").Value.ToString()
        End If
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        Dim l As New ClassLokasi With {
        .IdLok = txtid.Text,
        .Ruangan = txtruangan.Text,
        .Rak = txtrak.Text
    }

        If l.InsertLokasi() Then
            MsgBox("Data lokasi berhasil ditambahkan!")
            LoadDataLokasi()
            ClearForm()
        End If
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        Dim l As New ClassLokasi With {
        .IdLok = txtid.Text,
        .Ruangan = txtruangan.Text,
        .Rak = txtrak.Text
    }

        If l.UpdateLokasi() Then
            MsgBox("Data lokasi berhasil diperbarui!")
            LoadDataLokasi()
        End If
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        If txtid.Text = "" Then
            MsgBox("Pilih data terlebih dahulu!")
            Exit Sub
        End If

        Dim l As New ClassLokasi With {.IdLok = txtid.Text}

        If l.DeleteLokasi() Then
            MsgBox("Data lokasi berhasil dihapus!")
            LoadDataLokasi()
            ClearForm()
        End If
    End Sub

    Private Sub btncari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncari.Click
        Dim key As String = txtcari.Text

        Dim q As String =
            "SELECT * FROM tblokasi WHERE " &
            "idlok LIKE '%" & key & "%' OR " &
            "ruangan LIKE '%" & key & "%' OR " &
            "rak LIKE '%" & key & "%'"

        dgvlokasi.DataSource = GetDataTable(q)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dashboard.Show()
        Me.Close()
    End Sub
End Class