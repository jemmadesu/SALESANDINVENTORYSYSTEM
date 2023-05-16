Imports MySql.Data.MySqlClient
Public Class ucPRODUCTLIST


    Private Sub DGVSETPROPERTY()

        DGVPRODLIST.Columns(0).Width = 200
        DGVPRODLIST.Columns(0).HeaderText = "Product ID"

        DGVPRODLIST.Columns(1).Width = 200
        DGVPRODLIST.Columns(1).HeaderText = "Product Code"

        DGVPRODLIST.Columns(2).Width = 200
        DGVPRODLIST.Columns(2).HeaderText = "Product Name"

        DGVPRODLIST.Columns(3).Width = 200
        DGVPRODLIST.Columns(3).HeaderText = "Manufacturer"

        DGVPRODLIST.Columns(4).Width = 200
        DGVPRODLIST.Columns(4).HeaderText = "Brand"

        DGVPRODLIST.Columns(5).Width = 200
        DGVPRODLIST.Columns(5).HeaderText = "Category"

        DGVPRODLIST.Columns(6).Width = 200
        DGVPRODLIST.Columns(6).HeaderText = "Category Code"

        DGVPRODLIST.Columns(7).Width = 200
        DGVPRODLIST.Columns(7).HeaderText = "Unit"

        DGVPRODLIST.Columns(8).Width = 200
        DGVPRODLIST.Columns(8).HeaderText = "Price "

    End Sub
    Private Sub VIEW()
        Try

            Dim da As New MySqlDataAdapter("select id, prodcode, prodname, manufacturer, brand, category, catcode, unit, price from tbl_products ", con)
            Dim dt As New DataSet()
            da.Fill(dt)
            DGVPRODLIST.DataSource = dt.Tables(0)

            DGVSETPROPERTY()
        Catch ex As Exception

            MessageBox.Show(ex.ToString())

        End Try
    End Sub
    Private Sub ucPRODUCTLIST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VIEW()
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

    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        PerformSearchAndLoadData(TXTSEARCH.Text)
    End Sub

    Private Sub PerformSearchAndLoadData(keyword As String)
        ' Perform the search and load the data
        Dim query As String = "SELECT id, prodcode, prodname, manufacturer, brand, category, catcode, unit, price FROM tbl_products WHERE CONCAT(id, prodcode, prodname, manufacturer, brand) LIKE @Keyword"
        Dim connectionString As String = "Server=localhost;Port=3306;User=root;Password=password;Database=inventory_db"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Keyword", "%" & keyword & "%")

                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                DGVPRODLIST.DataSource = table
            End Using
        End Using
    End Sub

End Class
