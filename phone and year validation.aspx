<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="phone and year validation.aspx.cs" Inherits="WebApplication1.phone_and_year_validation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

      <script>
          function validateDates() {
              var startDateInput = document.getElementById('startDate');
              var endDateInput = document.getElementById('endDate');

              var startDate = new Date(startDateInput.value);
              var endDate = new Date(endDateInput.value);


              if (endDate < startDate) {
                  alert("End date must be greater than or equal to the start date.");
                  endDateInput.value = '';
                  endDateInput.focus();
              } else {

                  alert("Dates are valid.");
              }
          }
      </script>
     <script>
         function isvalidphoneno() {
             var id;
             var temp = document.getElementById("<%=txtphone.ClientID %>");
             id = temp.value;
             var re;
             //  re = /^[0-9]+$/;
             re = "^\+?(\d{1,3})?[ -]?\(?\d{3}\)?[ -]?\d{3}[ -]?\d{4}$"
             var digits = /^\d{10}$/;

             if (id == "") {
                 alert("Please enter phone no");
             }
             if (digits.test(id)) {
                 alert("Please enter 10 digit phone no");

             }
             if (re.test(id)) {
                 alert(" valid phone number");
             }
             else {

                 alert("enter digits only");
             }
         }
     </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <!DOCTYPE html>


   <p>Date Validation</p> 


    <label for="startDate">Start Date:</label>
    <input type="date" id="startDate" name="startDate">

    <label for="endDate">End Date:</label>
    <input type="date" id="endDate" name="endDate">

    <button onclick="validateDates()">Submit</button>

  


    <br />
    <asp:TextBox ID="txtphone" placeholder="javascript validation" runat="server"></asp:TextBox>
    <button text="js check no" onclick="isvalidphoneno()">Submit</button>
   

    <br />
     <asp:TextBox ID="txtPhoneNumber"  placeholder="RegularExpressionValidator" runat="server"></asp:TextBox>
     <asp:RegularExpressionValidator ID="regexValidator" runat="server"
                ControlToValidate="txtPhoneNumber"
                ValidationExpression="^\+?(\d{1,3})?[ -]?\(?\d{3}\)?[ -]?\d{3}[ -]?\d{4}$"
                ErrorMessage="Please enter a valid phone number in the format +1 (123) 456-7890 or 123-456-7890."
                Display="Dynamic" />


</asp:Content>
