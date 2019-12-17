<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ckMinuman = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMinuman = New System.Windows.Forms.TextBox()
        Me.txtMakanan = New System.Windows.Forms.TextBox()
        Me.lblPorsiMinuman = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.pnlMinuman = New System.Windows.Forms.Panel()
        Me.cmbMinuman = New System.Windows.Forms.ComboBox()
        Me.lblMinuman = New System.Windows.Forms.Label()
        Me.lblHargaMinuman = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblHargaMakanan = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbMakanan = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.pnlMinuman.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ckMinuman
        '
        Me.ckMinuman.AutoSize = True
        Me.ckMinuman.Location = New System.Drawing.Point(19, 152)
        Me.ckMinuman.Name = "ckMinuman"
        Me.ckMinuman.Size = New System.Drawing.Size(128, 17)
        Me.ckMinuman.TabIndex = 2
        Me.ckMinuman.Text = "Termasuk Minuman ?"
        Me.ckMinuman.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMinuman)
        Me.GroupBox1.Controls.Add(Me.txtMakanan)
        Me.GroupBox1.Controls.Add(Me.lblPorsiMinuman)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 256)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(305, 100)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Porsi"
        '
        'txtMinuman
        '
        Me.txtMinuman.Location = New System.Drawing.Point(140, 59)
        Me.txtMinuman.Name = "txtMinuman"
        Me.txtMinuman.Size = New System.Drawing.Size(100, 20)
        Me.txtMinuman.TabIndex = 3
        '
        'txtMakanan
        '
        Me.txtMakanan.Location = New System.Drawing.Point(140, 33)
        Me.txtMakanan.Name = "txtMakanan"
        Me.txtMakanan.Size = New System.Drawing.Size(100, 20)
        Me.txtMakanan.TabIndex = 2
        '
        'lblPorsiMinuman
        '
        Me.lblPorsiMinuman.AutoSize = True
        Me.lblPorsiMinuman.Location = New System.Drawing.Point(20, 59)
        Me.lblPorsiMinuman.Name = "lblPorsiMinuman"
        Me.lblPorsiMinuman.Size = New System.Drawing.Size(85, 13)
        Me.lblPorsiMinuman.TabIndex = 1
        Me.lblPorsiMinuman.Text = "Porsi Minuman ?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Porsi Makanan ?"
        '
        'btnHitung
        '
        Me.btnHitung.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnHitung.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHitung.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHitung.ForeColor = System.Drawing.Color.White
        Me.btnHitung.Location = New System.Drawing.Point(12, 422)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(305, 45)
        Me.btnHitung.TabIndex = 7
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = False
        '
        'pnlMinuman
        '
        Me.pnlMinuman.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlMinuman.Controls.Add(Me.cmbMinuman)
        Me.pnlMinuman.Controls.Add(Me.lblMinuman)
        Me.pnlMinuman.Controls.Add(Me.lblHargaMinuman)
        Me.pnlMinuman.Location = New System.Drawing.Point(19, 189)
        Me.pnlMinuman.Name = "pnlMinuman"
        Me.pnlMinuman.Size = New System.Drawing.Size(290, 43)
        Me.pnlMinuman.TabIndex = 12
        '
        'cmbMinuman
        '
        Me.cmbMinuman.FormattingEnabled = True
        Me.cmbMinuman.Items.AddRange(New Object() {"Es Jeruk", "Jus Alpukat", "Teh Manis"})
        Me.cmbMinuman.Location = New System.Drawing.Point(11, 9)
        Me.cmbMinuman.Name = "cmbMinuman"
        Me.cmbMinuman.Size = New System.Drawing.Size(121, 21)
        Me.cmbMinuman.TabIndex = 1
        '
        'lblMinuman
        '
        Me.lblMinuman.AutoSize = True
        Me.lblMinuman.Location = New System.Drawing.Point(158, 12)
        Me.lblMinuman.Name = "lblMinuman"
        Me.lblMinuman.Size = New System.Drawing.Size(36, 13)
        Me.lblMinuman.TabIndex = 8
        Me.lblMinuman.Text = "Harga"
        '
        'lblHargaMinuman
        '
        Me.lblHargaMinuman.AutoSize = True
        Me.lblHargaMinuman.Location = New System.Drawing.Point(211, 12)
        Me.lblHargaMinuman.Name = "lblHargaMinuman"
        Me.lblHargaMinuman.Size = New System.Drawing.Size(22, 13)
        Me.lblHargaMinuman.TabIndex = 5
        Me.lblHargaMinuman.Text = "....."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.lblHargaMakanan)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmbMakanan)
        Me.Panel1.Location = New System.Drawing.Point(19, 87)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(290, 44)
        Me.Panel1.TabIndex = 11
        '
        'lblHargaMakanan
        '
        Me.lblHargaMakanan.AutoSize = True
        Me.lblHargaMakanan.Location = New System.Drawing.Point(211, 16)
        Me.lblHargaMakanan.Name = "lblHargaMakanan"
        Me.lblHargaMakanan.Size = New System.Drawing.Size(22, 13)
        Me.lblHargaMakanan.TabIndex = 7
        Me.lblHargaMakanan.Text = "....."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(158, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Harga"
        '
        'cmbMakanan
        '
        Me.cmbMakanan.FormattingEnabled = True
        Me.cmbMakanan.Items.AddRange(New Object() {"Nasi Uduk", "Bakso", "Mie Ayam"})
        Me.cmbMakanan.Location = New System.Drawing.Point(11, 13)
        Me.cmbMakanan.Name = "cmbMakanan"
        Me.cmbMakanan.Size = New System.Drawing.Size(121, 21)
        Me.cmbMakanan.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lblTotal)
        Me.Panel2.Location = New System.Drawing.Point(19, 370)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(290, 39)
        Me.Panel2.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 24)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Total"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(129, 10)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 20)
        Me.lblTotal.TabIndex = 11
        Me.lblTotal.Text = "....."
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(63, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(267, 66)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Program Kasir Sederhana"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Elearning2.My.Resources.Resources.kasir1
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 66)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(328, 478)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlMinuman)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ckMinuman)
        Me.Name = "Form1"
        Me.Text = "Form Transaksi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlMinuman.ResumeLayout(False)
        Me.pnlMinuman.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ckMinuman As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMinuman As System.Windows.Forms.TextBox
    Friend WithEvents txtMakanan As System.Windows.Forms.TextBox
    Friend WithEvents lblPorsiMinuman As System.Windows.Forms.Label
    Friend WithEvents btnHitung As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents pnlMinuman As System.Windows.Forms.Panel
    Friend WithEvents cmbMinuman As System.Windows.Forms.ComboBox
    Friend WithEvents lblMinuman As System.Windows.Forms.Label
    Friend WithEvents lblHargaMinuman As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblHargaMakanan As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbMakanan As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
