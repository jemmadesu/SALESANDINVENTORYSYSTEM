Imports MySql.Data.MySqlClient

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
        cmd.CommandText = "Select * from tbl_users where username = '" & TXTUN.Text & "' and password = '" & TXTPW.Text & "' and status = '" & status & "' "
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader

        ''Admin 
        If dr.HasRows Then
            dr.Read()
            FRMMAINMENU.LBLUSERNAME.Text = TXTUN.Text
            If dr(1) = "Admin" Then
                activity = "Logged-in"

                FRMMAINMENU.LBLUSERTYPE.Text = "Admin"
                actlog()
                FRMMAINMENU.Show()
                Me.Close()


                '' Cashier
            ElseIf dr(1) = "Cashier" Then
                activity = "Logged-in"
                FRMMAINMENU.LBLUSERTYPE.Text = "Cashier"
                actlog()
                FRMMAINMENU.Show()
                Me.Close()


                '' Manager
            ElseIf dr(1) = "Manager" Then
                activity = "Logged-in"
                FRMMAINMENU.LBLUSERTYPE.Text = "Manager"
                actlog()
                FRMMAINMENU.Show()
                Me.Close()


            End If
        Else
            MsgBox("Sorry wrong username and password", vbOKOnly + vbCritical, "Error login")
            TXTUN.Text = ""
            TXTPW.Text = ""
            TXTUN.Focus()
        End If
        con.Close()


        If FRMMAINMENU.LBLUSERTYPE.Text = "Admin" Then


            ' ' NOTIF FOR NEAR_EXPIRY
            con.Open()
            cmd.CommandText = "select prodid, prodname, unit, quantity, expirationdate, datediff(expirationdate, now()) as remaining_days from tbl_products where expirationdate > curdate() and expirationdate <= date_add(curdate(), interval 10 day);"
            cmd.Parameters.Clear()
            cmd.ExecuteNonQuery()
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                Dim res As DialogResult
                res = MessageBox.Show("you have near-expiry products on your inventory, do you want view products?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                If res = DialogResult.Yes Then
                    FRMNEAREXPIRY.Show()
                    con.Close()
                End If
            End If


            '' LOW QTY
            con.Close()
            con.Open()
            cmd.CommandText = "select stockid, prodid, prodname, prodman, prodbrand, prodcat, catcode, price, unit, quantity, expirationdate from tbl_products WHERE quantity < 10;"
            cmd.Parameters.Clear()
            cmd.ExecuteNonQuery()
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                Dim reslow As DialogResult
                reslow = MessageBox.Show("you have out of stocks products on your inventory, do you want view products?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                If reslow = DialogResult.Yes Then
                    FRMLOWQTY.ShowDialog()
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

    Private Sub FRMLOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class



