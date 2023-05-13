Imports MySql.Data.MySqlClient
Public Class ucSUPPLIER

    Private Sub DGVSET()

        DGVSUP.Columns(0).Width = 200
        DGVSUP.Columns(0).HeaderText = "Ref. No"
        DGVSUP.Columns(1).Width = 200
        DGVSUP.Columns(1).HeaderText = "Company Name"
        DGVSUP.Columns(2).Width = 200
        DGVSUP.Columns(2).HeaderText = "Name"
        DGVSUP.Columns(3).Width = 200
        DGVSUP.Columns(3).HeaderText = "Tel No."
        DGVSUP.Columns(4).Width = 200
        DGVSUP.Columns(4).HeaderText = "Status"



    End Sub
    Private Sub load_data()
        Try

            Dim da As New MySqlDataAdapter("select RefNo, Companyname, name, telno, status from tbl_supplier ", con)
            Dim dt As New DataSet()
            da.Fill(dt)
            DGVSUP.DataSource = dt.Tables(0)

            DGVSET()
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


        If TXTCOM.Text = "" Or TXTNAME.Text = "" Or TXTTEL.Text = "" Then
            MsgBox("All fields are required!", vbOKOnly + vbCritical, "Error Saving")
            TXTCOM.Focus()
            Exit Sub
        End If

        OpenCon()
        cmd.CommandText = "insert into tbl_supplier (Companyname, name, telno, status ) values (@COM, @NN, @TEL, @ST)"
        With cmd.Parameters

            .Clear()

            .AddWithValue("COM", TXTCOM.Text)
            .AddWithValue("NN", TXTNAME)
            .AddWithValue("TEL", TXTTEL.Text)
            .AddWithValue("ST", CBOSTATUS.Text)

        End With
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("New Supplier has been saved!", vbOKOnly + vbInformation, "Saving Successful")
        activity = "Added new supplier. Company Name: " + TXTCOM.Text
        actlog()

        TXTCOM.Text = ""
        TXTNAME.Text = ""
        TXTTEL.Text = ""
        CBOSTATUS.Text = ""

        load_data()
    End Sub

    Private Sub ucSUPPLIER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Close()
        load_data()
    End Sub

    Private Sub BTNEDIT_Click(sender As Object, e As EventArgs) Handles BTNEDIT.Click
        If TXTCOM.Text = "" Or TXTNAME.Text = "" Or TXTTEL.Text = "" Then
            MsgBox("All fields are required!", vbOKOnly + vbCritical, "Error Saving")
            TXTCOM.Focus()
            Exit Sub
        End If

        Dim selectedRow As DataGridViewRow = DGVSUP.SelectedRows(0)
        Dim refNoValue As String = selectedRow.Cells(0).Value.ToString()


        OpenCon()
        cmd.CommandText = "UPDATE tbl_supplier SET Companyname = @COM, name = @NN, telno = @TEL, status = @ST WHERE RefNo = @REF"

        With cmd.Parameters
            .Clear()
            .AddWithValue("COM", TXTCOM.Text)
            .AddWithValue("NN", TXTNAME.Text)
            .AddWithValue("TEL", TXTTEL.Text)
            .AddWithValue("ST", CBOSTATUS.Text)
            .AddWithValue("REF", refNoValue) ' Replace REFNoValue with the actual value of RefNo
        End With

        cmd.ExecuteNonQuery()
        con.Close()

        MsgBox("Record has been updated!", vbOKOnly + vbInformation, "Editing Successful")

        TXTCOM.Text = ""
        TXTNAME.Text = ""
        CBOSTATUS.Text = ""
        TXTTEL.Text = ""
        load_data()

        BTNSAVE.Enabled = True
    End Sub

    'Private Sub BTNDELETE_Click(sender As Object, e As EventArgs)

    '    If MessageBox.Show("Are you sure to remove this from the Supplier Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = DialogResult.No Then
    '        Exit Sub
    '    End If

    '    For i As Integer = 0 To DGVSUP.SelectedRows.Count - 1
    '        Dim cmd As New MySqlCommand("delete from tbl_supplier where PhoneNo = @PN ", con)
    '        cmd.Parameters.AddWithValue("PN", DGVSUP.SelectedRows(i).Cells(4).Value.ToString())
    '        con.Open()
    '        cmd.ExecuteNonQuery()
    '        con.Close()
    '    Next
    '    load_data()
    '    MessageBox.Show("data deleted succesfully")
    '    activity = "deleted a supplier. Manufacturer Name: " + TXTCOM.Text
    '    actlog()
    '    TXTCOM.Text = ""
    '    TXTFN.Text = ""
    '    TXTLN.Text = ""
    '    TXTSTATUS.Text = ""
    '    TXTADD.Text = ""
    '    load_data()

    'End Sub
    Private Sub BTNCANCEL_Click(sender As Object, e As EventArgs) Handles BTNCANCEL.Click
        TXTCOM.Text = ""
        TXTNAME.Text = ""
        CBOSTATUS.Text = ""
        TXTTEL.Text = ""
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
        Dim dba As New MySqlDataAdapter("select RefNo, Companyname, name, telno, status from tbl_supplier WHERE tbl_supplier.companyname LIKE '%" & Me.TXTSEARCH.Text & "%';", con)
        Dim dbset As New DataSet
        dba.Fill(dbset)
        Me.DGVSUP.DataSource = dbset.Tables(0).DefaultView
    End Sub
    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        search()
    End Sub

    Private Sub DGVSUP_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSUP.CellContentClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = DGVSUP.Rows(e.RowIndex)


            TXTCOM.Text = row.Cells(1).Value
            TXTNAME.Text = row.Cells(2).Value
            TXTTEL.Text = row.Cells(3).Value
            CBOSTATUS.Text = row.Cells(4).Value

        End If
        BTNEDIT.Text = "Update"
        BTNSAVE.Enabled = False
    End Sub
    Private Sub TXTFN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTNAME.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Number or Special character is not allowed", MessageBoxIcon.Warning, "Error")
        End If
    End Sub

    Private Sub TXTLN_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Number or Special character is not allowed", MessageBoxIcon.Warning, "Error")
        End If
    End Sub

    Private Sub CBOSTATUS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOSTATUS.SelectedIndexChanged

    End Sub

    'Private Sub TXTEMAIL_Validating(sender As Object, e As CancelEventArgs) Handles TXTEMAIL.Validating
    '    ' Get the entered email address from the TextBox
    '    Dim emailAddress As String = TXTEMAIL.Text.Trim()

    '    ' Check if the email address is in a valid format
    '    If Not IsValidEmail(emailAddress) Then
    '        ' Display a warning message and cancel the event to prevent the TextBox from losing focus
    '        Dim res As DialogResult
    '        res = MessageBox.Show("The email address you entered is not in a valid format. Please enter a valid email address.", "Invalid Email Address", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
    '        'e.Cancel = True
    '        'If res = DialogResult.Cancel Then
    '        'End If
    '    End If
    'End Sub

    '' Helper function to check if an email address is in a valid format
    'Private Function IsValidEmail(ByVal emailAddress As String) As Boolean
    '    Dim emailRegex As New System.Text.RegularExpressions.Regex("^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$")
    '    Return emailRegex.IsMatch(emailAddress)
    'End Function

    'Private Sub TXTADD_Validating(sender As Object, e As CancelEventArgs) Handles TXTADD.Validating
    '    ' Get the entered address from the TextBox
    '    Dim address As String = TXTADD.Text.Trim()

    '    ' Check if the address is in a valid format
    '    If Not IsValidAddress(address) Then
    '        ' Display a warning message and cancel the event to prevent the TextBox from losing focus
    '        MessageBox.Show("The address you entered is not in a valid format. Please enter a valid address.", "Invalid Address", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
    '        'e.Cancel = True
    '    End If
    'End Sub

    '' Helper function to check if an address is in a valid format
    'Private Function IsValidAddress(ByVal address As String) As Boolean
    '    ' Check if the address is null or empty
    '    If String.IsNullOrEmpty(address) Then
    '        Return False
    '    End If

    '    ' Check if the address contains only letters, numbers, spaces, commas, and periods
    '    Dim validChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 ,."
    '    For Each c As Char In address
    '        If Not validChars.Contains(c) Then
    '            Return False
    '        End If
    '    Next

    '    ' Check if the address contains at least one letter or number
    '    If Not address.Any(Function(c) Char.IsLetterOrDigit(c)) Then
    '        Return False
    '    End If

    '    ' Check if the address starts with a number or letter
    '    If Not Char.IsLetterOrDigit(address(0)) Then
    '        Return False
    '    End If

    '    Return True
    'End Function
End Class
