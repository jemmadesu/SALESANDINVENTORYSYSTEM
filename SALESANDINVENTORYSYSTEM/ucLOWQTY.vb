
Imports MySql.Data.MySqlClient
Public Class ucLOWQTY
    Dim connection As MySqlConnection
    Dim command As MySqlCommand

    Private Sub DGVSETPROPERTY()

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

    End Sub
    Private Sub ucLOWQTY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection


        Dim dataset As New DataTable
        Dim bindindsrc As New BindingSource
        Dim dataadapt As New MySqlDataAdapter


        Try

            con.Open()
            command = New MySqlCommand("select id, prodcode, prodname, manufacturer, brand, category, catcode, unit, price, quantity, manufactureddate, expirationdate from tbl_stocks WHERE quantity < 10;", con)
            dataadapt.SelectCommand = command
            dataadapt.Fill(dataset)
            bindindsrc.DataSource = dataset


            DGVLOWQTY.DataSource = bindindsrc
            dataadapt.Update(dataset)
            con.Close()

            DGVSETPROPERTY()
        Catch ex As Exception

        Finally
            con.Dispose()

        End Try

        ' Set the backcolor of the row
        DGVLOWQTY.Columns(9).DefaultCellStyle.BackColor = Color.OrangeRed

        ' Set the forecolor of the row
        DGVLOWQTY.Columns(9).DefaultCellStyle.ForeColor = Color.White


    End Sub


    Private Sub BTNBACK_Click_1(sender As Object, e As EventArgs) Handles BTNBACK.Click
        Dim i As Integer
        For i = 0 To 0
            FRMMAINMENU.PNLMAIN.Controls.RemoveAt(i)
        Next

        Dim PRODLIST As New ucPRODUCTLIST()
        PRODLIST.Parent = FRMMAINMENU.PNLMAIN
        PRODLIST.Show()
        PRODLIST.Dock = DockStyle.Fill
    End Sub




    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs)
        'searchproducts()
    End Sub

End Class
