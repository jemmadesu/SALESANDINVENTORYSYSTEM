<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMANUFACTURER
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucMANUFACTURER))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTSEARCH = New System.Windows.Forms.TextBox()
        Me.DGVMANUFACTURER = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBOSTATUS = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTNUPDATE = New System.Windows.Forms.Button()
        Me.BTNSAVE = New System.Windows.Forms.Button()
        Me.TXTMANU = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BTNBACK = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGVMANUFACTURER, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TXTSEARCH)
        Me.GroupBox2.Controls.Add(Me.DGVMANUFACTURER)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox2.Location = New System.Drawing.Point(563, 108)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(483, 562)
        Me.GroupBox2.TabIndex = 85
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Manufacturer List"
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
        'DGVMANUFACTURER
        '
        Me.DGVMANUFACTURER.AllowUserToAddRows = False
        Me.DGVMANUFACTURER.AllowUserToDeleteRows = False
        Me.DGVMANUFACTURER.BackgroundColor = System.Drawing.Color.White
        Me.DGVMANUFACTURER.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVMANUFACTURER.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVMANUFACTURER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVMANUFACTURER.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVMANUFACTURER.Location = New System.Drawing.Point(41, 71)
        Me.DGVMANUFACTURER.Name = "DGVMANUFACTURER"
        Me.DGVMANUFACTURER.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVMANUFACTURER.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVMANUFACTURER.RowHeadersVisible = False
        Me.DGVMANUFACTURER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVMANUFACTURER.Size = New System.Drawing.Size(402, 474)
        Me.DGVMANUFACTURER.TabIndex = 76
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.CBOSTATUS)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BTNUPDATE)
        Me.GroupBox1.Controls.Add(Me.BTNSAVE)
        Me.GroupBox1.Controls.Add(Me.TXTMANU)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(46, 157)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(499, 513)
        Me.GroupBox1.TabIndex = 84
        Me.GroupBox1.TabStop = False
        '
        'CBOSTATUS
        '
        Me.CBOSTATUS.ForeColor = System.Drawing.Color.DimGray
        Me.CBOSTATUS.FormattingEnabled = True
        Me.CBOSTATUS.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.CBOSTATUS.Location = New System.Drawing.Point(170, 112)
        Me.CBOSTATUS.Name = "CBOSTATUS"
        Me.CBOSTATUS.Size = New System.Drawing.Size(300, 25)
        Me.CBOSTATUS.TabIndex = 75
        Me.CBOSTATUS.Text = "-- Select --"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(20, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(20, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Manufacturer"
        '
        'BTNUPDATE
        '
        Me.BTNUPDATE.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BTNUPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNUPDATE.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.BTNUPDATE.ForeColor = System.Drawing.Color.Snow
        Me.BTNUPDATE.Location = New System.Drawing.Point(371, 179)
        Me.BTNUPDATE.Name = "BTNUPDATE"
        Me.BTNUPDATE.Size = New System.Drawing.Size(99, 36)
        Me.BTNUPDATE.TabIndex = 38
        Me.BTNUPDATE.Text = "Edit"
        Me.BTNUPDATE.UseVisualStyleBackColor = False
        '
        'BTNSAVE
        '
        Me.BTNSAVE.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BTNSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSAVE.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.BTNSAVE.ForeColor = System.Drawing.Color.Snow
        Me.BTNSAVE.Location = New System.Drawing.Point(257, 179)
        Me.BTNSAVE.Name = "BTNSAVE"
        Me.BTNSAVE.Size = New System.Drawing.Size(99, 36)
        Me.BTNSAVE.TabIndex = 39
        Me.BTNSAVE.Text = "Save"
        Me.BTNSAVE.UseVisualStyleBackColor = False
        '
        'TXTMANU
        '
        Me.TXTMANU.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMANU.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TXTMANU.Location = New System.Drawing.Point(170, 51)
        Me.TXTMANU.Name = "TXTMANU"
        Me.TXTMANU.Size = New System.Drawing.Size(300, 23)
        Me.TXTMANU.TabIndex = 73
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label11.Location = New System.Drawing.Point(40, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(226, 32)
        Me.Label11.TabIndex = 83
        Me.Label11.Text = "MANUFACTURER"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BTNBACK)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1091, 49)
        Me.Panel2.TabIndex = 82
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
        'ucMANUFACTURER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "ucMANUFACTURER"
        Me.Size = New System.Drawing.Size(1091, 729)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGVMANUFACTURER, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTSEARCH As TextBox
    Friend WithEvents DGVMANUFACTURER As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CBOSTATUS As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BTNUPDATE As Button
    Friend WithEvents BTNSAVE As Button
    Friend WithEvents TXTMANU As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BTNBACK As Button
End Class
