using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class htmltablecreation : System.Web.UI.Page
    { readonly Connectionclass co=new Connectionclass(); 
        StringBuilder table=new StringBuilder();    
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        public void BindData()
        {
            try
            {
                co.Connectionopen();

                SqlCommand command = new SqlCommand();
                command.Connection = co.Connectionopen();
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "sp_SelectCountry";

                SqlDataReader rdr = command.ExecuteReader();

                table.Append("<Table border='1'>");
                table.Append("<tr><th>country</th><th>id</th>");
                table.Append("</tr");

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        table.Append("<tr>");
                        table.Append("<td>" + rdr[0] + "</td>");
                        table.Append("<td>" + rdr[1] + "</td>");
                        table.Append("</tr>");


                    }
                }

                table.Append("</table>");
                PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });
                rdr.Close();
            }
            catch(Exception ex) { }
            finally { }

        }





    }
}