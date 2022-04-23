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
            Label1.Text = Session["Name"].ToString();
        }
    }
}