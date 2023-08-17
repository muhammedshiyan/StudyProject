using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnThrowException_Click(object sender, EventArgs e)
        {

            try
            {
               
                int result = Divide(10, 0);
            }
            catch (Exception ex)
            {
                
                string stackTrace = ex.StackTrace;
                lblStackTrace.Text = stackTrace;
            }
        }
        private int Divide(int a, int b)
        {
            return a / b;
        }
    }
}