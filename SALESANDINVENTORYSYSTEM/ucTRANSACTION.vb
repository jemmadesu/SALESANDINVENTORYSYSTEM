
Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient


Public Class ucTRANSACTION
    Dim connection As MySqlConnection
    Dim command As MySqlCommand

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer

    Private Sub setsum()
        DGVSUMMARY.Columns(0).Width = 270
        DGVSUMMARY.Columns(0).HeaderText = "Products"
        DGVSUMMARY.Columns(1).Width = 100
        DGVSUMMARY.Columns(1).HeaderText = "Qty"
    End Sub
    Private Sub SUMMARY()
        Try

            Dim da As New MySqlDataAdapter("select prodname, quantity  from tbl_cart ", con)
            Dim dt As New DataSet()
            da.Fill(dt)
            Me.DGVSUMMARY.DataSource = dt.Tables(0).DefaultView

            setsum()
        Catch ex As Exception

            MessageBox.Show(ex.ToString())

        End Try
    End Sub
    Private Sub ucTRANSACTION_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'FIFO


        DGVSUMMARY.EnableHeadersVisualStyles = False


        ' Set the header cell backcolor
        DGVSUMMARY.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(191, 205, 219)


        ' Set the header cell forecolor
        DGVSUMMARY.ColumnHeadersDefaultCellStyle.ForeColor = Color.DimGray




        ' Disable the default column header cell selection
        DGVSUMMARY.SelectionMode = DataGridViewSelectionMode.CellSelect
        DGVSUMMARY.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 205, 219)
        DGVSUMMARY.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(104, 104, 104)


        lblun.Text = FRMMAINMENU.LBLUSERNAME.Text
        lblut.Text = FRMMAINMENU.LBLUSERTYPE.Text

        SUMMARY()

        con.Close()


        '------------------------------------------

        lbldate.Text = Format(Date.Now, "yyyy-MM-dd")


        showproducts()
        showcart()
        'remove()

    End Sub

    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = DGVCART.Rows.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 700

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
        Dim f10 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 8, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 8, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String

        line = "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -"


        e.Graphics.DrawString("RIZAl PROVINCIAL HOSP", f10b, Brushes.BlueViolet, centermargin, 5, center)
        e.Graphics.DrawString("EMPLOYEES MULTI PURPOSE COOP", f10b, Brushes.BlueViolet, centermargin, 20, center)
        e.Graphics.DrawString("Owned and Operated by : ", f8, Brushes.BlueViolet, centermargin, 35, center)
        e.Graphics.DrawString("RIZAL PROVINCIAL HOSP", f8, Brushes.BlueViolet, centermargin, 50, center)
        e.Graphics.DrawString("EMPLOYEES MULTI PURPOSE COOP", f8, Brushes.BlueViolet, centermargin, 65, center)
        e.Graphics.DrawString("Tomas Claudio St. San Juan Morong, Rizal", f8, Brushes.BlueViolet, centermargin, 80, center)



        e.Graphics.DrawString("Invoice No.: " + TXTOR.Text.ToString, f8, Brushes.BlueViolet, 0, 120)
        e.Graphics.DrawString("Cashier: " + FRMMAINMENU.LBLNAME.Text.ToString, f8, Brushes.BlueViolet, 0, 135)
        e.Graphics.DrawString("Date: " & Date.Now(), f8, Brushes.BlueViolet, 0, 150)


        Dim height As Integer
        Dim i As Long

        DGVCART.AllowUserToAddRows = False

        For row As Integer = 0 To DGVCART.RowCount - 1
            height += 15
            e.Graphics.DrawString(line, f8, Brushes.BlueViolet, 0, 170)


            e.Graphics.DrawString("X" + DGVCART.Rows(row).Cells(7).Value.ToString, f10, Brushes.BlueViolet, 0, 170 + height)
            e.Graphics.DrawString(DGVCART.Rows(row).Cells(1).Value.ToString, f10, Brushes.BlueViolet, 40, 170 + height)
            e.Graphics.DrawString(DGVCART.Rows(row).Cells(5).Value.ToString, f10, Brushes.BlueViolet, 220, 170 + height)


        Next
        Dim height2 As Integer
        height2 = 110 + height

        sumprice()
        e.Graphics.DrawString(line, f8, Brushes.BlueViolet, 0, 70 + height2)
        e.Graphics.DrawString("No. of items: " & t_qty, f10b, Brushes.BlueViolet, 0, 80 + height2)
        e.Graphics.DrawString("Total: " & Format(t_price, "##,##0"), f10b, Brushes.BlueViolet, rightmargin, 80 + height2, right)


        e.Graphics.DrawString("Cash: " + TXTPAYMENT.Text.ToString, f10b, Brushes.BlueViolet, 0, 110 + height2)
        e.Graphics.DrawString("Change: " + TXTCHANGE.Text.ToString, f10b, Brushes.BlueViolet, 0, 125 + height2)


        ' SALES DISCOUNT ----------------------------------------------------------------

        e.Graphics.DrawString(line, f8, Brushes.BlueViolet, 0, 135 + height2)

        e.Graphics.DrawString("Discount Type: " + CBODISCOUNT.Text.ToString, f10b, Brushes.BlueViolet, 0, 145 + height2)
        'e.Graphics.DrawString("Less (20%)" + CBODISCOUNT.Text.ToString, f10b, Brushes.BlueViolet, 0, 135 + height2)

        e.Graphics.DrawString("Discount Type: " + CBODISCOUNT.Text.ToString, f10b, Brushes.BlueViolet, 0, 145 + height2)
        e.Graphics.DrawString("Discount Amount: " + TXTDISCAMOUNT.Text.ToString, f10b, Brushes.BlueViolet, 0, 160 + height2)
        e.Graphics.DrawString(TXTNAME.Text.ToString, f10b, Brushes.BlueViolet, 0, 175 + height2)
        e.Graphics.DrawString(TXTID.Text.ToString, f10b, Brushes.BlueViolet, 0, 190 + height2)

        ' VAT -------------------------------------------------------

        e.Graphics.DrawString("VATable", f8, Brushes.BlueViolet, 0, 205 + height2)
        e.Graphics.DrawString("0.00", f8, Brushes.BlueViolet, 220, 205 + height2)

        e.Graphics.DrawString("VAT-Except Sale", f8, Brushes.BlueViolet, 0, 220 + height2)
        e.Graphics.DrawString("0.00", f8, Brushes.BlueViolet, 220, 220 + height2)

        e.Graphics.DrawString("VAT-Zero Rate Sale", f8, Brushes.BlueViolet, 0, 235 + height2)
        e.Graphics.DrawString("0.00", f8, Brushes.BlueViolet, 220, 235 + height2)

        e.Graphics.DrawString("VAT 12%", f8, Brushes.BlueViolet, 0, 250 + height2)
        e.Graphics.DrawString("0.00", f8, Brushes.BlueViolet, 220, 250 + height2)


        ' OTHER DETAILS --------------------------------------------------

        e.Graphics.DrawString("- - - - - SIS Accredited Supplier - - - - -", f8, Brushes.BlueViolet, centermargin, 290 + height2, center)
        e.Graphics.DrawString("UNIVERSITY OF RIZAL SYSTEM", f8, Brushes.BlueViolet, centermargin, 305 + height2, center)
        e.Graphics.DrawString("BINANGONAN CAMPUS", f8, Brushes.BlueViolet, centermargin, 320 + height2, center)
        e.Graphics.DrawString("F5MQ+62W, Manila E Rd, Binangonan, 1940 Rizal", f8, Brushes.BlueViolet, centermargin, 335 + height2, center)
        e.Graphics.DrawString("TIN: 005-037-570-000", f8, Brushes.BlueViolet, centermargin, 350 + height2, center)
        e.Graphics.DrawString("BIR Accre. #048005037570000011491", f8, Brushes.BlueViolet, centermargin, 365 + height2, center)
        e.Graphics.DrawString("Date Issued: " & Format(Date.Now, "MM/yyyy/dd"), f8, Brushes.BlueViolet, centermargin, 380 + height2, center)
        Dim validUntil As DateTime = Date.Now.AddYears(5)
        e.Graphics.DrawString("Valid Until: " & validUntil.ToString("MM/yyyy/dd"), f8, Brushes.BlueViolet, centermargin, 395 + height2, center)
        e.Graphics.DrawString("PTU # FP072015046004034600000", f8, Brushes.BlueViolet, centermargin, 410 + height2, center)
        e.Graphics.DrawString("Date Issued: " & Format(Date.Now, "MM/yyyy/dd"), f8, Brushes.BlueViolet, centermargin, 425 + height2, center)
        Dim validUntil2 As DateTime = Date.Now.AddYears(5)
        e.Graphics.DrawString("Valid Until: " & validUntil2.ToString("MM/yyyy/dd"), f8, Brushes.BlueViolet, centermargin, 440 + height2, center)
        e.Graphics.DrawString("THIS INVOICE RECEIPT SHALL BE", f8, Brushes.BlueViolet, centermargin, 455 + height2, center)
        e.Graphics.DrawString("VALID FOR FIVE (5) YEARS", f8, Brushes.BlueViolet, centermargin, 470 + height2, center)
        e.Graphics.DrawString("FROM THE DATE OF THE PERMIT TO USE ", f8, Brushes.BlueViolet, centermargin, 485 + height2, center)
        e.Graphics.DrawString("THIS DOCUMENT IS NOT VALID FOR", f8, Brushes.BlueViolet, centermargin, 500 + height2, center)
        e.Graphics.DrawString("CLAIM OF INPUT TAX", f8, Brushes.BlueViolet, centermargin, 515 + height2, center)


        e.Graphics.DrawString("Thanks for purchasing”, f8, Brushes.BlueViolet, centermargin, 545 + height2, center)
        e.Graphics.DrawString("This serves as your official receipt", f8, Brushes.BlueViolet, centermargin, 560 + height2, center)



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
        DGVPRODUCTS.Columns(0).HeaderText = "Product Code"
        DGVPRODUCTS.Columns(1).Width = 200
        DGVPRODUCTS.Columns(1).HeaderText = "Product Name"
        DGVPRODUCTS.Columns(2).Width = 200
        DGVPRODUCTS.Columns(2).HeaderText = "Product Brand"
        DGVPRODUCTS.Columns(3).Width = 200
        DGVPRODUCTS.Columns(3).HeaderText = "Category"
        DGVPRODUCTS.Columns(4).Width = 200
        DGVPRODUCTS.Columns(4).HeaderText = "Category Code"
        DGVPRODUCTS.Columns(5).Width = 200
        DGVPRODUCTS.Columns(5).HeaderText = "Price"
        DGVPRODUCTS.Columns(6).Width = 200
        DGVPRODUCTS.Columns(6).HeaderText = "Unit"
        DGVPRODUCTS.Columns(7).Width = 200
        DGVPRODUCTS.Columns(7).HeaderText = "Stocks"
        DGVPRODUCTS.Columns(8).Width = 200
        DGVPRODUCTS.Columns(8).HeaderText = "Date Added"
        DGVPRODUCTS.Columns(9).Width = 300
        DGVPRODUCTS.Columns(9).HeaderText = "Days ago after added"


    End Sub

    Private Sub DGVSETPROPERTYCART()


        '--------------------------------------------------------------- CODE FOR COLUMN HEADER NAME (CART) -----------------------------------------
        DGVCART.Columns(0).Width = 200
        DGVCART.Columns(0).HeaderText = "Product Code"
        DGVCART.Columns(1).Width = 200
        DGVCART.Columns(1).HeaderText = "Product Name"
        DGVCART.Columns(2).Width = 200
        DGVCART.Columns(2).HeaderText = "Product Brand"
        DGVCART.Columns(3).Width = 200
        DGVCART.Columns(3).HeaderText = "Category"
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

        Dim dataset As New DataTable
        Dim bindindsrc As New BindingSource
        Dim dataadapt As New MySqlDataAdapter

        Try
            con.Open()
            command = New MySqlCommand("SELECT prodcode, prodname, brand, category, catcode, price, unit, quantity, dateaddedstocks, CONCAT('added ', DATEDIFF(dateaddedstocks, NOW()), ' days ago') AS Remaining_Days FROM tbl_stocks", con)

            dataadapt.SelectCommand = command
            dataadapt.Fill(dataset)

            bindindsrc.DataSource = dataset

            DGVPRODUCTS.DataSource = bindindsrc
            dataadapt.Update(dataset)
            con.Close()

            DGVSETPROPERTYPROD()
        Catch ex As Exception

        Finally
            con.Dispose()

        End Try



    End Sub


    Private Sub showcart()

        '- DISPLAYING DATA FROM TBL_CART TO DATAGRID
        '- FOR REFRESHING DATA FROM DATAGRID
        '- DISPLAYING THE HEADER NAMES

        Try

            Dim da As New MySqlDataAdapter("select prodcode, prodname, brand, category, catcode, price, unit, quantity, transdate, returndate  from tbl_cart ", con)
            Dim dt As New DataSet()
            da.Fill(dt)
            Me.DGVCART.DataSource = dt.Tables(0).DefaultView

            DGVSETPROPERTYCART()
        Catch ex As Exception

            MessageBox.Show(ex.ToString())



        End Try


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
            MessageBox.Show("The quantity you have entered is beyond the stocks limit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
            cmd.CommandText = "Select * from tbl_cart where prodcode = '" & TXTPRODID.Text & "'"
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
        Dim sql = "UPDATE tbl_stocks SET quantity = quantity - @quantityToSubtract WHERE prodcode = @prodcode"

        ' Create the MySqlCommand and add the parameters
        Dim command As New MySqlCommand(sql, con)
        command.Parameters.AddWithValue("@quantityToSubtract", quantityToSubtract)
        command.Parameters.AddWithValue("@prodcode", currentRow.Cells(0).Value)

        ' Open the connection, execute the command, and close the connection
        con.Open()
        command.ExecuteNonQuery()
        con.Close()

        ' Refresh the DataGridView to show the updated data
        showproducts()
        SUMMARY()

        con.Open()
        cmd.CommandText = "insert into tbl_cart (prodcode, prodname, brand, category, catcode, price, unit, quantity, transdate ) values ( @pco, @pna, @br, @pc, @cc, @pr, @un, @qt, @td)  "
        With cmd.Parameters

            .Clear()

            .AddWithValue("pco", TXTPRODID.Text)
            .AddWithValue("pna", TXTPRODNAME.Text)
            .AddWithValue("br", TXTPRODBRAND.Text)
            .AddWithValue("pc", TXTPRODCAT.Text)
            .AddWithValue("cc", TXTCATCODE.Text)
            .AddWithValue("pr", QuantityUpdate)
            .AddWithValue("un", TXTUNIT.Text)
            .AddWithValue("qt", NumericUpDown1.Text)
            .AddWithValue("td", Format(Date.Now, "yyyy-mm-dd"))

        End With
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("New product order has been added!", vbOKOnly + vbInformation, "Added Successfully")
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
        SUMMARY()

        Dim dba1 As New MySqlDataAdapter("SELECT SUM(Price) FROM tbl_cart", con)
        Dim dbset1 As New DataSet
        dba1.Fill(dbset1)
        If dbset1.Tables(0).Rows.Count > 0 Then
            Dim sum As Object = dbset1.Tables(0).Rows(0)(0)
            If Not DBNull.Value.Equals(sum) Then
                Me.TXTBILL.Text = sum.ToString()
            Else
                Me.TXTBILL.Text = "N/A" ' or any default value if the sum is null
            End If
        Else
            Me.TXTBILL.Text = "N/A" ' or any default value if no rows were returned
        End If

        Console.Write(TXTBILL.Text)

    End Sub

    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click

        Dim payment As Double
        Dim total As Double

        If Double.TryParse(TXTPAYMENT.Text, payment) AndAlso Double.TryParse(TOTALBILL.Text, total) Then
            If payment < total Then

                Exit Sub
            End If
        Else
            ' Handle the case where the input values cannot be parsed as numbers
            MessageBox.Show("Invalid payment or total bill amount", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


        If CBODISCOUNT.Text = "-- Select --" Then
            MessageBox.Show("Please select Discount Type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If MessageBox.Show("Finalize Purchased Product", "Done order", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub
        End If

        If MessageBox.Show("Do you want to print receipt?", "Purchased Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            changelongpaper()
            PPD.Document = PD
            PPD.ShowDialog()


            activity = "Save purchase order. Order No:" + TXTOR.Text
            actlog()


            Dim x As Integer
            For x = 0 To DGVCART.Rows.Count - 1

                con.Open()
                cmd.CommandText = "insert into tbl_transaction values (NULL, @or, @ut, @una, @dt, @pc, @pn, @br, @cn, @cc, @un, @qt, @pm, @tb, @ch, @da, @td, @rd)"




                With cmd.Parameters
                    .Clear()


                    .AddWithValue("or", TXTOR.Text)

                    .AddWithValue("ut", lblut.Text)

                    .AddWithValue("una", lblun.Text)

                    .AddWithValue("dt", CBODISCOUNT.Text)

                    .AddWithValue("pc", DGVCART.Rows(x).Cells(0).Value.ToString)

                    .AddWithValue("pn", DGVCART.Rows(x).Cells(1).Value.ToString)

                    .AddWithValue("br", DGVCART.Rows(x).Cells(2).Value.ToString)

                    .AddWithValue("cn", DGVCART.Rows(x).Cells(3).Value.ToString)

                    .AddWithValue("cc", DGVCART.Rows(x).Cells(4).Value.ToString)

                    .AddWithValue("un", DGVCART.Rows(x).Cells(6).Value.ToString)

                    .AddWithValue("qt", DGVCART.Rows(x).Cells(7).Value.ToString)

                    .AddWithValue("pm", TXTPAYMENT.Text)

                    .AddWithValue("tb", TOTALBILL.Text)

                    .AddWithValue("ch", TXTCHANGE.Text)

                    .AddWithValue("da", TXTBILL.Text)

                    .AddWithValue("td", Format(Date.Now, "yyyy-MM-dd"))

                    .AddWithValue("rd", DGVCART.Rows(x).Cells(9).Value.ToString)


                End With
                cmd.ExecuteNonQuery()
                con.Close()



                Dim insrtslecmd As New MySqlCommand("INSERT INTO tbl_sales (orderno, transadate, discounttype, totalbill, payment, totalchange) VALUES (" & Me.TXTOR.Text & ",'" & Me.lbldate.Text & "', '" & Me.CBODISCOUNT.Text & "', '" & Me.TOTALBILL.Text & "', '" & Me.TXTPAYMENT.Text & "', '" & Me.TXTCHANGE.Text & "')", con)
                con.Open()
                insrtslecmd.ExecuteNonQuery()
                con.Close()

            Next
            MessageBox.Show("Order Transaction Done", "Thank you!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Dim dlcmd As New MySqlCommand("DELETE FROM tbl_cart", con)
        con.Open()
        dlcmd.ExecuteNonQuery()
        con.Close()
        showcart()
        SUMMARY()

        TXTBILL.Text = 0
        TXTCHANGE.Text = 0
        TXTPAYMENT.Text = 0
        TXTDISCAMOUNT.Text = 0
        TOTALAMOUNT.Text = "00,00"
        ORNO.Text = "000000"
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

            TOTALAMOUNT.Text = "₱" + TXTDISCAMOUNT.Text
            TXTPAYMENT.Text = 0


        ElseIf CBODISCOUNT.SelectedItem = "N/A" Then
            TXTPAYMENT.Text = 0
            TXTDISCAMOUNT.Text = 0


            TOTALBILL.Text = TXTBILL.Text
            TOTALAMOUNT.Text = "₱" + TXTBILL.Text
        End If

    End Sub

    Private Sub TXTPAYMENT_TextChanged(sender As Object, e As EventArgs) Handles TXTPAYMENT.TextChanged


        If CBODISCOUNT.SelectedItem = "Senior Citizen" Or CBODISCOUNT.SelectedItem = "PWD" Then
            If Val(TXTPAYMENT.Text) < Val(TXTDISCAMOUNT.Text) Then

                TXTCHANGE.Text = 0.00
            Else
                TXTCHANGE.Text = Val(TXTPAYMENT.Text) - Val(TXTDISCAMOUNT.Text)
            End If
        ElseIf CBODISCOUNT.SelectedItem = "N/A" Then
            If Val(TXTPAYMENT.Text) < Val(TXTBILL.Text) Then

                TXTCHANGE.Text = 0.00
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

        For Each productRow As DataGridViewRow In DGVPRODUCTS.Rows
            ' Get the product ID and quantity from the current row
            Dim prodcode = productRow.Cells(0).Value
            Dim quantity = productRow.Cells(7).Value

            ' Calculate the new quantity by adding the quantity in the cart rows
            For Each cartRow As DataGridViewRow In DGVCART.Rows
                If cartRow.Cells(0).Value = prodcode Then
                    quantity += cartRow.Cells(7).Value
                End If
            Next

            ' Construct the SQL query using parameterized queries
            Dim sql = "UPDATE tbl_stocks SET Quantity = @newQuantity WHERE prodcode = @prodcode"
            Dim command As New MySqlCommand(sql, con)
            command.Parameters.AddWithValue("@newQuantity", quantity)
            command.Parameters.AddWithValue("@prodcode", prodcode)

            ' Open the connection, execute the command, and close the connection
            con.Open()
            command.ExecuteNonQuery()
            con.Close()
        Next

        ' Refresh the DataGridViews to show the updated data
        showproducts()
        showcart()

        For i As Integer = 0 To DGVCART.SelectedRows.Count - 1
            Dim cmd As New MySqlCommand("delete from tbl_cart where prodcode = @pc ", con)
            cmd.Parameters.AddWithValue("pc", DGVCART.SelectedRows(i).Cells(0).Value.ToString())
            con.Open()
            cmd.ExecuteNonQuery()
            TXTBILL.Text = ""
            TXTDISCAMOUNT.Text = ""
            Me.NumericUpDown1.Value = 0
            con.Close()
        Next
        showcart()
        SUMMARY()
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
            TOTALAMOUNT.Text = TXTBILL.Text
        End If


        pnlpayment.Visible = True
    End Sub

    Private Sub TRANSADATE_FormatChanged(sender As Object, e As EventArgs)

        Format("yyyy-mm-dd")
        'Format(TRANSADATE.Value, "yyyy-mm-dd")
    End Sub
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs)
        If TXTUNIT.Text = "Pack/s" Then NumericUpDown1.Value = 10
    End Sub
    Private Sub TXTOR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTOR.KeyPress


        ORNO.Text = TXTOR.Text



        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MsgBox("Letter or Special character is not allowed", vbCritical, "Notice")
        End If
        If TXTOR.Text.Length >= 6 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MsgBox("Number Exceed", vbCritical, "Notice")
            End If
        End If
    End Sub


    Private Sub DGVPRODUCTS_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGVPRODUCTS.CellFormatting

        If e.ColumnIndex = DGVPRODUCTS.Columns(9).Index AndAlso e.Value IsNot Nothing Then
            Dim cellValue As String = e.Value.ToString()
            e.Value = cellValue.Replace("-", "")
            e.FormattingApplied = True
        End If
    End Sub

    Private Sub Guna2GradientTileButton1_Click(sender As Object, e As EventArgs)
        changelongpaper()
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub
End Class
