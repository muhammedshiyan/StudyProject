using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
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

            SqlDataReader rdr = co.GetDataReader(str);
                

            while(rdr.Read())
            { 
            ddlcountry.Items.Add(rdr.GetValue(0).ToString());
            
            
            }
            
            
            ddlcountry.Items.Insert(0, new ListItem("---selectone-----", "0"));
            ddlstate.Items.Insert(0, new ListItem("---selectone----", "0"));
            ddldistrict.Items.Insert(0, new ListItem("---selectone----", "0"));



        }


        protected void Ddlcountry_SelectedIndexChanged(object sender, EventArgs e)
        {


            co.Connectionopen();
            int cid = Convert.ToInt32(ddlcountry.SelectedValue);


            string str = "select * from state where countryID='" + cid + "'";

            SqlDataReader rdr = co.GetDataReader(str);
            int i = 1;
            ddlstate.Items.Clear();
            ddlstate.Items.Insert(0, new ListItem("---selectone----", "0"));

            while (rdr.Read())
            {

                ddlstate.Items.Insert(i, new ListItem(rdr.GetValue(0).ToString(), rdr["stateID"].ToString()));


                i++;


            }
            //while (rdr.Read())
            //{

            //    ddlstate.Items.Add(rdr.GetValue(1).ToString());

            //}

 
            if (ddlstate.SelectedIndex == 0)
            {
                ddldistrict.Items.Clear();
                ddldistrict.Items.Insert(0, new ListItem("---select one--", "0"));

            }





        }
        protected void Ddlstate_SelectedIndexChanged(object sender, EventArgs e)
        {
;
            co.Connectionopen();
            int sid = Convert.ToInt32(ddlstate.SelectedValue);


            string str = "select * from district where stateid='" + sid + "'";



            SqlDataReader rdr = co.GetDataReader(str);
            int i = 1;
            ddlstate.Items.Clear();
            ddlstate.Items.Insert(0, new ListItem("---selectone----", "0"));

            while (rdr.Read())
            {

                ddlstate.Items.Insert(i, new ListItem(rdr.GetValue(0).ToString(), rdr["stateID"].ToString()));


                i++;


            }
            //while (rdr.Read())
            //{

            //    ddlstate.Items.Add(rdr.GetValue(1).ToString());

            //}

            ddldistrict.Items.Insert(0, new ListItem("---select---", "0"));
            if (ddlstate.SelectedIndex == 0)
            {
                ddldistrict.Items.Clear();
                ddldistrict.Items.Insert(0, new ListItem("---select one--", "0"));

            }

        }

        protected void Ddldistrict_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}