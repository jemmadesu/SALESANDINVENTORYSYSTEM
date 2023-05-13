Imports MySql.Data.MySqlClient


Public Class ucUSERMANAGEMENT
    Dim con_str As String = "My.Settings.inventory_dbConnectionString"

    Private Sub DGVSETPROPERTY()
        DGVUSERS.Columns(0).Width = 150
        DGVUSERS.Columns(0).HeaderText = "Ref ID"
        DGVUSERS.Columns(1).Width = 150
        DGVUSERS.Columns(1).HeaderText = "Username"
        DGVUSERS.Columns(2).Width = 150
        DGVUSERS.Columns(2).HeaderText = "Usertype"
        DGVUSERS.Columns(3).Width = 150
        DGVUSERS.Columns(3).HeaderText = "User ID"
        DGVUSERS.Columns(4).Width = 150
        DGVUSERS.Columns(4).HeaderText = "Status"
        DGVUSERS.Columns(5).Width = 150
        DGVUSERS.Columns(5).HeaderText = "Password"
        DGVUSERS.Columns(6).Width = 150
        DGVUSERS.Columns(6).HeaderText = "First Name"
        DGVUSERS.Columns(7).Width = 150
        DGVUSERS.Columns(7).HeaderText = "Middle Name"
        DGVUSERS.Columns(8).Width = 150
        DGVUSERS.Columns(8).HeaderText = "Last Name"
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
    Private Sub Getmax()
        OpenCon()
        cmd.CommandText = "Select * from tbl_users"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Dim getno As Integer
            con.Close()
            OpenCon()
            cmd.CommandText = "Select Max(refid) from tbl_users"
            getno = Convert.ToInt64(cmd.ExecuteScalar())
            con.Close()
            ID.Text = getno + 1
            TXTRI.Text = "0" + ID.Text
            con.Close()
        End If
    End Sub
    Sub AutoID()
        If CBOACCTYPE.Text = "Admin" Then
            TXTUI.Text = "USER" + "RPHECMPC" + "01" + TXTRI.Text

        Else
        End If
        If CBOACCTYPE.Text = "Cashier" Then
            TXTUI.Text = "USER" + "RPHECMPC" + "02" + TXTRI.Text

        End If

        If CBOACCTYPE.Text = "Manager" Then
            TXTUI.Text = "USER" + "RPHECMPC" + "03" + TXTRI.Text

        End If
    End Sub
    Private Sub ucUSERMANAGEMENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOADUSERS()
    End Sub


    Private Sub LOADUSERS()
        Try
            Dim da As New MySqlDataAdapter("select refid, username, usertype, userid, status, password, firstname, middlename, lastname from tbl_users", con)
            Dim dt As New DataSet()
            da.Fill(dt)
            DGVUSERS.DataSource = dt.Tables(0)
            DGVSETPROPERTY()
        Catch ex As Exception

            MessageBox.Show(ex.ToString())



        End Try

    End Sub

    Private Sub chkshowpass_CheckedChanged(sender As Object, e As EventArgs) Handles CHKPASS.CheckedChanged
        If CHKPASS.Checked = False Then
            TXTPW.PasswordChar = "*"
            TXTCP.PasswordChar = "*"
        Else
            TXTPW.PasswordChar = ""
            TXTCP.PasswordChar = ""
        End If
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
    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click

        'ERROR TRAPPING

        'Getmax()
        'AutoID()

        If CBOACCTYPE.Text = "" Or CBOSTATUS.Text = "" Or TXTUI.Text = "" Or TXTMN.Text = "" Or TXTLN.Text = "" Or TXTUN.Text = "" Or TXTCP.Text = "" Or TXTRI.Text = "" Then
            MsgBox("All fields are required!", vbOKOnly + vbCritical, "Error Saving")
            TXTFN.Focus()
            Exit Sub
        End If
        If TXTPW.Text <> TXTCP.Text Then
            MsgBox("Password should match!", vbOKOnly + vbCritical, "Error Saving")
            TXTPW.Focus()
            Exit Sub
        End If
        If TXTUN.Text <> TXTDUN.Text Then
            OpenCon()
            cmd.CommandText = "Select * from tbl_users where username = '" & TXTUN.Text & "'"
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                MsgBox("Sorry username already exist!", vbOKOnly + vbCritical, "Error Saving")
                con.Close()
                TXTUN.Text = ""
                TXTUN.Focus()
                Exit Sub
            End If
        End If
        con.Close()


        con.Open()
        cmd.CommandText = "insert into tbl_users values (@ri, @un, @ut, @ui,  @st, @pw, @fn, @mn, @ln)"
        With cmd.Parameters
            .Clear()
            .AddWithValue("ri", TXTRI.Text)
            .AddWithValue("un", TXTUN.Text)
            .AddWithValue("ut", CBOACCTYPE.Text)
            .AddWithValue("ui", TXTUI.Text)
            .AddWithValue("st", CBOSTATUS.Text)
            .AddWithValue("pw", TXTPW.Text)
            .AddWithValue("fn", TXTFN.Text)
            .AddWithValue("mn", TXTMN.Text)
            .AddWithValue("ln", TXTLN.Text)


        End With
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("User information has been saved successfully!", vbOKOnly + vbInformation, "Saved Successfully!")
        activity = "Added new user. userID: " + TXTUI.Text
        actlog()
        con.Close()


        TXTUN.Text = ""
        CBOACCTYPE.Text = ""
        TXTUI.Text = ""
        TXTRI.Text = ""
        CBOSTATUS.Text = ""
        TXTPW.Text = ""
        TXTCP.Text = ""
        TXTFN.Text = ""
        TXTMN.Text = ""
        TXTLN.Text = ""
        TXTNAME.Text = ""
        CHKPASS.Checked = False


        TXTFN.Enabled = False
        TXTNAME.Enabled = False
        TXTMN.Enabled = False
        TXTLN.Enabled = False

        TXTCP.Enabled = False
        TXTPW.Enabled = False
        CBOSTATUS.Enabled = False
        DGVUSERS.Enabled = True


        LOADUSERS()
        ' refreshgrid()
    End Sub

    Private Sub BTNCANCEL_Click(sender As Object, e As EventArgs) Handles BTNCANCEL.Click





        TXTUN.Text = ""
        CBOACCTYPE.Text = ""
        TXTUI.Text = ""
        TXTRI.Text = ""
        CBOSTATUS.Text = ""
        TXTPW.Text = ""
        TXTCP.Text = ""
        TXTFN.Text = ""
        TXTMN.Text = ""
        TXTLN.Text = ""
        TXTNAME.Text = ""
        CBOACC.Text = ""
        PANELTYPE.Visible = False
        CHKPASS.Checked = False

        TXTFN.Enabled = False
        TXTNAME.Enabled = False
        TXTMN.Enabled = False
        TXTLN.Enabled = False

        TXTCP.Enabled = False
        TXTPW.Enabled = False
        CBOSTATUS.Enabled = False




    End Sub

    Private Sub BTNEDIT_Click(sender As Object, e As EventArgs) Handles BTNEDIT.Click

        PANELTYPE.Visible = False

        Using con As New MySqlConnection(“Server=localhost;Port=3306;User=root;Password=password;Database=inventory_db”)
            Using cmd As New MySqlCommand()
                cmd.Connection = con
                con.Open()

                cmd.CommandText = "UPDATE tbl_users SET usertype = @ut, refid = @ri, status = @st, password = @pw, firstname = @fn, middlename = @mn, lastname = @ln WHERE userid = @ui"

                cmd.Parameters.AddWithValue("@ut", CBOACC.Text)
                cmd.Parameters.AddWithValue("@ui", TXTUI.Text)
                cmd.Parameters.AddWithValue("@ri", TXTRI.Text)
                cmd.Parameters.AddWithValue("@st", CBOSTATUS.Text)
                cmd.Parameters.AddWithValue("@pw", TXTPW.Text)
                cmd.Parameters.AddWithValue("@fn", TXTFN.Text)
                cmd.Parameters.AddWithValue("@mn", TXTMN.Text)
                cmd.Parameters.AddWithValue("@ln", TXTLN.Text)

                cmd.ExecuteNonQuery()

                con.Close()
            End Using
        End Using



        MsgBox("User information has been edited successfully!", vbOKOnly + vbInformation, "Saved Successfully!")
        activity = "Updated a user. userID: " + TXTUI.Text
        actlog()
        LOADUSERS()

        BTNEDIT.Text = "Edit"


        BTNCANCEL.Enabled = False

        BTNSAVE.Visible = True
        BTNSAVE.Enabled = False


        CBOACCTYPE.Text = ""
        TXTUN.Text = ""
        TXTUI.Text = ""
        TXTRI.Text = ""
        CBOSTATUS.Text = ""
        TXTPW.Text = ""
        TXTCP.Text = ""
        TXTFN.Text = ""
        TXTMN.Text = ""
        TXTLN.Text = ""
        TXTNAME.Text = ""
        CHKPASS.Checked = False

        TXTUN.Enabled = False
        TXTFN.Enabled = False
        TXTNAME.Enabled = False
        TXTMN.Enabled = False
        TXTLN.Enabled = False

        TXTCP.Enabled = False
        TXTPW.Enabled = False
        CBOSTATUS.Enabled = False

    End Sub

    Private Sub CBOACCTYPE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOACCTYPE.SelectedIndexChanged

        BTNSAVE.Enabled = True
        BTNCANCEL.Enabled = True

        Getmax()
        AutoID()
        TXTFN.Focus()

        TXTUN.Enabled = True
        TXTFN.Enabled = True
        TXTNAME.Enabled = True
        TXTMN.Enabled = True
        TXTLN.Enabled = True

        TXTCP.Enabled = True
        TXTPW.Enabled = True
        CBOSTATUS.Enabled = True

    End Sub
    Private Sub searchuser()
        Dim dba As New MySqlDataAdapter("Select username, usertype, userid, refid, status, password, firstname, middlename, lastname from tbl_users WHERE tbl_users.username Like '%" & Me.txtsearch.Text & "%';", con)
        Dim dbset As New DataSet
        dba.Fill(dbset)
        Me.DGVUSERS.DataSource = dbset.Tables(0).DefaultView

    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        searchuser()
    End Sub

    Private Sub TXTFN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTFN.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Number or Special character is not allowed", MessageBoxIcon.Warning, "Error")
        End If
    End Sub
    Private Sub TXTMN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTMN.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Number or Special character is not allowed", MessageBoxIcon.Warning, "Invalid Format")
        End If
    End Sub
    Private Sub TXTLN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTLN.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Number or Special character is not allowed", MessageBoxIcon.Warning, "Invalid Format")
        End If
    End Sub

    Private Sub DGVUSERS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVUSERS.CellClick

        PANELTYPE.Visible = True

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DGVUSERS.Rows(e.RowIndex)
            TXTRI.Text = row.Cells(0).Value.ToString()
            TXTUN.Text = row.Cells(1).Value.ToString()
            CBOACCTYPE.Text = row.Cells(2).Value.ToString()
            CBOACC.Text = row.Cells(2).Value.ToString()
            TXTUI.Text = row.Cells(3).Value.ToString()
            CBOSTATUS.Text = row.Cells(4).Value.ToString()
            TXTPW.Text = row.Cells(5).Value.ToString()
            TXTCP.Text = row.Cells(5).Value.ToString()
            TXTFN.Text = row.Cells(6).Value.ToString()
            TXTMN.Text = row.Cells(7).Value.ToString()
            TXTLN.Text = row.Cells(8).Value.ToString()
        End If
        BTNEDIT.Text = "Save Edit"
        If BTNEDIT.Text = "Save Edit" Then BTNSAVE.Visible = False

        BTNEDIT.Enabled = True
        BTNCANCEL.Enabled = True

        TXTUN.Enabled = False
        TXTFN.Enabled = True
        TXTNAME.Enabled = True
        TXTMN.Enabled = True
        TXTLN.Enabled = True
        TXTCP.Enabled = True
        TXTPW.Enabled = True
        CBOSTATUS.Enabled = True
    End Sub
End Class
