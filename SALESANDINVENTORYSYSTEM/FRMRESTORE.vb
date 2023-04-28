Imports MySql.Data.MySqlClient
Public Class FRMRESTORE
    Private Sub BTNRESTORE_Click(sender As Object, e As EventArgs) Handles BTNRESTORE.Click

        Dim selectedColumns As New List(Of String) From {"prodid", "prodname", "prodman", "prodbrand", "prodcat", "catcode"}


        Dim values As New List(Of List(Of String))()
        For Each row As DataGridViewRow In DGVPROD.Rows
            Dim rowValues As New List(Of String)()
            For Each selectedColumn As String In selectedColumns
                Dim value As String = row.Cells(selectedColumn).Value.ToString()
                rowValues.Add(value)
            Next
            values.Add(rowValues)
        Next


        Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

        Using conn As New MySqlConnection("Server=localhost;Port=3306;User=root;Password=password;Database=inventory_db")
            conn.Open()
            For Each rowValues As List(Of String) In values
                Dim cmd As New MySqlCommand("insert into tbl_products (prodid, prodname, prodman, prodbrand, prodcat, catcode, date) values (@prodid, @prodname, @prodman, @prodbrand, @prodcat, @catcode, @date)", conn)
                cmd.Parameters.AddWithValue("prodid", rowValues(0))
                cmd.Parameters.AddWithValue("prodname", rowValues(1))
                cmd.Parameters.AddWithValue("prodman", rowValues(2))
                cmd.Parameters.AddWithValue("prodbrand", rowValues(3))
                cmd.Parameters.AddWithValue("prodcat", rowValues(4))
                cmd.Parameters.AddWithValue("catcode", rowValues(5))
                cmd.Parameters.AddWithValue("date", currentDate)
                cmd.ExecuteNonQuery()
            Next
            conn.Close()
        End Using

        MessageBox.Show("Successfully saved the selected columns to the database”, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)



    End Sub
    Private Sub VIEW()

        ' ------------------------------------------------------------ FOR DISPLAYING THE COLUMN HEADER (PRODUCTS) -------------------------------------------------
        Try

            Dim da As New MySqlDataAdapter("select prodid, prodname, prodman, prodbrand, prodcat, catcode from tbl_archiveprod ", con)
            Dim dt As New DataSet()
            da.Fill(dt)
            DGVPROD.DataSource = dt.Tables(0)

            'DGVSETPROPERTY()
        Catch ex As Exception

            MessageBox.Show(ex.ToString())



        End Try

    End Sub

    Private Sub FRMRESTORE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VIEW()
    End Sub
End Class