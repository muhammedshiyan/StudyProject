using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
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
    public partial class jsonserialiseanddeserialise : System.Web.UI.Page
    {
         readonly Connectionclass co=new Connectionclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Databind();
            }
            
        }

        public  void Databind()
        {
            string json = string.Empty;
            try {

                SqlCommand command=new SqlCommand();
                command.Connection = co.Connectionopen();
                command.CommandText = "sp_deserialise";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@topno",20);

                SqlDataAdapter adapter = new SqlDataAdapter(command);   
                DataTable dt=new DataTable();
                adapter.Fill(dt);

                Session["CONTENT"] = dt;
               

            }
            catch(Exception ex) {
              
                Label1.Text = ex.Message;
            }
            finally { }

        }
        public void Serialise()
        {  string json = string.Empty;  
            json = JsonConvert.SerializeObject(Session["CONTENT"]);
            Label1.Text = json;
            Session["CONTENT"] = json;
            Session["n"] = "1";
        }





        protected void Button1_Click(object sender, EventArgs e)
        {
            Serialise();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {

            if(Session["n"]==null)
            {
                Session["CONTENT"] = JsonConvert.SerializeObject(Session["CONTENT"]);
                Session["n"] = "1";
            }
            Label1.Text = "";
            if (Session["n"].ToString() == "1")
            {
                GridView1.DataSource = JsonConvert.DeserializeObject<DataTable>((string)Session["CONTENT"]);
                GridView1.DataBind();
                Session["n"] = "0";
            }
        }
    }
}