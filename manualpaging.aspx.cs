﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using WebGrease.Css.Ast;
using System.Security.Cryptography.X509Certificates;
using System.EnterpriseServices;

namespace WebApplication1
{
    public partial class manualsorting : System.Web.UI.Page
    {
        readonly Connectionclass co = new Connectionclass();    
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Custom(1,5);
            }
            Addpagingbutton();

        }
        protected void Custom(int Pageno,int Noofrecord)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = co.Connectionopen();
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "SP_CustomPaging";

                SqlParameter pageNo = new SqlParameter("@Pageno", Pageno);
                SqlParameter noOfRecord = new SqlParameter("@Noofrecord", Noofrecord);
                SqlParameter tottalsp = new SqlParameter("@Tottalrecord", System.Data.SqlDbType.Int);
                tottalsp.Direction = System.Data.ParameterDirection.Output;

                command.Parameters.Add(pageNo);
                command.Parameters.Add(noOfRecord);
                command.Parameters.Add(tottalsp);
       
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(dt);

                int Tottalrecord = 0 ;

                if (tottalsp.Value != null)
                {

                    int.TryParse(tottalsp.Value.ToString(), out Tottalrecord);

                }


                GridView1.DataSource = dt;
                GridView1.DataBind();
                Tottalrecord = (Tottalrecord/5);


                ViewState["tottalrecord"] = Tottalrecord;
                ViewState["Noofrecord"] = Noofrecord;

            }
            catch (Exception e)
            {

            }
            finally
            {

            }
        }

        protected void Addpagingbutton()
        {
            try
            {
                int tottalrecord = 0;
                int noofrecord = 0;
                tottalrecord = ViewState["tottalrecord"] != null ? (int)ViewState["tottalrecord"] : 0;
                noofrecord = ViewState["Noofrecord"] != null ? (int)ViewState["Noofrecord"] : 0;
                int pages = 0;
                if (tottalrecord > 0 && noofrecord > 0)
                {

                    pages = (tottalrecord / noofrecord) + ((tottalrecord % noofrecord) > 0 ? 1 : 0);
                    for (int i = 0; i < pages; i++)
                    {
                        Button b = new Button();
                        b.Text = (i + 1).ToString();
                        b.CommandArgument = (i + 1).ToString();
                        b.ID = "Button" + (i + 1).ToString();
                        b.Click += new EventHandler(this.b_click);

                        Panel1.Controls.Add(b);

                    }
                }

            }
            catch (Exception e) { }
            finally { }

        }

        protected void b_click(object sender, EventArgs e)
        {
            try
            {
                string pageno = ((Button)sender).CommandArgument;
                Custom(Convert.ToInt32(pageno), 5);
            }
            catch (Exception ex) { }
            finally { }
        }


    }
}