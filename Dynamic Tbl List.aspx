<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dynamic Tbl List.aspx.cs" Inherits="WebApplication1.Dynamic_Tbl_List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<%--<!DOCTYPE html>
<html>
<head>
    <title>Dynamic Table</title>
</head>
<body>
    <form id="form1" runat="server">--%>
        <asp:Table ID="myTable" runat="server">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell>Name</asp:TableHeaderCell>
                <asp:TableHeaderCell>Age</asp:TableHeaderCell>
                <asp:TableHeaderCell>Email</asp:TableHeaderCell>
            </asp:TableHeaderRow>
        
        </asp:Table>

        <div>
            <label for="txtName">Name:</label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <label for="txtAge">Age:</label>
            <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            <br />
            <label for="txtEmail">Email:</label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnAddPerson" runat="server" Text="Add Person" OnClick="btnAddPerson_Click" />
        </div>
<%--    </form>
</body>
</html>--%>



</asp:Content>
