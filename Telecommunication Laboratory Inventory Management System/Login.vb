Imports MySql.Data.MySqlClient

Public Class FormLogin

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Try
            bukaKoneksi()

            Dim q As String = "SELECT * FROM tbuser WHERE username=@u AND password=@p"
            Dim cmd As New MySqlCommand(q, conn)

            cmd.Parameters.AddWithValue("@u", txtUsername.Text)
            cmd.Parameters.AddWithValue("@p", txtPassword.Text)

            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            If dr.Read() Then

                ' SIMPAN ID USER BIAR TERPAKAI DI FORM LAIN
                LoggedUserID = dr("iduser").ToString()
                LoggedUserRole = dr("role").ToString()
                LoggedUserName = dr("namalengkap").ToString()

                MsgBox("Login berhasil! Selamat datang " & LoggedUserName)

                dr.Close()
                Me.Hide()
                Dashboard.Show()

            Else
                MsgBox("Username atau password salah!", vbExclamation)
            End If

        Catch ex As Exception
            MsgBox("Error login: " & ex.Message)
        End Try
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Application.Exit()
    End Sub
End Class