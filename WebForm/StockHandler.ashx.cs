using Newtonsoft.Json;
using System.Collections.Generic;
using System.Web;

namespace WebForm
{
    public class ChartSeries
    {
        public string type { get; set; }
        public string name { get; set; }
        public List<int> data { get; set; }
    }

    //x轴 种类、数据数组
    public class ChartXAxis
    {
        public string type { get; set; }
        public List<string> data { get; set; }
    }

    //图表种类数组
    public class ChartLegend
    {
        public List<string> data { get; set; }
    }

    /// <summary>
    /// StockHandler 的摘要说明
    /// </summary>
    public class StockHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //string qianta = context.Request["TestAction"].ToString();
            ChartSeries series1 = new ChartSeries();
            series1.type = "bar";
            series1.name = "2015";
            series1.data = new List<int>();
            series1.data.Add(89);
            series1.data.Add(92);
            series1.data.Add(94);
            series1.data.Add(85);
            List<ChartSeries> seriesList = new List<ChartSeries>() { series1 };

            ChartXAxis xAxis = new ChartXAxis();
            xAxis.type = "category";
            xAxis.data = new List<string>();
            xAxis.data.Add("牛奶");
            xAxis.data.Add("橙汁");
            xAxis.data.Add("可乐");
            xAxis.data.Add("雪碧");

            ChartLegend legend = new ChartLegend();
            legend.data = new List<string>();
            foreach (var sitem in seriesList)
            {
                legend.data.Add(sitem.name);
            }

            string jsonstr = JsonConvert.SerializeObject(new { se = seriesList, xa = xAxis, le = legend });
            context.Response.Write(jsonstr);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}