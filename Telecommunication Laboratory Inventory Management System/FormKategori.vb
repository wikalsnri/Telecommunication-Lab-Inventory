Public Class FormKategori

    Private Sub FormKategori_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDataKategori()
        lblnamauser.Text = LoggedUserName
        lblroleuser.Text = LoggedUserRole
    End Sub

    Private Sub LoadDataKategori()
        Dim k As New ClassKategori
        dgvKategori.DataSource = k.GetAllKategori()
    End Sub

    Private Sub ClearForm()
        txtID.Clear()
        txtNamaKategori.Clear()
        txtCari.Clear()
    End Sub

    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        ClearForm()
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        LoadDataKategori()
        ClearForm()
    End Sub

    Private Sub dgvkategori_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvkategori.CellContentClick
        If e.RowIndex >= 0 Then
            Dim r As DataGridViewRow = dgvkategori.Rows(e.RowIndex)

            txtid.Text = r.Cells("idkate").Value.ToString()
            txtnamakategori.Text = r.Cells("namakate").Value.ToString()
        End If
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        Dim k As New ClassKategori With {
       .IdKate = txtid.Text,
       .NamaKate = txtnamakategori.Text
   }

        If k.InsertKategori() Then
            MsgBox("Kategori berhasil ditambahkan!")
            LoadDataKategori()
            ClearForm()
        End If
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        Dim k As New ClassKategori With {
       .IdKate = txtid.Text,
       .NamaKate = txtnamakategori.Text
   }

        If k.UpdateKategori() Then
            MsgBox("Kategori berhasil diperbarui!")
            LoadDataKategori()
        End If
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        If txtid.Text = "" Then
            MsgBox("Pilih kategori dulu!")
            Exit Sub
        End If

        Dim k As New ClassKategori With {.IdKate = txtid.Text}

        If k.DeleteKategori() Then
            MsgBox("Kategori berhasil dihapus!")
            LoadDataKategori()
            ClearForm()
        End If

    End Sub

    Private Sub btncari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncari.Click
        Dim key As String = txtcari.Text

        Dim q As String =
            "SELECT * FROM tbkategori WHERE " &
            "idkate LIKE '%" & key & "%' OR " &
            "namakate LIKE '%" & key & "%'"

        dgvkategori.DataSource = GetDataTable(q)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dashboard.Show()
        Me.Close()
    End Sub

    Private Sub txtid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid.TextChanged

    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged

    End Sub
End Class