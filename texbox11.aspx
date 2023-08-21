<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="texbox11.aspx.cs" Inherits="WebApplication1.texbox11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    
    <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</asp:Content>
