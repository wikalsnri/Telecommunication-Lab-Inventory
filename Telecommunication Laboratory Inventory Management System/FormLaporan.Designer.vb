<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporan
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
        Me.cmbtipeitem = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbjenislaporan = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvlaporan = New System.Windows.Forms.DataGridView()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btntampilkan = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtawal = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtakhir = New System.Windows.Forms.DateTimePicker()
        Me.lblnamauser = New System.Windows.Forms.Label()
        Me.lblroleuser = New System.Windows.Forms.Label()
        CType(Me.dgvlaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbtipeitem
        '
        Me.cmbtipeitem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipeitem.FormattingEnabled = True
        Me.cmbtipeitem.Location = New System.Drawing.Point(273, 186)
        Me.cmbtipeitem.Name = "cmbtipeitem"
        Me.cmbtipeitem.Size = New System.Drawing.Size(349, 31)
        Me.cmbtipeitem.TabIndex = 101
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(146, 193)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 23)
        Me.Label10.TabIndex = 100
        Me.Label10.Text = "Tipe Item"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(146, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 23)
        Me.Label9.TabIndex = 98
        Me.Label9.Text = "Tanggal"
        '
        'cmbjenislaporan
        '
        Me.cmbjenislaporan.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbjenislaporan.FormattingEnabled = True
        Me.cmbjenislaporan.Location = New System.Drawing.Point(273, 111)
        Me.cmbjenislaporan.Name = "cmbjenislaporan"
        Me.cmbjenislaporan.Size = New System.Drawing.Size(349, 31)
        Me.cmbjenislaporan.TabIndex = 97
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(211, 609)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(344, 19)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "2025 - Politeknik Negeri Padang | Teknik Telekomukasi."
        '
        'dgvlaporan
        '
        Me.dgvlaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlaporan.Location = New System.Drawing.Point(41, 375)
        Me.dgvlaporan.Name = "dgvlaporan"
        Me.dgvlaporan.RowTemplate.Height = 24
        Me.dgvlaporan.Size = New System.Drawing.Size(695, 228)
        Me.dgvlaporan.TabIndex = 91
        '
        'btnreset
        '
        Me.btnreset.BackColor = System.Drawing.Color.Gray
        Me.btnreset.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnreset.Location = New System.Drawing.Point(273, 223)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(87, 33)
        Me.btnreset.TabIndex = 90
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = False
        '
        'btntampilkan
        '
        Me.btntampilkan.BackColor = System.Drawing.Color.RoyalBlue
        Me.btntampilkan.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntampilkan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btntampilkan.Location = New System.Drawing.Point(535, 223)
        Me.btntampilkan.Name = "btntampilkan"
        Me.btntampilkan.Size = New System.Drawing.Size(87, 33)
        Me.btntampilkan.TabIndex = 87
        Me.btntampilkan.Text = "Tampilkan"
        Me.btntampilkan.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(146, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 23)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Jenis Laporan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(288, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 32)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "FORM LAPORAN"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DarkGray
        Me.Button6.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(684, 40)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(76, 28)
        Me.Button6.TabIndex = 75
        Me.Button6.Text = "Back"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PA___Aplikasi_Inventaris_Lab.Telkom.My.Resources.Resources.logo_elektro_pnp
        Me.PictureBox1.Location = New System.Drawing.Point(11, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 74
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(295, 323)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 32)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "DATA LAPORAN"
        '
        'dtawal
        '
        Me.dtawal.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtawal.Location = New System.Drawing.Point(273, 150)
        Me.dtawal.Name = "dtawal"
        Me.dtawal.Size = New System.Drawing.Size(147, 30)
        Me.dtawal.TabIndex = 103
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(426, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 23)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "s/d"
        '
        'dtakhir
        '
        Me.dtakhir.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtakhir.Location = New System.Drawing.Point(466, 150)
        Me.dtakhir.Name = "dtakhir"
        Me.dtakhir.Size = New System.Drawing.Size(156, 30)
        Me.dtakhir.TabIndex = 105
        '
        'lblnamauser
        '
        Me.lblnamauser.AutoSize = True
        Me.lblnamauser.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnamauser.Location = New System.Drawing.Point(680, -1)
        Me.lblnamauser.Name = "lblnamauser"
        Me.lblnamauser.Size = New System.Drawing.Size(85, 19)
        Me.lblnamauser.TabIndex = 107
        Me.lblnamauser.Text = "[Nama User]"
        '
        'lblroleuser
        '
        Me.lblroleuser.AutoSize = True
        Me.lblroleuser.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblroleuser.Location = New System.Drawing.Point(680, 18)
        Me.lblroleuser.Name = "lblroleuser"
        Me.lblroleuser.Size = New System.Drawing.Size(80, 19)
        Me.lblroleuser.TabIndex = 106
        Me.lblroleuser.Text = "[Level User]"
        '
        'FormLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(772, 627)
        Me.Controls.Add(Me.lblnamauser)
        Me.Controls.Add(Me.lblroleuser)
        Me.Controls.Add(Me.dtakhir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtawal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbtipeitem)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbjenislaporan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgvlaporan)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btntampilkan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormLaporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLaporan"
        CType(Me.dgvlaporan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbtipeitem As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbjenislaporan As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dgvlaporan As System.Windows.Forms.DataGridView
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btntampilkan As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtawal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtakhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblnamauser As System.Windows.Forms.Label
    Friend WithEvents lblroleuser As System.Windows.Forms.Label
End Class
