using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace registration
{
    public partial class image_next : System.Web.UI.Page
    {
        static int i = 0;
        string[] images = {"mahi1.jpg", "rutu.jpg", "mahi2.jpg", "mahi_rutu.jpg", "csk2.jpg"};
        string[] des = {"Mahi", "Rutu", "MSD", "Mahi Rutu", "CSK"};
        protected void Page_Load(object sender, EventArgs e)
        {
            showImage();
            
        }

        protected void btnprev_Click(object sender, EventArgs e)
        {
            btnnext.Enabled = true;
            i--;
            showImage();
            if(i <= 0)
                btnprev.Enabled = false;            
        }

        protected void btnnext_Click(object sender, EventArgs e)
        {
            if (i < images.Length - 1)
            {
                i++;
                showImage();
            }

            //btnprev.Enabled = true;
            //i++;
            //showImage();
            //if (i >= images.Length - 1)
            //    btnnext.Enabled = false;
        }

        void showImage()
        {
            img.ImageUrl = "~/images/" + images[i];
            lbldata.Text = des[i];
        }
    }
}