<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucPRODUCTLIST
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucPRODUCTLIST))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BTNRD = New System.Windows.Forms.Button()
        Me.BTNEP = New System.Windows.Forms.Button()
        Me.BTNOS = New System.Windows.Forms.Button()
        Me.BTNLOW = New System.Windows.Forms.Button()
        Me.BTNSTOCKS = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTSEARCH = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DGVPRODLIST = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.DGVPRODLIST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BTNRD)
        Me.Panel2.Controls.Add(Me.BTNEP)
        Me.Panel2.Controls.Add(Me.BTNOS)
        Me.Panel2.Controls.Add(Me.BTNLOW)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1091, 49)
        Me.Panel2.TabIndex = 49
        '
        'BTNRD
        '
        Me.BTNRD.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BTNRD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTNRD.FlatAppearance.BorderSize = 0
        Me.BTNRD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNRD.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNRD.ForeColor = System.Drawing.Color.White
        Me.BTNRD.Image = CType(resources.GetObject("BTNRD.Image"), System.Drawing.Image)
        Me.BTNRD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNRD.Location = New System.Drawing.Point(629, 3)
        Me.BTNRD.Name = "BTNRD"
        Me.BTNRD.Size = New System.Drawing.Size(151, 46)
        Me.BTNRD.TabIndex = 75
        Me.BTNRD.Text = "Nearly-Expired"
        Me.BTNRD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNRD.UseVisualStyleBackColor = False
        '
        'BTNEP
        '
        Me.BTNEP.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BTNEP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTNEP.FlatAppearance.BorderSize = 0
        Me.BTNEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNEP.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNEP.ForeColor = System.Drawing.Color.White
        Me.BTNEP.Image = CType(resources.GetObject("BTNEP.Image"), System.Drawing.Image)
        Me.BTNEP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNEP.Location = New System.Drawing.Point(836, 3)
        Me.BTNEP.Name = "BTNEP"
        Me.BTNEP.Size = New System.Drawing.Size(162, 46)
        Me.BTNEP.TabIndex = 74
        Me.BTNEP.Text = "Expired products"
        Me.BTNEP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNEP.UseVisualStyleBackColor = False
        '
        'BTNOS
        '
        Me.BTNOS.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BTNOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTNOS.FlatAppearance.BorderSize = 0
        Me.BTNOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNOS.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNOS.ForeColor = System.Drawing.Color.White
        Me.BTNOS.Image = CType(resources.GetObject("BTNOS.Image"), System.Drawing.Image)
        Me.BTNOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNOS.Location = New System.Drawing.Point(412, 3)
        Me.BTNOS.Name = "BTNOS"
        Me.BTNOS.Size = New System.Drawing.Size(151, 46)
        Me.BTNOS.TabIndex = 73
        Me.BTNOS.Text = "Out of stocks"
        Me.BTNOS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNOS.UseVisualStyleBackColor = False
        '
        'BTNLOW
        '
        Me.BTNLOW.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BTNLOW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTNLOW.FlatAppearance.BorderSize = 0
        Me.BTNLOW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNLOW.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLOW.ForeColor = System.Drawing.Color.White
        Me.BTNLOW.Image = CType(resources.GetObject("BTNLOW.Image"), System.Drawing.Image)
        Me.BTNLOW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNLOW.Location = New System.Drawing.Point(166, 3)
        Me.BTNLOW.Name = "BTNLOW"
        Me.BTNLOW.Size = New System.Drawing.Size(191, 46)
        Me.BTNLOW.TabIndex = 72
        Me.BTNLOW.Text = "    Running out of stocks"
        Me.BTNLOW.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNLOW.UseVisualStyleBackColor = False
        '
        'BTNSTOCKS
        '
        Me.BTNSTOCKS.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BTNSTOCKS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTNSTOCKS.FlatAppearance.BorderSize = 0
        Me.BTNSTOCKS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSTOCKS.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSTOCKS.ForeColor = System.Drawing.Color.White
        Me.BTNSTOCKS.Image = CType(resources.GetObject("BTNSTOCKS.Image"), System.Drawing.Image)
        Me.BTNSTOCKS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNSTOCKS.Location = New System.Drawing.Point(0, 0)
        Me.BTNSTOCKS.Name = "BTNSTOCKS"
        Me.BTNSTOCKS.Size = New System.Drawing.Size(114, 46)
        Me.BTNSTOCKS.TabIndex = 60
        Me.BTNSTOCKS.Text = "Stock List"
        Me.BTNSTOCKS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNSTOCKS.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label1.Location = New System.Drawing.Point(21, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 32)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "PRODUCT LIST"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(632, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 21)
        Me.Label2.TabIndex = 135
        Me.Label2.Text = "Search Product :"
        '
        'TXTSEARCH
        '
        Me.TXTSEARCH.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTSEARCH.DefaultText = ""
        Me.TXTSEARCH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTSEARCH.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTSEARCH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTSEARCH.DisabledState.Parent = Me.TXTSEARCH
        Me.TXTSEARCH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTSEARCH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTSEARCH.FocusedState.Parent = Me.TXTSEARCH
        Me.TXTSEARCH.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSEARCH.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTSEARCH.HoverState.Parent = Me.TXTSEARCH
        Me.TXTSEARCH.Location = New System.Drawing.Point(777, 100)
        Me.TXTSEARCH.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXTSEARCH.Name = "TXTSEARCH"
        Me.TXTSEARCH.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTSEARCH.PlaceholderText = ""
        Me.TXTSEARCH.SelectedText = ""
        Me.TXTSEARCH.ShadowDecoration.Parent = Me.TXTSEARCH
        Me.TXTSEARCH.Size = New System.Drawing.Size(293, 27)
        Me.TXTSEARCH.TabIndex = 134
        '
        'DGVPRODLIST
        '
        Me.DGVPRODLIST.AllowUserToAddRows = False
        Me.DGVPRODLIST.AllowUserToDeleteRows = False
        Me.DGVPRODLIST.BackgroundColor = System.Drawing.Color.White
        Me.DGVPRODLIST.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVPRODLIST.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVPRODLIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVPRODLIST.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVPRODLIST.Location = New System.Drawing.Point(27, 150)
        Me.DGVPRODLIST.Name = "DGVPRODLIST"
        Me.DGVPRODLIST.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVPRODLIST.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVPRODLIST.RowHeadersVisible = False
        Me.DGVPRODLIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVPRODLIST.Size = New System.Drawing.Size(1043, 521)
        Me.DGVPRODLIST.TabIndex = 133
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(939, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 17)
        Me.Label4.TabIndex = 132
        '
        'ucPRODUCTLIST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTSEARCH)
        Me.Controls.Add(Me.DGVPRODLIST)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BTNSTOCKS)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ucPRODUCTLIST"
        Me.Size = New System.Drawing.Size(1091, 729)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DGVPRODLIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BTNSTOCKS As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BTNOS As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTSEARCH As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DGVPRODLIST As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents BTNRD As Button
    Friend WithEvents BTNEP As Button
    Friend WithEvents BTNLOW As Button
End Class
