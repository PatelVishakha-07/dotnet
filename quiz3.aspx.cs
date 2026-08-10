using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace registration
{
    public partial class quiz3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            int s = 0, i = int.Parse(Session["index"].ToString());
            string[] q = (string[])Session["question"];
            string[] ans = (string[])Session["answer"];

            if (rdoq1.SelectedIndex != -1)
            {
                if (rdoq1.SelectedIndex == 1)
                    s += 4;
                else
                {
                    s--;
                    q[i] = "Q1. Which access modifier allows access only within the same class?";
                    ans[i] = "private";
                    i++;
                }
            }

            if (rdoq2.SelectedIndex != -1)
            {
                if (rdoq2.SelectedIndex == 1)
                    s += 4;
                else
                {
                    s--;
                    q[i] = "Q2. Which class cannot be instantiated?";
                    ans[i] = "Abstract class";
                    i++;
                }
            }

            if (rdoq3.SelectedIndex != -1)
            {
                if (rdoq3.SelectedIndex == 2)
                    s += 4;
                else
                {
                    s--;
                    q[i] = "Q3. Which exception is thrown when dividing an integer by zero?";
                    ans[i] = "DivideByZeroException";
                    i++;
                }
            }

            if (rdoq4.SelectedIndex != -1)
            {
                if (rdoq4.SelectedIndex == 2)
                    s += 4;
                else
                {
                    s--;
                    q[i] = "Q4. Which keyword is used for exception handling?";
                    ans[i] = "both";
                    i++;
                }
            }

            if (rdoq5.SelectedIndex != -1)
            {
                if (rdoq5.SelectedIndex == 1)
                    s += 4;
                else
                {
                    s--;
                    q[i] = "Q5. Which of these is NOT an OOP principle?";
                    ans[i] = "Compilation";
                    i++;
                }
            }

            Session["score"] = int.Parse(Session["score"].ToString()) + s;

            lblscore.Text = "Wrong Answers:<br>";

            for(int j=0; j<i; j++)
            {
                lblscore.Text += q[j].ToString() + "<br>";
                lblscore.Text += ans[j].ToString() + "<br><br>";
            }

            lblscore.Text += "Score: " + Session["score"].ToString();
        }
    }
}