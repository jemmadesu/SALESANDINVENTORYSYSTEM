
Imports MySql.Data.MySqlClient
Public Class ucOUTOFSTOCKS
    Dim connection As MySqlConnection
    Dim command As MySqlCommand

    Private Sub DGVSETPROPERTY()
        DGVOUTOFSTOCKS.Columns(0).Width = 150
        DGVOUTOFSTOCKS.Columns(0).HeaderText = "Stock ID"
        DGVOUTOFSTOCKS.Columns(1).Width = 150
        DGVOUTOFSTOCKS.Columns(1).HeaderText = "Product ID"
        DGVOUTOFSTOCKS.Columns(2).Width = 150
        DGVOUTOFSTOCKS.Columns(2).HeaderText = "Product Name"
        DGVOUTOFSTOCKS.Columns(3).Width = 150
        DGVOUTOFSTOCKS.Columns(3).HeaderText = "Manufacturer"
        DGVOUTOFSTOCKS.Columns(4).Width = 150
        DGVOUTOFSTOCKS.Columns(4).HeaderText = "Brand"
        DGVOUTOFSTOCKS.Columns(5).Width = 150
        DGVOUTOFSTOCKS.Columns(5).HeaderText = "Product Category"
        DGVOUTOFSTOCKS.Columns(6).Width = 150
        DGVOUTOFSTOCKS.Columns(6).HeaderText = "Category Code"
        DGVOUTOFSTOCKS.Columns(7).Width = 150
        DGVOUTOFSTOCKS.Columns(7).HeaderText = "Price"
        DGVOUTOFSTOCKS.Columns(8).Width = 150
        DGVOUTOFSTOCKS.Columns(8).HeaderText = "Unit"
        DGVOUTOFSTOCKS.Columns(9).Width = 150
        DGVOUTOFSTOCKS.Columns(9).HeaderText = "Quantity"
        DGVOUTOFSTOCKS.Columns(10).Width = 150
        DGVOUTOFSTOCKS.Columns(10).HeaderText = "Expiration Date"
    End Sub
    Private Sub ucOUTOFSTOCKS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection


        Dim dataset As New DataTable
        Dim bindindsrc As New BindingSource
        Dim dataadapt As New MySqlDataAdapter


        Try



            con.Open()
            command = New MySqlCommand("select stockid, prodid, prodname, prodman, prodbrand, prodcat, catcode, price, unit, quantity, expirationdate from tbl_products  WHERE quantity = 0;", con)
            dataadapt.SelectCommand = command
            dataadapt.Fill(dataset)
            bindindsrc.DataSource = dataset

            DGVOUTOFSTOCKS.DataSource = bindindsrc
            dataadapt.Update(dataset)
            con.Close()
            DGVSETPROPERTY()
        Catch ex As Exception

        Finally
            con.Dispose()

        End Try

    End Sub

    Private Sub refreshgrid()
        connection = New MySqlConnection


        Dim dataset As New DataTable
        Dim bindindsrc As New BindingSource
        Dim dataadapt As New MySqlDataAdapter


        Try



            con.Open()
            command = New MySqlCommand("select stockid, prodid, prodname, prodman, prodbrand, prodcat, catcode, price, unit, quantity, expirationdate from tbl_products  WHERE quantity = 0;", con)
            dataadapt.SelectCommand = command
            dataadapt.Fill(dataset)
            bindindsrc.DataSource = dataset

            DGVOUTOFSTOCKS.DataSource = bindindsrc
            dataadapt.Update(dataset)
            con.Close()
            DGVSETPROPERTY()
        Catch ex As Exception

        Finally
            con.Dispose()

        End Try
    End Sub
    Private Sub BTNBACK_Click(sender As Object, e As EventArgs) Handles BTNBACK.Click
        Dim i As Integer
        For i = 0 To 0
            FRMMAINMENU.PNLMAIN.Controls.RemoveAt(i)
        Next

        Dim PRODLIST As New ucPRODUCTLIST()
        PRODLIST.Parent = FRMMAINMENU.PNLMAIN
        PRODLIST.Show()
        PRODLIST.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNARCHIVE_Click(sender As Object, e As EventArgs) Handles BTNARCHIVE.Click

        For Each row As DataGridViewRow In DGVOUTOFSTOCKS.SelectedRows
            Dim stockid As Integer = CInt(row.Cells("stockid").Value)
            Dim prodid As String = CStr(row.Cells("prodid").Value)
            Dim prodname As String = CStr(row.Cells("prodname").Value)
            Dim prodman As String = CStr(row.Cells("prodman").Value)
            Dim prodbrand As String = CStr(row.Cells("prodbrand").Value)
            Dim prodcat As String = CStr(row.Cells("prodcat").Value)
            Dim catcode As String = CStr(row.Cells("catcode").Value)
            Dim price As Integer = CInt(row.Cells("price").Value)
            Dim unit As String = CStr(row.Cells("unit").Value)
            Dim quantity As Integer = CInt(row.Cells("quantity").Value)
            Dim expirationdate As String = CStr(row.Cells("expirationdate").Value)


            'Insert selected columns into the destination table
            Dim sqlInsert As String = "INSERT INTO tbl_stocksout (stockid, prodid, prodname, prodman, prodbrand, prodcat, catcode, price, unit, quantity, expirationdate) VALUES (@stockid, @prodid, @prodname, @prodman, @prodbrand, @prodcat, @catcode, @price, @unit, @quantity, @expirationdate)"
            Using conn As New MySqlConnection(“Server=localhost;Port=3306;User=root;Password=password;Database=inventory_db”)
                Using cmd As New MySqlCommand(sqlInsert, conn)

                    cmd.Parameters.AddWithValue("@stockid", stockid)
                    cmd.Parameters.AddWithValue("@prodid", prodid)
                    cmd.Parameters.AddWithValue("@prodname", prodname)
                    cmd.Parameters.AddWithValue("@prodman", prodman)
                    cmd.Parameters.AddWithValue("@prodbrand", prodbrand)
                    cmd.Parameters.AddWithValue("@prodcat", prodcat)
                    cmd.Parameters.AddWithValue("@catcode", catcode)
                    cmd.Parameters.AddWithValue("@price", price)
                    cmd.Parameters.AddWithValue("@unit", unit)
                    cmd.Parameters.AddWithValue("@quantity", quantity)
                    cmd.Parameters.AddWithValue("@expirationdate", expirationdate)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using

        Next

        For i As Integer = 0 To DGVOUTOFSTOCKS.SelectedRows.Count - 1
            Dim cmd As New MySqlCommand("delete from tbl_products where prodid = @prodid", con)
            cmd.Parameters.AddWithValue("prodid", DGVOUTOFSTOCKS.SelectedRows(i).Cells(1).Value.ToString())
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            refreshgrid()

            MessageBox.Show("Product has been successfully added to Archive", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
        Next
    End Sub
End Class
