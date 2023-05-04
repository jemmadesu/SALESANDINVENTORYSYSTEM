Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Imports System.IO


Public Class ucUSERMANAGEMENT
    Dim con_str As String = "My.Settings.inventory_dbConnectionString"

    Private Sub DGVSETPROPERTY()
        DGVUSERS.Columns(0).Width = 150
        DGVUSERS.Columns(0).HeaderText = "Username"
        DGVUSERS.Columns(1).Width = 150
        DGVUSERS.Columns(1).HeaderText = "User Type"
        DGVUSERS.Columns(2).Width = 150
        DGVUSERS.Columns(2).HeaderText = "User ID"
        DGVUSERS.Columns(3).Width = 150
        DGVUSERS.Columns(3).HeaderText = "Reference ID"
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
        DGVUSERS.Columns(9).Width = 150
        DGVUSERS.Columns(9).HeaderText = "Telephone No."
        DGVUSERS.Columns(10).Width = 150
        DGVUSERS.Columns(10).HeaderText = "E-Mail"
        DGVUSERS.Columns(11).Width = 150
        DGVUSERS.Columns(11).HeaderText = "Address"
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
            TXTUI.Text = "USER" + "ADM" + "01" + TXTRI.Text

        Else
        End If
        If CBOACCTYPE.Text = "Cashier" Then
            TXTUI.Text = "USER" + "CHR" + "02" + TXTRI.Text

        End If

        If CBOACCTYPE.Text = "Manager" Then
            TXTUI.Text = "USER" + "MNG" + "03" + TXTRI.Text

        End If
    End Sub
    Private Sub ucUSERMANAGEMENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOADUSERS()
    End Sub


    Private Sub LOADUSERS()
        Try
            Dim da As New MySqlDataAdapter("select username, usertype, userid, refid, status, password, firstname, middlename, lastname, telno, email, address from tbl_users", con)
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

    Private Sub DGVUSERS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVUSERS.CellContentClick
        BTNDELETE.Enabled = True
        BTNEDIT.Text = "Save Edit"
        If BTNEDIT.Text = "Save Edit" Then BTNSAVE.Visible = False

        BTNEDIT.Enabled = True
        BTNCANCEL.Enabled = True


        TXTFN.Enabled = True
        TXTNAME.Enabled = True
        TXTMN.Enabled = True
        TXTLN.Enabled = True
        TXTTEL.Enabled = True
        TXTEMAIL.Enabled = True
        TXTADDRESS.Enabled = True
        TXTUN.Enabled = True
        TXTCP.Enabled = True
        TXTPW.Enabled = True
        CBOSTATUS.Enabled = True



        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow


            row = DGVUSERS.Rows(e.RowIndex)

            TXTUN.Text = row.Cells(0).Value
            CBOACCTYPE.Text = row.Cells(1).Value
            TXTUI.Text = row.Cells(2).Value
            TXTRI.Text = row.Cells(3).Value
            CBOSTATUS.Text = row.Cells(4).Value
            TXTPW.Text = row.Cells(5).Value
            TXTCP.Text = row.Cells(5).Value
            TXTFN.Text = row.Cells(6).Value
            TXTMN.Text = row.Cells(7).Value
            TXTLN.Text = row.Cells(8).Value
            TXTTEL.Text = row.Cells(9).Value
            TXTEMAIL.Text = row.Cells(10).Value
            TXTADDRESS.Text = row.Cells(11).Value

        End If
    End Sub

    Private Sub BTNDELETE_Click(sender As Object, e As EventArgs) Handles BTNDELETE.Click
        ' NOT WORKING 
        For i As Integer = 0 To DGVUSERS.SelectedRows.Count - 1
            Dim cmd As New MySqlCommand("delete from tbl_users where userid = @userid ", con)
            cmd.Parameters.AddWithValue("userid", DGVUSERS.SelectedRows(i).Cells(2).Value.ToString())
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Next
        LOADUSERS()
        MessageBox.Show("user deleted succesfully")
        activity = "deleted a user. user ID:" + TXTUI.Text



        actlog()

    End Sub
    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click


        'ERROR TRAPPING

        Getmax()
        AutoID()

        TXTNAME.Text = TXTFN.Text + " " + TXTMN.Text + " " + TXTLN.Text

        If CBOACCTYPE.Text = "" Or CBOSTATUS.Text = "" Or TXTUI.Text = "" Or TXTMN.Text = "" Or TXTLN.Text = "" Or TXTTEL.Text = "" Or TXTEMAIL.Text = "" Or TXTUN.Text = "" Or TXTCP.Text = "" Or TXTRI.Text = "" Then
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
            con.Close()
        End If



        OpenCon()
        cmd.CommandText = "insert into tbl_users values (@un, @ut, @ui, @ri, @st, @pw, @fn, @mn, @ln, @tel, @mail, @add)"
        With cmd.Parameters
            .Clear()
            .AddWithValue("un", TXTUN.Text)
            .AddWithValue("ut", CBOACCTYPE.Text)
            .AddWithValue("ui", TXTUI.Text)
            .AddWithValue("ri", TXTRI.Text)
            .AddWithValue("st", CBOSTATUS.Text)
            .AddWithValue("pw", TXTPW.Text)
            .AddWithValue("fn", TXTFN.Text)
            .AddWithValue("mn", TXTMN.Text)
            .AddWithValue("ln", TXTLN.Text)
            .AddWithValue("tel", TXTTEL.Text)
            .AddWithValue("mail", TXTEMAIL.Text)
            .AddWithValue("add", TXTADDRESS.Text)



        End With
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("New user has been saved!", vbOKOnly + vbInformation, "Saving Successful")
        activity = "Added new user. userID: " + TXTUI.Text
        actlog()

        con.Close()


        'Function_Disabled()
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
        TXTTEL.Text = ""
        TXTEMAIL.Text = ""
        TXTADDRESS.Text = ""
        TXTNAME.Text = ""
        CHKPASS.Checked = False


        TXTFN.Enabled = False
        TXTNAME.Enabled = False
        TXTMN.Enabled = False
        TXTLN.Enabled = False
        TXTTEL.Enabled = False
        TXTEMAIL.Enabled = False
        TXTADDRESS.Enabled = False
        TXTUN.Enabled = False
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
        TXTTEL.Text = ""
        TXTEMAIL.Text = ""
        TXTADDRESS.Text = ""
        TXTNAME.Text = ""
        CHKPASS.Checked = False

        TXTFN.Enabled = False
        TXTNAME.Enabled = False
        TXTMN.Enabled = False
        TXTLN.Enabled = False
        TXTTEL.Enabled = False
        TXTEMAIL.Enabled = False
        TXTADDRESS.Enabled = False
        TXTUN.Enabled = False
        TXTCP.Enabled = False
        TXTPW.Enabled = False
        CBOSTATUS.Enabled = False
        DGVUSERS.Enabled = True



    End Sub

    Private Sub BTNEDIT_Click(sender As Object, e As EventArgs) Handles BTNEDIT.Click

        con.Open()
        cmd.CommandText = "Update tbl_users set username=@un, usertype=@ut, userid=@ui, refid=@ri, status=@st, password=@pw, firstname=@fn, middlename=@mn, lastname=@ln, telno=@tel, email=@mail, address=@add where userid= @ui"

        With cmd.Parameters
            .Clear()
            .AddWithValue("un", TXTUN.Text)
            .AddWithValue("ut", CBOACCTYPE.Text)
            .AddWithValue("ui", TXTUI.Text)
            .AddWithValue("ri", TXTRI.Text)
            .AddWithValue("st", CBOSTATUS.Text)
            .AddWithValue("pw", TXTPW.Text)
            .AddWithValue("fn", TXTFN.Text)
            .AddWithValue("mn", TXTMN.Text)
            .AddWithValue("ln", TXTLN.Text)
            .AddWithValue("tel", TXTTEL.Text)
            .AddWithValue("mail", TXTEMAIL.Text)
            .AddWithValue("add", TXTADDRESS.Text)
        End With
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("New user has been updated!", vbOKOnly + vbInformation, "Saving Successful")
        activity = "Updated a user. userID: " + TXTUI.Text
        actlog()
        LOADUSERS()

        BTNEDIT.Text = "Edit"


        BTNCANCEL.Enabled = False

        BTNSAVE.Visible = True
        BTNSAVE.Enabled = False

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
        TXTTEL.Text = ""
        TXTEMAIL.Text = ""
        TXTADDRESS.Text = ""
        TXTNAME.Text = ""
        CHKPASS.Checked = False

        TXTFN.Enabled = False
        TXTNAME.Enabled = False
        TXTMN.Enabled = False
        TXTLN.Enabled = False
        TXTTEL.Enabled = False
        TXTEMAIL.Enabled = False
        TXTADDRESS.Enabled = False
        TXTUN.Enabled = False
        TXTCP.Enabled = False
        TXTPW.Enabled = False
        CBOSTATUS.Enabled = False
        DGVUSERS.Enabled = True
    End Sub

    Private Sub CBOACCTYPE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOACCTYPE.SelectedIndexChanged

        BTNSAVE.Enabled = True
        DGVUSERS.Enabled = False
        BTNCANCEL.Enabled = True

        Getmax()
        AutoID()

        TXTUN.Text = ""
        TXTPW.Text = ""
        TXTCP.Text = ""
        TXTFN.Text = ""
        TXTMN.Text = ""
        TXTLN.Text = ""
        TXTTEL.Text = ""
        TXTEMAIL.Text = ""
        TXTADDRESS.Text = ""
        TXTFN.Focus()

        TXTFN.Enabled = True
        TXTNAME.Enabled = True
        TXTMN.Enabled = True
        TXTLN.Enabled = True
        TXTTEL.Enabled = True
        TXTEMAIL.Enabled = True
        TXTADDRESS.Enabled = True
        TXTUN.Enabled = True
        TXTCP.Enabled = True
        TXTPW.Enabled = True
        CBOSTATUS.Enabled = True
        Exit Sub
        'End If
    End Sub

    Private Sub CBOSTATUS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOSTATUS.SelectedIndexChanged

    End Sub

    Private Sub searchuser()
        Dim dba As New MySqlDataAdapter("Select username, usertype, userid, refid, status, password, firstname, middlename, lastname, telno, email, address from tbl_users WHERE tbl_users.username Like '%" & Me.txtsearch.Text & "%';", con)
        Dim dbset As New DataSet
        dba.Fill(dbset)
        Me.DGVUSERS.DataSource = dbset.Tables(0).DefaultView

    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        searchuser()
    End Sub

    Private Sub TXTTEL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTTEL.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MsgBox("Letter or Special character is not allowed", vbCritical, "Error")
        End If
        If TXTTEL.Text.Length >= 12 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MsgBox("Number Exceed", vbCritical, "Error")
            End If
        End If
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

    Private Sub TXTEMAIL_Validating(sender As Object, e As CancelEventArgs) Handles TXTEMAIL.Validating
        ' Get the entered email address from the TextBox
        Dim emailAddress As String = TXTEMAIL.Text.Trim()

        ' Check if the email address is in a valid format
        If Not IsValidEmail(emailAddress) Then
            ' Display a warning message and cancel the event to prevent the TextBox from losing focus
            MessageBox.Show("The email address you entered is not in a valid format. Please enter a valid email address.", "Invalid Email Address", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Cancel = True
        End If
    End Sub

    ' Helper function to check if an email address is in a valid format
    Private Function IsValidEmail(ByVal emailAddress As String) As Boolean
        Dim emailRegex As New System.Text.RegularExpressions.Regex("^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$")
        Return emailRegex.IsMatch(emailAddress)
    End Function

    Private Sub TXTADDRESS_Validating(sender As Object, e As CancelEventArgs) Handles TXTADDRESS.Validating
        ' Get the entered address from the TextBox
        Dim address As String = TXTADDRESS.Text.Trim()

        ' Check if the address is in a valid format
        If Not IsValidAddress(address) Then
            ' Display a warning message and cancel the event to prevent the TextBox from losing focus
            MessageBox.Show("The address you entered is not in a valid format. Please enter a valid address.", "Invalid Address", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Cancel = True
        End If
    End Sub

    ' Helper function to check if an address is in a valid format
    Private Function IsValidAddress(ByVal address As String) As Boolean
        ' Check if the address is null or empty
        If String.IsNullOrEmpty(address) Then
            Return False
        End If

        ' Check if the address contains only letters, numbers, spaces, commas, and periods
        Dim validChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 ,."
        For Each c As Char In address
            If Not validChars.Contains(c) Then
                Return False
            End If
        Next

        ' Check if the address contains at least one letter or number
        If Not address.Any(Function(c) Char.IsLetterOrDigit(c)) Then
            Return False
        End If

        ' Check if the address starts with a number or letter
        If Not Char.IsLetterOrDigit(address(0)) Then
            Return False
        End If

        Return True
    End Function

End Class
