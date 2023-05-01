
Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class ucTRANSACTION

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer


    Private Sub search()
        Dim dba As New MySqlDataAdapter("select prodid, prodname, prodbrand, prodcat, catcode, price, unit, quantity from tbl_stocks WHERE tbl_stocks.prodname LIKE '%" & Me.TXTSEARCH.Text & "%';", con)
        Dim dbset As New DataSet
        dba.Fill(dbset)
        Me.DGVPRODUCTS.DataSource = dbset.Tables(0).DefaultView
    End Sub
    Private Sub ucTRANSACTION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Close()


        '------------------------------------------

        lbldate.Text = Format(Date.Now, "yyyy-MM-dd")

        TRANSADATE.Format = DateTimePickerFormat.Custom
        TRANSADATE.CustomFormat = "yyyy/MM/dd"



        showproducts()
        showcart()
        remove()

    End Sub

    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = DGVCART.Rows.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 500

    End Sub
    Private Sub BTNPRINT_Click(sender As Object, e As EventArgs)
        changelongpaper()
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub
    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String

        line = "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -"


        e.Graphics.DrawString("RPHECMPC", f10b, Brushes.Black, centermargin, 5, center)
        e.Graphics.DrawString("Rizal Provincial Hospital Employees", f8, Brushes.Black, centermargin, 25, center)
        e.Graphics.DrawString("and Community Multi-purpose Cooperative", f8, Brushes.Black, centermargin, 40, center)
        e.Graphics.DrawString("Tomas Claudio St. San Juan Morong, Rizal", f8, Brushes.Black, centermargin, 55, center)

        'e.Graphics.DrawString(line, f8, Brushes.Black, 0, 100)

        e.Graphics.DrawString("Invoice No.: " + TXTOR.Text.ToString, f8, Brushes.Black, 0, 80)
        e.Graphics.DrawString("Cashier: " + FRMMAINMENU.LBLUSERNAME.Text.ToString, f8, Brushes.Black, 0, 95)
        e.Graphics.DrawString("Date: " & Date.Now(), f8, Brushes.Black, 0, 110)


        Dim height As Integer
        Dim i As Long

        DGVCART.AllowUserToAddRows = False

        For row As Integer = 0 To DGVCART.RowCount - 1
            height += 15
            e.Graphics.DrawString("Qty " + DGVCART.Rows(row).Cells(7).Value.ToString, f10, Brushes.Black, 0, 120 + height)
            e.Graphics.DrawString(DGVCART.Rows(row).Cells(1).Value.ToString, f10, Brushes.Black, 35, 120 + height)


        Next
        Dim height2 As Integer
        height2 = 110 + height

        sumprice()

        e.Graphics.DrawString("Total Qty: " & t_qty, f10b, Brushes.Black, 0, 50 + height2)
        e.Graphics.DrawString("Total: " & Format(t_price, "##,##0"), f10b, Brushes.Black, rightmargin, 50 + height2, right)



        e.Graphics.DrawString("Payment: " + TXTPAYMENT.Text.ToString, f10b, Brushes.Black, 0, 65 + height2)
        e.Graphics.DrawString("Discount Type: " + CBODISCOUNT.Text.ToString, f10b, Brushes.Black, 0, 80 + height2)
        e.Graphics.DrawString("Change: " + TXTCHANGE.Text.ToString, f10b, Brushes.Black, 0, 95 + height2)

        e.Graphics.DrawString("Thanks for Shopping”, f10, Brushes.Black, centermargin, 150 + height2, center)
        e.Graphics.DrawString("This serves as your official receipt", f10, Brushes.Black, centermargin, 180 + height2, center)

    End Sub
    Dim t_price As Long
    Dim t_qty As Long
    Sub sumprice()
        t_price = Val(TOTALBILL.Text)

        Dim countqty As Long = 0
        For rowitem As Long = 0 To DGVCART.RowCount - 1
            countqty = countqty + DGVCART.Rows(rowitem).Cells(7).Value
        Next
        t_qty = countqty
    End Sub
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

    Private Sub DGVSETPROPERTYPROD()


        '--------------------------------------------------------------- CODE FOR COLUMN HEADER NAME (PRODUCTS) -----------------------------------------
        DGVPRODUCTS.Columns(0).Width = 200
        DGVPRODUCTS.Columns(0).HeaderText = "Product ID"
        DGVPRODUCTS.Columns(1).Width = 200
        DGVPRODUCTS.Columns(1).HeaderText = "Product Name"
        DGVPRODUCTS.Columns(2).Width = 200
        DGVPRODUCTS.Columns(2).HeaderText = "Product Brand"
        DGVPRODUCTS.Columns(3).Width = 200
        DGVPRODUCTS.Columns(3).HeaderText = "Category Name"
        DGVPRODUCTS.Columns(4).Width = 200
        DGVPRODUCTS.Columns(4).HeaderText = "Category Code"
        DGVPRODUCTS.Columns(5).Width = 200
        DGVPRODUCTS.Columns(5).HeaderText = "Price"
        DGVPRODUCTS.Columns(6).Width = 200
        DGVPRODUCTS.Columns(6).HeaderText = "Unit"
        DGVPRODUCTS.Columns(7).Width = 200
        DGVPRODUCTS.Columns(7).HeaderText = "Stocks"


    End Sub

    Private Sub DGVSETPROPERTYCART()


        '--------------------------------------------------------------- CODE FOR COLUMN HEADER NAME (CART) -----------------------------------------
        DGVCART.Columns(0).Width = 200
        DGVCART.Columns(0).HeaderText = "Product ID"
        DGVCART.Columns(1).Width = 200
        DGVCART.Columns(1).HeaderText = "Product Name"
        DGVCART.Columns(2).Width = 200
        DGVCART.Columns(2).HeaderText = "Product Brand"
        DGVCART.Columns(3).Width = 200
        DGVCART.Columns(3).HeaderText = "Category Name"
        DGVCART.Columns(4).Width = 200
        DGVCART.Columns(4).HeaderText = "Category Code"
        DGVCART.Columns(5).Width = 200
        DGVCART.Columns(5).HeaderText = "Price"
        DGVCART.Columns(6).Width = 200
        DGVCART.Columns(6).HeaderText = "Unit"
        DGVCART.Columns(7).Width = 200
        DGVCART.Columns(7).HeaderText = "Quantity"
        DGVCART.Columns(8).Width = 200
        DGVCART.Columns(8).HeaderText = "Transaction Date"
        DGVCART.Columns(9).Width = 200
        DGVCART.Columns(9).HeaderText = "Return Date"


    End Sub

    Private Sub SelectedColumnsDisplayInGridView_Load(sender As Object, e As Object) Handles MyBase.Load

        ' ------------------------------------------------ DISPLAYING HEADER TO DATAGRID --------------------------------------------------------------


        showproducts()
        showcart()


    End Sub

    Private Sub showproducts()


        '- DISPLAYING DATA FROM TBL_PRODUCTS TO DATAGRID
        '- FOR REFRESHING DATA FROM DATAGRID
        '- DISPLAYING THE HEADER NAMES


        Try

            Dim da As New MySqlDataAdapter("select prodid, prodname, prodbrand, prodcat, catcode, price, unit, quantity from tbl_stocks", con)
            Dim dt As New DataSet()
            da.Fill(dt)
            Me.DGVPRODUCTS.DataSource = dt.Tables(0).DefaultView
            DGVSETPROPERTYPROD()
        Catch ex As Exception

            MessageBox.Show(ex.ToString())



        End Try
    End Sub


    Private Sub showcart()

        '- DISPLAYING DATA FROM TBL_CART TO DATAGRID
        '- FOR REFRESHING DATA FROM DATAGRID
        '- DISPLAYING THE HEADER NAMES

        Try

            Dim da As New MySqlDataAdapter("select prodid, prodname, prodbrand, prodcat, catcode, price, unit, quantity, transdate, returndate  from tbl_cart ", con)
            Dim dt As New DataSet()
            da.Fill(dt)
            Me.DGVCART.DataSource = dt.Tables(0).DefaultView

            DGVSETPROPERTYCART()
        Catch ex As Exception

            MessageBox.Show(ex.ToString())



        End Try


    End Sub

    Private Sub remove()

        For i = 0 To DGVPRODUCTS.Rows.Count - 1

            If DGVPRODUCTS.Rows(i).Cells(5).Value Is Nothing OrElse
                        DGVPRODUCTS.Rows(i).Cells(5).Value.ToString.Trim = "" Then

                DGVPRODUCTS.Rows(i).Visible = False

            End If
        Next

    End Sub
    Private Sub BTNNEWTRANS_Click(sender As Object, e As EventArgs)
        DGVPRODUCTS.Enabled = True
    End Sub

    Private Sub BTNCART_Click(sender As Object, e As EventArgs) Handles BTNCART.Click



        ' ERROR TRAPPING FOR PRODUCTS

        If Me.TXTOR.Text = "" Then
            MessageBox.Show("Please input order No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        If TXTPRODID.Text = "" Then
            MessageBox.Show("Please choose a product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        '- ERROR TRAPPING FOR QUANTITY

        If Me.NumericUpDown1.Value = 0 Then
            MessageBox.Show("The Quantity is 0 ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Me.NumericUpDown1.Value > Me.DGVPRODUCTS.CurrentRow.Cells(7).Value Then
            MessageBox.Show("The Quantity you have Entered is beyond the Stocks Limit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Me.NumericUpDown1.Value > 0 Or Me.NumericUpDown1.Value <= Me.DGVPRODUCTS.CurrentRow.Cells(7).Value Then
        End If









        BTNPAY.Visible = True

        Dim QuantityUpdate As Integer
        QuantityUpdate = Val(TXTPRC.Text) * Val(NumericUpDown1.Text)


        ' - ERROR TRAPPING FOR SAME PRODUCTS ON CART


        If TXTPRODID.Text <> TXTDUN.Text Then
            OpenCon()
            cmd.CommandText = "Select * from tbl_cart where prodid = '" & TXTPRODID.Text & "'"
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                MsgBox("Product is already on the cart! ", vbOKOnly + vbCritical, "Error Saving")
                con.Close()
                Exit Sub

            End If
            con.Close()
        End If


        ' - QUANTITY UPDATE TO PRDUCTS 


        ' Get the current row and the quantity to subtract
        Dim currentRow = DGVPRODUCTS.CurrentRow
        Dim quantityToSubtract = NumericUpDown1.Value

        ' Construct the SQL query using parameterized queries
        Dim sql = "UPDATE tbl_stocks SET quantity = quantity - @quantityToSubtract WHERE prodid = @prodId"

        ' Create the MySqlCommand and add the parameters
        Dim command As New MySqlCommand(sql, con)
        command.Parameters.AddWithValue("@quantityToSubtract", quantityToSubtract)
        command.Parameters.AddWithValue("@prodId", currentRow.Cells(0).Value)

        ' Open the connection, execute the command, and close the connection
        con.Open()
        command.ExecuteNonQuery()
        con.Close()

        ' Refresh the DataGridView to show the updated data
        showproducts()

        ' ---------------------------------------------------------------------------- SAVING CODE FOR TBL_CART ----------------------------------------------------



        con.Open()
        cmd.CommandText = "insert into tbl_cart (prodid, prodname, prodbrand, prodcat, catcode, price, unit, quantity, transdate ) values ( @pid, @pna, @pb, @pc, @cc, @pr, @un, @qt, @td)  "
        With cmd.Parameters

            .Clear()

            .AddWithValue("pid", TXTPRODID.Text)
            .AddWithValue("pna", TXTPRODNAME.Text)
            .AddWithValue("pb", TXTPRODBRAND.Text)
            .AddWithValue("pc", TXTPRODCAT.Text)
            .AddWithValue("cc", TXTCATCODE.Text)
            .AddWithValue("pr", QuantityUpdate)
            .AddWithValue("un", TXTUNIT.Text)
            .AddWithValue("qt", NumericUpDown1.Text)
            .AddWithValue("td", Format(Date.Now, "yyyy-mm-dd"))

        End With
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("New order has been added!", vbOKOnly + vbInformation, "adding Successful")
        TXTPRODID.Text = ""
        TXTPRODNAME.Text = ""
        TXTPRODBRAND.Text = ""
        TXTPRODCAT.Text = ""
        TXTCATCODE.Text = ""
        TXTPRC.Text = ""
        TXTUNIT.Text = ""
        TXTQTY.Text = ""
        NumericUpDown1.Text = ""

        showproducts()
        showcart()

        Dim dba1 As New MySqlDataAdapter("SELECT SUM(Price) FROM tbl_cart", con)
        Dim dbset1 As New DataSet
        dba1.Fill(dbset1)
        Me.TXTBILL.Text = dbset1.Tables(0).DefaultView.Item(0).Item(0)

    End Sub

    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click




        If Val(TXTBILL.Text) <= Val(TXTPAYMENT.Text) Then
            MessageBox.Show("The Payment is Insufficient", "Insufficient Payment", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If CBODISCOUNT.Text = "-- Select --" Then
            MessageBox.Show("Please select Discount Type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If MessageBox.Show("Finalize Ordering", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub
        End If

        If MessageBox.Show("Do you want receipt to print?", "Print Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            changelongpaper()
            PPD.Document = PD
            PPD.ShowDialog()

            activity = "Save purchase order. Order No:" + TXTOR.Text
            actlog()

            Dim x As Integer
            For x = 0 To DGVCART.Rows.Count - 1

                con.Open()
                cmd.CommandText = "insert into tbl_transaction values (NULL, @or, @dt, @pi, @pn, @pb, @cn, @cc, @un, @qt, @pm, @tb, @ch, @da, @td, @rd)"



                Console.WriteLine(TRANSADATE.Value)
                With cmd.Parameters
                    .Clear()


                    .AddWithValue("or", TXTOR.Text)

                    .AddWithValue("dt", CBODISCOUNT.Text)

                    .AddWithValue("pi", DGVCART.Rows(x).Cells(0).Value.ToString)

                    .AddWithValue("pn", DGVCART.Rows(x).Cells(1).Value.ToString)

                    .AddWithValue("pb", DGVCART.Rows(x).Cells(2).Value.ToString)

                    .AddWithValue("cn", DGVCART.Rows(x).Cells(3).Value.ToString)

                    .AddWithValue("cc", DGVCART.Rows(x).Cells(4).Value.ToString)

                    .AddWithValue("un", DGVCART.Rows(x).Cells(6).Value.ToString)

                    .AddWithValue("qt", DGVCART.Rows(x).Cells(7).Value.ToString)

                    .AddWithValue("pm", TXTPAYMENT.Text)

                    .AddWithValue("tb", TOTALBILL.Text)

                    .AddWithValue("ch", TXTCHANGE.Text)

                    .AddWithValue("da", Convert.ToInt32(TXTDISCAMOUNT.Text))

                    .AddWithValue("td", TRANSADATE.Value)

                    .AddWithValue("rd", DGVCART.Rows(x).Cells(9).Value.ToString)


                End With
                cmd.ExecuteNonQuery()
                con.Close()

                MessageBox.Show("Thank you Very Much", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Dim insrtslecmd As New MySqlCommand("INSERT INTO tbl_sales (orderno, transadate, discounttype, totalbill, payment, totalchange) VALUES (" & Me.TXTOR.Text & ",'" & Me.lbldate.Text & "', '" & Me.CBODISCOUNT.Text & "', '" & Me.TXTBILL.Text & "', '" & Me.TXTPAYMENT.Text & "', '" & Me.TXTCHANGE.Text & "')", con)
                con.Open()
                insrtslecmd.ExecuteNonQuery()
                con.Close()


            Next
        End If
        Dim dlcmd As New MySqlCommand("DELETE FROM tbl_cart", con)
        con.Open()
        dlcmd.ExecuteNonQuery()
        con.Close()
        showcart()

        TXTBILL.Text = 0
        TXTCHANGE.Text = 0
        TXTPAYMENT.Text = 0
        TXTDISCAMOUNT.Text = 0
        CBODISCOUNT.Text = "-- Select --"
        TXTOR.Text = ""
        pnlpayment.Visible = False
        BTNPAY.Visible = False

        pnlpayment.Visible = False
    End Sub

    Private Sub TXTBILL_TextChanged(sender As Object, e As EventArgs) Handles TXTBILL.TextChanged
        TXTPAYMENT.Enabled = True
    End Sub

    Private Sub CBODISCOUNT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBODISCOUNT.SelectedIndexChanged

        If CBODISCOUNT.SelectedItem = "Senior Citizen" Or CBODISCOUNT.SelectedItem = "PWD" Then
            Discount = 0.2 * Val(TXTBILL.Text)
            Discounted = Convert.ToInt32(TXTBILL.Text) - Discount
            TXTDISCAMOUNT.Text = Convert.ToString(Discounted)
            TOTALBILL.Text = TXTDISCAMOUNT.Text
            TXTPAYMENT.Text = 0


        ElseIf CBODISCOUNT.SelectedItem = "N/A" Then
            TXTPAYMENT.Text = 0
            TXTDISCAMOUNT.Text = 0
            TOTALBILL.Text = TXTBILL.Text
        End If

    End Sub

    Private Sub TXTPAYMENT_TextChanged(sender As Object, e As EventArgs) Handles TXTPAYMENT.TextChanged


        If CBODISCOUNT.SelectedItem = "Senior Citizen" Or CBODISCOUNT.SelectedItem = "PWD" Then
            If Val(TXTPAYMENT.Text) < Val(TXTDISCAMOUNT.Text) Then

                TXTCHANGE.Text = 0
            Else
                TXTCHANGE.Text = Val(TXTPAYMENT.Text) - Val(TXTDISCAMOUNT.Text)
            End If
        ElseIf CBODISCOUNT.SelectedItem = "N/A" Then
            If Val(TXTPAYMENT.Text) < Val(TXTBILL.Text) Then

                TXTCHANGE.Text = 0
            Else
                If CBODISCOUNT.SelectedItem = "N/A" Then
                    TXTCHANGE.Text = Val(TXTPAYMENT.Text) - Val(TXTBILL.Text)
                End If

                If CBODISCOUNT.SelectedItem = "Senior Citizen" Or CBODISCOUNT.SelectedItem = "PWD" Then
                    TXTCHANGE.Text = Val(TXTPAYMENT.Text) - Val(TXTDISCAMOUNT.Text)

                End If
            End If
        End If


    End Sub

    Private Sub DGVPRODUCTS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPRODUCTS.CellClick
        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow
            row = DGVPRODUCTS.Rows(e.RowIndex)


            TXTPRODID.Text = row.Cells(0).Value
            TXTPRODNAME.Text = row.Cells(1).Value
            TXTPRODBRAND.Text = row.Cells(2).Value
            TXTPRODCAT.Text = row.Cells(3).Value
            TXTCATCODE.Text = row.Cells(4).Value
            TXTPRC.Text = row.Cells(5).Value
            TXTUNIT.Text = row.Cells(6).Value
            TXTQTY.Text = row.Cells(7).Value

        End If
    End Sub

    Private Sub BTNDELETE_Click_1(sender As Object, e As EventArgs) Handles BTNDELETE.Click
        If MessageBox.Show("Are you sure to remove this product from the cart?t", "Remove from the cart.", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub
        End If

        ' Get the selected row in the cart DataGridView
        Dim cartRow = DGVCART.CurrentRow

        ' Construct the SQL query using parameterized queries
        Dim sql = "UPDATE tbl_stocks SET Quantity = Quantity + @quantityToAdd WHERE prodid = @prodId"

        ' Loop through each row in the products DataGridView
        For Each productRow As DataGridViewRow In DGVPRODUCTS.Rows
            ' Get the product ID and quantity from the current row
            Dim prodId = productRow.Cells(0).Value
            Dim quantity = productRow.Cells(7).Value

            ' Calculate the new quantity by adding the quantity in the cart row
            Dim newQuantity = quantity + cartRow.Cells(7).Value

            ' Create the MySqlCommand and add the parameters
            Dim command As New MySqlCommand(sql, con)
            command.Parameters.AddWithValue("@quantityToAdd", cartRow.Cells(7).Value)
            command.Parameters.AddWithValue("@prodId", prodId)

            ' Open the connection, execute the command, and close the connection
            con.Open()
            command.ExecuteNonQuery()
            con.Close()
        Next

        ' Refresh the DataGridViews to show the updated data
        showproducts()
        showcart()

        For i As Integer = 0 To DGVCART.SelectedRows.Count - 1
            Dim cmd As New MySqlCommand("delete from tbl_cart where prodid = @pi ", con)
            cmd.Parameters.AddWithValue("pi", DGVCART.SelectedRows(i).Cells(0).Value.ToString())
            con.Open()
            cmd.ExecuteNonQuery()
            TXTBILL.Text = ""
            TXTDISCAMOUNT.Text = ""
            Me.NumericUpDown1.Value = 0
            con.Close()
        Next
        showcart()
        showproducts()
        MessageBox.Show("Successfully removed from the cart.")

        If Me.DGVPRODUCTS.RowCount = 0 Then
            TXTBILL.Text = 0
            Me.BTNDELETE.Visible = False
            Exit Sub

        End If
        If Me.DGVPRODUCTS.RowCount > 0 Then

        End If

        Exit Sub

    End Sub

    Private Sub BTNPAY_Click(sender As Object, e As EventArgs) Handles BTNPAY.Click
        If CBODISCOUNT.SelectedItem = "Senior Citizen" Or CBODISCOUNT.SelectedItem = "PWD" Then
            Discount = 0.2 * Val(TXTBILL.Text)
            Discounted = Convert.ToInt32(TXTBILL.Text) - Discount
            TOTALBILL.Text = Convert.ToString(Discounted)
            TXTPAYMENT.Text = 0


        ElseIf CBODISCOUNT.SelectedItem = "N/A" Then
            TXTPAYMENT.Text = 0
            TXTDISCAMOUNT.Text = 0
            TOTALBILL.Text = TXTBILL.Text
        End If

        pnlpayment.Visible = True
    End Sub

    Private Sub TRANSADATE_FormatChanged(sender As Object, e As EventArgs) Handles TRANSADATE.FormatChanged

        Format("yyyy-mm-dd")
        'Format(TRANSADATE.Value, "yyyy-mm-dd")
    End Sub
    Private Sub TXTPRICE_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        search()
    End Sub
    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    changelongpaper()
    '    PPD.Document = PD
    '    PPD.ShowDialog()
    'End Sub

    Private Sub TXTUNIT_TextChanged(sender As Object, e As EventArgs) Handles TXTUNIT.TextChanged

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If TXTUNIT.Text = "Pack/s" Then NumericUpDown1.Value = 10
    End Sub
End Class
