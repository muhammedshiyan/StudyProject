using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1;

namespace WebApplication1
{
    public partial class iframe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                myIframe.Attributes["src"] = "https://www.example.com";
                Session["state"] = "https://www.example.com";
                ClientScript.RegisterForEventValidation(myIframe.UniqueID, "https://www.example.com");



            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (Session["state"].ToString() == "https://www.example.com")
                {
                    Session["state"] = "https://www.youtube.com/embed/dQw4w9WgXcQ";

                }
                else
                {
                  Session["state"] = "https://www.example.com";
                }
                string newUrl = Session["state"].ToString();
                bool IsValidUrl(string url)
                {
                    return url.StartsWith(Session["state"].ToString());
                }

                if (IsValidUrl(newUrl))
                {
                    myIframe.Attributes["src"] = newUrl;
                    Session["state"] = newUrl;
                    ClientScript.RegisterForEventValidation(myIframe.UniqueID, newUrl);
                }
                else
                {

                }


            }
            catch (Exception ex)
            {
                string script = "alert('This is an alert message!');";
                ScriptManager.RegisterStartupScript(this, GetType(), "ShowAlert", script, true);
            }

            finally { }
        }


    }


}
