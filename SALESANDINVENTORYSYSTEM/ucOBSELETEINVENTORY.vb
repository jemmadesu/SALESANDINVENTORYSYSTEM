
Imports MySql.Data.MySqlClient

Public Class ucOBSELETEINVENTORY
    Dim connection As MySqlConnection
    Dim command As MySqlCommand

    Private Sub DGVSETPROPERTY()
        DGVEXPIREDPROD.Columns(0).Width = 150
        DGVEXPIREDPROD.Columns(0).HeaderText = "Stock ID"
        DGVEXPIREDPROD.Columns(1).Width = 150
        DGVEXPIREDPROD.Columns(1).HeaderText = "Product ID"
        DGVEXPIREDPROD.Columns(2).Width = 150
        DGVEXPIREDPROD.Columns(2).HeaderText = "Product Name"
        DGVEXPIREDPROD.Columns(3).Width = 150
        DGVEXPIREDPROD.Columns(3).HeaderText = "Manufacturer"
        DGVEXPIREDPROD.Columns(4).Width = 150
        DGVEXPIREDPROD.Columns(4).HeaderText = "Brand"
        DGVEXPIREDPROD.Columns(5).Width = 150
        DGVEXPIREDPROD.Columns(5).HeaderText = "Product Category"
        DGVEXPIREDPROD.Columns(6).Width = 150
        DGVEXPIREDPROD.Columns(6).HeaderText = "Category Code"
        DGVEXPIREDPROD.Columns(7).Width = 150
        DGVEXPIREDPROD.Columns(7).HeaderText = "Price"
        DGVEXPIREDPROD.Columns(8).Width = 150
        DGVEXPIREDPROD.Columns(8).HeaderText = "Unit"
        DGVEXPIREDPROD.Columns(9).Width = 150
        DGVEXPIREDPROD.Columns(9).HeaderText = "Quantity"
        DGVEXPIREDPROD.Columns(10).Width = 150
        DGVEXPIREDPROD.Columns(10).HeaderText = "Expiration Date"
    End Sub
    Private Sub ucOBSELETEINVENTORY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection


        Dim dataset As New DataTable
        Dim bindindsrc As New BindingSource
        Dim dataadapt As New MySqlDataAdapter

        Try



            con.Open()
            command = New MySqlCommand("select stockid, prodid, prodname, prodman, prodbrand, prodcat, catcode, price, unit, quantity, expirationdate from tbl_stocks  WHERE expirationdate  < Now();", con)

            dataadapt.SelectCommand = command
            dataadapt.Fill(dataset)
            bindindsrc.DataSource = dataset

            DGVEXPIREDPROD.DataSource = bindindsrc
            dataadapt.Update(dataset)
            con.Close()

            DGVSETPROPERTY()
        Catch ex As Exception

        Finally
            con.Dispose()

        End Try


    End Sub

    Private Sub BTNARCHIVE_Click(sender As Object, e As EventArgs) Handles BTNARCHIVE.Click

        For Each row As DataGridViewRow In DGVEXPIREDPROD.SelectedRows
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
            Dim sqlInsert As String = "INSERT INTO tbl_expiredprod (stockid, prodid, prodname, prodman, prodbrand, prodcat, catcode, price, unit, quantity, expirationdate) VALUES (@stockid, @prodid, @prodname, @prodman, @prodbrand, @prodcat, @catcode, @price, @unit, @quantity, @expirationdate)"
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

        For i As Integer = 0 To DGVEXPIREDPROD.SelectedRows.Count - 1
            Dim cmd As New MySqlCommand("delete from tbl_products where prodid = @prodid", con)
            cmd.Parameters.AddWithValue("prodid", DGVEXPIREDPROD.SelectedRows(i).Cells(1).Value.ToString())
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            refreshgrid()

            MessageBox.Show("Product has been successfully added to Archive", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
        Next

    End Sub

    Private Sub refreshgrid()

        Try

            Dim da As New MySqlDataAdapter("select stockid, prodid, prodname, prodman, prodbrand, prodcat, catcode, price, unit, quantity, expirationdate from tbl_products  WHERE expirationdate  < Now();", con)
            Dim dt As New DataSet()
            da.Fill(dt)
            DGVEXPIREDPROD.DataSource = dt.Tables(0)


        Catch ex As Exception

            MessageBox.Show(ex.ToString())



        End Try
    End Sub

    Private Sub BTNBACK_Click_1(sender As Object, e As EventArgs) Handles BTNBACK.Click
        Dim i As Integer
        For i = 0 To 0
            FRMMAINMENU.PNLMAIN.Controls.RemoveAt(i)
        Next

        Dim PROD As New ucPRODUCTLIST()
        PROD.Parent = FRMMAINMENU.PNLMAIN
        PROD.Show()
        PROD.Dock = DockStyle.Fill
    End Sub


End Class
