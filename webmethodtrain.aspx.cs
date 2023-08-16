using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using System.Web.Script.Services;

namespace WebApplication1
{
    public partial class webmethodtrain : System.Web.UI.Page
    {
        public class person

        {

            public string name { get; set; }

        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

   
        [System.Web.Services.WebMethod]
        [System.Web.Script.Services.ScriptMethod]

        public static person GetData(string name)

        {

            person p = new person();

            p.name = name;

            return p;

        }
    }
}