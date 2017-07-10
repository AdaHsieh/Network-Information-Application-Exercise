<%@ Page Language="C#" AutoEventWireup="true" CodeFile="s1011213_Task1.aspx.cs" Inherits="s1011213_Task1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 78px;
        }
        .style3
        {
            width: 699px;
        }
       
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">
                <table class="style1">
                    <tr>
                        <td class="style2">
                            姓名</td>
                        <td class="style3">
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            性別</td>
                        <td class="style3">
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                                RepeatDirection="Horizontal">
                                <asp:ListItem Value="0">男</asp:ListItem>
                                <asp:ListItem Value="1">女</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            學歷</td>
                        <td class="style3">
                            <asp:DropDownList ID="DropDownList1" runat="server">
                                <asp:ListItem Value="0">研究所</asp:ListItem>
                                <asp:ListItem Value="1">大專</asp:ListItem>
                                <asp:ListItem Value="2">高中</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            電子郵件</td>
                        <td class="style3">
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            興趣</td>
                        <td class="style3">
                            <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatColumns="4" 
                                RepeatDirection="Horizontal">
                                <asp:ListItem Value="0">游泳</asp:ListItem>
                                <asp:ListItem Value="1">籃球</asp:ListItem>
                                <asp:ListItem Value="1">聊天</asp:ListItem>
                                <asp:ListItem Value="2">打牌</asp:ListItem>
                                <asp:ListItem Value="3">吃東西</asp:ListItem>
                                <asp:ListItem Value="4">睡覺</asp:ListItem>
                                <asp:ListItem Value="5">爬山</asp:ListItem>
                                <asp:ListItem Value="6">看電視</asp:ListItem>
                                <asp:ListItem Value="7">逛街</asp:ListItem>
                            </asp:CheckBoxList>
                        </td>
                    </tr>
                </table>
                <br />
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="確定" />
            </asp:View>
            
            <asp:View ID="View2" runat="server">
                <asp:Label ID="Label1" runat="server" Visible="True"></asp:Label>
                &nbsp;你好，您的基本資料為<br /> <strong>學歷:</strong>
                <asp:Label ID="Label2" runat="server"></asp:Label>
                <br />
                <strong>興趣:</strong>
                <asp:Label ID="Label3" runat="server"></asp:Label>
                <br />
                <br />
                本公司將盡快將符合你 
                <asp:Label ID="Label4" runat="server"></asp:Label>
                &nbsp;的資料<br /> 寄至如下電子郵件信箱<br /> <strong>電子郵件:</strong>
                <asp:HyperLink ID="HyperLink1" runat="server">[HyperLink1]</asp:HyperLink>
            </asp:View>
        </asp:MultiView>
    
    </div>
    </form>
</body>
</html>
