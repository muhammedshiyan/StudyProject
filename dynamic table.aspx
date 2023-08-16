<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="dynamic table.aspx.cs" Inherits="WebApplication1.dynamic_table" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


        <asp:TextBox ID="txtRowName" runat="server" placeholder="Enter the name for the new row"></asp:TextBox>
        <asp:TextBox ID="txtAge" runat="server" placeholder="Enter the age for the new row"></asp:TextBox>
        <asp:TextBox ID="newcolumnname" runat="server" placeholder="Enter column name"></asp:TextBox>
       
        <asp:Button ID="btnAddRow" runat="server" Text="Add Row" OnClick="btnAddRow_Click" />
        <asp:Button ID="btnAddColumn" runat="server" Text="Add Column" OnClick="btnAddColumn_Click" />
      <asp:Table ID="myTable" runat="server" BorderStyle="Solid" BorderWidth="1">
           
            <asp:TableHeaderRow>
                <asp:TableHeaderCell>Name</asp:TableHeaderCell>
                <asp:TableHeaderCell>Age</asp:TableHeaderCell>
            </asp:TableHeaderRow>
        </asp:Table>
    <asp:Button ID="RowAdd" runat="server" Text="Show Input Dialog" OnClick="btnShowInput_Click" />
   <%-- <asp:Button ID="columnAdd" runat="server" Text="Show Input Dialog" OnClick="btnShowInput_Click" />--%>
     
        <asp:HiddenField ID="hiddenInput1" runat="server" />
        <asp:HiddenField ID="hiddenInput2" runat="server" />


    <asp:GridView ID="GridView1" runat="server"></asp:GridView>


        <script type="text/javascript">
            function showInputDialog() {
                var inputText1 = prompt('Enter your name:');
                var inputText2 = prompt('Enter your age:');
                if (inputText1 != null && inputText1.trim() !== '' && inputText2 != null && inputText2.trim() !== '') {
                   
                    document.getElementById('<%= hiddenInput1.ClientID %>').value = inputText1;
                    document.getElementById('<%= hiddenInput2.ClientID %>').value = inputText2;

                    
                    __doPostBack('<%= RowAdd.UniqueID %>', '');
                }
                return false; 
            }
        </script>
            
        
     <%--   <script type="text/javascript">
            function columnnamecall() {
                var input = prompt('Enter your name:');

               if (inputText1 != null && inputText1.trim() !== '' && inputText2 != null && inputText2.trim() !== '') {
                   
                    document.getElementById('<%= //hiddenInput1.ClientID %>').value = input;
                  
                    __doPostBack('<%=//columnAdd.UniqueID %>', '');
                }
                return false;
            }
        </script>--%>


</asp:Content>
