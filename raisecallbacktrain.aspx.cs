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

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string cref = Page.ClientScript.GetCallbackEventReference(this, "arg", "Getnumberserver", "context");
                string cscript = "function UseCallback (arg,context)" + "{" + cref + ";" + "}";
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "UseCallback", cscript, true);
            }
            catch(Exception ex) { }
            finally { }
           
        }


        public void RaiseCallbackEvent(string eventarg)
        {
            try
            {
                Random r = new Random();
                _callbackresult = r.Next().ToString();
            }
            catch(Exception ex) { }
            finally { }
           
          
        }
        public string GetCallbackResult()
        {

            return _callbackresult;


        }

       
    }
}

