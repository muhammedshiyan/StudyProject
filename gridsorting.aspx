<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="gridsorting.aspx.cs" Inherits="WebApplication1.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">-

    
    <asp:GridView ID="GridView1"  AllowSorting="True"  runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnSorting="GridView1_Sorting" Height="165px" Width="394px">
     
        

    </asp:GridView>
        


    </asp:Content>























