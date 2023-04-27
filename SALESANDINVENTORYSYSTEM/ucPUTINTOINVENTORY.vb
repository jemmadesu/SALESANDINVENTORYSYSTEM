Imports MySql.Data.MySqlClient
Public Class ucPUTINTOINVENTORY
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
    Private Sub Function_Enable()
        BTNSAVE.Enabled = True
    End Sub

    Private Sub DGVSETPROPERTY()


        '--------------------------------------------------------------- CODE FOR COLUMN HEADER NAME (PRODUCT) -----------------------------------------
        DGVPRODUCTS.Columns(0).Width = 200
        DGVPRODUCTS.Columns(0).HeaderText = "Product ID"
        DGVPRODUCTS.Columns(1).Width = 200
        DGVPRODUCTS.Columns(1).HeaderText = "Product Name"
        DGVPRODUCTS.Columns(2).Width = 200
        DGVPRODUCTS.Columns(2).HeaderText = "Manufacturer"
        DGVPRODUCTS.Columns(3).Width = 200
        DGVPRODUCTS.Columns(3).HeaderText = "Brand"
        DGVPRODUCTS.Columns(4).Width = 200
        DGVPRODUCTS.Columns(4).HeaderText = "Category"
        DGVPRODUCTS.Columns(5).Width = 200
        DGVPRODUCTS.Columns(5).HeaderText = "Category Code"



    End Sub

    Private Sub DGVMAINSET()
        DGVMAIN.Columns(0).Width = 200
        DGVMAIN.Columns(0).HeaderText = "Stock ID"
        DGVMAIN.Columns(1).Width = 200
        DGVMAIN.Columns(1).HeaderText = "Product ID"
        DGVMAIN.Columns(2).Width = 200
        DGVMAIN.Columns(2).HeaderText = "Product Name"
        DGVMAIN.Columns(3).Width = 200
        DGVMAIN.Columns(3).HeaderText = "Manufacturer"
        DGVMAIN.Columns(4).Width = 200
        DGVMAIN.Columns(4).HeaderText = "Brand"
        DGVMAIN.Columns(5).Width = 200
        DGVMAIN.Columns(5).HeaderText = "Category"
        DGVMAIN.Columns(6).Width = 200
        DGVMAIN.Columns(6).HeaderText = "Category Code"
        DGVMAIN.Columns(7).Width = 200
        DGVMAIN.Columns(7).HeaderText = "Price"
        DGVMAIN.Columns(8).Width = 200
        DGVMAIN.Columns(8).HeaderText = "Unit"
        DGVMAIN.Columns(9).Width = 200
        DGVMAIN.Columns(9).HeaderText = "Stocks"
        DGVMAIN.Columns(10).Width = 200
        DGVMAIN.Columns(10).HeaderText = "Expiration Date"

    End Sub
    Private Sub SelectedColumnsDisplayInGridView_Load(sender As Object, e As Object) Handles MyBase.Load
        VIEW()
    End Sub

    Private Sub VIEW()

        ' ------------------------------------------------------------ FOR DISPLAYING THE COLUMN HEADER (PRODUCTS) -------------------------------------------------
        Try

            Dim da As New MySqlDataAdapter("select prodid, prodname, prodman, prodbrand, prodcat, catcode from tbl_products ", con)
            Dim dt As New DataSet()
            da.Fill(dt)
            DGVPRODUCTS.DataSource = dt.Tables(0)

            DGVSETPROPERTY()
        Catch ex As Exception

            MessageBox.Show(ex.ToString())



        End Try

    End Sub
    Private Sub LOADDATAMAIN()
        Try

            Dim da As New MySqlDataAdapter("select stockid, prodid, prodname, prodman, prodbrand, prodcat, catcode, price, unit, quantity, expirationdate from tbl_stocks", con)
            Dim dt As New DataSet()
            da.Fill(dt)
            DGVMAIN.DataSource = dt.Tables(0)

            DGVMAINSET()
        Catch ex As Exception

            MessageBox.Show(ex.ToString())



        End Try

    End Sub
    Private Sub LOADDATAPROD()


        ' ------------------------------------------------------------ LOAD DATA (PRODUCTS) --------------------------------------------------------------------

        Try

            Dim da As New MySqlDataAdapter("select prodid, prodname, prodman, prodbrand, prodcat, catcode from tbl_products ", con)
            Dim dt As New DataSet()
            da.Fill(dt)
            DGVPRODUCTS.DataSource = dt.Tables(0)


        Catch ex As Exception

            MessageBox.Show(ex.ToString())



        End Try
    End Sub
    Private Sub ucPUTINTOINVENTORY_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        ' -------------------------------------------------------- FOR GETTING DATA TABLE TO DATA GRID "PRODUCTS" (MAIN FORM) -------------------------------------------------

        LOADDATAPROD()

        DTPED.Format = DateTimePickerFormat.Custom
        DTPED.CustomFormat = "   "

        ' -------------------------------------------------------- FOR GETTING DATA TABLE TO DATA GRID "WHOLE" (MAIN FORM) -------------------------------------------------


        LOADDATAMAIN()


    End Sub
    Private Sub DTPED_ValueChanged(sender As Object, e As EventArgs) Handles DTPED.ValueChanged
        DTPED.CustomFormat = "yyy/dd/MM"
    End Sub


    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DTPAS.ValueChanged
        DTPAS.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub TXTUNIT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTUNIT.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXTPRICE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTPRICE.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DGVPRODUCTS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPRODUCTS.CellContentClick

        ' -------------------------------------------------------------- FOR CELL CLICK (PRODUCTS) ----------------------------------------
        con.Close()

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow


            row = DGVPRODUCTS.Rows(e.RowIndex)

            TXTPI.Text = row.Cells(0).Value
            TXTPNA.Text = row.Cells(1).Value


        End If

        Function_Enable()
        'Getmax()
    End Sub



    Private Sub DGVMAIN_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVMAIN.CellContentClick
        con.Close()

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow


            row = DGVMAIN.Rows(e.RowIndex)

            TextBox1.Text = row.Cells(1).Value
        End If
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

    Private Sub BTNDELETE_Click_1(sender As Object, e As EventArgs) Handles BTNDELETE.Click
        For i As Integer = 0 To DGVMAIN.SelectedRows.Count - 1
            Dim cmd As New MySqlCommand("delete from tbl_products where stockid = @si ", con)
            cmd.Parameters.AddWithValue("si", DGVMAIN.SelectedRows(i).Cells(0).Value.ToString())
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Next
        LOADDATAMAIN()
        MessageBox.Show("product deleted succesfully")
        activity = "deleted a product. ProductID:" + TextBox1.Text

        actlog()
    End Sub

    Private Sub BTNSAVE_Click_1(sender As Object, e As EventArgs) Handles BTNSAVE.Click


        ' ------------------------------------------------------------- SAVING CODE -------------------------------------------------------------------

        If NUDQUANTITY.Text = "" Or TXTPRICE.Text = "" Or TXTUNIT.Text = "" Or CBOUNIT.Text = "" Then
            MsgBox("All fields are required!", vbOKOnly + vbCritical, "Error Saving")
            TXTPRICE.Focus()
        End If

        'save code - tbl_bookstock (insert into)

        con.Close()
        txtmix.Text = TXTUNIT.Text + " " + CBOUNIT.Text

        'Dim x As Integer
        'For x = 0 To DGVPRODUCTS.Rows.Count - 1


        cmd.CommandText = "INSERT INTO tbl_stocks (prodid, prodname, prodman, prodbrand, prodcat, catcode, price, unit, quantity, expirationdate, dateaddedstocks) " &
                  "VALUES (" & Me.TXTPI.Text & ", '" & Me.TXTPNA.Text & "', '" & Me.DGVPRODUCTS.CurrentRow.Cells(2).Value & "', '" & Me.DGVPRODUCTS.CurrentRow.Cells(3).Value & "', '" & Me.DGVPRODUCTS.CurrentRow.Cells(4).Value & "', '" & Me.DGVPRODUCTS.CurrentRow.Cells(5).Value & "', " & Me.TXTPRICE.Text & ", '" & Me.txtmix.Text & "', " & Me.NUDQUANTITY.Value & ", '" & Me.DTPED.Value.ToString("yyyy-MM-dd") & "', '" & Me.DTPAS.Value.ToString("yyyy-MM-dd HH:mm:ss") & "')"
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()



        MessageBox.Show("Thank you Very Much", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information)

        MsgBox("New product has been added into inventory!", vbOKOnly + vbInformation, "Added New Stock")
        activity = "Added new product into inventory. Product Name: " + TXTPNA.Text
        actlog()
        NUDQUANTITY.Text = ""
        TXTPRICE.Text = ""
        DTPED.Text = ""
        txtmix.Text = ""
        CBOUNIT.Text = ""
        TXTUNIT.Text = ""

        LOADDATAPROD()
        LOADDATAMAIN()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
