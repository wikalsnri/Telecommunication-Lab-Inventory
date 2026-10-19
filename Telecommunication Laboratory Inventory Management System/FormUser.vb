Public Class FormUser

    Private Sub FormUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadRole()
        LoadDataUser()
        lblnamauser.Text = LoggedUserName
        lblroleuser.Text = LoggedUserRole
    End Sub

    Private Sub LoadRole()
        cmbrole.Items.Clear()
        cmbrole.Items.Add("Admin")
        cmbrole.Items.Add("Staff")
        cmbrole.Items.Add("Kepala Lab")
    End Sub

    Private Sub LoadDataUser()
        Dim user As New ClassUser
        dgvuser.DataSource = user.GetAllUsers()
    End Sub

    Private Sub ClearForm()
        txtIdUser.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        cmbRole.SelectedIndex = -1
        txtCari.Clear()
    End Sub

    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        ClearForm()
    End Sub

    Private Sub dgvuser_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvuser.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvuser.Rows(e.RowIndex)

            txtiduser.Text = row.Cells("iduser").Value.ToString()
            txtusername.Text = row.Cells("username").Value.ToString()
            txtpassword.Text = row.Cells("password").Value.ToString()
            cmbrole.Text = row.Cells("role").Value.ToString()
        End If
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        If txtiduser.Text = "" Or txtusername.Text = "" Or txtpassword.Text = "" Then
            MsgBox("Isi semua field!", vbExclamation)
            Exit Sub
        End If

        Dim u As New ClassUser With {
            .IdUser = txtiduser.Text,
            .Username = txtusername.Text,
            .Password = txtpassword.Text,
            .NamaLengkap = "-",
            .Role = cmbrole.Text
            }

        If u.InsertUser() Then
            MsgBox("User berhasil ditambahkan!", vbInformation)
            LoadDataUser()
            ClearForm()
        End If
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        If txtiduser.Text = "" Then
            MsgBox("Pilih data dulu!", vbExclamation)
            Exit Sub
        End If

        Dim u As New ClassUser With {
            .IdUser = txtiduser.Text,
            .Username = txtusername.Text,
            .Password = txtpassword.Text,
            .NamaLengkap = "-",
            .Role = cmbrole.Text
        }

        If u.UpdateUser() Then
            MsgBox("User berhasil diupdate!", vbInformation)
            LoadDataUser()
        End If
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        If txtiduser.Text = "" Then
            MsgBox("Pilih data dulu!", vbExclamation)
            Exit Sub
        End If

        Dim u As New ClassUser With {.IdUser = txtiduser.Text}

        If u.DeleteUser() Then
            MsgBox("User berhasil dihapus!", vbInformation)
            LoadDataUser()
            ClearForm()
        End If
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        LoadDataUser()
    End Sub

    Private Sub btncari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncari.Click
        Dim keyword As String = txtcari.Text

        Dim query As String =
            "SELECT * FROM tbuser WHERE " &
            "iduser LIKE '%" & keyword & "%' OR " &
            "username LIKE '%" & keyword & "%' OR " &
            "role LIKE '%" & keyword & "%'"

        dgvuser.DataSource = GetDataTable(query)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dashboard.Show()
        Me.Close()
    End Sub
End Class