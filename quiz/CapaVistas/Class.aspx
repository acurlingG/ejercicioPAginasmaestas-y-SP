<%@ Page Title="" Language="C#" MasterPageFile="~/CapaVistas/Plantilla.Master" AutoEventWireup="true" CodeBehind="Class.aspx.cs" Inherits="quiz.CapaVistas.Class" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>CLASS CATALOG</h1>
    <br />
    <div>

        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
    <br />
    <br />
    <div>
        <asp:Label ID="Label1" runat="server" Text="Codigo"></asp:Label>
        <asp:TextBox ID="tcodigo" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="tnombre" runat="server"></asp:TextBox>
    </div>
    <div>&nbsp;</div>
    <div>&nbsp;</div>
    <div>
        <asp:Button ID="bconsultar" runat="server" Text="Consultar" OnClick="bconsultar_Click" />
        <asp:Button ID="baagregar" runat="server" Text="Agregar" OnClick="baagregar_Click" />
    </div>
</asp:Content>
