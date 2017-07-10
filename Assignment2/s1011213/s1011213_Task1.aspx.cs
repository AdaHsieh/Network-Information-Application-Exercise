using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class s1011213_Task1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string[] ToDoList = { "準備統計小考", "領錢", "小工盃比賽", "看電影", "買文具" };

        int x = Convert.ToInt32(TextBox1.Text);

        if(x>0 && x<= ToDoList.Length)
        {
            Label1.Text = "前" + x + "重要的事項有：" + "<br>";

        for (int i = 0; i < x; i++)
        {

            Label1.Text = Label1.Text + (i + 1) + "：" + ToDoList[i] + "<br>";
        }
        
        }
        else
            {
            Label1.Text="請輸入整數1~" + ToDoList.Length;
            }
        }

    }
