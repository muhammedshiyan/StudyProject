using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class cookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
               

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            HttpCookie cookie = new HttpCookie("department");
            cookie.Value = "cookievalue";
            Response.Cookies.Add(cookie);
            string cookievalue = Response.Cookies["department"].Value;

            Label3.Text = cookievalue;

            Response.Cookies["department"].Expires = DateTime.Now.AddDays(9);

            if (Check1.Checked)
                Response.Cookies["department"]["hr"] = "hr";
            if (Check2.Checked)
                Response.Cookies["department"]["marketing"] = "marketing";
            if (Check3.Checked)
                Response.Cookies["department"]["developing"] = "developing";
            if (Check4.Checked)
                Response.Cookies["department"]["testing"] = "testing";
            if (Check4.Checked)
                Response.Cookies["department"]["finance"] = "finance";
            if (Check4.Checked)
                Response.Cookies["department"]["system"] = "system";
             

            string str=string.Empty;

            if (Request.Cookies["department"].Values.ToString() != null)
            {
                if (Request.Cookies["department"]["hr"] != null)
                    str+= Request.Cookies["department"]["hr"] + " ";
                if (Request.Cookies["department"]["marketing"] != null)
                    str += Request.Cookies["department"]["marketing"] + " ";
                if (Request.Cookies["department"]["developing"] != null)
                    str += Request.Cookies["department"]["developing"] + " ";
                if (Request.Cookies["department"]["testing"] != null)
                    str += Request.Cookies["department"]["testing"] + " ";
                if (Request.Cookies["department"]["finance"] != null)
                    str += Request.Cookies["department"]["finance"] + " ";
                if (Request.Cookies["department"]["system"] != null)
                    str += Request.Cookies["department"]["system"] + " ";

                Label1.Text = str;
             
            }


            else Label1.Text = "Please select your choice";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["computer"] != null)
            {
               
                HttpCookie cookie = Request.Cookies["computer"];
                cookie.Value = "new value";
                cookie.Expires = DateTime.Now.AddDays(8);
                Response.Cookies.Add(cookie);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["computer"] != null)
            {
                HttpCookie cookie = new HttpCookie(Request.Cookies["computer"].ToString());
                cookie = Request.Cookies["computer"];
                cookie.Expires = DateTime.Now.AddDays(-1);

            }
        }
    }
    }
