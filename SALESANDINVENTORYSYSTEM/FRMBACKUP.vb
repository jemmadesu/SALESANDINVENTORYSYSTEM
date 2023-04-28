Imports MySql.Data.MySqlClient

Public Class FRMBACKUP

    Private Sub DGVSETPROPERTY()


        '--------------------------------------------------------------- CODE FOR COLUMN HEADER NAME (PRODUCT) -----------------------------------------
        DGVPROD.Columns(0).Width = 200
        DGVPROD.Columns(0).HeaderText = "Product ID"
        DGVPROD.Columns(1).Width = 200
        DGVPROD.Columns(1).HeaderText = "Product Name"
        DGVPROD.Columns(2).Width = 200
        DGVPROD.Columns(2).HeaderText = "Manufacturer"
        DGVPROD.Columns(3).Width = 200
        DGVPROD.Columns(3).HeaderText = "Brand"
        DGVPROD.Columns(4).Width = 200
        DGVPROD.Columns(4).HeaderText = "Category"
        DGVPROD.Columns(5).Width = 200
        DGVPROD.Columns(5).HeaderText = "Category Code"



    End Sub
    Private Sub BACKPROD_Click(sender As Object, e As EventArgs) Handles BACKPROD.Click

        Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

        For Each row As DataGridViewRow In DGVPROD.Rows
            con.Open()
            cmd.CommandText = "insert into tbl_archiveprod (prodid, prodname, prodman, prodbrand, prodcat, catcode, date) values (@prodid, @prodname, @prodman, @prodbrand, @prodcat, @catcode, @date)"
            With cmd.Parameters
                .Clear()

                cmd.Parameters.AddWithValue("prodid", row.Cells("prodid").Value)
                cmd.Parameters.AddWithValue("prodname", row.Cells("prodname").Value)
                cmd.Parameters.AddWithValue("prodman", row.Cells("prodman").Value)
                cmd.Parameters.AddWithValue("prodbrand", row.Cells("prodbrand").Value)
                cmd.Parameters.AddWithValue("prodcat", row.Cells("prodcat").Value)
                cmd.Parameters.AddWithValue("catcode", row.Cells("catcode").Value)
                cmd.Parameters.AddWithValue("date", currentDate)


                cmd.ExecuteNonQuery()
            End With
            con.Close()

        Next

        MessageBox.Show("Successfully created a product Backup”, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
    Private Sub VIEW()

        ' ------------------------------------------------------------ FOR DISPLAYING THE COLUMN HEADER (PRODUCTS) -------------------------------------------------
        Try

            Dim da As New MySqlDataAdapter("select prodid, prodname, prodman, prodbrand, prodcat, catcode from tbl_products ", con)
            Dim dt As New DataSet()
            da.Fill(dt)
            DGVPROD.DataSource = dt.Tables(0)

            'DGVSETPROPERTY()
        Catch ex As Exception

            MessageBox.Show(ex.ToString())



        End Try

    End Sub
    Private Sub FRMBACKUP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        VIEW()
    End Sub
End Class