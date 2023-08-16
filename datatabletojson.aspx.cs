using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.Text;

namespace WebApplication1
{
    public partial class datatabletojson : System.Web.UI.Page
    {
        readonly Connectionclass co= new Connectionclass();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                try
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = co.Connectionopen();
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = "sp_DataTableToJson";
                    command.Parameters.AddWithValue("@topno", 10);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable t = new DataTable();
                    adapter.Fill(t);

                    ViewState["t"] = t;
                }
                catch(Exception ex) { }
                
                finally { }
            }



        }

        public string TableToJon(DataTable t)
        {
            
         

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> RowList = new List<Dictionary<string, object>>();
            Dictionary<string, object> EachRow;

            foreach (DataRow row in t.Rows)
            {
                EachRow = new Dictionary<string, object>();

                foreach (DataColumn col in t.Columns)
                {
                    EachRow.Add(col.ColumnName, row[col]);

                }

                RowList.Add(EachRow);

            }

            return serializer.Serialize(RowList);
        }

        public string StringBuilderToJson(DataTable t)
        {

            var jsonString = new StringBuilder();
            if (t.Rows.Count > 0)
            {
                jsonString.Append("[");
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    jsonString.Append("{");
                    for (int j = 0; j < t.Columns.Count; j++)
                    {
                        if (j < t.Columns.Count - 1)
                        {
                            jsonString.Append("\"" + t.Columns[j].ColumnName.ToString()
                                              + "\":" + "\""
                                              + t.Rows[i][j].ToString() + "\",");
                        }
                        else if (j == t.Columns.Count - 1)
                        {
                            jsonString.Append("\"" + t.Columns[j].ColumnName.ToString()
                                              + "\":" + "\""
                                              + t.Rows[i][j].ToString() + "\"");
                        }
                    }
                    if (i == t.Rows.Count - 1)
                    {
                        jsonString.Append("}");
                    }
                    else
                    {
                        jsonString.Append("},");
                    }
                }
                jsonString.Append("]");
            }
            return jsonString.ToString();
           
        }

        public string Tojson(DataTable t)
        {

            string json = string.Empty;
            json=JsonConvert.SerializeObject(t);
            return json;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable t = new DataTable();
            t = (DataTable)ViewState["t"];
            Label2.Text = "Using JavaScriptSerializer";
            Label1.Text = TableToJon(t);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DataTable t = new DataTable();
            t = (DataTable)ViewState["t"];
            Label2.Text = "Json.Net DLL";
            Label1.Text = Tojson(t);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            DataTable t = new DataTable();
            t = (DataTable)ViewState["t"];
            Label2.Text = "string builder";
            Label1.Text = Tojson(t);

        }
    }
}