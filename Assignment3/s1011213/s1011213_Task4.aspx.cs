using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class s1011213_Task4 : System.Web.UI.Page
{
    double[,] price = { { 0, 140, 480, 950 }, { 130, 0, 550, 880 }, { 520, 430, 0, 520 }, { 980, 870, 500, 0 } };
    int[,] number = { { 0, 3, 8, 10 }, { 5, 0, 2, 3 }, { 9, 7, 0, 0 }, { 4, 7, 12, 0 } };
    int k;
    int p;

   double value;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = "";
        k = RadioButtonList1.SelectedIndex;
        p = Convert.ToInt32(TextBox1.Text);
       
        for (int i = 0; i < price.GetLength(0); i++)
        {
            for (int j = 0; j < price.GetLength(1); j++)
            {
                if (DropDownList1.SelectedIndex == DropDownList2.SelectedIndex)
                {
                    MultiView1.ActiveViewIndex = 1;
                    Label1.Text = "出發地點與到達地點不得相同";
                }

                else if (p > number[DropDownList1.SelectedIndex, DropDownList2.SelectedIndex])
                {
                    MultiView1.ActiveViewIndex = 1;
                    Label1.Text = "數量不足，請重新訂購";
                }

                else if (k == 0 && p <= number[DropDownList1.SelectedIndex, DropDownList2.SelectedIndex] && DropDownList1.SelectedIndex != DropDownList2.SelectedIndex) 
                {
                    MultiView1.ActiveViewIndex = 1;
                    value = p * price[DropDownList1.SelectedIndex, DropDownList2.SelectedIndex];
                  
                    Label1.Text = "訂位資訊如下" + "<br>" + "<br>" + "出發地點：" + DropDownList1.SelectedItem.Text + "<br>到達地點：" + DropDownList2.SelectedItem.Text + "<br>票種：" + RadioButtonList1.SelectedItem.Text + "<br>總票價為：" + value;
                }

                else if (k == 1 && p <= number[DropDownList1.SelectedIndex, DropDownList2.SelectedIndex] && DropDownList1.SelectedIndex != DropDownList2.SelectedIndex)
                {
                    MultiView1.ActiveViewIndex = 1;
                    value = p * 0.8 * price[DropDownList1.SelectedIndex, DropDownList2.SelectedIndex];
                    
                    Label1.Text = "訂位資訊如下" + "<br>" + "<br>" + "出發地點：" + DropDownList1.SelectedItem.Text + "<br>到達地點：" + DropDownList2.SelectedItem.Text + "<br>票種：" + RadioButtonList1.SelectedItem.Text + "<br>總票價為：" + value;
                }
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
        DropDownList1.SelectedIndex = 0;
        DropDownList2.SelectedIndex = 0;
        RadioButtonList1.Items[0].Selected=false;
        RadioButtonList1.Items[1].Selected = false;
        TextBox1.Text = "";
    }
}