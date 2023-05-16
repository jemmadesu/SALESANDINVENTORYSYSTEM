Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Public Class FRMREPORTS
    Public Property ReportParameter1 As String
    Private Sub FRMREPORTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '
        ' ---------------------------------------------------------

        lblNameReport.Text = FRMMAINMENU.LBLNAME.Text
        LBLUSERTYPE.Text = FRMMAINMENU.LBLUSERTYPE.Text

        ' ----- CODE FOR COMBO BOX CATEGORY -----

        Dim cmd As New MySqlCommand("SELECT ID, catcode, catname FROM tbl_category", con)
        Dim da As New MySqlDataAdapter(cmd)
        Dim tbl_category As New DataTable()
        da.Fill(tbl_category)

        Dim row As DataRow = tbl_category.NewRow()
        row("catname") = "-- Select --"
        tbl_category.Rows.InsertAt(row, 0)

        CBOPRODUCTSCATEGORY.DataSource = tbl_category
        CBOPRODUCTSCATEGORY.DisplayMember = "catname"

        CBOSTOCKSCATEGORY.DataSource = tbl_category
        CBOSTOCKSCATEGORY.DisplayMember = "catname"

        ' PRODUCTS REPORTS -------------------------------------------------------------------------------------------------------------

        'Assuming you are using Microsoft.Reporting.WinForms.ReportParameter for RDLC report
        Dim currentDateParamproducts As New ReportParameter("CurrentDate", DateTime.Now.ToString())
        ' Set the parameter to the report viewer
        RPTPRODUCTS.LocalReport.SetParameters(currentDateParamproducts)

        ' Refresh the report viewer to apply the parameter
        RPTPRODUCTS.RefreshReport()

        Me.RPTPRODUCTS.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_productsTableAdapter.Fill(Me.inventory_dbDataSet.tbl_products)

        Me.RPTPRODUCTS.RefreshReport()

        ' SALES REPORTS -------------------------------------------------------------------------------------------------------------

        'Assuming you are using Microsoft.Reporting.WinForms.ReportParameter for RDLC report
        Dim currentDateParamsales As New ReportParameter("CurrentDate", DateTime.Now.ToString())
        ' Set the parameter to the report viewer
        RPTSALES.LocalReport.SetParameters(currentDateParamsales)

        ' Refresh the report viewer to apply the parameter
        RPTSALES.RefreshReport()

        Me.RPTSALES.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_salesTableAdapter.Fill(Me.inventory_dbDataSet.tbl_sales)

        Me.RPTSALES.RefreshReport()


        ' USER REPORTS -------------------------------------------------------------------------------------------------------------

        'Assuming you are using Microsoft.Reporting.WinForms.ReportParameter for RDLC report
        Dim currentDateParam As New ReportParameter("CurrentDate", DateTime.Now.ToString())
        ' Set the parameter to the report viewer
        RPTUSERS.LocalReport.SetParameters(currentDateParam)

        ' Refresh the report viewer to apply the parameter
        RPTUSERS.RefreshReport()


        Me.RPTUSERS.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_usersTableAdapter.Fill(Me.inventory_dbDataSet.tbl_users)

        Me.RPTUSERS.RefreshReport()


        ' STOCKS REPORTS -------------------------------------------------------------------------------------------------------------

        'Assuming you are using Microsoft.Reporting.WinForms.ReportParameter for RDLC report
        Dim currentDateParamstocks As New ReportParameter("CurrentDate", DateTime.Now.ToString())
        ' Set the parameter to the report viewer
        RPTSTOCKS.LocalReport.SetParameters(currentDateParamstocks)

        ' Refresh the report viewer to apply the parameter
        RPTSTOCKS.RefreshReport()


        Me.RPTSTOCKS.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_stocksTableAdapter.Fill(Me.inventory_dbDataSet.tbl_stocks)


        Me.RPTSTOCKS.RefreshReport()


        ' DELIVERY REPORTS -------------------------------------------------------------------------------------------------------------

        'Assuming you are using Microsoft.Reporting.WinForms.ReportParameter for RDLC report
        Dim currentDateParamdelivery As New ReportParameter("CurrentDate", DateTime.Now.ToString())
        ' Set the parameter to the report viewer
        RPTDELIVERY.LocalReport.SetParameters(currentDateParamdelivery)

        ' Refresh the report viewer to apply the parameter
        RPTDELIVERY.RefreshReport()


        Me.RPTDELIVERY.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_deliveryTableAdapter.Fill(Me.inventory_dbDataSet.tbl_delivery)


        Me.RPTDELIVERY.RefreshReport()


        ' EXPIRED PRODUCTS REPORTS -------------------------------------------------------------------------------------------------------------

        'Assuming you are using Microsoft.Reporting.WinForms.ReportParameter for RDLC report
        Dim currentDateParamexpiredproducts As New ReportParameter("CurrentDate", DateTime.Now.ToString())
        ' Set the parameter to the report viewer
        RPTEXPIREDPRODUCTS.LocalReport.SetParameters(currentDateParamexpiredproducts)

        ' Refresh the report viewer to apply the parameter
        RPTEXPIREDPRODUCTS.RefreshReport()

        Me.RPTEXPIREDPRODUCTS.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_expiredproductsTableAdapter.Fill(Me.inventory_dbDataSet.tbl_expiredproducts)


        Me.RPTEXPIREDPRODUCTS.RefreshReport()


        ' OUT OF STOCKS PRODUCTS REPORTS -------------------------------------------------------------------------------------------------------------

        'Assuming you are using Microsoft.Reporting.WinForms.ReportParameter for RDLC report
        Dim currentDateParamoutofstocks As New ReportParameter("CurrentDate", DateTime.Now.ToString())
        ' Set the parameter to the report viewer
        RPTOUTOFSTOCKS.LocalReport.SetParameters(currentDateParamoutofstocks)

        ' Refresh the report viewer to apply the parameter
        RPTOUTOFSTOCKS.RefreshReport()

        Me.RPTOUTOFSTOCKS.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_outofstocksTableAdapter.Fill(Me.inventory_dbDataSet.tbl_outofstocks)


        Me.RPTOUTOFSTOCKS.RefreshReport()

        ' ACTIVITY LOG REPORTS -------------------------------------------------------------------------------------------------------------

        'Assuming you are using Microsoft.Reporting.WinForms.ReportParameter for RDLC report
        Dim currentDateParamactlog As New ReportParameter("CurrentDate", DateTime.Now.ToString())
        ' Set the parameter to the report viewer
        RPTACTLOG.LocalReport.SetParameters(currentDateParamactlog)

        ' Refresh the report viewer to apply the parameter
        RPTACTLOG.RefreshReport()

        Me.RPTACTLOG.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_actlogTableAdapter.Fill(Me.inventory_dbDataSet.tbl_actlog)


        Me.RPTACTLOG.RefreshReport()

        ' TRANSACTION REPORTS -------------------------------------------------------------------------------------------------------------

        'Assuming you are using Microsoft.Reporting.WinForms.ReportParameter for RDLC report
        Dim currentDateParamtransaction As New ReportParameter("CurrentDate", DateTime.Now.ToString())
        ' Set the parameter to the report viewer
        RPTTRANSACTIONRECORDS.LocalReport.SetParameters(currentDateParamtransaction)

        ' Refresh the report viewer to apply the parameter
        RPTTRANSACTIONRECORDS.RefreshReport()

        Me.RPTTRANSACTIONRECORDS.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_transactionTableAdapter.Fill(Me.inventory_dbDataSet.tbl_transaction)


        Me.RPTTRANSACTIONRECORDS.RefreshReport()
    End Sub
    Private Sub BTNCLOSE_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub FILTERPRODUCTS_Click(sender As Object, e As EventArgs) Handles FILTERPRODUCTS.Click
        Me.tbl_productsTableAdapter.FillByCategory(Me.inventory_dbDataSet.tbl_products, CBOPRODUCTSCATEGORY.Text)

        Me.RPTPRODUCTS.RefreshReport()
    End Sub

    Private Sub CLEARPRODUCTS_Click(sender As Object, e As EventArgs) Handles CLEARPRODUCTS.Click
        Me.tbl_productsTableAdapter.Fill(Me.inventory_dbDataSet.tbl_products)

        Me.RPTPRODUCTS.RefreshReport()
    End Sub
    Private Function RetrieveFilteredData(filterStartDate As DateTime, filterEndDate As DateTime) As DataTable
        ' Implement your data retrieval logic here
        ' Connect to your database or data source
        ' Execute a query or call a stored procedure to retrieve the filtered data

        Dim dataTable As New DataTable()

        ' Fill the DataTable with the filtered data
        Using connection As New MySqlConnection("Server=localhost;Port=3306;User=root;Password=password;Database=inventory_db")
            Dim query As String = "SELECT * FROM tbl_sales WHERE transadate >= @FilterStartDate AND transadate <= @FilterEndDate"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@FilterStartDate", filterStartDate)
                command.Parameters.AddWithValue("@FilterEndDate", filterEndDate)
                Dim adapter As New MySqlDataAdapter(command)
                adapter.Fill(dataTable)
            End Using
        End Using

        Return dataTable
    End Function

    ' ------------------------------------ DELIVERY FILTERING -----------------------------------------------------

    Private Function RetrieveFilteredDataDelivery(filterStartDate As DateTime, filterEndDate As DateTime) As DataTable
        ' Implement your data retrieval logic here
        ' Connect to your database or data source
        ' Execute a query or call a stored procedure to retrieve the filtered data

        Dim dataTable As New DataTable()

        ' Fill the DataTable with the filtered data
        Using connection As New MySqlConnection("Server=localhost;Port=3306;User=root;Password=password;Database=inventory_db")
            Dim query As String = "SELECT * FROM tbl_delivery WHERE datedelivered >= @FilterStartDate AND datedelivered <= @FilterEndDate"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@FilterStartDate", filterStartDate)
                command.Parameters.AddWithValue("@FilterEndDate", filterEndDate)
                Dim adapter As New MySqlDataAdapter(command)
                adapter.Fill(dataTable)
            End Using
        End Using

        Return dataTable
    End Function

    Private Function RetrieveFilteredDataTransaction(filterStartDate As DateTime, filterEndDate As DateTime) As DataTable
        ' Implement your data retrieval logic here
        ' Connect to your database or data source
        ' Execute a query or call a stored procedure to retrieve the filtered data

        Dim dataTable As New DataTable()

        ' Fill the DataTable with the filtered data
        Using connection As New MySqlConnection("Server=localhost;Port=3306;User=root;Password=password;Database=inventory_db")
            Dim query As String = "SELECT * FROM tbl_transaction WHERE transdate >= @FilterStartDate AND transdate <= @FilterEndDate"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@FilterStartDate", filterStartDate)
                command.Parameters.AddWithValue("@FilterEndDate", filterEndDate)
                Dim adapter As New MySqlDataAdapter(command)
                adapter.Fill(dataTable)
            End Using
        End Using

        Return dataTable
    End Function


    Private Sub FILTERSALES_Click(sender As Object, e As EventArgs) Handles FILTERSALES.Click
        If DAILY.Checked Then
            ' Daily filter
            Dim filterDate As DateTime = DateTime.Today

            ' Retrieve the data based on the filterDate using your data retrieval logic
            Dim filteredData As DataTable = RetrieveFilteredData(filterDate, filterDate)

            ' Bind the filtered data to the report viewer
            RPTSALES.LocalReport.DataSources.Clear()
            RPTSALES.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", filteredData))

            ' Pass the filter value to the RDLC report
            RPTSALES.LocalReport.SetParameters(New ReportParameter("FilterStartDate", filterDate.ToString("yyyy-MM-dd")))
            RPTSALES.LocalReport.SetParameters(New ReportParameter("FilterEndDate", filterDate.ToString("yyyy-MM-dd")))

            ' Refresh the report viewer
            RPTSALES.RefreshReport()
        ElseIf WEEKLY.Checked Then
            ' Weekly filter
            Dim filterStartDate As DateTime = DateTime.Today
            Dim filterEndDate As DateTime = filterStartDate.AddDays(7)

            ' Retrieve the data based on the filter start and end dates using your data retrieval logic
            Dim filteredData As DataTable = RetrieveFilteredData(filterStartDate, filterEndDate)

            ' Bind the filtered data to the report viewer
            RPTSALES.LocalReport.DataSources.Clear()
            RPTSALES.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", filteredData))

            ' Pass the filter values to the RDLC report
            RPTSALES.LocalReport.SetParameters(New ReportParameter("FilterStartDate", filterStartDate.ToString("yyyy-MM-dd")))
            RPTSALES.LocalReport.SetParameters(New ReportParameter("FilterEndDate", filterEndDate.ToString("yyyy-MM-dd")))

            ' Refresh the report viewer
            RPTSALES.RefreshReport()
        ElseIf MONTHLY.Checked Then
            ' Monthly filter
            Dim filterStartDate As DateTime = New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
            Dim filterEndDate As DateTime = filterStartDate.AddMonths(1).AddDays(-1)

            ' Retrieve the data based on the filter start and end dates using your data retrieval logic
            Dim filteredData As DataTable = RetrieveFilteredData(filterStartDate, filterEndDate)

            ' Bind the filtered data to the report viewer
            RPTSALES.LocalReport.DataSources.Clear()
            RPTSALES.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", filteredData))

            ' Pass the filter values to the RDLC report
            RPTSALES.LocalReport.SetParameters(New ReportParameter("FilterStartDate", filterStartDate.ToString("yyyy-MM-dd")))
            RPTSALES.LocalReport.SetParameters(New ReportParameter("FilterEndDate", filterEndDate.ToString("yyyy-MM-dd")))

            ' Refresh the report viewer
            RPTSALES.RefreshReport()
        End If
    End Sub

    'Private Sub CLEARSALES_Click(sender As Object, e As EventArgs) Handles CLEARSALES.Click
    '    ' Clear the filter selection
    '    DAILY.Checked = False
    '    WEEKLY.Checked = False
    '    MONTHLY.Checked = False

    '    ' Refresh the report viewer
    '    Me.RPTSALES.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    '    Me.tbl_salesTableAdapter.Fill(Me.inventory_dbDataSet.tbl_sales)

    '    Me.RPTSALES.RefreshReport()
    'End Sub
    Private Sub FILTERUSERS_Click(sender As Object, e As EventArgs) Handles FILTERUSERS.Click
        Me.tbl_usersTableAdapter.FillByusertype(Me.inventory_dbDataSet.tbl_users, CBOUSERS.Text)

        Me.RPTUSERS.RefreshReport()
    End Sub

    Private Sub CLEARUSERS_Click(sender As Object, e As EventArgs) Handles CLEARUSERS.Click
        Me.tbl_usersTableAdapter.Fill(Me.inventory_dbDataSet.tbl_users)

        Me.RPTUSERS.RefreshReport()
    End Sub

    Private Sub FILTERSTOCKS_Click(sender As Object, e As EventArgs) Handles FILTERSTOCKS.Click
        Me.tbl_stocksTableAdapter.FillBySTOCKSCATEGORY(Me.inventory_dbDataSet.tbl_stocks, CBOSTOCKSCATEGORY.Text)

        Me.RPTSTOCKS.RefreshReport()
    End Sub

    Private Sub CLEARSTOCKS_Click(sender As Object, e As EventArgs) Handles CLEARSTOCKS.Click
        Me.tbl_stocksTableAdapter.Fill(Me.inventory_dbDataSet.tbl_stocks)

        Me.RPTSTOCKS.RefreshReport()
    End Sub

    Private Sub LBLUSERNAME_Click(sender As Object, e As EventArgs) Handles lblNameReport.Click
        lblNameReport.Text = FRMMAINMENU.LBLUSERNAME.Text
    End Sub

    Private Sub FILTERDELIVERY_Click(sender As Object, e As EventArgs) Handles FILTERDELIVERY.Click
        If DAILYDELIVERY.Checked Then
            ' Daily filter
            Dim filterDate As DateTime = DateTime.Today

            ' Retrieve the data based on the filterDate using your data retrieval logic
            Dim filteredData As DataTable = RetrieveFilteredDataDelivery(filterDate, filterDate)

            ' Bind the filtered data to the report viewer
            RPTDELIVERY.LocalReport.DataSources.Clear()
            RPTDELIVERY.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", filteredData))

            ' Pass the filter value to the RDLC report
            RPTDELIVERY.LocalReport.SetParameters(New ReportParameter("FilterStartDate", filterDate.ToString("yyyy-MM-dd")))
            RPTDELIVERY.LocalReport.SetParameters(New ReportParameter("FilterEndDate", filterDate.ToString("yyyy-MM-dd")))

            ' Refresh the report viewer
            RPTDELIVERY.RefreshReport()
        ElseIf WEEKLYDELIVERY.Checked Then
            ' Weekly filter
            Dim filterStartDate As DateTime = DateTime.Today
            Dim filterEndDate As DateTime = filterStartDate.AddDays(7)

            ' Retrieve the data based on the filter start and end dates using your data retrieval logic
            Dim filteredData As DataTable = RetrieveFilteredDataDelivery(filterStartDate, filterEndDate)

            ' Bind the filtered data to the report viewer
            RPTDELIVERY.LocalReport.DataSources.Clear()
            RPTDELIVERY.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", filteredData))

            ' Pass the filter values to the RDLC report
            RPTDELIVERY.LocalReport.SetParameters(New ReportParameter("FilterStartDate", filterStartDate.ToString("yyyy-MM-dd")))
            RPTDELIVERY.LocalReport.SetParameters(New ReportParameter("FilterEndDate", filterEndDate.ToString("yyyy-MM-dd")))

            ' Refresh the report viewer
            RPTDELIVERY.RefreshReport()
        ElseIf MONTHLYDELIVERY.Checked Then
            ' Monthly filter
            Dim filterStartDate As DateTime = New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
            Dim filterEndDate As DateTime = filterStartDate.AddMonths(1).AddDays(-1)

            ' Retrieve the data based on the filter start and end dates using your data retrieval logic
            Dim filteredData As DataTable = RetrieveFilteredDataDelivery(filterStartDate, filterEndDate)

            ' Bind the filtered data to the report viewer
            RPTDELIVERY.LocalReport.DataSources.Clear()
            RPTDELIVERY.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", filteredData))

            ' Pass the filter values to the RDLC report
            RPTDELIVERY.LocalReport.SetParameters(New ReportParameter("FilterStartDate", filterStartDate.ToString("yyyy-MM-dd")))
            RPTDELIVERY.LocalReport.SetParameters(New ReportParameter("FilterEndDate", filterEndDate.ToString("yyyy-MM-dd")))

            ' Refresh the report viewer
            RPTDELIVERY.RefreshReport()
        End If
    End Sub

    'Private Sub CLEARDELIVERY_Click(sender As Object, e As EventArgs) Handles CLEARDELIVERY.Click
    '    ' Clear the filter selection
    '    DAILYDELIVERY.Checked = False
    '    WEEKLYDELIVERY.Checked = False
    '    MONTHLYDELIVERY.Checked = False

    '    ' Clear the data sources for the report viewer
    '    RPTDELIVERY.LocalReport.DataSources.Clear()

    '    ' Set the parameters to their default values
    '    Dim emptyStartDate As String = ""
    '    Dim emptyEndDate As String = ""
    '    RPTDELIVERY.LocalReport.SetParameters(New ReportParameter("FilterStartDate", emptyStartDate))
    '    RPTDELIVERY.LocalReport.SetParameters(New ReportParameter("FilterEndDate", emptyEndDate))

    '    ' Refresh the report viewer
    '    RPTDELIVERY.RefreshReport()
    'End Sub



    Private Sub FILTERACTLOG_Click(sender As Object, e As EventArgs) Handles FILTERACTLOG.Click
        Me.tbl_actlogTableAdapter.FillByACT(Me.inventory_dbDataSet.tbl_actlog, CBOACTIVITYLOG.Text)

        Me.RPTACTLOG.RefreshReport()
    End Sub
    Private Sub CLEARACTLOG_Click(sender As Object, e As EventArgs) Handles CLEARACTLOG.Click
        Me.tbl_actlogTableAdapter.Fill(Me.inventory_dbDataSet.tbl_actlog)

        Me.RPTACTLOG.RefreshReport()
    End Sub

    Private Sub FILTEROUTOFSTOCKS_Click(sender As Object, e As EventArgs) Handles FILTEROUTOFSTOCKS.Click
        Me.tbl_outofstocksTableAdapter.FillByOUTOFSTOCKS(Me.inventory_dbDataSet.tbl_outofstocks, DATE1OUTOFSTOCKS.Value.ToShortDateString, DATE2OUTOFSTOCKS.Value.ToShortDateString)

        Me.RPTOUTOFSTOCKS.RefreshReport()
    End Sub

    Private Sub CLEAROUTOFSTOCKS_Click(sender As Object, e As EventArgs) Handles CLEAROUTOFSTOCKS.Click

        Me.tbl_outofstocksTableAdapter.Fill(Me.inventory_dbDataSet.tbl_outofstocks)


        Me.RPTOUTOFSTOCKS.RefreshReport()

    End Sub

    Private Sub FILTEREXPIREDPRODUCTS_Click(sender As Object, e As EventArgs) Handles FILTEREXPIREDPRODUCTS.Click
        Me.tbl_expiredproductsTableAdapter.FillByEXPIRATIONDATE(Me.inventory_dbDataSet.tbl_expiredproducts, DATE1EXPIREDPRODUCTS.Value.ToShortDateString, DATE2EXPIREDPRODUCTS.Value.ToShortDateString)

        Me.RPTEXPIREDPRODUCTS.RefreshReport()
    End Sub

    Private Sub CLEAREXPIREDPRODUCTS_Click(sender As Object, e As EventArgs) Handles CLEAREXPIREDPRODUCTS.Click
        Me.tbl_expiredproductsTableAdapter.Fill(Me.inventory_dbDataSet.tbl_expiredproducts)


        Me.RPTEXPIREDPRODUCTS.RefreshReport()
    End Sub

    Private Sub FILTERTRANSACTION_Click(sender As Object, e As EventArgs) Handles FILTERTRANSACTION.Click
        If DAILYTRANSACTION.Checked Then
            ' Daily filter
            Dim filterDate As DateTime = DateTime.Today

            ' Retrieve the data based on the filterDate using your data retrieval logic
            Dim filteredData As DataTable = RetrieveFilteredDataTransaction(filterDate, filterDate)

            ' Bind the filtered data to the report viewer
            RPTTRANSACTIONRECORDS.LocalReport.DataSources.Clear()
            RPTTRANSACTIONRECORDS.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", filteredData))

            ' Pass the filter value to the RDLC report
            RPTTRANSACTIONRECORDS.LocalReport.SetParameters(New ReportParameter("FilterStartDate", filterDate.ToString("yyyy-MM-dd")))
            RPTTRANSACTIONRECORDS.LocalReport.SetParameters(New ReportParameter("FilterEndDate", filterDate.ToString("yyyy-MM-dd")))

            ' Refresh the report viewer
            RPTTRANSACTIONRECORDS.RefreshReport()
        ElseIf WEEKLYTRANSACTION.Checked Then
            ' Weekly filter
            Dim filterStartDate As DateTime = DateTime.Today
            Dim filterEndDate As DateTime = filterStartDate.AddDays(7)

            ' Retrieve the data based on the filter start and end dates using your data retrieval logic
            Dim filteredData As DataTable = RetrieveFilteredDataTransaction(filterStartDate, filterEndDate)

            ' Bind the filtered data to the report viewer
            RPTTRANSACTIONRECORDS.LocalReport.DataSources.Clear()
            RPTTRANSACTIONRECORDS.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", filteredData))

            ' Pass the filter values to the RDLC report
            RPTTRANSACTIONRECORDS.LocalReport.SetParameters(New ReportParameter("FilterStartDate", filterStartDate.ToString("yyyy-MM-dd")))
            RPTTRANSACTIONRECORDS.LocalReport.SetParameters(New ReportParameter("FilterEndDate", filterEndDate.ToString("yyyy-MM-dd")))

            ' Refresh the report viewer
            RPTTRANSACTIONRECORDS.RefreshReport()
        ElseIf MONTHLYTRANSACTION.Checked Then
            ' Monthly filter
            Dim filterStartDate As DateTime = New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
            Dim filterEndDate As DateTime = filterStartDate.AddMonths(1).AddDays(-1)

            ' Retrieve the data based on the filter start and end dates using your data retrieval logic
            Dim filteredData As DataTable = RetrieveFilteredDataTransaction(filterStartDate, filterEndDate)

            ' Bind the filtered data to the report viewer
            RPTTRANSACTIONRECORDS.LocalReport.DataSources.Clear()
            RPTTRANSACTIONRECORDS.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", filteredData))

            ' Pass the filter values to the RDLC report
            RPTTRANSACTIONRECORDS.LocalReport.SetParameters(New ReportParameter("FilterStartDate", filterStartDate.ToString("yyyy-MM-dd")))
            RPTTRANSACTIONRECORDS.LocalReport.SetParameters(New ReportParameter("FilterEndDate", filterEndDate.ToString("yyyy-MM-dd")))

            ' Refresh the report viewer
            RPTTRANSACTIONRECORDS.RefreshReport()
        End If
    End Sub

    Private Sub CLEARSALES_Click(sender As Object, e As EventArgs)

    End Sub
End Class