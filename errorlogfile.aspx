<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="errorlogfile.aspx.cs" Inherits="WebApplication1.errorlogfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">






</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <h1>Error Log File</h1>

    <asp:Button ID="Button1" runat="server" Text="current error" OnClick="Button1_Click" />   <asp:Button ID="Button2" runat="server" Text="previous errors" OnClick="Button2_Click" />  <br />
   
    <h5>CURRENT ERROR</h5>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br /><br />
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label><br /><br />
    <h5>PREVIOUS ERROR</h5>
     <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>

</asp:Content>
