Imports MySql.Data.MySqlClient
Public Class FRMLOWQTY

    Private Sub DGVSETPROPERTY()
        DGVLOWQTY.Columns(0).Width = 150
        DGVLOWQTY.Columns(0).HeaderText = "Stock ID"
        DGVLOWQTY.Columns(1).Width = 150
        DGVLOWQTY.Columns(1).HeaderText = "Product ID"
        DGVLOWQTY.Columns(2).Width = 150
        DGVLOWQTY.Columns(2).HeaderText = "Product Name"
        DGVLOWQTY.Columns(3).Width = 150
        DGVLOWQTY.Columns(3).HeaderText = "Manufacturer"
        DGVLOWQTY.Columns(4).Width = 150
        DGVLOWQTY.Columns(4).HeaderText = "Brand"
        DGVLOWQTY.Columns(5).Width = 150
        DGVLOWQTY.Columns(5).HeaderText = "Product Category"
        DGVLOWQTY.Columns(6).Width = 150
        DGVLOWQTY.Columns(6).HeaderText = "Category Code"
        DGVLOWQTY.Columns(7).Width = 150
        DGVLOWQTY.Columns(7).HeaderText = "Price"
        DGVLOWQTY.Columns(8).Width = 150
        DGVLOWQTY.Columns(8).HeaderText = "Unit"
        DGVLOWQTY.Columns(9).Width = 150
        DGVLOWQTY.Columns(9).HeaderText = "Quantity"
        DGVLOWQTY.Columns(10).Width = 150
        DGVLOWQTY.Columns(10).HeaderText = "Expiration Date"
    End Sub
    Private Sub FRMLOWQTY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Close()
        Try

            Dim da As New MySqlDataAdapter("select stockid, prodid, prodname, prodman, prodbrand, prodcat, catcode, price, unit, quantity, expirationdate from tbl_stocks WHERE quantity < 10;", con)
            Dim dt As New DataSet()
            da.Fill(dt)
            DGVLOWQTY.DataSource = dt.Tables(0)

            DGVSETPROPERTY()
        Catch ex As Exception

            MessageBox.Show(ex.ToString())

        End Try
        con.Close()

    End Sub

    Private Sub LBLEXIT_Click(sender As Object, e As EventArgs) Handles LBLEXIT.Click
        Me.Close()
    End Sub
End Class