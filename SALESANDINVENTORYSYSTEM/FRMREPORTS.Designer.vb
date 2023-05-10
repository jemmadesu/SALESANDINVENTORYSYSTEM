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
        Me.tbl_actlogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.inventory_dbDataSet = New SALESANDINVENTORYSYSTEM.inventory_dbDataSet()
        Me.tbl_salesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbl_stocksoutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbl_supplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbl_productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbl_usersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbl_stocksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbl_transactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbl_expiredprodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TPACT = New System.Windows.Forms.TabPage()
        Me.ACTCLR = New Guna.UI2.WinForms.Guna2Button()
        Me.ACTFILL = New Guna.UI2.WinForms.Guna2Button()
        Me.CBOTYPE = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RPTACTLOG = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TPSALES = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SALESCLR = New Guna.UI2.WinForms.Guna2Button()
        Me.SALESFILL = New Guna.UI2.WinForms.Guna2Button()
        Me.Date2SALES = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Date1SALES = New Guna.UI2.WinForms.Guna2DateTimePicker()
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
        Me.TPSUP = New System.Windows.Forms.TabPage()
        Me.RPTSUP = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TPPRODS = New System.Windows.Forms.TabPage()
        Me.BTNCLR = New System.Windows.Forms.Button()
        Me.BTNFILL = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Date2 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Date1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.RPTPRODUCTS = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TPUSERS = New System.Windows.Forms.TabPage()
        Me.RPTUSERS = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BTNCLEAR = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTNFILTER = New Guna.UI2.WinForms.Guna2Button()
        Me.CBOUT = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TCREPORTS = New System.Windows.Forms.TabControl()
        Me.TPSTOCKS = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.STOCKCLR = New Guna.UI2.WinForms.Guna2Button()
        Me.STOCKSFILL = New Guna.UI2.WinForms.Guna2Button()
        Me.Date2St = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Date1St = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.RPTSTOCKS = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TPTRANSREC = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BTNCLRTRANS = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNFILLTRANS = New Guna.UI2.WinForms.Guna2Button()
        Me.DT2 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.DT1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.RPTTRANSACTIONRECORDS = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BTNCLOSE = New System.Windows.Forms.Button()
        Me.tbl_usersTableAdapter = New SALESANDINVENTORYSYSTEM.inventory_dbDataSetTableAdapters.tbl_usersTableAdapter()
        Me.tbl_salesTableAdapter = New SALESANDINVENTORYSYSTEM.inventory_dbDataSetTableAdapters.tbl_salesTableAdapter()
        Me.tbl_supplierTableAdapter = New SALESANDINVENTORYSYSTEM.inventory_dbDataSetTableAdapters.tbl_supplierTableAdapter()
        Me.tbl_actlogTableAdapter = New SALESANDINVENTORYSYSTEM.inventory_dbDataSetTableAdapters.tbl_actlogTableAdapter()
        Me.tbl_stocksTableAdapter = New SALESANDINVENTORYSYSTEM.inventory_dbDataSetTableAdapters.tbl_stocksTableAdapter()
        Me.tbl_productsTableAdapter = New SALESANDINVENTORYSYSTEM.inventory_dbDataSetTableAdapters.tbl_productsTableAdapter()
        Me.tbl_transactionTableAdapter = New SALESANDINVENTORYSYSTEM.inventory_dbDataSetTableAdapters.tbl_transactionTableAdapter()
        Me.tbl_stocksoutTableAdapter = New SALESANDINVENTORYSYSTEM.inventory_dbDataSetTableAdapters.tbl_stocksoutTableAdapter()
        Me.tbl_expiredprodTableAdapter = New SALESANDINVENTORYSYSTEM.inventory_dbDataSetTableAdapters.tbl_expiredprodTableAdapter()
        CType(Me.tbl_actlogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inventory_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_salesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_stocksoutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_supplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_usersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_stocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_transactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_expiredprodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPACT.SuspendLayout()
        Me.TPSALES.SuspendLayout()
        Me.TPOUT.SuspendLayout()
        Me.TPEXP.SuspendLayout()
        Me.TPSUP.SuspendLayout()
        Me.TPPRODS.SuspendLayout()
        Me.TPUSERS.SuspendLayout()
        Me.TCREPORTS.SuspendLayout()
        Me.TPSTOCKS.SuspendLayout()
        Me.TPTRANSREC.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbl_actlogBindingSource
        '
        Me.tbl_actlogBindingSource.DataMember = "tbl_actlog"
        Me.tbl_actlogBindingSource.DataSource = Me.inventory_dbDataSet
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
        'tbl_stocksoutBindingSource
        '
        Me.tbl_stocksoutBindingSource.DataMember = "tbl_stocksout"
        Me.tbl_stocksoutBindingSource.DataSource = Me.inventory_dbDataSet
        '
        'tbl_supplierBindingSource
        '
        Me.tbl_supplierBindingSource.DataMember = "tbl_supplier"
        Me.tbl_supplierBindingSource.DataSource = Me.inventory_dbDataSet
        '
        'tbl_productsBindingSource
        '
        Me.tbl_productsBindingSource.DataMember = "tbl_products"
        Me.tbl_productsBindingSource.DataSource = Me.inventory_dbDataSet
        '
        'tbl_usersBindingSource
        '
        Me.tbl_usersBindingSource.DataMember = "tbl_users"
        Me.tbl_usersBindingSource.DataSource = Me.inventory_dbDataSet
        '
        'tbl_stocksBindingSource
        '
        Me.tbl_stocksBindingSource.DataMember = "tbl_stocks"
        Me.tbl_stocksBindingSource.DataSource = Me.inventory_dbDataSet
        '
        'tbl_transactionBindingSource
        '
        Me.tbl_transactionBindingSource.DataMember = "tbl_transaction"
        Me.tbl_transactionBindingSource.DataSource = Me.inventory_dbDataSet
        '
        'tbl_expiredprodBindingSource
        '
        Me.tbl_expiredprodBindingSource.DataMember = "tbl_expiredprod"
        Me.tbl_expiredprodBindingSource.DataSource = Me.inventory_dbDataSet
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
        ReportDataSource1.Name = "DataSet_ACT"
        ReportDataSource1.Value = Me.tbl_actlogBindingSource
        Me.RPTACTLOG.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RPTACTLOG.LocalReport.ReportEmbeddedResource = "SALESANDINVENTORYSYSTEM.RPTACTLOG.rdlc"
        Me.RPTACTLOG.Location = New System.Drawing.Point(20, 80)
        Me.RPTACTLOG.Name = "RPTACTLOG"
        Me.RPTACTLOG.ServerReport.BearerToken = Nothing
        Me.RPTACTLOG.Size = New System.Drawing.Size(1067, 513)
        Me.RPTACTLOG.TabIndex = 1
        '
        'TPSALES
        '
        Me.TPSALES.Controls.Add(Me.Label12)
        Me.TPSALES.Controls.Add(Me.Label11)
        Me.TPSALES.Controls.Add(Me.SALESCLR)
        Me.TPSALES.Controls.Add(Me.SALESFILL)
        Me.TPSALES.Controls.Add(Me.Date2SALES)
        Me.TPSALES.Controls.Add(Me.Date1SALES)
        Me.TPSALES.Controls.Add(Me.RPTSALES)
        Me.TPSALES.Location = New System.Drawing.Point(4, 29)
        Me.TPSALES.Name = "TPSALES"
        Me.TPSALES.Padding = New System.Windows.Forms.Padding(3)
        Me.TPSALES.Size = New System.Drawing.Size(1108, 619)
        Me.TPSALES.TabIndex = 4
        Me.TPSALES.Text = "Sales Report"
        Me.TPSALES.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(313, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 20)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "To :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(27, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 20)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "From :"
        '
        'SALESCLR
        '
        Me.SALESCLR.BackColor = System.Drawing.Color.Transparent
        Me.SALESCLR.CheckedState.Parent = Me.SALESCLR
        Me.SALESCLR.CustomImages.Parent = Me.SALESCLR
        Me.SALESCLR.FillColor = System.Drawing.SystemColors.ControlDark
        Me.SALESCLR.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.SALESCLR.ForeColor = System.Drawing.Color.White
        Me.SALESCLR.HoverState.Parent = Me.SALESCLR
        Me.SALESCLR.Location = New System.Drawing.Point(740, 27)
        Me.SALESCLR.Name = "SALESCLR"
        Me.SALESCLR.ShadowDecoration.Parent = Me.SALESCLR
        Me.SALESCLR.Size = New System.Drawing.Size(98, 36)
        Me.SALESCLR.TabIndex = 14
        Me.SALESCLR.Text = "Clear Filter"
        '
        'SALESFILL
        '
        Me.SALESFILL.CheckedState.Parent = Me.SALESFILL
        Me.SALESFILL.CustomImages.Parent = Me.SALESFILL
        Me.SALESFILL.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.SALESFILL.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.SALESFILL.ForeColor = System.Drawing.Color.White
        Me.SALESFILL.HoverState.Parent = Me.SALESFILL
        Me.SALESFILL.Location = New System.Drawing.Point(610, 26)
        Me.SALESFILL.Name = "SALESFILL"
        Me.SALESFILL.ShadowDecoration.Parent = Me.SALESFILL
        Me.SALESFILL.Size = New System.Drawing.Size(98, 36)
        Me.SALESFILL.TabIndex = 13
        Me.SALESFILL.Text = "Filter"
        '
        'Date2SALES
        '
        Me.Date2SALES.CheckedState.Parent = Me.Date2SALES
        Me.Date2SALES.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.Date2SALES.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date2SALES.ForeColor = System.Drawing.Color.White
        Me.Date2SALES.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Date2SALES.HoverState.Parent = Me.Date2SALES
        Me.Date2SALES.Location = New System.Drawing.Point(372, 26)
        Me.Date2SALES.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Date2SALES.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Date2SALES.Name = "Date2SALES"
        Me.Date2SALES.ShadowDecoration.Parent = Me.Date2SALES
        Me.Date2SALES.Size = New System.Drawing.Size(200, 36)
        Me.Date2SALES.TabIndex = 12
        Me.Date2SALES.Value = New Date(2023, 4, 15, 23, 18, 1, 623)
        '
        'Date1SALES
        '
        Me.Date1SALES.CheckedState.Parent = Me.Date1SALES
        Me.Date1SALES.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.Date1SALES.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date1SALES.ForeColor = System.Drawing.Color.White
        Me.Date1SALES.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Date1SALES.HoverState.Parent = Me.Date1SALES
        Me.Date1SALES.Location = New System.Drawing.Point(90, 26)
        Me.Date1SALES.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Date1SALES.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Date1SALES.Name = "Date1SALES"
        Me.Date1SALES.ShadowDecoration.Parent = Me.Date1SALES
        Me.Date1SALES.Size = New System.Drawing.Size(200, 36)
        Me.Date1SALES.TabIndex = 11
        Me.Date1SALES.Value = New Date(2023, 4, 15, 23, 18, 1, 623)
        '
        'RPTSALES
        '
        ReportDataSource2.Name = "DataSet_Sales"
        ReportDataSource2.Value = Me.tbl_salesBindingSource
        Me.RPTSALES.LocalReport.DataSources.Add(ReportDataSource2)
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
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.tbl_stocksoutBindingSource
        Me.RPTOUTOFSTOCKS.LocalReport.DataSources.Add(ReportDataSource3)
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
        ReportDataSource4.Name = "DataSet1"
        ReportDataSource4.Value = Me.tbl_expiredprodBindingSource
        Me.RPTEXP.LocalReport.DataSources.Add(ReportDataSource4)
        Me.RPTEXP.LocalReport.ReportEmbeddedResource = "SALESANDINVENTORYSYSTEM.RPTEXP.rdlc"
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
        'TPSUP
        '
        Me.TPSUP.Controls.Add(Me.RPTSUP)
        Me.TPSUP.Location = New System.Drawing.Point(4, 29)
        Me.TPSUP.Name = "TPSUP"
        Me.TPSUP.Padding = New System.Windows.Forms.Padding(3)
        Me.TPSUP.Size = New System.Drawing.Size(1108, 619)
        Me.TPSUP.TabIndex = 6
        Me.TPSUP.Text = "Supplier"
        Me.TPSUP.UseVisualStyleBackColor = True
        '
        'RPTSUP
        '
        ReportDataSource5.Name = "DataSet_SUPPLIER"
        ReportDataSource5.Value = Me.tbl_supplierBindingSource
        Me.RPTSUP.LocalReport.DataSources.Add(ReportDataSource5)
        Me.RPTSUP.LocalReport.ReportEmbeddedResource = "SALESANDINVENTORYSYSTEM.RPTSUPPLIER.rdlc"
        Me.RPTSUP.Location = New System.Drawing.Point(20, 80)
        Me.RPTSUP.Name = "RPTSUP"
        Me.RPTSUP.ServerReport.BearerToken = Nothing
        Me.RPTSUP.Size = New System.Drawing.Size(1067, 513)
        Me.RPTSUP.TabIndex = 1
        '
        'TPPRODS
        '
        Me.TPPRODS.Controls.Add(Me.BTNCLR)
        Me.TPPRODS.Controls.Add(Me.BTNFILL)
        Me.TPPRODS.Controls.Add(Me.Label6)
        Me.TPPRODS.Controls.Add(Me.Label5)
        Me.TPPRODS.Controls.Add(Me.Date2)
        Me.TPPRODS.Controls.Add(Me.Date1)
        Me.TPPRODS.Controls.Add(Me.RPTPRODUCTS)
        Me.TPPRODS.Location = New System.Drawing.Point(4, 29)
        Me.TPPRODS.Name = "TPPRODS"
        Me.TPPRODS.Padding = New System.Windows.Forms.Padding(3)
        Me.TPPRODS.Size = New System.Drawing.Size(1108, 619)
        Me.TPPRODS.TabIndex = 1
        Me.TPPRODS.Text = "Products"
        Me.TPPRODS.UseVisualStyleBackColor = True
        '
        'BTNCLR
        '
        Me.BTNCLR.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BTNCLR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCLR.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCLR.ForeColor = System.Drawing.Color.White
        Me.BTNCLR.Location = New System.Drawing.Point(740, 27)
        Me.BTNCLR.Name = "BTNCLR"
        Me.BTNCLR.Size = New System.Drawing.Size(98, 36)
        Me.BTNCLR.TabIndex = 47
        Me.BTNCLR.Text = "Clear Filter"
        Me.BTNCLR.UseVisualStyleBackColor = False
        '
        'BTNFILL
        '
        Me.BTNFILL.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BTNFILL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNFILL.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNFILL.ForeColor = System.Drawing.Color.White
        Me.BTNFILL.Location = New System.Drawing.Point(610, 26)
        Me.BTNFILL.Name = "BTNFILL"
        Me.BTNFILL.Size = New System.Drawing.Size(98, 36)
        Me.BTNFILL.TabIndex = 46
        Me.BTNFILL.Text = "Filter"
        Me.BTNFILL.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(313, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "To :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "From :"
        '
        'Date2
        '
        Me.Date2.CheckedState.Parent = Me.Date2
        Me.Date2.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.Date2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Date2.ForeColor = System.Drawing.Color.White
        Me.Date2.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Date2.HoverState.Parent = Me.Date2
        Me.Date2.Location = New System.Drawing.Point(372, 26)
        Me.Date2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Date2.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Date2.Name = "Date2"
        Me.Date2.ShadowDecoration.Parent = Me.Date2
        Me.Date2.Size = New System.Drawing.Size(200, 36)
        Me.Date2.TabIndex = 10
        Me.Date2.Value = New Date(2023, 5, 7, 4, 55, 16, 541)
        '
        'Date1
        '
        Me.Date1.CheckedState.Parent = Me.Date1
        Me.Date1.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.Date1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Date1.ForeColor = System.Drawing.Color.White
        Me.Date1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Date1.HoverState.Parent = Me.Date1
        Me.Date1.Location = New System.Drawing.Point(90, 26)
        Me.Date1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Date1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Date1.Name = "Date1"
        Me.Date1.ShadowDecoration.Parent = Me.Date1
        Me.Date1.Size = New System.Drawing.Size(200, 36)
        Me.Date1.TabIndex = 9
        Me.Date1.Value = New Date(2023, 5, 7, 4, 53, 45, 171)
        '
        'RPTPRODUCTS
        '
        ReportDataSource6.Name = "DataSet1"
        ReportDataSource6.Value = Me.tbl_productsBindingSource
        Me.RPTPRODUCTS.LocalReport.DataSources.Add(ReportDataSource6)
        Me.RPTPRODUCTS.LocalReport.ReportEmbeddedResource = "SALESANDINVENTORYSYSTEM.RPTPRODUCTS.rdlc"
        Me.RPTPRODUCTS.Location = New System.Drawing.Point(20, 80)
        Me.RPTPRODUCTS.Name = "RPTPRODUCTS"
        Me.RPTPRODUCTS.ServerReport.BearerToken = Nothing
        Me.RPTPRODUCTS.Size = New System.Drawing.Size(1067, 513)
        Me.RPTPRODUCTS.TabIndex = 8
        '
        'TPUSERS
        '
        Me.TPUSERS.Controls.Add(Me.RPTUSERS)
        Me.TPUSERS.Controls.Add(Me.BTNCLEAR)
        Me.TPUSERS.Controls.Add(Me.Label2)
        Me.TPUSERS.Controls.Add(Me.BTNFILTER)
        Me.TPUSERS.Controls.Add(Me.CBOUT)
        Me.TPUSERS.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.TPUSERS.Location = New System.Drawing.Point(4, 29)
        Me.TPUSERS.Name = "TPUSERS"
        Me.TPUSERS.Padding = New System.Windows.Forms.Padding(3)
        Me.TPUSERS.Size = New System.Drawing.Size(1108, 619)
        Me.TPUSERS.TabIndex = 0
        Me.TPUSERS.Text = "User Accounts"
        Me.TPUSERS.UseVisualStyleBackColor = True
        '
        'RPTUSERS
        '
        ReportDataSource7.Name = "DataSet_useraccounts"
        ReportDataSource7.Value = Me.tbl_usersBindingSource
        Me.RPTUSERS.LocalReport.DataSources.Add(ReportDataSource7)
        Me.RPTUSERS.LocalReport.ReportEmbeddedResource = "SALESANDINVENTORYSYSTEM.RPTUSERACCOUNTS.rdlc"
        Me.RPTUSERS.Location = New System.Drawing.Point(20, 80)
        Me.RPTUSERS.Name = "RPTUSERS"
        Me.RPTUSERS.ServerReport.BearerToken = Nothing
        Me.RPTUSERS.Size = New System.Drawing.Size(1067, 513)
        Me.RPTUSERS.TabIndex = 0
        '
        'BTNCLEAR
        '
        Me.BTNCLEAR.BackColor = System.Drawing.Color.Transparent
        Me.BTNCLEAR.CheckedState.Parent = Me.BTNCLEAR
        Me.BTNCLEAR.CustomImages.Parent = Me.BTNCLEAR
        Me.BTNCLEAR.FillColor = System.Drawing.SystemColors.ControlDark
        Me.BTNCLEAR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNCLEAR.ForeColor = System.Drawing.Color.White
        Me.BTNCLEAR.HoverState.Parent = Me.BTNCLEAR
        Me.BTNCLEAR.Location = New System.Drawing.Point(507, 25)
        Me.BTNCLEAR.Name = "BTNCLEAR"
        Me.BTNCLEAR.ShadowDecoration.Parent = Me.BTNCLEAR
        Me.BTNCLEAR.Size = New System.Drawing.Size(98, 36)
        Me.BTNCLEAR.TabIndex = 4
        Me.BTNCLEAR.Text = "Clear Filter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(26, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Filter by usertype :"
        '
        'BTNFILTER
        '
        Me.BTNFILTER.CheckedState.Parent = Me.BTNFILTER
        Me.BTNFILTER.CustomImages.Parent = Me.BTNFILTER
        Me.BTNFILTER.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTNFILTER.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNFILTER.ForeColor = System.Drawing.Color.White
        Me.BTNFILTER.HoverState.Parent = Me.BTNFILTER
        Me.BTNFILTER.Location = New System.Drawing.Point(382, 25)
        Me.BTNFILTER.Name = "BTNFILTER"
        Me.BTNFILTER.ShadowDecoration.Parent = Me.BTNFILTER
        Me.BTNFILTER.Size = New System.Drawing.Size(98, 36)
        Me.BTNFILTER.TabIndex = 3
        Me.BTNFILTER.Text = "Filter"
        '
        'CBOUT
        '
        Me.CBOUT.BackColor = System.Drawing.Color.Transparent
        Me.CBOUT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBOUT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOUT.FocusedColor = System.Drawing.Color.Empty
        Me.CBOUT.FocusedState.Parent = Me.CBOUT
        Me.CBOUT.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBOUT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBOUT.FormattingEnabled = True
        Me.CBOUT.HoverState.Parent = Me.CBOUT
        Me.CBOUT.ItemHeight = 30
        Me.CBOUT.Items.AddRange(New Object() {"Admin", "Cashier", "Manager"})
        Me.CBOUT.ItemsAppearance.Parent = Me.CBOUT
        Me.CBOUT.Location = New System.Drawing.Point(199, 24)
        Me.CBOUT.Name = "CBOUT"
        Me.CBOUT.ShadowDecoration.Parent = Me.CBOUT
        Me.CBOUT.Size = New System.Drawing.Size(140, 36)
        Me.CBOUT.TabIndex = 2
        '
        'TCREPORTS
        '
        Me.TCREPORTS.Controls.Add(Me.TPUSERS)
        Me.TCREPORTS.Controls.Add(Me.TPPRODS)
        Me.TCREPORTS.Controls.Add(Me.TPSTOCKS)
        Me.TCREPORTS.Controls.Add(Me.TPSUP)
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
        'TPSTOCKS
        '
        Me.TPSTOCKS.Controls.Add(Me.Label4)
        Me.TPSTOCKS.Controls.Add(Me.Label3)
        Me.TPSTOCKS.Controls.Add(Me.STOCKCLR)
        Me.TPSTOCKS.Controls.Add(Me.STOCKSFILL)
        Me.TPSTOCKS.Controls.Add(Me.Date2St)
        Me.TPSTOCKS.Controls.Add(Me.Date1St)
        Me.TPSTOCKS.Controls.Add(Me.RPTSTOCKS)
        Me.TPSTOCKS.Location = New System.Drawing.Point(4, 29)
        Me.TPSTOCKS.Name = "TPSTOCKS"
        Me.TPSTOCKS.Size = New System.Drawing.Size(1108, 619)
        Me.TPSTOCKS.TabIndex = 7
        Me.TPSTOCKS.Text = "Stocks"
        Me.TPSTOCKS.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(313, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "To :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "From :"
        '
        'STOCKCLR
        '
        Me.STOCKCLR.BackColor = System.Drawing.Color.Transparent
        Me.STOCKCLR.CheckedState.Parent = Me.STOCKCLR
        Me.STOCKCLR.CustomImages.Parent = Me.STOCKCLR
        Me.STOCKCLR.FillColor = System.Drawing.SystemColors.ControlDark
        Me.STOCKCLR.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.STOCKCLR.ForeColor = System.Drawing.Color.White
        Me.STOCKCLR.HoverState.Parent = Me.STOCKCLR
        Me.STOCKCLR.Location = New System.Drawing.Point(740, 27)
        Me.STOCKCLR.Name = "STOCKCLR"
        Me.STOCKCLR.ShadowDecoration.Parent = Me.STOCKCLR
        Me.STOCKCLR.Size = New System.Drawing.Size(98, 36)
        Me.STOCKCLR.TabIndex = 11
        Me.STOCKCLR.Text = "Clear Filter"
        '
        'STOCKSFILL
        '
        Me.STOCKSFILL.CheckedState.Parent = Me.STOCKSFILL
        Me.STOCKSFILL.CustomImages.Parent = Me.STOCKSFILL
        Me.STOCKSFILL.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.STOCKSFILL.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.STOCKSFILL.ForeColor = System.Drawing.Color.White
        Me.STOCKSFILL.HoverState.Parent = Me.STOCKSFILL
        Me.STOCKSFILL.Location = New System.Drawing.Point(610, 26)
        Me.STOCKSFILL.Name = "STOCKSFILL"
        Me.STOCKSFILL.ShadowDecoration.Parent = Me.STOCKSFILL
        Me.STOCKSFILL.Size = New System.Drawing.Size(98, 36)
        Me.STOCKSFILL.TabIndex = 10
        Me.STOCKSFILL.Text = "Filter"
        '
        'Date2St
        '
        Me.Date2St.CheckedState.Parent = Me.Date2St
        Me.Date2St.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.Date2St.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date2St.ForeColor = System.Drawing.Color.White
        Me.Date2St.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Date2St.HoverState.Parent = Me.Date2St
        Me.Date2St.Location = New System.Drawing.Point(372, 26)
        Me.Date2St.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Date2St.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Date2St.Name = "Date2St"
        Me.Date2St.ShadowDecoration.Parent = Me.Date2St
        Me.Date2St.Size = New System.Drawing.Size(200, 36)
        Me.Date2St.TabIndex = 9
        Me.Date2St.Value = New Date(2023, 4, 15, 23, 18, 1, 623)
        '
        'Date1St
        '
        Me.Date1St.CheckedState.Parent = Me.Date1St
        Me.Date1St.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.Date1St.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date1St.ForeColor = System.Drawing.Color.White
        Me.Date1St.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Date1St.HoverState.Parent = Me.Date1St
        Me.Date1St.Location = New System.Drawing.Point(90, 26)
        Me.Date1St.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Date1St.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Date1St.Name = "Date1St"
        Me.Date1St.ShadowDecoration.Parent = Me.Date1St
        Me.Date1St.Size = New System.Drawing.Size(200, 36)
        Me.Date1St.TabIndex = 8
        Me.Date1St.Value = New Date(2023, 4, 15, 23, 18, 1, 623)
        '
        'RPTSTOCKS
        '
        ReportDataSource8.Name = "inv_db"
        ReportDataSource8.Value = Me.tbl_stocksBindingSource
        Me.RPTSTOCKS.LocalReport.DataSources.Add(ReportDataSource8)
        Me.RPTSTOCKS.LocalReport.ReportEmbeddedResource = "SALESANDINVENTORYSYSTEM.RPTSTOCKS.rdlc"
        Me.RPTSTOCKS.Location = New System.Drawing.Point(20, 80)
        Me.RPTSTOCKS.Name = "RPTSTOCKS"
        Me.RPTSTOCKS.ServerReport.BearerToken = Nothing
        Me.RPTSTOCKS.Size = New System.Drawing.Size(1067, 513)
        Me.RPTSTOCKS.TabIndex = 7
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
        ReportDataSource9.Name = "DataSet1"
        ReportDataSource9.Value = Me.tbl_transactionBindingSource
        Me.RPTTRANSACTIONRECORDS.LocalReport.DataSources.Add(ReportDataSource9)
        Me.RPTTRANSACTIONRECORDS.LocalReport.ReportEmbeddedResource = "SALESANDINVENTORYSYSTEM.RPTTRANSACTIONRECORDS.rdlc"
        Me.RPTTRANSACTIONRECORDS.Location = New System.Drawing.Point(20, 80)
        Me.RPTTRANSACTIONRECORDS.Name = "RPTTRANSACTIONRECORDS"
        Me.RPTTRANSACTIONRECORDS.ServerReport.BearerToken = Nothing
        Me.RPTTRANSACTIONRECORDS.Size = New System.Drawing.Size(1067, 513)
        Me.RPTTRANSACTIONRECORDS.TabIndex = 2
        '
        'BTNCLOSE
        '
        Me.BTNCLOSE.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BTNCLOSE.FlatAppearance.BorderSize = 0
        Me.BTNCLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCLOSE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNCLOSE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BTNCLOSE.Location = New System.Drawing.Point(1026, 12)
        Me.BTNCLOSE.Name = "BTNCLOSE"
        Me.BTNCLOSE.Size = New System.Drawing.Size(75, 30)
        Me.BTNCLOSE.TabIndex = 5
        Me.BTNCLOSE.Text = "Close"
        Me.BTNCLOSE.UseVisualStyleBackColor = False
        '
        'tbl_usersTableAdapter
        '
        Me.tbl_usersTableAdapter.ClearBeforeFill = True
        '
        'tbl_salesTableAdapter
        '
        Me.tbl_salesTableAdapter.ClearBeforeFill = True
        '
        'tbl_supplierTableAdapter
        '
        Me.tbl_supplierTableAdapter.ClearBeforeFill = True
        '
        'tbl_actlogTableAdapter
        '
        Me.tbl_actlogTableAdapter.ClearBeforeFill = True
        '
        'tbl_stocksTableAdapter
        '
        Me.tbl_stocksTableAdapter.ClearBeforeFill = True
        '
        'tbl_productsTableAdapter
        '
        Me.tbl_productsTableAdapter.ClearBeforeFill = True
        '
        'tbl_transactionTableAdapter
        '
        Me.tbl_transactionTableAdapter.ClearBeforeFill = True
        '
        'tbl_stocksoutTableAdapter
        '
        Me.tbl_stocksoutTableAdapter.ClearBeforeFill = True
        '
        'tbl_expiredprodTableAdapter
        '
        Me.tbl_expiredprodTableAdapter.ClearBeforeFill = True
        '
        'FRMREPORTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1113, 682)
        Me.Controls.Add(Me.BTNCLOSE)
        Me.Controls.Add(Me.TCREPORTS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRMREPORTS"
        Me.Text = "FRMREPORTS"
        CType(Me.tbl_actlogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inventory_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_salesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_stocksoutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_supplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_usersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_stocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_transactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_expiredprodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPACT.ResumeLayout(False)
        Me.TPACT.PerformLayout()
        Me.TPSALES.ResumeLayout(False)
        Me.TPSALES.PerformLayout()
        Me.TPOUT.ResumeLayout(False)
        Me.TPOUT.PerformLayout()
        Me.TPEXP.ResumeLayout(False)
        Me.TPEXP.PerformLayout()
        Me.TPSUP.ResumeLayout(False)
        Me.TPPRODS.ResumeLayout(False)
        Me.TPPRODS.PerformLayout()
        Me.TPUSERS.ResumeLayout(False)
        Me.TPUSERS.PerformLayout()
        Me.TCREPORTS.ResumeLayout(False)
        Me.TPSTOCKS.ResumeLayout(False)
        Me.TPSTOCKS.PerformLayout()
        Me.TPTRANSREC.ResumeLayout(False)
        Me.TPTRANSREC.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbl_usersBindingSource As BindingSource
    Friend WithEvents inventory_dbDataSet As inventory_dbDataSet
    Friend WithEvents tbl_usersTableAdapter As inventory_dbDataSetTableAdapters.tbl_usersTableAdapter
    Friend WithEvents tbl_salesBindingSource As BindingSource
    Friend WithEvents tbl_salesTableAdapter As inventory_dbDataSetTableAdapters.tbl_salesTableAdapter
    Friend WithEvents tbl_supplierBindingSource As BindingSource
    Friend WithEvents tbl_supplierTableAdapter As inventory_dbDataSetTableAdapters.tbl_supplierTableAdapter
    Friend WithEvents tbl_actlogBindingSource As BindingSource
    Friend WithEvents tbl_actlogTableAdapter As inventory_dbDataSetTableAdapters.tbl_actlogTableAdapter
    Friend WithEvents TPACT As TabPage
    Friend WithEvents ACTCLR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ACTFILL As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CBOTYPE As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RPTACTLOG As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TPSALES As TabPage
    Friend WithEvents SALESCLR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SALESFILL As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Date2SALES As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Date1SALES As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents RPTSALES As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TPOUT As TabPage
    Friend WithEvents OUTCLR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OUTFILL As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Date2OUT As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Date1OUT As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents RPTOUTOFSTOCKS As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TPEXP As TabPage
    Friend WithEvents EXPCLR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents EXPFILL As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DAte2EXP As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Date1EXP As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents TPSUP As TabPage
    Friend WithEvents RPTSUP As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TPPRODS As TabPage
    Friend WithEvents TPUSERS As TabPage
    Friend WithEvents RPTUSERS As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BTNCLEAR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BTNFILTER As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CBOUT As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TCREPORTS As TabControl
    Friend WithEvents BTNCLOSE As Button
    Friend WithEvents TPSTOCKS As TabPage
    Friend WithEvents STOCKSFILL As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Date2St As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Date1St As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents RPTSTOCKS As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_stocksBindingSource As BindingSource
    Friend WithEvents tbl_stocksTableAdapter As inventory_dbDataSetTableAdapters.tbl_stocksTableAdapter
    Friend WithEvents RPTPRODUCTS As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_productsBindingSource As BindingSource
    Friend WithEvents tbl_productsTableAdapter As inventory_dbDataSetTableAdapters.tbl_productsTableAdapter
    Friend WithEvents TPTRANSREC As TabPage
    Friend WithEvents RPTTRANSACTIONRECORDS As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_transactionBindingSource As BindingSource
    Friend WithEvents tbl_transactionTableAdapter As inventory_dbDataSetTableAdapters.tbl_transactionTableAdapter
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Date2 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Date1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents STOCKCLR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BTNCLR As Button
    Friend WithEvents BTNFILL As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents BTNCLRTRANS As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNFILLTRANS As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DT2 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents DT1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents tbl_stocksoutBindingSource As BindingSource
    Friend WithEvents tbl_stocksoutTableAdapter As inventory_dbDataSetTableAdapters.tbl_stocksoutTableAdapter
    Friend WithEvents tbl_expiredprodBindingSource As BindingSource
    Friend WithEvents tbl_expiredprodTableAdapter As inventory_dbDataSetTableAdapters.tbl_expiredprodTableAdapter
    Friend WithEvents RPTEXP As Microsoft.Reporting.WinForms.ReportViewer
End Class
