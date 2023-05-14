<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMREPORTS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource7 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource8 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource9 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMREPORTS))
        Me.tbl_usersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.inventory_dbDataSet = New SALESANDINVENTORYSYSTEM.inventory_dbDataSet()
        Me.tbl_salesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbl_expiredproductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbl_deliveryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbl_stocksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbl_productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TPTRANSREC = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BTNCLRTRANS = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNFILLTRANS = New Guna.UI2.WinForms.Guna2Button()
        Me.DT2 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.DT1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.RPTTRANSACTIONRECORDS = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TPACT = New System.Windows.Forms.TabPage()
        Me.ACTCLR = New Guna.UI2.WinForms.Guna2Button()
        Me.ACTFILL = New Guna.UI2.WinForms.Guna2Button()
        Me.CBOTYPE = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RPTACTLOG = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TPSALES = New System.Windows.Forms.TabPage()
        Me.MONTHLY = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.WEEKLY = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.DAILY = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.CLEARSALES = New Guna.UI2.WinForms.Guna2Button()
        Me.FILTERSALES = New Guna.UI2.WinForms.Guna2Button()
        Me.RPTSALES = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TPOUT = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.OUTCLR = New Guna.UI2.WinForms.Guna2Button()
        Me.OUTFILL = New Guna.UI2.WinForms.Guna2Button()
        Me.Date2OUT = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Date1OUT = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.RPTOUTOFSTOCKS = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TPEXP = New System.Windows.Forms.TabPage()
        Me.RPTEXP = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EXPCLR = New Guna.UI2.WinForms.Guna2Button()
        Me.EXPFILL = New Guna.UI2.WinForms.Guna2Button()
        Me.DAte2EXP = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Date1EXP = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.TPDELIVERY = New System.Windows.Forms.TabPage()
        Me.MONTHLYDELIVERY = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.WEEKLYDELIVERY = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.DAILYDELIVERY = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.CLEARDELIVERY = New Guna.UI2.WinForms.Guna2Button()
        Me.FILTERDELIVERY = New Guna.UI2.WinForms.Guna2Button()
        Me.RPTDELIVERY = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TPSTOCKS = New System.Windows.Forms.TabPage()
        Me.CLEARSTOCKS = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FILTERSTOCKS = New Guna.UI2.WinForms.Guna2Button()
        Me.CBOSTOCKSCATEGORY = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.RPTSTOCKS = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TPPRODS = New System.Windows.Forms.TabPage()
        Me.CLEARPRODUCTS = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FILTERPRODUCTS = New Guna.UI2.WinForms.Guna2Button()
        Me.CBOPRODUCTSCATEGORY = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.RPTPRODUCTS = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TPUSERS = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LBLUSERNAME = New System.Windows.Forms.Label()
        Me.RPTUSERS = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CLEARUSERS = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FILTERUSERS = New Guna.UI2.WinForms.Guna2Button()
        Me.CBOUSERS = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TCREPORTS = New System.Windows.Forms.TabControl()
        Me.tbl_productsTableAdapter = New SALESANDINVENTORYSYSTEM.inventory_dbDataSetTableAdapters.tbl_productsTableAdapter()
        Me.tbl_salesTableAdapter = New SALESANDINVENTORYSYSTEM.inventory_dbDataSetTableAdapters.tbl_salesTableAdapter()
        Me.tbl_usersTableAdapter = New SALESANDINVENTORYSYSTEM.inventory_dbDataSetTableAdapters.tbl_usersTableAdapter()
        Me.tbl_expiredproductsTableAdapter = New SALESANDINVENTORYSYSTEM.inventory_dbDataSetTableAdapters.tbl_expiredproductsTableAdapter()
        Me.tbl_stocksTableAdapter = New SALESANDINVENTORYSYSTEM.inventory_dbDataSetTableAdapters.tbl_stocksTableAdapter()
        Me.tbl_deliveryTableAdapter = New SALESANDINVENTORYSYSTEM.inventory_dbDataSetTableAdapters.tbl_deliveryTableAdapter()
        CType(Me.tbl_usersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inventory_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_salesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_expiredproductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_deliveryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_stocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPTRANSREC.SuspendLayout()
        Me.TPACT.SuspendLayout()
        Me.TPSALES.SuspendLayout()
        Me.TPOUT.SuspendLayout()
        Me.TPEXP.SuspendLayout()
        Me.TPDELIVERY.SuspendLayout()
        Me.TPSTOCKS.SuspendLayout()
        Me.TPPRODS.SuspendLayout()
        Me.TPUSERS.SuspendLayout()
        Me.TCREPORTS.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbl_usersBindingSource
        '
        Me.tbl_usersBindingSource.DataMember = "tbl_users"
        Me.tbl_usersBindingSource.DataSource = Me.inventory_dbDataSet
        '
        'inventory_dbDataSet
        '
        Me.inventory_dbDataSet.DataSetName = "inventory_dbDataSet"
        Me.inventory_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbl_salesBindingSource
        '
        Me.tbl_salesBindingSource.DataMember = "tbl_sales"
        Me.tbl_salesBindingSource.DataSource = Me.inventory_dbDataSet
        '
        'tbl_expiredproductsBindingSource
        '
        Me.tbl_expiredproductsBindingSource.DataMember = "tbl_expiredproducts"
        Me.tbl_expiredproductsBindingSource.DataSource = Me.inventory_dbDataSet
        '
        'tbl_deliveryBindingSource
        '
        Me.tbl_deliveryBindingSource.DataMember = "tbl_delivery"
        Me.tbl_deliveryBindingSource.DataSource = Me.inventory_dbDataSet
        '
        'tbl_stocksBindingSource
        '
        Me.tbl_stocksBindingSource.DataMember = "tbl_stocks"
        Me.tbl_stocksBindingSource.DataSource = Me.inventory_dbDataSet
        '
        'tbl_productsBindingSource
        '
        Me.tbl_productsBindingSource.DataMember = "tbl_products"
        Me.tbl_productsBindingSource.DataSource = Me.inventory_dbDataSet
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(152, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1237, 25)
        Me.Panel1.TabIndex = 13
        '
        'TPTRANSREC
        '
        Me.TPTRANSREC.Controls.Add(Me.Label13)
        Me.TPTRANSREC.Controls.Add(Me.Label14)
        Me.TPTRANSREC.Controls.Add(Me.BTNCLRTRANS)
        Me.TPTRANSREC.Controls.Add(Me.BTNFILLTRANS)
        Me.TPTRANSREC.Controls.Add(Me.DT2)
        Me.TPTRANSREC.Controls.Add(Me.DT1)
        Me.TPTRANSREC.Controls.Add(Me.RPTTRANSACTIONRECORDS)
        Me.TPTRANSREC.Location = New System.Drawing.Point(4, 29)
        Me.TPTRANSREC.Name = "TPTRANSREC"
        Me.TPTRANSREC.Size = New System.Drawing.Size(1108, 619)
        Me.TPTRANSREC.TabIndex = 8
        Me.TPTRANSREC.Text = "Transaction Records"
        Me.TPTRANSREC.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(313, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 20)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "To :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(27, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 20)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "From :"
        '
        'BTNCLRTRANS
        '
        Me.BTNCLRTRANS.BackColor = System.Drawing.Color.Transparent
        Me.BTNCLRTRANS.CheckedState.Parent = Me.BTNCLRTRANS
        Me.BTNCLRTRANS.CustomImages.Parent = Me.BTNCLRTRANS
        Me.BTNCLRTRANS.FillColor = System.Drawing.SystemColors.ControlDark
        Me.BTNCLRTRANS.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.BTNCLRTRANS.ForeColor = System.Drawing.Color.White
        Me.BTNCLRTRANS.HoverState.Parent = Me.BTNCLRTRANS
        Me.BTNCLRTRANS.Location = New System.Drawing.Point(740, 27)
        Me.BTNCLRTRANS.Name = "BTNCLRTRANS"
        Me.BTNCLRTRANS.ShadowDecoration.Parent = Me.BTNCLRTRANS
        Me.BTNCLRTRANS.Size = New System.Drawing.Size(98, 36)
        Me.BTNCLRTRANS.TabIndex = 20
        Me.BTNCLRTRANS.Text = "Clear Filter"
        '
        'BTNFILLTRANS
        '
        Me.BTNFILLTRANS.CheckedState.Parent = Me.BTNFILLTRANS
        Me.BTNFILLTRANS.CustomImages.Parent = Me.BTNFILLTRANS
        Me.BTNFILLTRANS.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTNFILLTRANS.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.BTNFILLTRANS.ForeColor = System.Drawing.Color.White
        Me.BTNFILLTRANS.HoverState.Parent = Me.BTNFILLTRANS
        Me.BTNFILLTRANS.Location = New System.Drawing.Point(610, 26)
        Me.BTNFILLTRANS.Name = "BTNFILLTRANS"
        Me.BTNFILLTRANS.ShadowDecoration.Parent = Me.BTNFILLTRANS
        Me.BTNFILLTRANS.Size = New System.Drawing.Size(98, 36)
        Me.BTNFILLTRANS.TabIndex = 19
        Me.BTNFILLTRANS.Text = "Filter"
        '
        'DT2
        '
        Me.DT2.CheckedState.Parent = Me.DT2
        Me.DT2.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.DT2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DT2.ForeColor = System.Drawing.Color.White
        Me.DT2.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DT2.HoverState.Parent = Me.DT2
        Me.DT2.Location = New System.Drawing.Point(372, 26)
        Me.DT2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DT2.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DT2.Name = "DT2"
        Me.DT2.ShadowDecoration.Parent = Me.DT2
        Me.DT2.Size = New System.Drawing.Size(200, 36)
        Me.DT2.TabIndex = 18
        Me.DT2.Value = New Date(2023, 4, 15, 23, 18, 1, 623)
        '
        'DT1
        '
        Me.DT1.CheckedState.Parent = Me.DT1
        Me.DT1.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.DT1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DT1.ForeColor = System.Drawing.Color.White
        Me.DT1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DT1.HoverState.Parent = Me.DT1
        Me.DT1.Location = New System.Drawing.Point(90, 26)
        Me.DT1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DT1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DT1.Name = "DT1"
        Me.DT1.ShadowDecoration.Parent = Me.DT1
        Me.DT1.Size = New System.Drawing.Size(200, 36)
        Me.DT1.TabIndex = 17
        Me.DT1.Value = New Date(2023, 4, 15, 23, 18, 1, 623)
        '
        'RPTTRANSACTIONRECORDS
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tbl_usersBindingSource
        Me.RPTTRANSACTIONRECORDS.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RPTTRANSACTIONRECORDS.LocalReport.ReportEmbeddedResource = "SALESANDINVENTORYSYSTEM.RPTUSERS.rdlc"
        Me.RPTTRANSACTIONRECORDS.Location = New System.Drawing.Point(20, 80)
        Me.RPTTRANSACTIONRECORDS.Name = "RPTTRANSACTIONRECORDS"
        Me.RPTTRANSACTIONRECORDS.ServerReport.BearerToken = Nothing
        Me.RPTTRANSACTIONRECORDS.Size = New System.Drawing.Size(1067, 513)
        Me.RPTTRANSACTIONRECORDS.TabIndex = 2
        '
        'TPACT
        '
        Me.TPACT.Controls.Add(Me.ACTCLR)
        Me.TPACT.Controls.Add(Me.ACTFILL)
        Me.TPACT.Controls.Add(Me.CBOTYPE)
        Me.TPACT.Controls.Add(Me.Label1)
        Me.TPACT.Controls.Add(Me.RPTACTLOG)
        Me.TPACT.Location = New System.Drawing.Point(4, 29)
        Me.TPACT.Name = "TPACT"
        Me.TPACT.Padding = New System.Windows.Forms.Padding(3)
        Me.TPACT.Size = New System.Drawing.Size(1108, 619)
        Me.TPACT.TabIndex = 5
        Me.TPACT.Text = "Activity Log"
        Me.TPACT.UseVisualStyleBackColor = True
        '
        'ACTCLR
        '
        Me.ACTCLR.BackColor = System.Drawing.Color.Transparent
        Me.ACTCLR.CheckedState.Parent = Me.ACTCLR
        Me.ACTCLR.CustomImages.Parent = Me.ACTCLR
        Me.ACTCLR.FillColor = System.Drawing.SystemColors.ControlDark
        Me.ACTCLR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ACTCLR.ForeColor = System.Drawing.Color.White
        Me.ACTCLR.HoverState.Parent = Me.ACTCLR
        Me.ACTCLR.Location = New System.Drawing.Point(508, 26)
        Me.ACTCLR.Name = "ACTCLR"
        Me.ACTCLR.ShadowDecoration.Parent = Me.ACTCLR
        Me.ACTCLR.Size = New System.Drawing.Size(98, 36)
        Me.ACTCLR.TabIndex = 6
        Me.ACTCLR.Text = "Clear Filter"
        '
        'ACTFILL
        '
        Me.ACTFILL.CheckedState.Parent = Me.ACTFILL
        Me.ACTFILL.CustomImages.Parent = Me.ACTFILL
        Me.ACTFILL.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.ACTFILL.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ACTFILL.ForeColor = System.Drawing.Color.White
        Me.ACTFILL.HoverState.Parent = Me.ACTFILL
        Me.ACTFILL.Location = New System.Drawing.Point(383, 26)
        Me.ACTFILL.Name = "ACTFILL"
        Me.ACTFILL.ShadowDecoration.Parent = Me.ACTFILL
        Me.ACTFILL.Size = New System.Drawing.Size(98, 36)
        Me.ACTFILL.TabIndex = 5
        Me.ACTFILL.Text = "Filter"
        '
        'CBOTYPE
        '
        Me.CBOTYPE.BackColor = System.Drawing.Color.Transparent
        Me.CBOTYPE.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBOTYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOTYPE.FocusedColor = System.Drawing.Color.Empty
        Me.CBOTYPE.FocusedState.Parent = Me.CBOTYPE
        Me.CBOTYPE.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBOTYPE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBOTYPE.FormattingEnabled = True
        Me.CBOTYPE.HoverState.Parent = Me.CBOTYPE
        Me.CBOTYPE.ItemHeight = 30
        Me.CBOTYPE.Items.AddRange(New Object() {"Admin", "Cashier", "Manager"})
        Me.CBOTYPE.ItemsAppearance.Parent = Me.CBOTYPE
        Me.CBOTYPE.Location = New System.Drawing.Point(200, 25)
        Me.CBOTYPE.Name = "CBOTYPE"
        Me.CBOTYPE.ShadowDecoration.Parent = Me.CBOTYPE
        Me.CBOTYPE.Size = New System.Drawing.Size(140, 36)
        Me.CBOTYPE.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(27, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Filter by usertype :"
        '
        'RPTACTLOG
        '
        ReportDataSource2.Name = "DataSet_ACT"
        ReportDataSource2.Value = Nothing
        Me.RPTACTLOG.LocalReport.DataSources.Add(ReportDataSource2)
        Me.RPTACTLOG.LocalReport.ReportEmbeddedResource = "SALESANDINVENTORYSYSTEM.RPTACTLOG.rdlc"
        Me.RPTACTLOG.Location = New System.Drawing.Point(20, 80)
        Me.RPTACTLOG.Name = "RPTACTLOG"
        Me.RPTACTLOG.ServerReport.BearerToken = Nothing
        Me.RPTACTLOG.Size = New System.Drawing.Size(1067, 513)
        Me.RPTACTLOG.TabIndex = 1
        '
        'TPSALES
        '
        Me.TPSALES.Controls.Add(Me.MONTHLY)
        Me.TPSALES.Controls.Add(Me.WEEKLY)
        Me.TPSALES.Controls.Add(Me.DAILY)
        Me.TPSALES.Controls.Add(Me.CLEARSALES)
        Me.TPSALES.Controls.Add(Me.FILTERSALES)
        Me.TPSALES.Controls.Add(Me.RPTSALES)
        Me.TPSALES.Location = New System.Drawing.Point(4, 29)
        Me.TPSALES.Name = "TPSALES"
        Me.TPSALES.Padding = New System.Windows.Forms.Padding(3)
        Me.TPSALES.Size = New System.Drawing.Size(1108, 619)
        Me.TPSALES.TabIndex = 4
        Me.TPSALES.Text = "Sales Report"
        Me.TPSALES.UseVisualStyleBackColor = True
        '
        'MONTHLY
        '
        Me.MONTHLY.AutoSize = True
        Me.MONTHLY.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MONTHLY.CheckedState.BorderThickness = 0
        Me.MONTHLY.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MONTHLY.CheckedState.InnerColor = System.Drawing.Color.White
        Me.MONTHLY.CheckedState.InnerOffset = -4
        Me.MONTHLY.Location = New System.Drawing.Point(202, 26)
        Me.MONTHLY.Name = "MONTHLY"
        Me.MONTHLY.Size = New System.Drawing.Size(86, 24)
        Me.MONTHLY.TabIndex = 18
        Me.MONTHLY.TabStop = True
        Me.MONTHLY.Text = "Monthly"
        Me.MONTHLY.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.MONTHLY.UncheckedState.BorderThickness = 2
        Me.MONTHLY.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.MONTHLY.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.MONTHLY.UseVisualStyleBackColor = True
        '
        'WEEKLY
        '
        Me.WEEKLY.AutoSize = True
        Me.WEEKLY.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.WEEKLY.CheckedState.BorderThickness = 0
        Me.WEEKLY.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.WEEKLY.CheckedState.InnerColor = System.Drawing.Color.White
        Me.WEEKLY.CheckedState.InnerOffset = -4
        Me.WEEKLY.Location = New System.Drawing.Point(98, 26)
        Me.WEEKLY.Name = "WEEKLY"
        Me.WEEKLY.Size = New System.Drawing.Size(81, 24)
        Me.WEEKLY.TabIndex = 17
        Me.WEEKLY.TabStop = True
        Me.WEEKLY.Text = "Weekly"
        Me.WEEKLY.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.WEEKLY.UncheckedState.BorderThickness = 2
        Me.WEEKLY.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.WEEKLY.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.WEEKLY.UseVisualStyleBackColor = True
        '
        'DAILY
        '
        Me.DAILY.AutoSize = True
        Me.DAILY.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DAILY.CheckedState.BorderThickness = 0
        Me.DAILY.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DAILY.CheckedState.InnerColor = System.Drawing.Color.White
        Me.DAILY.CheckedState.InnerOffset = -4
        Me.DAILY.Location = New System.Drawing.Point(20, 27)
        Me.DAILY.Name = "DAILY"
        Me.DAILY.Size = New System.Drawing.Size(62, 24)
        Me.DAILY.TabIndex = 16
        Me.DAILY.TabStop = True
        Me.DAILY.Text = "Daily"
        Me.DAILY.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.DAILY.UncheckedState.BorderThickness = 2
        Me.DAILY.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.DAILY.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.DAILY.UseVisualStyleBackColor = True
        '
        'CLEARSALES
        '
        Me.CLEARSALES.BackColor = System.Drawing.Color.Transparent
        Me.CLEARSALES.CheckedState.Parent = Me.CLEARSALES
        Me.CLEARSALES.CustomImages.Parent = Me.CLEARSALES
        Me.CLEARSALES.FillColor = System.Drawing.SystemColors.ControlDark
        Me.CLEARSALES.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.CLEARSALES.ForeColor = System.Drawing.Color.White
        Me.CLEARSALES.HoverState.Parent = Me.CLEARSALES
        Me.CLEARSALES.Location = New System.Drawing.Point(443, 27)
        Me.CLEARSALES.Name = "CLEARSALES"
        Me.CLEARSALES.ShadowDecoration.Parent = Me.CLEARSALES
        Me.CLEARSALES.Size = New System.Drawing.Size(98, 36)
        Me.CLEARSALES.TabIndex = 14
        Me.CLEARSALES.Text = "Clear Filter"
        '
        'FILTERSALES
        '
        Me.FILTERSALES.CheckedState.Parent = Me.FILTERSALES
        Me.FILTERSALES.CustomImages.Parent = Me.FILTERSALES
        Me.FILTERSALES.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.FILTERSALES.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.FILTERSALES.ForeColor = System.Drawing.Color.White
        Me.FILTERSALES.HoverState.Parent = Me.FILTERSALES
        Me.FILTERSALES.Location = New System.Drawing.Point(313, 26)
        Me.FILTERSALES.Name = "FILTERSALES"
        Me.FILTERSALES.ShadowDecoration.Parent = Me.FILTERSALES
        Me.FILTERSALES.Size = New System.Drawing.Size(98, 36)
        Me.FILTERSALES.TabIndex = 13
        Me.FILTERSALES.Text = "Filter"
        '
        'RPTSALES
        '
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.tbl_salesBindingSource
        Me.RPTSALES.LocalReport.DataSources.Add(ReportDataSource3)
        Me.RPTSALES.LocalReport.ReportEmbeddedResource = "SALESANDINVENTORYSYSTEM.RPTSALES.rdlc"
        Me.RPTSALES.Location = New System.Drawing.Point(20, 80)
        Me.RPTSALES.Name = "RPTSALES"
        Me.RPTSALES.ServerReport.BearerToken = Nothing
        Me.RPTSALES.Size = New System.Drawing.Size(1067, 513)
        Me.RPTSALES.TabIndex = 10
        '
        'TPOUT
        '
        Me.TPOUT.Controls.Add(Me.Label10)
        Me.TPOUT.Controls.Add(Me.Label9)
        Me.TPOUT.Controls.Add(Me.OUTCLR)
        Me.TPOUT.Controls.Add(Me.OUTFILL)
        Me.TPOUT.Controls.Add(Me.Date2OUT)
        Me.TPOUT.Controls.Add(Me.Date1OUT)
        Me.TPOUT.Controls.Add(Me.RPTOUTOFSTOCKS)
        Me.TPOUT.Location = New System.Drawing.Point(4, 29)
        Me.TPOUT.Name = "TPOUT"
        Me.TPOUT.Padding = New System.Windows.Forms.Padding(3)
        Me.TPOUT.Size = New System.Drawing.Size(1108, 619)
        Me.TPOUT.TabIndex = 3
        Me.TPOUT.Text = "Out of Stocks"
        Me.TPOUT.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(313, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 20)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "To :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 20)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "From :"
        '
        'OUTCLR
        '
        Me.OUTCLR.BackColor = System.Drawing.Color.Transparent
        Me.OUTCLR.CheckedState.Parent = Me.OUTCLR
        Me.OUTCLR.CustomImages.Parent = Me.OUTCLR
        Me.OUTCLR.FillColor = System.Drawing.SystemColors.ControlDark
        Me.OUTCLR.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.OUTCLR.ForeColor = System.Drawing.Color.White
        Me.OUTCLR.HoverState.Parent = Me.OUTCLR
        Me.OUTCLR.Location = New System.Drawing.Point(740, 27)
        Me.OUTCLR.Name = "OUTCLR"
        Me.OUTCLR.ShadowDecoration.Parent = Me.OUTCLR
        Me.OUTCLR.Size = New System.Drawing.Size(98, 36)
        Me.OUTCLR.TabIndex = 14
        Me.OUTCLR.Text = "Clear Filter"
        '
        'OUTFILL
        '
        Me.OUTFILL.CheckedState.Parent = Me.OUTFILL
        Me.OUTFILL.CustomImages.Parent = Me.OUTFILL
        Me.OUTFILL.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.OUTFILL.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.OUTFILL.ForeColor = System.Drawing.Color.White
        Me.OUTFILL.HoverState.Parent = Me.OUTFILL
        Me.OUTFILL.Location = New System.Drawing.Point(610, 26)
        Me.OUTFILL.Name = "OUTFILL"
        Me.OUTFILL.ShadowDecoration.Parent = Me.OUTFILL
        Me.OUTFILL.Size = New System.Drawing.Size(98, 36)
        Me.OUTFILL.TabIndex = 13
        Me.OUTFILL.Text = "Filter"
        '
        'Date2OUT
        '
        Me.Date2OUT.CheckedState.Parent = Me.Date2OUT
        Me.Date2OUT.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.Date2OUT.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date2OUT.ForeColor = System.Drawing.Color.White
        Me.Date2OUT.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Date2OUT.HoverState.Parent = Me.Date2OUT
        Me.Date2OUT.Location = New System.Drawing.Point(372, 26)
        Me.Date2OUT.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Date2OUT.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Date2OUT.Name = "Date2OUT"
        Me.Date2OUT.ShadowDecoration.Parent = Me.Date2OUT
        Me.Date2OUT.Size = New System.Drawing.Size(200, 36)
        Me.Date2OUT.TabIndex = 12
        Me.Date2OUT.Value = New Date(2023, 4, 15, 23, 18, 1, 623)
        '
        'Date1OUT
        '
        Me.Date1OUT.CheckedState.Parent = Me.Date1OUT
        Me.Date1OUT.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.Date1OUT.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date1OUT.ForeColor = System.Drawing.Color.White
        Me.Date1OUT.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Date1OUT.HoverState.Parent = Me.Date1OUT
        Me.Date1OUT.Location = New System.Drawing.Point(90, 26)
        Me.Date1OUT.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Date1OUT.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Date1OUT.Name = "Date1OUT"
        Me.Date1OUT.ShadowDecoration.Parent = Me.Date1OUT
        Me.Date1OUT.Size = New System.Drawing.Size(200, 36)
        Me.Date1OUT.TabIndex = 11
        Me.Date1OUT.Value = New Date(2023, 4, 15, 23, 18, 1, 623)
        '
        'RPTOUTOFSTOCKS
        '
        ReportDataSource4.Name = "DataSet1"
        ReportDataSource4.Value = Nothing
        Me.RPTOUTOFSTOCKS.LocalReport.DataSources.Add(ReportDataSource4)
        Me.RPTOUTOFSTOCKS.LocalReport.ReportEmbeddedResource = "SALESANDINVENTORYSYSTEM.RPTOUTOFSTOCKS.rdlc"
        Me.RPTOUTOFSTOCKS.Location = New System.Drawing.Point(20, 80)
        Me.RPTOUTOFSTOCKS.Name = "RPTOUTOFSTOCKS"
        Me.RPTOUTOFSTOCKS.ServerReport.BearerToken = Nothing
        Me.RPTOUTOFSTOCKS.Size = New System.Drawing.Size(1067, 513)
        Me.RPTOUTOFSTOCKS.TabIndex = 10
        '
        'TPEXP
        '
        Me.TPEXP.Controls.Add(Me.RPTEXP)
        Me.TPEXP.Controls.Add(Me.Label8)
        Me.TPEXP.Controls.Add(Me.Label7)
        Me.TPEXP.Controls.Add(Me.EXPCLR)
        Me.TPEXP.Controls.Add(Me.EXPFILL)
        Me.TPEXP.Controls.Add(Me.DAte2EXP)
        Me.TPEXP.Controls.Add(Me.Date1EXP)
        Me.TPEXP.Location = New System.Drawing.Point(4, 29)
        Me.TPEXP.Name = "TPEXP"
        Me.TPEXP.Padding = New System.Windows.Forms.Padding(3)
        Me.TPEXP.Size = New System.Drawing.Size(1108, 619)
        Me.TPEXP.TabIndex = 2
        Me.TPEXP.Text = "Expired Products"
        Me.TPEXP.UseVisualStyleBackColor = True
        '
        'RPTEXP
        '
        ReportDataSource5.Name = "DataSet1"
        ReportDataSource5.Value = Me.tbl_expiredproductsBindingSource
        Me.RPTEXP.LocalReport.DataSources.Add(ReportDataSource5)
        Me.RPTEXP.LocalReport.ReportEmbeddedResource = "SALESANDINVENTORYSYSTEM.RPTEXPIREDPRODUCTS.rdlc"
        Me.RPTEXP.Location = New System.Drawing.Point(20, 80)
        Me.RPTEXP.Name = "RPTEXP"
        Me.RPTEXP.ServerReport.BearerToken = Nothing
        Me.RPTEXP.Size = New System.Drawing.Size(1067, 513)
        Me.RPTEXP.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "From :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(313, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "To :"
        '
        'EXPCLR
        '
        Me.EXPCLR.BackColor = System.Drawing.Color.Transparent
        Me.EXPCLR.CheckedState.Parent = Me.EXPCLR
        Me.EXPCLR.CustomImages.Parent = Me.EXPCLR
        Me.EXPCLR.FillColor = System.Drawing.SystemColors.ControlDark
        Me.EXPCLR.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.EXPCLR.ForeColor = System.Drawing.Color.White
        Me.EXPCLR.HoverState.Parent = Me.EXPCLR
        Me.EXPCLR.Location = New System.Drawing.Point(740, 27)
        Me.EXPCLR.Name = "EXPCLR"
        Me.EXPCLR.ShadowDecoration.Parent = Me.EXPCLR
        Me.EXPCLR.Size = New System.Drawing.Size(98, 36)
        Me.EXPCLR.TabIndex = 9
        Me.EXPCLR.Text = "Clear Filter"
        '
        'EXPFILL
        '
        Me.EXPFILL.CheckedState.Parent = Me.EXPFILL
        Me.EXPFILL.CustomImages.Parent = Me.EXPFILL
        Me.EXPFILL.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.EXPFILL.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.EXPFILL.ForeColor = System.Drawing.Color.White
        Me.EXPFILL.HoverState.Parent = Me.EXPFILL
        Me.EXPFILL.Location = New System.Drawing.Point(610, 26)
        Me.EXPFILL.Name = "EXPFILL"
        Me.EXPFILL.ShadowDecoration.Parent = Me.EXPFILL
        Me.EXPFILL.Size = New System.Drawing.Size(98, 36)
        Me.EXPFILL.TabIndex = 8
        Me.EXPFILL.Text = "Filter"
        '
        'DAte2EXP
        '
        Me.DAte2EXP.CheckedState.Parent = Me.DAte2EXP
        Me.DAte2EXP.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.DAte2EXP.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DAte2EXP.ForeColor = System.Drawing.Color.White
        Me.DAte2EXP.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DAte2EXP.HoverState.Parent = Me.DAte2EXP
        Me.DAte2EXP.Location = New System.Drawing.Point(372, 26)
        Me.DAte2EXP.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DAte2EXP.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DAte2EXP.Name = "DAte2EXP"
        Me.DAte2EXP.ShadowDecoration.Parent = Me.DAte2EXP
        Me.DAte2EXP.Size = New System.Drawing.Size(200, 36)
        Me.DAte2EXP.TabIndex = 7
        Me.DAte2EXP.Value = New Date(2023, 4, 15, 23, 18, 1, 623)
        '
        'Date1EXP
        '
        Me.Date1EXP.CheckedState.Parent = Me.Date1EXP
        Me.Date1EXP.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.Date1EXP.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date1EXP.ForeColor = System.Drawing.Color.White
        Me.Date1EXP.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Date1EXP.HoverState.Parent = Me.Date1EXP
        Me.Date1EXP.Location = New System.Drawing.Point(90, 26)
        Me.Date1EXP.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Date1EXP.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Date1EXP.Name = "Date1EXP"
        Me.Date1EXP.ShadowDecoration.Parent = Me.Date1EXP
        Me.Date1EXP.Size = New System.Drawing.Size(200, 36)
        Me.Date1EXP.TabIndex = 6
        Me.Date1EXP.Value = New Date(2023, 4, 15, 23, 18, 1, 623)
        '
        'TPDELIVERY
        '
        Me.TPDELIVERY.Controls.Add(Me.MONTHLYDELIVERY)
        Me.TPDELIVERY.Controls.Add(Me.WEEKLYDELIVERY)
        Me.TPDELIVERY.Controls.Add(Me.DAILYDELIVERY)
        Me.TPDELIVERY.Controls.Add(Me.CLEARDELIVERY)
        Me.TPDELIVERY.Controls.Add(Me.FILTERDELIVERY)
        Me.TPDELIVERY.Controls.Add(Me.RPTDELIVERY)
        Me.TPDELIVERY.Location = New System.Drawing.Point(4, 29)
        Me.TPDELIVERY.Name = "TPDELIVERY"
        Me.TPDELIVERY.Padding = New System.Windows.Forms.Padding(3)
        Me.TPDELIVERY.Size = New System.Drawing.Size(1108, 619)
        Me.TPDELIVERY.TabIndex = 6
        Me.TPDELIVERY.Text = "Delivery"
        Me.TPDELIVERY.UseVisualStyleBackColor = True
        '
        'MONTHLYDELIVERY
        '
        Me.MONTHLYDELIVERY.AutoSize = True
        Me.MONTHLYDELIVERY.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MONTHLYDELIVERY.CheckedState.BorderThickness = 0
        Me.MONTHLYDELIVERY.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MONTHLYDELIVERY.CheckedState.InnerColor = System.Drawing.Color.White
        Me.MONTHLYDELIVERY.CheckedState.InnerOffset = -4
        Me.MONTHLYDELIVERY.Location = New System.Drawing.Point(202, 28)
        Me.MONTHLYDELIVERY.Name = "MONTHLYDELIVERY"
        Me.MONTHLYDELIVERY.Size = New System.Drawing.Size(86, 24)
        Me.MONTHLYDELIVERY.TabIndex = 23
        Me.MONTHLYDELIVERY.TabStop = True
        Me.MONTHLYDELIVERY.Text = "Monthly"
        Me.MONTHLYDELIVERY.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.MONTHLYDELIVERY.UncheckedState.BorderThickness = 2
        Me.MONTHLYDELIVERY.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.MONTHLYDELIVERY.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.MONTHLYDELIVERY.UseVisualStyleBackColor = True
        '
        'WEEKLYDELIVERY
        '
        Me.WEEKLYDELIVERY.AutoSize = True
        Me.WEEKLYDELIVERY.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.WEEKLYDELIVERY.CheckedState.BorderThickness = 0
        Me.WEEKLYDELIVERY.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.WEEKLYDELIVERY.CheckedState.InnerColor = System.Drawing.Color.White
        Me.WEEKLYDELIVERY.CheckedState.InnerOffset = -4
        Me.WEEKLYDELIVERY.Location = New System.Drawing.Point(98, 28)
        Me.WEEKLYDELIVERY.Name = "WEEKLYDELIVERY"
        Me.WEEKLYDELIVERY.Size = New System.Drawing.Size(81, 24)
        Me.WEEKLYDELIVERY.TabIndex = 22
        Me.WEEKLYDELIVERY.TabStop = True
        Me.WEEKLYDELIVERY.Text = "Weekly"
        Me.WEEKLYDELIVERY.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.WEEKLYDELIVERY.UncheckedState.BorderThickness = 2
        Me.WEEKLYDELIVERY.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.WEEKLYDELIVERY.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.WEEKLYDELIVERY.UseVisualStyleBackColor = True
        '
        'DAILYDELIVERY
        '
        Me.DAILYDELIVERY.AutoSize = True
        Me.DAILYDELIVERY.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DAILYDELIVERY.CheckedState.BorderThickness = 0
        Me.DAILYDELIVERY.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DAILYDELIVERY.CheckedState.InnerColor = System.Drawing.Color.White
        Me.DAILYDELIVERY.CheckedState.InnerOffset = -4
        Me.DAILYDELIVERY.Location = New System.Drawing.Point(20, 29)
        Me.DAILYDELIVERY.Name = "DAILYDELIVERY"
        Me.DAILYDELIVERY.Size = New System.Drawing.Size(62, 24)
        Me.DAILYDELIVERY.TabIndex = 21
        Me.DAILYDELIVERY.TabStop = True
        Me.DAILYDELIVERY.Text = "Daily"
        Me.DAILYDELIVERY.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.DAILYDELIVERY.UncheckedState.BorderThickness = 2
        Me.DAILYDELIVERY.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.DAILYDELIVERY.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.DAILYDELIVERY.UseVisualStyleBackColor = True
        '
        'CLEARDELIVERY
        '
        Me.CLEARDELIVERY.BackColor = System.Drawing.Color.Transparent
        Me.CLEARDELIVERY.CheckedState.Parent = Me.CLEARDELIVERY
        Me.CLEARDELIVERY.CustomImages.Parent = Me.CLEARDELIVERY
        Me.CLEARDELIVERY.FillColor = System.Drawing.SystemColors.ControlDark
        Me.CLEARDELIVERY.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.CLEARDELIVERY.ForeColor = System.Drawing.Color.White
        Me.CLEARDELIVERY.HoverState.Parent = Me.CLEARDELIVERY
        Me.CLEARDELIVERY.Location = New System.Drawing.Point(443, 29)
        Me.CLEARDELIVERY.Name = "CLEARDELIVERY"
        Me.CLEARDELIVERY.ShadowDecoration.Parent = Me.CLEARDELIVERY
        Me.CLEARDELIVERY.Size = New System.Drawing.Size(98, 36)
        Me.CLEARDELIVERY.TabIndex = 20
        Me.CLEARDELIVERY.Text = "Clear Filter"
        '
        'FILTERDELIVERY
        '
        Me.FILTERDELIVERY.CheckedState.Parent = Me.FILTERDELIVERY
        Me.FILTERDELIVERY.CustomImages.Parent = Me.FILTERDELIVERY
        Me.FILTERDELIVERY.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.FILTERDELIVERY.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.FILTERDELIVERY.ForeColor = System.Drawing.Color.White
        Me.FILTERDELIVERY.HoverState.Parent = Me.FILTERDELIVERY
        Me.FILTERDELIVERY.Location = New System.Drawing.Point(313, 28)
        Me.FILTERDELIVERY.Name = "FILTERDELIVERY"
        Me.FILTERDELIVERY.ShadowDecoration.Parent = Me.FILTERDELIVERY
        Me.FILTERDELIVERY.Size = New System.Drawing.Size(98, 36)
        Me.FILTERDELIVERY.TabIndex = 19
        Me.FILTERDELIVERY.Text = "Filter"
        '
        'RPTDELIVERY
        '
        ReportDataSource6.Name = "DataSet1"
        ReportDataSource6.Value = Me.tbl_deliveryBindingSource
        Me.RPTDELIVERY.LocalReport.DataSources.Add(ReportDataSource6)
        Me.RPTDELIVERY.LocalReport.ReportEmbeddedResource = "SALESANDINVENTORYSYSTEM.RPTDELIVERY.rdlc"
        Me.RPTDELIVERY.Location = New System.Drawing.Point(20, 80)
        Me.RPTDELIVERY.Name = "RPTDELIVERY"
        Me.RPTDELIVERY.ServerReport.BearerToken = Nothing
        Me.RPTDELIVERY.Size = New System.Drawing.Size(1067, 513)
        Me.RPTDELIVERY.TabIndex = 1
        '
        'TPSTOCKS
        '
        Me.TPSTOCKS.Controls.Add(Me.CLEARSTOCKS)
        Me.TPSTOCKS.Controls.Add(Me.Label3)
        Me.TPSTOCKS.Controls.Add(Me.FILTERSTOCKS)
        Me.TPSTOCKS.Controls.Add(Me.CBOSTOCKSCATEGORY)
        Me.TPSTOCKS.Controls.Add(Me.RPTSTOCKS)
        Me.TPSTOCKS.Location = New System.Drawing.Point(4, 29)
        Me.TPSTOCKS.Name = "TPSTOCKS"
        Me.TPSTOCKS.Size = New System.Drawing.Size(1108, 619)
        Me.TPSTOCKS.TabIndex = 7
        Me.TPSTOCKS.Text = "Stocks"
        Me.TPSTOCKS.UseVisualStyleBackColor = True
        '
        'CLEARSTOCKS
        '
        Me.CLEARSTOCKS.BackColor = System.Drawing.Color.Transparent
        Me.CLEARSTOCKS.CheckedState.Parent = Me.CLEARSTOCKS
        Me.CLEARSTOCKS.CustomImages.Parent = Me.CLEARSTOCKS
        Me.CLEARSTOCKS.FillColor = System.Drawing.SystemColors.ControlDark
        Me.CLEARSTOCKS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CLEARSTOCKS.ForeColor = System.Drawing.Color.White
        Me.CLEARSTOCKS.HoverState.Parent = Me.CLEARSTOCKS
        Me.CLEARSTOCKS.Location = New System.Drawing.Point(497, 28)
        Me.CLEARSTOCKS.Name = "CLEARSTOCKS"
        Me.CLEARSTOCKS.ShadowDecoration.Parent = Me.CLEARSTOCKS
        Me.CLEARSTOCKS.Size = New System.Drawing.Size(98, 36)
        Me.CLEARSTOCKS.TabIndex = 16
        Me.CLEARSTOCKS.Text = "Clear Filter"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label3.Location = New System.Drawing.Point(16, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Filter by Category"
        '
        'FILTERSTOCKS
        '
        Me.FILTERSTOCKS.CheckedState.Parent = Me.FILTERSTOCKS
        Me.FILTERSTOCKS.CustomImages.Parent = Me.FILTERSTOCKS
        Me.FILTERSTOCKS.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.FILTERSTOCKS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FILTERSTOCKS.ForeColor = System.Drawing.Color.White
        Me.FILTERSTOCKS.HoverState.Parent = Me.FILTERSTOCKS
        Me.FILTERSTOCKS.Location = New System.Drawing.Point(372, 28)
        Me.FILTERSTOCKS.Name = "FILTERSTOCKS"
        Me.FILTERSTOCKS.ShadowDecoration.Parent = Me.FILTERSTOCKS
        Me.FILTERSTOCKS.Size = New System.Drawing.Size(98, 36)
        Me.FILTERSTOCKS.TabIndex = 15
        Me.FILTERSTOCKS.Text = "Filter"
        '
        'CBOSTOCKSCATEGORY
        '
        Me.CBOSTOCKSCATEGORY.BackColor = System.Drawing.Color.Transparent
        Me.CBOSTOCKSCATEGORY.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBOSTOCKSCATEGORY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOSTOCKSCATEGORY.FocusedColor = System.Drawing.Color.Empty
        Me.CBOSTOCKSCATEGORY.FocusedState.Parent = Me.CBOSTOCKSCATEGORY
        Me.CBOSTOCKSCATEGORY.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBOSTOCKSCATEGORY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBOSTOCKSCATEGORY.FormattingEnabled = True
        Me.CBOSTOCKSCATEGORY.HoverState.Parent = Me.CBOSTOCKSCATEGORY
        Me.CBOSTOCKSCATEGORY.ItemHeight = 30
        Me.CBOSTOCKSCATEGORY.Items.AddRange(New Object() {"Admin", "Cashier", "Manager"})
        Me.CBOSTOCKSCATEGORY.ItemsAppearance.Parent = Me.CBOSTOCKSCATEGORY
        Me.CBOSTOCKSCATEGORY.Location = New System.Drawing.Point(189, 27)
        Me.CBOSTOCKSCATEGORY.Name = "CBOSTOCKSCATEGORY"
        Me.CBOSTOCKSCATEGORY.ShadowDecoration.Parent = Me.CBOSTOCKSCATEGORY
        Me.CBOSTOCKSCATEGORY.Size = New System.Drawing.Size(140, 36)
        Me.CBOSTOCKSCATEGORY.TabIndex = 14
        '
        'RPTSTOCKS
        '
        ReportDataSource7.Name = "DataSet1"
        ReportDataSource7.Value = Me.tbl_stocksBindingSource
        Me.RPTSTOCKS.LocalReport.DataSources.Add(ReportDataSource7)
        Me.RPTSTOCKS.LocalReport.ReportEmbeddedResource = "SALESANDINVENTORYSYSTEM.RPTSTOCKS.rdlc"
        Me.RPTSTOCKS.Location = New System.Drawing.Point(20, 80)
        Me.RPTSTOCKS.Name = "RPTSTOCKS"
        Me.RPTSTOCKS.ServerReport.BearerToken = Nothing
        Me.RPTSTOCKS.Size = New System.Drawing.Size(1067, 513)
        Me.RPTSTOCKS.TabIndex = 7
        '
        'TPPRODS
        '
        Me.TPPRODS.Controls.Add(Me.CLEARPRODUCTS)
        Me.TPPRODS.Controls.Add(Me.Label5)
        Me.TPPRODS.Controls.Add(Me.FILTERPRODUCTS)
        Me.TPPRODS.Controls.Add(Me.CBOPRODUCTSCATEGORY)
        Me.TPPRODS.Controls.Add(Me.RPTPRODUCTS)
        Me.TPPRODS.Location = New System.Drawing.Point(4, 29)
        Me.TPPRODS.Name = "TPPRODS"
        Me.TPPRODS.Padding = New System.Windows.Forms.Padding(3)
        Me.TPPRODS.Size = New System.Drawing.Size(1108, 619)
        Me.TPPRODS.TabIndex = 1
        Me.TPPRODS.Text = "Products"
        Me.TPPRODS.UseVisualStyleBackColor = True
        '
        'CLEARPRODUCTS
        '
        Me.CLEARPRODUCTS.BackColor = System.Drawing.Color.Transparent
        Me.CLEARPRODUCTS.CheckedState.Parent = Me.CLEARPRODUCTS
        Me.CLEARPRODUCTS.CustomImages.Parent = Me.CLEARPRODUCTS
        Me.CLEARPRODUCTS.FillColor = System.Drawing.SystemColors.ControlDark
        Me.CLEARPRODUCTS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CLEARPRODUCTS.ForeColor = System.Drawing.Color.White
        Me.CLEARPRODUCTS.HoverState.Parent = Me.CLEARPRODUCTS
        Me.CLEARPRODUCTS.Location = New System.Drawing.Point(497, 27)
        Me.CLEARPRODUCTS.Name = "CLEARPRODUCTS"
        Me.CLEARPRODUCTS.ShadowDecoration.Parent = Me.CLEARPRODUCTS
        Me.CLEARPRODUCTS.Size = New System.Drawing.Size(98, 36)
        Me.CLEARPRODUCTS.TabIndex = 12
        Me.CLEARPRODUCTS.Text = "Clear Filter"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label5.Location = New System.Drawing.Point(16, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Filter by Category"
        '
        'FILTERPRODUCTS
        '
        Me.FILTERPRODUCTS.CheckedState.Parent = Me.FILTERPRODUCTS
        Me.FILTERPRODUCTS.CustomImages.Parent = Me.FILTERPRODUCTS
        Me.FILTERPRODUCTS.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.FILTERPRODUCTS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FILTERPRODUCTS.ForeColor = System.Drawing.Color.White
        Me.FILTERPRODUCTS.HoverState.Parent = Me.FILTERPRODUCTS
        Me.FILTERPRODUCTS.Location = New System.Drawing.Point(372, 27)
        Me.FILTERPRODUCTS.Name = "FILTERPRODUCTS"
        Me.FILTERPRODUCTS.ShadowDecoration.Parent = Me.FILTERPRODUCTS
        Me.FILTERPRODUCTS.Size = New System.Drawing.Size(98, 36)
        Me.FILTERPRODUCTS.TabIndex = 11
        Me.FILTERPRODUCTS.Text = "Filter"
        '
        'CBOPRODUCTSCATEGORY
        '
        Me.CBOPRODUCTSCATEGORY.BackColor = System.Drawing.Color.Transparent
        Me.CBOPRODUCTSCATEGORY.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBOPRODUCTSCATEGORY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOPRODUCTSCATEGORY.FocusedColor = System.Drawing.Color.Empty
        Me.CBOPRODUCTSCATEGORY.FocusedState.Parent = Me.CBOPRODUCTSCATEGORY
        Me.CBOPRODUCTSCATEGORY.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBOPRODUCTSCATEGORY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBOPRODUCTSCATEGORY.FormattingEnabled = True
        Me.CBOPRODUCTSCATEGORY.HoverState.Parent = Me.CBOPRODUCTSCATEGORY
        Me.CBOPRODUCTSCATEGORY.ItemHeight = 30
        Me.CBOPRODUCTSCATEGORY.Items.AddRange(New Object() {"Admin", "Cashier", "Manager"})
        Me.CBOPRODUCTSCATEGORY.ItemsAppearance.Parent = Me.CBOPRODUCTSCATEGORY
        Me.CBOPRODUCTSCATEGORY.Location = New System.Drawing.Point(189, 26)
        Me.CBOPRODUCTSCATEGORY.Name = "CBOPRODUCTSCATEGORY"
        Me.CBOPRODUCTSCATEGORY.ShadowDecoration.Parent = Me.CBOPRODUCTSCATEGORY
        Me.CBOPRODUCTSCATEGORY.Size = New System.Drawing.Size(140, 36)
        Me.CBOPRODUCTSCATEGORY.TabIndex = 10
        '
        'RPTPRODUCTS
        '
        ReportDataSource8.Name = "DataSet1"
        ReportDataSource8.Value = Me.tbl_productsBindingSource
        Me.RPTPRODUCTS.LocalReport.DataSources.Add(ReportDataSource8)
        Me.RPTPRODUCTS.LocalReport.ReportEmbeddedResource = "SALESANDINVENTORYSYSTEM.RPTPRODUCTS.rdlc"
        Me.RPTPRODUCTS.Location = New System.Drawing.Point(20, 80)
        Me.RPTPRODUCTS.Name = "RPTPRODUCTS"
        Me.RPTPRODUCTS.ServerReport.BearerToken = Nothing
        Me.RPTPRODUCTS.Size = New System.Drawing.Size(1067, 513)
        Me.RPTPRODUCTS.TabIndex = 8
        '
        'TPUSERS
        '
        Me.TPUSERS.BackColor = System.Drawing.Color.White
        Me.TPUSERS.Controls.Add(Me.Label6)
        Me.TPUSERS.Controls.Add(Me.LBLUSERNAME)
        Me.TPUSERS.Controls.Add(Me.RPTUSERS)
        Me.TPUSERS.Controls.Add(Me.CLEARUSERS)
        Me.TPUSERS.Controls.Add(Me.Label2)
        Me.TPUSERS.Controls.Add(Me.FILTERUSERS)
        Me.TPUSERS.Controls.Add(Me.CBOUSERS)
        Me.TPUSERS.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.TPUSERS.Location = New System.Drawing.Point(4, 29)
        Me.TPUSERS.Name = "TPUSERS"
        Me.TPUSERS.Padding = New System.Windows.Forms.Padding(3)
        Me.TPUSERS.Size = New System.Drawing.Size(1108, 619)
        Me.TPUSERS.TabIndex = 0
        Me.TPUSERS.Text = "User Accounts"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(890, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Current User :"
        '
        'LBLUSERNAME
        '
        Me.LBLUSERNAME.AutoSize = True
        Me.LBLUSERNAME.Location = New System.Drawing.Point(1004, 44)
        Me.LBLUSERNAME.Name = "LBLUSERNAME"
        Me.LBLUSERNAME.Size = New System.Drawing.Size(83, 20)
        Me.LBLUSERNAME.TabIndex = 5
        Me.LBLUSERNAME.Text = "Username"
        '
        'RPTUSERS
        '
        ReportDataSource9.Name = "DataSet1"
        ReportDataSource9.Value = Me.tbl_usersBindingSource
        Me.RPTUSERS.LocalReport.DataSources.Add(ReportDataSource9)
        Me.RPTUSERS.LocalReport.ReportEmbeddedResource = "SALESANDINVENTORYSYSTEM.RPTUSERS.rdlc"
        Me.RPTUSERS.Location = New System.Drawing.Point(20, 80)
        Me.RPTUSERS.Name = "RPTUSERS"
        Me.RPTUSERS.ServerReport.BearerToken = Nothing
        Me.RPTUSERS.Size = New System.Drawing.Size(1067, 513)
        Me.RPTUSERS.TabIndex = 0
        '
        'CLEARUSERS
        '
        Me.CLEARUSERS.BackColor = System.Drawing.Color.Transparent
        Me.CLEARUSERS.CheckedState.Parent = Me.CLEARUSERS
        Me.CLEARUSERS.CustomImages.Parent = Me.CLEARUSERS
        Me.CLEARUSERS.FillColor = System.Drawing.SystemColors.ControlDark
        Me.CLEARUSERS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CLEARUSERS.ForeColor = System.Drawing.Color.White
        Me.CLEARUSERS.HoverState.Parent = Me.CLEARUSERS
        Me.CLEARUSERS.Location = New System.Drawing.Point(497, 28)
        Me.CLEARUSERS.Name = "CLEARUSERS"
        Me.CLEARUSERS.ShadowDecoration.Parent = Me.CLEARUSERS
        Me.CLEARUSERS.Size = New System.Drawing.Size(98, 36)
        Me.CLEARUSERS.TabIndex = 4
        Me.CLEARUSERS.Text = "Clear Filter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(16, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Filter by Usertype :"
        '
        'FILTERUSERS
        '
        Me.FILTERUSERS.CheckedState.Parent = Me.FILTERUSERS
        Me.FILTERUSERS.CustomImages.Parent = Me.FILTERUSERS
        Me.FILTERUSERS.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.FILTERUSERS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FILTERUSERS.ForeColor = System.Drawing.Color.White
        Me.FILTERUSERS.HoverState.Parent = Me.FILTERUSERS
        Me.FILTERUSERS.Location = New System.Drawing.Point(372, 28)
        Me.FILTERUSERS.Name = "FILTERUSERS"
        Me.FILTERUSERS.ShadowDecoration.Parent = Me.FILTERUSERS
        Me.FILTERUSERS.Size = New System.Drawing.Size(98, 36)
        Me.FILTERUSERS.TabIndex = 3
        Me.FILTERUSERS.Text = "Filter"
        '
        'CBOUSERS
        '
        Me.CBOUSERS.BackColor = System.Drawing.Color.Transparent
        Me.CBOUSERS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBOUSERS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOUSERS.FocusedColor = System.Drawing.Color.Empty
        Me.CBOUSERS.FocusedState.Parent = Me.CBOUSERS
        Me.CBOUSERS.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBOUSERS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBOUSERS.FormattingEnabled = True
        Me.CBOUSERS.HoverState.Parent = Me.CBOUSERS
        Me.CBOUSERS.ItemHeight = 30
        Me.CBOUSERS.Items.AddRange(New Object() {"Admin", "Cashier", "Manager"})
        Me.CBOUSERS.ItemsAppearance.Parent = Me.CBOUSERS
        Me.CBOUSERS.Location = New System.Drawing.Point(189, 27)
        Me.CBOUSERS.Name = "CBOUSERS"
        Me.CBOUSERS.ShadowDecoration.Parent = Me.CBOUSERS
        Me.CBOUSERS.Size = New System.Drawing.Size(140, 36)
        Me.CBOUSERS.TabIndex = 2
        '
        'TCREPORTS
        '
        Me.TCREPORTS.Controls.Add(Me.TPUSERS)
        Me.TCREPORTS.Controls.Add(Me.TPPRODS)
        Me.TCREPORTS.Controls.Add(Me.TPSTOCKS)
        Me.TCREPORTS.Controls.Add(Me.TPDELIVERY)
        Me.TCREPORTS.Controls.Add(Me.TPEXP)
        Me.TCREPORTS.Controls.Add(Me.TPOUT)
        Me.TCREPORTS.Controls.Add(Me.TPSALES)
        Me.TCREPORTS.Controls.Add(Me.TPACT)
        Me.TCREPORTS.Controls.Add(Me.TPTRANSREC)
        Me.TCREPORTS.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.TCREPORTS.Location = New System.Drawing.Point(-1, 31)
        Me.TCREPORTS.Name = "TCREPORTS"
        Me.TCREPORTS.SelectedIndex = 0
        Me.TCREPORTS.Size = New System.Drawing.Size(1116, 652)
        Me.TCREPORTS.TabIndex = 23
        '
        'tbl_productsTableAdapter
        '
        Me.tbl_productsTableAdapter.ClearBeforeFill = True
        '
        'tbl_salesTableAdapter
        '
        Me.tbl_salesTableAdapter.ClearBeforeFill = True
        '
        'tbl_usersTableAdapter
        '
        Me.tbl_usersTableAdapter.ClearBeforeFill = True
        '
        'tbl_expiredproductsTableAdapter
        '
        Me.tbl_expiredproductsTableAdapter.ClearBeforeFill = True
        '
        'tbl_stocksTableAdapter
        '
        Me.tbl_stocksTableAdapter.ClearBeforeFill = True
        '
        'tbl_deliveryTableAdapter
        '
        Me.tbl_deliveryTableAdapter.ClearBeforeFill = True
        '
        'FRMREPORTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1107, 682)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TCREPORTS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMREPORTS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports"
        CType(Me.tbl_usersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inventory_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_salesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_expiredproductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_deliveryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_stocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPTRANSREC.ResumeLayout(False)
        Me.TPTRANSREC.PerformLayout()
        Me.TPACT.ResumeLayout(False)
        Me.TPACT.PerformLayout()
        Me.TPSALES.ResumeLayout(False)
        Me.TPSALES.PerformLayout()
        Me.TPOUT.ResumeLayout(False)
        Me.TPOUT.PerformLayout()
        Me.TPEXP.ResumeLayout(False)
        Me.TPEXP.PerformLayout()
        Me.TPDELIVERY.ResumeLayout(False)
        Me.TPDELIVERY.PerformLayout()
        Me.TPSTOCKS.ResumeLayout(False)
        Me.TPSTOCKS.PerformLayout()
        Me.TPPRODS.ResumeLayout(False)
        Me.TPPRODS.PerformLayout()
        Me.TPUSERS.ResumeLayout(False)
        Me.TPUSERS.PerformLayout()
        Me.TCREPORTS.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbl_productsBindingSource As BindingSource
    Friend WithEvents inventory_dbDataSet As inventory_dbDataSet
    Friend WithEvents tbl_productsTableAdapter As inventory_dbDataSetTableAdapters.tbl_productsTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbl_salesBindingSource As BindingSource
    Friend WithEvents tbl_salesTableAdapter As inventory_dbDataSetTableAdapters.tbl_salesTableAdapter
    Friend WithEvents TPTRANSREC As TabPage
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents BTNCLRTRANS As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNFILLTRANS As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DT2 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents DT1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents RPTTRANSACTIONRECORDS As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TPACT As TabPage
    Friend WithEvents ACTCLR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ACTFILL As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CBOTYPE As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RPTACTLOG As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TPSALES As TabPage
    Friend WithEvents MONTHLY As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents WEEKLY As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents DAILY As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents CLEARSALES As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents FILTERSALES As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents RPTSALES As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TPOUT As TabPage
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents OUTCLR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OUTFILL As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Date2OUT As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Date1OUT As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents RPTOUTOFSTOCKS As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TPEXP As TabPage
    Friend WithEvents RPTEXP As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents EXPCLR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents EXPFILL As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DAte2EXP As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Date1EXP As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents TPDELIVERY As TabPage
    Friend WithEvents MONTHLYDELIVERY As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents WEEKLYDELIVERY As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents DAILYDELIVERY As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents CLEARDELIVERY As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents FILTERDELIVERY As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TPSTOCKS As TabPage
    Friend WithEvents TPPRODS As TabPage
    Friend WithEvents CLEARPRODUCTS As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents FILTERPRODUCTS As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CBOPRODUCTSCATEGORY As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents RPTPRODUCTS As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TPUSERS As TabPage
    Friend WithEvents RPTUSERS As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CLEARUSERS As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents FILTERUSERS As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CBOUSERS As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TCREPORTS As TabControl
    Friend WithEvents tbl_usersBindingSource As BindingSource
    Friend WithEvents tbl_usersTableAdapter As inventory_dbDataSetTableAdapters.tbl_usersTableAdapter
    Friend WithEvents CLEARSTOCKS As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents FILTERSTOCKS As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CBOSTOCKSCATEGORY As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LBLUSERNAME As Label
    Friend WithEvents RPTSTOCKS As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RPTDELIVERY As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_expiredproductsBindingSource As BindingSource
    Friend WithEvents tbl_expiredproductsTableAdapter As inventory_dbDataSetTableAdapters.tbl_expiredproductsTableAdapter
    Friend WithEvents tbl_stocksBindingSource As BindingSource
    Friend WithEvents tbl_stocksTableAdapter As inventory_dbDataSetTableAdapters.tbl_stocksTableAdapter
    Friend WithEvents tbl_deliveryBindingSource As BindingSource
    Friend WithEvents tbl_deliveryTableAdapter As inventory_dbDataSetTableAdapters.tbl_deliveryTableAdapter
End Class
