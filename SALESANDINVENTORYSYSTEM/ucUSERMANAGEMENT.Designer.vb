<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucUSERMANAGEMENT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucUSERMANAGEMENT))
        Me.TXTMN = New System.Windows.Forms.TextBox()
        Me.CBOSTATUS = New System.Windows.Forms.ComboBox()
        Me.CBOACCTYPE = New System.Windows.Forms.ComboBox()
        Me.TXTDUN = New System.Windows.Forms.TextBox()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.CHKPASS = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TXTCP = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXTPW = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXTUN = New System.Windows.Forms.TextBox()
        Me.TXTRI = New System.Windows.Forms.TextBox()
        Me.TXTADDRESS = New System.Windows.Forms.TextBox()
        Me.TXTEMAIL = New System.Windows.Forms.TextBox()
        Me.TXTTEL = New System.Windows.Forms.TextBox()
        Me.TXTLN = New System.Windows.Forms.TextBox()
        Me.TXTFN = New System.Windows.Forms.TextBox()
        Me.ID = New System.Windows.Forms.TextBox()
        Me.TXTUI = New System.Windows.Forms.TextBox()
        Me.TXTNAME = New System.Windows.Forms.TextBox()
        Me.DGVUSERS = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BTNCANCEL = New System.Windows.Forms.Button()
        Me.BTNEDIT = New System.Windows.Forms.Button()
        Me.BTNDELETE = New System.Windows.Forms.Button()
        Me.BTNSAVE = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNBACK = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVUSERS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXTMN
        '
        Me.TXTMN.Enabled = False
        Me.TXTMN.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.TXTMN.Location = New System.Drawing.Point(182, 270)
        Me.TXTMN.Name = "TXTMN"
        Me.TXTMN.Size = New System.Drawing.Size(341, 22)
        Me.TXTMN.TabIndex = 117
        '
        'CBOSTATUS
        '
        Me.CBOSTATUS.Enabled = False
        Me.CBOSTATUS.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.CBOSTATUS.FormattingEnabled = True
        Me.CBOSTATUS.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.CBOSTATUS.Location = New System.Drawing.Point(383, 153)
        Me.CBOSTATUS.Name = "CBOSTATUS"
        Me.CBOSTATUS.Size = New System.Drawing.Size(102, 25)
        Me.CBOSTATUS.TabIndex = 115
        '
        'CBOACCTYPE
        '
        Me.CBOACCTYPE.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.CBOACCTYPE.FormattingEnabled = True
        Me.CBOACCTYPE.Items.AddRange(New Object() {"Admin", "Cashier", "Manager"})
        Me.CBOACCTYPE.Location = New System.Drawing.Point(182, 153)
        Me.CBOACCTYPE.Name = "CBOACCTYPE"
        Me.CBOACCTYPE.Size = New System.Drawing.Size(102, 25)
        Me.CBOACCTYPE.TabIndex = 114
        '
        'TXTDUN
        '
        Me.TXTDUN.Location = New System.Drawing.Point(559, 781)
        Me.TXTDUN.Name = "TXTDUN"
        Me.TXTDUN.Size = New System.Drawing.Size(13, 20)
        Me.TXTDUN.TabIndex = 113
        Me.TXTDUN.Visible = False
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(843, 114)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(277, 23)
        Me.txtsearch.TabIndex = 107
        '
        'CHKPASS
        '
        Me.CHKPASS.AutoSize = True
        Me.CHKPASS.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.CHKPASS.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CHKPASS.Location = New System.Drawing.Point(343, 147)
        Me.CHKPASS.Name = "CHKPASS"
        Me.CHKPASS.Size = New System.Drawing.Size(117, 21)
        Me.CHKPASS.TabIndex = 99
        Me.CHKPASS.Text = "Show Password"
        Me.CHKPASS.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TXTCP)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TXTPW)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TXTUN)
        Me.GroupBox1.Controls.Add(Me.CHKPASS)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(63, 522)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(481, 174)
        Me.GroupBox1.TabIndex = 95
        Me.GroupBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel1.Location = New System.Drawing.Point(0, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(482, 10)
        Me.Panel1.TabIndex = 140
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label12.Location = New System.Drawing.Point(15, 115)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 17)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Confirm Password :"
        '
        'TXTCP
        '
        Me.TXTCP.Enabled = False
        Me.TXTCP.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.TXTCP.Location = New System.Drawing.Point(150, 112)
        Me.TXTCP.Multiline = True
        Me.TXTCP.Name = "TXTCP"
        Me.TXTCP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTCP.Size = New System.Drawing.Size(310, 20)
        Me.TXTCP.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(15, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 17)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Password :"
        '
        'TXTPW
        '
        Me.TXTPW.Enabled = False
        Me.TXTPW.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.TXTPW.Location = New System.Drawing.Point(150, 77)
        Me.TXTPW.Multiline = True
        Me.TXTPW.Name = "TXTPW"
        Me.TXTPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTPW.Size = New System.Drawing.Size(310, 20)
        Me.TXTPW.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(15, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 17)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Username :"
        '
        'TXTUN
        '
        Me.TXTUN.Enabled = False
        Me.TXTUN.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.TXTUN.Location = New System.Drawing.Point(150, 43)
        Me.TXTUN.Multiline = True
        Me.TXTUN.Name = "TXTUN"
        Me.TXTUN.Size = New System.Drawing.Size(310, 20)
        Me.TXTUN.TabIndex = 2
        '
        'TXTRI
        '
        Me.TXTRI.Enabled = False
        Me.TXTRI.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.TXTRI.Location = New System.Drawing.Point(447, 776)
        Me.TXTRI.Name = "TXTRI"
        Me.TXTRI.Size = New System.Drawing.Size(64, 22)
        Me.TXTRI.TabIndex = 91
        Me.TXTRI.Visible = False
        '
        'TXTADDRESS
        '
        Me.TXTADDRESS.Enabled = False
        Me.TXTADDRESS.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.TXTADDRESS.Location = New System.Drawing.Point(182, 446)
        Me.TXTADDRESS.Multiline = True
        Me.TXTADDRESS.Name = "TXTADDRESS"
        Me.TXTADDRESS.Size = New System.Drawing.Size(341, 50)
        Me.TXTADDRESS.TabIndex = 89
        '
        'TXTEMAIL
        '
        Me.TXTEMAIL.Enabled = False
        Me.TXTEMAIL.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.TXTEMAIL.Location = New System.Drawing.Point(182, 401)
        Me.TXTEMAIL.Multiline = True
        Me.TXTEMAIL.Name = "TXTEMAIL"
        Me.TXTEMAIL.Size = New System.Drawing.Size(341, 20)
        Me.TXTEMAIL.TabIndex = 87
        '
        'TXTTEL
        '
        Me.TXTTEL.Enabled = False
        Me.TXTTEL.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.TXTTEL.Location = New System.Drawing.Point(182, 358)
        Me.TXTTEL.Name = "TXTTEL"
        Me.TXTTEL.Size = New System.Drawing.Size(341, 22)
        Me.TXTTEL.TabIndex = 85
        '
        'TXTLN
        '
        Me.TXTLN.Enabled = False
        Me.TXTLN.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.TXTLN.Location = New System.Drawing.Point(182, 313)
        Me.TXTLN.Name = "TXTLN"
        Me.TXTLN.Size = New System.Drawing.Size(341, 22)
        Me.TXTLN.TabIndex = 83
        '
        'TXTFN
        '
        Me.TXTFN.Enabled = False
        Me.TXTFN.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.TXTFN.Location = New System.Drawing.Point(182, 233)
        Me.TXTFN.Name = "TXTFN"
        Me.TXTFN.Size = New System.Drawing.Size(341, 22)
        Me.TXTFN.TabIndex = 81
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(517, 781)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(10, 20)
        Me.ID.TabIndex = 121
        Me.ID.Visible = False
        '
        'TXTUI
        '
        Me.TXTUI.Enabled = False
        Me.TXTUI.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.TXTUI.Location = New System.Drawing.Point(182, 191)
        Me.TXTUI.Name = "TXTUI"
        Me.TXTUI.Size = New System.Drawing.Size(341, 22)
        Me.TXTUI.TabIndex = 123
        '
        'TXTNAME
        '
        Me.TXTNAME.Location = New System.Drawing.Point(533, 781)
        Me.TXTNAME.Name = "TXTNAME"
        Me.TXTNAME.Size = New System.Drawing.Size(20, 20)
        Me.TXTNAME.TabIndex = 124
        Me.TXTNAME.Visible = False
        '
        'DGVUSERS
        '
        Me.DGVUSERS.BackgroundColor = System.Drawing.Color.White
        Me.DGVUSERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVUSERS.Location = New System.Drawing.Point(576, 145)
        Me.DGVUSERS.Name = "DGVUSERS"
        Me.DGVUSERS.ReadOnly = True
        Me.DGVUSERS.RowHeadersVisible = False
        Me.DGVUSERS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVUSERS.Size = New System.Drawing.Size(692, 499)
        Me.DGVUSERS.TabIndex = 126
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BTNBACK)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1322, 49)
        Me.Panel2.TabIndex = 127
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label14.Location = New System.Drawing.Point(57, 79)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(323, 32)
        Me.Label14.TabIndex = 128
        Me.Label14.Text = "CREATE USER ACCOUNT"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label13.Location = New System.Drawing.Point(58, 276)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 17)
        Me.Label13.TabIndex = 136
        Me.Label13.Text = "Middle Name :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label17.Location = New System.Drawing.Point(56, 153)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(95, 17)
        Me.Label17.TabIndex = 135
        Me.Label17.Text = "Account Type"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label18.Location = New System.Drawing.Point(60, 446)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 17)
        Me.Label18.TabIndex = 134
        Me.Label18.Text = "Address :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label19.Location = New System.Drawing.Point(60, 404)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 17)
        Me.Label19.TabIndex = 133
        Me.Label19.Text = "E- mail :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label20.Location = New System.Drawing.Point(60, 363)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(59, 17)
        Me.Label20.TabIndex = 132
        Me.Label20.Text = "Tel No. :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label21.Location = New System.Drawing.Point(60, 318)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(85, 17)
        Me.Label21.TabIndex = 131
        Me.Label21.Text = "Last Name :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label22.Location = New System.Drawing.Point(58, 233)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(83, 17)
        Me.Label22.TabIndex = 130
        Me.Label22.Text = "First Name :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label23.Location = New System.Drawing.Point(56, 196)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(58, 17)
        Me.Label23.TabIndex = 129
        Me.Label23.Text = "User ID :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label15.Location = New System.Drawing.Point(309, 156)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 17)
        Me.Label15.TabIndex = 137
        Me.Label15.Text = "Status :"
        '
        'BTNCANCEL
        '
        Me.BTNCANCEL.BackColor = System.Drawing.Color.Gray
        Me.BTNCANCEL.Enabled = False
        Me.BTNCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCANCEL.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.BTNCANCEL.ForeColor = System.Drawing.Color.White
        Me.BTNCANCEL.Location = New System.Drawing.Point(1169, 669)
        Me.BTNCANCEL.Name = "BTNCANCEL"
        Me.BTNCANCEL.Size = New System.Drawing.Size(99, 36)
        Me.BTNCANCEL.TabIndex = 143
        Me.BTNCANCEL.Text = "Cancel"
        Me.BTNCANCEL.UseVisualStyleBackColor = False
        '
        'BTNEDIT
        '
        Me.BTNEDIT.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BTNEDIT.Enabled = False
        Me.BTNEDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNEDIT.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.BTNEDIT.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNEDIT.Location = New System.Drawing.Point(690, 669)
        Me.BTNEDIT.Name = "BTNEDIT"
        Me.BTNEDIT.Size = New System.Drawing.Size(99, 36)
        Me.BTNEDIT.TabIndex = 142
        Me.BTNEDIT.Text = "Edit"
        Me.BTNEDIT.UseVisualStyleBackColor = False
        '
        'BTNDELETE
        '
        Me.BTNDELETE.BackColor = System.Drawing.Color.Gray
        Me.BTNDELETE.Enabled = False
        Me.BTNDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNDELETE.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.BTNDELETE.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNDELETE.Location = New System.Drawing.Point(1055, 669)
        Me.BTNDELETE.Name = "BTNDELETE"
        Me.BTNDELETE.Size = New System.Drawing.Size(99, 36)
        Me.BTNDELETE.TabIndex = 141
        Me.BTNDELETE.Text = "Delete"
        Me.BTNDELETE.UseVisualStyleBackColor = False
        '
        'BTNSAVE
        '
        Me.BTNSAVE.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BTNSAVE.Enabled = False
        Me.BTNSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSAVE.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.BTNSAVE.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNSAVE.Location = New System.Drawing.Point(576, 669)
        Me.BTNSAVE.Name = "BTNSAVE"
        Me.BTNSAVE.Size = New System.Drawing.Size(99, 36)
        Me.BTNSAVE.TabIndex = 140
        Me.BTNSAVE.Text = "Save"
        Me.BTNSAVE.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(711, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 17)
        Me.Label1.TabIndex = 144
        Me.Label1.Text = "Search Username :"
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
        Me.BTNBACK.TabIndex = 3
        Me.BTNBACK.Text = " Back"
        Me.BTNBACK.UseVisualStyleBackColor = False
        '
        'ucUSERMANAGEMENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNCANCEL)
        Me.Controls.Add(Me.BTNEDIT)
        Me.Controls.Add(Me.BTNDELETE)
        Me.Controls.Add(Me.BTNSAVE)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DGVUSERS)
        Me.Controls.Add(Me.TXTNAME)
        Me.Controls.Add(Me.TXTUI)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.TXTMN)
        Me.Controls.Add(Me.CBOSTATUS)
        Me.Controls.Add(Me.CBOACCTYPE)
        Me.Controls.Add(Me.TXTDUN)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TXTRI)
        Me.Controls.Add(Me.TXTADDRESS)
        Me.Controls.Add(Me.TXTEMAIL)
        Me.Controls.Add(Me.TXTTEL)
        Me.Controls.Add(Me.TXTLN)
        Me.Controls.Add(Me.TXTFN)
        Me.Location = New System.Drawing.Point(299, 32)
        Me.Name = "ucUSERMANAGEMENT"
        Me.Size = New System.Drawing.Size(1322, 801)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVUSERS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXTMN As TextBox
    Friend WithEvents CBOSTATUS As ComboBox
    Friend WithEvents CBOACCTYPE As ComboBox
    Friend WithEvents TXTDUN As TextBox
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents CHKPASS As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TXTCP As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TXTPW As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TXTUN As TextBox
    Friend WithEvents TXTRI As TextBox
    Friend WithEvents TXTADDRESS As TextBox
    Friend WithEvents TXTEMAIL As TextBox
    Friend WithEvents TXTTEL As TextBox
    Friend WithEvents TXTLN As TextBox
    Friend WithEvents TXTFN As TextBox
    Friend WithEvents ID As TextBox
    Friend WithEvents TXTUI As TextBox
    Friend WithEvents TXTNAME As TextBox
    Friend WithEvents DGVUSERS As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BTNBACK As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTNCANCEL As Button
    Friend WithEvents BTNEDIT As Button
    Friend WithEvents BTNDELETE As Button
    Friend WithEvents BTNSAVE As Button
    Friend WithEvents Label1 As Label
End Class
