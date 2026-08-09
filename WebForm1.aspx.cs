using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace registration
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        String s;
        int c = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            //s = TextBox1.Text;
            c += 1;
            //n1 = int.Parse(txtn1.Text);
            //n2 = int.Parse(txtn2.Text);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = c.ToString();
            //Label1.Text += "<br>" + (n1+n2);
        }
    }
}