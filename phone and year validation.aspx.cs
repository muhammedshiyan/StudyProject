using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace WebApplication1
{
    public partial class phone_and_year_validation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            //string pattern = @"^\+?(\d{1,3})?[ -]?\(?\d{3}\)?[ -]?\d{3}[ -]?\d{4}$";
            //Regex regex = new Regex(pattern);
            // regex.IsMatch(txtPhoneNumber.Text);
            //Console.WriteLine($"Is {txtPhoneNumber.Text} a valid phone number? {regex.IsMatch(txtPhoneNumber.Text)}");

        }
    }
}