using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm.Demo1
{
    public partial class CountNum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnConsole_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(TxtBox1.Text);
            int num2 = Convert.ToInt32(TxtBox2.Text);
            int sum = num1 + num2;
            TxtBox3.Text = sum.ToString();
        }
    }
}