using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class s1011213_Task4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        double[,] price = { { 0, 140, 480, 950 }, { 130, 0, 550, 880 }, { 520, 430, 0, 520 }, { 980, 870, 500, 0 } };
        string[] station = { "台北", "桃園", "台中", "高雄" };
        double min = 100000.0;
        int a1=0, a2=0;

        for (int i = 0; i < price.GetLength(0); i++)
        {
            for (int j = 0; j < price.GetLength(1); j++)
            {
                if (price[i, j] < min && price[i,j] != 0)
                {
                    min = price[i, j];
                    a1 = i;
                    a2 = j;
                }

            }
        }
        Label1.Text = "";
        Label1.Text = "最便宜票價：" + min + "<br>" +"起始站："+station[a1]+"<br>"+"終點站："+station[a2];

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        double[,] price = { { 0, 140, 480, 950 }, { 130, 0, 550, 880 }, { 520, 430, 0, 520 }, { 980, 870, 500, 0 } };
        string[] station = { "台北", "桃園", "台中", "高雄" };

        for (int i = 0; i < price.GetLength(0); i++)
        {
            for (int j = 0; j < price.GetLength(1); j++)
            {
                if (price[i, j] < 300)
                {
                    price[i, j] = price[i, j] * 1.4;
                }
                if (price[i, j] < 600 && price[i, j] > 300)
                {
                    price[i, j] = price[i, j] * 1.2;
                }
                if (price[i, j] >= 600)
                {
                    price[i, j] = price[i, j];
                }
            }
        }

        Label2.Text = "";
        Label2.Text = Label2.Text + "起站" + " " + "終站" + " " + "票價" + "<br>";

        for (int i = 0; i < price.GetLength(0); i++)
        {
            for (int j = 0; j < price.GetLength(1); j++)
            {
                if (i != j)
                {
                    Label2.Text = Label2.Text + station[i] + " " + station[j] + " " + price[i, j] + "<br>";
                }
            }
        }
    }

}