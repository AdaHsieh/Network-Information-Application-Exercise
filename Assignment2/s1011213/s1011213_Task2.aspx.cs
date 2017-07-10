using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class s1011213_Task2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string[] Name = { "王一", "黃二", "張三", "李四", "陳五" };
        int[] Chinese = { 80, 45, 60, 90, 20 };

        int x = Convert.ToInt32(TextBox1.Text);

        Label1.Text = "國文成績大於及等於" + x + "分者：" + "<br>" + "姓名 成績" + "<br>";
        for (int i = 0; i < Name.Length; i++)
        {
            if(Chinese[i] >= x)
            {
                
            Label1.Text = Label1.Text + Name[i] + " " + Chinese[i] + "<br>";
            }
        }

            Label1.Text = Label1.Text + "<br>" + "國文成績小於" + x + "分者：" + "<br>" + "姓名 成績" + "<br>";
            for (int j = 0; j < Name.Length; j++)
            {
                if (Chinese[j] < x)
                {
                   
                    Label1.Text = Label1.Text + Name[j] + " " + Chinese[j] + "<br>";
                }
            
        }
    }
}