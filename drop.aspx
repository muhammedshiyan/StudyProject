<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="drop.aspx.cs" Inherits="WebApplication1.drop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">




    <table>
        <tr>
            <td>country </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList></td>
        </tr>
           <tr>
            <td>state </td>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"></asp:DropDownList></td>
        </tr>
           <tr>
            <td>district</td>
            <td>
                <asp:DropDownList ID="DropDownList3" runat="server" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged"></asp:DropDownList></td>
        </tr>
    </table>
</asp:Content>
 