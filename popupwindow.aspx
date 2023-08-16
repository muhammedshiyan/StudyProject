<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="popupwindow.aspx.cs" Inherits="WebApplication1.popupwindow" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="https://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.9/jquery-ui.js" type="text/javascript"></script>
    <link rel="stylesheet" type="text/css" href="https://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.9/themes/start/jquery-ui.css">
    <script type="text/javascript">

        $(document).ready(function () {
            $("#Button2").click(function (e) {
                e.preventDefault();
                $("#dialog").dialog({
                    title: "jQuery Dialog Popup",
                    buttons: {
                        Close: function () {
                            $(this).dialog('close');
                        }
                    }
                });
                return false;
            });
        });
    </script>







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
    <h1>Pop Up</h1>

    <div id="dialog" style="display: none">
        popup window


    </div>
    <asp:Button ID="btnPopup" runat="server" Text="Show Popup" OnClientClick="" UseSubmitBehavior="false" />

    <input id="Button2" type="button" value="button" />

    <input id="Button1" type="button" value="button" />


</asp:Content>
