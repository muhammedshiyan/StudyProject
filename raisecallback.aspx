<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" enableEventValidation="false" CodeBehind="raisecallback.aspx.cs" Inherits="WebApplication1.race_callback" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <form id="form1" >
        <div>
            <h1>Callback</h1>
       
                 <asp:Button ID="btnStart" runat="server" Text="btnStart" OnClick="btnStart_Click" />
                <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
            
           
        </div>
    </form>
</asp:Content>
