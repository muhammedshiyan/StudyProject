<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="querystring.aspx.cs" Inherits="WebApplication1.querystring" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <asp:Label ID="Label1" runat="server" Text="Fname"></asp:Label> <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label2" runat="server" Text="Sname"></asp:Label> <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="btnstart" OnClick="Button1_Click" />

    <h3> <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label><br /><br /></h3>
   <h3> <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label><br /><br /></h3>
    <h3><asp:Label ID="Label5" runat="server" Text="Label"></asp:Label><br /></h3>
   
    
</asp:Content>
