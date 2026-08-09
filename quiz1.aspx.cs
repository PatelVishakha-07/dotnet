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
            int s = 0;
            
            if(rdoq1.SelectedIndex != -1)
            {
                if (rdoq1.SelectedIndex == 1)
                    s += 2;
                else
                    s--;
            }

            if (rdoq2.SelectedIndex != -1)
            {
                if (rdoq2.SelectedIndex == 2)
                    s += 2;
                else
                    s--;
            }

            if (rdoq3.SelectedIndex != -1)
            {
                if (rdoq3.SelectedIndex == 0)
                    s += 2;
                else
                    s--;
            }

            if (rdoq4.SelectedIndex != -1)
            {
                if (rdoq4.SelectedIndex == 0)
                    s += 2;
                else
                    s--;
            }

            if (rdoq5.SelectedIndex != -1)
            {
                if (rdoq5.SelectedIndex == 1)
                    s += 2;
                else
                    s--;
            }

            if (rdoq6.SelectedIndex != -1)
            {
                if (rdoq6.SelectedIndex == 2)
                    s += 2;
                else
                    s--;
            }

            if (rdoq7.SelectedIndex != -1)
            {
                if (rdoq7.SelectedIndex == 1)
                    s += 2;
                else
                    s--;
            }

            if (rdoq8.SelectedIndex != -1)
            {
                if (rdoq8.SelectedIndex == 1)
                    s += 2;
                else
                    s--;
            }

            if (rdoq9.SelectedIndex != -1)
            {
                if (rdoq9.SelectedIndex == 0)
                    s += 2;
                else
                    s--;
            }

            if (rdoq10.SelectedIndex != -1)
            {
                if (rdoq10.SelectedIndex == 0)
                    s += 2;
                else
                    s--;
            }

            Session["score"] = s;
            Response.Redirect("quiz2.aspx");
        }
    }
}