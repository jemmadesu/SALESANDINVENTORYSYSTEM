Imports MySql.Data.MySqlClient
Public Class FRMMAINMENU
    Private Sub FRMMAINMENU_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If LBLUSERTYPE.Text = "Admin" Then

            BTNREPORTS.Enabled = True
            BTNSALES.Enabled = True
            BTNDASHBOARD.Enabled = True
            BTNINVENTORY.Enabled = True
            BTNSALES.Enabled = True
            BTNSETTINGS.Enabled = True
            BTNTRANSACTION.Enabled = True
        End If

        If LBLUSERTYPE.Text = "Cashier" Then


            BTNREPORTS.Enabled = False
            BTNSALES.Enabled = False
            BTNDASHBOARD.Enabled = True
            BTNINVENTORY.Enabled = False
            BTNSALES.Enabled = False
            BTNSETTINGS.Enabled = False
            BTNTRANSACTION.Enabled = True
        End If

        If LBLUSERTYPE.Text = "Manager" Then

            BTNREPORTS.Enabled = True
            BTNSALES.Enabled = True
            BTNDASHBOARD.Enabled = True
            BTNINVENTORY.Enabled = True
            BTNSALES.Enabled = True
            BTNSETTINGS.Enabled = True
            BTNTRANSACTION.Enabled = True
        End If

        Dim Dashboard As New ucDASHBOARD()
        Dashboard.Parent = PNLMAIN
        Dashboard.Show()
        Dashboard.Dock = DockStyle.Fill

        Timer1.Enabled = True
    End Sub
    Private Sub BTNLOGOUT_Click(sender As Object, e As EventArgs)
        FRMLOGIN.Show()
        Me.Close()
    End Sub

    Private Sub BTNTRANSACTION_Click(sender As Object, e As EventArgs) Handles BTNTRANSACTION.Click
        Dim i As Integer
        For i = 0 To 0
            PNLMAIN.Controls.RemoveAt(i)
        Next

        Dim TRANSACTION As New ucTRANSACTION()
        TRANSACTION.Parent = PNLMAIN
        TRANSACTION.Show()
        TRANSACTION.Dock = DockStyle.Fill


        BTNTRANSACTION.BackColor = Color.FromArgb(44, 55, 70)

        BTNINVENTORY.BackColor = Color.FromArgb(37, 46, 59)
        BTNDASHBOARD.BackColor = Color.FromArgb(37, 46, 59)
        BTNINVENTORY.BackColor = Color.FromArgb(37, 46, 59)
        BTNSALES.BackColor = Color.FromArgb(37, 46, 59)
        BTNSETTINGS.BackColor = Color.FromArgb(37, 46, 59)
        BTNLOGOUT.BackColor = Color.FromArgb(37, 46, 59)


    End Sub

    Private Sub BTNREPORTS_Click_1(sender As Object, e As EventArgs) Handles BTNSALES.Click
        Dim i As Integer
        For i = 0 To 0
            PNLMAIN.Controls.RemoveAt(i)
        Next

        Dim REPORTS As New ucSALES
        REPORTS.Parent = PNLMAIN
        REPORTS.Show()
        REPORTS.Dock = DockStyle.Fill


        BTNSALES.BackColor = Color.FromArgb(44, 55, 70)

        BTNINVENTORY.BackColor = Color.FromArgb(37, 46, 59)
        BTNTRANSACTION.BackColor = Color.FromArgb(37, 46, 59)
        BTNINVENTORY.BackColor = Color.FromArgb(37, 46, 59)
        BTNDASHBOARD.BackColor = Color.FromArgb(37, 46, 59)
        BTNSETTINGS.BackColor = Color.FromArgb(37, 46, 59)
        BTNLOGOUT.BackColor = Color.FromArgb(37, 46, 59)

    End Sub

    Private Sub BTNSETTINGS_Click_1(sender As Object, e As EventArgs) Handles BTNSETTINGS.Click
        Dim i As Integer
        For i = 0 To 0
            PNLMAIN.Controls.RemoveAt(i)
        Next

        Dim SETTINGS As New ucSETTINGS
        SETTINGS.Parent = PNLMAIN
        SETTINGS.Show()
        SETTINGS.Dock = DockStyle.Fill


        BTNSETTINGS.BackColor = Color.FromArgb(44, 55, 70)

        BTNINVENTORY.BackColor = Color.FromArgb(37, 46, 59)
        BTNTRANSACTION.BackColor = Color.FromArgb(37, 46, 59)
        BTNINVENTORY.BackColor = Color.FromArgb(37, 46, 59)
        BTNSALES.BackColor = Color.FromArgb(37, 46, 59)
        BTNDASHBOARD.BackColor = Color.FromArgb(37, 46, 59)
        BTNLOGOUT.BackColor = Color.FromArgb(37, 46, 59)

    End Sub

    Private Sub BTNLOGOUT_Click_1(sender As Object, e As EventArgs) Handles BTNLOGOUT.Click

        FRMLOGIN.Show()
        Me.Close()


        BTNLOGOUT.BackColor = Color.FromArgb(44, 55, 70)

        BTNINVENTORY.BackColor = Color.FromArgb(37, 46, 59)
        BTNTRANSACTION.BackColor = Color.FromArgb(37, 46, 59)
        BTNINVENTORY.BackColor = Color.FromArgb(37, 46, 59)
        BTNSALES.BackColor = Color.FromArgb(37, 46, 59)
        BTNSETTINGS.BackColor = Color.FromArgb(37, 46, 59)
        BTNDASHBOARD.BackColor = Color.FromArgb(37, 46, 59)




    End Sub
    Private Sub BTNINVENTORY_Click(sender As Object, e As EventArgs) Handles BTNINVENTORY.Click

        Dim i As Integer
        For i = 0 To 0
            PNLMAIN.Controls.RemoveAt(i)
        Next

        Dim INVENTORY As New ucPRODUCTLIST
        INVENTORY.Parent = PNLMAIN
        INVENTORY.Show()
        INVENTORY.Dock = DockStyle.Fill


        BTNINVENTORY.BackColor = Color.FromArgb(44, 55, 70)

        BTNDASHBOARD.BackColor = Color.FromArgb(37, 46, 59)
        BTNTRANSACTION.BackColor = Color.FromArgb(37, 46, 59)
        BTNDASHBOARD.BackColor = Color.FromArgb(37, 46, 59)
        BTNSALES.BackColor = Color.FromArgb(37, 46, 59)
        BTNSETTINGS.BackColor = Color.FromArgb(37, 46, 59)
        BTNLOGOUT.BackColor = Color.FromArgb(37, 46, 59)

    End Sub
    Private Sub BTNDASHBOARD_Click(sender As Object, e As EventArgs) Handles BTNDASHBOARD.Click
        Dim i As Integer
        For i = 0 To 0
            PNLMAIN.Controls.RemoveAt(i)
        Next

        Dim DASHBOARD As New ucDASHBOARD
        DASHBOARD.Parent = PNLMAIN
        DASHBOARD.Show()
        DASHBOARD.Dock = DockStyle.Fill



        BTNDASHBOARD.BackColor = Color.FromArgb(44, 55, 70)

        BTNINVENTORY.BackColor = Color.FromArgb(37, 46, 59)
        BTNTRANSACTION.BackColor = Color.FromArgb(37, 46, 59)
        BTNINVENTORY.BackColor = Color.FromArgb(37, 46, 59)
        BTNSALES.BackColor = Color.FromArgb(37, 46, 59)
        BTNSETTINGS.BackColor = Color.FromArgb(37, 46, 59)
        BTNLOGOUT.BackColor = Color.FromArgb(37, 46, 59)

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TIMEDATE.Text = Date.Now.ToString("MM-dd-yyyy hh:mm:ss tt ")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTNREPORTS.Click
        FRMREPORTS.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub LBLUSERNAME_Click(sender As Object, e As EventArgs) Handles LBLUSERNAME.Click

    End Sub
End Class
'MsgBox("you have near-expiry products on your inventory, do you want view products?", MessageBoxIcon.Information)
'If res = DialogResult.Yes Then

'    Dim i As Integer
'    For i = 0 To 0
'        PNLMAIN.Controls.RemoveAt(i)
'    Next

'    Dim exp As New ucNEAREXPIRY
'    exp.Parent = FRMMAINMENU.PNLMAIN
'    exp.Show()
'    exp.Dock = DockStyle.Fill

'End If