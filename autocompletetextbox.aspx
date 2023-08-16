<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="autocompletetextbox.aspx.cs" Inherits="WebApplication1.autocompletetextbox" %>
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">

    <title></title>    
    <script src="https://ajax.aspnetcdn.com/ajax/jquery/jquery-1.8.0.js"></script>    
    <script src="https://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.22/jquery-ui.js"></script>    
    <link rel="stylesheet" href="https://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.10/themes/redmond/jquery-ui.css" />  
  <script type="text/javascript">
      $(function () {
          $("#txtEmpName").autocomplete({
              source: function (request, response) {
                  var param = { empName: $('#txtEmpName').val() };
                  $.ajax({
                      url: "autocomplete.asmx/GetEmpNames",
                      data: JSON.stringify(param),
                      dataType: "json",
                      type: "POST",
                      contentType: "application/json; charset=utf-8",
                      success: function (data) {
                          response($.map(data.d, function (item) {
                              return {
                                  value: item
                              };
                          }));
                      },
                      error: function (XMLHttpRequest, textStatus, errorThrown) {
                          try {
                              var errorResponse = JSON.parse(XMLHttpRequest.responseText);
                              if (errorResponse && errorResponse.Message) {
                                  alert("Error: " + errorResponse.Message);
                              } else {
                                  alert("An unknown error occurred.");
                                
                              }
                          } catch (e) {
                              alert("An error occurred: " + textStatus);
                          }
                      }
                  });
              },
              minLength: 2
          });
      });
  </script>

</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" runat="server">
    
      
    EmpName :<input id="txtEmpName" type="text" />
       
</asp:Content>
