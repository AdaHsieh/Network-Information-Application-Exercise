<%@ Page Language="C#" AutoEventWireup="true" CodeFile="s1011213_Task2.aspx.cs" Inherits="s1011213_Task2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 26%;
        }
        table,tr,td
{
    
    border: 1px solid black;
     padding:1px;
}    
 </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">
                身高 
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem Value="0">&lt;=</asp:ListItem>
                    <asp:ListItem Value="1">&gt;=</asp:ListItem>
                </asp:DropDownList>
                &nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                &nbsp;cm<br />&nbsp;<br />體重 
                <asp:DropDownList ID="DropDownList2" runat="server">
                    <asp:ListItem Value="0">&lt;=</asp:ListItem>
                    <asp:ListItem Value="1">&gt;=</asp:ListItem>
                </asp:DropDownList>
                &nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                &nbsp;kg<br />
                <br />
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                    Text="查詢條件符合者" />
            </asp:View>
            <asp:View ID="View2" runat="server">
                <asp:Label ID="Label1" runat="server"></asp:Label>
                <br />
            </asp:View>
        </asp:MultiView>
    
    </div>
    </form>
</body>
</html>
