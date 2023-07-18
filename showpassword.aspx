<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="showpassword.aspx.cs" Inherits="WebApplication1.showpassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

   
  





<label for="Check">Checkbox:</label> 
<input type="checkbox" id="Check" onclick="Show()">

<p id="text" style="display:none">Checkbox is CHECKED</p>

<script>
        function Show() {
            var check = document.getElementById("Check");
            var text = document.getElementById("text");
            if (check.checked == true) {
                text.style.display = "block";
            } else {
                text.style.display = "none";
            }
        }
</script>



</asp:Content>
