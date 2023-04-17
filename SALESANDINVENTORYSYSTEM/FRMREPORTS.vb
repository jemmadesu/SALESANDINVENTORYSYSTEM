Imports MySql.Data.MySqlClient
Public Class FRMREPORTS
    Private Sub FRMREPORTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'inventory_dbDataSet.tbl_actlog' table. You can move, or remove it, as needed.
        Me.RPTACTLOG.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_actlogTableAdapter.Fill(Me.inventory_dbDataSet.tbl_actlog)

        Me.RPTACTLOG.RefreshReport()
        '-------------------------------------- SUPPLIER ---------------------
        'TODO: This line of code loads data into the 'inventory_dbDataSet.tbl_supplier' table. You can move, or remove it, as needed.
        Me.RPTSUP.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_supplierTableAdapter.Fill(Me.inventory_dbDataSet.tbl_supplier)

        Me.RPTSUP.RefreshReport()
        '----------------------------------- SALES -----------------------------
        'TODO: This line of code loads data into the 'inventory_dbDataSet.tbl_sales' table. You can move, or remove it, as needed.
        Me.RPTSALES.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_salesTableAdapter.Fill(Me.inventory_dbDataSet.tbl_sales)


        Me.RPTSALES.RefreshReport()
        '------------------------------------- OUT OF STOCKS -------------------------
        'TODO: This line of code loads data into the 'inventory_dbDataSet.tbl_stocksout' table. You can move, or remove it, as needed.
        Me.RPTOUTOFSTOCKS.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_stocksoutTableAdapter.Fill(Me.inventory_dbDataSet.tbl_stocksout)

        Me.RPTOUTOFSTOCKS.RefreshReport()

        '--------------------------------- EXPIRED PRODUCTS ------------
        'TODO: This line of code loads data into the 'inventory_dbDataSet.tbl_expiredprod' table. You can move, or remove it, as needed.
        Me.RPTEXP.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_expiredprodTableAdapter.Fill(Me.inventory_dbDataSet.tbl_expiredprod)

        Me.RPTEXP.RefreshReport()
        '------------------------- PRODUCTS ---------------------
        'TODO: This line of code loads data into the 'inventory_dbDataSet.tbl_products' table. You can move, or remove it, as needed.
        Me.RPTPRODUCTS.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_productsTableAdapter.Fill(Me.inventory_dbDataSet.tbl_products)

        Me.RPTPRODUCTS.RefreshReport()
        '---------------------------- USERS --------------------------------
        'TODO: This line of code loads data into the 'inventory_dbDataSet.tbl_users' table. You can move, or remove it, as needed.
        Me.RPTUSERS.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.tbl_usersTableAdapter.Fill(Me.inventory_dbDataSet.tbl_users)

        Me.RPTUSERS.RefreshReport()


    End Sub
    Private Sub BTNFILTER_Click(sender As Object, e As EventArgs) Handles BTNFILTER.Click
        Me.tbl_usersTableAdapter.FillByusertype(Me.inventory_dbDataSet.tbl_users, CBOUT.Text)

        Me.RPTUSERS.RefreshReport()
    End Sub

    Private Sub clear()
        Me.tbl_usersTableAdapter.Fill(Me.inventory_dbDataSet.tbl_users)

        Me.RPTUSERS.RefreshReport()
    End Sub

    Private Sub BTNCLEAR_Click(sender As Object, e As EventArgs) Handles BTNCLEAR.Click
        clear()
    End Sub
    Private Sub BTNFILL_Click(sender As Object, e As EventArgs) Handles BTNFILL.Click
        Me.tbl_productsTableAdapter.FillByDate(Me.inventory_dbDataSet.tbl_products, Date1.Value.ToShortDateString, Date2.Value.ToShortDateString)

        Me.RPTPRODUCTS.RefreshReport()
    End Sub

    Private Sub BTNCLRDATE_Click(sender As Object, e As EventArgs) Handles BTNCLRDATE.Click
        Me.tbl_productsTableAdapter.Fill(Me.inventory_dbDataSet.tbl_products)

        Me.RPTPRODUCTS.RefreshReport()
    End Sub

    Private Sub EXPFILL_Click(sender As Object, e As EventArgs) Handles EXPFILL.Click
        Me.tbl_expiredprodTableAdapter.FillByEXP(Me.inventory_dbDataSet.tbl_expiredprod, Date1EXP.Value.ToShortDateString, DAte2EXP.Value.ToShortDateString)

        Me.RPTEXP.RefreshReport()
    End Sub

    Private Sub EXPCLR_Click(sender As Object, e As EventArgs) Handles EXPCLR.Click
        Me.tbl_expiredprodTableAdapter.Fill(Me.inventory_dbDataSet.tbl_expiredprod)

        Me.RPTEXP.RefreshReport()
    End Sub

    Private Sub OUTFILL_Click(sender As Object, e As EventArgs) Handles OUTFILL.Click
        Me.tbl_stocksoutTableAdapter.FillByOUT(Me.inventory_dbDataSet.tbl_stocksout, Date1OUT.Value.ToShortDateString, Date2OUT.Value.ToShortDateString)

        Me.RPTOUTOFSTOCKS.RefreshReport()
    End Sub

    Private Sub OUTCLR_Click(sender As Object, e As EventArgs) Handles OUTCLR.Click
        Me.tbl_stocksoutTableAdapter.Fill(Me.inventory_dbDataSet.tbl_stocksout)

        Me.RPTOUTOFSTOCKS.RefreshReport()
    End Sub

    Private Sub SALESFILL_Click(sender As Object, e As EventArgs) Handles SALESFILL.Click
        Me.tbl_salesTableAdapter.FillBySALES(Me.inventory_dbDataSet.tbl_sales, Date1SALES.Value.ToShortDateString, Date2SALES.Value.ToShortDateString)

        Me.RPTSALES.RefreshReport()
    End Sub

    Private Sub SALESCLR_Click(sender As Object, e As EventArgs) Handles SALESCLR.Click
        Me.tbl_salesTableAdapter.Fill(Me.inventory_dbDataSet.tbl_sales)


        Me.RPTSALES.RefreshReport()
    End Sub
    Private Sub ACTFILL_Click(sender As Object, e As EventArgs) Handles ACTFILL.Click
        Me.tbl_actlogTableAdapter.FillByACT(Me.inventory_dbDataSet.tbl_actlog, CBOTYPE.Text)

        Me.RPTACTLOG.RefreshReport()
    End Sub
    Private Sub ACTCLR_Click(sender As Object, e As EventArgs) Handles ACTCLR.Click
        Me.tbl_actlogTableAdapter.Fill(Me.inventory_dbDataSet.tbl_actlog)

        Me.RPTACTLOG.RefreshReport()
    End Sub

    Private Sub BTNCLOSE_Click(sender As Object, e As EventArgs) Handles BTNCLOSE.Click
        Me.Close()
    End Sub
End Class