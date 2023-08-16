<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master"  enableEventValidation="false"  AutoEventWireup="true" CodeBehind="iframe.aspx.cs" Inherits="WebApplication1.iframe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <form id="form1" method="post">
    

        <iframe id="myIframe" runat="server"></iframe>

    </form>
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

</asp:Content>
