<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="summary validation.aspx.cs" Inherits="WebApplication1.summary_validation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script lang="javascript" type="text/javascript">


        function validationcheck() {

            var summary = "";
            summary += isvaliduser();
            summary += isvalidfistname();
            summary += isvalidsecondname();
            summary += isvalidpassword();
            summary += isvalidconfirmpassword();
            summary += isvalidemail();
            summary += isvalidphoneno();

            if (summary != "") {
                alert(summary);
                return false;
            } else {
                return true;
            }
        }



        function isvaliduser() {
            var id;
            var temp = document.getElementById("<%=TextBox3.Text%>");
            id = temp.value;
            if (id == "") { return "please enter username" + "\n" }
        }
        function isvalidfistname() {
            var id;
            var temp = document.getElementById("<%=TextBox1.Text%>");
            id = temp.value;

            if (id == "") { return "please enter first name" + "\n" }
            else { return ""; }
        }
        function isvalidsecondname() {
            var id;
            var temp = document.getElementById("<%=TextBox2.Text%>");
            id = temp.value;


            if (id == "") { return "please enter second name" + "\n" }
            else { return ""; }

        }

        function isvalidpassword() {
            var id;
            var temp = document.getElementById("<%=TextBox4.Text%>")
            if (id == "") { return "please enter your password" + "\n" }
            else { return ""; }


        }

        function isvalidconfirmpassword() {

            var idcfmpwd;
            var idpwd;
            var tempcfmpwd = document.getElementById("<%=TextBox5.Text%>");
            var temppwd = document.getElementById(<%=TextBox4.Text%>);
            idcfmpwd = tempcfmpwd.value;
            idpwd = temppwd.value;
            if (idcfmpwd == "") { return ("plaese enter confirm password" + "\n") }
            else if (idcfmpwd != idpwd) { return "please re enter your password to confirm" + "\n" }

            else {
                return ("email should be in the form ex:abc@xyz." + "\n")
            }
               
            

        }

        function isvalidphoneno() {
            var id;
            var temp = document.getElementById("<%=TextBox7.Text%>");
            id = temp.value;
            var re;
            re = /^[0-9]+$/;
            var digits = /\d(10)/;
            if (id == "") {
                return ("Please enter phone no" + "\n");
            } else if (re.test(id)) {
                return "";
            } else {
                return ("Phone no should be digits only" + "\n");
            }
        }
       




    </script>

    <table>

        <tr>
            <td>first name
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </td>
        </tr>

        <tr>
            <td>second  name
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            </td>
        </tr>

        <tr>
            <td>user name
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
            </td>
        </tr>

        <tr>
            <td>password
            </td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
            </td>
        </tr>

        <tr>
            <td>confirm password
            </td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
            </td>
        </tr>

        <tr>
            <td>email id
            </td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
            </td>
        </tr>

        <tr>
            <td>phone no
            </td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
    <input id="Button1" type="button" value="button" onclick="validationcheck()" />
     
    

</asp:Content>
