<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="WebApplication1.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Button ID="btnThrowException" runat="server" Text="Throw Exception" OnClick="btnThrowException_Click" />
            <asp:Label ID="lblStackTrace" runat="server" Text="lblStackTrace"></asp:Label>
        </div>
    </form>
</body>
</html>
