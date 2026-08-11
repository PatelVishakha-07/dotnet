using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace registration
{
    public partial class quiz1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnnext_Click(object sender, EventArgs e)
        {
            int s = 0, i=0, j=0;
            string[] q = new string[15];
            string[] ans = new string[15];
            string[] unattempted_ques = new string[15];
            string[] unattempted_ans = new string[15];

            if (rdoq1.SelectedIndex != -1)
            {
                if (rdoq1.SelectedIndex == 1)
                    s += 2;
                else
                {
                    s--;
                    q[i] = "Q1. Flutter is developed by?";
                    ans[i] = "Google";
                    i++;
                }
            }
            else
            {
                unattempted_ques[j] = "Q1. Flutter is developed by?";
                unattempted_ans[j] = "Google";
                j++;
            }

            if (rdoq2.SelectedIndex != -1)
            {
                if (rdoq2.SelectedIndex == 2)
                    s += 2;
                else
                {
                    s--;
                    q[i] = "Q2. Which widget is immutable?";
                    ans[i] = "StatelessWidget";
                    i++;
                }
            }
            else
            {
                unattempted_ques[j] = "Q2. Which widget is immutable?";
                unattempted_ans[j] = "StatelessWidget";
                j++;
            }

            if (rdoq3.SelectedIndex != -1)
            {
                if (rdoq3.SelectedIndex == 0)
                    s += 2;
                else
                {
                    s--;
                    q[i] = "Q3. Which method rebuilds the Flutter UI?";
                    ans[i] = "setState()";
                    i++;
                }
            }
            else
            {
                unattempted_ques[j] = "Q3. Which method rebuilds the Flutter UI?";
                unattempted_ans[j] = "setState()";
                j++;
            }

            if (rdoq4.SelectedIndex != -1)
            {
                if (rdoq4.SelectedIndex == 0)
                    s += 2;
                else
                {
                    s--;
                    q[i] = "Q4. Android is based on which operating system?";
                    ans[i] = "Linux";
                    i++;
                }
            }
            else
            {
                unattempted_ques[j] = "Q4. Android is based on which operating system?";
                unattempted_ans[j] = "Linux";
                j++;
            }

            if (rdoq5.SelectedIndex != -1)
            {
                if (rdoq5.SelectedIndex == 1)
                    s += 2;
                else
                {
                    s--;
                    q[i] = "Q5. Django follows which architecture?";
                    ans[i] = "MVT";
                    i++;
                }
            }
            else
            {
                unattempted_ques[j] = "Q5. Django follows which architecture?";
                unattempted_ans[j] = "MVT";
                j++;
            }

            if (rdoq6.SelectedIndex != -1)
            {
                if (rdoq6.SelectedIndex == 2)
                    s += 2;
                else
                {
                    s--;
                    q[i] = "Q6. Laravel is written in?";
                    ans[i] = "PHP";
                    i++;
                }
            }
            else
            {
                unattempted_ques[j] = "Q6. Laravel is written in?";
                unattempted_ans[j] = "PHP";
                j++;
            }

            if (rdoq7.SelectedIndex != -1)
            {
                if (rdoq7.SelectedIndex == 1)
                    s += 2;
                else
                {
                    s--;
                    q[i] = "Q7. Which HTTP method is used to retrieve data?";
                    ans[i] = "GET";
                    i++;
                
                }
            }
            else
            {
                unattempted_ques[j] = "Q7. Which HTTP method is used to retrieve data?";
                unattempted_ans[j] = "GET";
                j++;
            }

            if (rdoq8.SelectedIndex != -1)
            {
                if (rdoq8.SelectedIndex == 1)
                    s += 2;
                else
                {
                    s--;
                    q[i] = "Q8. Which data structure follows LIFO?";
                    ans[i] = "Stack";
                    i++;
                }
            }
            else
            {
                unattempted_ques[j] = "Q8. Which data structure follows LIFO?";
                unattempted_ans[j] = "Stack";
                j++;
            }

            if (rdoq9.SelectedIndex != -1)
            {
                if (rdoq9.SelectedIndex == 0)
                    s += 2;
                else
                {
                    s--;
                    q[i] = "Q9.Time complexity of Binary Search? ";
                    ans[i] = "O(log n)";
                    i++;
                }
            }
            else
            {
                unattempted_ques[j] = "Q9.Time complexity of Binary Search? ";
                unattempted_ans[j] = "O(log n)";
                j++;
            }

            if (rdoq10.SelectedIndex != -1)
            {
                if (rdoq10.SelectedIndex == 0)
                    s += 2;
                else
                {
                    s--;
                    q[i] = "Q10. Which Python data type is immutable?";
                    ans[i] = "Tuple";
                    i++;
                }
            }
            else
            {
                unattempted_ques[j] = "Q10. Which Python data type is immutable?";
                unattempted_ans[j] = "Tuple";
                j++;
            }

            Session["score"] = s;
            Session["question"] = q;
            Session["answer"] = ans;
            Session["index"] = i;
            Session["unattempted_index"] = j;
            Session["unattempted_question"] = unattempted_ques;
            Session["unattempted_answer"] = unattempted_ans;
            Response.Redirect("quiz2.aspx");
        }
    }
}