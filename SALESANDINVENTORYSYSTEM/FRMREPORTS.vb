Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Public Class FRMREPORTS
    Private Sub FRMREPORTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim userType As String = LBLUSERNAME.Text
        Dim parameter As New ReportParameter("UserType", userType)
        RPTSTOCKS.LocalReport.SetParameters(parameter)


        RPTSTOCKS.LocalReport.ReportPath = "c:\users\jesse celeridad\source\repos\salesandinventorysystem\SALESANDINVENTORYSYSTEM\RPTSTOCKS.rdlc" ' Set the path to your RDLC file
        RPTSTOCKS.RefreshReport()


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

        ' PRODUCTS REPORT -------------------------------------------------------------------------------------------------------------

        'TODO: This line of code loads data into the 'inventory_dbDataSet.tbl_products' table. You can move, or remove it, as needed.
        Me.RPTPRODUCTS.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_productsTableAdapter.Fill(Me.inventory_dbDataSet.tbl_products)

        Me.RPTPRODUCTS.RefreshReport()

        ' SALES REPORT -------------------------------------------------------------------------------------------------------------

        'TODO: This line of code loads data into the 'inventory_dbDataSet.tbl_sales' table. You can move, or remove it, as needed.
        Me.RPTSALES.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_salesTableAdapter.Fill(Me.inventory_dbDataSet.tbl_sales)

        Me.RPTSALES.RefreshReport()


        ' USER REPORT -------------------------------------------------------------------------------------------------------------

        'TODO: This line of code loads data into the 'inventory_dbDataSet.tbl_users' table. You can move, or remove it, as needed.
        Me.RPTUSERS.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_usersTableAdapter.Fill(Me.inventory_dbDataSet.tbl_users)

        Me.RPTUSERS.RefreshReport()


        ' USER STOCKS -------------------------------------------------------------------------------------------------------------

        'TODO: This line of code loads data into the 'inventory_dbDataSet.tbl_stocks' table. You can move, or remove it, as needed.
        Me.RPTSTOCKS.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_stocksTableAdapter.Fill(Me.inventory_dbDataSet.tbl_stocks)

        Me.RPTSTOCKS.RefreshReport()
    End Sub
    Private Sub BTNCLOSE_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub FILTERPRODUCTS_Click(sender As Object, e As EventArgs) Handles FILTERPRODUCTS.Click
        Me.tbl_productsTableAdapter.FillByCategory(Me.inventory_dbDataSet.tbl_products, CBOPRODUCTSCATEGORY.Text)

        Me.RPTPRODUCTS.RefreshReport()
    End Sub

    Private Sub CLEARPRODUCTS_Click(sender As Object, e As EventArgs) Handles CLEARPRODUCTS.Click
        Me.RPTPRODUCTS.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

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

    Private Sub CLEARSALES_Click(sender As Object, e As EventArgs) Handles CLEARSALES.Click
        Me.RPTSALES.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

        Me.RPTSALES.RefreshReport()
    End Sub
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

    Private Sub LBLUSERNAME_Click(sender As Object, e As EventArgs) Handles LBLUSERNAME.Click
        LBLUSERNAME.Text = FRMMAINMENU.LBLUSERNAME.Text
    End Sub
End Class