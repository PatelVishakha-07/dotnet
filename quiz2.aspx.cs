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
            string[] q = (string[])Session["question"];
            string[] ans = (string[])Session["answer"];

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

            Session["score"] = int.Parse(Session["score"].ToString()) + s;
            Session["question"] = q;
            Session["answer"] = ans;
            Session["index"] = i;

            Response.Redirect("quiz3.aspx");
        }
    }
}