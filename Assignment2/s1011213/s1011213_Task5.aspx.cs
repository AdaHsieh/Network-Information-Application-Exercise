using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class s1011213_Task5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string x = TextBox1.Text;

        Label1.Text = "";
        for (int i = 0; i< x.Length  ; i++)
        {
            Label1.Text += "<img src=\"" + TextBox1.Text.Substring(i,1) + "BBLKBLK" + ".GIF\""+"/>";

        }
    }
}