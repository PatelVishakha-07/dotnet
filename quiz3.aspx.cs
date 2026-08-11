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
            string[] unattempted_ques = (string[])Session["unattempted_question"];
            string[] unattempted_ans = (string[])Session["unattempted_answer"];
            int j = int.Parse(Session["unattempted_index"].ToString());

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
            else
            {
                unattempted_ques[j] = "Q1. Which access modifier allows access only within the same class?";
                unattempted_ans[j] = "private";
                j++;
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
            else
            {
                unattempted_ques[j] = "Q2. Which class cannot be instantiated?";
                unattempted_ans[j] = "Abstract class";
                j++;
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
            else
            {
                unattempted_ques[j] = "Q3. Which exception is thrown when dividing an integer by zero?";
                unattempted_ans[j] = "DivideByZeroException";
                j++;
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
            else
            {
                unattempted_ques[j] = "Q4. Which keyword is used for exception handling?";
                unattempted_ans[j] = "both";
                j++;
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
            else
            {
                unattempted_ques[j] = "Q5. Which of these is NOT an OOP principle?";
                unattempted_ans[j] = "Compilation";
                j++;
            }

            Session["score"] = int.Parse(Session["score"].ToString()) + s;

            lblscore.Text = "Wrong Answers:<br>";

            for(int k=0; k<i; k++)
            {
                lblscore.Text += q[k].ToString() + "<br>";
                lblscore.Text += ans[k].ToString() + "<br><br>";
            }

            lblscore.Text += "<br>Unattempted Questions: <br><br>";

            for(int k=0; k<j; k++)
            {
                lblscore.Text += unattempted_ques[k].ToString() + "<br>";
                lblscore.Text += unattempted_ans[k].ToString() + "<br><br>";
            }

            lblscore.Text += "Score: " + Session["score"].ToString();
        }
    }
}