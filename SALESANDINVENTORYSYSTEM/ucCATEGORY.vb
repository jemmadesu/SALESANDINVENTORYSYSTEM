
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

            Dim da As New MySqlDataAdapter("select catcode, catname from tbl_category ", con)
            Dim dt As New DataSet()
            da.Fill(dt)
            DGVPRODUCTS.DataSource = dt.Tables(0)


        Catch ex As Exception

            MessageBox.Show(ex.ToString())



        End Try
    End Sub
    Private Sub Getmax()
        OpenCon()
        cmd.CommandText = "Select * from tbl_category"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Dim getno As Integer
            con.Close()
            OpenCon()
            cmd.CommandText = "Select Max(ID) from tbl_category"
            getno = Convert.ToInt64(cmd.ExecuteScalar())
            con.Close()
            TXTID.Text = getno + 1
        Else
            TXTID.Text = 1
            con.Close()
        End If
    End Sub


    Private Sub DGVSETPROPERTY()
        DGVPRODUCTS.Columns(0).Width = 200
        DGVPRODUCTS.Columns(0).HeaderText = "Category Code"
        DGVPRODUCTS.Columns(1).Width = 200
        DGVPRODUCTS.Columns(1).HeaderText = "Category Name"


    End Sub


    Private Sub ucCATEGORY_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try

            Dim da As New MySqlDataAdapter("select catcode, catname from tbl_category ", con)
            Dim dt As New DataSet()
            da.Fill(dt)
            DGVPRODUCTS.DataSource = dt.Tables(0)

            DGVSETPROPERTY()
        Catch ex As Exception

            MessageBox.Show(ex.ToString())



        End Try

    End Sub

    Private Sub BTNBACK_Click(sender As Object, e As EventArgs) Handles BTNBACK.Click
        Dim i As Integer
        For i = 0 To 0
            FRMMAINMENU.PNLMAIN.Controls.RemoveAt(i)
        Next

        Dim SETTINGS As New ucSETTINGS()
        SETTINGS.Parent = FRMMAINMENU.PNLMAIN
        SETTINGS.Show()
        SETTINGS.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNADD_Click_1(sender As Object, e As EventArgs) Handles BTNADD.Click
        Getmax()
    End Sub

    Private Sub BTNINSERT_Click_1(sender As Object, e As EventArgs) Handles BTNINSERT.Click


        OpenCon()


        cmd.CommandText = "insert into tbl_category(ID, catcode,catname) values ( @ID, @cc, @cn)"
        With cmd.Parameters

            .Clear()


            .AddWithValue("ID", TXTID.Text)
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
        load_data()

    End Sub

    Private Sub BTNUPDATE_Click_1(sender As Object, e As EventArgs) Handles BTNUPDATE.Click
        If TXTCATNAME.Text = "" Or TXTCATCODE.Text = "" Then
            MsgBox("All fields are required!", vbOKOnly + vbCritical, "Error Saving")
            TXTCATNAME.Focus()
            Exit Sub
        End If

        OpenCon()
        cmd.CommandText = "Update tbl_category set catcode =@cc, catname=@cn where catcode= @cc"
        With cmd.Parameters
            .Clear()
            .AddWithValue("cc", TXTCATCODE.Text)
            .AddWithValue("cn", TXTCATNAME.Text)


        End With
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Record has been updated!", vbOKOnly + vbInformation, "Editing Successful")

        TXTID.Text = ""
        TXTCATNAME.Text = ""
        TXTCATCODE.Text = ""
        load_data()
    End Sub

    Private Sub BTNDELETE_Click_1(sender As Object, e As EventArgs) Handles BTNDELETE.Click
        For i As Integer = 0 To DGVPRODUCTS.SelectedRows.Count - 1
            Dim cmd As New MySqlCommand("delete from tbl_category where catcode = @cc ", con)
            cmd.Parameters.AddWithValue("cc", DGVPRODUCTS.SelectedRows(i).Cells(0).Value.ToString())
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Next
        load_data()
        MessageBox.Show("data deleted succesfully")
        activity = "deleted a category. Category Code: " + TXTCATCODE.Text
        actlog()
        TXTCATCODE.Text = ""
        TXTCATNAME.Text = ""
    End Sub



    Private Sub DGVPRODUCTS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPRODUCTS.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = DGVPRODUCTS.Rows(e.RowIndex)


            TXTCATCODE.Text = row.Cells(0).Value
            TXTCATNAME.Text = row.Cells(1).Value


        End If
        BTNUPDATE.Text = "Update"
    End Sub
End Class
