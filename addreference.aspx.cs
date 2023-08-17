using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary4;


namespace WebApplication1
{
    public partial class addreference : System.Web.UI.Page
    {
        public Class1 obj = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string s = string.Empty;

                Double num1 = 12;
                double num2 = 15;

                s += obj.Addition(num1, num2);
                s += "   " + obj.Subtraction(num1, num2);
                s += "   " + obj.Multiplication(num1, num2);
                s += "   " + obj.Division(num1, num2);


                Label1.Text = s;
            }
            catch(Exception ex) { }
            finally { }
          

        }
    }
}