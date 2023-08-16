using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Data;
using System.Drawing;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class webmethod : System.Web.UI.Page
    {
        readonly Connectionclass co = new Connectionclass();
        protected void Page_Load(object sender, EventArgs e)
        {



        }

        
        protected void DropDownList1_CallingDataMethods(object sender, CallingDataMethodsEventArgs e)
       {

        }
    }
}