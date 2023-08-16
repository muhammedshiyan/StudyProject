using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    
    [WebService(Namespace = "WebApplication1")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    
     [System.Web.Script.Services.ScriptService]
    public class autocomplete : System.Web.Services.WebService
    {
        readonly static Connectionclass co = new Connectionclass();

        [WebMethod]
        public  List<string> GetEmpNames(string empName)
        {
            List<string> Emp = new List<string>();
            co.Connectionopen();

            SqlCommand command = new SqlCommand();
            command.Connection = co.Connectionopen();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "sp_Autocomplete";
            command.Parameters.AddWithValue("@topno", 20);
            command.Parameters.AddWithValue("@text", empName);


            SqlDataReader rdr = command.ExecuteReader();

            while (rdr.Read())
            {
                Emp.Add(rdr.GetString(0));
            }

            return Emp;

          
        }
       
    }
}
