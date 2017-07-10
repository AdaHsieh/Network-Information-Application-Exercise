using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class s1011213_Task3 : System.Web.UI.Page{
    
    string[] Name = {"王一", "黃二", "張三", "李四", "陳五"};
    string[] Passwd = { "$wang%", "$huang%", "$chang%", "$lee%", "$chen%" };
    int[ , ] Data = {{50, 60, 80}, {90, 80, 100}, {45, 30, 65}, {70, 45, 30}, {60, 90, 90}};
    int k;
    bool a = true;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       string name= DropDownList1.SelectedItem.ToString();
       string passwd= TextBox2.Text.ToString();
        for(int i=0;i< Name.Length ;i++)
        {
            if(name== Name[i] && passwd==Passwd[i])
            {   MultiView1.ActiveViewIndex=2;
                k=i;
                a = false;
            }
        }
        if(a==true)
        {
            MultiView1.ActiveViewIndex = 1;
            DropDownList1.SelectedIndex = 0;
            TextBox2.Text = "";
            Label1.ForeColor = System.Drawing.Color.Blue;
        }

    }
    protected void  Button2_Click(object sender, EventArgs e)
{
    MultiView1.ActiveViewIndex=0;
}
    protected void  Button3_Click(object sender, EventArgs e)
{
    MultiView1.ActiveViewIndex=3;
    Label2.Text="";
    Label2.Text = Name[k] + "同學成績" + "<br>";
    for (int i = 0; i < CheckBoxList1.Items.Count; i++)
    {
         
        if (CheckBoxList1.Items[i].Selected == true)
        {
            Label2.Text += CheckBoxList1.Items[i].Text + "：" + Data[k,i]+"<br>";
        }
    
    }
       
}
    protected void Button4_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 2;
       
        for (int i = 0; i < CheckBoxList1.Items.Count; i++)
        {

            if (CheckBoxList1.Items[i].Selected == true)
            {
                CheckBoxList1.Items[i].Selected = false;
            }

        }
    }
}