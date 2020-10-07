<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChongDinXiang1.aspx.cs" Inherits="Response_ChongDinXiang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            用户名：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            性 别：<asp:RadioButton ID="rb1" runat="server" Checked="True" GroupName="sex" Text="男" />
            <asp:RadioButton ID="rb2" runat="server" GroupName="sex" Text="女" />
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="确认" />
    </form>
</body>
</html>
