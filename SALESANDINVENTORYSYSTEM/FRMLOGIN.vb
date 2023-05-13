Public Class FRMLOGIN


    Dim status As String = "Active"
    Dim admin As String = "Admin"
    Dim Cashier As String = "Cashier"
    Dim manager As String = "Manager"

    Private Sub actlog()
        con.Close()
        OpenCon()
        cmd.CommandText = "insert into tbl_actlog values (@un, @ut, @act, @dt)"
        With cmd.Parameters
            .Clear()
            .AddWithValue("un", TXTUN.Text)
            .AddWithValue("ut", FRMMAINMENU.LBLUSERTYPE.Text)
            .AddWithValue("act", activity)
            .AddWithValue("dt", Format(Date.Now, "yyyy-MM-dd h:mm tt"))


            cmd.ExecuteNonQuery()
            con.Close()
        End With
    End Sub


    Private Sub BTNLOGIN_Click_1(sender As Object, e As EventArgs) Handles BTNLOGIN.Click

        OpenCon()
        cmd.CommandText = "SELECT * FROM tbl_users WHERE username = '" & TXTUN.Text & "' AND password = '" & TXTPW.Text & "'"
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            dr.Read()
            If dr("status").ToString() = "Active" Then
                FRMMAINMENU.LBLUSERNAME.Text = TXTUN.Text

                If dr("usertype").ToString() = "Admin" Then
                    activity = "Logged-in"
                    FRMMAINMENU.LBLUSERTYPE.Text = "Admin"
                    actlog()
                    FRMMAINMENU.Show()
                    Me.Close()
                ElseIf dr("usertype").ToString() = "Cashier" Then
                    activity = "Logged-in"
                    FRMMAINMENU.LBLUSERTYPE.Text = "Cashier"
                    actlog()
                    FRMMAINMENU.Show()
                    Me.Close()
                ElseIf dr("usertype").ToString() = "Manager" Then
                    activity = "Logged-in"
                    FRMMAINMENU.LBLUSERTYPE.Text = "Manager"
                    actlog()
                    FRMMAINMENU.Show()
                    Me.Close()
                End If
            Else
                MsgBox("Your account is deactivated. Please contact the administrator.", vbOKOnly + vbExclamation, "Account Deactivated")
                TXTUN.Text = ""
                TXTPW.Text = ""
                TXTUN.Focus()
            End If
        Else
            MsgBox("Sorry, wrong username and password", vbOKOnly + vbCritical, "Error login")
            TXTUN.Text = ""
            TXTPW.Text = ""
            TXTUN.Focus()
        End If

        dr.Close()
        con.Close()


        If FRMMAINMENU.LBLUSERTYPE.Text = "Manager" Then


            ' ' NOTIF FOR NEAR_EXPIRY
            con.Open()
            cmd.CommandText = "select prodcode, prodname, unit, quantity, expirationdate, datediff(expirationdate, now()) as remaining_days from tbl_stocks where expirationdate > curdate() and expirationdate <= date_add(curdate(), interval 10 day);"
            cmd.Parameters.Clear()
            cmd.ExecuteNonQuery()
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                Dim res As DialogResult
                res = MessageBox.Show("Please check if you have near-expiry products on your inventory, do you want view products?", "Notify Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2)
                If res = DialogResult.Yes Then
                    FRMNEAREXPIRY.Show()
                    con.Close()
                End If
            End If


            '' LOW QTY
            con.Close()
            con.Open()
            cmd.CommandText = "select prodcode, prodname, manufacturer, brand, category, catcode, price, unit, quantity, expirationdate from tbl_Stocks WHERE quantity < 10;"
            cmd.Parameters.Clear()
            cmd.ExecuteNonQuery()
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                Dim reslow As DialogResult
                reslow = MessageBox.Show("Please check if you have products that is already running out of stocks on your inventory, do you want yo view the products?", "Notify Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2)
                If reslow = DialogResult.Yes Then
                    FRMOUTOFSTOCKS.ShowDialog()
                End If
                con.Close()
            End If
        End If

        con.Close()
    End Sub
    Private Sub CHKPASS_CheckedChanged(sender As Object, e As EventArgs) Handles CHKPASS.CheckedChanged
        If CHKPASS.Checked = False Then
            TXTPW.PasswordChar = "*"
        Else
            TXTPW.PasswordChar = ""
        End If
    End Sub

    Private Sub BTNCANCEL_Click(sender As Object, e As EventArgs) Handles BTNCANCEL.Click
        TXTPW.Text = ""
        TXTUN.Text = ""
    End Sub



    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
    End Sub


End Class



