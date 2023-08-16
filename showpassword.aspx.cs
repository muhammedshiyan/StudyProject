using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class showpassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox1.TextMode = TextBoxMode.Password;

                //ViewState["text"] = "";
            }

            //string str = ViewState["text"].ToString();
            //TextBox1.Text = str;



        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

            string str = TextBox1.Text;
            ViewState["text"] = str;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (TextBox1.TextMode == TextBoxMode.Password)
            {
                TextBox1.TextMode = TextBoxMode.SingleLine;
                TextBox1.Text = ViewState["text"].ToString();


            }
            else if (TextBox1.TextMode == TextBoxMode.SingleLine)
            {

                TextBox1.TextMode = TextBoxMode.Password;
                TextBox1.Text = ViewState["text"].ToString();
            }


        }
    }
}

