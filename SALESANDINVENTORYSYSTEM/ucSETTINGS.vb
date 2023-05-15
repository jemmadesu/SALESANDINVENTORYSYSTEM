
Imports MySql.Data.MySqlClient

Public Class ucSETTINGS

    Private Sub records()
        con.Close()
        OpenCon()
        cmd.CommandText = "insert into tbl_backuprecords values (NULL, @un, @ut, @dt)"
        With cmd.Parameters
            .Clear()
            .AddWithValue("un", FRMMAINMENU.LBLUSERNAME.Text)
            .AddWithValue("ut", FRMMAINMENU.LBLUSERTYPE.Text)
            .AddWithValue("dt", Format(Date.Now, "yyyy-MM-dd h:mm tt"))


            cmd.ExecuteNonQuery()
            con.Close()
        End With
    End Sub

    Private Sub DGVSET()
        DGVHISTORY.Columns(0).Width = 200
        DGVHISTORY.Columns(0).HeaderText = "Username"
        DGVHISTORY.Columns(1).Width = 200
        DGVHISTORY.Columns(1).HeaderText = "Usertype"
        DGVHISTORY.Columns(2).Width = 200
        DGVHISTORY.Columns(2).HeaderText = "Date"
    End Sub
    Private Sub VIEW()

        ' ------------------------------------------------------------ FOR DISPLAYING THE COLUMN HEADER (HISTORY) -------------------------------------------------
        Try

            Dim da As New MySqlDataAdapter("select username, usertype, date from tbl_backuprecords", con)
            Dim dt As New DataSet()
            da.Fill(dt)
            DGVHISTORY.DataSource = dt.Tables(0)

            DGVSET()
        Catch ex As Exception

            MessageBox.Show(ex.ToString())



        End Try


    End Sub


    Private Sub BunifuCustomDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            Console.WriteLine("Test")
        End If

    End Sub

    Private Sub ucSETTINGS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DGVHISTORY.EnableHeadersVisualStyles = False


        ' Set the header cell backcolor
        DGVHISTORY.ColumnHeadersDefaultCellStyle.BackColor = Color.White


        ' Set the header cell forecolor
        DGVHISTORY.ColumnHeadersDefaultCellStyle.ForeColor = Color.DimGray


        ' Disable the default column header cell selection
        DGVHISTORY.SelectionMode = DataGridViewSelectionMode.CellSelect
        DGVHISTORY.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White
        DGVHISTORY.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.DimGray

        VIEW()
    End Sub

    Private Sub BTNUM_Click_1(sender As Object, e As EventArgs) Handles BTNUM.Click
        Dim i As Integer
        For i = 0 To 0
            FRMMAINMENU.PNLMAIN.Controls.RemoveAt(i)
        Next

        Dim USER As New ucUSERMANAGEMENT()
        USER.Parent = FRMMAINMENU.PNLMAIN
        USER.Show()
        USER.Dock = DockStyle.Fill
    End Sub



    Private Sub BTNCATEGORY_Click_1(sender As Object, e As EventArgs)
        Dim i As Integer
        For i = 0 To 0
            FRMMAINMENU.PNLMAIN.Controls.RemoveAt(i)
        Next

        Dim CATEGORY As New ucCATEGORY()
        CATEGORY.Parent = FRMMAINMENU.PNLMAIN
        CATEGORY.Show()
        CATEGORY.Dock = DockStyle.Fill
    End Sub
    Private Sub BTNPI_Click(sender As Object, e As EventArgs) Handles BTNINVENTORY.Click
        Dim i As Integer
        For i = 0 To 0
            FRMMAINMENU.PNLMAIN.Controls.RemoveAt(i)
        Next

        Dim INVENTORY As New ucNEWPRODUCT
        INVENTORY.Parent = FRMMAINMENU.PNLMAIN
        INVENTORY.Show()
        INVENTORY.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNSTOCKIN_Click(sender As Object, e As EventArgs) Handles BTNSTOCKIN.Click
        Dim i As Integer
        For i = 0 To 0
            FRMMAINMENU.PNLMAIN.Controls.RemoveAt(i)
        Next

        Dim RESTOCK As New ucRESTOCK
        RESTOCK.Parent = FRMMAINMENU.PNLMAIN
        RESTOCK.Show()
        RESTOCK.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNSUP_Click(sender As Object, e As EventArgs) Handles BTNSUP.Click

        Dim i As Integer
        For i = 0 To 0
            FRMMAINMENU.PNLMAIN.Controls.RemoveAt(i)
        Next

        Dim SUPPLIER As New ucSUPPLIER
        SUPPLIER.Parent = FRMMAINMENU.PNLMAIN
        SUPPLIER.Show()
        SUPPLIER.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNBACKUP_Click_1(sender As Object, e As EventArgs) Handles BTNBACKUP.Click
        Dim backup As New SaveFileDialog
        backup.InitialDirectory = “C:\"
        backup.Title = "Database Backup”
        backup.CheckFileExists = False
        backup.CheckPathExists = False
        backup.DefaultExt = "sql"
        backup.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.*"
        backup.RestoreDirectory = True

        If backup.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim con As MySqlConnection = New MySqlConnection(“Server=localhost;Port=3306;User=root;Password=password;Database=inventory_db;charset=utf8”)
            Dim cmd As MySqlCommand = New MySqlCommand
            cmd.Connection = con
            con.Open()
            Dim mb As MySqlBackup = New MySqlBackup(cmd)
            mb.ExportToFile(backup.FileName)
            con.Close()
        ElseIf backup.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Return
        End If


        MessageBox.Show("Successfully created a Backup”, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        records()

        'FRMBACKUP.ShowDialog()

    End Sub

    Private Sub BTNRESTORE_Click_1(sender As Object, e As EventArgs) Handles BTNRESTORE.Click
        Dim restore As New OpenFileDialog
        restore.InitialDirectory = "C:\"
        restore.Title = "Restore Database”
        restore.CheckFileExists = False
        restore.CheckPathExists = False
        restore.DefaultExt = “sql”
        restore.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.*"
        restore.RestoreDirectory = True

        If restore.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim con As MySqlConnection = New MySqlConnection(“Server=localhost;Port=3306;User=root;Password=password;Database=restore_db;charset=utf8”)
            Dim cmd As MySqlCommand = New MySqlCommand
            cmd.Connection = con
            con.Open()
            Dim restoreDB As MySqlBackup = New MySqlBackup(cmd)
            restoreDB.ImportFromFile(restore.FileName)
            con.Close()

            MessageBox.Show("Successfully restored the database”, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        'FRMRESTORE.ShowDialog()
    End Sub

    Private Sub LBLHISTORY_Click(sender As Object, e As EventArgs) Handles LBLHISTORY.Click
        PNLHISTORY.Visible = True
    End Sub

    Private Sub LBLCLOSE_Click(sender As Object, e As EventArgs) Handles LBLCLOSE.Click
        PNLHISTORY.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim i As Integer
        For i = 0 To 0
            FRMMAINMENU.PNLMAIN.Controls.RemoveAt(i)
        Next

        Dim MANUFACTURER As New ucMANUFACTURER
        MANUFACTURER.Parent = FRMMAINMENU.PNLMAIN
        MANUFACTURER.Show()
        MANUFACTURER.Dock = DockStyle.Fill
    End Sub
End Class
