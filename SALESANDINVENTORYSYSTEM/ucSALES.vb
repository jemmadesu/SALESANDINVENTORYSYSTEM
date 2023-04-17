
Imports MySql.Data.MySqlClient

Public Class ucSALES

    Private Sub DGVSETPROPERTY()


        DGVSALES.Columns(0).Width = 200
        DGVSALES.Columns(0).HeaderText = "Sales No."

        DGVSALES.Columns(1).Width = 200
        DGVSALES.Columns(1).HeaderText = "order No."

        DGVSALES.Columns(2).Width = 200
        DGVSALES.Columns(2).HeaderText = "Transaction Date"

        DGVSALES.Columns(3).Width = 200
        DGVSALES.Columns(3).HeaderText = "Discount Type"

        DGVSALES.Columns(4).Width = 200
        DGVSALES.Columns(4).HeaderText = "Total Bill"

        DGVSALES.Columns(5).Width = 200
        DGVSALES.Columns(5).HeaderText = "Payment"

        DGVSALES.Columns(6).Width = 200
        DGVSALES.Columns(6).HeaderText = "Change"

    End Sub

    Private Sub loads()



        Dim dba As New MySqlDataAdapter("SELECT SUM(TotalBill) FROM tbl_Sales;", con)
        Dim dbs As New DataSet
        dba.Fill(dbs)
        Dim totalbill1 As Decimal = 0
        totalbill1 = dbs.Tables(0).DefaultView.Item(0).Item(0)

        TXTINCOME.Text = "₱" & totalbill1.ToString("N2")

    End Sub
    Private Sub ucSALES_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        displayprod()
        loads()


    End Sub



    Private Sub displayprod()
        Try

            Dim da As New MySqlDataAdapter("select * from tbl_Sales ", con)
            Dim dt As New DataSet()
            da.Fill(dt)
            DGVSALES.DataSource = dt.Tables(0)

            DGVSETPROPERTY()
        Catch ex As Exception

            MessageBox.Show(ex.ToString())



        End Try
    End Sub
    Private Sub BTNGENERATE_Click(sender As Object, e As EventArgs) Handles BTNGENERATE.Click
        ' Retrieve sales data from data source
        Dim dtSales As New DataTable
        Using conn As New MySqlConnection(“Server=localhost;Port=3306;User=root;Password=password;Database=inventory_db”)
            conn.Open()
            Using cmd As New MySqlCommand("SELECT * FROM tbl_sales", conn)
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dtSales)
                End Using
            End Using
        End Using

        ' Filter sales data based on date range selected in date time picker
        Dim startDate As Date = DATE1.Value.Date
        Dim endDate As Date = DATE2.Value.Date.AddDays(1).AddSeconds(-1)
        Dim filteredRows() As DataRow = dtSales.Select("transadate >= #" & startDate.ToString("yyyy/MM/dd") & "# AND transadate <= #" & endDate.ToString("yyyy/MM/dd") & "#")

        ' Calculate total sales for filtered data
        Dim totalbill As Decimal = 0
        For Each row As DataRow In filteredRows
            totalbill += Convert.ToDecimal(row("totalbill"))
        Next

        ' Display total sales in a label or textbox
        TXTINCOME.Text = "₱" & totalbill.ToString("N2")
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub LBLEXIT_Click(sender As Object, e As EventArgs) Handles LBLEXIT.Click

    End Sub
End Class
