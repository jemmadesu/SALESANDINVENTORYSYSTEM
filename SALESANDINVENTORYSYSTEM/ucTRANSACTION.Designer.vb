<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucTRANSACTION
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXTPRICE = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTBILL = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TXTPRC = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TXTCATCODE = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TXTPRODCAT = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TXTPRODBRAND = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TXTPRODNAME = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TXTPRODID = New System.Windows.Forms.TextBox()
        Me.TXTUNIT = New System.Windows.Forms.TextBox()
        Me.TXTQTY = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BTNCART = New System.Windows.Forms.Button()
        Me.CBODISCOUNT = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTOR = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BTNSAVE = New System.Windows.Forms.Button()
        Me.TXTPAYMENT = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlpayment = New System.Windows.Forms.Panel()
        Me.TOTALBILL = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TXTCHANGE = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Payment = New System.Windows.Forms.Label()
        Me.TXTDISCAMOUNT = New System.Windows.Forms.TextBox()
        Me.TXTDUN = New System.Windows.Forms.TextBox()
        Me.DTTD = New System.Windows.Forms.DateTimePicker()
        Me.DTRD = New System.Windows.Forms.DateTimePicker()
        Me.DGVCART = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGVPRODUCTS = New System.Windows.Forms.DataGridView()
        Me.BTNDELETE = New System.Windows.Forms.Button()
        Me.BTNPAY = New System.Windows.Forms.Button()
        Me.TRANSADATE = New System.Windows.Forms.DateTimePicker()
        Me.lbldate = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.pnlpayment.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVCART, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVPRODUCTS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label11.Location = New System.Drawing.Point(539, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(238, 32)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "Sales Transaction"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(11, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Quantity:"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BackColor = System.Drawing.SystemColors.Window
        Me.NumericUpDown1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.NumericUpDown1.Location = New System.Drawing.Point(107, 57)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(176, 21)
        Me.NumericUpDown1.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(24, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 17)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Search Product "
        '
        'TXTPRICE
        '
        Me.TXTPRICE.BackColor = System.Drawing.SystemColors.Window
        Me.TXTPRICE.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPRICE.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTPRICE.Location = New System.Drawing.Point(141, 62)
        Me.TXTPRICE.Name = "TXTPRICE"
        Me.TXTPRICE.Size = New System.Drawing.Size(255, 23)
        Me.TXTPRICE.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(34, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 17)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Total Bill : "
        '
        'TXTBILL
        '
        Me.TXTBILL.BackColor = System.Drawing.SystemColors.Window
        Me.TXTBILL.Enabled = False
        Me.TXTBILL.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBILL.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTBILL.Location = New System.Drawing.Point(310, 781)
        Me.TXTBILL.Name = "TXTBILL"
        Me.TXTBILL.ReadOnly = True
        Me.TXTBILL.Size = New System.Drawing.Size(13, 21)
        Me.TXTBILL.TabIndex = 49
        Me.TXTBILL.Text = "0"
        Me.TXTBILL.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.TXTPRC)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.TXTCATCODE)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.TXTPRODCAT)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.TXTPRODBRAND)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.TXTPRODNAME)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.TXTPRODID)
        Me.GroupBox3.Controls.Add(Me.TXTUNIT)
        Me.GroupBox3.Controls.Add(Me.TXTQTY)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox3.Location = New System.Drawing.Point(22, 265)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(864, 98)
        Me.GroupBox3.TabIndex = 51
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Product's Information"
        '
        'TXTPRC
        '
        Me.TXTPRC.BackColor = System.Drawing.SystemColors.Window
        Me.TXTPRC.Enabled = False
        Me.TXTPRC.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPRC.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTPRC.Location = New System.Drawing.Point(598, 55)
        Me.TXTPRC.Name = "TXTPRC"
        Me.TXTPRC.ReadOnly = True
        Me.TXTPRC.Size = New System.Drawing.Size(80, 21)
        Me.TXTPRC.TabIndex = 61
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(476, 34)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(118, 17)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "Category Code :"
        '
        'TXTCATCODE
        '
        Me.TXTCATCODE.BackColor = System.Drawing.SystemColors.Window
        Me.TXTCATCODE.Enabled = False
        Me.TXTCATCODE.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCATCODE.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTCATCODE.Location = New System.Drawing.Point(479, 56)
        Me.TXTCATCODE.Name = "TXTCATCODE"
        Me.TXTCATCODE.ReadOnly = True
        Me.TXTCATCODE.Size = New System.Drawing.Size(96, 21)
        Me.TXTCATCODE.TabIndex = 29
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(358, 33)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(121, 17)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Category Name :"
        '
        'TXTPRODCAT
        '
        Me.TXTPRODCAT.BackColor = System.Drawing.SystemColors.Window
        Me.TXTPRODCAT.Enabled = False
        Me.TXTPRODCAT.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPRODCAT.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTPRODCAT.Location = New System.Drawing.Point(361, 55)
        Me.TXTPRODCAT.Name = "TXTPRODCAT"
        Me.TXTPRODCAT.ReadOnly = True
        Me.TXTPRODCAT.Size = New System.Drawing.Size(96, 21)
        Me.TXTPRODCAT.TabIndex = 27
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(241, 33)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(108, 17)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Product Brand :"
        '
        'TXTPRODBRAND
        '
        Me.TXTPRODBRAND.BackColor = System.Drawing.SystemColors.Window
        Me.TXTPRODBRAND.Enabled = False
        Me.TXTPRODBRAND.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPRODBRAND.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTPRODBRAND.Location = New System.Drawing.Point(240, 56)
        Me.TXTPRODBRAND.Name = "TXTPRODBRAND"
        Me.TXTPRODBRAND.ReadOnly = True
        Me.TXTPRODBRAND.Size = New System.Drawing.Size(96, 21)
        Me.TXTPRODBRAND.TabIndex = 25
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(120, 33)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(111, 17)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Product Name :"
        '
        'TXTPRODNAME
        '
        Me.TXTPRODNAME.BackColor = System.Drawing.SystemColors.Window
        Me.TXTPRODNAME.Enabled = False
        Me.TXTPRODNAME.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPRODNAME.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTPRODNAME.Location = New System.Drawing.Point(123, 56)
        Me.TXTPRODNAME.Name = "TXTPRODNAME"
        Me.TXTPRODNAME.ReadOnly = True
        Me.TXTPRODNAME.Size = New System.Drawing.Size(96, 21)
        Me.TXTPRODNAME.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 17)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Product ID :"
        '
        'TXTPRODID
        '
        Me.TXTPRODID.BackColor = System.Drawing.SystemColors.Window
        Me.TXTPRODID.Enabled = False
        Me.TXTPRODID.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPRODID.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTPRODID.Location = New System.Drawing.Point(15, 56)
        Me.TXTPRODID.Name = "TXTPRODID"
        Me.TXTPRODID.ReadOnly = True
        Me.TXTPRODID.Size = New System.Drawing.Size(96, 21)
        Me.TXTPRODID.TabIndex = 21
        '
        'TXTUNIT
        '
        Me.TXTUNIT.BackColor = System.Drawing.SystemColors.Window
        Me.TXTUNIT.Enabled = False
        Me.TXTUNIT.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTUNIT.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTUNIT.Location = New System.Drawing.Point(684, 55)
        Me.TXTUNIT.Name = "TXTUNIT"
        Me.TXTUNIT.ReadOnly = True
        Me.TXTUNIT.Size = New System.Drawing.Size(80, 21)
        Me.TXTUNIT.TabIndex = 19
        '
        'TXTQTY
        '
        Me.TXTQTY.BackColor = System.Drawing.SystemColors.Window
        Me.TXTQTY.Enabled = False
        Me.TXTQTY.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTQTY.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTQTY.Location = New System.Drawing.Point(770, 55)
        Me.TXTQTY.Name = "TXTQTY"
        Me.TXTQTY.ReadOnly = True
        Me.TXTQTY.Size = New System.Drawing.Size(80, 21)
        Me.TXTQTY.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(595, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Price:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(681, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 17)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Unit:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(767, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 17)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Stocks :"
        '
        'BTNCART
        '
        Me.BTNCART.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BTNCART.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNCART.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCART.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCART.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNCART.Location = New System.Drawing.Point(306, 28)
        Me.BTNCART.Name = "BTNCART"
        Me.BTNCART.Size = New System.Drawing.Size(82, 48)
        Me.BTNCART.TabIndex = 60
        Me.BTNCART.Text = "Add to Cart"
        Me.BTNCART.UseVisualStyleBackColor = False
        '
        'CBODISCOUNT
        '
        Me.CBODISCOUNT.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.CBODISCOUNT.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CBODISCOUNT.FormattingEnabled = True
        Me.CBODISCOUNT.Items.AddRange(New Object() {"N/A", "Senior Citizen", "PWD"})
        Me.CBODISCOUNT.Location = New System.Drawing.Point(142, 73)
        Me.CBODISCOUNT.Name = "CBODISCOUNT"
        Me.CBODISCOUNT.Size = New System.Drawing.Size(266, 25)
        Me.CBODISCOUNT.TabIndex = 13
        Me.CBODISCOUNT.Text = "-- Select --"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(34, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Discount Type :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(11, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "OR Number : "
        '
        'TXTOR
        '
        Me.TXTOR.BackColor = System.Drawing.SystemColors.Window
        Me.TXTOR.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTOR.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTOR.Location = New System.Drawing.Point(107, 26)
        Me.TXTOR.Name = "TXTOR"
        Me.TXTOR.Size = New System.Drawing.Size(171, 21)
        Me.TXTOR.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(34, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Change:"
        '
        'BTNSAVE
        '
        Me.BTNSAVE.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BTNSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSAVE.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSAVE.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNSAVE.Location = New System.Drawing.Point(308, 213)
        Me.BTNSAVE.Name = "BTNSAVE"
        Me.BTNSAVE.Size = New System.Drawing.Size(100, 29)
        Me.BTNSAVE.TabIndex = 16
        Me.BTNSAVE.Text = "Save"
        Me.BTNSAVE.UseVisualStyleBackColor = False
        '
        'TXTPAYMENT
        '
        Me.TXTPAYMENT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TXTPAYMENT.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTPAYMENT.Location = New System.Drawing.Point(142, 144)
        Me.TXTPAYMENT.Name = "TXTPAYMENT"
        Me.TXTPAYMENT.Size = New System.Drawing.Size(266, 20)
        Me.TXTPAYMENT.TabIndex = 19
        Me.TXTPAYMENT.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(34, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 17)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Cash Amount : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(24, 379)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 17)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Customer's Cart"
        '
        'pnlpayment
        '
        Me.pnlpayment.BackColor = System.Drawing.SystemColors.Control
        Me.pnlpayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlpayment.Controls.Add(Me.TOTALBILL)
        Me.pnlpayment.Controls.Add(Me.Panel2)
        Me.pnlpayment.Controls.Add(Me.Label9)
        Me.pnlpayment.Controls.Add(Me.Label2)
        Me.pnlpayment.Controls.Add(Me.CBODISCOUNT)
        Me.pnlpayment.Controls.Add(Me.TXTCHANGE)
        Me.pnlpayment.Controls.Add(Me.Panel1)
        Me.pnlpayment.Controls.Add(Me.BTNSAVE)
        Me.pnlpayment.Controls.Add(Me.Label3)
        Me.pnlpayment.Controls.Add(Me.Label5)
        Me.pnlpayment.Controls.Add(Me.TXTPAYMENT)
        Me.pnlpayment.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlpayment.Location = New System.Drawing.Point(871, 408)
        Me.pnlpayment.Name = "pnlpayment"
        Me.pnlpayment.Size = New System.Drawing.Size(428, 269)
        Me.pnlpayment.TabIndex = 53
        Me.pnlpayment.Visible = False
        '
        'TOTALBILL
        '
        Me.TOTALBILL.Enabled = False
        Me.TOTALBILL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TOTALBILL.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TOTALBILL.Location = New System.Drawing.Point(142, 111)
        Me.TOTALBILL.Name = "TOTALBILL"
        Me.TOTALBILL.Size = New System.Drawing.Size(266, 20)
        Me.TOTALBILL.TabIndex = 70
        Me.TOTALBILL.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel2.Location = New System.Drawing.Point(0, 258)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(429, 10)
        Me.Panel2.TabIndex = 69
        '
        'TXTCHANGE
        '
        Me.TXTCHANGE.Enabled = False
        Me.TXTCHANGE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TXTCHANGE.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.TXTCHANGE.Location = New System.Drawing.Point(142, 177)
        Me.TXTCHANGE.Name = "TXTCHANGE"
        Me.TXTCHANGE.Size = New System.Drawing.Size(266, 20)
        Me.TXTCHANGE.TabIndex = 31
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel1.Controls.Add(Me.Payment)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(428, 48)
        Me.Panel1.TabIndex = 0
        '
        'Payment
        '
        Me.Payment.AutoSize = True
        Me.Payment.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Payment.ForeColor = System.Drawing.Color.White
        Me.Payment.Location = New System.Drawing.Point(168, 12)
        Me.Payment.Name = "Payment"
        Me.Payment.Size = New System.Drawing.Size(80, 21)
        Me.Payment.TabIndex = 0
        Me.Payment.Text = "Payment"
        '
        'TXTDISCAMOUNT
        '
        Me.TXTDISCAMOUNT.Enabled = False
        Me.TXTDISCAMOUNT.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDISCAMOUNT.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTDISCAMOUNT.Location = New System.Drawing.Point(284, 781)
        Me.TXTDISCAMOUNT.Name = "TXTDISCAMOUNT"
        Me.TXTDISCAMOUNT.Size = New System.Drawing.Size(20, 21)
        Me.TXTDISCAMOUNT.TabIndex = 68
        Me.TXTDISCAMOUNT.Text = "0"
        Me.TXTDISCAMOUNT.Visible = False
        '
        'TXTDUN
        '
        Me.TXTDUN.Location = New System.Drawing.Point(177, 778)
        Me.TXTDUN.Name = "TXTDUN"
        Me.TXTDUN.Size = New System.Drawing.Size(33, 20)
        Me.TXTDUN.TabIndex = 62
        Me.TXTDUN.Visible = False
        '
        'DTTD
        '
        Me.DTTD.Enabled = False
        Me.DTTD.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.DTTD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTTD.Location = New System.Drawing.Point(216, 781)
        Me.DTTD.Name = "DTTD"
        Me.DTTD.Size = New System.Drawing.Size(25, 23)
        Me.DTTD.TabIndex = 66
        Me.DTTD.Visible = False
        '
        'DTRD
        '
        Me.DTRD.Enabled = False
        Me.DTRD.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.DTRD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTRD.Location = New System.Drawing.Point(247, 781)
        Me.DTRD.Name = "DTRD"
        Me.DTRD.Size = New System.Drawing.Size(22, 23)
        Me.DTRD.TabIndex = 67
        Me.DTRD.Visible = False
        '
        'DGVCART
        '
        Me.DGVCART.AllowUserToAddRows = False
        Me.DGVCART.AllowUserToDeleteRows = False
        Me.DGVCART.BackgroundColor = System.Drawing.Color.White
        Me.DGVCART.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCART.Location = New System.Drawing.Point(23, 408)
        Me.DGVCART.Name = "DGVCART"
        Me.DGVCART.ReadOnly = True
        Me.DGVCART.RowHeadersVisible = False
        Me.DGVCART.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVCART.Size = New System.Drawing.Size(818, 269)
        Me.DGVCART.TabIndex = 32
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.BTNCART)
        Me.GroupBox1.Controls.Add(Me.TXTOR)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(892, 265)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(407, 98)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        '
        'DGVPRODUCTS
        '
        Me.DGVPRODUCTS.AllowUserToAddRows = False
        Me.DGVPRODUCTS.AllowUserToDeleteRows = False
        Me.DGVPRODUCTS.BackgroundColor = System.Drawing.Color.White
        Me.DGVPRODUCTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPRODUCTS.Location = New System.Drawing.Point(22, 101)
        Me.DGVPRODUCTS.Name = "DGVPRODUCTS"
        Me.DGVPRODUCTS.ReadOnly = True
        Me.DGVPRODUCTS.RowHeadersVisible = False
        Me.DGVPRODUCTS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVPRODUCTS.Size = New System.Drawing.Size(1277, 158)
        Me.DGVPRODUCTS.TabIndex = 70
        '
        'BTNDELETE
        '
        Me.BTNDELETE.BackColor = System.Drawing.Color.Gray
        Me.BTNDELETE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNDELETE.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNDELETE.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNDELETE.Location = New System.Drawing.Point(696, 693)
        Me.BTNDELETE.Name = "BTNDELETE"
        Me.BTNDELETE.Size = New System.Drawing.Size(145, 31)
        Me.BTNDELETE.TabIndex = 71
        Me.BTNDELETE.Text = "Remove from cart"
        Me.BTNDELETE.UseVisualStyleBackColor = False
        '
        'BTNPAY
        '
        Me.BTNPAY.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BTNPAY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNPAY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNPAY.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNPAY.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNPAY.Location = New System.Drawing.Point(545, 693)
        Me.BTNPAY.Name = "BTNPAY"
        Me.BTNPAY.Size = New System.Drawing.Size(145, 31)
        Me.BTNPAY.TabIndex = 72
        Me.BTNPAY.Text = "Pay"
        Me.BTNPAY.UseVisualStyleBackColor = False
        Me.BTNPAY.Visible = False
        '
        'TRANSADATE
        '
        Me.TRANSADATE.Location = New System.Drawing.Point(13, 775)
        Me.TRANSADATE.Name = "TRANSADATE"
        Me.TRANSADATE.Size = New System.Drawing.Size(15, 20)
        Me.TRANSADATE.TabIndex = 73
        Me.TRANSADATE.Visible = False
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Location = New System.Drawing.Point(133, 785)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(38, 13)
        Me.lbldate.TabIndex = 76
        Me.lbldate.Text = "lbldate"
        '
        'ucTRANSACTION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.TRANSADATE)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.BTNDELETE)
        Me.Controls.Add(Me.BTNPAY)
        Me.Controls.Add(Me.DGVPRODUCTS)
        Me.Controls.Add(Me.pnlpayment)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TXTDISCAMOUNT)
        Me.Controls.Add(Me.TXTBILL)
        Me.Controls.Add(Me.DTRD)
        Me.Controls.Add(Me.DTTD)
        Me.Controls.Add(Me.TXTDUN)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DGVCART)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TXTPRICE)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "ucTRANSACTION"
        Me.Size = New System.Drawing.Size(1322, 801)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.pnlpayment.ResumeLayout(False)
        Me.pnlpayment.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGVCART, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVPRODUCTS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTBILL As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TXTUNIT As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TXTQTY As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXTPRICE As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTOR As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BTNSAVE As Button
    Friend WithEvents TXTPAYMENT As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CBODISCOUNT As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TXTPRODID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents pnlpayment As Panel
    Friend WithEvents BTNCART As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents TXTCATCODE As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TXTPRODCAT As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TXTPRODBRAND As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TXTPRODNAME As TextBox
    Friend WithEvents TXTDUN As TextBox
    Friend WithEvents DTTD As DateTimePicker
    Friend WithEvents DTRD As DateTimePicker
    Friend WithEvents TXTCHANGE As TextBox
    Friend WithEvents DGVCART As DataGridView
    Friend WithEvents TransnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TXTDISCAMOUNT As TextBox
    Friend WithEvents TXTPRC As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Payment As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DGVPRODUCTS As DataGridView
    Friend WithEvents BTNDELETE As Button
    Friend WithEvents BTNPAY As Button
    Friend WithEvents TOTALBILL As TextBox
    Friend WithEvents TRANSADATE As DateTimePicker
    Friend WithEvents lbldate As Label
End Class
