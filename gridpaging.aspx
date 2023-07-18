<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="gridpaging.aspx.cs" Inherits="WebApplication1.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
<div>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="true"  PageSize  ="5" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="Gridchanging">
     


        
        <AlternatingRowStyle BackColor="White" ForeColor="#284775"></AlternatingRowStyle>

        <EditRowStyle BackColor="#999999"></EditRowStyle>

        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White"></FooterStyle>

        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White"></HeaderStyle>

        <PagerStyle HorizontalAlign="Center" BackColor="#284775" ForeColor="White"></PagerStyle>

        <RowStyle BackColor="#F7F6F3" ForeColor="#333333"></RowStyle>

        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333"></SelectedRowStyle>

        <SortedAscendingCellStyle BackColor="#E9E7E2"></SortedAscendingCellStyle>

        <SortedAscendingHeaderStyle BackColor="#506C8C"></SortedAscendingHeaderStyle>

        <SortedDescendingCellStyle BackColor="#FFFDF8"></SortedDescendingCellStyle>

        <SortedDescendingHeaderStyle BackColor="#6F8DAE"></SortedDescendingHeaderStyle>
    </asp:GridView>

</div>




</asp:Content>

