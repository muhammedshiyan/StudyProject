using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;


namespace WebApplication2
{

    [WebService(Namespace = " WebApplication2")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    // [System.Web.Script.Services.ScriptService]
    public class WebService2 : System.Web.Services.WebService
    {
       

        [WebMethod]
        public int DataWebService2(int num1,int num2)
        {

            int result = num1 + num2;


            return result;
        }


    }
}
