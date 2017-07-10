using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class s1011213_Question1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string[] ToDoList = { "工管周", "準備統計小考", "領錢", "小工盃比賽", "看電影", "買文具" };
        int[] Priority = { 1, 3, 5, 4, 6, 2 };
       
        int x = Convert.ToInt32(TextBox1.Text);
        int[] a = new int[ToDoList.Length];
        if (x > 0 && x <= ToDoList.Length)
        {
            Label1.Text="前"+ x +"重要的事項有："+"<br>";

            for (int i = 0; i < ToDoList.Length; i++)
            {
                if (x + Priority[i] >= ToDoList.Length + 1)
                {
                    a[i] = i;
                }
                else {
                    a[i] = -1;
                }
                
            }
            for (int i = 0; i < ToDoList.Length; i++)
            {
                if (a[i] != -1)
                {
                    Label1.Text = Label1.Text + ToDoList[a[i]] + "<br>";
                }
            }
        }

        
        else
        {
        Label1.Text = "請輸入整數1~"+ToDoList.Length;
        }
    }
}