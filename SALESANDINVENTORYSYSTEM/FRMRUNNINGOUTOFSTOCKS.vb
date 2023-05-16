Imports MySql.Data.MySqlClient
Public Class FRMRUNNINGOUTOFSTOCKS

    Dim connection As MySqlConnection
    Dim command As MySqlCommand

    Private Sub DGVSETPROPERTY()
        If DGVLOWQTY.Columns.Count >= 12 Then
            DGVLOWQTY.Columns(0).Width = 200
            DGVLOWQTY.Columns(0).HeaderText = "Product ID"
            DGVLOWQTY.Columns(1).Width = 200
            DGVLOWQTY.Columns(1).HeaderText = "Product Code"
            DGVLOWQTY.Columns(2).Width = 200
            DGVLOWQTY.Columns(2).HeaderText = "Product Name"
            DGVLOWQTY.Columns(3).Width = 200
            DGVLOWQTY.Columns(3).HeaderText = "Manufacturer"
            DGVLOWQTY.Columns(4).Width = 200
            DGVLOWQTY.Columns(4).HeaderText = "Brand"
            DGVLOWQTY.Columns(5).Width = 200
            DGVLOWQTY.Columns(5).HeaderText = "Category"
            DGVLOWQTY.Columns(6).Width = 200
            DGVLOWQTY.Columns(6).HeaderText = "Category Code"
            DGVLOWQTY.Columns(7).Width = 200
            DGVLOWQTY.Columns(7).HeaderText = "Unit"
            DGVLOWQTY.Columns(8).Width = 200
            DGVLOWQTY.Columns(8).HeaderText = "Price"
            DGVLOWQTY.Columns(9).Width = 200
            DGVLOWQTY.Columns(9).HeaderText = "Stocks"
            DGVLOWQTY.Columns(10).Width = 200
            DGVLOWQTY.Columns(10).HeaderText = "Manufactured Date"
            DGVLOWQTY.Columns(11).Width = 200
            DGVLOWQTY.Columns(11).HeaderText = "Expiration Date"
        End If
    End Sub

    Private Sub FRMRUNNINGOUTOFSTOCKS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Close()
        Try

            Dim da As New MySqlDataAdapter("select id, prodcode, prodname, manufacturer, brand, category, catcode, unit, price, quantity, manufactureddate, expirationdate from tbl_stocks WHERE quantity < 10; ", con)
            Dim dt As New DataSet()
            da.Fill(dt)
            DGVLOWQTY.DataSource = dt.Tables(0)

            DGVSETPROPERTY()
        Catch ex As Exception

            MessageBox.Show(ex.ToString())



        End Try

        ' Set the backcolor of the row
        DGVLOWQTY.Columns(9).DefaultCellStyle.BackColor = Color.IndianRed

        ' Set the forecolor of the row
        DGVLOWQTY.Columns(9).DefaultCellStyle.ForeColor = Color.White
    End Sub

    Private Sub LBLCLOSE_Click(sender As Object, e As EventArgs) Handles LBLCLOSE.Click
        Me.Close()
    End Sub
End Class