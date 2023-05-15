<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucRESTOCK
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucRESTOCK))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTBRAND = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTPRICE = New System.Windows.Forms.TextBox()
        Me.TXTUNIT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTPRODNAME = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNSAVE = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TXTPRODCODE = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TXTID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXTCATCODE = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXTCATEGORY = New System.Windows.Forms.TextBox()
        Me.TXTMAN = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGVPRODUCTS = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTSEARCH = New System.Windows.Forms.TextBox()
        Me.TXTSI = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BTNBACK = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CBOSUPPLIER = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTNSUPPLIER = New System.Windows.Forms.Button()
        Me.MANU = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.EXP = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.DELIVERED = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.QTY = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PNLSUPPLIER = New System.Windows.Forms.Panel()
        Me.HEADERPANEL = New System.Windows.Forms.Panel()
        Me.LBLCLOSE = New System.Windows.Forms.PictureBox()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVPRODUCTS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.QTY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.HEADERPANEL.SuspendLayout()
        CType(Me.LBLCLOSE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label8.Location = New System.Drawing.Point(45, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(332, 32)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "DELIVERY MANAGEMENT"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TXTBRAND)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TXTPRICE)
        Me.GroupBox3.Controls.Add(Me.TXTUNIT)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TXTPRODNAME)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.BTNSAVE)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox3.Location = New System.Drawing.Point(51, 292)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(993, 117)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Product Information"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(213, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Brand "
        '
        'TXTBRAND
        '
        Me.TXTBRAND.BackColor = System.Drawing.Color.White
        Me.TXTBRAND.Enabled = False
        Me.TXTBRAND.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTBRAND.Location = New System.Drawing.Point(213, 65)
        Me.TXTBRAND.Name = "TXTBRAND"
        Me.TXTBRAND.ReadOnly = True
        Me.TXTBRAND.Size = New System.Drawing.Size(150, 23)
        Me.TXTBRAND.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(394, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Unit "
        '
        'TXTPRICE
        '
        Me.TXTPRICE.BackColor = System.Drawing.Color.White
        Me.TXTPRICE.Enabled = False
        Me.TXTPRICE.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTPRICE.Location = New System.Drawing.Point(582, 65)
        Me.TXTPRICE.Name = "TXTPRICE"
        Me.TXTPRICE.ReadOnly = True
        Me.TXTPRICE.Size = New System.Drawing.Size(150, 23)
        Me.TXTPRICE.TabIndex = 5
        '
        'TXTUNIT
        '
        Me.TXTUNIT.BackColor = System.Drawing.Color.White
        Me.TXTUNIT.Enabled = False
        Me.TXTUNIT.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTUNIT.Location = New System.Drawing.Point(394, 65)
        Me.TXTUNIT.Name = "TXTUNIT"
        Me.TXTUNIT.ReadOnly = True
        Me.TXTUNIT.Size = New System.Drawing.Size(150, 23)
        Me.TXTUNIT.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(578, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Price "
        '
        'TXTPRODNAME
        '
        Me.TXTPRODNAME.BackColor = System.Drawing.Color.White
        Me.TXTPRODNAME.Enabled = False
        Me.TXTPRODNAME.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTPRODNAME.Location = New System.Drawing.Point(24, 65)
        Me.TXTPRODNAME.Name = "TXTPRODNAME"
        Me.TXTPRODNAME.ReadOnly = True
        Me.TXTPRODNAME.Size = New System.Drawing.Size(150, 23)
        Me.TXTPRODNAME.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Name "
        '
        'BTNSAVE
        '
        Me.BTNSAVE.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BTNSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSAVE.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSAVE.ForeColor = System.Drawing.Color.White
        Me.BTNSAVE.Location = New System.Drawing.Point(795, 61)
        Me.BTNSAVE.Name = "BTNSAVE"
        Me.BTNSAVE.Size = New System.Drawing.Size(133, 31)
        Me.BTNSAVE.TabIndex = 8
        Me.BTNSAVE.Text = "Save"
        Me.BTNSAVE.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(20, 69)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(117, 20)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Product Code "
        '
        'TXTPRODCODE
        '
        Me.TXTPRODCODE.BackColor = System.Drawing.Color.White
        Me.TXTPRODCODE.Enabled = False
        Me.TXTPRODCODE.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTPRODCODE.Location = New System.Drawing.Point(24, 95)
        Me.TXTPRODCODE.Name = "TXTPRODCODE"
        Me.TXTPRODCODE.ReadOnly = True
        Me.TXTPRODCODE.Size = New System.Drawing.Size(158, 20)
        Me.TXTPRODCODE.TabIndex = 24
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(20, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 20)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Product ID "
        '
        'TXTID
        '
        Me.TXTID.BackColor = System.Drawing.Color.White
        Me.TXTID.Enabled = False
        Me.TXTID.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTID.Location = New System.Drawing.Point(24, 33)
        Me.TXTID.Name = "TXTID"
        Me.TXTID.ReadOnly = True
        Me.TXTID.Size = New System.Drawing.Size(158, 20)
        Me.TXTID.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(184, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 20)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Category Code "
        '
        'TXTCATCODE
        '
        Me.TXTCATCODE.BackColor = System.Drawing.Color.White
        Me.TXTCATCODE.Enabled = False
        Me.TXTCATCODE.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTCATCODE.Location = New System.Drawing.Point(184, 106)
        Me.TXTCATCODE.Name = "TXTCATCODE"
        Me.TXTCATCODE.ReadOnly = True
        Me.TXTCATCODE.Size = New System.Drawing.Size(150, 20)
        Me.TXTCATCODE.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(184, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Category "
        '
        'TXTCATEGORY
        '
        Me.TXTCATEGORY.BackColor = System.Drawing.Color.White
        Me.TXTCATEGORY.Enabled = False
        Me.TXTCATEGORY.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTCATEGORY.Location = New System.Drawing.Point(188, 42)
        Me.TXTCATEGORY.Name = "TXTCATEGORY"
        Me.TXTCATEGORY.ReadOnly = True
        Me.TXTCATEGORY.Size = New System.Drawing.Size(150, 20)
        Me.TXTCATEGORY.TabIndex = 15
        '
        'TXTMAN
        '
        Me.TXTMAN.BackColor = System.Drawing.Color.White
        Me.TXTMAN.Enabled = False
        Me.TXTMAN.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTMAN.Location = New System.Drawing.Point(24, 157)
        Me.TXTMAN.Name = "TXTMAN"
        Me.TXTMAN.ReadOnly = True
        Me.TXTMAN.Size = New System.Drawing.Size(150, 20)
        Me.TXTMAN.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Manufacturer "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(274, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Expiration Date :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox1.Controls.Add(Me.DGVPRODUCTS)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TXTSEARCH)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(51, 427)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(993, 255)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product List"
        '
        'DGVPRODUCTS
        '
        Me.DGVPRODUCTS.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVPRODUCTS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DGVPRODUCTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVPRODUCTS.DefaultCellStyle = DataGridViewCellStyle11
        Me.DGVPRODUCTS.Location = New System.Drawing.Point(24, 51)
        Me.DGVPRODUCTS.Name = "DGVPRODUCTS"
        Me.DGVPRODUCTS.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVPRODUCTS.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DGVPRODUCTS.RowHeadersVisible = False
        Me.DGVPRODUCTS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVPRODUCTS.Size = New System.Drawing.Size(952, 186)
        Me.DGVPRODUCTS.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(22, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Search "
        '
        'TXTSEARCH
        '
        Me.TXTSEARCH.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSEARCH.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTSEARCH.Location = New System.Drawing.Point(83, 22)
        Me.TXTSEARCH.Name = "TXTSEARCH"
        Me.TXTSEARCH.Size = New System.Drawing.Size(248, 23)
        Me.TXTSEARCH.TabIndex = 7
        '
        'TXTSI
        '
        Me.TXTSI.BackColor = System.Drawing.Color.White
        Me.TXTSI.Enabled = False
        Me.TXTSI.Location = New System.Drawing.Point(18, 778)
        Me.TXTSI.Name = "TXTSI"
        Me.TXTSI.ReadOnly = True
        Me.TXTSI.Size = New System.Drawing.Size(147, 20)
        Me.TXTSI.TabIndex = 39
        Me.TXTSI.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BTNBACK)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1091, 49)
        Me.Panel2.TabIndex = 45
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
        Me.BTNBACK.Location = New System.Drawing.Point(973, 3)
        Me.BTNBACK.Name = "BTNBACK"
        Me.BTNBACK.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.BTNBACK.Size = New System.Drawing.Size(119, 46)
        Me.BTNBACK.TabIndex = 2
        Me.BTNBACK.Text = "Back"
        Me.BTNBACK.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 20)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Quantity :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(274, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(164, 20)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Manufactured Date :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(20, 36)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 20)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Supplier :"
        '
        'CBOSUPPLIER
        '
        Me.CBOSUPPLIER.FormattingEnabled = True
        Me.CBOSUPPLIER.Location = New System.Drawing.Point(24, 59)
        Me.CBOSUPPLIER.Name = "CBOSUPPLIER"
        Me.CBOSUPPLIER.Size = New System.Drawing.Size(158, 25)
        Me.CBOSUPPLIER.TabIndex = 25
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.BTNSUPPLIER)
        Me.GroupBox2.Controls.Add(Me.MANU)
        Me.GroupBox2.Controls.Add(Me.EXP)
        Me.GroupBox2.Controls.Add(Me.DELIVERED)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.QTY)
        Me.GroupBox2.Controls.Add(Me.CBOSUPPLIER)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox2.Location = New System.Drawing.Point(51, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(993, 174)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Delivered Products Information"
        '
        'BTNSUPPLIER
        '
        Me.BTNSUPPLIER.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BTNSUPPLIER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTNSUPPLIER.FlatAppearance.BorderSize = 0
        Me.BTNSUPPLIER.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSUPPLIER.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSUPPLIER.ForeColor = System.Drawing.Color.White
        Me.BTNSUPPLIER.Image = CType(resources.GetObject("BTNSUPPLIER.Image"), System.Drawing.Image)
        Me.BTNSUPPLIER.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNSUPPLIER.Location = New System.Drawing.Point(188, 49)
        Me.BTNSUPPLIER.Name = "BTNSUPPLIER"
        Me.BTNSUPPLIER.Size = New System.Drawing.Size(39, 33)
        Me.BTNSUPPLIER.TabIndex = 51
        Me.BTNSUPPLIER.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNSUPPLIER.UseVisualStyleBackColor = False
        '
        'MANU
        '
        Me.MANU.CheckedState.Parent = Me.MANU
        Me.MANU.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.MANU.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MANU.ForeColor = System.Drawing.Color.White
        Me.MANU.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.MANU.HoverState.Parent = Me.MANU
        Me.MANU.Location = New System.Drawing.Point(278, 49)
        Me.MANU.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.MANU.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.MANU.Name = "MANU"
        Me.MANU.ShadowDecoration.Parent = Me.MANU
        Me.MANU.Size = New System.Drawing.Size(211, 36)
        Me.MANU.TabIndex = 50
        Me.MANU.Value = New Date(2023, 12, 31, 0, 0, 0, 0)
        '
        'EXP
        '
        Me.EXP.CheckedState.Parent = Me.EXP
        Me.EXP.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.EXP.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXP.ForeColor = System.Drawing.Color.White
        Me.EXP.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.EXP.HoverState.Parent = Me.EXP
        Me.EXP.Location = New System.Drawing.Point(278, 121)
        Me.EXP.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.EXP.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.EXP.Name = "EXP"
        Me.EXP.ShadowDecoration.Parent = Me.EXP
        Me.EXP.Size = New System.Drawing.Size(211, 36)
        Me.EXP.TabIndex = 49
        Me.EXP.Value = New Date(2023, 12, 31, 0, 0, 0, 0)
        '
        'DELIVERED
        '
        Me.DELIVERED.CheckedState.Parent = Me.DELIVERED
        Me.DELIVERED.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.DELIVERED.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DELIVERED.ForeColor = System.Drawing.Color.White
        Me.DELIVERED.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DELIVERED.HoverState.Parent = Me.DELIVERED
        Me.DELIVERED.Location = New System.Drawing.Point(562, 88)
        Me.DELIVERED.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DELIVERED.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DELIVERED.Name = "DELIVERED"
        Me.DELIVERED.ShadowDecoration.Parent = Me.DELIVERED
        Me.DELIVERED.Size = New System.Drawing.Size(211, 36)
        Me.DELIVERED.TabIndex = 47
        Me.DELIVERED.Value = New Date(2023, 12, 31, 0, 0, 0, 0)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(558, 58)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(129, 20)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "Date Delivered :"
        '
        'QTY
        '
        Me.QTY.BackColor = System.Drawing.Color.Transparent
        Me.QTY.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.QTY.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.QTY.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.QTY.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.QTY.DisabledState.Parent = Me.QTY
        Me.QTY.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.QTY.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.QTY.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QTY.FocusedState.Parent = Me.QTY
        Me.QTY.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QTY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.QTY.Location = New System.Drawing.Point(24, 115)
        Me.QTY.Name = "QTY"
        Me.QTY.ShadowDecoration.Parent = Me.QTY
        Me.QTY.Size = New System.Drawing.Size(100, 23)
        Me.QTY.TabIndex = 47
        Me.QTY.UpDownButtonFillColor = System.Drawing.Color.MediumSeaGreen
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.TXTCATCODE)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TXTPRODCODE)
        Me.Panel1.Controls.Add(Me.TXTCATEGORY)
        Me.Panel1.Controls.Add(Me.TXTID)
        Me.Panel1.Controls.Add(Me.TXTMAN)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(1129, 452)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(383, 216)
        Me.Panel1.TabIndex = 25
        '
        'PNLSUPPLIER
        '
        Me.PNLSUPPLIER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PNLSUPPLIER.Location = New System.Drawing.Point(51, 100)
        Me.PNLSUPPLIER.Name = "PNLSUPPLIER"
        Me.PNLSUPPLIER.Size = New System.Drawing.Size(993, 582)
        Me.PNLSUPPLIER.TabIndex = 75
        Me.PNLSUPPLIER.Visible = False
        '
        'HEADERPANEL
        '
        Me.HEADERPANEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.HEADERPANEL.Controls.Add(Me.LBLCLOSE)
        Me.HEADERPANEL.Location = New System.Drawing.Point(51, 62)
        Me.HEADERPANEL.Name = "HEADERPANEL"
        Me.HEADERPANEL.Size = New System.Drawing.Size(993, 49)
        Me.HEADERPANEL.TabIndex = 79
        Me.HEADERPANEL.Visible = False
        '
        'LBLCLOSE
        '
        Me.LBLCLOSE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LBLCLOSE.Image = Global.SALESANDINVENTORYSYSTEM.My.Resources.Resources.x_mark_64__1_
        Me.LBLCLOSE.Location = New System.Drawing.Point(957, 11)
        Me.LBLCLOSE.Name = "LBLCLOSE"
        Me.LBLCLOSE.Size = New System.Drawing.Size(19, 21)
        Me.LBLCLOSE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LBLCLOSE.TabIndex = 79
        Me.LBLCLOSE.TabStop = False
        '
        'ucRESTOCK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.HEADERPANEL)
        Me.Controls.Add(Me.PNLSUPPLIER)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TXTSI)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "ucRESTOCK"
        Me.Size = New System.Drawing.Size(1091, 729)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVPRODUCTS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.QTY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.HEADERPANEL.ResumeLayout(False)
        CType(Me.LBLCLOSE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TXTMAN As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BTNSAVE As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TXTPRICE As TextBox
    Friend WithEvents TXTUNIT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTPRODNAME As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTSEARCH As TextBox
    Friend WithEvents TXTSI As TextBox
    Friend WithEvents DGVPRODUCTS As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BTNBACK As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents TXTCATCODE As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TXTCATEGORY As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTBRAND As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents CBOSUPPLIER As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TXTPRODCODE As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TXTID As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents QTY As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Label16 As Label
    Friend WithEvents DELIVERED As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents MANU As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents EXP As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents BTNSUPPLIER As Button
    Friend WithEvents PNLSUPPLIER As Panel
    Friend WithEvents LBLCLOSE As PictureBox
    Friend WithEvents HEADERPANEL As Panel
End Class
