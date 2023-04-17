Imports MySql.Data.MySqlClient
Public Class ucDASHBOARD
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub ucDASHBOARD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim prod As String
        OpenCon()
        cmd.CommandText = "select count(prodname) from tbl_products"
        prod = cmd.ExecuteScalar()
        lblproducts.Text = prod
        con.Close()


        Dim sales As String
        OpenCon()
        cmd.CommandText = "select sum(totalbill) from tbl_Sales"
        sales = cmd.ExecuteScalar()
        lblsales.Text = "₱" & sales
        con.Close()

        Dim exp As String
        OpenCon()
        cmd.CommandText = "select count(prodname) from tbl_expiredprod"
        exp = cmd.ExecuteScalar()
        lblexp.Text = exp
        con.Close()

        ' Define the SQL query to retrieve total sales data
        Dim sqlQuery As String = "SELECT SUM(totalbill) AS TotalSales, MONTH(transadate) AS Month FROM tbl_sales GROUP BY MONTH(transadate)"

        ' Create a new data table to store the results of the SQL query
        Dim dataTable As New DataTable()

        ' Create a new data adapter to retrieve data from the database
        Dim dataAdapter As New MySqlDataAdapter(sqlQuery, con)

        ' Fill the data table with the results of the SQL query
        dataAdapter.Fill(dataTable)

        ' Bind the data table to the chart control and specify the data series and X/Y values
        chart1.DataSource = dataTable
        chart1.Series("Total Sales").XValueMember = "Month"
        chart1.Series("Total Sales").YValueMembers = "TotalSales"

        ' Customize the appearance and behavior of the chart control as desired
        chart1.ChartAreas(0).AxisX.LabelStyle.Interval = 1
        chart1.Series("Total Sales").ChartType = DataVisualization.Charting.SeriesChartType.Line
    End Sub

    Private Sub chart1_Click(sender As Object, e As EventArgs)


    End Sub
End Class
