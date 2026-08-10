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
            int s = 0, i=0;
            string[] q = new string[15];
            string[] ans = new string[15];

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

            if (rdoq6.SelectedIndex != -1)
            {
                if (rdoq6.SelectedIndex == 2)
                    s += 2;
                else
                {
                    s--;
                    q[i] = " Q6. Laravel is written in?";
                    ans[i] = "PHP";
                    i++;
                }
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

            Session["score"] = s;
            Session["question"] = q;
            Session["answer"] = ans;
            Session["index"] = i;
            Response.Redirect("quiz2.aspx");
        }
    }
}