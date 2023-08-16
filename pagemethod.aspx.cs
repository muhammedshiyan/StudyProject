using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class filldropdownbypagemethode : System.Web.UI.Page
    {
       readonly Connectionclass co = new Connectionclass();

     
       public static DataTable dt = new DataTable();
    
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = co.Connectionopen();
            command.CommandText = "sp_pagemethod1";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@topno", 20);


            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);


            if (Request.Form["DropListName"] != null)
               lblSubmitValue.Text = String.Format("Submitted Value: \"{0}\"",
               Request.Form["DropListName"]);
        }
        public class ListData
        {
            public string text { get; set; }
            public int value { get; set;}
        }
        [System.Web.Services.WebMethod]
        [System.Web.Script.Services.ScriptMethod]
        public static IEnumerable<ListData> GetListData(int arg)
        {
            List<ListData> list = new List<ListData>();


            foreach (DataRow row in dt.Rows)
            {

                string text = row["STATENAME"].ToString();
                int value = Convert.ToInt32(row["STATEID"]);

                list.Add(new ListData()
                {
                    text = text,
                    value = value
                });
            }


            return list;
        }
    }

}


