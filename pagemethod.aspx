<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="pagemethod.aspx.cs" Inherits="WebApplication1.filldropdownbypagemethode" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   
 

    <style type="text/css">
      
    </style>
    <script type="text/javascript">
        function PopulateList() {
            PageMethods.GetListData(1, OnPopulateList);
          
        }
        function OnPopulateList(list) {
            var dropList = document.getElementById('DropList');
            for (i = 1; i < 10; i++) {
                var option = document.createElement('OPTION');
                option.text = list[i].text;
                option.value = list[i].value;
                dropList.options.add(option);
            }
        }
    </script>

   
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="True">
        </asp:ScriptManager>
        <p>
        </p>
       
        <p >
            <input id="PopList" type="button" value="Populate List"
                onclick="PopulateList()"  />
        </p>
        <p >
            <select id="DropList" name="DropListName"
                >
            </select>
        </p>
        <p >
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
        </p>
        <p >
            <asp:Label ID="lblSubmitValue" runat="server" 
               ></asp:Label>
        </p>
    </div>




</asp:Content>
