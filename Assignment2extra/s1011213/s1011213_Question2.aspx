<%@ Page Language="C#" AutoEventWireup="true" CodeFile="s1011213_Question2.aspx.cs" Inherits="s1011213_Question2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    國文及格成績：
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />英文及格成績：
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="兩科皆及格名單" />
&nbsp;<asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="任一科不及格名單" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
