<%@ Page Language="C#" AutoEventWireup="true" CodeFile="s1011213_Task3.aspx.cs" Inherits="s1011213_Task3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
table, td {border-collapse:collapse; border: 1px solid black;}
</style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="肥胖評比" />
&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="顯示BMI統計" 
            onclick="Button2_Click" />
        <br>
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
