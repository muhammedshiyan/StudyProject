<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="datatabletojson.aspx.cs" Inherits="WebApplication1.datatabletojson" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

        <script type="text/javascript">
        $(document).ready(function () {
            $("#Button1").click(function () {


                popupContent = "<h2>content<h2>";
                var popupWidth = 500;
                var popupHeight = 300;
                var popupLeft = (window.screen.width - popupWidth) / 2;
                var popupTop = (window.screen.height - popupHeight) / 2;
                var popupOptions = 'width=' + popupWidth + ',height=' + popupHeight + ',left=' + popupLeft + ',top=' + popupTop;

               
                var popupURL = 'https://www.example.com';

               
                window.open(popupURL, 'PopupWindow', popupOptions);


                popupWindow.document.write(popupContent);
            });
        });
        </script>



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h1>DataTableToJson</h1>
    <asp:Button ID="Button1" runat="server" Text="Using JavaScriptSerializer" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="Json.Net DLL" OnClick="Button2_Click" />
    <asp:Button ID="Button3" runat="server" Text="string builder" OnClick="Button3_Click" />
   <br />
    
    <asp:Label ID="Label2" runat="server" Text="....."></asp:Label>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>


</asp:Content>
