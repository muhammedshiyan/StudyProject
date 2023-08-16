using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;


namespace WebApplication1
{
    public partial class updatepanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                lblMessage.Text = "not updated";
                lblMessage.Visible = true;
            }
            lblMessage.Text = "not updated";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

            label1.Text = "before updated time is" + DateTime.Now.ToString("HH:mm:ss");
            System.Threading.Thread.Sleep(2000);
            lblMessage.Text = "updated time is" + DateTime.Now.ToString("HH:mm:ss");
            // lblMessage.Visible = false;


        }
    }
}