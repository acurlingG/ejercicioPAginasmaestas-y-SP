<%@ Page Title="" Language="C#" MasterPageFile="~/CapaVistas/Plantilla.Master" AutoEventWireup="true" CodeBehind="Estudiante.aspx.cs" Inherits="quiz.CapaVistas.Estudiante" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>STUDENT CATALOG</h2>
    <br />
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    <br />  
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

       <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
   <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
       <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
   <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
       <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
   <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>

    <br />

    <asp:Button ID="Button1" runat="server" Text="Button" />
</asp:Content>
