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

        Dim out As String
        OpenCon()
        cmd.CommandText = "select stockid, prodid, prodname, prodman, prodbrand, prodcat, catcode, price, unit, quantity, expirationdate from tbl_stocks  WHERE quantity = 0;"
        out = cmd.ExecuteScalar()
        lblouofstock.Text = out
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

        'PIE

        Dim sql As String = "SELECT YEAR(transadate) AS salesyear, SUM(totalbill) AS salesamount FROM tbl_sales GROUP BY YEAR(transadate)"
        Dim adapter As New MySqlDataAdapter(sql, con)
        Dim table As New DataTable()
        adapter.Fill(table)

        For Each row As DataRow In table.Rows
            chart1.Series("Sales").Points.AddXY(row("salesyear").ToString(), row("salesamount"))
        Next



        ' Set the chart type to column chart
        chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie





    End Sub

    Private Sub refreshgrid()
        Me.Tbl_usersTableAdapter.Fill(Me.Inventory_dbDataSet.tbl_users)
    End Sub

    'Private Sub refreshgrid1()
    '    Me.Tbl_salesTableAdapter.Fill(Me.Inventory_dbDataSet.tbl_sales)
    'End Sub

End Class
