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
    <script src="https://cdn.staticfile.org/echarts/4.3.0/echarts.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div style="position:relative">
            <center>
                <a>下方输入股票信息</a>
                <br />
                <asp:TextBox ID="ttbStock" runat="server"></asp:TextBox>
                <asp:Button ID="BtnSearch" runat="server" Text="搜索" OnClick="BtnSearch_Click" />
            </center>
            <%--</div>--%>
        </div>
        <br />
        <br />
        <br />
        <center><div id="m2" style="width: 600px; height: 400px;"></div></center>
        <div style="position:relative">
              <label style="position:absolute;right:0">Powerd By 阿拉丁(微信:AladdinDXW)</label>
        </div>
    </form>

    <script type="text/javascript">
        $(function () {
            $.ajax({
                type: "POST",
                url: "/StockHandler.ashx",
                data: { 'TestAction': 19 },
                success: function (data) {
                    var jsonObj = JSON.parse(data);
                    //alert(jsonObj["xa"]["type"])
                    //构造图表
                    var myChart = echarts.init(document.getElementById('m2'));
                    myChart.showLoading({
                        text: 'loading',
                        color: '#c23531',
                        textColor: '#fff',
                        maskColor: 'rgba(255, 255, 255, 0.2)',
                        zlevel: 0,
                      });
                    //配置参数
                    option = {
                        tooltip: {
                            trigger: 'axis',
                            axisPointer: {
                                type: 'shadow'        // 默认为直线，可选为：'line' | 'shadow'
                            }
                        },
                        legend: jsonObj["le"],
                        xAxis: jsonObj["xa"],
                        yAxis: {},
                        series: jsonObj["se"]
                    };
                    myChart.hideLoading();
                    //使用参数
                    myChart.setOption(option);
                },  //end success
                error: function (jqXHR) {
                    alert(jqXHR);
                }
            });  //end ajax
        });  //end page ready
    </script>
</body>
</html>
