using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace registration
{
    public partial class radiobutton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtoutput.Text = "";
            if (txtstr.Text == "")
                txtoutput.Text = "Enter string";
            else
            {
                if (RadioButtonList1.SelectedItem.Text == "UpperCase")
                    txtoutput.Text = txtstr.Text.ToUpper();
                else if (RadioButtonList1.SelectedItem.Text == "LowerCase")
                    txtoutput.Text = txtstr.Text.ToLower();
                else
                {
                    if (txtstr.Text.Length < 3)
                        txtoutput.Text = "Enter String with length greater than 3";
                    else
                    {
                        if (RadioButtonList1.SelectedItem.Text == "First 3 Char")
                            txtoutput.Text = txtstr.Text.Substring(0, 3);
                        else if (RadioButtonList1.SelectedItem.Text == "Last 3 Char")
                            txtoutput.Text = txtstr.Text.Substring(txtstr.Text.Length-3);
                    }
                }
            }
        }
    }
}