using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class s1011213_Question2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string[] Name = { "王一", "黃二", "張三", "李四", "陳五" };
        int[] Chinese = { 80, 45, 60, 90, 20 };
        int[] English = { 100, 50, 40, 80, 70 };
        int[] failch = new int[Chinese.Length];
        int[] failen = new int[English.Length];

        int ch = Convert.ToInt32(TextBox1.Text);
        int en = Convert.ToInt32(TextBox2.Text);
        Label1.Text = "姓名" + " " + "國文" + " " + "成績" + "<br>";
        for (int i = 0; i < Name.Length; i++)
        {
            if (Chinese[i] >= ch)
            {
                failch[i] = i;
            }
            else
            {
                failch[i] = -1;
            }
        }

        for (int i = 0; i < Name.Length; i++)
        {
            if (English[i] >= en)
            {
                failen[i] = i;
            }
            else
            {
                failen[i] = -1;
            }
        }

        for (int i = 0; i < Name.Length; i++)
        {

            if (failch[i] != -1 && failen[i] != -1)
            {

                Label1.Text = Label1.Text + Name[failch[i]] + " " + Chinese[failch[i]] + " " + English[failch[i]] + "<br>";
            }

        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {

        string[] Name = { "王一", "黃二", "張三", "李四", "陳五" };
        int[] Chinese = { 80, 45, 60, 90, 20 };
        int[] English = { 100, 50, 40, 80, 70 };
        int[] failch = new int[Chinese.Length];
        int[] failen = new int[English.Length];
        int[] d = new int[Name.Length];
        Label1.Text = "";
        int ch = Convert.ToInt32(TextBox1.Text);
        int en = Convert.ToInt32(TextBox2.Text);
        Label1.Text = "姓名" + " " + "國文" + " " + "成績" + " " +"等第" +"<br>";
       


        for (int i = 0; i < Name.Length; i++)
        {
            if (Chinese[i] >= ch)
            {
                failch[i] = -1;
                
            }
            else
            {
                failch[i] = Chinese[i];
                d[i] = 1;
            }
        }

        for (int i = 0; i < Name.Length; i++)
        {
            if (English[i] >= en)
            {
                failen[i] = -1;
            }
            else
            {
                failen[i] = English[i];
                d[i] +=  1;
            }
        }

        for (int i = 0; i < Name.Length; i++)
        {

            if (failch[i] == -1 && failen[i] == -1)
            {

            }
            else
            {
                failen[i] = English[i];
                failch[i] = Chinese[i];
                Label1.Text = Label1.Text + Name[i] + " " + failch[i] + " " + failen[i] + " " + d[i]+"D" + "<br>";
            
            }

        }
    }
}