
Imports MySql.Data.MySqlClient


Public Class ucRESTOCK

    Private Sub actlog()
        con.Close()
        OpenCon()
        cmd.CommandText = "insert into tbl_actlog values (@un, @ut, @act, @dt)"
        With cmd.Parameters
            .Clear()
            .AddWithValue("un", FRMMAINMENU.LBLUSERNAME.Text)
            .AddWithValue("ut", FRMMAINMENU.LBLUSERTYPE.Text)
            .AddWithValue("act", activity)
            .AddWithValue("dt", Format(Date.Now, "yyyy-MM-dd h:mm tt"))
            cmd.ExecuteNonQuery()
            con.Close()
        End With
    End Sub
    Public Sub DGVMAINSET()


        DGVPRODUCTS.Columns(0).Width = 150
        DGVPRODUCTS.Columns(0).HeaderText = "Product ID"
        DGVPRODUCTS.Columns(1).Width = 150
        DGVPRODUCTS.Columns(1).HeaderText = "Product Code"
        DGVPRODUCTS.Columns(2).Width = 150
        DGVPRODUCTS.Columns(2).HeaderText = "Product Name"
        DGVPRODUCTS.Columns(3).Width = 150
        DGVPRODUCTS.Columns(3).HeaderText = "Manufacturer"
        DGVPRODUCTS.Columns(4).Width = 150
        DGVPRODUCTS.Columns(4).HeaderText = "Brand"
        DGVPRODUCTS.Columns(5).Width = 150
        DGVPRODUCTS.Columns(5).HeaderText = "Category"
        DGVPRODUCTS.Columns(6).Width = 150
        DGVPRODUCTS.Columns(6).HeaderText = "Category Code"
        DGVPRODUCTS.Columns(7).Width = 150
        DGVPRODUCTS.Columns(7).HeaderText = "Unit"
        DGVPRODUCTS.Columns(8).Width = 150
        DGVPRODUCTS.Columns(8).HeaderText = "Price"


    End Sub
    Private Sub VIEW()
        Try

            Dim da As New MySqlDataAdapter("select id, prodcode, prodname, manufacturer, brand, category, catcode, unit, price from tbl_products ", con)
            Dim dt As New DataSet()
            da.Fill(dt)
            DGVPRODUCTS.DataSource = dt.Tables(0)

            DGVMAINSET()
        Catch ex As Exception

            MessageBox.Show(ex.ToString())

        End Try
    End Sub
    Private Sub ucRESTOCK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VIEW()

        Dim cmd1 As New MySqlCommand("SELECT name, status FROM tbl_supplier WHERE status = 'Active'", con)
        Dim da1 As New MySqlDataAdapter(cmd1)
        Dim tbl_supplier As New DataTable()
        da1.Fill(tbl_supplier)

        Dim rowsup As DataRow = tbl_supplier.NewRow()
        rowsup("name") = "-- Select --"
        tbl_supplier.Rows.InsertAt(rowsup, 0)

        CBOSUPPLIER.DataSource = tbl_supplier
        CBOSUPPLIER.DisplayMember = "name"

    End Sub


    Private Sub DGVMAIN_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPRODUCTS.CellClick

        BTNSAVE.Text = "Save"
        con.Close()

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow


            row = DGVPRODUCTS.Rows(e.RowIndex)

            TXTID.Text = row.Cells(0).Value
            TXTPRODCODE.Text = row.Cells(1).Value
            TXTPRODNAME.Text = row.Cells(2).Value
            TXTMAN.Text = row.Cells(3).Value
            TXTBRAND.Text = row.Cells(4).Value
            TXTCATEGORY.Text = row.Cells(5).Value
            TXTCATCODE.Text = row.Cells(6).Value
            TXTUNIT.Text = row.Cells(7).Value
            TXTPRICE.Text = row.Cells(8).Value

        End If
    End Sub
    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click


        If Me.QTY.Text = "" Then
            MessageBox.Show("Please add a quantity.", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub

        End If

        If Me.QTY.Text = "0" Then
            MessageBox.Show("The Quantity is Zero", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End If

        cmd.CommandText = "INSERT INTO tbl_stocks (id, prodcode, prodname, manufacturer, brand, category, catcode, unit, price, quantity, manufactureddate, expirationdate, dateaddedstocks) " &
                  "VALUES (@id, @prodcode, @prodname, @manufacturer, @brand, @category, @catcode, @unit, @price, @quantity, @manufactureddate, @expirationdate, @dateaddedstocks)"

        cmd.Parameters.AddWithValue("@id", Me.DGVPRODUCTS.CurrentRow.Cells(0).Value)
        cmd.Parameters.AddWithValue("@prodcode", Me.DGVPRODUCTS.CurrentRow.Cells(1).Value)
        cmd.Parameters.AddWithValue("@prodname", Me.TXTPRODNAME.Text)
        cmd.Parameters.AddWithValue("@manufacturer", Me.DGVPRODUCTS.CurrentRow.Cells(3).Value)
        cmd.Parameters.AddWithValue("@brand", Me.TXTBRAND.Text)
        cmd.Parameters.AddWithValue("@category", Me.DGVPRODUCTS.CurrentRow.Cells(5).Value)
        cmd.Parameters.AddWithValue("@catcode", Me.DGVPRODUCTS.CurrentRow.Cells(6).Value)
        cmd.Parameters.AddWithValue("@unit", Me.DGVPRODUCTS.CurrentRow.Cells(7).Value)
        cmd.Parameters.AddWithValue("@price", Me.DGVPRODUCTS.CurrentRow.Cells(8).Value)
        cmd.Parameters.AddWithValue("@quantity", Me.QTY.Text)
        cmd.Parameters.AddWithValue("@manufactureddate", Me.MANU.Value.ToString("yyyy-MM-dd"))
        cmd.Parameters.AddWithValue("@expirationdate", Me.EXP.Value.ToString("yyyy-MM-dd"))
        cmd.Parameters.AddWithValue("@dateaddedstocks", Me.DELIVERED.Value.ToString("yyyy-MM-dd"))

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()


        MsgBox("New stock has been added", vbOKOnly + vbInformation, "Added Stock")
        activity = "Added stock. Product Name: " + TXTPRODNAME.Text + "Quantity"
        actlog()


        Dim cmdrec As New MySqlCommand("INSERT INTO tbl_delivery (supplier, prodid, prodcode, prodname, quantity, manufactureddate, expirationdate, datedelivered) VALUES (@supplier, @prodid, @prodcode, @prodname, @quantity, @manufactureddate, @expirationdate, @datedelivered)", con)

        With cmdrec.Parameters
            .Clear()
            .AddWithValue("@supplier", CBOSUPPLIER.Text)
            .AddWithValue("@prodid", DGVPRODUCTS.CurrentRow.Cells(0).Value)
            .AddWithValue("@prodcode", DGVPRODUCTS.CurrentRow.Cells(1).Value)
            .AddWithValue("@prodname", TXTPRODNAME.Text)
            .AddWithValue("@quantity", QTY.Text)
            .AddWithValue("@manufactureddate", Me.MANU.Value.ToString("yyyy-MM-dd"))
            .AddWithValue("@expirationdate", Me.EXP.Value.ToString("yyyy-MM-dd"))
            .AddWithValue("@datedelivered", Me.DELIVERED.Value.ToString("yyyy-MM-dd"))
        End With

        OpenCon()
        cmdrec.ExecuteNonQuery()
        con.Close()



        TXTPRODNAME.Text = ""
        TXTUNIT.Text = ""
        TXTPRICE.Text = ""
        QTY.Text = ""
        TXTMAN.Text = ""
        TXTBRAND.Text = ""



    End Sub
    Private Sub BTNBACK_Click_1(sender As Object, e As EventArgs) Handles BTNBACK.Click
        Dim i As Integer
        For i = 0 To 0
            FRMMAINMENU.PNLMAIN.Controls.RemoveAt(i)
        Next

        Dim SETTINGS As New ucSETTINGS()
        SETTINGS.Parent = FRMMAINMENU.PNLMAIN
        SETTINGS.Show()
        SETTINGS.Dock = DockStyle.Fill
    End Sub

    Private Sub EXP_ValueChanged(sender As Object, e As EventArgs) 
        EXP.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub MANU_ValueChanged(sender As Object, e As EventArgs) 
        MANU.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        PerformSearchAndLoadData(TXTSEARCH.Text)
    End Sub

    Private Sub PerformSearchAndLoadData(keyword As String)
        ' Perform the search and load the data
        Dim query As String = "SELECT id, prodcode, prodname, manufacturer, brand, category, catcode, unit, price FROM tbl_products WHERE CONCAT(id, prodcode, prodname, manufacturer, brand) LIKE @Keyword"
        Dim connectionString As String = "Server=localhost;Port=3306;User=root;Password=password;Database=inventory_db"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Keyword", "%" & keyword & "%")

                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                DGVPRODUCTS.DataSource = table
            End Using
        End Using
    End Sub

End Class
