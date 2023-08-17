using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class querystring : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string firstname = Request.QueryString["firstname"];
                string lastname = Request.QueryString["lastname"];
                Label3.Text = "Your Data Is" + firstname + " " + lastname;


                HttpContext context = HttpContext.Current;


                NameValueCollection queryParameters = context.Request.QueryString;

                string S = string.Empty;
                foreach (string key in queryParameters.AllKeys)
                {
                    S += ("Key: " + key + ", Value: " + queryParameters[key]);
                }
                Label4.Text = S;
                
             
            }
            catch (Exception ex) { }
            finally { }
             
        }


        public void Show()
        {
            try
            {
                Response.Redirect("querystring.aspx?firstname=" + TextBox1.Text + "&lastname=" + TextBox2.Text);

                HttpContext context = HttpContext.Current;


                string QueryString = context.Request.QueryString.ToString();


                string encodedQueryString = QueryString;


                string decodedQueryString = HttpUtility.UrlDecode(encodedQueryString);


                string[] keyValuePairs = decodedQueryString.Split('&');


                List<KeyValuePair<string, string>> queryList = new List<KeyValuePair<string, string>>();

                foreach (string pair in keyValuePairs)
                {
                    int equalsIndex = pair.IndexOf('=');
                    if (equalsIndex != -1)
                    {
                        string key = pair.Substring(0, equalsIndex);
                        string value = pair.Substring(equalsIndex + 1);
                        queryList.Add(new KeyValuePair<string, string>(key, value));
                    }
                }

                string S = string.Empty;
                foreach (var item in queryList)
                {

                    S += ("Key: " + item.Key + ", Value: " + item.Value);
                }

                Label5.Text = S;
            }
            catch (Exception ex)
            {
            }
            finally { }

        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            Show();



        }
    }

    }
