using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
       readonly Connectionclass co = new Connectionclass();
        protected void Page_Load(object sender, EventArgs e)
        {
             Gridbind();


        }


        public void Gridbind()
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = co.Connectionopen();
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "sp_GridPaging";
                command.Parameters.AddWithValue("@topno",12);

                DataTable dt= new DataTable();
                SqlDataAdapter adr = new SqlDataAdapter(command);
                adr.Fill(dt);

                ViewState["paging"] = dt;
                GridView1.DataSource = dt;
                GridView1.DataBind();

            }
            catch (Exception ex) { }
            finally { }


        }

       

        protected void Gridchanging(object sender, GridViewPageEventArgs e)
        {

            try
            {
                GridView1.PageIndex = e.NewPageIndex;
                GridView1.DataSource = ViewState["paging"];
                GridView1.DataBind();
            }
            catch (Exception ex) { }
            finally { } 
        }


    }
    }
