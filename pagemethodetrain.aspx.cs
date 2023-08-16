using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace WebApplication1
{
    public partial class pagemethodetrain : System.Web.UI.Page
    {
     
        protected void Page_Init(object sender, EventArgs e)
        {

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
           
        }

        [WebMethod]
        public static int GetStringLength(string input)
        {

            //    return input.Length;
            return 50;
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
           
        }
    }
}