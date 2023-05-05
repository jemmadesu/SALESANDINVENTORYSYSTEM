Imports MySql.Data.MySqlClient
Public Class FRMNEAREXPIRY
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
    Private Sub FRMNEAREXPIRY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Close()
        Try

            Dim da As New MySqlDataAdapter("SELECT prodid, prodname, unit, quantity, expirationdate, DATEDIFF(expirationdate, NOW()) AS Remaining_Days FROM tbl_stocks WHERE expirationdate > CURDATE() AND expirationdate <= DATE_ADD(CURDATE(), interval 10 day);", con)
            Dim dt As New DataSet()
            da.Fill(dt)
            DGVEXP.DataSource = dt.Tables(0)

            DGVSETPROPERTY()
        Catch ex As Exception

            MessageBox.Show(ex.ToString())

        End Try
        con.Close()


        ' Set the backcolor of the row
        DGVEXP.Columns(5).DefaultCellStyle.BackColor = Color.IndianRed

        ' Set the forecolor of the row
        DGVEXP.Columns(5).DefaultCellStyle.ForeColor = Color.White


    End Sub

    Private Sub LBLEXIT_Click(sender As Object, e As EventArgs) Handles LBLEXIT.Click
        Me.Close()
    End Sub

End Class