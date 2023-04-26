Imports MySql.Data.MySqlClient
Public Class ucDASHBOARD


    Private Sub DGVSETPROPERTY()
        'DGVUSERS.Columns(0).Width = 10
        DGVUSERS.Columns(0).HeaderText = "Username"
        'DGVUSERS.Columns(1).Width = 10
        DGVUSERS.Columns(1).HeaderText = "User Type"
        'DGVUSERS.Columns(2).Width = 10
        DGVUSERS.Columns(2).HeaderText = "Status"

    End Sub
    Private Sub ucDASHBOARD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVSETPROPERTY()
        refreshgrid()
        'refreshgrid1()

        Dim currentMonth As String = DateTime.Now.ToString("MMMM")
        LBLMONTH.Text = currentMonth

        Dim currentDay As String = DateTime.Now.ToString("dddd")
        LBLDAY.Text = currentDay

        Dim currentDate As String = DateTime.Now.ToString("dd")
        LBLDATE.Text = currentDate

        Dim currentYear As String = DateTime.Now.ToString("yyyy")
        LBLYEAR.Text = currentYear

        DGVUSERS.DefaultCellStyle.ForeColor = Color.Black



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




        ' LINE CHART


        Dim conn As New MySqlConnection(“Server=localhost;Port=3306;User=root;Password=password;Database=inventory_db”)
        Dim cmd1 As New MySqlCommand("
    SELECT 
        MONTH(transadate) AS Month, 
        SUM(totalbill) AS TotalBill
    FROM 
        tbl_sales 
    GROUP BY 
        MONTH(transadate)

", conn)
        Dim da As New MySqlDataAdapter(cmd1)
        Dim dt As New DataTable()
        da.Fill(dt)


        CHART.DataSource = dt
        CHART.Series("Total Bill").XValueMember = "Month"
        CHART.Series("Total Bill").YValueMembers = "TotalBill"
        CHART.Series("Total Bill").LegendText = "Total Bill"

        CHART.ChartAreas(0).AxisX.Title = "Month"
        CHART.ChartAreas(0).AxisY.Title = "Total Bill"


        ' PIE CHART

        '' Create a connection to the MySQL database
        'Dim connectionString As String = "Server=myServerAddress;Database=myDatabase;Uid=myUsername;Pwd=myPassword;"
        'Dim connection As New MySqlConnection(connectionString)

        '' Create a SQL query to retrieve the total bill and yearly sales data
        'Dim query As String = "SELECT SUM(totalbill) as TotalBill, YEAR(transadate) as SaleYear, SUM(totalsales) as TotalSales FROM tbl_Sales GROUP BY SaleYear"

        '' Create a command object and execute the query
        'Dim command As New MySqlCommand(query, connection)
        'connection.Open()
        'Dim reader As MySqlDataReader = command.ExecuteReader()

        '' Create a new chart control
        'Dim chart1 As New Chart()

        '' Set up the chart area and legend
        'chart1.ChartAreas.Add(New ChartArea())
        'chart1.Legends.Add(New Legend("Legend"))
        'chart1.Legends("Legend").Docking = Docking.Bottom

        '' Set up the series data
        'Dim series1 As New Series()
        'series1.ChartType = SeriesChartType.Pie
        'series1.IsValueShownAsLabel = True
        'series1.Legend = "Legend"

        'While reader.Read()
        '    Dim year As Integer = reader.GetInt32("SaleYear")
        '    Dim sales As Decimal = reader.GetDecimal("TotalSales")
        '    Dim bill As Decimal = reader.GetDecimal("TotalBill")

        '    ' Add the data point to the series with the year, total bill, and yearly sales data
        '    Dim dp As New DataPoint()
        '    dp.SetValueXY(year, sales)
        '    dp.LegendText = year.ToString()
        '    dp.Label = String.Format("{0}: {1:C2} ({2:C2})", year, bill, sales)
        '    series1.Points.Add(dp)
        'End While

        '' Set the chart title
        'chart1.Titles.Add("Yearly Sales")

        '' Bind the series to the chart control
        'chart1.Series.Add(series1)

        '' Add the chart control to your form's controls collection
        'Me.Controls.Add(chart1)

        '' Close the database connection and reader
        'reader.Close()
        'connection.Close()




        ' Set the chart type to column chart
        Chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie





    End Sub

    Private Sub refreshgrid()
        Me.Tbl_usersTableAdapter.Fill(Me.Inventory_dbDataSet.tbl_users)
    End Sub

    'Private Sub refreshgrid1()
    '    Me.Tbl_salesTableAdapter.Fill(Me.Inventory_dbDataSet.tbl_sales)
    'End Sub

End Class
