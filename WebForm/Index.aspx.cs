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
    }
}