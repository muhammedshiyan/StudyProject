<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="manualpaging.aspx.cs" Inherits="WebApplication1.manualsorting" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


     <asp:GridView ID="GridView1" AutoGenerateColumns="true" PageSize="5" AllowPaging="true" AllowCustomPaging="true" runat="server"></asp:GridView>

    
    <asp:Panel ID="Panel1" runat="server">

           
    </asp:Panel>


</asp:Content>
