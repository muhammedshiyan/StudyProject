<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="webmethod.aspx.cs" Inherits="WebApplication1.webmethod" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

       <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
<script type="text/javascript">
    $(document).ready(function () {
        console.log("jjjjjj")
        $.ajax({
            type: "POST",
            url: "webmethod1.asmx/GetProductData",
            data: '{}',
            contentType: "application/json;charset=utf-8",
            dataType: "json",
            beforeSend: function (xhr) {
                console.log("555555")
            },
            success: function (r) {
                var DropDownList1 = $("[id*=DropDownList1]");
                DropDownList1.empty().append('<option selected="selected" value="0">Please select</option>');
                $.each(r.d, function () {
                    DropDownList1.append($("<option></option>").val(this['Value']).html(this['Text']));
                });
            },
            error: function (xhr, textStatus, errorThrown) {
                console.log(xhr.responseText);
            }
        });

    });




</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
 
    <form=""  > 
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true"></asp:ScriptManager>
    <asp:DropDownList ID="DropDownList1" runat="server" ></asp:DropDownList>
    <div> <asp:GridView ID="GridView1" runat="server"></asp:GridView>


<%--    <%--    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="function ()" />--%>
        <input id="Button2" type="button" value="button"  onclick="function ()"/>--%>

</div>
   
</form>

</asp:Content>

