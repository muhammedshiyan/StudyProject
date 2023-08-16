using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication1
{
    public partial class racecallbacktrain : System.Web.UI.Page, System.Web.UI.ICallbackEventHandler
    {

        public string _callbackresult =null;

        //protected void Page_PreRender(object sender, EventArgs e)
        //{
        //    string cref = Page.ClientScript.GetCallbackEventReference(this, "arg", "Getnumberserver", "context");
        //    string cscript = "function UseCallback(arg, context) { " + cref + "; }";
        //    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "UseCallback", cscript, true);
        //}

        protected void Page_Load(object sender, EventArgs e)
        {
            string cref = Page.ClientScript.GetCallbackEventReference(this, "arg", "Getnumberserver", "context");
            string cscript = "function UseCallback (arg,context)" + "{" + cref + ";" + "}";
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "UseCallback", cscript, true);
        }


        public void RaiseCallbackEvent(string eventarg)
        {

            Random r = new Random();
            _callbackresult = r.Next().ToString();
          
        }
        public string GetCallbackResult()
        {

            return _callbackresult;


        }

       
    }
}

