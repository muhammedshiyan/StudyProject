<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="jsonserialiseanddeserialise.aspx.cs" Inherits="WebApplication1.jsonserialiseanddeserialise" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">




</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

     <asp:Button ID="Button1" runat="server" Text="Serialise" OnClick="Button1_Click" />

    <asp:Button ID="Button2" runat="server" Text="Deserialise" OnClick="Button2_Click" />

    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
   
</asp:Content>
