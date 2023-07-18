<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="datareaderdataset.aspx.cs" Inherits="WebApplication1.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


     <div>

            <table>
                <tr>
                    <td>select country</td>
                    <td>
                        <asp:DropDownList ID="ddlcountry" runat="server" OnSelectedIndexChanged="Ddlcountry_SelectedIndexChanged"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td>select state
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlstate" runat="server" OnSelectedIndexChanged="Ddlstate_SelectedIndexChanged"></asp:DropDownList></td>
                </tr>
                <tr>

                    <td>select district
                    </td>
                    <td>

                        <asp:DropDownList ID="ddldistrict" runat="server" OnSelectedIndexChanged="Ddldistrict_SelectedIndexChanged"></asp:DropDownList>
                    </td>
                </tr>


            </table>
        </div>






</asp:Content>
