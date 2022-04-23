<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CountNum.aspx.cs" Inherits="WebForm.Demo1.CountNum" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>计算器</h1>
            <asp:TextBox ID="TxtBox1" runat="server"></asp:TextBox>
            +
            <asp:TextBox ID="TxtBox2" runat="server"></asp:TextBox>
            =
            <asp:TextBox ID="TxtBox3" runat="server"></asp:TextBox>
            <asp:Button ID="BtnConsole" runat="server" Text="计算" OnClick="BtnConsole_Click"/>
        </div>
        <% 
            string str = "欢迎来到ASP.NET网站开发";
        %>
        <%=str%>
    </form>
</body>
</html>
