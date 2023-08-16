<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="pagemethodetrain.aspx.cs" Inherits="WebApplication1.pagemethodetrain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

   
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script type="text/javascript">

        function getLength() {
            var input = $("#txtInput").val();

            
            PageMethods.GetStringLength(input, onSuccess, onError);

        }
        
        function onSuccess(result) {

            var input = $("#txtInput").val();

           
            alert("String length: " );

        }

        function onError(error) {
            alert("An error occurred: "+ error.get_message());


        }
    </script>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <form id="form1" >
         <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true"></asp:ScriptManager>

   <div>  
            <input type="text" id="txtInput" />
            <input type="button" id="btnGetLength" value="Get Length" onclick="getLength()" />
        </div>
   
         </form>
</asp:Content>
