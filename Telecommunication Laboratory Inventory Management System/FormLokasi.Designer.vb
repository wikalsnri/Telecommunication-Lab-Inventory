<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLokasi
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.btncari = New System.Windows.Forms.Button()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvlokasi = New System.Windows.Forms.DataGridView()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.txtrak = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtruangan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblnamauser = New System.Windows.Forms.Label()
        Me.lblroleuser = New System.Windows.Forms.Label()
        CType(Me.dgvlokasi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(211, 602)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(344, 19)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "2025 - Politeknik Negeri Padang | Teknik Telekomukasi."
        '
        'btnrefresh
        '
        Me.btnrefresh.BackColor = System.Drawing.Color.ForestGreen
        Me.btnrefresh.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnrefresh.Location = New System.Drawing.Point(42, 346)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(87, 33)
        Me.btnrefresh.TabIndex = 93
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.UseVisualStyleBackColor = False
        '
        'btncari
        '
        Me.btncari.BackColor = System.Drawing.Color.DarkCyan
        Me.btncari.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncari.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btncari.Location = New System.Drawing.Point(650, 346)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(87, 33)
        Me.btncari.TabIndex = 92
        Me.btncari.Text = "Search"
        Me.btncari.UseVisualStyleBackColor = False
        '
        'txtcari
        '
        Me.txtcari.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcari.Location = New System.Drawing.Point(384, 349)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(260, 30)
        Me.txtcari.TabIndex = 91
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(321, 352)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 23)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "Cari :"
        '
        'dgvlokasi
        '
        Me.dgvlokasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlokasi.Location = New System.Drawing.Point(42, 385)
        Me.dgvlokasi.Name = "dgvlokasi"
        Me.dgvlokasi.RowTemplate.Height = 24
        Me.dgvlokasi.Size = New System.Drawing.Size(695, 195)
        Me.dgvlokasi.TabIndex = 89
        '
        'btnbatal
        '
        Me.btnbatal.BackColor = System.Drawing.Color.Gray
        Me.btnbatal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbatal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnbatal.Location = New System.Drawing.Point(485, 276)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(87, 33)
        Me.btnbatal.TabIndex = 88
        Me.btnbatal.Text = "Clear"
        Me.btnbatal.UseVisualStyleBackColor = False
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.Color.Firebrick
        Me.btnhapus.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnhapus.Location = New System.Drawing.Point(392, 276)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(87, 33)
        Me.btnhapus.TabIndex = 87
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.Goldenrod
        Me.btnedit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnedit.Location = New System.Drawing.Point(299, 276)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(87, 33)
        Me.btnedit.TabIndex = 86
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btntambah
        '
        Me.btntambah.BackColor = System.Drawing.Color.RoyalBlue
        Me.btntambah.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambah.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btntambah.Location = New System.Drawing.Point(206, 276)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(87, 33)
        Me.btntambah.TabIndex = 85
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'txtrak
        '
        Me.txtrak.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrak.Location = New System.Drawing.Point(335, 177)
        Me.txtrak.Name = "txtrak"
        Me.txtrak.Size = New System.Drawing.Size(260, 30)
        Me.txtrak.TabIndex = 82
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(178, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 23)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Rak"
        '
        'txtruangan
        '
        Me.txtruangan.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtruangan.Location = New System.Drawing.Point(335, 141)
        Me.txtruangan.Name = "txtruangan"
        Me.txtruangan.Size = New System.Drawing.Size(260, 30)
        Me.txtruangan.TabIndex = 80
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(178, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 23)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Ruangan"
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(335, 105)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(260, 30)
        Me.txtid.TabIndex = 78
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(178, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 23)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "ID Lokasi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(312, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 32)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "DATA LOKASI"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DarkGray
        Me.Button6.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(684, 41)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(76, 28)
        Me.Button6.TabIndex = 74
        Me.Button6.Text = "Back"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PA___Aplikasi_Inventaris_Lab.Telkom.My.Resources.Resources.logo_elektro_pnp
        Me.PictureBox1.Location = New System.Drawing.Point(11, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 73
        Me.PictureBox1.TabStop = False
        '
        'lblnamauser
        '
        Me.lblnamauser.AutoSize = True
        Me.lblnamauser.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnamauser.Location = New System.Drawing.Point(680, 0)
        Me.lblnamauser.Name = "lblnamauser"
        Me.lblnamauser.Size = New System.Drawing.Size(85, 19)
        Me.lblnamauser.TabIndex = 152
        Me.lblnamauser.Text = "[Nama User]"
        '
        'lblroleuser
        '
        Me.lblroleuser.AutoSize = True
        Me.lblroleuser.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblroleuser.Location = New System.Drawing.Point(680, 19)
        Me.lblroleuser.Name = "lblroleuser"
        Me.lblroleuser.Size = New System.Drawing.Size(80, 19)
        Me.lblroleuser.TabIndex = 151
        Me.lblroleuser.Text = "[Level User]"
        '
        'FormLokasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(772, 626)
        Me.Controls.Add(Me.lblnamauser)
        Me.Controls.Add(Me.lblroleuser)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.btncari)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvlokasi)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.txtrak)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtruangan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormLokasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLokasi"
        CType(Me.dgvlokasi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgvlokasi As System.Windows.Forms.DataGridView
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents txtrak As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtruangan As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblnamauser As System.Windows.Forms.Label
    Friend WithEvents lblroleuser As System.Windows.Forms.Label
End Class
