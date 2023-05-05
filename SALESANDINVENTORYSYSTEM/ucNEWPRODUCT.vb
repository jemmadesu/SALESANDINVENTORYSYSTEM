
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
        DGVPRODUCTS.Columns(1).HeaderText = "Product Name"

        DGVPRODUCTS.Columns(2).Width = 200
        DGVPRODUCTS.Columns(2).HeaderText = "Product Manufacturer"

        DGVPRODUCTS.Columns(3).Width = 200
        DGVPRODUCTS.Columns(3).HeaderText = "Product Brand"

        DGVPRODUCTS.Columns(4).Width = 200
        DGVPRODUCTS.Columns(4).HeaderText = "Category Name"

        DGVPRODUCTS.Columns(5).Width = 200
        DGVPRODUCTS.Columns(5).HeaderText = "Category Code"

    End Sub


    Private Sub Function_Enabled()


        BTNSAVE.Enabled = True
        BTNEDIT.Enabled = False
        BTNCSNCEL.Enabled = True
        TXTPI.Enabled = True
        CBOPRODCAT.Enabled = True
        TXTPNA.Enabled = True
        CBOBRAND.Enabled = True
        CBOBRAND.Enabled = True
        CBOMANUFACTURER.Enabled = True


    End Sub
    Private Sub Function_Disabled()
        BTNADD.Enabled = False
        BTNSAVE.Enabled = False
        BTNEDIT.Enabled = True
        BTNCSNCEL.Enabled = True
        TXTPI.Enabled = True
        CBOPRODCAT.Enabled = True
        TXTPNA.Enabled = True
        CBOBRAND.Enabled = True
        CBOBRAND.Enabled = True
        CBOMANUFACTURER.Enabled = True


    End Sub


    Private Sub disabled()

        BTNADD.Enabled = True
        BTNSAVE.Enabled = False
        BTNEDIT.Enabled = True
        BTNCSNCEL.Enabled = True
        TXTPI.Enabled = False
        CBOPRODCAT.Enabled = False
        TXTPNA.Enabled = False
        CBOBRAND.Enabled = False
        CBOBRAND.Enabled = False
        CBOMANUFACTURER.Enabled = False


    End Sub

    Private Sub searchproducts()
        Dim dba As New MySqlDataAdapter("select prodid, prodname, prodman, prodbrand, prodcat, catcode  from tbl_products  WHERE tbl_products.prodname LIKE '%" & Me.TXTSEARCH.Text & "%' OR tbl_products.prodid LIKE '%" & Me.TXTSEARCH.Text & "%'", con)
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

            Dim da As New MySqlDataAdapter("select prodid, prodname, prodman, prodbrand, prodcat, catcode  from tbl_products ", con)
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
        Dim cmd1 As New MySqlCommand("select companyname from tbl_supplier", con)
        Dim da1 As New MySqlDataAdapter
        da1.SelectCommand = cmd1
        Dim tbl_supplier As New DataTable
        da1.Fill(tbl_supplier)

        Dim rowsup As DataRow = tbl_supplier.NewRow()

        rowsup("companyname") = "-- Select --"
        tbl_supplier.Rows.InsertAt(rowsup, 0)

        CBOMANUFACTURER.DataSource = tbl_supplier
        CBOMANUFACTURER.DisplayMember = "companyname"



    End Sub


    Private Sub Load_data()
        Try

            Dim da As New MySqlDataAdapter("select prodid, prodname, prodman, prodbrand, prodcat, catcode  from tbl_products ", con)
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


        If TXTPI.Text = "" Or TXTPNA.Text = "" Or CBOMANUFACTURER.Text = "" Then
            MessageBox.Show("All fields are required!", "Error Saving", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        ' ---------------------------------------------------------------------------------------------------------- SAVING CODE ----------------------------------------------------------------------------------------------------------

        TXTPI.Focus()
        OpenCon()


        cmd.CommandText = "insert into tbl_products (id, prodid, prodname, prodman, prodbrand, prodcat, catcode, dateaddedprod) values (@id, @pid, @pna, @pm, @pb, @pc, @cc, @dap)"
        With cmd.Parameters

            .Clear()
            .AddWithValue("id", LBLID.Text)
            .AddWithValue("pid", TXTPI.Text)
            .AddWithValue("pna", TXTPNA.Text)
            .AddWithValue("pm", CBOMANUFACTURER.Text)
            .AddWithValue("pb", CBOBRAND.Text)
            .AddWithValue("pc", CBOPRODCAT.Text)
            .AddWithValue("cc", TXTCATCODE.Text)
            .AddWithValue("dap", Format(Date.Now, "yyyy-MM-dd"))


        End With
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("New product has been saved!", vbOKOnly + vbInformation, "Saving Successfully")
        activity = "Added new product. Product Name: " + TXTPNA.Text
        actlog()
        Function_Disabled()
        TXTPI.Text = ""
        TXTPNA.Text = ""
        CBOMANUFACTURER.Text = ""
        CBOBRAND.Text = ""
        CBOPRODCAT.Text = ""
        TXTCATCODE.Text = ""
        Load_data()
    End Sub

    Private Sub BTNEDIT_Click_1(sender As Object, e As EventArgs) Handles BTNEDIT.Click
        ' ---------------------------------------------------------------------------------------------------------- ERROR CODE ----------------------------------------------------------------------------------------------------------

        If BTNEDIT.Text = "Edit" Then
            If TXTPI.Text = "" Or TXTPNA.Text = "" Or CBOMANUFACTURER.Text = "" Then

                MsgBox("Please select a record to edit!", vbOKOnly + vbCritical, "Error Editing")
                Exit Sub



            End If

        ElseIf BTNEDIT.Text = "Update" Then

            If TXTPI.Text = "" Or TXTPNA.Text = "" Or CBOMANUFACTURER.Text = "" Then
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
            .AddWithValue("pb", CBOBRAND.Text)
            .AddWithValue("pna", TXTPNA.Text)
            .AddWithValue("pm", CBOMANUFACTURER.Text)
            .AddWithValue("pc", CBOPRODCAT.Text)
            .AddWithValue("cc", TXTCATCODE.Text)

        End With
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Record has been updated!", vbOKOnly + vbInformation, "Editing Successful")
        BTNEDIT.Text = "Edit"
        TXTPI.Text = ""
        TXTPNA.Text = ""
        CBOBRAND.Text = ""
        CBOMANUFACTURER.Text = ""
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
        CBOBRAND.Text = ""
        CBOMANUFACTURER.Text = "-- Select --"
        CBOPRODCAT.Text = "-- Select --"
        TXTCATCODE.Text = ""
        TXTPI.Text = ""
        TXTPNA.Text = ""
        CBOMANUFACTURER.Text = ""
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
            TXTPI.Text = row.Cells(0).Value
            TXTPNA.Text = row.Cells(1).Value
            CBOMANUFACTURER.Text = row.Cells(2).Value
            CBOBRAND.Text = row.Cells(3).Value
            CBOPRODCAT.Text = row.Cells(4).Value
            TXTCATCODE.Text = row.Cells(5).Value

        End If
        BTNEDIT.Text = "Update"

    End Sub


End Class


