using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;
using static WebApplication1.xmlserialdeserial;

namespace WebApplication1
{
    public partial class xmlserialdeserial : System.Web.UI.Page
    {
        readonly public Connectionclass co = new Connectionclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }
        public void BindData()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = co.Connectionopen();
            command.CommandText = "sp_XmlSerialise";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@top",5);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt=new DataTable();
            adapter.Fill(dt);
            dt.TableName = "DepartmentData";


            XmlSerializer xmlSerializerobj2 = new XmlSerializer(typeof(DataTable));
            StreamWriter streamWriterobj2 = new StreamWriter(@"D:\\StudyProject\\departmentsample1.xml");
            xmlSerializerobj2.Serialize(streamWriterobj2, dt);
            streamWriterobj2.Close();

            StreamReader streamReaderobj = new StreamReader(@"D:\\StudyProject\\departmentsample1.xml");

            string xmlcontetent = streamReaderobj.ReadToEnd();

            Label1.Text = Server.HtmlEncode(xmlcontetent);
            Label2.Text = xmlcontetent;



        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            BindData();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {



            XmlSerializer xmlSerializerobj2 = new XmlSerializer(typeof(DataTable));

            StreamReader streamReaderobj = new StreamReader(@"D:\\StudyProject\\departmentsample1.xml");

            DataTable deserialiseobj = (DataTable)xmlSerializerobj2.Deserialize(streamReaderobj);


            Label1.Text=string.Empty;
            Label2.Text=string.Empty;
            GridView1.DataSource = deserialiseobj;
            GridView1.DataBind();

            streamReaderobj.BaseStream.Position = 0;
         


        }
    }
}