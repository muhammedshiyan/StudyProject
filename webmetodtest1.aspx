<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webmetodtest1.aspx.cs" Inherits="WebApplication1.webmetodtest1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
  <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
<script>
    $(document).ready(function () {
       
        $("#btnHello").click(function () {
            $.ajax({
                type: "POST",
                url: "webmetodtest1.aspx/HelloWorld",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (data) {
                    alert(data.d);
                },
                error: function (xhr, textStatus, error) {
                    console.log(xhr.responseText);
                }
            });
        });

        
        $("#btnAdd").click(function () {
            var num1 = parseInt($("#num1").val());
            var num2 = parseInt($("#num2").val());

            $.ajax({
                type: "POST",
                url: "MyWebService.aspx/AddNumbers",
                data: JSON.stringify({ num1: num1, num2: num2 }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (data) {
                    $("#result").text("Result: " + data.d);
                },
                error: function (xhr, textStatus, error) {
                    console.log(xhr.responseText);
                }
            });
        });
    });
</script>


<button id="btnHello">Say Hello</button>
<br />
<button id="btnAdd">Add Numbers</button>
<br />
<input type="text" id="num1" placeholder="Number 1" />
<input type="text" id="num2" placeholder="Number 2" />
<br />
<div id="result"></div>

</body>
</html>
