<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucCATEGORY
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucCATEGORY))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TXTID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTCATNAME = New System.Windows.Forms.TextBox()
        Me.TXTCATCODE = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BTNBACK = New System.Windows.Forms.Button()
        Me.BTNINSERT = New System.Windows.Forms.Button()
        Me.BTNUPDATE = New System.Windows.Forms.Button()
        Me.BTNDELETE = New System.Windows.Forms.Button()
        Me.DGVPRODUCTS = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTNADD = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTSEARCH = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel2.SuspendLayout()
        CType(Me.DGVPRODUCTS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(606, 632)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(8, 8)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TXTID
        '
        Me.TXTID.Location = New System.Drawing.Point(30, 742)
        Me.TXTID.Name = "TXTID"
        Me.TXTID.Size = New System.Drawing.Size(100, 20)
        Me.TXTID.TabIndex = 34
        Me.TXTID.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(17, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 17)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Category Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(20, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 17)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Category Code"
        '
        'TXTCATNAME
        '
        Me.TXTCATNAME.Enabled = False
        Me.TXTCATNAME.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCATNAME.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTCATNAME.Location = New System.Drawing.Point(170, 105)
        Me.TXTCATNAME.Name = "TXTCATNAME"
        Me.TXTCATNAME.Size = New System.Drawing.Size(300, 23)
        Me.TXTCATNAME.TabIndex = 73
        '
        'TXTCATCODE
        '
        Me.TXTCATCODE.Enabled = False
        Me.TXTCATCODE.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCATCODE.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTCATCODE.Location = New System.Drawing.Point(170, 40)
        Me.TXTCATCODE.Name = "TXTCATCODE"
        Me.TXTCATCODE.Size = New System.Drawing.Size(300, 23)
        Me.TXTCATCODE.TabIndex = 72
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label11.Location = New System.Drawing.Point(49, 81)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(358, 32)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "CATEGORY MANAGEMENT"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BTNBACK)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1091, 49)
        Me.Panel2.TabIndex = 75
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
        Me.BTNBACK.Location = New System.Drawing.Point(960, 3)
        Me.BTNBACK.Name = "BTNBACK"
        Me.BTNBACK.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.BTNBACK.Size = New System.Drawing.Size(119, 46)
        Me.BTNBACK.TabIndex = 3
        Me.BTNBACK.Text = " Back"
        Me.BTNBACK.UseVisualStyleBackColor = False
        '
        'BTNINSERT
        '
        Me.BTNINSERT.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BTNINSERT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNINSERT.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.BTNINSERT.ForeColor = System.Drawing.Color.Snow
        Me.BTNINSERT.Location = New System.Drawing.Point(371, 161)
        Me.BTNINSERT.Name = "BTNINSERT"
        Me.BTNINSERT.Size = New System.Drawing.Size(99, 36)
        Me.BTNINSERT.TabIndex = 39
        Me.BTNINSERT.Text = "Save"
        Me.BTNINSERT.UseVisualStyleBackColor = False
        '
        'BTNUPDATE
        '
        Me.BTNUPDATE.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BTNUPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNUPDATE.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.BTNUPDATE.ForeColor = System.Drawing.Color.Snow
        Me.BTNUPDATE.Location = New System.Drawing.Point(244, 203)
        Me.BTNUPDATE.Name = "BTNUPDATE"
        Me.BTNUPDATE.Size = New System.Drawing.Size(99, 36)
        Me.BTNUPDATE.TabIndex = 38
        Me.BTNUPDATE.Text = "Update"
        Me.BTNUPDATE.UseVisualStyleBackColor = False
        '
        'BTNDELETE
        '
        Me.BTNDELETE.BackColor = System.Drawing.Color.Gray
        Me.BTNDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNDELETE.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.BTNDELETE.ForeColor = System.Drawing.Color.Snow
        Me.BTNDELETE.Location = New System.Drawing.Point(371, 203)
        Me.BTNDELETE.Name = "BTNDELETE"
        Me.BTNDELETE.Size = New System.Drawing.Size(99, 36)
        Me.BTNDELETE.TabIndex = 37
        Me.BTNDELETE.Text = "Delete"
        Me.BTNDELETE.UseVisualStyleBackColor = False
        '
        'DGVPRODUCTS
        '
        Me.DGVPRODUCTS.AllowUserToAddRows = False
        Me.DGVPRODUCTS.AllowUserToDeleteRows = False
        Me.DGVPRODUCTS.BackgroundColor = System.Drawing.Color.White
        Me.DGVPRODUCTS.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
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
        Me.DGVPRODUCTS.Location = New System.Drawing.Point(41, 71)
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
        Me.DGVPRODUCTS.Size = New System.Drawing.Size(402, 474)
        Me.DGVPRODUCTS.TabIndex = 76
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.TXTCATCODE)
        Me.GroupBox1.Controls.Add(Me.BTNADD)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BTNUPDATE)
        Me.GroupBox1.Controls.Add(Me.BTNINSERT)
        Me.GroupBox1.Controls.Add(Me.TXTCATNAME)
        Me.GroupBox1.Controls.Add(Me.BTNDELETE)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(55, 142)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(499, 295)
        Me.GroupBox1.TabIndex = 77
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add category"
        '
        'BTNADD
        '
        Me.BTNADD.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BTNADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNADD.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.BTNADD.ForeColor = System.Drawing.Color.Snow
        Me.BTNADD.Location = New System.Drawing.Point(244, 161)
        Me.BTNADD.Name = "BTNADD"
        Me.BTNADD.Size = New System.Drawing.Size(99, 36)
        Me.BTNADD.TabIndex = 40
        Me.BTNADD.Text = "Add"
        Me.BTNADD.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TXTSEARCH)
        Me.GroupBox2.Controls.Add(Me.DGVPRODUCTS)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox2.Location = New System.Drawing.Point(572, 93)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(483, 562)
        Me.GroupBox2.TabIndex = 78
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Category List"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 17)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Search Category Name:"
        '
        'TXTSEARCH
        '
        Me.TXTSEARCH.Location = New System.Drawing.Point(263, 37)
        Me.TXTSEARCH.Name = "TXTSEARCH"
        Me.TXTSEARCH.Size = New System.Drawing.Size(180, 23)
        Me.TXTSEARCH.TabIndex = 77
        '
        'ucCATEGORY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TXTID)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label11)
        Me.Name = "ucCATEGORY"
        Me.Size = New System.Drawing.Size(1091, 729)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DGVPRODUCTS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents TXTID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTCATNAME As TextBox
    Friend WithEvents TXTCATCODE As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BTNBACK As Button
    Friend WithEvents BTNINSERT As Button
    Friend WithEvents BTNUPDATE As Button
    Friend WithEvents BTNDELETE As Button
    Friend WithEvents DGVPRODUCTS As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTSEARCH As TextBox
    Friend WithEvents BTNADD As Button
End Class
