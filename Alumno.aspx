<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Alumno.aspx.vb" Inherits="Pro1_Semana4_CRUD_Visual_Basic_MySQL.Alumno1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>


    <p class="text-center" style="font-size: large">
        <strong>LISTADO DE </strong>A<span style="font-weight: bold">LUMNOS</span></p>

    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" Width="131px" />

    <br />

    <asp:placeholder ID="estudiantes" runat="server" />

    <br />

</asp:Content>