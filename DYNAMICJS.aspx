<%--<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DYNAMICJS.aspx.cs" Inherits="WebApplication1.DYNAMICJS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">--%>


<!DOCTYPE html>
<html>
<head>
  <title>Dynamic Table</title>
</head>
<body>
  <button onclick="addRow()">Add Row</button>
  <button onclick="addColumn()">Add Column</button>
  <table id="myTable">
    <thead>
      <tr>
        <th>Name</th>
        <th>Age</th>
        <th>Email</th>
      </tr>
    </thead>
    <tbody>
     
    </tbody>
  </table>
</body>
</html>
<script>
    function addRow() {
        var table = document.getElementById("myTable").getElementsByTagName('tbody')[0];
        var newRow = table.insertRow(table.rows.length);

        
        var nameCell = newRow.insertCell(0);
        var ageCell = newRow.insertCell(1);
        var emailCell = newRow.insertCell(2);

        var nameInput = document.createElement("input");
        nameInput.type = "text";
        nameCell.appendChild(nameInput);

        var ageInput = document.createElement("input");
        ageInput.type = "text";
        ageCell.appendChild(ageInput);

        var emailInput = document.createElement("input");
        emailInput.type = "text";
        emailCell.appendChild(emailInput);

         //for (var i = -1; i < table.rows.length; i++) {
        //    var newRow = table.insertRow(i);
        //    for (var k = 0; k < table.column.count; k++) {
        //        var newRowCell = newRow.insertCell(k)
        //        var newInput = document.createElement("input");
        //        newInput.type = "text";
        //        newRowCell.appendChild(newInput);

        //    }

        //}

    }

    function addColumn() {
        var table = document.getElementById("myTable");
        var headerRow = table.rows[0];

     
        var newHeaderCell = document.createElement("th");
        newHeaderCell.innerHTML = "Column " + (headerRow.cells.length + 1);
        headerRow.appendChild(newHeaderCell);

       
        for (var i = 1; i < table.rows.length; i++) {

            for (var k =-1; k< 0; k++) {
                var newRowCell = table.rows[i].insertCell(-1);
                var newInput = document.createElement("input");
                newInput.type = "text";
                newRowCell.appendChild(newInput);

            }
               
            }


        }
    
</script>



<%--</asp:Content>--%>
