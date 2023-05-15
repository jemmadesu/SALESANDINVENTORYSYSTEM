<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucSETTINGS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucSETTINGS))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BTNUM = New System.Windows.Forms.Button()
        Me.BTNSTOCKIN = New System.Windows.Forms.Button()
        Me.BTNINVENTORY = New System.Windows.Forms.Button()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.BTNRESTORE = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNBACKUP = New Guna.UI2.WinForms.Guna2Button()
        Me.LBLHISTORY = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PNLHISTORY = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBLCLOSE = New System.Windows.Forms.PictureBox()
        Me.DGVHISTORY = New System.Windows.Forms.DataGridView()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Panel2.SuspendLayout()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.PNLHISTORY.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.LBLCLOSE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVHISTORY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BTNUM)
        Me.Panel2.Controls.Add(Me.BTNSTOCKIN)
        Me.Panel2.Controls.Add(Me.BTNINVENTORY)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1091, 49)
        Me.Panel2.TabIndex = 44
        '
        'BTNUM
        '
        Me.BTNUM.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BTNUM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTNUM.FlatAppearance.BorderSize = 0
        Me.BTNUM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNUM.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNUM.ForeColor = System.Drawing.Color.White
        Me.BTNUM.Image = CType(resources.GetObject("BTNUM.Image"), System.Drawing.Image)
        Me.BTNUM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNUM.Location = New System.Drawing.Point(531, -6)
        Me.BTNUM.Name = "BTNUM"
        Me.BTNUM.Size = New System.Drawing.Size(174, 52)
        Me.BTNUM.TabIndex = 47
        Me.BTNUM.Text = "User Management" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BTNUM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNUM.UseVisualStyleBackColor = False
        '
        'BTNSTOCKIN
        '
        Me.BTNSTOCKIN.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BTNSTOCKIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTNSTOCKIN.FlatAppearance.BorderSize = 0
        Me.BTNSTOCKIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSTOCKIN.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSTOCKIN.ForeColor = System.Drawing.Color.White
        Me.BTNSTOCKIN.Image = CType(resources.GetObject("BTNSTOCKIN.Image"), System.Drawing.Image)
        Me.BTNSTOCKIN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNSTOCKIN.Location = New System.Drawing.Point(282, -3)
        Me.BTNSTOCKIN.Name = "BTNSTOCKIN"
        Me.BTNSTOCKIN.Size = New System.Drawing.Size(210, 49)
        Me.BTNSTOCKIN.TabIndex = 49
        Me.BTNSTOCKIN.Text = "Delivery Management"
        Me.BTNSTOCKIN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNSTOCKIN.UseVisualStyleBackColor = False
        '
        'BTNINVENTORY
        '
        Me.BTNINVENTORY.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BTNINVENTORY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTNINVENTORY.FlatAppearance.BorderSize = 0
        Me.BTNINVENTORY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNINVENTORY.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNINVENTORY.ForeColor = System.Drawing.Color.White
        Me.BTNINVENTORY.Image = CType(resources.GetObject("BTNINVENTORY.Image"), System.Drawing.Image)
        Me.BTNINVENTORY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNINVENTORY.Location = New System.Drawing.Point(49, -3)
        Me.BTNINVENTORY.Name = "BTNINVENTORY"
        Me.BTNINVENTORY.Size = New System.Drawing.Size(207, 49)
        Me.BTNINVENTORY.TabIndex = 49
        Me.BTNINVENTORY.Text = "Product Management"
        Me.BTNINVENTORY.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNINVENTORY.UseVisualStyleBackColor = False
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.BTNRESTORE)
        Me.Guna2ShadowPanel1.Controls.Add(Me.BTNBACKUP)
        Me.Guna2ShadowPanel1.Controls.Add(Me.LBLHISTORY)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(515, 98)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(495, 550)
        Me.Guna2ShadowPanel1.TabIndex = 46
        '
        'BTNRESTORE
        '
        Me.BTNRESTORE.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BTNRESTORE.CheckedState.Parent = Me.BTNRESTORE
        Me.BTNRESTORE.CustomImages.Parent = Me.BTNRESTORE
        Me.BTNRESTORE.FillColor = System.Drawing.Color.LightGray
        Me.BTNRESTORE.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNRESTORE.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BTNRESTORE.HoverState.Parent = Me.BTNRESTORE
        Me.BTNRESTORE.Image = CType(resources.GetObject("BTNRESTORE.Image"), System.Drawing.Image)
        Me.BTNRESTORE.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BTNRESTORE.ImageSize = New System.Drawing.Size(50, 45)
        Me.BTNRESTORE.Location = New System.Drawing.Point(58, 183)
        Me.BTNRESTORE.Name = "BTNRESTORE"
        Me.BTNRESTORE.ShadowDecoration.Parent = Me.BTNRESTORE
        Me.BTNRESTORE.Size = New System.Drawing.Size(352, 83)
        Me.BTNRESTORE.TabIndex = 52
        Me.BTNRESTORE.Text = "Restore"
        Me.BTNRESTORE.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTNBACKUP
        '
        Me.BTNBACKUP.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BTNBACKUP.CheckedState.Parent = Me.BTNBACKUP
        Me.BTNBACKUP.CustomImages.Parent = Me.BTNBACKUP
        Me.BTNBACKUP.FillColor = System.Drawing.Color.LightGray
        Me.BTNBACKUP.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNBACKUP.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BTNBACKUP.HoverState.Parent = Me.BTNBACKUP
        Me.BTNBACKUP.Image = CType(resources.GetObject("BTNBACKUP.Image"), System.Drawing.Image)
        Me.BTNBACKUP.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BTNBACKUP.ImageSize = New System.Drawing.Size(50, 45)
        Me.BTNBACKUP.Location = New System.Drawing.Point(58, 73)
        Me.BTNBACKUP.Name = "BTNBACKUP"
        Me.BTNBACKUP.ShadowDecoration.Parent = Me.BTNBACKUP
        Me.BTNBACKUP.Size = New System.Drawing.Size(352, 83)
        Me.BTNBACKUP.TabIndex = 51
        Me.BTNBACKUP.Text = "Create Backup"
        Me.BTNBACKUP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'LBLHISTORY
        '
        Me.LBLHISTORY.AutoSize = True
        Me.LBLHISTORY.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LBLHISTORY.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLHISTORY.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.LBLHISTORY.Location = New System.Drawing.Point(281, 285)
        Me.LBLHISTORY.Name = "LBLHISTORY"
        Me.LBLHISTORY.Size = New System.Drawing.Size(129, 20)
        Me.LBLHISTORY.TabIndex = 49
        Me.LBLHISTORY.Text = "Backup Records"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(76, 370)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 33)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "BACKUP AND RESTORE"
        '
        'PNLHISTORY
        '
        Me.PNLHISTORY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PNLHISTORY.Controls.Add(Me.Panel1)
        Me.PNLHISTORY.Controls.Add(Me.DGVHISTORY)
        Me.PNLHISTORY.Location = New System.Drawing.Point(484, 406)
        Me.PNLHISTORY.Name = "PNLHISTORY"
        Me.PNLHISTORY.Size = New System.Drawing.Size(441, 264)
        Me.PNLHISTORY.TabIndex = 53
        Me.PNLHISTORY.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.LBLCLOSE)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(439, 45)
        Me.Panel1.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(18, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 17)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Backup History"
        '
        'LBLCLOSE
        '
        Me.LBLCLOSE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LBLCLOSE.Image = Global.SALESANDINVENTORYSYSTEM.My.Resources.Resources.x_mark_64__1_
        Me.LBLCLOSE.Location = New System.Drawing.Point(403, 15)
        Me.LBLCLOSE.Name = "LBLCLOSE"
        Me.LBLCLOSE.Size = New System.Drawing.Size(15, 17)
        Me.LBLCLOSE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LBLCLOSE.TabIndex = 57
        Me.LBLCLOSE.TabStop = False
        '
        'DGVHISTORY
        '
        Me.DGVHISTORY.AllowUserToAddRows = False
        Me.DGVHISTORY.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DGVHISTORY.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVHISTORY.BackgroundColor = System.Drawing.Color.White
        Me.DGVHISTORY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVHISTORY.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DGVHISTORY.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVHISTORY.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVHISTORY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVHISTORY.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVHISTORY.Enabled = False
        Me.DGVHISTORY.GridColor = System.Drawing.Color.DimGray
        Me.DGVHISTORY.Location = New System.Drawing.Point(-1, 51)
        Me.DGVHISTORY.Name = "DGVHISTORY"
        Me.DGVHISTORY.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVHISTORY.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGVHISTORY.RowHeadersVisible = False
        Me.DGVHISTORY.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DGVHISTORY.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DGVHISTORY.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGVHISTORY.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVHISTORY.Size = New System.Drawing.Size(441, 208)
        Me.DGVHISTORY.TabIndex = 56
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(138, 181)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(175, 166)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 51
        Me.Guna2PictureBox1.TabStop = False
        '
        'ucSETTINGS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PNLHISTORY)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "ucSETTINGS"
        Me.Size = New System.Drawing.Size(1091, 729)
        Me.Panel2.ResumeLayout(False)
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        Me.PNLHISTORY.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.LBLCLOSE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVHISTORY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents LBLHISTORY As Label
    Friend WithEvents BTNUM As Button
    Friend WithEvents BTNINVENTORY As Button
    Friend WithEvents BTNSTOCKIN As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BTNBACKUP As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNRESTORE As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PNLHISTORY As Panel
    Friend WithEvents DGVHISTORY As DataGridView
    Friend WithEvents LBLCLOSE As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
End Class
