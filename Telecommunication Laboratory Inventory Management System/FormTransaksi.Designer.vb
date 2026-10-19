<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksi
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbtipeitem = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtpeminjam = New System.Windows.Forms.TextBox()
        Me.txtidpinjam = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbitem = New System.Windows.Forms.ComboBox()
        Me.dtpinjam = New System.Windows.Forms.DateTimePicker()
        Me.btnpinjam = New System.Windows.Forms.Button()
        Me.txtidkembali = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtkembali = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbkondisikembali = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnkembalikan = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvtransaksi = New System.Windows.Forms.DataGridView()
        Me.txtiduser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblnamauser = New System.Windows.Forms.Label()
        Me.lblroleuser = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvtransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 198)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 23)
        Me.Label9.TabIndex = 126
        Me.Label9.Text = "Peminjam"
        '
        'cmbtipeitem
        '
        Me.cmbtipeitem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipeitem.FormattingEnabled = True
        Me.cmbtipeitem.Location = New System.Drawing.Point(144, 87)
        Me.cmbtipeitem.Name = "cmbtipeitem"
        Me.cmbtipeitem.Size = New System.Drawing.Size(217, 31)
        Me.cmbtipeitem.TabIndex = 125
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(218, 666)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(344, 19)
        Me.Label8.TabIndex = 124
        Me.Label8.Text = "2025 - Politeknik Negeri Padang | Teknik Telekomukasi."
        '
        'txtjumlah
        '
        Me.txtjumlah.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjumlah.Location = New System.Drawing.Point(144, 160)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(217, 30)
        Me.txtjumlah.TabIndex = 114
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 23)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "Tgl Pinjam"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 23)
        Me.Label5.TabIndex = 112
        Me.Label5.Text = "Jumlah"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 23)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "Item"
        '
        'txtpeminjam
        '
        Me.txtpeminjam.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpeminjam.Location = New System.Drawing.Point(144, 196)
        Me.txtpeminjam.Name = "txtpeminjam"
        Me.txtpeminjam.Size = New System.Drawing.Size(217, 30)
        Me.txtpeminjam.TabIndex = 109
        '
        'txtidpinjam
        '
        Me.txtidpinjam.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidpinjam.Location = New System.Drawing.Point(144, 52)
        Me.txtidpinjam.Name = "txtidpinjam"
        Me.txtidpinjam.Size = New System.Drawing.Size(217, 30)
        Me.txtidpinjam.TabIndex = 108
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 23)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Tipe Item"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 23)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "ID Peminjaman"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DarkGray
        Me.Button6.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(689, 42)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(76, 28)
        Me.Button6.TabIndex = 103
        Me.Button6.Text = "Back"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PA___Aplikasi_Inventaris_Lab.Telkom.My.Resources.Resources.logo_elektro_pnp
        Me.PictureBox1.Location = New System.Drawing.Point(10, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 102
        Me.PictureBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(174, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(504, 32)
        Me.Label11.TabIndex = 130
        Me.Label11.Text = "DATA PEMINJAMAN DAN PENGEMBALIAN"
        '
        'cmbitem
        '
        Me.cmbitem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbitem.FormattingEnabled = True
        Me.cmbitem.Location = New System.Drawing.Point(144, 123)
        Me.cmbitem.Name = "cmbitem"
        Me.cmbitem.Size = New System.Drawing.Size(217, 31)
        Me.cmbitem.TabIndex = 131
        '
        'dtpinjam
        '
        Me.dtpinjam.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpinjam.Location = New System.Drawing.Point(144, 232)
        Me.dtpinjam.Name = "dtpinjam"
        Me.dtpinjam.Size = New System.Drawing.Size(217, 30)
        Me.dtpinjam.TabIndex = 132
        '
        'btnpinjam
        '
        Me.btnpinjam.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnpinjam.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpinjam.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnpinjam.Location = New System.Drawing.Point(274, 268)
        Me.btnpinjam.Name = "btnpinjam"
        Me.btnpinjam.Size = New System.Drawing.Size(87, 33)
        Me.btnpinjam.TabIndex = 133
        Me.btnpinjam.Text = "Pinjam"
        Me.btnpinjam.UseVisualStyleBackColor = False
        '
        'txtidkembali
        '
        Me.txtidkembali.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidkembali.Location = New System.Drawing.Point(147, 47)
        Me.txtidkembali.Name = "txtidkembali"
        Me.txtidkembali.Size = New System.Drawing.Size(194, 30)
        Me.txtidkembali.TabIndex = 136
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 23)
        Me.Label10.TabIndex = 135
        Me.Label10.Text = "ID Pengembalian"
        '
        'dtkembali
        '
        Me.dtkembali.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtkembali.Location = New System.Drawing.Point(147, 83)
        Me.dtkembali.Name = "dtkembali"
        Me.dtkembali.Size = New System.Drawing.Size(194, 30)
        Me.dtkembali.TabIndex = 138
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(9, 90)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 23)
        Me.Label13.TabIndex = 137
        Me.Label13.Text = "Tgl Kembali"
        '
        'cmbkondisikembali
        '
        Me.cmbkondisikembali.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbkondisikembali.FormattingEnabled = True
        Me.cmbkondisikembali.Location = New System.Drawing.Point(147, 119)
        Me.cmbkondisikembali.Name = "cmbkondisikembali"
        Me.cmbkondisikembali.Size = New System.Drawing.Size(194, 31)
        Me.cmbkondisikembali.TabIndex = 140
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 127)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 23)
        Me.Label14.TabIndex = 139
        Me.Label14.Text = "Kondisi"
        '
        'btnkembalikan
        '
        Me.btnkembalikan.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnkembalikan.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkembalikan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnkembalikan.Location = New System.Drawing.Point(225, 156)
        Me.btnkembalikan.Name = "btnkembalikan"
        Me.btnkembalikan.Size = New System.Drawing.Size(116, 33)
        Me.btnkembalikan.TabIndex = 141
        Me.btnkembalikan.Text = "Kembalikan"
        Me.btnkembalikan.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnpinjam)
        Me.GroupBox1.Controls.Add(Me.dtpinjam)
        Me.GroupBox1.Controls.Add(Me.cmbitem)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cmbtipeitem)
        Me.GroupBox1.Controls.Add(Me.txtjumlah)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtpeminjam)
        Me.GroupBox1.Controls.Add(Me.txtidpinjam)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 126)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(396, 309)
        Me.GroupBox1.TabIndex = 142
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PEMINJAMAN"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnkembalikan)
        Me.GroupBox2.Controls.Add(Me.cmbkondisikembali)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.dtkembali)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtidkembali)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(418, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(347, 200)
        Me.GroupBox2.TabIndex = 143
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PENGEMBALIAN"
        '
        'btnrefresh
        '
        Me.btnrefresh.BackColor = System.Drawing.Color.ForestGreen
        Me.btnrefresh.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnrefresh.Location = New System.Drawing.Point(51, 450)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(87, 33)
        Me.btnrefresh.TabIndex = 148
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.UseVisualStyleBackColor = False
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.DarkCyan
        Me.btnsearch.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsearch.Location = New System.Drawing.Point(659, 450)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(87, 33)
        Me.btnsearch.TabIndex = 147
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'txtcari
        '
        Me.txtcari.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcari.Location = New System.Drawing.Point(393, 453)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(260, 30)
        Me.txtcari.TabIndex = 146
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(330, 456)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 23)
        Me.Label7.TabIndex = 145
        Me.Label7.Text = "Cari :"
        '
        'dgvtransaksi
        '
        Me.dgvtransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtransaksi.Location = New System.Drawing.Point(51, 489)
        Me.dgvtransaksi.Name = "dgvtransaksi"
        Me.dgvtransaksi.RowTemplate.Height = 24
        Me.dgvtransaksi.Size = New System.Drawing.Size(695, 160)
        Me.dgvtransaksi.TabIndex = 144
        '
        'txtiduser
        '
        Me.txtiduser.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtiduser.Location = New System.Drawing.Point(345, 79)
        Me.txtiduser.Name = "txtiduser"
        Me.txtiduser.Size = New System.Drawing.Size(217, 30)
        Me.txtiduser.TabIndex = 135
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(259, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 23)
        Me.Label2.TabIndex = 134
        Me.Label2.Text = "ID User"
        '
        'lblnamauser
        '
        Me.lblnamauser.AutoSize = True
        Me.lblnamauser.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnamauser.Location = New System.Drawing.Point(685, 1)
        Me.lblnamauser.Name = "lblnamauser"
        Me.lblnamauser.Size = New System.Drawing.Size(85, 19)
        Me.lblnamauser.TabIndex = 150
        Me.lblnamauser.Text = "[Nama User]"
        '
        'lblroleuser
        '
        Me.lblroleuser.AutoSize = True
        Me.lblroleuser.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblroleuser.Location = New System.Drawing.Point(685, 20)
        Me.lblroleuser.Name = "lblroleuser"
        Me.lblroleuser.Size = New System.Drawing.Size(80, 19)
        Me.lblroleuser.TabIndex = 149
        Me.lblroleuser.Text = "[Level User]"
        '
        'FormTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(777, 700)
        Me.Controls.Add(Me.lblnamauser)
        Me.Controls.Add(Me.lblroleuser)
        Me.Controls.Add(Me.txtiduser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvtransaksi)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormTransaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormTransaksi"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvtransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbtipeitem As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtjumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtpeminjam As System.Windows.Forms.TextBox
    Friend WithEvents txtidpinjam As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbitem As System.Windows.Forms.ComboBox
    Friend WithEvents dtpinjam As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnpinjam As System.Windows.Forms.Button
    Friend WithEvents txtidkembali As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtkembali As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbkondisikembali As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnkembalikan As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgvtransaksi As System.Windows.Forms.DataGridView
    Friend WithEvents txtiduser As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblnamauser As System.Windows.Forms.Label
    Friend WithEvents lblroleuser As System.Windows.Forms.Label
End Class
