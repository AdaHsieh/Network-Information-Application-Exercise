<%@ Page Language="C#" AutoEventWireup="true" CodeFile="s1011213_Task4.aspx.cs" Inherits="s1011213_Task4" %>

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
               出發地點：<asp:DropDownList ID="DropDownList1" runat="server">
                   <asp:ListItem Value="0">台北</asp:ListItem>
                   <asp:ListItem Value="1">桃園</asp:ListItem>
                   <asp:ListItem Value="2">台中</asp:ListItem>
                   <asp:ListItem Value="3">高雄</asp:ListItem>
               </asp:DropDownList>
               <br />
               <br />
               到達地點：<asp:DropDownList ID="DropDownList2" runat="server">
                   <asp:ListItem Value="0">台北</asp:ListItem>
                   <asp:ListItem Value="1">桃園</asp:ListItem>
                   <asp:ListItem Value="2">台中</asp:ListItem>
                   <asp:ListItem Value="3">高雄</asp:ListItem>
               </asp:DropDownList>
               <br />
               <br />
               票種：<asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                   RepeatDirection="Horizontal" RepeatLayout="Flow">
                   <asp:ListItem Value="0">全票</asp:ListItem>
                   <asp:ListItem Value="1">優待票</asp:ListItem>
               </asp:RadioButtonList>
               <br />
               票數：<asp:TextBox ID="TextBox1" runat="server" Height="19px"></asp:TextBox>
               <br />
               <br />
               <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="訂購" />
            </asp:View> 
             <asp:View ID="View2" runat="server">
                 <asp:Label ID="Label1" runat="server"></asp:Label>
                 <br />
                 <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="返回訂票系統" />
            </asp:View> 
        </asp:MultiView>
    
    </div>
    </form>
</body>
</html>
