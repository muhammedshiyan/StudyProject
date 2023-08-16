<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="cookie.aspx.cs" Inherits="WebApplication1.cookie" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">






</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

   

    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br /><br />
      <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><br /><br />
          <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label><br /><br />
    <asp:CheckBox ID="Check1" runat="server" Text="hr" /><br />
    <asp:CheckBox ID="Check2" runat="server" Text="marketing"/><br />
    <asp:CheckBox ID="Check3" runat="server" Text="developing"/><br />
    <asp:CheckBox ID="Check4" runat="server" Text="testing"/><br />
    <asp:CheckBox ID="Check5" runat="server" Text="finance"/><br />
    <asp:CheckBox ID="Check6" runat="server" Text="system"/><br />
   

    <asp:Button ID="Button1" runat="server" Text="create" OnClick="Button1_Click" />

    <asp:Button ID="Button2" runat="server" Text="update" OnClick="Button2_Click" />



    <asp:Button ID="Button3" runat="server" Text="delete" OnClick="Button3_Click" />


</asp:Content>
