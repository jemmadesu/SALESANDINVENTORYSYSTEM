Imports MySql.Data.MySqlClient
Public Class ucSTOCKLIST
    Private Sub ucSTOCKLIST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOADDATAMAIN()
    End Sub
    Private Sub DGVMAINSET()
        DGVSTOCK.Columns(0).Width = 200
        DGVSTOCK.Columns(0).HeaderText = "Product ID"
        DGVSTOCK.Columns(1).Width = 200
        DGVSTOCK.Columns(1).HeaderText = "Product Code"
        DGVSTOCK.Columns(2).Width = 200
        DGVSTOCK.Columns(2).HeaderText = "Product Name"
        DGVSTOCK.Columns(3).Width = 200
        DGVSTOCK.Columns(3).HeaderText = "Manufacturer"
        DGVSTOCK.Columns(4).Width = 200
        DGVSTOCK.Columns(4).HeaderText = "Brand"
        DGVSTOCK.Columns(5).Width = 200
        DGVSTOCK.Columns(5).HeaderText = "Category"
        DGVSTOCK.Columns(6).Width = 200
        DGVSTOCK.Columns(6).HeaderText = "Category Code"
        DGVSTOCK.Columns(7).Width = 200
        DGVSTOCK.Columns(7).HeaderText = "Unit"
        DGVSTOCK.Columns(8).Width = 200
        DGVSTOCK.Columns(8).HeaderText = "Price"
        DGVSTOCK.Columns(9).Width = 200
        DGVSTOCK.Columns(9).HeaderText = "Stocks"
        DGVSTOCK.Columns(10).Width = 200
        DGVSTOCK.Columns(10).HeaderText = "Manufactured Date"
        DGVSTOCK.Columns(11).Width = 200
        DGVSTOCK.Columns(11).HeaderText = "Expiration Date"

    End Sub
    Private Sub LOADDATAMAIN()
        Try

            Dim da As New MySqlDataAdapter("select id, prodcode, prodname, manufacturer, brand, category, catcode, unit, price, quantity, manufactureddate, expirationdate from tbl_stocks ", con)
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
        PerformSearchAndLoadData(TXTSEARCH.Text)
    End Sub
    Private Sub PerformSearchAndLoadData(keyword As String)
        ' Perform the search and load the data
        Dim query As String = "SELECT id, prodcode, prodname, manufacturer, brand, category, catcode, unit, price, quantity, manufactureddate, expirationdate FROM tbl_stocks WHERE CONCAT( id, prodcode, prodname, manufacturer, brand) LIKE @Keyword"
        Dim connectionString As String = "Server=localhost;Port=3306;User=root;Password=password;Database=inventory_db"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Keyword", "%" & keyword & "%")

                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                DGVSTOCK.DataSource = table
            End Using
        End Using
    End Sub

End Class
