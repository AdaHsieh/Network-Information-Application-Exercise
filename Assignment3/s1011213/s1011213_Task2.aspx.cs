using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class s1011213_Task2 : System.Web.UI.Page
{
    string[] Name = { "王一", "黃二", "張三", "李四", "陳五", "楊六", "丁七" };
    int[,] Data = { { 80, 170 }, { 110, 185 }, { 70, 190 }, { 55, 165 }, { 70, 160 }, { 40, 150 }, { 95, 158 } };
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
        int  hight = Convert.ToInt32(TextBox1.Text);
        int  weight = Convert.ToInt32(TextBox2.Text);
        Label1.Text = "<table><tr><td>姓名</td><td>身高</td><td>體重</td></tr>";
        for (int i = 0; i < Name.Length; i++)
        {
            
        if (DropDownList1.SelectedValue == "0" &&  DropDownList2.SelectedValue == "0" )
        {
            if (Data[i, 0] <= weight && Data[i, 1] <= hight)
            {
                Label1.Text += "<tr><td>" + Name[i] + "</td><td>" + Data[i,1] + "</td><td>" + Data[i,0] + "</td></tr> <br>";
            }
        }
        else if (DropDownList1.SelectedValue == "0" && DropDownList2.SelectedValue == "1")
        {
            if (Data[i, 0] <= weight && Data[i, 1] >= hight)
            {
                Label1.Text += "<tr><td>" + Name[i] + "</td><td>" + Data[i, 1] + "</td><td>" + Data[i, 0] + "</td></tr> <br>";
            }
        }
        else if (DropDownList1.SelectedValue == "1" && DropDownList2.SelectedValue == "0")
        {
            if (Data[i, 0] >= weight && Data[i, 1] <= hight)
            {
                Label1.Text += "<tr><td>" + Name[i] + "</td><td>" + Data[i, 1] + "</td><td>" + Data[i, 0] + "</td></tr> <br>";
            }
        }
        else if (DropDownList1.SelectedValue == "1" && DropDownList2.SelectedValue == "1")
        {
            if (Data[i, 0] >= weight && Data[i, 1] >= hight)
            {
                Label1.Text += "<tr><td>" + Name[i] + "</td><td>" + Data[i, 1] + "</td><td>" + Data[i, 0] + "</td></tr> <br>";
            }
        }
        }

        Label1.Text += "</table>";
    }
}