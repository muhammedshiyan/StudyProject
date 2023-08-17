using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class highlightmouseover : System.Web.UI.Page
    {
        readonly Connectionclass co = new Connectionclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            Binddata();



        }

        public void Binddata()
        {
            try
            {
                co.Connectionopen();
                string str = "select TOP 12 ResellerKey,GeographyKey,Phone,BusinessType,ResellerName,FirstOrderYear,LastOrderYear,ProductLine,AddressLine1 from DimReseller";

                GridView1.DataSource = co.Showdata(str);
                GridView1.DataBind();
            }
            catch(Exception ex) { }
            finally { }
           



        }


        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {

            try
            {
                if (e.Row.RowType == System.Web.UI.WebControls.DataControlRowType.DataRow)
                {


                    e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#FF1493'");


                    e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
                }


            }
            catch(Exception ex) { }
            finally { } 
        }
    }
}