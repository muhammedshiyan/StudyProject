<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="WebApplication1.WebForm5" %>

<%@ Register Src="~/WebUserControltrain.ascx" TagPrefix="uc1" TagName="WebUserControltrain" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="Label1" runat="server" Text="DateTime"></asp:Label>
    <uc1:webusercontroltrain runat="server" SelectedDate="00-00-00" ID="WebUserControltrain" />


<asp:Button ID="Button1" runat="server" Text="Show Date" OnClick="Button1_Click" />
</asp:Content>
