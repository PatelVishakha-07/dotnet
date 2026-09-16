using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace registration
{
    public partial class inheritance : System.Web.UI.Page
    {
        public class Shape
        {
            public string name;
            public Shape(string name)
            {
                this.name = name;
            }

            public string display()
            {
                return name;
            }
        }

        public class Rectangle : Shape
        {
            int length, width;
            public Rectangle(int length, int width): base("Rectangle")
            {
                this.length = length;
                this.width = width;
            }

            public int calculate_perimeter_rectangle()
            {
                return 2 * length + 2 * width;
            }
        }

        public class Circle : Shape{
            int radius;
            public Circle(int radius) : base("Circle")
            {
                this.radius = radius;
            }

            public double calculate_perimeter_circle()
            {
                return 2 * 3.14 * radius;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btndisplay_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            Rectangle r = new Rectangle(int.Parse(txtlength.Text), int.Parse(txtwidth.Text));
            Label1.Text += "Shape Name: " + r.display();
            Label1.Text += "<br>Perimeter of Rectangle: " + r.calculate_perimeter_rectangle();

            Circle c = new Circle(int.Parse(txtrad.Text));
            Label1.Text += "<br><br>Shape Name: " + c.display();
            Label1.Text += "<br>Perimeter of Circle: " + c.calculate_perimeter_circle();

        }
    }
}