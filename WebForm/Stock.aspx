<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Stock.aspx.cs" Inherits="WebForm.Stock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>股票分析软件</title>
    <style type="text/css">
        #Search {
            position: center;
            top: 50%;
            left: 50%;
        }
    </style>
    <script src="Modules/jquery-3.3.1.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="Search">
            <center>
                <a>下方输入股票信息</a>
                <br />
                <asp:TextBox ID="ttbStock" runat="server"></asp:TextBox>
                <asp:Button ID="BtnSearch" runat="server" Text="搜索" OnClick="BtnSearch_Click" />
            </center>
        </div>
        <br />
        <br />
        <br />
        <div id="m2" style="width: 600px; height: 400px;"></div>
        <div>
            <center>
                <label style="text-anchor: end">Powerd By 阿拉丁(微信:AladdinDXW)</label>
            </center>
        </div>
    </form>

    <script src="Modules/echarts.js"></script>
    <script type="text/javascript">
        $(function () {
            $.ajax({
                type: "POST",
                url: "/StockHandler.ashx",
                data: { 'TestAction': 19 },
                success: function (data) {
                    alert(data.le)
                    //构造图表
                    var myChart2 = echarts.init(document.getElementById('m2'));
                    //配置参数
                    option2 = {
                        tooltip: {
                            trigger: 'axis',
                            axisPointer: {
                                type: 'shadow'        // 默认为直线，可选为：'line' | 'shadow'
                            }
                        },
                        legend: data.le,
                        xAxis: data.xa,
                        yAxis: {},
                        series: data.se
                    };

                    //使用参数
                    myChart2.setOption(option2);
                },  //end success
                error: function (jqXHR) {

                }
            });  //end ajax
        });  //end page ready
    </script>
</body>
</html>
