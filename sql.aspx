<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="sql.aspx.cs" Inherits="WebApplication1.sql" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">




</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Button ID="view" runat="server" Text="view Button" OnClick="view_Click" />
    <asp:Button ID="function" runat="server" Text="function Button" OnClick="function_Click" />
    <asp:Button ID="trigger" runat="server" Text="trigger Button" OnClick="trigger_Click" />
    <asp:Button ID="groupbyhavingOrderby" runat="server" Text="Groupby-Having-Orderby" OnClick="groupbyhavingOrderby_Click" />
    <asp:Button ID="offsetfetchnext" runat="server" Text="offset-fetch-next-LASTCOUNT Button" OnClick="offsetfetchnext_Click" />
    <asp:Button ID="aggregatefunctions" runat="server" Text="aggregate functions Button" OnClick="aggregatefunctions_Click" />
    <asp:Button ID="joins" runat="server" Text="joins  Button" OnClick="joins_Click" /><br /><br/>

    <asp:Button ID="servicebroker" runat="server" Text="ServiceBroker TransmissionQueue Data" OnClick="servicebroker_Click" />
    <asp:Button ID="questatus" runat="server" Text="check que status" OnClick="questatus_Click" />
     <asp:Button ID="targetqueue" runat="server" Text="Change TargetQueue Status" OnClick="targetqueue_Click" />

    <asp:Button ID="target" runat="server" Text="Target Queue Data" OnClick="target_Click" />
     <asp:Button ID="testq" runat="server" Text="Test Queue Data" OnClick="test_Click" /><br /><br />

    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
     <asp:Button ID="messagesend" runat="server" Text="send message to target" OnClick="messagesend_Click" />


    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>
