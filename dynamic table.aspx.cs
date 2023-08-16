using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication1
{
    public partial class dynamic_table : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {  RowAdd.Attributes.Add("onclick", "showInputDialog();");
            if (!IsPostBack)
            {
                DataTable mytable = new DataTable();
                Session["mytable"] = mytable;
                AddColumn("column");
                // AddRow("John", "30");
            }
        }

        protected void btnAddRow_Click(object sender, EventArgs e)
        {
            string name = txtRowName.Text;
            string age = txtAge.Text;
            AddRow(name, age);

        }

        protected void btnAddColumn_Click(object sender, EventArgs e)
        {
            string column = newcolumnname.Text;
            AddColumn(column);
        }
        private void AddRow(string name, string age)
        {

            TableRow newRow = new TableRow();

            TableCell cell1 = new TableCell();
            TableCell cell2 = new TableCell();

            DataTable mytable = new DataTable();

            //  if (Session["mytable"].ToString() != "")
            { mytable = (DataTable)Session["mytable"]; }


            cell1.Text = name;
            cell2.Text = age;


            mytable.Rows.Add(cell1);
            mytable.Rows.Add(cell2);

            Session["mytable"] = mytable;


            GridView1.DataSource = mytable;
            GridView1.DataBind();

        }

        private void AddColumn(string columnName)
        {
            DataTable mytable = new DataTable();
          //  mytable = (DataTable)Session["mytable"];

            DataColumn col = new DataColumn(columnName);

            mytable.Columns.Add(col);


          

            Session["mytable"] = mytable;

            GridView1.DataSource = mytable;
            GridView1.DataBind();


        }

        protected void btnShowInput_Click(object sender, EventArgs e)
        {

            string inputText1 = hiddenInput1.Value;
            string inputText2 = hiddenInput2.Value;


            if (!string.IsNullOrWhiteSpace(inputText1) && !string.IsNullOrWhiteSpace(inputText2))
            {
                string message = "Hello, " + inputText1 + "! You are " + inputText2 + " years old.";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('" + message + "');", true);
            }

            string name = txtRowName.Text;
            string age = txtAge.Text;
            AddRow(name, age);
        }
    }
}