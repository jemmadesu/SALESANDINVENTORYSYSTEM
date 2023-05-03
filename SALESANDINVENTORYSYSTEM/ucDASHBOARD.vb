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

    Private Sub users()
        Try

            Dim da As New MySqlDataAdapter("select username, usertype, status from tbl_users ", con)
            Dim dt As New DataSet()
            da.Fill(dt)
            DGVUSERS.DataSource = dt.Tables(0)


        Catch ex As Exception

            MessageBox.Show(ex.ToString())



        End Try
    End Sub
    Private Sub ucDASHBOARD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        users()
        DGVSETPROPERTY()
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
        cmd.CommandText = "select count(quantity) from tbl_Stocks WHERE quantity < 10;"
        cmd.Parameters.Clear()
        cmd.ExecuteNonQuery()
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
        CHART.Series("Total Sales").XValueMember = "Month"
        CHART.Series("Total Sales").YValueMembers = "TotalBill"
        CHART.Series("Total Sales").LegendText = "Total Sales"

        CHART.ChartAreas(0).AxisX.Title = "Month"
        CHART.ChartAreas(0).AxisY.Title = "Total Sales"

        'PIE

        Dim sql As String = "SELECT YEAR(transadate) AS salesyear, SUM(totalbill) AS salesamount FROM tbl_sales GROUP BY YEAR(transadate)"
        Dim adapter As New MySqlDataAdapter(sql, con)
        Dim table As New DataTable()
        adapter.Fill(table)

        For Each row As DataRow In table.Rows
            chart1.Series("Sales").Points.AddXY(row("salesyear").ToString(), row("salesamount"))
        Next



        ' Set the chart type to column chart
        Chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie







        ' TEMP



    End Sub


    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint

        Dim rect As Rectangle = New Rectangle(0, 0, PictureBox1.Width, PictureBox1.Height)
        Dim radius As Integer = 20
        Dim path As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90)
        path.AddLine(rect.X + radius, rect.Y, rect.Width - radius, rect.Y)
        path.AddArc(rect.X + rect.Width - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90)
        path.AddLine(rect.Width, rect.Y + radius, rect.Width, rect.Height - radius)
        path.AddArc(rect.X + rect.Width - radius * 2, rect.Y + rect.Height - radius * 2, radius * 2, radius * 2, 0, 90)
        path.AddLine(rect.Width - radius, rect.Height, rect.X + radius, rect.Height)
        path.AddArc(rect.X, rect.Y + rect.Height - radius * 2, radius * 2, radius * 2, 90, 90)
        path.CloseFigure()
        PictureBox1.Region = New Region(path)
        PictureBox1.BackColor = Color.Transparent

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs)

    End Sub
End Class
