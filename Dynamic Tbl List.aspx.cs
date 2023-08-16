using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication1
{
    public partial class Dynamic_Tbl_List : System.Web.UI.Page
    {
        [Serializable]
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Email { get; set; }
        }

        protected List<Person> PeopleList
        {
            get
            {
                if (ViewState["PeopleList"] != null)
                {
                    return (List<Person>)ViewState["PeopleList"];
                   
                }
                else
                {

                    List<Person> emptyList = new List<Person>();
                    ViewState["PeopleList"] = emptyList;
                    return emptyList;
                    //return new List<Person>();
                }
            }
            set
            {
                ViewState["PeopleList"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
              //  ViewState["Table"] = myTable;

                BindTable();
            }
        }

        protected void btnAddPerson_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            int age = Convert.ToInt32(txtAge.Text.Trim());
            string email = txtEmail.Text.Trim();

         //  PeopleList =(List) ViewState["PeopleList"];
            List<Person> peopleList = ViewState["PeopleList"] as List<Person>;
            PeopleList.Add(new Person { Name = name, Age = age, Email = email });
            ViewState["PeopleList"] = PeopleList;

            txtName.Text = "";
            txtAge.Text = "";
            txtEmail.Text = "";

            ViewState["PeopleList"] = peopleList;
            BindTable();
        }

        protected void BindTable()
        {
            //   myTable.Rows.Clear();

            List<Person> peopleList = ViewState["PeopleList"] as List<Person>;
            foreach (var person in PeopleList)
            {
                TableRow row = new TableRow();
                TableCell nameCell = new TableCell();
                TableCell ageCell = new TableCell();
                TableCell emailCell = new TableCell();

                nameCell.Text = person.Name;
                ageCell.Text = person.Age.ToString();
                emailCell.Text = person.Email;

                row.Cells.Add(nameCell);
                row.Cells.Add(ageCell);
                row.Cells.Add(emailCell);

                myTable.Rows.Add(row);

              //  ViewState["Table"]= myTable;

            }


        }
    }
}

