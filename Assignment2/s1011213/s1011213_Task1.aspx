<%@ Page Language="C#" AutoEventWireup="true" CodeFile="s1011213_Task1.aspx.cs" Inherits="s1011213_Task1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <p>請輸入欲查看事件的個數：
        <br>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="確定" />
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <div>
    
    </div>
    </form>
</body>
</html>
