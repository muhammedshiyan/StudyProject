using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class sql : System.Web.UI.Page
    {
        Connectionclass co = new Connectionclass();

        public string s = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void function_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = co.Connectionopen();

                if (function.Text == "function Button")
                {
                    function.BackColor = Color.Aquamarine;


                    command.CommandText = "sp_FUNDimSalesReason";
                    command.CommandType = System.Data.CommandType.StoredProcedure;



                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    function.Text = "scalar function Button";
                }
                else
                {
                    function.BackColor = Color.Cyan;

                    command.CommandText = "sp_FUNDimOrganization";
                    command.CommandType = System.Data.CommandType.StoredProcedure;



                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    function.Text = "function Button";
                }


            }
            catch(Exception ex) { }
            finally { }



        }

        protected void view_Click(object sender, EventArgs e)
        {
            try {
                view.BackColor = Color.Aquamarine;



                SqlCommand command = new SqlCommand();
                command.Connection = co.Connectionopen();
                command.CommandText = "sp_VIEWFactSalesQuota";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                //  command.Parameters.AddWithValue("", "");


                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch(Exception ex) { }
            finally { }

            


        }

        protected void trigger_Click(object sender, EventArgs e)
        {
            try
            {
                trigger.BackColor = Color.Aquamarine;

                SqlCommand command = new SqlCommand();
                command.Connection = co.Connectionopen();
                command.CommandText = "sp_trigUpdateDimPromotion";
                command.CommandType = System.Data.CommandType.StoredProcedure;



                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch (Exception ex) { }
            finally { }
           

        }

        protected void groupbyhavingOrderby_Click(object sender, EventArgs e)
        {
            try
            {
                groupbyhavingOrderby.BackColor = Color.Aquamarine;

                SqlCommand command = new SqlCommand();
                command.Connection = co.Connectionopen();
                command.CommandText = "sp_OrderbyGroupbyHaving";
                command.CommandType = System.Data.CommandType.StoredProcedure;




                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch(Exception ex) { }
            finally { }
           



        }

        protected void offsetfetchnext_Click(object sender, EventArgs e)
        {
            try {
                SqlCommand command = new SqlCommand();
                command.Connection = co.Connectionopen();
                if (offsetfetchnext.Text == "offsetFetchNextRows")
                {
                    offsetfetchnext.BackColor = Color.Aquamarine;

                    command.CommandText = "sp_FetchNextRowsFactCallCenter";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NoOfCoutWanted", 5);
                    command.Parameters.AddWithValue("@StartingCoutWanted", 6);



                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    offsetfetchnext.Text = "offset-fetch-next-LASTCOUNT";
                }
                else
                {
                    offsetfetchnext.BackColor = Color.Cyan;

                    command.CommandText = "sp_FetchLastRowsFactCallCenter";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NoOfCoutWanted", 5);




                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    offsetfetchnext.Text = "offsetFetchNextRows";

                }
            }
            catch(Exception ex) { }
            finally { }
            


        }

        protected void aggregatefunctions_Click(object sender, EventArgs e)
        {
            try {
                SqlCommand command = new SqlCommand();
                command.Connection = co.Connectionopen();
                aggregatefunctions.BackColor = Color.Aquamarine;

                if (aggregatefunctions.Text == "aggregate functions ")
                {
                    aggregatefunctions.Text = "aggregate functions Button";
                }

                if (aggregatefunctions.Text == "aggregate function avg Button")
                {
                    command.CommandText = "sp_AVGDimReseller";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    GridView1.DataSource = dt;
                    GridView1.DataBind();

                    aggregatefunctions.Text = "aggregate functions ";
                }

                if (aggregatefunctions.Text == "aggregate function min Button")
                {
                    command.CommandText = "sp_minDimReseller";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    aggregatefunctions.Text = "aggregate function avg Button";
                }
                if (aggregatefunctions.Text == "aggregate function sum Button")
                {
                    command.CommandText = "sp_sumDimReseller";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    GridView1.DataSource = dt;
                    GridView1.DataBind();

                    aggregatefunctions.Text = "aggregate function min Button";
                }

                if (aggregatefunctions.Text == "aggregate functions Button")
                {

                    command.CommandText = "sp_countDimReseller";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    aggregatefunctions.Text = "aggregate function sum Button";
                }
            }
            catch(Exception ex) { }
            finally { }



        }

        protected void joins_Click(object sender, EventArgs e)
        {
            try {
                SqlCommand command = new SqlCommand();
                command.Connection = co.Connectionopen();
                if (joins.Text == "full joins Button")
                {
                    joins.BackColor = Color.Cyan;

                    command.CommandText = "sp_fulljoin";
                    command.CommandType = System.Data.CommandType.StoredProcedure;


                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    joins.Text = "joins Button";


                }


                if (joins.Text == "right joins Button")
                {
                    joins.BackColor = Color.Aquamarine;

                    command.CommandText = "sp_rightjoin";
                    command.CommandType = System.Data.CommandType.StoredProcedure;


                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    joins.Text = "full joins Button";


                }



                if (joins.Text == "left joins Button")
                {
                    joins.BackColor = Color.Cyan;

                    command.CommandText = "sp_leftjoin";
                    command.CommandType = System.Data.CommandType.StoredProcedure;


                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    joins.Text = "right joins Button";
                }
                if (joins.Text == "joins  Button")
                {

                    joins.BackColor = Color.Aquamarine;

                    command.CommandText = "sp_InnerJoin";
                    command.CommandType = System.Data.CommandType.StoredProcedure;


                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    joins.Text = "left joins Button";
                }
            }
            catch (Exception ex) { }
            finally { }
            








        }

        protected void servicebroker_Click(object sender, EventArgs e)
        {
            try
            {
                string str = WebConfigurationManager.ConnectionStrings["myco"].ConnectionString;

                SqlConnection connection = new SqlConnection(str);
                SqlCommand command = new SqlCommand();
                command.Connection = connection;


                command.CommandText = "sp_DataFromTransmissionQueue";
                command.CommandType = System.Data.CommandType.StoredProcedure;


                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch(Exception ex) { }
            finally { }








        }

        protected void targetqueue_Click(object sender, EventArgs e)
        {
            try {
                string str = WebConfigurationManager.ConnectionStrings["myco"].ConnectionString;

                SqlConnection connection = new SqlConnection(str);
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                //  command.CommandText = "SP_ChangeTargetQueueStatus";
                if (targetqueue.Text == "Change TargetQueue Status")
                {

                    command.CommandText = "SP_TargetQueueEnable";
                    command.CommandType = System.Data.CommandType.StoredProcedure;


                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    targetqueue.Text = "Change TargetQueue to disable";
                }
                else
                {
                    command.CommandText = "SP_TargetQueueDisable";
                    command.CommandType = System.Data.CommandType.StoredProcedure;


                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    targetqueue.Text = "Change TargetQueue Status";

                }
            }
            catch(Exception ex) { }
            finally { }
            

        }

        protected void messagesend_Click(object sender, EventArgs e)
        {
            try {
                string str = WebConfigurationManager.ConnectionStrings["myco"].ConnectionString;

                SqlConnection connection = new SqlConnection(str);
                SqlCommand command = new SqlCommand();
                command.Connection = connection;


                command.CommandText = "sp_ServicebrokerSendMessage";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@message_body", TextBox1.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch(Exception ex) { }
            finally { }





        }

        protected void target_Click(object sender, EventArgs e)
        {
            try {
                string str = WebConfigurationManager.ConnectionStrings["myco"].ConnectionString;

                SqlConnection connection = new SqlConnection(str);
                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandText = "sp_DataFromTargetQueue";
                command.CommandType = System.Data.CommandType.StoredProcedure;


                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch (Exception ex) { }
            finally { }
            




        }

        protected void test_Click(object sender, EventArgs e)
        {

            try {
                string str = WebConfigurationManager.ConnectionStrings["myco"].ConnectionString;

                SqlConnection connection = new SqlConnection(str);
                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandText = "sp_DataFromTestQueue";
                command.CommandType = System.Data.CommandType.StoredProcedure;


                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch (Exception ex) { }
            finally { }
            





        }

        protected void questatus_Click(object sender, EventArgs e)
        {
            try
            {
                string str = WebConfigurationManager.ConnectionStrings["myco"].ConnectionString;

                SqlConnection connection = new SqlConnection(str);
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandText = "SP_Queuestatus";
                command.CommandType = System.Data.CommandType.StoredProcedure;


                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch(Exception ex) { }
            finally { }




        }
    }
}