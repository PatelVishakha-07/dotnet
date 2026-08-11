using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace registration
{
    public partial class quiz2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnnext_Click(object sender, EventArgs e)
        {
            int s = 0, i = int.Parse(Session["index"].ToString());
            int j = int.Parse(Session["unattempted_index"].ToString());
            string[] q = (string[])Session["question"];
            string[] ans = (string[])Session["answer"];
            string[] unattempted_ques = (string[])Session["unattempted_question"];
            string[] unattempted_ans = (string[])Session["unattempted_answer"];

            if (rdoq1.SelectedIndex != -1)
            {
                if (rdoq1.SelectedIndex == 2)
                    s += 3;
                else
                {
                    s--;
                    q[i] = "Q1. Which OOP principle hides implementation details?";
                    ans[i] = "Abstraction";
                    i++;
                }
            }
            else
            {
                unattempted_ques[j] = "Q1. Which OOP principle hides implementation details?";
                unattempted_ans[j] = "Abstraction";
                j++;
            }

            if (rdoq2.SelectedIndex != -1)
            {
                if (rdoq2.SelectedIndex == 0)
                    s += 3;
                else
                {
                    s--;
                    q[i] = "Q2. Which OOP principle allows one class to acquire properties of another?";
                    ans[i] = "Inheritance";
                    i++;
                }
            }
            else
            {
                unattempted_ques[j] = "Q2. Which OOP principle allows one class to acquire properties of another?";
                unattempted_ans[j] = "Inheritance";
                j++;
            }

            if (rdoq3.SelectedIndex != -1)
            {
                if (rdoq3.SelectedIndex == 2)
                    s += 3;
                else
                {
                    s--;
                    q[i] = "Q3. Which keyword is used to create an object in C#?";
                    ans[i] = "new";
                    i++;
                }
            }
            else
            {
                unattempted_ques[j] = "Q3. Which keyword is used to create an object in C#?";
                unattempted_ans[j] = "new";
                j++;
            }

            if (rdoq4.SelectedIndex != -1)
            {
                if (rdoq4.SelectedIndex == 0)
                    s += 3;
                else
                {
                    s--;
                    q[i] = "Q4. CLR stands for? ";
                    ans[i] = "Common Language Runtime";
                    i++;
                }
            }
            else
            {
                unattempted_ques[j] = "Q4. CLR stands for? ";
                unattempted_ans[j] = "Common Language Runtime";
                j++;
            }

            if (rdoq5.SelectedIndex != -1)
            {
                if (rdoq5.SelectedIndex == 0)
                    s += 3;
                else
                {
                    s--;
                    q[i] = "Q5. JIT stands for? ";
                    ans[i] = "Just-In-Time";
                    i++;
                }
            }
            else
            {
                unattempted_ques[j] = "Q5. JIT stands for? ";
                unattempted_ans[j] = "Just-In-Time";
                j++;
            }

            Session["score"] = int.Parse(Session["score"].ToString()) + s;
            Session["question"] = q;
            Session["answer"] = ans;
            Session["index"] = i;
            Session["unattempted_index"] = j;
            Session["unattempted_question"] = unattempted_ques;
            Session["unattempted_answer"] = unattempted_ans;

            Response.Redirect("quiz3.aspx");
        }
    }
}