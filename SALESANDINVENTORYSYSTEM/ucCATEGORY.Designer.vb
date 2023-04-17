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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TXTID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTCATNAME = New System.Windows.Forms.TextBox()
        Me.TXTCATCODE = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BTNBACK = New System.Windows.Forms.Button()
        Me.BTNADD = New System.Windows.Forms.Button()
        Me.BTNINSERT = New System.Windows.Forms.Button()
        Me.BTNUPDATE = New System.Windows.Forms.Button()
        Me.BTNDELETE = New System.Windows.Forms.Button()
        Me.DGVPRODUCTS = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2.SuspendLayout()
        CType(Me.DGVPRODUCTS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(630, 630)
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
        Me.Label2.Location = New System.Drawing.Point(32, 136)
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
        Me.Label1.Location = New System.Drawing.Point(35, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 17)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Category Code"
        '
        'TXTCATNAME
        '
        Me.TXTCATNAME.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCATNAME.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTCATNAME.Location = New System.Drawing.Point(185, 136)
        Me.TXTCATNAME.Name = "TXTCATNAME"
        Me.TXTCATNAME.Size = New System.Drawing.Size(244, 23)
        Me.TXTCATNAME.TabIndex = 73
        '
        'TXTCATCODE
        '
        Me.TXTCATCODE.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCATCODE.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTCATCODE.Location = New System.Drawing.Point(185, 71)
        Me.TXTCATCODE.Name = "TXTCATCODE"
        Me.TXTCATCODE.Size = New System.Drawing.Size(244, 23)
        Me.TXTCATCODE.TabIndex = 72
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label11.Location = New System.Drawing.Point(57, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(139, 32)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "Category"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BTNBACK)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1322, 49)
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
        Me.BTNBACK.Location = New System.Drawing.Point(1197, 3)
        Me.BTNBACK.Name = "BTNBACK"
        Me.BTNBACK.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.BTNBACK.Size = New System.Drawing.Size(119, 46)
        Me.BTNBACK.TabIndex = 3
        Me.BTNBACK.Text = " Back"
        Me.BTNBACK.UseVisualStyleBackColor = False
        '
        'BTNADD
        '
        Me.BTNADD.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BTNADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNADD.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.BTNADD.ForeColor = System.Drawing.Color.Snow
        Me.BTNADD.Location = New System.Drawing.Point(65, 233)
        Me.BTNADD.Name = "BTNADD"
        Me.BTNADD.Size = New System.Drawing.Size(99, 36)
        Me.BTNADD.TabIndex = 40
        Me.BTNADD.Text = "Add"
        Me.BTNADD.UseVisualStyleBackColor = False
        '
        'BTNINSERT
        '
        Me.BTNINSERT.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BTNINSERT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNINSERT.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.BTNINSERT.ForeColor = System.Drawing.Color.Snow
        Me.BTNINSERT.Location = New System.Drawing.Point(206, 233)
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
        Me.BTNUPDATE.Location = New System.Drawing.Point(342, 233)
        Me.BTNUPDATE.Name = "BTNUPDATE"
        Me.BTNUPDATE.Size = New System.Drawing.Size(99, 36)
        Me.BTNUPDATE.TabIndex = 38
        Me.BTNUPDATE.Text = "Update"
        Me.BTNUPDATE.UseVisualStyleBackColor = False
        '
        'BTNDELETE
        '
        Me.BTNDELETE.BackColor = System.Drawing.Color.IndianRed
        Me.BTNDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNDELETE.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.BTNDELETE.ForeColor = System.Drawing.Color.Snow
        Me.BTNDELETE.Location = New System.Drawing.Point(65, 295)
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
        Me.DGVPRODUCTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPRODUCTS.Location = New System.Drawing.Point(719, 140)
        Me.DGVPRODUCTS.Name = "DGVPRODUCTS"
        Me.DGVPRODUCTS.ReadOnly = True
        Me.DGVPRODUCTS.RowHeadersVisible = False
        Me.DGVPRODUCTS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVPRODUCTS.Size = New System.Drawing.Size(423, 565)
        Me.DGVPRODUCTS.TabIndex = 76
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
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
        Me.GroupBox1.Location = New System.Drawing.Point(79, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(494, 565)
        Me.GroupBox1.TabIndex = 77
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add category"
        '
        'ucCATEGORY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TXTID)
        Me.Controls.Add(Me.DGVPRODUCTS)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label11)
        Me.Name = "ucCATEGORY"
        Me.Size = New System.Drawing.Size(1322, 801)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DGVPRODUCTS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents BTNADD As Button
    Friend WithEvents BTNINSERT As Button
    Friend WithEvents BTNUPDATE As Button
    Friend WithEvents BTNDELETE As Button
    Friend WithEvents DGVPRODUCTS As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
End Class
