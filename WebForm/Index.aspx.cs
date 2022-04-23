using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    Response.Write("第一次加载");
            //}

            if (!IsPostBack)
            {
                ViewState["countState"] = 0;//ViewState无法在不同页面保存
                TTBNum.Text = "0";
            }
        }
        protected void BtnConsole_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(TxtBox1.Text);
            int num2 = Convert.ToInt32(TxtBox2.Text);
            int sum = num1 + num2;
            TxtBox3.Text = sum.ToString();
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            int count = (int)ViewState["countState"];
            count++;
            TTBNum.Text = count.ToString();
            ViewState["countState"] = count;
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            string name = TTBName.Text;
            Session["Name"] = name;
        }

        protected void BtnSave1_Click(object sender, EventArgs e)
        {
            string name = ttbName1.Text;
            //1.创建cookies，并设置有效期
            Response.Cookies["Name"].Expires = DateTime.Now.AddMinutes(1.0);//设置cookies的有效期1分钟
            Response.Cookies["Name"].Value = name;

            //2.方法2
            HttpCookie cookie = new HttpCookie("Age", "20");
            cookie.Expires = DateTime.Now.AddMinutes(2.0);
            //把cookies响应到浏览器
            Response.Cookies.Add(cookie);
        }
    }
}