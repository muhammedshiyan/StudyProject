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

                string str = "select top 100 CustomerKey,GeographyKey,CustomerAlternateKey,Title,FirstName,MiddleName,LastName,EmailAddress from Dimcustomer";

                co.Connectionopen();
                ViewState["paging"] = co.Showdata(str);
                GridView1.DataSource = co.Showdata(str);
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
