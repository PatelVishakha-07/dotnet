using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace registration
{
    public partial class tuple : System.Web.UI.Page
    {
        private List<Tuple<string, int, string>> person
        {
            get
            {
                if (ViewState["person"] == null)
                    ViewState["person"] = new List<Tuple<string, int, string>>();
                return (List<Tuple<string, int, string>>)ViewState["person"];
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var p = Tuple.Create(txtname.Text, Convert.ToInt32(txtage.Text), txtcourse.Text);
            person.Add(p);

            string data = "";
            foreach (var item in person)
            {
                data += $"Name: {item.Item1}, Age: {item.Item2}, Course: {item.Item3}<br />";
            }
            Label1.Text = data;
        }
    }
}