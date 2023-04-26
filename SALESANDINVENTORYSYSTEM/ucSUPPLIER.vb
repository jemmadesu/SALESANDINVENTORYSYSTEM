Imports MySql.Data.MySqlClient
Public Class ucSUPPLIER


    Private Sub load_data()
        Try

            Dim da As New MySqlDataAdapter("select Companyname, FirstName, LastName, Email, PhoneNo, Address from tbl_supplier ", con)
            Dim dt As New DataSet()
            da.Fill(dt)
            DGVSUP.DataSource = dt.Tables(0)


        Catch ex As Exception

            MessageBox.Show(ex.ToString())



        End Try
    End Sub
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
    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click


        If TXTCOM.Text = "" Or TXTFN.Text = "" Or TXTLN.Text = "" Or TXTEMAIL.Text = "" Or TXTNO.Text = "" Or TXTADD.Text = "" Then
            MsgBox("All fields are required!", vbOKOnly + vbCritical, "Error Saving")
            TXTCOM.Focus()
            Exit Sub
        End If

        OpenCon()
        cmd.CommandText = "insert into tbl_supplier (Companyname, FirstName, LastName, Email, PhoneNo, Address ) values ( @COM, @FN, @LN, @EM, @PN, @ADD)"
        With cmd.Parameters

            .Clear()


            .AddWithValue("COM", TXTCOM.Text)
            .AddWithValue("FN", TXTFN.Text)
            .AddWithValue("LN", TXTLN.Text)
            .AddWithValue("EM", TXTEMAIL.Text)
            .AddWithValue("PN", TXTNO.Text)
            .AddWithValue("ADD", TXTADD.Text)

        End With
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("New Supplier has been saved!", vbOKOnly + vbInformation, "Saving Successful")
        activity = "Added new supplier. Company Name: " + TXTCOM.Text
        actlog()

        TXTCOM.Text = ""
        TXTFN.Text = ""
        TXTLN.Text = ""
        TXTEMAIL.Text = ""
        TXTNO.Text = ""
        TXTADD.Text = ""

        load_data()
    End Sub

    Private Sub ucSUPPLIER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Close()
        load_data()
    End Sub

    Private Sub BTNEDIT_Click(sender As Object, e As EventArgs) Handles BTNEDIT.Click
        If TXTCOM.Text = "" Or TXTFN.Text = "" Or TXTLN.Text = "" Or TXTEMAIL.Text = "" Or TXTNO.Text = "" Or TXTADD.Text = "" Then
            MsgBox("All fields are required!", vbOKOnly + vbCritical, "Error Saving")
            TXTCOM.Focus()
            Exit Sub
        End If

        OpenCon()
        cmd.CommandText = "Update tbl_supplier set Companyname=@COM, FirstName=@FN , LastName=@LN, Email=@EM, PhoneNo=@PN, Address=@ADD where PhoneNo=@PN"
        With cmd.Parameters

            .Clear()
            .AddWithValue("COM", TXTCOM.Text)
            .AddWithValue("FN", TXTFN.Text)
            .AddWithValue("LN", TXTLN.Text)
            .AddWithValue("EM", TXTEMAIL.Text)
            .AddWithValue("PN", TXTNO.Text)
            .AddWithValue("ADD", TXTADD.Text)


        End With
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Record has been updated!", vbOKOnly + vbInformation, "Editing Successful")

        TXTCOM.Text = ""
        TXTFN.Text = ""
        TXTLN.Text = ""
        TXTEMAIL.Text = ""
        TXTNO.Text = ""
        TXTADD.Text = ""
        load_data()

        BTNSAVE.Enabled = True
    End Sub

    Private Sub BTNDELETE_Click(sender As Object, e As EventArgs) Handles BTNDELETE.Click
        For i As Integer = 0 To DGVSUP.SelectedRows.Count - 1
            Dim cmd As New MySqlCommand("delete from tbl_supplier where PhoneNo = @PN ", con)
            cmd.Parameters.AddWithValue("PN", DGVSUP.SelectedRows(i).Cells(4).Value.ToString())
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Next
        load_data()
        MessageBox.Show("data deleted succesfully")
        activity = "deleted a supplier. Company Name: " + TXTCOM.Text
        actlog()
        TXTCOM.Text = ""
        TXTFN.Text = ""
        TXTLN.Text = ""
        TXTEMAIL.Text = ""
        TXTNO.Text = ""
        TXTADD.Text = ""
        load_data()

    End Sub

    Private Sub DGVSUP_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSUP.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = DGVSUP.Rows(e.RowIndex)


            TXTCOM.Text = row.Cells(0).Value
            TXTFN.Text = row.Cells(1).Value
            TXTLN.Text = row.Cells(2).Value
            TXTEMAIL.Text = row.Cells(3).Value
            TXTNO.Text = row.Cells(4).Value
            TXTADD.Text = row.Cells(5).Value


        End If
        BTNEDIT.Text = "Update"
        BTNSAVE.Enabled = False
    End Sub

    Private Sub BTNCANCEL_Click(sender As Object, e As EventArgs) Handles BTNCANCEL.Click
        TXTCOM.Text = ""
        TXTFN.Text = ""
        TXTLN.Text = ""
        TXTEMAIL.Text = ""
        TXTNO.Text = ""
        TXTADD.Text = ""
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
    Private Sub search()
        Dim dba As New MySqlDataAdapter("select Companyname, FirstName, LastName, Email, PhoneNo, Address from tbl_supplier WHERE tbl_supplier.companyname LIKE '%" & Me.TXTSEARCH.Text & "%';", con)
        Dim dbset As New DataSet
        dba.Fill(dbset)
        Me.DGVSUP.DataSource = dbset.Tables(0).DefaultView
    End Sub
    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        search()
    End Sub
End Class
