<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="raisecallbacktrain.aspx.cs" Inherits="WebApplication1.racecallbacktrain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">



    <script type="text/javascript">
        function Getvalue() {
            var textBoxValue = document.getElementById('<%= TextBox1.ClientID %>').value;
        UseCallback(textBoxValue);
    }

    function Getnumberserver(textBoxValue, context) {
        document.getElementById('<%= TextBox1.ClientID %>').value = textBoxValue;
        }
    </script>



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Raise CallBack</h1>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <input id="Button1" type="button" value="get random value"  name ="get random value"   onclick="Getvalue()"/>
  
    
  
</asp:Content>
