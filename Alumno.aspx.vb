Partial Class alumno1
    Inherits System.Web.UI.Page
    Dim Alumno As New Alumno
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            'Llenar datable con la base de datos.
            Dim dt As DataTable = Alumno.ListarRegistros()

            'Construyendo HTML string
            Dim html As New StringBuilder()

            'Inicia la creacion de la tabla
            html.Append("<table class='table table-striped'>")

            'Agregando encabezado a la tabla
            html.Append("<thead>")
            html.Append("<tr>")
            html.Append("<tr>Codigo</tr>")
            html.Append("<tr>Nombre</tr>")
            html.Append("<tr>Apellido</tr>")
            html.Append("</tr>")
            html.Append("</thead>")
            html.Append("<tbody>")

            'Mostras datos en filas
            For i = 0 To dt.Rows.Count - 1
                Dim Codigo As Integer = dt.Rows(i).Item("CodAlumno")

                html.Append("<tr>")
                html.Append("<td>")
                html.Append(dt.Rows(i).Item("CodAlumno"))
                html.Append("</td><td>")
                html.Append(dt.Rows(i).Item("NomAlumno"))
                html.Append("</td><td>")
                html.Append(dt.Rows(i).Item("apeAlumno"))
                html.Append("</td>")
                html.Append("</tr>")
            Next

            html.Append("</tbody>")
            'finaliza tabla
            html.Append("</table>")

            'agregar html en placeholder1
            alumno1.Controls.Add(New Literal() With {
                .Text = html.ToString()
            })
        End If
    End Sub

End Class