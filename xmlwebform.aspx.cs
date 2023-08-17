using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace WebApplication1
{
    public partial class xmlwebform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

          StringBuilder ss=new StringBuilder();
            string s=string.Empty;
            string s1 = string.Empty;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Server.MapPath("XMLFile2.xml"));
          


            XmlNodeList employeeNodes = xmlDoc.SelectNodes("/employees/employee");

            foreach (XmlNode employeeNode in employeeNodes)
            {
                string id = employeeNode.SelectSingleNode("id").InnerText;

                string name = employeeNode.SelectSingleNode("name").InnerText;

                string age = employeeNode.SelectSingleNode("age").InnerText;

                string department = employeeNode.SelectSingleNode("department").InnerText;

                string salary = employeeNode.SelectSingleNode("salary").InnerText;

                string hireDate = employeeNode.SelectSingleNode("hire_date").InnerText;

                string isManager = employeeNode.SelectSingleNode("is_manager").InnerText;

                s+=$"Employee ID: {id}";

                s += ($"Name: {name}");

                s += ($"Age: {age}");

                s += ($"Department: {department}");

                s += ($"Salary: {salary}");

                s += ($"Hire Date: {hireDate}");

                s += ($"Is Manager: {isManager}");

                s1 =s1+s+"-------------------------------------";
            }
            Label1.Text = s1;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Server.MapPath("XMLFile2.xml"));



            XmlNodeList employeeNodes = xmlDoc.SelectNodes("/employees/employee");




        }
    }
}