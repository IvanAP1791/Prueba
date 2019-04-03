<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Presentacion.aspx.cs" Inherits="Pruebapractica.Presentacion1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Sistema de gestion de Alumnos</h1>
    <br />
    <asp:Label ID="LblNombre" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
    <br>
    <br />
    <asp:Label ID="LblApellido" runat="server" Text="Apellido"></asp:Label>
    <asp:TextBox ID="TxtApellido" runat="server"></asp:TextBox>
    <br>
    <br />
    <asp:Label ID="LblDocumento" runat="server" Text="Documento"></asp:Label>
    <asp:TextBox ID="TxtDocumento" runat="server"></asp:TextBox>
    <br>
    <br />
    <asp:Label ID="LblEdad" runat="server" Text="Edad"></asp:Label>
    <asp:TextBox ID="TxtEdad" runat="server"></asp:TextBox>
    <br>
    <br />
    <asp:Button ID="Guardar" OnClick="Guardar_Click" runat="server" Text="Guardar" />
</asp:Content>
