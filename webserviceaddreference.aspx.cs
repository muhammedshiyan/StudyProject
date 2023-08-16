using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication1
{
    public partial class webserviceaddreference : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            ServiceReferencedata1.WebService1SoapClient client= new ServiceReferencedata1.WebService1SoapClient();

            client.data();
            
            
            GridView1.DataSource = client.data();
            GridView1.DataBind();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
          ServiceReferencesum.WebService1SoapClient cl= new ServiceReferencesum.WebService1SoapClient();
           
           Label5.Text= cl.Sum();    

        }
    }
}