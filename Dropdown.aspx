<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dropdown.aspx.cs" Inherits="WebApplication1.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


        <div>

            <table>
                <tr>
                    <td>select country</td>
                    <td>
                        <asp:DropDownList ID="ddlcountry" runat="server" OnSelectedIndexChanged="OnCountryChange" OnTextChanged="ddlcountry_TextChanged" AutoPostBack="True"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td>select state
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlstate" runat="server" OnSelectedIndexChanged="ddlstate_SelectedIndexChanged" OnTextChanged="ddlstate_TextChanged" AutoPostBack="True"></asp:DropDownList></td>
                </tr>
                <tr>

                    <td>select district
                    </td>
                    <td>

                        <asp:DropDownList ID="ddldistrict" runat="server" OnSelectedIndexChanged="ddldistrict_SelectedIndexChanged" OnTextChanged="ddldistrict_TextChanged" AutoPostBack="True"></asp:DropDownList>
                    </td>
                </tr>
              
            </table>
        </div>





</asp:Content>
