using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
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
            try
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


                string str = string.Empty;

                if (Request.Cookies["department"].Values.ToString() != null)
                {
                    if (Request.Cookies["department"]["hr"] != null)
                        str += Request.Cookies["department"]["hr"] + " ";

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
            catch (Exception ex) { }
            finally { }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (Request.Cookies["department"] != null)
                {

                    HttpCookie cookie = Request.Cookies["department"];
                    cookie.Value = "new value";
                    Label3.Text = cookie.Value;
                    cookie.Expires = DateTime.Now.AddDays(8);
                    Response.Cookies.Add(cookie);
                }
            }
            catch (Exception ex) { }
            finally { }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            try
            {
                if (Request.Cookies["department"] != null)
                {
                    HttpCookie cookie = new HttpCookie(Request.Cookies["department"].ToString());
                    cookie = Request.Cookies["department"];
                    //cookie.Expires = DateTime.Now.AddDays(-1);
                    HttpContext.Current.Request.Cookies.Remove("department");
                }
            }
            catch (Exception ex) { }
            finally { }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            try
            {
                if (Button4.Text == "session update")
                {
                    Session["UserName"] = "smith";
                    Label4.Text = "smith";
                }


                if (Button4.Text == "session add")
                {
                    Session["UserName"] = "Jane";
                    Label4.Text = "Jane";

                }

                if (Button4.Text == "session delete")
                {
                    Session.Remove("UserName");

                    Button4.Text = "session add";
                    Label4.Text = "session removed";

                }


                {
                    if (Session["UserName"] != null)
                    {
                        if (Session["UserName"].ToString() == "Jane")
                        {

                            Button4.Text = "session update";
                        }

                        else
                        {
                            Session["UserName"] = "smith";
                            Label4.Text = "smith";
                            Button4.Text = "session delete";

                        }
                    }
                }
            }

            catch (Exception ex)
            {



            }
            finally
            {


            }









        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            HttpCookieCollection cookies = Request.Cookies;
            for (int i = 0; i < cookies.Count; i++)
            {
                sb.Append("Name: " + cookies[i].Name + "<br/>");
                sb.Append("Value: " + cookies[i].Value + "<br/>");
                sb.Append("Expires: " + cookies[i].Expires.ToString() +
                          "<br/><br/>");

            }

            Label5.Text= sb.ToString();
        }
    }
}
