
Imports MySql.Data.MySqlClient

Public Class ucOBSELETEINVENTORY
    Dim connection As MySqlConnection
    Dim command As MySqlCommand

    Private Sub DGVSETPROPERTY()

        DGVEXPIREDPROD.Columns(0).Width = 200
        DGVEXPIREDPROD.Columns(0).HeaderText = "Product ID"
        DGVEXPIREDPROD.Columns(1).Width = 200
        DGVEXPIREDPROD.Columns(1).HeaderText = "Product Code"
        DGVEXPIREDPROD.Columns(2).Width = 200
        DGVEXPIREDPROD.Columns(2).HeaderText = "Product Name"
        DGVEXPIREDPROD.Columns(3).Width = 200
        DGVEXPIREDPROD.Columns(3).HeaderText = "Manufacturer"
        DGVEXPIREDPROD.Columns(4).Width = 200
        DGVEXPIREDPROD.Columns(4).HeaderText = "Brand"
        DGVEXPIREDPROD.Columns(5).Width = 200
        DGVEXPIREDPROD.Columns(5).HeaderText = "Category"
        DGVEXPIREDPROD.Columns(6).Width = 200
        DGVEXPIREDPROD.Columns(6).HeaderText = "Category Code"
        DGVEXPIREDPROD.Columns(7).Width = 200
        DGVEXPIREDPROD.Columns(7).HeaderText = "Unit"
        DGVEXPIREDPROD.Columns(8).Width = 200
        DGVEXPIREDPROD.Columns(8).HeaderText = "Price"
        DGVEXPIREDPROD.Columns(9).Width = 200
        DGVEXPIREDPROD.Columns(9).HeaderText = "Stocks"
        DGVEXPIREDPROD.Columns(10).Width = 200
        DGVEXPIREDPROD.Columns(10).HeaderText = "Manufactured Date"
        DGVEXPIREDPROD.Columns(11).Width = 200
        DGVEXPIREDPROD.Columns(11).HeaderText = "Expiration Date"

    End Sub

    Private Sub view()
        connection = New MySqlConnection


        Dim dataset As New DataTable
        Dim bindindsrc As New BindingSource
        Dim dataadapt As New MySqlDataAdapter

        Try



            con.Open()
            command = New MySqlCommand("select id, prodcode, prodname, manufacturer, brand, category, catcode, unit, price, quantity, manufactureddate, expirationdate from tbl_stocks  WHERE expirationdate  < Now();", con)

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
    Private Sub ucOBSELETEINVENTORY_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        view()

        ' Set the backcolor of the row
        DGVEXPIREDPROD.Columns(10).DefaultCellStyle.BackColor = Color.IndianRed

        ' Set the forecolor of the row
        DGVEXPIREDPROD.Columns(10).DefaultCellStyle.ForeColor = Color.White

    End Sub

    Private Sub BTNARCHIVE_Click(sender As Object, e As EventArgs) Handles BTNARCHIVE.Click

        If MessageBox.Show("This product is already expired, Do you really want to archive this product?", "Archive", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub
        End If

        For Each row As DataGridViewRow In DGVEXPIREDPROD.SelectedRows


            Dim id As Integer = CStr(row.Cells("id").Value)

            Dim prodcode As String = CStr(row.Cells("prodcode").Value)

            Dim prodname As String = CStr(row.Cells("prodname").Value)

            Dim manufacturer As String = CStr(row.Cells("manufacturer").Value)

            Dim brand As String = CStr(row.Cells("brand").Value)

            Dim category As String = CStr(row.Cells("category").Value)

            Dim catcode As String = CStr(row.Cells("catcode").Value)

            Dim price As Integer = CInt(row.Cells("price").Value)

            Dim unit As String = CStr(row.Cells("unit").Value)

            Dim quantity As Integer = CInt(row.Cells("quantity").Value)

            Dim manufactureddate As String = CStr(row.Cells("manufactureddate").Value)

            Dim expirationdate As String = CStr(row.Cells("expirationdate").Value)


            'Insert selected columns into the destination table
            Dim sqlInsert As String = "INSERT INTO tbl_expiredproducts (id, prodcode, prodname, manufacturer, brand, category, catcode, unit, price, quantity, manufactureddate, expirationdate, dateremoved) VALUES (@id, @prodcode, @prodname, @manufacturer, @brand, @category, @catcode, @unit, @price, @quantity, @manufactureddate, @expirationdate, @dateremoved)"
            Using conn As New MySqlConnection(“Server=localhost;Port=3306;User=root;Password=password;Database=inventory_db”)
                Using cmd As New MySqlCommand(sqlInsert, conn)

                    cmd.Parameters.AddWithValue("@id", id)

                    cmd.Parameters.AddWithValue("@prodcode", prodcode)

                    cmd.Parameters.AddWithValue("@prodname", prodname)

                    cmd.Parameters.AddWithValue("@manufacturer", manufacturer)

                    cmd.Parameters.AddWithValue("@brand", brand)

                    cmd.Parameters.AddWithValue("@category", category)

                    cmd.Parameters.AddWithValue("@catcode", catcode)

                    cmd.Parameters.AddWithValue("@price", price)

                    cmd.Parameters.AddWithValue("@unit", unit)

                    cmd.Parameters.AddWithValue("@quantity", quantity)

                    cmd.Parameters.AddWithValue("@manufactureddate", manufactureddate)

                    cmd.Parameters.AddWithValue("@expirationdate", expirationdate)

                    cmd.Parameters.AddWithValue("@dateremoved", Format(Date.Now, "yyyy-MM-dd"))


                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using

        Next

        For i As Integer = 0 To DGVEXPIREDPROD.SelectedRows.Count - 1
            Dim cmd As New MySqlCommand("delete from tbl_stocks where id = @id", con)
            cmd.Parameters.AddWithValue("id", DGVEXPIREDPROD.SelectedRows(i).Cells(0).Value.ToString())
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            view()

            MessageBox.Show("Product has been added to Archive", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
        Next
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
