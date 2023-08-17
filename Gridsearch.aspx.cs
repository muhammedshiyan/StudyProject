using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
     public partial class Gridsearch : System.Web.UI.Page
  

    {
        readonly Connectionclass co=new Connectionclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            Binddata(); 
            

        }

        public void Binddata()
        {
            try
            {
                co.Connectionopen();
                // string str = "select TOP 12 ResellerKey,Phone,BusinessType,ResellerName,FirstOrderYear,LastOrderYear,ProductLine,AddressLine1 from DimReseller";


                SqlCommand command = new SqlCommand();
                command.Connection = co.Connectionopen();
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "sp_GridSearch";

                command.Parameters.AddWithValue("@top", 15);



                SqlDataAdapter adr = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adr.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch(Exception ex) { }
            finally { }
           


        }

        

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = co.Connectionopen();
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "sp_GridSearchLike";

                command.Parameters.AddWithValue("@top", 15);
                command.Parameters.AddWithValue("@textchange", TextBox1.Text);

                SqlDataAdapter adr = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adr.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch(Exception ex) { }
            finally { }


        }
    }
}