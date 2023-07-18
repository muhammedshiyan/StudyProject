using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Configuration;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public class Connectionclass
    {
        SqlConnection con;
        public SqlConnection Connectionopen()
        {
            string str = WebConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            con = new SqlConnection(str);

            con.Open();
        return con;

        }



        public void Executequery(string str)
        {

            SqlCommand cmd;


            try
            {
                cmd = null;
                cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cmd = null;
                con.Close();
            }


        }
        public SqlDataReader GetDataReader(string str)
        {
            SqlDataReader rdr = null;
            SqlCommand cmd = null;
            try
            {
                cmd = new SqlCommand(str,con);
                rdr = cmd.ExecuteReader();
                return rdr;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return rdr;
            }
            finally
            {
                con.Close();

            }
        }

        public object Showdata(string str)
        {

            object data = null;
            SqlDataAdapter adr = null;
            try
            {
                adr = new SqlDataAdapter(str, con);
                DataSet ds = new DataSet();
                adr.Fill(ds);
                data = ds.Tables[0];
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return data;
            }

            finally
            {
                adr = null;
                con.Close();
                
            }
        }
        



        }
    }
    