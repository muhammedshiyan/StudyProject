using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class errorlogfile : System.Web.UI.Page
    {  public  ExceptionLogging except =new ExceptionLogging();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string filepath = string.Empty;
            try
            {
              

                string[] s = new string[2];
                s[10] = "6";

            }

            catch (Exception ex)
            {


                Label1.Text= except.SendErrorToText(ex);

               

            }
            finally {
            }
            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string filepath = string.Empty;

            try
            {
                filepath = @"D:\\StudyProject\\ExceptionDetailsFile\\02-08-23.txt";
                StreamReader sr = new StreamReader(filepath);
                string line = string.Empty;

                string[] lines = File.ReadAllLines(filepath);


                foreach (string l in lines)
                {
                    line += l;

                }
                Label2.Text = line;
            }
            catch(Exception ex)
            {

            }
            finally
            {

            }




        }
    }
}