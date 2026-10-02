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
        public class Employee
        {
            public int emp_id { get; set; }
            public int salary { get; set; }
            public int dept_id { get; set; }
            public string name { get; set; }
        }

        List<Employee> employees = new List<Employee>()
        {
            new Employee(){emp_id=1, salary=1000, dept_id=1, name="John"},
            new Employee(){emp_id=2, salary=2000, dept_id=2, name="Jane"},
            new Employee(){emp_id=3, salary=3000, dept_id=3, name="Bob"},
            new Employee(){emp_id=4, salary=4000, dept_id=4, name="Alice"},
            new Employee(){emp_id=5, salary=5000, dept_id=5, name="Tom"},
            new Employee(){emp_id=6, salary=6000, dept_id=6, name="Jerry"},
            new Employee(){emp_id=7, salary=7000, dept_id=5, name="Mike"},
            new Employee(){emp_id=8, salary=8000, dept_id=4, name="Sara"},
        };
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text += "All Employees List: <br>";
            foreach(var emp in employees)
            {
                Label1.Text += "Id: " + emp.emp_id + "   Name: " + emp.name + "   Salary: " + 
                    emp.salary + "   Dept Id: " + emp.dept_id + "<br />";
            }

            Label1.Text += "<br>Employees with salary greater than 5000: " + 
                string.Join(", ",employees.Where(emp => emp.salary > 5000).Select(emp => emp.name));

            Label1.Text += "<br><br>Employees whose name starts with 'a': " +
                string.Join(", ", employees.Where(emp => emp.name.EndsWith("a")).Select(emp => emp.name));

            Label1.Text += "<br><br>3rd Employee Details: <br>Name: " + employees[2].name 
                + "   Salary: " + employees[2].salary + "   Dept Id: " + employees[2].dept_id;

        }
    }
}