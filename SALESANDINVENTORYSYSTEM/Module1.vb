
Imports MySql.Data.MySqlClient
Module Module1
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public adapter As MySqlDataAdapter

    Public activity As String
    Public Discount As String
    Public Discounted As String
    Sub OpenCon()
        con.ConnectionString = My.Settings.inventory_dbConnectionString
        con.Open()
        cmd.Connection = con
    End Sub
End Module


