using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Data;
using System.Drawing;
using System.Web.Script.Serialization;



namespace WebApplication1
{
    public partial class webmethod : System.Web.UI.Page
    {
        readonly Connectionclass co = new Connectionclass();
        protected void Page_Load(object sender, EventArgs e)
        {

            GetProduct();

        }
        
        [System.Web.Services.WebMethod]
        [System.Web.Script.Services.ScriptMethod]
        public string GetProduct()
        {

            var productList = GetProductData();


            var serializer = new JavaScriptSerializer();
            var json = serializer.Serialize(productList);
            Response.Write(json);
            return json;
        }
        public List<ListItem> GetProductData()
        {
            co.Connectionopen();

            List<ListItem> list_product = new List<ListItem>();

            string str = "select top 12 ProductKey,EnglishProductName  from DimProduct";


            GridView1.DataSource = co.Showdata(str);
            GridView1.DataBind();

            DropDownList1.DataBind();
            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    string id = row.Cells[0].Text;
                    string name = row.Cells[1].Text;

                    list_product.Add(new ListItem(name, id));
                }
            }
            return list_product;
        }

    }
}