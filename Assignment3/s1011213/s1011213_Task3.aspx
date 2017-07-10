<%@ Page Language="C#" AutoEventWireup="true" CodeFile="s1011213_Task3.aspx.cs" Inherits="s1011213_Task3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">
                姓名：<asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem Value="0">王一</asp:ListItem>
                    <asp:ListItem Value="1">黃二</asp:ListItem>
                    <asp:ListItem Value="2">張三</asp:ListItem>
                    <asp:ListItem Value="3">李四</asp:ListItem>
                    <asp:ListItem Value="4">陳五</asp:ListItem>
                </asp:DropDownList>
                <br />
                密碼：<asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="登入" />
            </asp:View>
            <asp:View ID="View2" runat="server">
                <asp:Label ID="Label1" runat="server" Text="姓名或密碼輸入錯誤"></asp:Label>
                <br />
                <br />
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="回登入畫面" />
            </asp:View>
            <asp:View ID="View3" runat="server">
                查詢科目：<asp:CheckBoxList ID="CheckBoxList1" runat="server" 
                    RepeatDirection="Horizontal">
                    <asp:ListItem Value="0">國文</asp:ListItem>
                    <asp:ListItem Value="1">英文</asp:ListItem>
                    <asp:ListItem Value="2">數學</asp:ListItem>
                </asp:CheckBoxList>
                <br />
                <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="查詢" />
            </asp:View>
            <asp:View ID="View4" runat="server">
                <asp:Label ID="Label2" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Button ID="Button4" runat="server" onclick="Button4_Click" Text="回查詢畫面" />
            </asp:View>
        </asp:MultiView>
    
    </div>
    </form>
</body>
</html>
