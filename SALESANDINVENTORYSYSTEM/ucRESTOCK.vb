
Imports MySql.Data.MySqlClient


Public Class ucRESTOCK

    Private Sub actlog()
        con.Close()
        OpenCon()
        cmd.CommandText = "insert into tbl_actlog values (@un, @ut, @act, @dt)"
        With cmd.Parameters
            .Clear()
            .AddWithValue("un", FRMMAINMENU.LBLUSERNAME.Text)
            .AddWithValue("ut", FRMMAINMENU.LBLUSERTYPE.Text)
            .AddWithValue("act", activity)
            .AddWithValue("dt", Format(Date.Now, "yyyy-MM-dd h:mm tt"))
            cmd.ExecuteNonQuery()
            con.Close()
        End With
    End Sub
    Public Sub DGVMAINSET()


        DGVMAIN.Columns(0).Width = 150
        DGVMAIN.Columns(0).HeaderText = "Stock ID"
        DGVMAIN.Columns(1).Width = 150
        DGVMAIN.Columns(1).HeaderText = "Product Name"
        DGVMAIN.Columns(2).Width = 150
        DGVMAIN.Columns(2).HeaderText = "Unit"
        DGVMAIN.Columns(3).Width = 150
        DGVMAIN.Columns(3).HeaderText = "Price"
        DGVMAIN.Columns(4).Width = 150
        DGVMAIN.Columns(4).HeaderText = "stocks"
        DGVMAIN.Columns(5).Width = 150
        DGVMAIN.Columns(5).HeaderText = "Product Manufacturer"
        DGVMAIN.Columns(6).Width = 150
        DGVMAIN.Columns(6).HeaderText = "Expiration Date"


    End Sub

    Private Sub searchproducts()
        Dim dba As New MySqlDataAdapter("select stockid, prodname, unit, price, quantity, prodman, expirationdate from tbl_products WHERE tbl_products.prodname LIKE '%" & Me.TXTSEARCH.Text & "%';", con)
        Dim dbset As New DataSet
        dba.Fill(dbset)
        Me.DGVMAIN.DataSource = dbset.Tables(0).DefaultView

    End Sub
    Private Sub LOADDATA()

        Try

            Dim da As New MySqlDataAdapter("select stockid, prodname, unit, price, quantity, prodman, expirationdate from tbl_products ", con)
            Dim dt As New DataSet()
            da.Fill(dt)
            DGVMAIN.DataSource = dt.Tables(0)

            DGVMAINSET()
        Catch ex As Exception

            MessageBox.Show(ex.ToString())



        End Try

    End Sub
    Private Sub ucRESTOCK_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Dim da As New MySqlDataAdapter("select stockid, prodname, unit, price, quantity, prodman, expirationdate from tbl_products where price <> '' ", con)
            Dim dt As New DataSet()
            da.Fill(dt)
            DGVMAIN.DataSource = dt.Tables(0)

            DGVMAINSET()
        Catch ex As Exception

            MessageBox.Show(ex.ToString())



        End Try




        'For Each row As DataGridViewRow In DGVMAIN.Rows
        '    Dim isRowEmpty As Boolean = True

        '    For Each cell As DataGridViewCell In row.Cells
        '        If Not String.IsNullOrEmpty(cell.Value) Then
        '            isRowEmpty = False
        '            Exit For
        '        End If
        '    Next

        '    row.Visible = Not isRowEmpty
        'Next





        'Dim connString As String = “Server=localhost;Port=3306;User=root;Password=password;Database=inventory_db”
        'Dim conn As New MySqlConnection(connString)
        'Dim query As String = "SELECT select stockid, prodname, unit, price, quantity, prodman, expirationdate WHERE quantity IS NOT NULL AND quantity <> '';"
        'Dim dat As New MySqlDataAdapter(query, conn)
        'Dim ds As New DataSet()
        'dat.Fill(ds, "tbl_products")

        'DGVMAIN.DataSource = ds.Tables("tbl_products")


        'For Each col As DataGridViewColumn In DGVMAIN.Columns
        '    If col.HeaderText = "quantity" Then
        '        col.Visible = False
        '    End If
        'Next

        'For Each row As DataGridViewRow In DGVMAIN.Rows
        '    Dim ageValue As String = Convert.ToString(row.Cells("quantity").Value)
        '    If String.IsNullOrEmpty(ageValue) Then
        '        row.Cells("quantity").Style.ForeColor = Color.White
        '        row.Cells("quantity").Style.BackColor = Color.Red
        '    End If
        'Next


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click

        BTNSAVE.Text = "Save"

        Me.TXTQTY.ReadOnly = False


        If Me.TXTQTY.Text = "" Then
            MessageBox.Show("EMPTY", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub

        End If
        If Me.TXTQTY.Text = "0" Then
            MessageBox.Show("The Quantity is Zero", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End If
        Me.BTNSAVE.Text = "Edit Quantity"




        Dim QuantityUpdate As Integer

        QuantityUpdate = Val(TXTQTY.Text) + Val(TXTQTYADD.Text)

        con.Close()
        con.Open()
        cmd.CommandText = "Update tbl_products set quantity=@qt where stockid= @si"



        With cmd.Parameters
            .Clear()
            .AddWithValue("qt", QuantityUpdate)
            .AddWithValue("si", TXTSI.Text)

        End With
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("New stock has been added", vbOKOnly + vbInformation, "Added Stock")
        activity = "Added stock. Product Name: " + TXTPRODNAME.Text + "Quantity" + TXTQTYADD.Text
        actlog()
        TXTPRODNAME.Text = ""
        TXTUNIT.Text = ""
        TXTPRICE.Text = ""
        TXTQTY.Text = ""
        TXTMAN.Text = ""
        TXTED.Text = ""
        TXTQTYADD.Text = ""
        LOADDATA()
    End Sub

    Private Sub TXTQTYADD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTQTYADD.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DGVMAIN_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DGVMAIN.CellContentClick
        con.Close()

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow


            row = DGVMAIN.Rows(e.RowIndex)

            TXTSI.Text = row.Cells(0).Value
            TXTPRODNAME.Text = row.Cells(1).Value
            TXTUNIT.Text = row.Cells(2).Value
            TXTPRICE.Text = row.Cells(3).Value
            TXTQTY.Text = row.Cells(4).Value
            TXTMAN.Text = row.Cells(5).Value
            TXTED.Text = row.Cells(6).Value


        End If
    End Sub



    Private Sub BTNBACK_Click_1(sender As Object, e As EventArgs) Handles BTNBACK.Click
        Dim i As Integer
        For i = 0 To 0
            FRMMAINMENU.PNLMAIN.Controls.RemoveAt(i)
        Next

        Dim SETTINGS As New ucSETTINGS()
        SETTINGS.Parent = FRMMAINMENU.PNLMAIN
        SETTINGS.Show()
        SETTINGS.Dock = DockStyle.Fill
    End Sub



    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        searchproducts()
    End Sub

End Class
