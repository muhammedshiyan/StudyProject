using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        readonly Connectionclass co = new Connectionclass();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                Bindcountry();
            }





        }

        protected void Bindcountry()
        {


            co.Connectionopen();

            string str = "select * from country";

            object d = co.Showdata(str);
            ddlcountry.DataSource = d;
            ddlcountry.DataTextField = "countryName";
            ddlcountry.DataValueField = "countryID";
            ddlcountry.DataBind();
            ddlcountry.Items.Insert(0, new ListItem("---selectone-----", "0"));
            ddlstate.Items.Insert(0, new ListItem("---selectone----", "0"));
            ddldistrict.Items.Insert(0, new ListItem("---selectone----", "0"));



        }


        protected void OnCountryChange(object sender, EventArgs e)
        {


            try
            {
                co.Connectionopen();
                int cid = Convert.ToInt32(ddlcountry.SelectedValue);
               



                //    string str = "select * from state where countryID='" + cid + "'";
                string str = "select * from state";
                SqlDataReader rdr = co.GetDataReader(str);
                object d = co.Showdata(str);


                ddlstate.DataSource = d;
                ddlstate.DataTextField = "countryName";
                ddlstate.DataValueField = "stateID";
                ddlstate.DataBind();


                ddlstate.Items.Insert(0, new ListItem("---select---", "0"));
                if (ddlstate.SelectedIndex == 0)
                {
                    ddldistrict.Items.Clear();
                    ddldistrict.Items.Insert(0, new ListItem("---select one--", "0"));

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {


            }




        }
        protected void ddlstate_SelectedIndexChanged(object sender, EventArgs e)
        {
            co.Connectionopen();
            int sid = Convert.ToInt32(ddlstate.SelectedValue);


            //   string str = "select * from district where stateid='" + sid + "'";
            string str = "select * from state";
            object d = co.Showdata(str);
            ddldistrict.DataSource = d;
            ddldistrict.DataTextField = "districtName";
            ddldistrict.DataValueField = "district";
            ddldistrict.DataBind();


            ddldistrict.Items.Insert(0, new ListItem("---select---", "0"));
            if (ddlstate.SelectedIndex == 0)
            {
                ddldistrict.Items.Clear();
                ddldistrict.Items.Insert(0, new ListItem("---select one--", "0"));

            }

        }

        protected void ddldistrict_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlcountry_TextChanged(object sender, EventArgs e)
        {

            //co.Connectionopen();
            //string cid = ddlcountry.SelectedItem.Text;


            //string str = "select * from state where countryID='" + cid + "'";

            //object d = co.Showdata(str);
            //ddlstate.DataSource = d;
            //ddlstate.DataTextField = "countryName";
            //ddlstate.DataValueField = "stateID";
            //ddlstate.DataBind();


            //ddlstate.Items.Insert(0, new ListItem("---select---", "0"));
            //if (ddlstate.SelectedIndex == 0)
            //{
            //    ddldistrict.Items.Clear();
            //    ddldistrict.Items.Insert(0, new ListItem("---select one--", "0"));

            //}
        }


        protected void ddlstate_TextChanged(object sender, EventArgs e)
        {

            //co.Connectionopen();
            //string sid = ddlcountry.SelectedItem.Value.ToString();


            //string str = "select * from district where stateid='" + sid + "'";

            //object d = co.Showdata(str);
            //ddldistrict.DataSource = d;
            //ddldistrict.DataTextField = "districtName";
            //ddldistrict.DataValueField = "districtid";
            //ddldistrict.DataBind();


            //ddldistrict.Items.Insert(0, new ListItem("---select---", "0"));
            //if (ddlstate.SelectedIndex == 0)
            //{
            //    ddldistrict.Items.Clear();
            //    ddldistrict.Items.Insert(0, new ListItem("---select one--", "0"));

            //}
        }

        protected void ddldistrict_TextChanged(object sender, EventArgs e)
        {

        }
    }
}