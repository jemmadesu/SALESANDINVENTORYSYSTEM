﻿Imports MySql.Data.MySqlClient
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
            command = New MySqlCommand("SELECT prodid, prodname, unit, quantity, expirationdate, DATEDIFF(expirationdate, NOW()) AS Remaining_Days FROM tbl_stocks WHERE expirationdate > CURDATE() AND expirationdate <= DATE_ADD(CURDATE(), interval 10 day);", con)

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

        ' Set the backcolor of the row
        DGVEXP.Columns(5).DefaultCellStyle.BackColor = Color.IndianRed

        ' Set the forecolor of the row
        DGVEXP.Columns(5).DefaultCellStyle.ForeColor = Color.White

    End Sub

    Private Sub DGVEXP_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
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
End Class
