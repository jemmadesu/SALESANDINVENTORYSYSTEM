
Imports MySql.Data.MySqlClient

Public Class ucSETTINGS

    Private Sub VIEW()

        ' ------------------------------------------------------------ FOR DISPLAYING THE COLUMN HEADER (PRODUCTS) -------------------------------------------------


    End Sub


    Private Sub BunifuCustomDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            Console.WriteLine("Test")
        End If

    End Sub

    Private Sub ucSETTINGS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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



    Private Sub BTNCATEGORY_Click_1(sender As Object, e As EventArgs) Handles BTNCATEGORY.Click
        Dim i As Integer
        For i = 0 To 0
            FRMMAINMENU.PNLMAIN.Controls.RemoveAt(i)
        Next

        Dim CATEGORY As New ucCATEGORY()
        CATEGORY.Parent = FRMMAINMENU.PNLMAIN
        CATEGORY.Show()
        CATEGORY.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNINVENTORY_Click_1(sender As Object, e As EventArgs) Handles BTNINVENTORY.Click
        Dim i As Integer
        For i = 0 To 0
            FRMMAINMENU.PNLMAIN.Controls.RemoveAt(i)
        Next

        Dim INVENTORY As New ucNEWPRODUCT
        INVENTORY.Parent = FRMMAINMENU.PNLMAIN
        INVENTORY.Show()
        INVENTORY.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNPI_Click(sender As Object, e As EventArgs) Handles BTNPI.Click
        Dim i As Integer
        For i = 0 To 0
            FRMMAINMENU.PNLMAIN.Controls.RemoveAt(i)
        Next

        Dim STOCKIN As New ucPUTINTOINVENTORY
        STOCKIN.Parent = FRMMAINMENU.PNLMAIN
        STOCKIN.Show()
        STOCKIN.Dock = DockStyle.Fill
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

    Private Sub BTNBACKUP_Click(sender As Object, e As EventArgs) Handles BTNBACKUP.Click
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
    End Sub

    Private Sub BTNRESTORE_Click(sender As Object, e As EventArgs) Handles BTNRESTORE.Click
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

    End Sub
End Class
