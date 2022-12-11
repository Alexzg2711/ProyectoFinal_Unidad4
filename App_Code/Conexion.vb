Imports MySql.Data.MySqlClient
Imports System.Data
Public Class Conexion

    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable
    Public result As String

    Public Function Strconexion() As MySqlConnection
        Return New MySqlConnection("server=localhost;userid=ugb;password=ugb2022;database=academica;port=3306")
    End Function

    Public strcon As MySqlConnection = Strconexion()


End Class
