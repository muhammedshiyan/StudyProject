<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DynamicT.aspx.cs" Inherits="WebApplication1.DynamicT" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">



    <button onclick="addRow()">Add Row</button>
    <button onclick="addColumn()">Add Column</button>

    <table id="myTable" border="1">
        
        <tr>
            <th>Column 1</th>
            <th>Column 2</th>
        </tr>
    </table>

    <script type="text/javascript">
        function addRow() {
            var table = document.getElementById('myTable');
            var newRow = table.insertRow();

            var columns = table.rows[0].cells.length;
            for (var i = 0; i < columns; i++) {
                var newCell = newRow.insertCell();
                newCell.innerHTML = "Row " + table.rows.length + ", Cell " + (i + 1);
            }
        }

        function addColumn() {
            var table = document.getElementById('myTable');
            var rows = table.rows;
            var maxCells = 0;

            for (var i = 0; i < rows.length; i++) {
                var cells = rows[i].cells.length;
                if (cells > maxCells) {
                    maxCells = cells;
                }
            }

            
            for (var i = 0; i < rows.length; i++) {
                var newCell = rows[i].insertCell();
                newCell.innerHTML = "Row " + (i + 1) + ", Cell " + (maxCells + 1);
            }
        }
    </script>




</asp:Content>
