using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace registration
{
    public partial class student : System.Web.UI.Page
    {
        static int i = 0;
        static string[] name = new string[5];
        static int[] rno = new int[5];
        static string[] dept = new string[5];
        static int[] semester = new int[5];
        static string[] elective = new string[5];
        static string[] batch = new string[5];
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            if (i < 5)
            {
                name[i] = txtname.Text;
                rno[i] = int.Parse(txtrno.Text);
                dept[i] = drpdept.SelectedItem.Text;
                semester[i] = int.Parse(rdosemester.SelectedItem.Text);
                foreach (ListItem l in chkelective.Items)
                {
                    if (l.Selected)
                        elective[i] += l.Text + ", ";
                }
                batch[i] = drplab.SelectedItem.Text;
                i++;
            }
            else
                lbldata.Text = "No more records can be added";
            
        }

        protected void btndisplay_Click(object sender, EventArgs e)
        {
            lbldata.Text = "Roll no   Name      Semester   Department    Elective    Lab Batch";
            for (int j = 0; j < i; j++)
                lbldata.Text += "<br>" + rno[j].ToString() + "     " + name[j] + "    " + semester[j].ToString() + "      " +
                     dept[j] + "      " + elective[j] + "    " + batch[j];
        }
    }
}