using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace registration
{
    public partial class linq : System.Web.UI.Page
    {
        [Serializable]
        public class Employee
        {
            public int emp_id { get; set; }
            public int salary { get; set; }
            public int dept_id { get; set; }
            public string name { get; set; }
        }

        List<Employee> employees
        {
            get
            {
                if (ViewState["employees"] == null)
                {
                    ViewState["employees"] = new List<Employee>();
                }
                return (List<Employee>)ViewState["employees"];
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            employees.Add(new Employee{emp_id = int.Parse(txtempid.Text), name = txtname.Text, 
                salary = int.Parse(txtsal.Text), dept_id = int.Parse(txtdptid.Text)});
        }

        protected void btndisplay_Click(object sender, EventArgs e)
        {
            Label1.Text = string.Join("<br/>", employees.Select(emp => $"ID: {emp.emp_id}," +
            $" Name: {emp.name}, Salary: {emp.salary}, Dept ID: {emp.dept_id}"));
        }
    }
}