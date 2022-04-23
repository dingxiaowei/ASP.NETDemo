using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebForm
{
    public partial class Stock : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            ViewState["BaseDir"] = Path.Combine(baseDir, "Excels/");
        }

        //股票搜索
        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            string excelDir = ViewState["BaseDir"].ToString();
            string stockInfo = ttbStock.Text;
            if (string.IsNullOrEmpty(stockInfo))
            {
                Response.Write("<script>alert('请输入要搜索的股票信息')</script>");
                return;
            }
            DirectoryInfo dirInfo = new DirectoryInfo(excelDir);
            var files = dirInfo.GetFiles().Where(s => s.Name.Contains(stockInfo)).ToList();
            if(files.Count < 1)
            {
                Response.Write("<script>alert('没有搜索到相关股票数据')</script>");
                return;
            }
            Response.Write(files[0].Name);
        }
    }
}