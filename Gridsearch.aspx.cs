using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
     public partial class Gridsearch : System.Web.UI.Page
  

    {
        readonly Connectionclass co=new Connectionclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            Binddata(); 
            

        }

        public void Binddata()
        {   
            
            co.Connectionopen();
            string str = "select TOP 12 ResellerKey,Phone,BusinessType,ResellerName,FirstOrderYear,LastOrderYear,ProductLine,AddressLine1 from DimReseller";
       
            GridView1.DataSource = co.Showdata(str);
            GridView1.DataBind();   


        }

        

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

            co.Connectionopen();
            string str = "select TOP 12 ResellerKey,Phone,BusinessType,ResellerName,FirstOrderYear,LastOrderYear,ProductLine,AddressLine1 from DimReseller  where ResellerName LIKE '"+TextBox1.Text+"%'";

            GridView1.DataSource = co.Showdata(str);
            GridView1.DataBind();


        }
    }
}