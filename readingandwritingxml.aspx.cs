using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace WebApplication1
{
    public partial class readingandwritingxml : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowXmlData();
            }
             
            

        }


        public void ShowXmlData()
        {
            DataSet ds = new DataSet();
            try
            {
                ds.ReadXml(Server.MapPath("~/XMLFile1.xml"));


                if (ds.Tables.Count > 0)
                {
                    GridView1.DataSource = ds.Tables[0];
                    GridView1.DataBind();


                }

            }
            catch(Exception ex) { }
            finally { }





        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(Server.MapPath("XMLFile1.xml"));

                XmlElement parent = xmlDoc.CreateElement("UserData");

                XmlElement name = xmlDoc.CreateElement("name");
                name.InnerText = TextBox1.Text;

                XmlElement age = xmlDoc.CreateElement("age");
                age.InnerText = TextBox2.Text;

                XmlElement place = xmlDoc.CreateElement("place");
                place.InnerText = TextBox3.Text;


                XmlElement time = xmlDoc.CreateElement("time");
                time.InnerText = DateTime.Now.ToString();

                parent.AppendChild(name);
                parent.AppendChild(age);
                parent.AppendChild(place);
                parent.AppendChild(time);

                xmlDoc.DocumentElement.AppendChild(parent);

                xmlDoc.Save(Server.MapPath("XMLFile1.xml"));
                ShowXmlData();

                TextBox1.Text = string.Empty;
                TextBox2.Text = string.Empty;
                TextBox3.Text = string.Empty;

                ShowXmlData();
            }
            catch(Exception ex) { }
            finally { }





        }
    }
}