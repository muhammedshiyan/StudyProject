using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {

      readonly Connectionclass co=new Connectionclass();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if(!IsPostBack)
            {
                Binddata();
            }
        }

        public void Binddata()
        {
            try
            {
                co.Connectionopen();
              
                string str = "select top 15 CustomerKey,GeographyKey,CustomerAlternateKey,Title,FirstName,MiddleName,LastName,EmailAddress from Dimcustomer";
                

                object d = co.Showdata(str);
                DataTable dt = new DataTable();
                dt = (DataTable)d;
                ViewState["table"] = dt;
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch { }
            finally { }

        }

      #pragma warning disable IDE0060 // Remove unused parameter 'direction' if it is not part of a shipped public API
        public SortDirection CurrentSortDirection
        {
            
                get
            {
                    if (ViewState["sortdirection"] == null)
                    {
                        ViewState["sortdirection"] = SortDirection.Ascending;

                    }

                    return (SortDirection)ViewState["sortdirection"];



                }
                set
            {
                    ViewState["sortdirectoin"] = value;
                }
           

        }



        protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
        {
            try
            {

                if (CurrentSortDirection == SortDirection.Ascending)
                {
                    CurrentSortDirection = SortDirection.Descending;

                    Sortgrid(e.SortExpression, "ASC");

                }

                else
                {
                    CurrentSortDirection = SortDirection.Ascending;
                    Sortgrid(e.SortExpression, "DESC");
                }

            }
            catch (Exception ex) { }
            finally { }
        }

        public void Sortgrid(string sortexpression,string direction)
        {
            try
            {

                dynamic dt = ViewState["table"];
                DataView dv = new DataView(dt)
                {
                    Sort = sortexpression
                };



                GridView1.DataSource = dv;
                GridView1.DataBind();
            }
            catch(Exception ex) { }
            finally { }
        
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        }
    }
}
