Public Class Dashboard

    Private Sub Dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblnamauser.Text = LoggedUserName
        lblroleuser.Text = LoggedUserRole
    End Sub

    Private Sub btnalat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalat.Click
        FormAlat.Show()
    End Sub

    Private Sub btnkomponen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkomponen.Click
        FormKomponen.Show()
    End Sub

    Private Sub btnuser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnuser.Click
        FormUser.Show()
    End Sub

    Private Sub btnlokasi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlokasi.Click
        FormLokasi.Show()
    End Sub

    Private Sub btnkategori_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkategori.Click
        FormKategori.Show()
    End Sub

    Private Sub btntransaksi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntransaksi.Click
        FormTransaksi.Show()
    End Sub

    Private Sub btnlaporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlaporan.Click
        FormLaporan.Show()
    End Sub

    Private Sub btnlogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogout.Click
        LoggedUserID = ""
        LoggedUserRole = ""
        LoggedUserName = ""

        Me.Hide()
        FormLogin.Show()
    End Sub
End Class