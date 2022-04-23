<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebForm.Index" %>

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
        <div>
            <a href="WebFormRequest.aspx?name=zhangsan&age=20">跳转到第二个页面</a>
            <br />
            <asp:TextBox ID="TTBNum" runat="server"></asp:TextBox>
            <asp:Button ID="BtnAdd" runat="server" Text="自增" OnClick="BtnAdd_Click" />
            <br />
            <asp:Label ID="lblName" runat="server" Text="请输入姓名"></asp:Label>
            <asp:TextBox ID="TTBName" runat="server"></asp:TextBox>
            <asp:Button ID="BtnSave" runat="server" Text="将姓名保存到Session中" OnClick="BtnSave_Click" />
        </div>
        <% 
            string str = "欢迎来到ASP.NET网站开发";
        %>
        <%=str%>
    </form>
</body>
</html>
