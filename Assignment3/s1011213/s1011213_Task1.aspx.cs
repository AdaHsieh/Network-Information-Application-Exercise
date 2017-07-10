using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class s1011213_Task1 : System.Web.UI.Page
{
    int x;
   
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
        
        if (RadioButtonList1.SelectedValue == "0")
        {
            Label1.ForeColor = System.Drawing.Color.Blue;
            Label1.Text = TextBox1.Text + "先生";
            Label2.Text = DropDownList1.SelectedItem.Text;
            for (int i = 0; i < CheckBoxList1.Items.Count;i++ )
              if(CheckBoxList1.Items[i].Selected == true)
              {
                  Label3.Text += CheckBoxList1.Items[i].Text + " ";
              }
            Label4.ForeColor = System.Drawing.Color.Red;
            Label4.Text = "女朋友";
            HyperLink1.NavigateUrl = "mailto:" + TextBox2.Text;
            HyperLink1.Text = TextBox2.Text;
        }      
        else
        {
            Label1.ForeColor = System.Drawing.Color.Red;
            Label1.Text = TextBox1.Text + "小姐";
            Label2.Text = DropDownList1.SelectedItem.Text;
            for (int i = 0; i < CheckBoxList1.Items.Count; i++)
                if (CheckBoxList1.Items[i].Selected == true)
                {
                    Label3.Text += CheckBoxList1.Items[i].Text + " ";
                }
            Label4.ForeColor = System.Drawing.Color.Blue;
            Label4.Text = "男朋友";
            HyperLink1.NavigateUrl = "mailto:" + TextBox2.Text;
            HyperLink1.Text = TextBox2.Text;
        
        
        }
    }
   
    
}