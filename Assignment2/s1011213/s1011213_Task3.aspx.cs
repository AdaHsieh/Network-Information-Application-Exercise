using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class s1011213_Task3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string[] Name = { "王一", "黃二", "張三", "李四", "陳五", "楊六", "丁七" };
        int[,] Data = { { 170, 80 }, { 185, 110 }, { 190, 70 }, { 165, 55 }, { 160, 70 }, { 150, 40 }, { 158, 95 } };
        double[] bmi = new double[Name.Length];
        string[] fat = new string[Name.Length];
        double[,] data1 = new double[Name.Length,Name.Length];


        for (int i = 0; i < Name.Length; i++)
        {
            for (int j = 0; j < Data.GetLength(1); j++)
            {
                data1[i, j] = Convert.ToDouble(Data[i, j]);
            }
        }

       
            for(int i=0;i< Name.Length;i++)
        {
            bmi[i] = data1[i, 1] / (data1[i, 0] / 100) / (data1[i, 0] / 100);
              
                if(bmi[i] < 18.5)
                {
                fat[i] = "體重過輕";
                }
                if(bmi[i] >= 18.5 && bmi[i] <24 )
                {
                fat[i] = "正常範圍";
                }
                if(bmi[i] >= 24 && bmi[i] <27 )
                {
                fat[i] = "過重";
                }
                if(bmi[i] >= 27 && bmi[i] <30 )
                {
                fat[i] = "輕度肥胖";
                }
                 if(bmi[i] >= 30 && bmi[i] <35 )
                {
                fat[i] = "中度肥胖";
                }
                 if (bmi[i] >= 35)
                 {
                     fat[i] = "重度肥胖";
                 }
            }
            Label1.Text = "";
            Label1.Text = "<table>"+"<tr>"+"<td>"+"<姓名>"+"</td>"+"<td>"+"BMI值"+"</td>"+"<td>"+"評等"+"</td>";
            for (int i = 0; i < Name.Length; i++)
            {
                Label1.Text = Label1.Text + "<tr>"+"<td>"+ Name[i] +"</td>"+"<td>"+ bmi[i] +"</td>"+"<td>"+ fat[i]+"</td>" + "<br>";
            }
            Label1.Text += "</table>";
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string[] Name = { "王一", "黃二", "張三", "李四", "陳五", "楊六", "丁七" };
        double[,] Data = { { 170, 80 }, { 185, 110 }, { 190, 70 }, { 165, 55 }, { 160, 70 }, { 150, 40 }, { 158, 95 } };
        double[] bmi = new double[Name.Length];
        string[] fat = new string[Name.Length];
        double min = 10000.0;
        double max = 0.00000;
        int b1=0,b2=0;
        double[,] data1 = new double[Name.Length, Name.Length];


        for (int i = 0; i < Name.Length; i++)
        {
            for (int j = 0; j < Data.GetLength(1); j++)
            {
                data1[i, j] = Convert.ToDouble(Data[i, j]);
            }
        }


        for (int i = 0; i < Name.Length; i++)
        {
            bmi[i] = data1[i, 1] / (data1[i, 0] / 100) / (data1[i, 0] / 100);

            if (bmi[i] < 18.5)
            {
                fat[i] = "體重過輕";
            }
            if (bmi[i] >= 18.5 && bmi[i] < 24)
            {
                fat[i] = "正常範圍";
            }
            if (bmi[i] >= 24 && bmi[i] < 27)
            {
                fat[i] = "過重";
            }
            if (bmi[i] >= 27 && bmi[i] < 30)
            {
                fat[i] = "輕度肥胖";
            }
            if (bmi[i] >= 30 && bmi[i] < 35)
            {
                fat[i] = "中度肥胖";
            }
            if (bmi[i] >= 35)
            {
                fat[i] = "重度肥胖";
            }
        }

        Label2.Text = "";
        Label2.Text= "<table>"+"<tr>"+"<td>"+"統計量"+"</td>"+"<td>"+"姓名"+"</td>"+"<td>"+"BMI值"+"</td>";
        for (int s = 0; s < Name.Length; s++)
        {
            if (bmi[s] <= min)
            {
                min = bmi[s];
                b1=s;
            }
        
        }

        for (int a = 0; a < Name.Length; a++)
        {
            if (bmi[a] >= max)
            {
                max = bmi[a];
                b2=a;
            }

        }
        double avg = 0.0;
        avg = (bmi[b1] + bmi[b2])/2; 
        Label2.Text = Label2.Text + "<tr>" + "<td>" + "最大值" + "</td>" + "<td>" + Name[b2] + "</td>" + "<td>" + bmi[b2] + "</td>";
        Label2.Text = Label2.Text + "<tr>" + "<td>" + "最小值" + "</td>" + "<td>" + Name[b1] + "</td>" + "<td>" + bmi[b1] + "</td>";
        Label2.Text = Label2.Text + "<tr>" + "<td>" + "平均值" + "</td>" + "<td>" + "" + "</td>" + "<td>" + avg + "</td>"+ "<table>";
    }
}