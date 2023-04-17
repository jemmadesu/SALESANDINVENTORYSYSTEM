Imports MySql.Data.MySqlClient
Public Class ucNEAREXPIRY
    Dim connection As MySqlConnection
    Dim command As MySqlCommand

    Private Sub DGVSETPROPERTY()
        DGVEXP.Columns(0).Width = 200
        DGVEXP.Columns(0).HeaderText = "Product ID"
        DGVEXP.Columns(1).Width = 200
        DGVEXP.Columns(1).HeaderText = "Product Name"
        DGVEXP.Columns(2).Width = 200
        DGVEXP.Columns(2).HeaderText = "Unit"
        DGVEXP.Columns(3).Width = 200
        DGVEXP.Columns(3).HeaderText = "Quantity"
        DGVEXP.Columns(4).Width = 200
        DGVEXP.Columns(4).HeaderText = "Expiration Date"
        DGVEXP.Columns(5).Width = 200
        DGVEXP.Columns(5).HeaderText = "Remaining Days"
    End Sub
    Private Sub ucREMAININGDAYS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connection = New MySqlConnection


        Dim dataset As New DataTable
        Dim bindindsrc As New BindingSource
        Dim dataadapt As New MySqlDataAdapter

        Try

            con.Open()
            command = New MySqlCommand("SELECT prodid, prodname, unit, quantity, expirationdate, DATEDIFF(expirationdate, NOW()) AS Remaining_Days FROM tbl_products WHERE expirationdate > CURDATE() AND expirationdate <= DATE_ADD(CURDATE(), interval 10 day);", con)

            dataadapt.SelectCommand = command
            dataadapt.Fill(dataset)
            bindindsrc.DataSource = dataset

            DGVEXP.DataSource = bindindsrc
            dataadapt.Update(dataset)
            con.Close()

            DGVSETPROPERTY()
        Catch ex As Exception

        Finally
            con.Dispose()

        End Try

    End Sub

    Private Sub DGVEXP_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)

        'If DGVEXP.Columns(e.ColumnIndex).Name = "remaining_days" Then
        '    DGVEXP.Columns(e.ColumnIndex).HeaderText = "Remaining Days"
        '    DGVEXP.Columns(e.ColumnIndex).Width = 150

        'End If

        ' Check if the current column is the column you want to modify
        If e.ColumnIndex = 5 Then ' Replace 1 with the index of the column you want to modify
            ' Check if the cell value is a negative number
            If IsNumeric(e.Value) AndAlso CDbl(e.Value) < 0 Then
                ' Remove the negative sign and set the cell value to the absolute value of the original number
                e.Value = Math.Abs(CDbl(e.Value)).ToString()
                e.FormattingApplied = True


            End If
        End If


        ' Check if the column index is the one you want to format
        If e.ColumnIndex = 5 Then ' Replace 1 with the actual column index you want to format
            ' Check the cell value and set the background color accordingly
            If Convert.ToInt32(e.Value) < 10 Then ' Replace 10 with the value you want to use as the threshold
                e.CellStyle.BackColor = Color.FromArgb(208, 34, 41)
                e.CellStyle.ForeColor = Color.White
            End If
        End If
    End Sub

    Private Sub BTNBACK_Click(sender As Object, e As EventArgs) Handles BTNBACK.Click
        Dim i As Integer
        For i = 0 To 0
            FRMMAINMENU.PNLMAIN.Controls.RemoveAt(i)
        Next

        Dim PROD As New ucPRODUCTLIST()
        PROD.Parent = FRMMAINMENU.PNLMAIN
        PROD.Show()
        PROD.Dock = DockStyle.Fill
    End Sub
    'Private Sub searchproducts()
    '    Dim dba As New MySqlDataAdapter("select stockid, prodname, unit, price, quantity, prodman, expirationdate from tbl_products WHERE tbl_products.prodname LIKE '%" & Me.TXTSEARCH.Text & "%';", con)
    '    Dim dbset As New DataSet
    '    dba.Fill(dbset)
    '    Me.DGVEXP.DataSource = dbset.Tables(0).DefaultView

    'End Sub

    'Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs)
    '    searchproducts()
    'End Sub
End Class
