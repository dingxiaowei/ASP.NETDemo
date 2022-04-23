using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class WebFormRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //1.QueryString
            //string name = Request.QueryString["name"];
            //string age = Request.QueryString["age"];
            //Response.Write($"名字:{name} 年龄:{age}");

            //2.params
            string name = Request.Params["name"];
            string age = Request.Params["age"];
            Response.Write($"名字:{name} 年龄:{age}");

            //取出Session
            if (Session["Name"] != null)
                Label1.Text = Session["Name"].ToString();
            //取出cookies值
            if (Request.Cookies["Name"] != null)
            {
                string name1 = Request.Cookies["Name"].Value;
                Label2.Text = name1.ToString();
            }
        }
    }
}