<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucPUTINTOINVENTORY
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucPUTINTOINVENTORY))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BTNDELETE = New System.Windows.Forms.Button()
        Me.DGVMAIN = New System.Windows.Forms.DataGridView()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTNSAVE = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXTSI = New System.Windows.Forms.TextBox()
        Me.TXTPNA = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTPI = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBOUNIT = New System.Windows.Forms.ComboBox()
        Me.TXTUNIT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTPED = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NUDQUANTITY = New System.Windows.Forms.NumericUpDown()
        Me.TXTPRICE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DTPAS = New System.Windows.Forms.DateTimePicker()
        Me.TXTDA = New System.Windows.Forms.TextBox()
        Me.txtmix = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGVPRODUCTS = New System.Windows.Forms.DataGridView()
        Me.TXTSEARCH = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BTNBACK = New System.Windows.Forms.Button()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DGVMAIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NUDQUANTITY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGVPRODUCTS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox4.Controls.Add(Me.BTNDELETE)
        Me.GroupBox4.Controls.Add(Me.DGVMAIN)
        Me.GroupBox4.Controls.Add(Me.TextBox4)
        Me.GroupBox4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox4.Location = New System.Drawing.Point(30, 488)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1240, 271)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Stock List"
        '
        'BTNDELETE
        '
        Me.BTNDELETE.BackColor = System.Drawing.Color.IndianRed
        Me.BTNDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNDELETE.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNDELETE.ForeColor = System.Drawing.Color.White
        Me.BTNDELETE.Location = New System.Drawing.Point(1097, 35)
        Me.BTNDELETE.Name = "BTNDELETE"
        Me.BTNDELETE.Size = New System.Drawing.Size(124, 34)
        Me.BTNDELETE.TabIndex = 47
        Me.BTNDELETE.Text = "Delete"
        Me.BTNDELETE.UseVisualStyleBackColor = False
        '
        'DGVMAIN
        '
        Me.DGVMAIN.BackgroundColor = System.Drawing.Color.White
        Me.DGVMAIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMAIN.Location = New System.Drawing.Point(41, 88)
        Me.DGVMAIN.Name = "DGVMAIN"
        Me.DGVMAIN.ReadOnly = True
        Me.DGVMAIN.RowHeadersVisible = False
        Me.DGVMAIN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVMAIN.Size = New System.Drawing.Size(1191, 174)
        Me.DGVMAIN.TabIndex = 33
        '
        'TextBox4
        '
        Me.TextBox4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TextBox4.Location = New System.Drawing.Point(41, 40)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(546, 23)
        Me.TextBox4.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.BTNSAVE)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TXTSI)
        Me.GroupBox1.Controls.Add(Me.TXTPNA)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TXTPI)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.CBOUNIT)
        Me.GroupBox1.Controls.Add(Me.TXTUNIT)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DTPED)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.NUDQUANTITY)
        Me.GroupBox1.Controls.Add(Me.TXTPRICE)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(341, 383)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'BTNSAVE
        '
        Me.BTNSAVE.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BTNSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSAVE.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSAVE.ForeColor = System.Drawing.Color.White
        Me.BTNSAVE.Location = New System.Drawing.Point(160, 326)
        Me.BTNSAVE.Name = "BTNSAVE"
        Me.BTNSAVE.Size = New System.Drawing.Size(127, 37)
        Me.BTNSAVE.TabIndex = 48
        Me.BTNSAVE.Text = "Save"
        Me.BTNSAVE.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(13, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 20)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Stock ID : "
        '
        'TXTSI
        '
        Me.TXTSI.Enabled = False
        Me.TXTSI.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TXTSI.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTSI.Location = New System.Drawing.Point(146, 21)
        Me.TXTSI.Name = "TXTSI"
        Me.TXTSI.Size = New System.Drawing.Size(152, 23)
        Me.TXTSI.TabIndex = 19
        '
        'TXTPNA
        '
        Me.TXTPNA.Enabled = False
        Me.TXTPNA.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TXTPNA.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTPNA.Location = New System.Drawing.Point(146, 100)
        Me.TXTPNA.Name = "TXTPNA"
        Me.TXTPNA.Size = New System.Drawing.Size(153, 23)
        Me.TXTPNA.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(13, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Product Name : "
        '
        'TXTPI
        '
        Me.TXTPI.Enabled = False
        Me.TXTPI.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPI.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTPI.Location = New System.Drawing.Point(146, 60)
        Me.TXTPI.Name = "TXTPI"
        Me.TXTPI.Size = New System.Drawing.Size(153, 23)
        Me.TXTPI.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(13, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Product ID : "
        '
        'CBOUNIT
        '
        Me.CBOUNIT.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.CBOUNIT.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CBOUNIT.FormattingEnabled = True
        Me.CBOUNIT.Items.AddRange(New Object() {"gram/s", "miligram/s", "liter/s", "mililiter/s", "Pack/s", "Sachet/s", "Bottle/s", "Piece/s", "Boxe/s"})
        Me.CBOUNIT.Location = New System.Drawing.Point(205, 142)
        Me.CBOUNIT.Name = "CBOUNIT"
        Me.CBOUNIT.Size = New System.Drawing.Size(94, 25)
        Me.CBOUNIT.TabIndex = 11
        '
        'TXTUNIT
        '
        Me.TXTUNIT.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTUNIT.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTUNIT.Location = New System.Drawing.Point(146, 144)
        Me.TXTUNIT.Name = "TXTUNIT"
        Me.TXTUNIT.Size = New System.Drawing.Size(53, 23)
        Me.TXTUNIT.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(13, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Per Unit :"
        '
        'DTPED
        '
        Me.DTPED.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.DTPED.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPED.Location = New System.Drawing.Point(148, 275)
        Me.DTPED.Name = "DTPED"
        Me.DTPED.Size = New System.Drawing.Size(152, 23)
        Me.DTPED.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(13, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Expiration Date :"
        '
        'NUDQUANTITY
        '
        Me.NUDQUANTITY.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NUDQUANTITY.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.NUDQUANTITY.Location = New System.Drawing.Point(147, 232)
        Me.NUDQUANTITY.Name = "NUDQUANTITY"
        Me.NUDQUANTITY.Size = New System.Drawing.Size(153, 23)
        Me.NUDQUANTITY.TabIndex = 6
        '
        'TXTPRICE
        '
        Me.TXTPRICE.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TXTPRICE.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTPRICE.Location = New System.Drawing.Point(146, 186)
        Me.TXTPRICE.Name = "TXTPRICE"
        Me.TXTPRICE.Size = New System.Drawing.Size(153, 23)
        Me.TXTPRICE.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(13, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Price : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(13, 235)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Stocks : "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1150, 783)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(22, 20)
        Me.TextBox1.TabIndex = 24
        Me.TextBox1.Visible = False
        '
        'DTPAS
        '
        Me.DTPAS.Enabled = False
        Me.DTPAS.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.DTPAS.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPAS.Location = New System.Drawing.Point(1121, 781)
        Me.DTPAS.Name = "DTPAS"
        Me.DTPAS.Size = New System.Drawing.Size(23, 23)
        Me.DTPAS.TabIndex = 23
        Me.DTPAS.Visible = False
        '
        'TXTDA
        '
        Me.TXTDA.Location = New System.Drawing.Point(1178, 780)
        Me.TXTDA.Name = "TXTDA"
        Me.TXTDA.Size = New System.Drawing.Size(27, 20)
        Me.TXTDA.TabIndex = 20
        Me.TXTDA.Visible = False
        '
        'txtmix
        '
        Me.txtmix.Location = New System.Drawing.Point(1216, 781)
        Me.txtmix.Name = "txtmix"
        Me.txtmix.Size = New System.Drawing.Size(19, 20)
        Me.txtmix.TabIndex = 14
        Me.txtmix.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.DGVPRODUCTS)
        Me.GroupBox2.Controls.Add(Me.TXTSEARCH)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox2.Location = New System.Drawing.Point(391, 77)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(879, 383)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "New Product List"
        '
        'DGVPRODUCTS
        '
        Me.DGVPRODUCTS.BackgroundColor = System.Drawing.Color.White
        Me.DGVPRODUCTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPRODUCTS.Location = New System.Drawing.Point(19, 77)
        Me.DGVPRODUCTS.Name = "DGVPRODUCTS"
        Me.DGVPRODUCTS.ReadOnly = True
        Me.DGVPRODUCTS.RowHeadersVisible = False
        Me.DGVPRODUCTS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVPRODUCTS.Size = New System.Drawing.Size(836, 275)
        Me.DGVPRODUCTS.TabIndex = 32
        '
        'TXTSEARCH
        '
        Me.TXTSEARCH.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTSEARCH.Location = New System.Drawing.Point(19, 29)
        Me.TXTSEARCH.Name = "TXTSEARCH"
        Me.TXTSEARCH.Size = New System.Drawing.Size(397, 23)
        Me.TXTSEARCH.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BTNBACK)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1322, 49)
        Me.Panel2.TabIndex = 44
        '
        'BTNBACK
        '
        Me.BTNBACK.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BTNBACK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTNBACK.FlatAppearance.BorderSize = 0
        Me.BTNBACK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNBACK.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNBACK.ForeColor = System.Drawing.Color.White
        Me.BTNBACK.Image = CType(resources.GetObject("BTNBACK.Image"), System.Drawing.Image)
        Me.BTNBACK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNBACK.Location = New System.Drawing.Point(1200, 3)
        Me.BTNBACK.Name = "BTNBACK"
        Me.BTNBACK.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.BTNBACK.Size = New System.Drawing.Size(119, 46)
        Me.BTNBACK.TabIndex = 4
        Me.BTNBACK.Text = " Back"
        Me.BTNBACK.UseVisualStyleBackColor = False
        '
        'ucPUTINTOINVENTORY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DTPAS)
        Me.Controls.Add(Me.TXTDA)
        Me.Controls.Add(Me.txtmix)
        Me.Name = "ucPUTINTOINVENTORY"
        Me.Size = New System.Drawing.Size(1322, 801)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DGVMAIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NUDQUANTITY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGVPRODUCTS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CBOUNIT As ComboBox
    Friend WithEvents TXTUNIT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DTPED As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents NUDQUANTITY As NumericUpDown
    Friend WithEvents TXTPRICE As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TXTSEARCH As TextBox
    Friend WithEvents txtmix As TextBox
    Friend WithEvents TXTPNA As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TXTPI As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXTDA As TextBox
    Friend WithEvents DTPAS As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents TXTSI As TextBox
    Friend WithEvents DGVPRODUCTS As DataGridView
    Friend WithEvents DGVMAIN As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BTNBACK As Button
    Friend WithEvents BTNDELETE As Button
    Friend WithEvents BTNSAVE As Button
End Class
