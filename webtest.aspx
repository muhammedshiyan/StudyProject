<%--<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="webtest.aspx.cs" Inherits="WebApplication1.webtest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">--%>

<%@ WebService Language="C#" CodeBehind="webtest.aspx.cs" Class="MyWebService" %>

    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
<script>
  $(document).ready(function() {
    // Call the HelloWorld web method on button click
    $("#btnHello").click(function() {
      $.ajax({
        type: "POST",
          url: "webtest.aspx.cs/HelloWorld",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function(data) {
          alert(data.d);
        },
        error: function(xhr, textStatus, error) {
          console.log(xhr.responseText);
        }
      });
    });

    // Call the AddNumbers web method on button click
    $("#btnAdd").click(function() {
      var num1 = parseInt($("#num1").val());
      var num2 = parseInt($("#num2").val());

      $.ajax({
        type: "POST",
        url: "MyWebService.asmx/AddNumbers",
        data: JSON.stringify({ num1: num1, num2: num2 }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function(data) {
          $("#result").text("Result: " + data.d);
        },
        error: function(xhr, textStatus, error) {
          console.log(xhr.responseText);
        }
      });
    });
  });
</script>

<!-- HTML elements to trigger the web service calls -->
<button id="btnHello">Say Hello</button>
<br />
<button id="btnAdd">Add Numbers</button>
<br />
<input type="text" id="num1" placeholder="Number 1" />
<input type="text" id="num2" placeholder="Number 2" />
<br />
<div id="result"></div>

<%--</asp:Content>--%>
