<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="readingandwritingxml.aspx.cs" Inherits="WebApplication1.readingandwritingxml" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">





</asp:Content>

    
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
      
        
        <ContentTemplate>
                 <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />

    <asp:Label ID="Label2" runat="server" Text="Age"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />

    <asp:Label ID="Label3" runat="server" Text="Place"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />

    <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" />

    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </ContentTemplate>

   <Triggers>

       <asp:AsyncPostBackTrigger ControlID="Button1" />
   

   </Triggers>

        
    
       

    </asp:UpdatePanel>
   
    
    


</asp:Content>
