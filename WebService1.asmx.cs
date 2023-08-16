using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    
    [WebService(Namespace = "WebApplication1")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        readonly public Connectionclass co=new Connectionclass();
 
        [WebMethod]
        public DataTable data() {
            SqlCommand command = new SqlCommand();
            command.Connection = co.Connectionopen();
            command.CommandText = "sp_XmlSerialise";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@top", 5);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dt.TableName = "DepartmentData";

            return dt;
        }

        [WebMethod]
        public string Sum() {


            return "success";
        }



    }
}
