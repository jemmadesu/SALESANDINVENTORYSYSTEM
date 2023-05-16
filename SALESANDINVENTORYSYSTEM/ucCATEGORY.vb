
Imports MySql.Data.MySqlClient
Public Class ucCATEGORY
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
    Private Sub load_data()
        Try

            Dim da As New MySqlDataAdapter("select ID, catname, catcode from tbl_category ", con)
            Dim dt As New DataSet()
            da.Fill(dt)
            DGVPRODUCTS.DataSource = dt.Tables(0)


        Catch ex As Exception

            MessageBox.Show(ex.ToString())



        End Try
    End Sub
    Private Sub DGVSETPROPERTY()
        DGVPRODUCTS.Columns(0).Width = 200
        DGVPRODUCTS.Columns(0).HeaderText = "Ref No"
        DGVPRODUCTS.Columns(1).Width = 200
        DGVPRODUCTS.Columns(1).HeaderText = "Category Name"
        DGVPRODUCTS.Columns(2).Width = 200
        DGVPRODUCTS.Columns(2).HeaderText = "Category Code"

    End Sub


    Private Sub ucCATEGORY_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        TXTCATNAME.Enabled = True
        TXTCATCODE.Enabled = True
        BTNINSERT.Enabled = True
        BTNUPDATE.Enabled = False
        BTNUPDATE.Text = "Edit"


        con.Close()

        Try

            Dim da As New MySqlDataAdapter("select ID, catname, catcode from tbl_category ", con)
            Dim dt As New DataSet()
            da.Fill(dt)
            DGVPRODUCTS.DataSource = dt.Tables(0)

            DGVSETPROPERTY()
        Catch ex As Exception

            MessageBox.Show(ex.ToString())

        End Try

    End Sub
    Private Sub BTNINSERT_Click_1(sender As Object, e As EventArgs) Handles BTNINSERT.Click

        OpenCon()
        cmd.CommandText = "insert into tbl_category values (NULL, @cc, @cn)"
        With cmd.Parameters

            .Clear()
            .AddWithValue("cc", TXTCATCODE.Text)
            .AddWithValue("cn", TXTCATNAME.Text)

        End With
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("New category has been saved!", vbOKOnly + vbInformation, "Saving Successful")
        activity = "Added new category. Category Code: " + TXTCATCODE.Text
        actlog()

        TXTID.Text = ""
        TXTCATNAME.Text = ""
        TXTCATCODE.Text = ""
        TXTCATNAME.Enabled = False
        TXTCATCODE.Enabled = False
        load_data()

    End Sub

    Private Sub BTNUPDATE_Click_1(sender As Object, e As EventArgs) Handles BTNUPDATE.Click
        If TXTCATNAME.Text = "" Or TXTCATCODE.Text = "" Then
            MsgBox("All fields are required!", vbOKOnly + vbCritical, "Error Saving")
            TXTCATNAME.Focus()
            Exit Sub
        End If


        If TXTCATNAME.Text = "" Or TXTCATCODE.Text = "" Then
            MsgBox("All fields are required!", vbOKOnly + vbCritical, "Error Saving")
            TXTCATNAME.Focus()
            Exit Sub
        End If

        con.Open()
        cmd.CommandText = "UPDATE tbl_category SET ID=@ID, catcode=@cc, catname=@cn WHERE ID=@ID"
        With cmd.Parameters
            .Clear()
            .AddWithValue("@ID", Me.DGVPRODUCTS.CurrentRow.Cells(0).Value)
            .AddWithValue("@cc", TXTCATCODE.Text)
            .AddWithValue("@cn", TXTCATNAME.Text)
        End With
        cmd.ExecuteNonQuery()
        con.Close()

        MsgBox("Record has been updated!", vbOKOnly + vbInformation, "Editing Successful")

        TXTCATNAME.Text = ""
        TXTCATCODE.Text = ""
        TXTCATNAME.Enabled = False
        TXTCATCODE.Enabled = False
        BTNINSERT.Enabled = True
        BTNUPDATE.Enabled = False

        load_data()
    End Sub
    Private Sub DGVPRODUCTS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPRODUCTS.CellClick

        TXTCATNAME.Enabled = True
        TXTCATCODE.Enabled = True
        BTNINSERT.Enabled = False

        BTNUPDATE.Enabled = True


        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = DGVPRODUCTS.Rows(e.RowIndex)


            TXTCATNAME.Text = row.Cells(1).Value
            TXTCATCODE.Text = row.Cells(2).Value


        End If
        BTNUPDATE.Text = "Update"
    End Sub
    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        PerformSearchAndLoadData(TXTSEARCH.Text)
    End Sub

    Private Sub PerformSearchAndLoadData(keyword As String)
        ' Perform the search and load the data
        Dim query As String = "SELECT ID, catname, catcode FROM tbl_category WHERE catname LIKE @Keyword OR catcode LIKE @Keyword"
        Dim connectionString As String = "Server=localhost;Port=3306;User=root;Password=password;Database=inventory_db"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Keyword", "%" & keyword & "%")

                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                DGVPRODUCTS.DataSource = table
                DGVSETPROPERTY()
            End Using
        End Using
    End Sub

    'Private Sub BTNSAVEEDIT_Click(sender As Object, e As EventArgs)
    '    If TXTCATNAME.Text = "" Or TXTCATCODE.Text = "" Then
    '        MsgBox("All fields are required!", vbOKOnly + vbCritical, "Error Saving")
    '        TXTCATNAME.Focus()
    '        Exit Sub
    '    End If

    '    OpenCon()
    '    cmd.CommandText = "Update tbl_category set catcode =@cc, catname=@cn where catcode= @cc"
    '    With cmd.Parameters
    '        .Clear()
    '        .AddWithValue("cc", TXTCATCODE.Text)
    '        .AddWithValue("cn", TXTCATNAME.Text)


    '    End With
    '    cmd.ExecuteNonQuery()
    '    con.Close()
    '    MsgBox("Record has been updated!", vbOKOnly + vbInformation, "Editing Successful")

    '    TXTID.Text = ""
    '    TXTCATNAME.Text = ""
    '    TXTCATCODE.Text = ""
    '    load_data()
    'End Sub
End Class
