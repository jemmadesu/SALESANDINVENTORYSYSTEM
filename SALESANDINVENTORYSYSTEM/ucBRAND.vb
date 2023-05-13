Imports MySql.Data.MySqlClient
Public Class ucBRAND
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
        DGVBRAND.Columns(0).Width = 200
        DGVBRAND.Columns(0).HeaderText = "Ref No."
        DGVBRAND.Columns(1).Width = 200
        DGVBRAND.Columns(1).HeaderText = "Manufacturer"
        DGVBRAND.Columns(2).Width = 200
        DGVBRAND.Columns(2).HeaderText = "Brand"
        DGVBRAND.Columns(3).Width = 200
        DGVBRAND.Columns(3).HeaderText = "Status"
    End Sub
    Private Sub view()
        con.Close()

        Try

            Dim da As New MySqlDataAdapter("select refno, manufacturer, brand, status from tbl_brand ", con)
            Dim dt As New DataSet()
            da.Fill(dt)
            DGVBRAND.DataSource = dt.Tables(0)

            DGVSETPROPERTY()
        Catch ex As Exception

            MessageBox.Show(ex.ToString())



        End Try
    End Sub

    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click

        If CBOMANU.Text = "-- Select --" Or TXTBRAND.Text = "" Or CBOSTATUS.Text = "-- Select --" Then
            MsgBox("All fields are required!", vbOKOnly + vbCritical, "Error Saving")
            Exit Sub
        End If

        OpenCon()
        cmd.CommandText = "insert into tbl_brand values (NULL, @mn, @br, @st)"
        With cmd.Parameters

            .Clear()
            .AddWithValue("mn", CBOMANU.Text)
            .AddWithValue("br", TXTBRAND.Text)
            .AddWithValue("st", CBOSTATUS.Text)

        End With
        cmd.ExecuteNonQuery()
        con.Close()

        MsgBox("New brand has been saved!", vbOKOnly + vbInformation, "Saving Successful")
        activity = "Added new Brand. Brand Name: " + TXTBRAND.Text

        actlog()
        view()

        CBOMANU.Text = ""
        TXTBRAND.Text = ""
        CBOSTATUS.Text = ""
    End Sub

    Private Sub BTNUPDATE_Click(sender As Object, e As EventArgs) Handles BTNUPDATE.Click

        If CBOMANU.Text = "-- Select --" Or TXTBRAND.Text = "" Or CBOSTATUS.Text = "-- Select --" Then
            MsgBox("All fields are required!", vbOKOnly + vbCritical, "Error Saving")
            Exit Sub
        End If

        OpenCon()
        cmd.CommandText = "Update tbl_brand set refno=@rn, manufacturer =@mn, brand=@br, status=@st where refno=@rn"
        With cmd.Parameters
            .Clear()
            .AddWithValue("mn", CBOMANU.Text)
            .AddWithValue("br", TXTBRAND.Text)
            .AddWithValue("st", CBOSTATUS.Text)
        End With
        cmd.ExecuteNonQuery()
        con.Close()
        view()
        MsgBox("Record has been updated!", vbOKOnly + vbInformation, "Editing Successful")
        BTNUPDATE.Text = "Edit"
    End Sub

    Private Sub DGVBRAND_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVBRAND.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = DGVBRAND.Rows(e.RowIndex)


            CBOMANU.Text = row.Cells(1).Value
            TXTBRAND.Text = row.Cells(2).Value
            CBOSTATUS.Text = row.Cells(3).Value


        End If
        BTNUPDATE.Text = "Update"
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
End Class
