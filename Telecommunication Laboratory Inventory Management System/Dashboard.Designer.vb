<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnkomponen = New System.Windows.Forms.Button()
        Me.btnlokasi = New System.Windows.Forms.Button()
        Me.btnuser = New System.Windows.Forms.Button()
        Me.btnkategori = New System.Windows.Forms.Button()
        Me.btntransaksi = New System.Windows.Forms.Button()
        Me.btnalat = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblnamauser = New System.Windows.Forms.Label()
        Me.lblroleuser = New System.Windows.Forms.Label()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.btnlaporan = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnkomponen
        '
        Me.btnkomponen.BackColor = System.Drawing.Color.SteelBlue
        Me.btnkomponen.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkomponen.ForeColor = System.Drawing.Color.White
        Me.btnkomponen.Location = New System.Drawing.Point(137, 286)
        Me.btnkomponen.Name = "btnkomponen"
        Me.btnkomponen.Size = New System.Drawing.Size(181, 47)
        Me.btnkomponen.TabIndex = 31
        Me.btnkomponen.Text = "Data Komponen"
        Me.btnkomponen.UseVisualStyleBackColor = False
        '
        'btnlokasi
        '
        Me.btnlokasi.BackColor = System.Drawing.Color.SteelBlue
        Me.btnlokasi.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlokasi.ForeColor = System.Drawing.Color.White
        Me.btnlokasi.Location = New System.Drawing.Point(462, 286)
        Me.btnlokasi.Name = "btnlokasi"
        Me.btnlokasi.Size = New System.Drawing.Size(181, 47)
        Me.btnlokasi.TabIndex = 28
        Me.btnlokasi.Text = "Data Lokasi"
        Me.btnlokasi.UseVisualStyleBackColor = False
        '
        'btnuser
        '
        Me.btnuser.BackColor = System.Drawing.Color.SteelBlue
        Me.btnuser.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnuser.ForeColor = System.Drawing.Color.White
        Me.btnuser.Location = New System.Drawing.Point(137, 351)
        Me.btnuser.Name = "btnuser"
        Me.btnuser.Size = New System.Drawing.Size(181, 47)
        Me.btnuser.TabIndex = 27
        Me.btnuser.Text = "Data Pengguna"
        Me.btnuser.UseVisualStyleBackColor = False
        '
        'btnkategori
        '
        Me.btnkategori.BackColor = System.Drawing.Color.SteelBlue
        Me.btnkategori.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkategori.ForeColor = System.Drawing.Color.White
        Me.btnkategori.Location = New System.Drawing.Point(462, 351)
        Me.btnkategori.Name = "btnkategori"
        Me.btnkategori.Size = New System.Drawing.Size(181, 47)
        Me.btnkategori.TabIndex = 26
        Me.btnkategori.Text = "Data Kategori"
        Me.btnkategori.UseVisualStyleBackColor = False
        '
        'btntransaksi
        '
        Me.btntransaksi.BackColor = System.Drawing.Color.SteelBlue
        Me.btntransaksi.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntransaksi.ForeColor = System.Drawing.Color.White
        Me.btntransaksi.Location = New System.Drawing.Point(462, 221)
        Me.btntransaksi.Name = "btntransaksi"
        Me.btntransaksi.Size = New System.Drawing.Size(181, 47)
        Me.btntransaksi.TabIndex = 25
        Me.btntransaksi.Text = "Data Transaksi"
        Me.btntransaksi.UseVisualStyleBackColor = False
        '
        'btnalat
        '
        Me.btnalat.BackColor = System.Drawing.Color.SteelBlue
        Me.btnalat.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnalat.ForeColor = System.Drawing.Color.White
        Me.btnalat.Location = New System.Drawing.Point(137, 221)
        Me.btnalat.Name = "btnalat"
        Me.btnalat.Size = New System.Drawing.Size(181, 47)
        Me.btnalat.TabIndex = 24
        Me.btnalat.Text = "Data Alat"
        Me.btnalat.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(214, 583)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(344, 19)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "2025 - Politeknik Negeri Padang | Teknik Telekomukasi."
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(131, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(512, 32)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "SISTEM INVENTARIS LAB TELEKOMUNIKASI"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PA___Aplikasi_Inventaris_Lab.Telkom.My.Resources.Resources.logo_elektro_pnp
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'lblnamauser
        '
        Me.lblnamauser.AutoSize = True
        Me.lblnamauser.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnamauser.Location = New System.Drawing.Point(678, 9)
        Me.lblnamauser.Name = "lblnamauser"
        Me.lblnamauser.Size = New System.Drawing.Size(85, 19)
        Me.lblnamauser.TabIndex = 34
        Me.lblnamauser.Text = "[Nama User]"
        '
        'lblroleuser
        '
        Me.lblroleuser.AutoSize = True
        Me.lblroleuser.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblroleuser.Location = New System.Drawing.Point(678, 28)
        Me.lblroleuser.Name = "lblroleuser"
        Me.lblroleuser.Size = New System.Drawing.Size(80, 19)
        Me.lblroleuser.TabIndex = 33
        Me.lblroleuser.Text = "[Level User]"
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.Color.DarkGray
        Me.btnlogout.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.ForeColor = System.Drawing.Color.Black
        Me.btnlogout.Location = New System.Drawing.Point(682, 50)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(76, 28)
        Me.btnlogout.TabIndex = 32
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'btnlaporan
        '
        Me.btnlaporan.BackColor = System.Drawing.Color.SteelBlue
        Me.btnlaporan.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlaporan.ForeColor = System.Drawing.Color.White
        Me.btnlaporan.Location = New System.Drawing.Point(300, 429)
        Me.btnlaporan.Name = "btnlaporan"
        Me.btnlaporan.Size = New System.Drawing.Size(181, 47)
        Me.btnlaporan.TabIndex = 35
        Me.btnlaporan.Text = "Laporan"
        Me.btnlaporan.UseVisualStyleBackColor = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(770, 629)
        Me.Controls.Add(Me.btnlaporan)
        Me.Controls.Add(Me.lblnamauser)
        Me.Controls.Add(Me.lblroleuser)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.btnkomponen)
        Me.Controls.Add(Me.btnlokasi)
        Me.Controls.Add(Me.btnuser)
        Me.Controls.Add(Me.btnkategori)
        Me.Controls.Add(Me.btntransaksi)
        Me.Controls.Add(Me.btnalat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnkomponen As System.Windows.Forms.Button
    Friend WithEvents btnlokasi As System.Windows.Forms.Button
    Friend WithEvents btnuser As System.Windows.Forms.Button
    Friend WithEvents btnkategori As System.Windows.Forms.Button
    Friend WithEvents btntransaksi As System.Windows.Forms.Button
    Friend WithEvents btnalat As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblnamauser As System.Windows.Forms.Label
    Friend WithEvents lblroleuser As System.Windows.Forms.Label
    Friend WithEvents btnlogout As System.Windows.Forms.Button
    Friend WithEvents btnlaporan As System.Windows.Forms.Button
End Class
