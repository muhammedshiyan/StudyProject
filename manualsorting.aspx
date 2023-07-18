<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="manualsorting.aspx.cs" Inherits="WebApplication1.manualpagnigsorting" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <asp:GridView ID="GridView1" AllowSorting="true"  OnSelectedIndexChanged="GridView1_SelectedIndexChanged"  OnSorting="GridView1_Sorting" runat="server"></asp:GridView>

</asp:Content>
