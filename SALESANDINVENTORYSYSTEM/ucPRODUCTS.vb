
Imports MySql.Data.MySqlClient


Public Class ucNEWPRODUCT
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

    'Dim con As New MySqlConnection("Data Source=. ;initial Catalog=DatabaseSql; User ID = root;Password = password")
    Private Sub DGVSETPROPERTY()


        DGVPRODUCTS.Columns(0).Width = 200
        DGVPRODUCTS.Columns(0).HeaderText = "Product ID"

        DGVPRODUCTS.Columns(1).Width = 200
        DGVPRODUCTS.Columns(1).HeaderText = "Product Code"

        DGVPRODUCTS.Columns(2).Width = 200
        DGVPRODUCTS.Columns(2).HeaderText = "Product Name"

        DGVPRODUCTS.Columns(3).Width = 200
        DGVPRODUCTS.Columns(3).HeaderText = "Manufacturer"

        DGVPRODUCTS.Columns(4).Width = 200
        DGVPRODUCTS.Columns(4).HeaderText = "Product Brand"

        DGVPRODUCTS.Columns(5).Width = 200
        DGVPRODUCTS.Columns(5).HeaderText = "Category Name"

        DGVPRODUCTS.Columns(6).Width = 200
        DGVPRODUCTS.Columns(6).HeaderText = "Category Code"

        DGVPRODUCTS.Columns(7).Width = 200
        DGVPRODUCTS.Columns(7).HeaderText = "Unit"

        DGVPRODUCTS.Columns(8).Width = 200
        DGVPRODUCTS.Columns(8).HeaderText = "Price"

    End Sub


    Private Sub Functionadd()


        BTNSAVE.Enabled = True
        BTNEDIT.Enabled = False
        BTNCSNCEL.Enabled = True
        TXTPI.Enabled = True
        CBOPRODCAT.Enabled = True
        TXTPNA.Enabled = True
        CBOBRAND.Enabled = True
        CBOMANUFACTURER.Enabled = True
        TXTUNIT.Enabled = True
        TXTPRICE.Enabled = True


    End Sub
    Private Sub Functionupdate()

        BTNADD.Enabled = False
        BTNSAVE.Enabled = False
        BTNEDIT.Enabled = True
        BTNCSNCEL.Enabled = True
        TXTPI.Enabled = True
        CBOPRODCAT.Enabled = True
        TXTPNA.Enabled = True
        CBOBRAND.Enabled = True
        CBOMANUFACTURER.Enabled = True
        TXTUNIT.Enabled = True
        TXTPRICE.Enabled = True


    End Sub


    Private Sub Functionafterupdate()

        BTNADD.Enabled = True
        BTNSAVE.Enabled = False
        BTNEDIT.Enabled = False
        BTNCSNCEL.Enabled = True
        TXTPI.Enabled = False
        CBOPRODCAT.Enabled = False
        TXTPNA.Enabled = False
        CBOBRAND.Enabled = False
        CBOBRAND.Enabled = False
        CBOMANUFACTURER.Enabled = False
        TXTUNIT.Enabled = False
        TXTPRICE.Enabled = False




    End Sub

    Private Sub searchproducts()
        Dim dba As New MySqlDataAdapter("select id, prodcode, prodname, manufacturer, brand, category, catcode, unit, price  from tbl_products  WHERE tbl_products.prodname LIKE '%" & Me.TXTSEARCH.Text & "%' OR tbl_products.prodcode LIKE '%" & Me.TXTSEARCH.Text & "%'", con)
        Dim dbset As New DataSet
        dba.Fill(dbset)
        Me.DGVPRODUCTS.DataSource = dbset.Tables(0).DefaultView

    End Sub



    Private Sub Getmax()
        OpenCon()
        cmd.CommandText = "Select * from tbl_products"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Dim getno As Integer
            con.Close()
            OpenCon()
            cmd.CommandText = "Select Max(id) from tbl_products"
            getno = Convert.ToInt64(cmd.ExecuteScalar())
            con.Close()
            LBLID.Text = getno + 1
        Else
            LBLID.Text = 1
            con.Close()
        End If
    End Sub

    Private Sub VIEW()
        Try

            Dim da As New MySqlDataAdapter("select id, prodcode, prodname, manufacturer, brand, category, catcode, unit, price from tbl_products ", con)
            Dim dt As New DataSet()
            da.Fill(dt)
            DGVPRODUCTS.DataSource = dt.Tables(0)

            DGVSETPROPERTY()
        Catch ex As Exception

            MessageBox.Show(ex.ToString())



        End Try
    End Sub
    Private Sub ucADDNEWPRODUCT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '---------------------------------- CATEGORY COMBOBOX DATA ------------------------------

        Dim cmd As New MySqlCommand(“select catcode,catname from tbl_category”, con)
        Dim da As New MySqlDataAdapter
        da.SelectCommand = cmd
        Dim tbl_category As New DataTable
        da.Fill(tbl_category)

        Dim row As DataRow = tbl_category.NewRow

        row(0) = 0
        row(1) = "-- select --"

        tbl_category.Rows.InsertAt(row, 0)
        CBOPRODCAT.DataSource = tbl_category

        CBOPRODCAT.DisplayMember = “catname”
        CBOPRODCAT.ValueMember = "catcode"

        '---------------------------------- MANUFACTURER COMBOBOX DATA ------------------------------

        Dim cmd1 As New MySqlCommand("SELECT refno, manufacturer, status FROM tbl_manufacturer WHERE status = 'Active'", con)
        Dim da1 As New MySqlDataAdapter(cmd1)
        Dim tbl_manufacturer As New DataTable()
        da1.Fill(tbl_manufacturer)

        Dim rowsup As DataRow = tbl_manufacturer.NewRow()
        rowsup("manufacturer") = "-- Select --"
        tbl_manufacturer.Rows.InsertAt(rowsup, 0)

        CBOMANUFACTURER.DataSource = tbl_manufacturer
        CBOMANUFACTURER.DisplayMember = "manufacturer"

        '---------------------------------- BRAND COMBOBOX DATA ------------------------------

        Dim cmd3 As New MySqlCommand("SELECT refno, manufacturer, brand, status FROM tbl_brand WHERE status = 'Active'", con)
        Dim da3 As New MySqlDataAdapter(cmd3)
        Dim tbl_brand As New DataTable()
        da3.Fill(tbl_brand)

        Dim rowbrand As DataRow = tbl_brand.NewRow()
        rowbrand("brand") = "-- Select --"
        tbl_brand.Rows.InsertAt(rowbrand, 0)

        CBOBRAND.DataSource = tbl_brand
        CBOBRAND.DisplayMember = "brand"

    End Sub
    Private Sub BTNSAVE_Click_1(sender As Object, e As EventArgs) Handles BTNSAVE.Click



        If CBOPRODCAT.Text = "-- Select --" Or CBOMANUFACTURER.Text = "-- Select --" Or CBOBRAND.Text = "-- Select --" Then
            MessageBox.Show("Please select a product category!", "Error Saving", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' ---------------------------------------------------------------------------------------------------------- ERROR TRAPPING ----------------------------------------------------------------------------------------------------------


        If TXTPI.Text = "" Or TXTPNA.Text = "" Or TXTCATCODE.Text = "" Or CBOMANUFACTURER.Text = "" Or CBOBRAND.Text = "" Or CBOPRODCAT.Text = "" Then
            MessageBox.Show("All fields are required!", "Error Saving", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        ' ---------------------------------------------------------------------------------------------------------- SAVING CODE ----------------------------------------------------------------------------------------------------------

        'Dim result As String = TXTUNIT.Text & CBOUNIT.Text


        TXTPI.Focus()

        OpenCon()
        cmd.CommandText = "insert into tbl_products (id, prodid, prodname, manufacturer, brand, category, catcode, unit, price dateaddedprod) values (@id, @pid, @pna, @pm, @pb, @pc, @cc, @un, @pr, @dap)"
        With cmd.Parameters

            .Clear()
            .AddWithValue("id", LBLID.Text)
            .AddWithValue("pid", TXTPI.Text)
            .AddWithValue("pna", TXTPNA.Text)
            .AddWithValue("pm", CBOMANUFACTURER.Text)
            .AddWithValue("pb", CBOBRAND.Text)
            .AddWithValue("pc", CBOPRODCAT.Text)
            .AddWithValue("cc", TXTCATCODE.Text)
            .AddWithValue("un", TXTUNIT.Text)
            .AddWithValue("pr", TXTPRICE.Text)
            .AddWithValue("dap", Format(Date.Now, "yyyy-MM-dd"))


        End With
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("New product has been saved!", vbOKOnly + vbInformation, "Saving Successfully")
        activity = "Added new product. Product Name: " + TXTPNA.Text
        actlog()

        Functionupdate()

        TXTPI.Text = ""
        TXTPNA.Text = ""
        CBOMANUFACTURER.Text = ""
        CBOBRAND.Text = ""
        CBOPRODCAT.Text = ""
        TXTCATCODE.Text = ""
        VIEW()
    End Sub

    Private Sub BTNEDIT_Click_1(sender As Object, e As EventArgs) Handles BTNEDIT.Click

        ' ---------------------------------------------------------------------------------------------------------- ERROR CODE ----------------------------------------------------------------------------------------------------------

        If CBOPRODCAT.Text = "-- Select --" Or CBOMANUFACTURER.Text = "-- Select --" Or CBOBRAND.Text = "-- Select --" Then
            MessageBox.Show("Please select a product category!", "Error Saving", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If BTNEDIT.Text = "Edit" Then
            If TXTPI.Text = "" Or TXTPNA.Text = "" Or CBOMANUFACTURER.Text = "" Then

                MsgBox("Please select a record to edit!", vbOKOnly + vbCritical, "Error Editing")
                Exit Sub
            End If

        ElseIf BTNEDIT.Text = "Update" Then
            If TXTPI.Text = "" Or TXTPNA.Text = "" Or TXTCATCODE.Text = "" Or CBOMANUFACTURER.Text = "" Or CBOBRAND.Text = "" Or CBOPRODCAT.Text = "" Or TXTPRICE.Text = "" Then
                MessageBox.Show("All fields are required!", "Error Saving", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        Dim selectedRow As DataGridViewRow = DGVPRODUCTS.SelectedRows(0)
        Dim ID As String = selectedRow.Cells(0).Value.ToString()


        Using con As New MySqlConnection(“Server=localhost;Port=3306;User=root;Password=password;Database=inventory_db”)
            Using cmd As New MySqlCommand()
                cmd.Connection = con
                con.Open()

                cmd.CommandText = "Update tbl_products set id=@id, prodcode =@pi, prodname=@pna, manufacturer=@pm, brand=@pb, category=@pc, catcode=@cc, price=@pr, unit=@un where id=@id"

                cmd.Parameters.AddWithValue("@id", ID)
                cmd.Parameters.AddWithValue("@pi", TXTPI.Text)
                cmd.Parameters.AddWithValue("@pb", CBOBRAND.Text)
                cmd.Parameters.AddWithValue("@pna", TXTPNA.Text)
                cmd.Parameters.AddWithValue("@pm", CBOMANUFACTURER.Text)
                cmd.Parameters.AddWithValue("@pc", CBOPRODCAT.Text)
                cmd.Parameters.AddWithValue("@cc", TXTCATCODE.Text)
                cmd.Parameters.AddWithValue("@pr", TXTPRICE.Text)
                cmd.Parameters.AddWithValue("@un", TXTUNIT.Text)

                cmd.ExecuteNonQuery()

                con.Close()
            End Using
        End Using

        MsgBox("Record has been updated!", vbOKOnly + vbInformation, "Editing Successful")
        BTNEDIT.Text = "Edit"
        TXTPI.Text = ""
        TXTPNA.Text = ""
        CBOBRAND.Text = ""
        CBOMANUFACTURER.Text = ""
        CBOPRODCAT.Text = ""
        TXTCATCODE.Text = ""
        TXTUNIT.Text = ""
        TXTPRICE.Text = ""

        VIEW()

    End Sub

    Private Sub SelectedColumnsDisplayInGridView_Load(sender As Object, e As Object) Handles MyBase.Load
        'DGVSETPROPERTY()
        VIEW()
    End Sub


    Private Sub BTNADD_Click(sender As Object, e As EventArgs) Handles BTNADD.Click
        Functionadd()
        Getmax()
    End Sub

    Private Sub BTNCSNCEL_Click_1(sender As Object, e As EventArgs) Handles BTNCSNCEL.Click

        Functionafterupdate()
        CBOMANUFACTURER.Text = "-- Select --"
        CBOBRAND.Text = "-- Select --"
        CBOPRODCAT.Text = "-- Select --"
        CBOMANUFACTURER.Text = "-- Select --"
        TXTCATCODE.Text = ""
        TXTPI.Text = ""
        TXTPNA.Text = ""
        TXTPRICE.Text = ""
        TXTUNIT.Text = ""
        TXTPI.Focus()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DTP.ValueChanged
        Format(Date.Now, "dd/MM/yyyy")
    End Sub
    Private Sub LBLEXIT_Click(sender As Object, e As EventArgs)
        FRMMAINMENU.Close()
        FRMLOGIN.Show()

    End Sub
    Private Sub CBOPRODCAT_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CBOPRODCAT.SelectionChangeCommitted
        TXTCATCODE.Text = CBOPRODCAT.SelectedValue
    End Sub

    Private Sub BTNBACK_Click(sender As Object, e As EventArgs) Handles BTNBACK.Click
        Dim i As Integer
        For i = 0 To 0
            FRMMAINMENU.PNLMAIN.Controls.RemoveAt(i)
        Next

        Dim SETTINGS As New ucSETTINGS()
        SETTINGS.Parent = FRMMAINMENU.PNLMAIN
        SETTINGS.Show()
        SETTINGS.Dock = DockStyle.Fill
    End Sub

    Private Sub DGVPRODUCTS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPRODUCTS.CellClick
        Functionupdate()
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = DGVPRODUCTS.Rows(e.RowIndex)

            TXTPI.Text = row.Cells(1).Value
            TXTPNA.Text = row.Cells(2).Value
            CBOMANUFACTURER.Text = row.Cells(3).Value
            CBOBRAND.Text = row.Cells(4).Value
            CBOPRODCAT.Text = row.Cells(5).Value
            TXTCATCODE.Text = row.Cells(6).Value
            TXTUNIT.Text = row.Cells(7).Value
            TXTPRICE.Text = row.Cells(8).Value

        End If
        BTNEDIT.Text = "Update"

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


