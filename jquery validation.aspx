<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="jquery validation.aspx.cs" Inherits="WebApplication1.jquery_validation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    
<meta name="viewport" content="width=device-width, initial-scale=1">  
 
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css">  

 
<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.0/jquery.min.js"></script>  
<script>  
    $(document).ready(function () {
        $('#first_form').submit(function (e) {
            e.preventDefault();
            var first_name = $('#first_name').val();
            var last_name = $('#last_name').val();
            var email = $('#email').val();
            var password = $('#password').val();
            var number = $('#number').val();
            $(".error").remove();
            if (first_name.length < 1) {
                $('#first_name').after('<span class="error">This field is required</span>');
            }
            if (number.length < 1) {
                $('#number').after('<span class="error">This field is required</span>');
            }
            if (last_name.length < 1) {
                $('#last_name').after('<span class="error">This field is required</span>');
            }
            if (email.length < 1) {
                $('#email').after('<span class="error">This field is required</span>');
            } else {
                var regEx = /^[A-Z0-9][A-Z0-9._%+-]{0,63}@(?:[A-Z0-9-]{1,63}\.){1,125}[A-Z]{2,63}$/;
                var validEmail = regEx.test(email);
                if (!validEmail) {
                    $('#email').after('<span class="error">Enter a valid email</span>');
                }
            }
            if (password.length < 8) {
                $('#password').after('<span class="error">Password must be at least 8 characters long</span>');
            }
        });

        $('form[id="second_form"]').validate({
            rules: {
                fname: 'required',
                lname: 'required',
                user_email: {
                    required: true,
                    email: true,
                },
                psword: {
                    required: true,
                    minlength: 8,
                }
            },
            messages: {
                fname: 'This field is required',
                lname: 'This field is required',
                user_email: 'Enter a valid email',
                psword: {
                    minlength: 'Password must be at least 8 characters long'
                }
            },
            submitHandler: function (form) {
                form.submit();
            }
        });
    });

</script>  
      <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />

     <script>
         function validateForm() {

             var name = document.getElementById("name").value.trim();
             var email = document.getElementById("email").value.trim();
             var age = document.getElementById("age").value.trim();
             var country = document.getElementById("country").value.trim();
             var phone = document.getElementById("phone").value.trim();
             var postalCode = document.getElementById("postalCode").value.trim();
             var message = document.getElementById("message").value.trim();


             document.querySelectorAll(".error").forEach(function (element) {
                 element.remove();
             })
                 ;


             if (name === "") {
                 displayError("name", "Name is required");
                 return false;
             }


             var emailRegex = /^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$/;
             if (!emailRegex.test(email)) {
                 displayError("email", "Enter a valid email address");
                 return false;
             }


             var ageRegex = /^\d+$/;
             if (!ageRegex.test(age) || parseInt(age) <= 0) {
                 displayError("age", "Age must be a positive number");
                 return false;
             }


             var countryRegex = /^[A-Za-z]+$/;
             if (!countryRegex.test(country)) {
                 displayError("country", "Country should only contain letters");
                 return false;
             }

             var phoneRegex = /^\d{3}-\d{3}-\d{4}$/;
             if (!phoneRegex.test(phone)) {
                 displayError("phone", "Phone number should be in the format xxx-xxx-xxxx");
                 return false;
             }

             var postalCodeRegex = /^[A-Z]\d[A-Z] \d[A-Z]\d$/;
             if (!postalCodeRegex.test(postalCode)) {
                 displayError("postalCode", "Postal code should be in the format X9X 9X9");
                 return false;
             }


             if (message === "") {
                 displayError("message", "Message is required");
                 return false;
             }


             return true;
         }

         function displayError(field, errorMessage) {
             var errorSpan = document.createElement("span");
             errorSpan.className = "error";
             errorSpan.textContent = errorMessage;

             var inputField = document.getElementById(field);
             inputField.parentNode.insertBefore(errorSpan, inputField.nextSibling);
         }
     </script>



  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<%--<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="jquery_validation.aspx.cs" Inherits="WebApplication1.jquery_validation" %>--%>


<center>  
 
<h2> FORM VALIDATION</h2><br /><h3>USING JQUERY</h3>  
<%--<form id="first_form" method="post" action="jquery validation.aspx.cs"  >--%>
  <div>  
    <label for="first_name"> Enter First Name: </label>  
    <input type="text" id="first_name" name="first_name"/>  
  </div>  
  <div>  
    <label for="last_name"> Enter Last Name: </label>  
    <input type="text" id="last_name" name="last_name"/>  
  </div>  
  <div>  
   <label for="last_name"> Enter Number: </label>  
  <input type="text"  id="number" name="number">  
  </div>  
  <div>  
    <label for="email"> Enter Email: </label>  
    <input type="email" id="email" name="email"/>  
  </div>  
  
  <div>  
    <label for="password"> Enter Password: </label>  
    <input type="password" id="password1" name="password1"/>  
  </div>  
  <div>  
    <label for="password"> Confirm Password: </label>  
    <input type="password" id="password2" name="password2"/> 
  </div>  
  <div>  
    <input type="submit" value="Submit" /> 
  </div>  
<%--</form> --%>
</center>  
  
<center>
  <h3>USING JAVASCRIPT</h3>
 <%-- <form id="myForm" onsubmit="return validateForm()" method="post">--%>
    <div>
      <label for="name">Name:</label>
      <input type="text" id="name" name="name" required>
    </div>
    <div>
      <label for="email">Email:</label>
      <input type="email" id="email" name="email" required>
    </div>
    <div>
      <label for="age">Age:</label>
      <input type="text" id="age" name="age" required>
    </div>
    <div>
      <label for="country">Country:</label>
      <input type="text" id="country" name="country" required>
    </div>
    <div>
      <label for="phone">Phone Number:</label>
      <input type="text" id="phone" name="phone" required>
    </div>
    <div>
      <label for="postalCode">Postal Code:</label>
      <input type="text" id="postalCode" name="postalCode" required>
    </div>
    <div>
      <label for="message">Message:</label>
      <textarea id="message" name="message" required></textarea>
    </div>
    <div>
      <input type="submit" value="Submit">
    </div>
<%--  </form>--%>
</center>
 

<centre>
    
    <div style="text-align: center;">
  <h3>USING  VALIDATION ASPX</h3>

  

    
   <%-- <form id="Form1" runat="server">--%>
        <div class="container mt-5">
            <div >
                <label for="txtName">Name:</label>
                <asp:TextBox ID="txtName" runat="server" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName"
                    ErrorMessage="Name is required" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>

            <div >
                <label for="txtEmail">Email:</label>
                <asp:TextBox ID="txtEmail" runat="server" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail"
                    ErrorMessage="Email is required" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail"
                    ErrorMessage="Enter a valid email address" Display="Dynamic"
                    ValidationExpression="^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"
                    CssClass="text-danger"></asp:RegularExpressionValidator>
            </div>

            <div >
                <label for="txtAge">Age:</label>
                <asp:TextBox ID="txtAge" runat="server" placeholder="Age must be between 18 and 50" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvAge" runat="server" ControlToValidate="txtAge"
                    ErrorMessage="Age is required" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="rvAge" runat="server" ControlToValidate="txtAge"
                    ErrorMessage="Age must be between 18 and 50" MinimumValue="18" MaximumValue="50"
                    Type="Integer" Display="Dynamic" CssClass="text-danger"></asp:RangeValidator>
            </div>

            <div >
                <label for="txtPhone">Phone Number:</label>
                <asp:TextBox ID="txtPhone" runat="server" placeholder="Enter a valid phone number in correct format " ></asp:TextBox>
                <asp:RegularExpressionValidator ID="revPhone" runat="server" ControlToValidate="txtPhone"
                    ErrorMessage="Enter a valid phone number in the format xxx-xxx-xxxx" Display="Dynamic"
                    ValidationExpression="^\d{3}-\d{3}-\d{4}$" CssClass="text-danger"></asp:RegularExpressionValidator>
            </div>

            <div >
                <label for="txtPostalCode">Postal Code:</label>
                <asp:TextBox ID="txtPostalCode" runat="server" placeholder="Enter a valid postal code in correct format"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revPostalCode" runat="server" ControlToValidate="txtPostalCode"
                    ErrorMessage="Enter a valid postal code in the format X9X 9X9" Display="Dynamic"
                    ValidationExpression="^[A-Z]\d[A-Z] \d[A-Z]\d$" CssClass="text-danger"></asp:RegularExpressionValidator>
            </div>

            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />

            <asp:ValidationSummary ID="valSummary" runat="server" ShowSummary="true" ShowMessageBox="false"
                CssClass="alert alert-danger mt-3" ValidationGroup="vgSubmit" />
        </div>
 <%--   </form>--%>
        </centre>
</div>
    </asp:Content>

