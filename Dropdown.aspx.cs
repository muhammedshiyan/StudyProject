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
            try
            {
                co.Connectionopen();
                SqlCommand command = new SqlCommand();
                command.Connection = co.Connectionopen();
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "sp_SelectCountry";
                SqlDataAdapter adr = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adr.Fill(dt);


                ddlcountry.DataSource = dt;
                ddlcountry.DataTextField = "countryName";
                ddlcountry.DataValueField = "countryID";
                ddlcountry.DataBind();
                ddlcountry.Items.Insert(0, new ListItem("---selectone-----", "0"));
                ddlstate.Items.Insert(0, new ListItem("---selectone----", "0"));
                ddldistrict.Items.Insert(0, new ListItem("---selectone----", "0"));
            }
            catch (Exception ex) { }
            finally { }



        }


        protected void OnCountryChange(object sender, EventArgs e)
        {


            try
            {
                int countyid = Convert.ToInt32(ddlcountry.SelectedValue);

                SqlCommand command = new SqlCommand();
                command.Connection = co.Connectionopen();
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "sp_Selectstate";
                command.Parameters.AddWithValue("@countryid", countyid);

                SqlDataAdapter adr = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adr.Fill(dt);


                ddlstate.DataSource = dt;
                ddlstate.DataTextField = "stateName";
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
            try
            {
                int stateid = Convert.ToInt32(ddlstate.SelectedValue);

                SqlCommand command = new SqlCommand();
                command.Connection = co.Connectionopen();
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "sp_SelectDistrict";
                command.Parameters.AddWithValue("@stateid", stateid);

                SqlDataAdapter adr = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                adr.Fill(ds);

                ddldistrict.DataSource = ds.Tables[0];
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
            catch (Exception ex) { }
            finally { }
    
        }

        protected void ddldistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
        

        }

        protected void ddlcountry_TextChanged(object sender, EventArgs e)
        {

          
        }


        protected void ddlstate_TextChanged(object sender, EventArgs e)
        {

           
        }

        protected void ddldistrict_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }
    }
}