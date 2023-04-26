Imports MySql.Data.MySqlClient
Public Class ucPRODUCTLIST

    Private Sub searchprod()
        Dim dba As New MySqlDataAdapter("select stockid, prodid, prodname, prodman, prodbrand, prodcat, catcode  from tbl_products  WHERE  tbl_products.stockid LIKE '%" & Me.TXTSEARCH.Text & "%' OR tbl_products.prodname LIKE '%" & Me.TXTSEARCH.Text & "%' OR tbl_products.prodid LIKE '%" & Me.TXTSEARCH.Text & "%'", con)
        Dim dbset As New DataSet
        dba.Fill(dbset)
        Me.DGVPRODLIST.DataSource = dbset.Tables(0).DefaultView
    End Sub
    Private Sub DGVSETPROPERTY()


        DGVPRODLIST.Columns(0).Width = 200
        DGVPRODLIST.Columns(0).HeaderText = "Stock ID"

        DGVPRODLIST.Columns(1).Width = 200
        DGVPRODLIST.Columns(1).HeaderText = "Product ID"

        DGVPRODLIST.Columns(2).Width = 200
        DGVPRODLIST.Columns(2).HeaderText = "Product Name"

        DGVPRODLIST.Columns(3).Width = 200
        DGVPRODLIST.Columns(3).HeaderText = "Product Manufacturer"

        DGVPRODLIST.Columns(4).Width = 200
        DGVPRODLIST.Columns(4).HeaderText = "Product Brand"

        DGVPRODLIST.Columns(5).Width = 200
        DGVPRODLIST.Columns(5).HeaderText = "Category Name"

        DGVPRODLIST.Columns(6).Width = 200
        DGVPRODLIST.Columns(6).HeaderText = "Category Code"

    End Sub
    Private Sub VIEW()
        Try

            Dim da As New MySqlDataAdapter("select stockid, prodid, prodname, prodman, prodbrand, prodcat, catcode  from tbl_products ", con)
            Dim dt As New DataSet()
            da.Fill(dt)
            DGVPRODLIST.DataSource = dt.Tables(0)

            DGVSETPROPERTY()
        Catch ex As Exception

        MessageBox.Show(ex.ToString())



        End Try
    End Sub

    Private Sub SelectedColumnsDisplayInGridView_Load(sender As Object, e As Object) Handles MyBase.Load
        VIEW()
    End Sub
    Private Sub ucPRODUCTLIST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Close()
        Try

            Dim da As New MySqlDataAdapter("select stockid, prodid, prodname, prodman, prodbrand, prodcat, catcode from tbl_products ", con)
            Dim dt As New DataSet()
            da.Fill(dt)
            DGVPRODLIST.DataSource = dt.Tables(0)

            DGVSETPROPERTY()
        Catch ex As Exception

            MessageBox.Show(ex.ToString())



        End Try
    End Sub

    Private Sub BTNBACK_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub search()
        Dim dba As New MySqlDataAdapter("select stockid, prodid, prodname, prodman, prodbrand, prodcat, catcode from tbl_products  WHERE tbl_products.prodname LIKE '%" & Me.TXTSEARCH.Text & "%';", con)
        Dim dbset As New DataSet
        dba.Fill(dbset)
        Me.DGVPRODLIST.DataSource = dbset.Tables(0).DefaultView
    End Sub
    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs)
        search()
    End Sub

    Private Sub BTNSTOCKS_Click(sender As Object, e As EventArgs) Handles BTNSTOCKS.Click
        Dim i As Integer
        For i = 0 To 0
            FRMMAINMENU.PNLMAIN.Controls.RemoveAt(i)
        Next

        Dim STOCKLIST As New ucSTOCKLIST()
        STOCKLIST.Parent = FRMMAINMENU.PNLMAIN
        STOCKLIST.Show()
        STOCKLIST.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNLOW_Click(sender As Object, e As EventArgs)
        Dim i As Integer
        For i = 0 To 0
            FRMMAINMENU.PNLMAIN.Controls.RemoveAt(i)
        Next

        Dim LOW As New ucLOWQTY()
        LOW.Parent = FRMMAINMENU.PNLMAIN
        LOW.Show()
        LOW.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNEP_Click(sender As Object, e As EventArgs) Handles BTNEP.Click
        Dim i As Integer
        For i = 0 To 0
            FRMMAINMENU.PNLMAIN.Controls.RemoveAt(i)
        Next

        Dim EXPIRED As New ucOBSELETEINVENTORY()
        EXPIRED.Parent = FRMMAINMENU.PNLMAIN
        EXPIRED.Show()
        EXPIRED.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNRD_Click(sender As Object, e As EventArgs) Handles BTNRD.Click
        Dim i As Integer
        For i = 0 To 0
            FRMMAINMENU.PNLMAIN.Controls.RemoveAt(i)
        Next

        Dim REMDAY As New ucNEAREXPIRY()
        REMDAY.Parent = FRMMAINMENU.PNLMAIN
        REMDAY.Show()
        REMDAY.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNLOW_Click_1(sender As Object, e As EventArgs) Handles BTNLOW.Click
        Dim i As Integer
        For i = 0 To 0
            FRMMAINMENU.PNLMAIN.Controls.RemoveAt(i)
        Next

        Dim LOW As New ucLOWQTY()
        LOW.Parent = FRMMAINMENU.PNLMAIN
        LOW.Show()
        LOW.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNOS_Click(sender As Object, e As EventArgs) Handles BTNOS.Click
        Dim i As Integer
        For i = 0 To 0
            FRMMAINMENU.PNLMAIN.Controls.RemoveAt(i)
        Next

        Dim OUT As New ucOUTOFSTOCKS()
        OUT.Parent = FRMMAINMENU.PNLMAIN
        OUT.Show()
        OUT.Dock = DockStyle.Fill
    End Sub

    Private Sub TXTSEARCH_TextChanged_1(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        searchprod()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
