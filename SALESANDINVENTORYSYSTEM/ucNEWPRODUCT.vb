
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
        DGVPRODUCTS.Columns(0).HeaderText = "Stock ID"

        DGVPRODUCTS.Columns(1).Width = 200
        DGVPRODUCTS.Columns(1).HeaderText = "Product ID"

        DGVPRODUCTS.Columns(2).Width = 200
        DGVPRODUCTS.Columns(2).HeaderText = "Product Name"

        DGVPRODUCTS.Columns(3).Width = 200
        DGVPRODUCTS.Columns(3).HeaderText = "Product Manufacturer"

        DGVPRODUCTS.Columns(4).Width = 200
        DGVPRODUCTS.Columns(4).HeaderText = "Product Brand"

        DGVPRODUCTS.Columns(5).Width = 200
        DGVPRODUCTS.Columns(5).HeaderText = "Category Name"

        DGVPRODUCTS.Columns(6).Width = 200
        DGVPRODUCTS.Columns(6).HeaderText = "Category Code"

    End Sub


    Private Sub Function_Enabled()


        BTNSAVE.Enabled = True
        BTNEDIT.Enabled = False
        BTNCSNCEL.Enabled = True
        TXTPI.Enabled = True
        CBOPRODCAT.Enabled = True
        TXTPNA.Enabled = True
        TXTBRAND.Enabled = True
        TXTBRAND.Enabled = True
        TXTPM.Enabled = True


    End Sub
    Private Sub Function_Disabled()
        BTNADD.Enabled = False
        BTNSAVE.Enabled = False
        BTNEDIT.Enabled = True
        BTNCSNCEL.Enabled = True
        TXTPI.Enabled = True
        CBOPRODCAT.Enabled = True
        TXTPNA.Enabled = True
        TXTBRAND.Enabled = True
        TXTBRAND.Enabled = True
        TXTPM.Enabled = True


    End Sub


    Private Sub disabled()

        BTNADD.Enabled = True
        BTNSAVE.Enabled = False
        BTNEDIT.Enabled = True
        BTNCSNCEL.Enabled = True
        TXTPI.Enabled = False
        CBOPRODCAT.Enabled = False
        TXTPNA.Enabled = False
        TXTBRAND.Enabled = False
        TXTBRAND.Enabled = False
        TXTPM.Enabled = False

    End Sub

    Private Sub searchproducts()
        Dim dba As New MySqlDataAdapter("select stockid, prodid, prodname, prodman, prodbrand, prodcat, catcode  from tbl_products  WHERE  tbl_products.stockid LIKE '%" & Me.TXTSEARCH.Text & "%' OR tbl_products.prodname LIKE '%" & Me.TXTSEARCH.Text & "%' OR tbl_products.prodid LIKE '%" & Me.TXTSEARCH.Text & "%'", con)
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
            cmd.CommandText = "Select Max(stockid) from tbl_products"
            getno = Convert.ToInt64(cmd.ExecuteScalar())
            con.Close()
            TXTSI.Text = getno + 1
        Else
            TXTSI.Text = 1
            con.Close()
        End If
    End Sub



    Private Sub dgv_refresh()
        'Me.Tbl_productsTableAdapter.Fill(Me.Inventory_dbDataSet.tbl_products)
    End Sub

    Private Sub VIEW()
        Try

            Dim da As New MySqlDataAdapter("select stockid, prodid, prodname, prodman, prodbrand, prodcat, catcode  from tbl_products ", con)
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
        row(1) = "-- Select --"

        tbl_category.Rows.InsertAt(row, 0)
        CBOPRODCAT.DataSource = tbl_category

        CBOPRODCAT.DisplayMember = “catname”
        CBOPRODCAT.ValueMember = "catcode"

        '---------------------------------- MANUFACTURER COMBOBOX DATA ------------------------------



    End Sub


    Private Sub Load_data()
        Try

            Dim da As New MySqlDataAdapter("select stockid, prodid, prodname, prodman, prodbrand, prodcat, catcode  from tbl_products ", con)
            Dim dt As New DataSet()
            da.Fill(dt)
            DGVPRODUCTS.DataSource = dt.Tables(0)


        Catch ex As Exception

            MessageBox.Show(ex.ToString())



        End Try
    End Sub

    Private Sub BTNSAVE_Click_1(sender As Object, e As EventArgs) Handles BTNSAVE.Click


        If CBOPRODCAT.Text = "-- Select --" Then
            MessageBox.Show("Please select a product category!", "Error Saving", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' ---------------------------------------------------------------------------------------------------------- ERROR TRAPPING ----------------------------------------------------------------------------------------------------------


        If TXTPI.Text = "" Or TXTPNA.Text = "" Or TXTPM.Text = "" Then
            MessageBox.Show("All fields are required!", "Error Saving", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        ' ---------------------------------------------------------------------------------------------------------- SAVING CODE ----------------------------------------------------------------------------------------------------------

        TXTPI.Focus()
        OpenCon()


        cmd.CommandText = "insert into tbl_products (stockid, prodid, prodname, prodman, prodbrand, prodcat, catcode, dateadddedprod) values (@si, @pid, @pna, @pm, @pb, @pc, @cc, @dap)  "
        With cmd.Parameters
            'cmd.CommandText = "insert into tbl_products values(@pid, @pno, @pna, @pm, @da)"
            'With cmd.Parameters
            .Clear()
            .AddWithValue("si", TXTSI.Text)
            .AddWithValue("pid", TXTPI.Text)
            .AddWithValue("pna", TXTPNA.Text)
            .AddWithValue("pb", TXTBRAND.Text)
            .AddWithValue("pm", TXTPM.Text)
            .AddWithValue("dap", DTP.Value)
            .AddWithValue("pc", CBOPRODCAT.Text)
            .AddWithValue("cc", TXTCATCODE.Text)

        End With
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("New product has been saved!", vbOKOnly + vbInformation, "Saving Successfully")
        activity = "Added new product. Product Name: " + TXTPNA.Text
        actlog()
        Function_Disabled()
        TXTPI.Text = ""
        TXTPNA.Text = ""
        TXTPM.Text = ""
        TXTBRAND.Text = ""
        CBOPRODCAT.Text = ""
        TXTCATCODE.Text = ""
        Load_data()
    End Sub

    Private Sub BTNEDIT_Click_1(sender As Object, e As EventArgs) Handles BTNEDIT.Click
        ' ---------------------------------------------------------------------------------------------------------- ERROR CODE ----------------------------------------------------------------------------------------------------------

        If BTNEDIT.Text = "Edit" Then
            If TXTPI.Text = "" Or TXTPNA.Text = "" Or TXTPM.Text = "" Then

                MsgBox("Please select a record to edit!", vbOKOnly + vbCritical, "Error Editing")
                Exit Sub



            End If

        ElseIf BTNEDIT.Text = "Update" Then

            If TXTPI.Text = "" Or TXTPNA.Text = "" Or TXTPM.Text = "" Then
                MsgBox("All fields are required!", vbOKOnly + vbCritical, "Error Saving")
                TXTPI.Focus()
                Exit Sub
            End If
        End If
        OpenCon()
        cmd.CommandText = "Update tbl_products set prodid =@pi, prodname=@pna, prodman=@pm, prodbrand=@pb, prodcat=@pc, catcode=@cc where prodid= @pi"
        With cmd.Parameters
            .Clear()
            .AddWithValue("pi", TXTPI.Text)
            .AddWithValue("pb", TXTBRAND.Text)
            .AddWithValue("pna", TXTPNA.Text)
            .AddWithValue("pm", TXTPM.Text)
            .AddWithValue("pc", CBOPRODCAT.Text)
            .AddWithValue("cc", TXTCATCODE.Text)

        End With
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Record has been updated!", vbOKOnly + vbInformation, "Editing Successful")
        BTNEDIT.Text = "Edit"
        TXTPI.Text = ""
        TXTPNA.Text = ""
        TXTBRAND.Text = ""
        TXTPM.Text = ""
        CBOPRODCAT.Text = ""
        TXTCATCODE.Text = ""
        Load_data()

    End Sub

    Private Sub SelectedColumnsDisplayInGridView_Load(sender As Object, e As Object) Handles MyBase.Load
        'DGVSETPROPERTY()
        VIEW()
    End Sub


    Private Sub BTNADD_Click(sender As Object, e As EventArgs) Handles BTNADD.Click
        Function_Enabled()
        Getmax()
    End Sub

    Private Sub BTNCSNCEL_Click_1(sender As Object, e As EventArgs) Handles BTNCSNCEL.Click

        disabled()
        TXTBRAND.Text = ""
        CBOPRODCAT.Text = "-- Select --"
        TXTCATCODE.Text = ""
        TXTPI.Text = ""
        TXTPNA.Text = ""
        TXTPM.Text = ""
        TXTSI.Text = ""
        TXTPI.Focus()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DTP.ValueChanged
        Format(Date.Now, "dd/MM/yyyy")
    End Sub
    Private Sub LBLEXIT_Click(sender As Object, e As EventArgs)
        FRMMAINMENU.Close()
        FRMLOGIN.Show()

    End Sub
    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        searchproducts()

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

    Private Sub DGVPRODUCTS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPRODUCTS.CellContentClick
        Function_Disabled()
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = DGVPRODUCTS.Rows(e.RowIndex)
            TXTSI.Text = row.Cells(0).Value
            TXTPI.Text = row.Cells(1).Value
            TXTPNA.Text = row.Cells(2).Value
            TXTPM.Text = row.Cells(3).Value
            TXTBRAND.Text = row.Cells(4).Value
            CBOPRODCAT.Text = row.Cells(5).Value
            TXTCATCODE.Text = row.Cells(6).Value

        End If
        BTNEDIT.Text = "Update"

    End Sub


End Class


