using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForm
{
    /// <summary>
    /// 图标种类(例如日K、MA5、MA10、MA20、MA30、MA60、MA180、MA360)
    /// </summary>
    public class OptionLegend
    {
        public List<string> datas { get; set; }
    }

    /// <summary>
    /// 均线模板
    /// </summary>
    public class MA
    {
        /// <summary>
        /// 均线名字
        /// </summary>
        public string MAName { get; set; }
        /// <summary>
        /// 均线数据
        /// </summary>
        public List<float> datas { get; set; }
    }

    /// <summary>
    /// 日K数据
    /// </summary>
    public class DayKData
    {
        /// <summary>
        /// 日期
        /// </summary>
        public string Date { get; set; }
        /// <summary>
        /// 开盘价、收盘价、最低价、最高价
        /// </summary>
        public List<float> PricesDatas { get; set; }
    }
}