using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class drop : System.Web.UI.Page
    {
        readonly Connectionclass co = new Connectionclass();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCountry();
                Bind();

            }


        }

        public void BindCountry()
        {
            try
            {
                co.Connectionopen();
                string str = "select * from tbl_country";
                DropDownList1.DataSource = co.Showdata(str);
                DropDownList1.DataTextField = "COUNTRYNAME";
                DropDownList1.DataValueField = "COUNTRYID";
                DropDownList1.DataBind();
            }
            catch (Exception ex) { }
           
            finally { }
            
        }

        public void Bind()
        {
            try
            {
                string str = "select * from tbl_state ";

                DropDownList2.DataSource = co.Showdata(str);
                DropDownList2.DataTextField = "STATENAME";
                DropDownList2.DataValueField = "STATEID";
                DropDownList2.DataBind();

                string st = "select * from tbl_district";

                DropDownList3.DataSource = co.Showdata(st);
                DropDownList3.DataTextField = "DISTRICTNAME";
                DropDownList3.DataValueField = "DISTRICT";
                DropDownList3.DataBind();

            }
            catch (Exception ex) { }

            finally { }
         
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int cid = Convert.ToInt32(DropDownList1.SelectedValue);

                string str = "select * from tbl_state  where COUNTRYID='" + cid + "'";

                DropDownList2.DataSource = co.Showdata(str);
                DropDownList2.DataTextField = "STATENAME";
                DropDownList2.DataValueField = "STATEID";
                DropDownList2.DataBind();
            }
            catch(Exception ex) { }

            finally { }
          


        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                int sid = Convert.ToInt32(DropDownList1.SelectedValue);

                string str = "select * from tbl_district where STATEID='" + sid + "'";

                DropDownList3.DataSource = co.Showdata(str);
                DropDownList3.DataTextField = "DISTRICTNAME";
                DropDownList3.DataValueField = "DITRICT";
                DropDownList3.DataBind();
            }
            catch (Exception ex) { }

            finally { }
            

        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}