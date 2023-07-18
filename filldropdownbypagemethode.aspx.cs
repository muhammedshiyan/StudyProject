using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class filldropdownbypagemethode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.Form["DropListName"] != null)
                lblSubmitValue.Text = String.Format("Submitted Value: \"{0}\"",
                    Request.Form["DropListName"]);
        }
        public class ListData
        {
            public string text { get; set; }
            public int value { get; set; }
        }
        [System.Web.Services.WebMethod]
        [System.Web.Script.Services.ScriptMethod]
        public static IEnumerable<ListData> GetListData(int arg)
        {
            List<ListData> list = new List<ListData>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(new ListData()
                {
                    text = String.Format("List Item {0}", i),
                    value = i
                });
            }
            return list;
        }
    }

}


