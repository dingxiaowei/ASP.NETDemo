<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Stock.aspx.cs" Inherits="WebForm.Stock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="ttbStock" runat="server"></asp:TextBox>
            <asp:Button ID="BtnSearch" runat="server" Text="搜索" OnClick="BtnSearch_Click" />
            
            <br />
            <br />
            <br />
            <label>Powerd By 阿拉丁(微信:AladdinDXW)</label>
        </div>
    </form>
</body>
</html>
