<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucDASHBOARD
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucDASHBOARD))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.LBLYEAR = New System.Windows.Forms.Label()
        Me.LBLDATE = New System.Windows.Forms.Label()
        Me.LBLDAY = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblsales = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblexp = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.lblproducts = New System.Windows.Forms.Label()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CHART = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Inventory_dbDataSet = New SALESANDINVENTORYSYSTEM.inventory_dbDataSet()
        Me.Tbl_usersTableAdapter = New SALESANDINVENTORYSYSTEM.inventory_dbDataSetTableAdapters.tbl_usersTableAdapter()
        Me.TblusersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DGVUSERS = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsertypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LBLMONTH = New System.Windows.Forms.Label()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CHART, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventory_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblusersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVUSERS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Controls.Add(Me.LBLYEAR)
        Me.Panel7.Controls.Add(Me.LBLDATE)
        Me.Panel7.Controls.Add(Me.LBLDAY)
        Me.Panel7.Location = New System.Drawing.Point(1015, 75)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(267, 228)
        Me.Panel7.TabIndex = 41
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel8.Location = New System.Drawing.Point(0, 218)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(267, 10)
        Me.Panel8.TabIndex = 1
        '
        'LBLYEAR
        '
        Me.LBLYEAR.AutoSize = True
        Me.LBLYEAR.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLYEAR.ForeColor = System.Drawing.Color.Black
        Me.LBLYEAR.Location = New System.Drawing.Point(96, 185)
        Me.LBLYEAR.Name = "LBLYEAR"
        Me.LBLYEAR.Size = New System.Drawing.Size(47, 21)
        Me.LBLYEAR.TabIndex = 3
        Me.LBLYEAR.Text = "Year"
        '
        'LBLDATE
        '
        Me.LBLDATE.AutoSize = True
        Me.LBLDATE.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDATE.ForeColor = System.Drawing.Color.Black
        Me.LBLDATE.Location = New System.Drawing.Point(62, 106)
        Me.LBLDATE.Name = "LBLDATE"
        Me.LBLDATE.Size = New System.Drawing.Size(135, 56)
        Me.LBLDATE.TabIndex = 2
        Me.LBLDATE.Text = "Date"
        '
        'LBLDAY
        '
        Me.LBLDAY.AutoSize = True
        Me.LBLDAY.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDAY.ForeColor = System.Drawing.Color.Black
        Me.LBLDAY.Location = New System.Drawing.Point(106, 63)
        Me.LBLDAY.Name = "LBLDAY"
        Me.LBLDAY.Size = New System.Drawing.Size(41, 21)
        Me.LBLDAY.TabIndex = 1
        Me.LBLDAY.Text = "Day"
        '
        'Panel6
        '
        Me.Panel6.Location = New System.Drawing.Point(40, 498)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(953, 228)
        Me.Panel6.TabIndex = 40
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.lblsales)
        Me.Panel5.Controls.Add(Me.PictureBox5)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Location = New System.Drawing.Point(761, 78)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(232, 81)
        Me.Panel5.TabIndex = 37
        '
        'lblsales
        '
        Me.lblsales.AutoSize = True
        Me.lblsales.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsales.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblsales.Location = New System.Drawing.Point(82, 40)
        Me.lblsales.Name = "lblsales"
        Me.lblsales.Size = New System.Drawing.Size(24, 25)
        Me.lblsales.TabIndex = 22
        Me.lblsales.Text = "0"
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.ImageLocation = ""
        Me.PictureBox5.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(68, 66)
        Me.PictureBox5.TabIndex = 21
        Me.PictureBox5.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(82, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 21)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Sales"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.lblexp)
        Me.Panel4.Controls.Add(Me.PictureBox4)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Location = New System.Drawing.Point(522, 78)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(232, 81)
        Me.Panel4.TabIndex = 38
        '
        'lblexp
        '
        Me.lblexp.AutoSize = True
        Me.lblexp.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexp.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblexp.Location = New System.Drawing.Point(82, 40)
        Me.lblexp.Name = "lblexp"
        Me.lblexp.Size = New System.Drawing.Size(24, 25)
        Me.lblexp.TabIndex = 22
        Me.lblexp.Text = "0"
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.ImageLocation = ""
        Me.PictureBox4.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(68, 66)
        Me.PictureBox4.TabIndex = 21
        Me.PictureBox4.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(82, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 21)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Expired Products"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Location = New System.Drawing.Point(278, 78)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(232, 81)
        Me.Panel3.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(82, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 25)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "0"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImageLocation = ""
        Me.PictureBox2.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(68, 66)
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(82, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "New Products"
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.White
        Me.panel2.Controls.Add(Me.lblproducts)
        Me.panel2.Controls.Add(Me.pictureBox3)
        Me.panel2.Controls.Add(Me.Label2)
        Me.panel2.Location = New System.Drawing.Point(40, 78)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(232, 81)
        Me.panel2.TabIndex = 35
        '
        'lblproducts
        '
        Me.lblproducts.AutoSize = True
        Me.lblproducts.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproducts.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblproducts.Location = New System.Drawing.Point(82, 40)
        Me.lblproducts.Name = "lblproducts"
        Me.lblproducts.Size = New System.Drawing.Size(24, 25)
        Me.lblproducts.TabIndex = 22
        Me.lblproducts.Text = "0"
        '
        'pictureBox3
        '
        Me.pictureBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"), System.Drawing.Image)
        Me.pictureBox3.ImageLocation = ""
        Me.pictureBox3.Location = New System.Drawing.Point(8, 8)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(68, 66)
        Me.pictureBox3.TabIndex = 21
        Me.pictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(82, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Products"
        '
        'CHART
        '
        ChartArea1.Name = "ChartArea1"
        Me.CHART.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.CHART.Legends.Add(Legend1)
        Me.CHART.Location = New System.Drawing.Point(40, 181)
        Me.CHART.Name = "CHART"
        Me.CHART.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Total Bill"
        Me.CHART.Series.Add(Series1)
        Me.CHART.Size = New System.Drawing.Size(953, 265)
        Me.CHART.TabIndex = 42
        Me.CHART.Text = "Chart1"
        '
        'Inventory_dbDataSet
        '
        Me.Inventory_dbDataSet.DataSetName = "inventory_dbDataSet"
        Me.Inventory_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_usersTableAdapter
        '
        Me.Tbl_usersTableAdapter.ClearBeforeFill = True
        '
        'TblusersBindingSource
        '
        Me.TblusersBindingSource.DataMember = "tbl_users"
        Me.TblusersBindingSource.DataSource = Me.Inventory_dbDataSet
        '
        'DGVUSERS
        '
        Me.DGVUSERS.AllowUserToAddRows = False
        Me.DGVUSERS.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.DGVUSERS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVUSERS.AutoGenerateColumns = False
        Me.DGVUSERS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVUSERS.BackgroundColor = System.Drawing.Color.White
        Me.DGVUSERS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVUSERS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVUSERS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVUSERS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVUSERS.ColumnHeadersHeight = 21
        Me.DGVUSERS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsernameDataGridViewTextBoxColumn, Me.UsertypeDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.DGVUSERS.DataSource = Me.TblusersBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(220, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(138, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVUSERS.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVUSERS.Enabled = False
        Me.DGVUSERS.EnableHeadersVisualStyles = False
        Me.DGVUSERS.GridColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.DGVUSERS.Location = New System.Drawing.Point(1015, 331)
        Me.DGVUSERS.Name = "DGVUSERS"
        Me.DGVUSERS.ReadOnly = True
        Me.DGVUSERS.RowHeadersVisible = False
        Me.DGVUSERS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVUSERS.Size = New System.Drawing.Size(267, 395)
        Me.DGVUSERS.TabIndex = 0
        Me.DGVUSERS.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green
        Me.DGVUSERS.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.DGVUSERS.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGVUSERS.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGVUSERS.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGVUSERS.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGVUSERS.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGVUSERS.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.DGVUSERS.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.DGVUSERS.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVUSERS.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DGVUSERS.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGVUSERS.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGVUSERS.ThemeStyle.HeaderStyle.Height = 21
        Me.DGVUSERS.ThemeStyle.ReadOnly = True
        Me.DGVUSERS.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DGVUSERS.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVUSERS.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DGVUSERS.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DGVUSERS.ThemeStyle.RowsStyle.Height = 22
        Me.DGVUSERS.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DGVUSERS.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsertypeDataGridViewTextBoxColumn
        '
        Me.UsertypeDataGridViewTextBoxColumn.DataPropertyName = "usertype"
        Me.UsertypeDataGridViewTextBoxColumn.HeaderText = "usertype"
        Me.UsertypeDataGridViewTextBoxColumn.Name = "UsertypeDataGridViewTextBoxColumn"
        Me.UsertypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel1.Controls.Add(Me.LBLMONTH)
        Me.Panel1.Location = New System.Drawing.Point(1015, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 60)
        Me.Panel1.TabIndex = 0
        '
        'LBLMONTH
        '
        Me.LBLMONTH.AutoSize = True
        Me.LBLMONTH.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMONTH.ForeColor = System.Drawing.Color.White
        Me.LBLMONTH.Location = New System.Drawing.Point(96, 22)
        Me.LBLMONTH.Name = "LBLMONTH"
        Me.LBLMONTH.Size = New System.Drawing.Size(70, 22)
        Me.LBLMONTH.TabIndex = 0
        Me.LBLMONTH.Text = "Month"
        '
        'ucDASHBOARD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CHART)
        Me.Controls.Add(Me.DGVUSERS)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.panel2)
        Me.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Name = "ucDASHBOARD"
        Me.Size = New System.Drawing.Size(1322, 801)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CHART, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventory_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblusersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVUSERS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Private WithEvents Panel5 As Panel
    Private WithEvents lblsales As Label
    Private WithEvents PictureBox5 As PictureBox
    Private WithEvents Label10 As Label
    Private WithEvents Panel4 As Panel
    Private WithEvents lblexp As Label
    Private WithEvents PictureBox4 As PictureBox
    Private WithEvents Label8 As Label
    Private WithEvents Panel3 As Panel
    Private WithEvents Label5 As Label
    Private WithEvents PictureBox2 As PictureBox
    Private WithEvents Label6 As Label
    Private WithEvents panel2 As Panel
    Private WithEvents lblproducts As Label
    Private WithEvents pictureBox3 As PictureBox
    Private WithEvents Label2 As Label
    Friend WithEvents CHART As DataVisualization.Charting.Chart
    Friend WithEvents Inventory_dbDataSet As inventory_dbDataSet
    Friend WithEvents Tbl_usersTableAdapter As inventory_dbDataSetTableAdapters.tbl_usersTableAdapter
    Friend WithEvents TblusersBindingSource As BindingSource
    Friend WithEvents DGVUSERS As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsertypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LBLMONTH As Label
    Friend WithEvents LBLDAY As Label
    Friend WithEvents LBLYEAR As Label
    Friend WithEvents LBLDATE As Label
    Friend WithEvents Panel8 As Panel
End Class
