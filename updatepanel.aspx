<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="updatepanel.aspx.cs" Inherits="WebApplication1.updatepanel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   
<%--<!DOCTYPE HTML>

<HEAD>


</HEAD>
<BODY>--%>
    <form id="form1" >
        
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Label ID="lblMessage" runat="server" Text="Initial Text"></asp:Label>
                     <asp:Label ID="label1" runat="server" Text="Initial Text"></asp:Label>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="btnUpdate"  />
                </Triggers>

            </asp:UpdatePanel>
            <asp:Button ID="btnUpdate" runat="server" Text="Update button" OnClick="btnUpdate_Click" />
        </div>
    </form>
        

<%--</BODY>--%>
   
</asp:Content>
