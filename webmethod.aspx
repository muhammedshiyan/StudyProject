<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="webmethod.aspx.cs" Inherits="WebApplication1.webmethod" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
<script type="text/javascript">
    $(function () {                                  //$(document).ready(function () { })
    $.ajax({
        type: "POST",
        url: "webmethod.aspx/GetProductData",
        data: '{}',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (r) {
            var DropDownList1 = $("[id*=DropDownList1]");
            DropDownList1.empty().append('<option selected="selected" value="0">Please select</option>');
            $.each(r.d, function () {
                DropDownList1.append($("<option></option>").val(this['Value']).html(this['Text']));
            });
        }
    });
    });



</script>

    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>

    <asp:GridView ID="GridView1" runat="server"></asp:GridView>



</asp:Content>

