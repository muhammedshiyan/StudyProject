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

            try
            {
                co.Connectionopen();

                SqlCommand command = new SqlCommand();
                command.Connection = co.Connectionopen();
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "sp_SelectCountry";

                SqlDataReader rdr = command.ExecuteReader();
                int i = 0;
                while (rdr.Read())
                {
                    //ddlcountry.Items.Add(rdr.GetValue(2).ToString());
                    ddlcountry.Items.Insert(i, new ListItem(rdr.GetValue(2).ToString(), rdr.GetValue(1).ToString()));
                    i++;

                }

                ddlcountry.Items.Insert(0, new ListItem("---selectone-----", "0"));
                ddlstate.Items.Insert(0, new ListItem("---selectone----", "0"));
                ddldistrict.Items.Insert(0, new ListItem("---selectone----", "0"));
            }
            catch (Exception ex) { }
            finally { }
           



        }


        protected void Ddlcountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                int countyid = Convert.ToInt32(ddlcountry.SelectedValue);

                co.Connectionopen();

                SqlCommand command = new SqlCommand();
                command.Connection = co.Connectionopen();
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "sp_Selectstate";
                command.Parameters.AddWithValue("@countryid", countyid);

                SqlDataReader rdr = command.ExecuteReader();
                int i = 1;
                while (rdr.Read())
                {

                    ddlstate.Items.Insert(i, new ListItem(rdr.GetValue(2).ToString(), rdr.GetValue(1).ToString()));
                    i++;

                }


                if (ddlstate.SelectedIndex == 0)
                {
                    ddldistrict.Items.Clear();
                    ddldistrict.Items.Insert(0, new ListItem("---select one--", "0"));

                }
            }
            catch(Exception ex) { } 
            finally { }






        }
        protected void Ddlstate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                int stateid = Convert.ToInt32(ddlstate.SelectedValue);

                SqlCommand command = new SqlCommand();
                command.Connection = co.Connectionopen();
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "sp_SelectDistrict";
                command.Parameters.AddWithValue("@stateid", stateid);

                SqlDataReader rdr = command.ExecuteReader();
                int i = 0;
                ddldistrict.Items.Clear();
                while (rdr.Read())
                {

                    ddldistrict.Items.Insert(i, new ListItem(rdr.GetValue(2).ToString(), rdr.GetValue(1).ToString()));
                    i++;

                }


                ddldistrict.Items.Insert(0, new ListItem("---select---", "0"));
                if (ddlstate.SelectedIndex == 0)
                {
                    ddldistrict.Items.Clear();
                    ddldistrict.Items.Insert(0, new ListItem("---select one--", "0"));

                }
            }
            catch (Exception ex) { }    
            finally { } 

            

        }

        protected void Ddldistrict_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}