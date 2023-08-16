<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControltrain.ascx.cs" Inherits="WebApplication1.WebUserControltrain" %>



<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<asp:ImageButton ID="ImageButton1" runat="server" OnClick="ImageButton1_Click" />
 <asp:Calendar ID="Calendar1"  SelectedDate="02-08-2023"  runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>