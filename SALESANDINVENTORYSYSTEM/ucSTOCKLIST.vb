Imports MySql.Data.MySqlClient
Public Class ucSTOCKLIST
    Private Sub ucSTOCKLIST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOADDATAMAIN()
    End Sub

    Private Sub search()
        Dim dba As New MySqlDataAdapter("select stockid, prodname, unit, price, quantity, prodman, expirationdate from tbl_products WHERE tbl_products.prodname LIKE '%" & Me.TXTSEARCH.Text & "%';", con)
        Dim dbset As New DataSet
        dba.Fill(dbset)
        Me.DGVSTOCK.DataSource = dbset.Tables(0).DefaultView
    End Sub
    Private Sub DGVMAINSET()
        DGVSTOCK.Columns(0).Width = 200
        DGVSTOCK.Columns(0).HeaderText = "Stock ID"
        DGVSTOCK.Columns(1).Width = 200
        DGVSTOCK.Columns(1).HeaderText = "Product ID"
        DGVSTOCK.Columns(2).Width = 200
        DGVSTOCK.Columns(2).HeaderText = "Product Name"
        DGVSTOCK.Columns(3).Width = 200
        DGVSTOCK.Columns(3).HeaderText = "Product Manufacturer"
        DGVSTOCK.Columns(4).Width = 200
        DGVSTOCK.Columns(4).HeaderText = "Product Brand"
        DGVSTOCK.Columns(5).Width = 200
        DGVSTOCK.Columns(5).HeaderText = "Category Name"
        DGVSTOCK.Columns(6).Width = 200
        DGVSTOCK.Columns(6).HeaderText = "Category Code"
        DGVSTOCK.Columns(7).Width = 200
        DGVSTOCK.Columns(7).HeaderText = "Price"
        DGVSTOCK.Columns(8).Width = 200
        DGVSTOCK.Columns(8).HeaderText = "Unit"
        DGVSTOCK.Columns(9).Width = 200
        DGVSTOCK.Columns(9).HeaderText = "Stocks"
        DGVSTOCK.Columns(10).Width = 200
        DGVSTOCK.Columns(10).HeaderText = "Expiration Date"

    End Sub
    Private Sub LOADDATAMAIN()
        Try

            Dim da As New MySqlDataAdapter("select stockid, prodid, prodname, prodman, prodbrand, prodcat, catcode, price, unit, quantity, expirationdate from tbl_products ", con)
            Dim dt As New DataSet()
            da.Fill(dt)
            DGVSTOCK.DataSource = dt.Tables(0)

            DGVMAINSET()
        Catch ex As Exception

            MessageBox.Show(ex.ToString())



        End Try

    End Sub

    Private Sub BTNBACK_Click(sender As Object, e As EventArgs) Handles BTNBACK.Click
        Dim i As Integer
        For i = 0 To 0
            FRMMAINMENU.PNLMAIN.Controls.RemoveAt(i)
        Next

        Dim INVETORY As New ucPRODUCTLIST()
        INVETORY.Parent = FRMMAINMENU.PNLMAIN
        INVETORY.Show()
        INVETORY.Dock = DockStyle.Fill
    End Sub

    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        search()
    End Sub
End Class
