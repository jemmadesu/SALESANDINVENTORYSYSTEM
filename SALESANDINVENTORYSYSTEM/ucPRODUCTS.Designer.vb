<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucNEWPRODUCT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucNEWPRODUCT))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TXTCATCODE = New System.Windows.Forms.TextBox()
        Me.BTNADD = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CBOPRODCAT = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTPI = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNSAVE = New System.Windows.Forms.Button()
        Me.BTNEDIT = New System.Windows.Forms.Button()
        Me.BTNCSNCEL = New System.Windows.Forms.Button()
        Me.TXTPNA = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXTSEARCH = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DTP = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXTUNIT = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTPRICE = New System.Windows.Forms.TextBox()
        Me.CBOBRAND = New System.Windows.Forms.ComboBox()
        Me.CBOMANUFACTURER = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BTNBACK = New System.Windows.Forms.Button()
        Me.DGVPRODUCTS = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LBLID = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DGVPRODUCTS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXTCATCODE
        '
        Me.TXTCATCODE.Enabled = False
        Me.TXTCATCODE.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCATCODE.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTCATCODE.Location = New System.Drawing.Point(231, 314)
        Me.TXTCATCODE.Name = "TXTCATCODE"
        Me.TXTCATCODE.Size = New System.Drawing.Size(190, 23)
        Me.TXTCATCODE.TabIndex = 48
        '
        'BTNADD
        '
        Me.BTNADD.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BTNADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNADD.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNADD.ForeColor = System.Drawing.Color.White
        Me.BTNADD.Location = New System.Drawing.Point(28, 479)
        Me.BTNADD.Name = "BTNADD"
        Me.BTNADD.Size = New System.Drawing.Size(75, 30)
        Me.BTNADD.TabIndex = 45
        Me.BTNADD.Text = "Add"
        Me.BTNADD.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(45, 197)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 20)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Brand :"
        '
        'CBOPRODCAT
        '
        Me.CBOPRODCAT.Enabled = False
        Me.CBOPRODCAT.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOPRODCAT.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CBOPRODCAT.FormattingEnabled = True
        Me.CBOPRODCAT.Location = New System.Drawing.Point(231, 255)
        Me.CBOPRODCAT.Name = "CBOPRODCAT"
        Me.CBOPRODCAT.Size = New System.Drawing.Size(190, 25)
        Me.CBOPRODCAT.TabIndex = 21
        Me.CBOPRODCAT.Text = "-- Select --"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(45, 314)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 20)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Category Code :"
        '
        'TXTPI
        '
        Me.TXTPI.Enabled = False
        Me.TXTPI.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPI.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTPI.Location = New System.Drawing.Point(231, 34)
        Me.TXTPI.Name = "TXTPI"
        Me.TXTPI.Size = New System.Drawing.Size(190, 23)
        Me.TXTPI.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(45, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Category Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(45, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Product Code :"
        '
        'BTNSAVE
        '
        Me.BTNSAVE.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BTNSAVE.Enabled = False
        Me.BTNSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSAVE.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSAVE.ForeColor = System.Drawing.Color.White
        Me.BTNSAVE.Location = New System.Drawing.Point(248, 479)
        Me.BTNSAVE.Name = "BTNSAVE"
        Me.BTNSAVE.Size = New System.Drawing.Size(75, 30)
        Me.BTNSAVE.TabIndex = 14
        Me.BTNSAVE.Text = "Save"
        Me.BTNSAVE.UseVisualStyleBackColor = False
        '
        'BTNEDIT
        '
        Me.BTNEDIT.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BTNEDIT.Enabled = False
        Me.BTNEDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNEDIT.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNEDIT.ForeColor = System.Drawing.Color.White
        Me.BTNEDIT.Location = New System.Drawing.Point(123, 479)
        Me.BTNEDIT.Name = "BTNEDIT"
        Me.BTNEDIT.Size = New System.Drawing.Size(75, 30)
        Me.BTNEDIT.TabIndex = 12
        Me.BTNEDIT.Text = "Edit"
        Me.BTNEDIT.UseVisualStyleBackColor = False
        '
        'BTNCSNCEL
        '
        Me.BTNCSNCEL.BackColor = System.Drawing.Color.Gray
        Me.BTNCSNCEL.Enabled = False
        Me.BTNCSNCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCSNCEL.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCSNCEL.ForeColor = System.Drawing.Color.White
        Me.BTNCSNCEL.Location = New System.Drawing.Point(346, 479)
        Me.BTNCSNCEL.Name = "BTNCSNCEL"
        Me.BTNCSNCEL.Size = New System.Drawing.Size(75, 30)
        Me.BTNCSNCEL.TabIndex = 15
        Me.BTNCSNCEL.Text = "Clear"
        Me.BTNCSNCEL.UseVisualStyleBackColor = False
        '
        'TXTPNA
        '
        Me.TXTPNA.Enabled = False
        Me.TXTPNA.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPNA.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTPNA.Location = New System.Drawing.Point(231, 89)
        Me.TXTPNA.Name = "TXTPNA"
        Me.TXTPNA.Size = New System.Drawing.Size(190, 23)
        Me.TXTPNA.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(45, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Manufacturer :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(45, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Product Name :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label8.Location = New System.Drawing.Point(42, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(344, 32)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "PRODUCT MANAGEMENT "
        '
        'TXTSEARCH
        '
        Me.TXTSEARCH.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSEARCH.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTSEARCH.Location = New System.Drawing.Point(227, 38)
        Me.TXTSEARCH.Name = "TXTSEARCH"
        Me.TXTSEARCH.Size = New System.Drawing.Size(254, 23)
        Me.TXTSEARCH.TabIndex = 40
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(67, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(154, 17)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Search Product Name:"
        '
        'DTP
        '
        Me.DTP.Enabled = False
        Me.DTP.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.DTP.Location = New System.Drawing.Point(43, 775)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(15, 23)
        Me.DTP.TabIndex = 42
        Me.DTP.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXTUNIT)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TXTPRICE)
        Me.GroupBox1.Controls.Add(Me.CBOBRAND)
        Me.GroupBox1.Controls.Add(Me.CBOMANUFACTURER)
        Me.GroupBox1.Controls.Add(Me.TXTCATCODE)
        Me.GroupBox1.Controls.Add(Me.TXTPI)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.BTNCSNCEL)
        Me.GroupBox1.Controls.Add(Me.BTNADD)
        Me.GroupBox1.Controls.Add(Me.TXTPNA)
        Me.GroupBox1.Controls.Add(Me.BTNSAVE)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.BTNEDIT)
        Me.GroupBox1.Controls.Add(Me.CBOPRODCAT)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(48, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(474, 529)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        '
        'TXTUNIT
        '
        Me.TXTUNIT.Enabled = False
        Me.TXTUNIT.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTUNIT.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTUNIT.Location = New System.Drawing.Point(231, 367)
        Me.TXTUNIT.Name = "TXTUNIT"
        Me.TXTUNIT.Size = New System.Drawing.Size(190, 23)
        Me.TXTUNIT.TabIndex = 79
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(51, 370)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 20)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Unit :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(51, 424)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "Price :"
        '
        'TXTPRICE
        '
        Me.TXTPRICE.Enabled = False
        Me.TXTPRICE.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPRICE.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTPRICE.Location = New System.Drawing.Point(231, 421)
        Me.TXTPRICE.Name = "TXTPRICE"
        Me.TXTPRICE.Size = New System.Drawing.Size(190, 23)
        Me.TXTPRICE.TabIndex = 76
        '
        'CBOBRAND
        '
        Me.CBOBRAND.Enabled = False
        Me.CBOBRAND.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOBRAND.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CBOBRAND.FormattingEnabled = True
        Me.CBOBRAND.Items.AddRange(New Object() {"ARBLOC", "AUGMENTIN", "AVARIN", "BIOGESI", "CATAFLAM", "CLOVIX", "COZAAR", "CORALAN", "DOXICON", "EXFORGE", "FENOFLEX", "FORXIGA", "GODEX", "KELTICAN", "LIVOLIN", "LYRICA", "NEBILET", "PLAVIX", "RENVELA", "VOLTAREN", "ZYRTEC"})
        Me.CBOBRAND.Location = New System.Drawing.Point(231, 197)
        Me.CBOBRAND.Name = "CBOBRAND"
        Me.CBOBRAND.Size = New System.Drawing.Size(190, 25)
        Me.CBOBRAND.TabIndex = 75
        Me.CBOBRAND.Text = "-- Select --"
        '
        'CBOMANUFACTURER
        '
        Me.CBOMANUFACTURER.Enabled = False
        Me.CBOMANUFACTURER.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOMANUFACTURER.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CBOMANUFACTURER.FormattingEnabled = True
        Me.CBOMANUFACTURER.Location = New System.Drawing.Point(231, 147)
        Me.CBOMANUFACTURER.Name = "CBOMANUFACTURER"
        Me.CBOMANUFACTURER.Size = New System.Drawing.Size(190, 25)
        Me.CBOMANUFACTURER.TabIndex = 74
        Me.CBOMANUFACTURER.Text = "-- Select --"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BTNBACK)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1091, 49)
        Me.Panel2.TabIndex = 48
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
        Me.BTNBACK.Location = New System.Drawing.Point(979, 3)
        Me.BTNBACK.Name = "BTNBACK"
        Me.BTNBACK.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.BTNBACK.Size = New System.Drawing.Size(119, 46)
        Me.BTNBACK.TabIndex = 3
        Me.BTNBACK.Text = " Back"
        Me.BTNBACK.UseVisualStyleBackColor = False
        '
        'DGVPRODUCTS
        '
        Me.DGVPRODUCTS.AllowUserToAddRows = False
        Me.DGVPRODUCTS.AllowUserToDeleteRows = False
        Me.DGVPRODUCTS.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVPRODUCTS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVPRODUCTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVPRODUCTS.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVPRODUCTS.Location = New System.Drawing.Point(26, 67)
        Me.DGVPRODUCTS.Name = "DGVPRODUCTS"
        Me.DGVPRODUCTS.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVPRODUCTS.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVPRODUCTS.RowHeadersVisible = False
        Me.DGVPRODUCTS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVPRODUCTS.Size = New System.Drawing.Size(455, 433)
        Me.DGVPRODUCTS.TabIndex = 71
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox2.Controls.Add(Me.DGVPRODUCTS)
        Me.GroupBox2.Controls.Add(Me.TXTSEARCH)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox2.Location = New System.Drawing.Point(544, 145)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(502, 520)
        Me.GroupBox2.TabIndex = 72
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "New Product List"
        '
        'LBLID
        '
        Me.LBLID.AutoSize = True
        Me.LBLID.ForeColor = System.Drawing.Color.White
        Me.LBLID.Location = New System.Drawing.Point(432, 120)
        Me.LBLID.Name = "LBLID"
        Me.LBLID.Size = New System.Drawing.Size(18, 13)
        Me.LBLID.TabIndex = 73
        Me.LBLID.Text = "ID"
        Me.LBLID.Visible = False
        '
        'ucNEWPRODUCT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.LBLID)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DTP)
        Me.Name = "ucNEWPRODUCT"
        Me.Size = New System.Drawing.Size(1091, 729)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DGVPRODUCTS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNSAVE As Button
    Friend WithEvents BTNEDIT As Button
    Friend WithEvents TXTPI As TextBox
    Friend WithEvents BTNCSNCEL As Button
    Friend WithEvents TXTPNA As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TXTSEARCH As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CBOPRODCAT As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BTNADD As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TXTCATCODE As TextBox
    Friend WithEvents DTP As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BTNBACK As Button
    Friend WithEvents DGVPRODUCTS As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LBLID As Label
    Friend WithEvents CBOMANUFACTURER As ComboBox
    Friend WithEvents CBOBRAND As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXTPRICE As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TXTUNIT As TextBox
End Class
