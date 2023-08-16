using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Web.DynamicData;
using Microsoft.Ajax.Utilities;

namespace WebApplication1
{

    [WebService(Namespace = "WebApplication1")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    [System.Web.Script.Services.ScriptService]
    public class Webmethod1 : System.Web.Services.WebService
    {
        readonly Connectionclass co = new Connectionclass();

        protected void Page_Load(object sender, EventArgs e)
        {



        }

        //[System.Web.Services.WebMethod]
        //[System.Web.Script.Services.ScriptMethod]
        //[ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        [WebMethod]
        public string GetProduct()
        {
            string json = string.Empty;

            try
            {
                var productList = GetProductData();


                var serializer = new JavaScriptSerializer();
                json = serializer.Serialize(productList);

                if (json == null)
                {
                    json = "error";
                }

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
            finally
            {

            }
            return json;
        }

    



    //[System.Web.Services.WebMethod]
    //[System.Web.Script.Services.ScriptMethod]
    [WebMethod]


    public List<ListItem> GetProductData()
    {
        List<ListItem> list_product = new List<ListItem>();


        try
        {
            SqlCommand command = new SqlCommand();
            command.Connection = co.Connectionopen();
            command.CommandText = "sp_webmethod";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@topno", 20);


            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                list_product.Add(new ListItem(row["EnglishProductName"].ToString(), row["ProductKey"].ToString()));
            }
            if (list_product.Count == 0)
            {
                list_product.Add(new ListItem("None", "0"));
            }

           

        }
        catch (Exception ex)
        {
            list_product.Add(new ListItem(ex.ToString(), "-1"));
        }
        finally
        {
            
        }
        return list_product;


    }



}
}
