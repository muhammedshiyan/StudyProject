<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="xmlserialdeserial.aspx.cs" Inherits="WebApplication1.xmlserialdeserial" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    

    <asp:Button ID="Button1" runat="server" Text="XmlSerialise" OnClick="Button1_Click" />


    <asp:Button ID="Button2" runat="server" Text="XmlDeserialise" OnClick="Button2_Click" /><br />HTML ENCODE<br /><br />

    <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br />XML READ DATA<br /><br /><br />
    <asp:Label ID="Label2" runat="server" Text=""></asp:Label><br />

    GRID VIEW
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>

</asp:Content>
