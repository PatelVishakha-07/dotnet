using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace registration
{
    public partial class listbox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnright_Click(object sender, EventArgs e)
        {
            lblmsg.Text = "";
            if (lst1.SelectedIndex == -1)
                lblmsg.Text = "Select course from Listbox 1";
            else
            {
                for (int i = lst1.Items.Count - 1; i >= 0; i--)
                {
                    if (lst1.Items[i].Selected)
                    {
                        lst2.Items.Add(lst1.Items[i].Text);
                        lst1.Items.RemoveAt(i);
                    }
                }

                /*int[] ar = new int[lst1.Items.Count];
                int i = 0;
                int c = 0;

                foreach(ListItem l in lst1.Items)
                {
                    if (l.Selected)
                    {
                        lst2.Items.Add(l.Text);
                        ar[i] = c;
                        i++;
                    }
                    c++;
                }

                for (int j = 0; j < i; j++)
                    lst1.Items.RemoveAt(ar[j]);*/
            }
        }

        protected void btnleft_Click(object sender, EventArgs e)
        {
            lblmsg.Text = "";
            if (lst2.SelectedIndex == -1)
                lblmsg.Text = "Select course from Listbox 2";
            else
            {
                for(int i=lst2.Items.Count-1; i>=0; i--)
                {
                    if (lst2.Items[i].Selected)
                    {
                        lst1.Items.Add(lst2.Items[i].Text);
                        lst2.Items.RemoveAt(i);
                    }
                }

                /*int[] ar = new int[lst2.Items.Count];
                int i = 0;
                int c = 0;

                foreach (ListItem l in lst2.Items)
                {
                    if (l.Selected)
                    {
                        lst1.Items.Add(l.Text);
                        ar[i] = c;
                        i++;
                    }
                    c++;
                }

                for (int j = 0; j < i; j++)
                    lst2.Items.RemoveAt(ar[j]);*/

            }
        }

        protected void btnrightall_Click(object sender, EventArgs e)
        {
            /*foreach(ListItem l in lst1.Items)
                lst2.Items.Add(l.Text);            

            int i = 0, c=lst1.Items.Count-1;
            while (i <= c)
            {
                lst1.Items.RemoveAt(i);
                c--;
            }*/

            for (int i = lst1.Items.Count - 1; i >= 0; i--)
            {
                lst2.Items.Add(lst1.Items[i].Text);
                lst1.Items.RemoveAt(i);
            }
        }

        protected void btnleftall_Click(object sender, EventArgs e)
        {
            /*foreach (ListItem l in lst2.Items)
                lst1.Items.Add(l.Text);

            int i = 0, c = lst2.Items.Count - 1;
            while (i <= c)
            {
                lst2.Items.RemoveAt(i);
                c--;
            }*/

            for(int i=lst2.Items.Count-1; i >= 0; i--)
            {
                lst1.Items.Add(lst2.Items[i].Text);
                lst2.Items.RemoveAt(i);
            }
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            if(txtsearch.Text == "")
            {
                lblsearch.Text = "Enter course name";
                return;
            }
            int f = 0, i=0;
            foreach(ListItem l in lst1.Items)
            {
                if(l.Text.ToLower() == txtsearch.Text.ToLower())
                {
                    f = 1;
                    lblsearch.Text = l.Text + " found at " + i + " position";
                    break;
                }
                i++;
            }
            if (f == 0)
                lblsearch.Text = txtsearch.Text + " not found";
        }
    }
}