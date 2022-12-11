Imports Microsoft.VisualBasic
Imports System.Data
Public Class Alumno
    'Instancia de la clase conexion
    Dim con As New Conexion

    'Declaracion de propiedades de la clase
    Private CodigoAlumno As String
    Private NombreAlumno As String
    Private ApellidoAlumno As String
    Private Pagina As Page

    'Metodos de propiedad
    Public Property CodAlumno() As String
        Get
            Return CodigoAlumno
        End Get
        Set(value As String)
            CodigoAlumno = value
        End Set
    End Property

    Public Property NomAlumno() As String
        Get
            Return NombreAlumno
        End Get
        Set(value As String)
            NombreAlumno = value
        End Set
    End Property

    Public Property ApeAlumno() As String
        Get
            Return ApellidoAlumno
        End Get
        Set(value As String)
            ApellidoAlumno = value
        End Set
    End Property
    Public Function ListarRegistros() As DataTable
    'c hace referencia a la instancia de la clase conexion
    con.strcon.Open()
    With con.cmd
        .Connection = con.strcon
        .CommandText = "Select codAlumno, Nomalumno, ApeAlumno FROM Alumno"
    End With
    con.da.SelectCommand = con.cmd
    con.da.Fill(con.dt)
        Return con.dt
    End Function
End Class
