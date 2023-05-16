Imports MySql.Data.MySqlClient
Public Class ucMANUFACTURER
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
    Private Sub ucBRAND_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        view()
    End Sub
    Private Sub DGVSETPROPERTY()
        DGVMANUFACTURER.Columns(0).Width = 200
        DGVMANUFACTURER.Columns(0).HeaderText = "Ref No."
        DGVMANUFACTURER.Columns(1).Width = 200
        DGVMANUFACTURER.Columns(1).HeaderText = "Manufacturer"
        DGVMANUFACTURER.Columns(2).Width = 200
        DGVMANUFACTURER.Columns(2).HeaderText = "Status"
    End Sub
    Private Sub view()
        con.Close()

        Try

            Dim da As New MySqlDataAdapter("select refno, manufacturer, status from tbl_manufacturer ", con)
            Dim dt As New DataSet()
            da.Fill(dt)
            DGVMANUFACTURER.DataSource = dt.Tables(0)

            DGVSETPROPERTY()
        Catch ex As Exception

            MessageBox.Show(ex.ToString())



        End Try
    End Sub

    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click

        If TXTMANU.Text = "" Or CBOSTATUS.Text = "-- Select --" Then
            MsgBox("All fields are required!", vbOKOnly + vbCritical, "Error Saving")
            Exit Sub
        End If

        OpenCon()
        cmd.CommandText = "insert into tbl_manufacturer values (NULL, @mn, @st)"
        With cmd.Parameters

            .Clear()
            .AddWithValue("mn", TXTMANU.Text)
            .AddWithValue("st", CBOSTATUS.Text)

        End With
        cmd.ExecuteNonQuery()
        con.Close()

        MsgBox("New Manufacturer has been saved!", vbOKOnly + vbInformation, "Saving Successful")
        activity = "Added new Manufacturer. Manufacturer Name: " + TXTMANU.Text

        actlog()
        view()

        TXTMANU.Text = ""
        CBOSTATUS.Text = ""
    End Sub

    Private Sub BTNUPDATE_Click(sender As Object, e As EventArgs) Handles BTNUPDATE.Click


        If TXTMANU.Text = "" Or CBOSTATUS.Text = "-- Select --" Then
            MsgBox("All fields are required!", vbOKOnly + vbCritical, "Error Saving")
            Exit Sub
        End If

        Dim selectedRow As DataGridViewRow = DGVMANUFACTURER.SelectedRows(0)
        Dim refNoValue As String = selectedRow.Cells(0).Value.ToString()

        OpenCon()
        cmd.CommandText = "UPDATE tbl_manufacturer SET manufacturer = @mn, status = @st WHERE refno = @rn"
        With cmd.Parameters
            .Clear()
            .AddWithValue("mn", TXTMANU.Text)
            .AddWithValue("st", CBOSTATUS.Text)
            .AddWithValue("rn", refnoValue) ' Replace refnoValue with the actual value of the refno to be updated
        End With
        cmd.ExecuteNonQuery()
        con.Close()

        view()
        MsgBox("Record has been updated!", vbOKOnly + vbInformation, "Editing Successful")
        BTNUPDATE.Text = "Edit"
    End Sub

    Private Sub DGVBRAND_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVMANUFACTURER.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = DGVMANUFACTURER.Rows(e.RowIndex)


            TXTMANU.Text = row.Cells(1).Value
            CBOSTATUS.Text = row.Cells(2).Value

        End If
        BTNUPDATE.Text = "Update"
    End Sub
    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        PerformSearchAndLoadData(TXTSEARCH.Text)
    End Sub

    Private Sub PerformSearchAndLoadData(keyword As String)
        ' Perform the search and load the data
        Dim query As String = "SELECT refno, manufacturer, status FROM tbl_manufacturer WHERE manufacturer LIKE @Keyword OR status LIKE @Keyword"
        Dim connectionString As String = "Server=localhost;Port=3306;User=root;Password=password;Database=inventory_db"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Keyword", "%" & keyword & "%")

                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                DGVMANUFACTURER.DataSource = table
                DGVSETPROPERTY()
            End Using
        End Using
    End Sub

End Class
