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
    public partial class manualpagnigsorting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if (!IsPostBack)
             {
                Databind();
            }
        }



        public void Databind()
        {
            Connectionclass con = new Connectionclass();
            con.Connectionopen();
            string str = "select top 15 * from Dimaccount";
            con.Executequery(str);

            object obt = con.Showdata(str);
            DataTable dt = (DataTable)obt;

            ViewState["datatable"] = dt;
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
        {
            //string dataTableString = ViewState["datatable"].ToString();

        
            //DataTable dt = new DataTable();
            //if (!string.IsNullOrEmpty(dataTableString))
            //{
            //    using (var reader = new System.IO.StringReader(dataTableString))
            //    {
            //        dt.ReadXml(reader);
            //    }
            //}

            DataTable dt = (DataTable)ViewState["datatable"];
            if(dt != null)
            {

                
                dt.DefaultView.Sort = e.SortExpression + " " + Direction(e.SortExpression );
                GridView1.DataSource=dt.DefaultView;
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
            {   if (sortexpression == column)
                {
                     lastdirection = ViewState["sortdirection"] as string;
                    if ((lastdirection != null) && (lastdirection == "ASC"))
                    {
                        sortdirection = "DESC";
                    }
                }
            }
            ViewState["sortdirection"]= sortdirection;
            ViewState["sortexpression"] = column;


            return sortdirection;
        }




    }
}