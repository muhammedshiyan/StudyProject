<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="showpassword.aspx.cs" Inherits="WebApplication1.showpassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">







    <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>

  <%--  <label for="Check">Checkbox:</label>--%>
   <%-- <input type="checkbox" id="Check" onclick="Show()">--%>
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

    <p id="text" style="display: none">Checkbox is CHECKED</p>

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

    <label for="password">Password:</label>
<input type="password" id="password" name="password">

<button onclick="PasswordVisibility()"> View</button>

    <script>
        function PasswordVisibility() {
            var passwordInput = document.getElementById('password');
            var type = passwordInput.getAttribute('type');

            if (type === 'password') {
                passwordInput.setAttribute('type', 'text');
            } else {
                passwordInput.setAttribute('type', 'password');
            }
        }

    </script>




</asp:Content>
