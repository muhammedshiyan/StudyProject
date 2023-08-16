<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="webserviceaddreference.aspx.cs" Inherits="WebApplication1.webserviceaddreference" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Webservice Add Reference</h1>
    <%--      <asp:Label ID="Label1" runat="server" Text="num1"></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="num2"></asp:Label><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label3" runat="server" Text="result"></asp:Label><asp:Label ID="Label4" runat="server" Text="result"></asp:Label>     <br />--%>

    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <asp:Button ID="Button1" runat="server" Text="Button1" OnClick="Button1_Click" />                                                                                                                                      
    <asp:Button ID="Button2" runat="server" Text="Button2" OnClick="Button2_Click" /> 
     <asp:Label ID="Label5" runat="server" Text=""></asp:Label>

    
</asp:Content>
