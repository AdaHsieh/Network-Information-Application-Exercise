<%@ Page Language="C#" AutoEventWireup="true" CodeFile="s1011213_Task2.aspx.cs" Inherits="s1011213_Task2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        成績分割點：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        (只能輸入0~100的整數)
        <br /><br>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="產生表格" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
