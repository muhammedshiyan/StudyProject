using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class manualpagnigsorting : System.Web.UI.Page
    {
        readonly Connectionclass co = new Connectionclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Databind();
            }
        }



        public void Databind()
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = co.Connectionopen();
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "SP_ManualSort";

                command.Parameters.AddWithValue("@topno", 12);

                SqlDataAdapter adr = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adr.Fill(dt);
                ViewState["datatable"] = dt;
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch (Exception ex) { }
            finally { }


        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
        {

            DataTable dt = (DataTable)ViewState["datatable"];
            if (dt != null)
            {


                dt.DefaultView.Sort = e.SortExpression + " " + Direction(e.SortExpression);
                GridView1.DataSource = dt.DefaultView;
                ViewState["datatable"] = dt;
                GridView1.DataBind();
            }


        }

        public string Direction(string column)
        {
            string sortdirection = "ASC";
            string lastdirection = "";
            string sortexpression = ViewState["sortexpression"] as string;



            if (sortexpression != null)
            {
                if (sortexpression == column)
                {
                    lastdirection = ViewState["sortdirection"] as string;
                    if ((lastdirection != null) && (lastdirection == "ASC"))
                    {
                        sortdirection = "DESC";
                    }
                }
            }
            ViewState["sortdirection"] = sortdirection;
            ViewState["sortexpression"] = column;


            return sortdirection;
        }




    }
}