using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class texbox11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if(!IsPostBack)
            {
                
                Session["ff"] = String.Empty;

            }
            TextBox1.Text = Session["ff"].ToString();

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            
  
            
            if (TextBox1.TextMode != TextBoxMode.SingleLine)
            {
                TextBox1.TextMode = TextBoxMode.SingleLine;
               
               Session["ff"] = TextBox1.Text;
            }
            else {
                Session["ff"] = TextBox1.Text;
                TextBox1.TextMode = TextBoxMode.Password;
            }
            Label1.Text= TextBox1.Text;

            TextBox1.Text= Session["ff"].ToString();


        }
    }
}