
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
End Class
