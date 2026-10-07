using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace registration
{
    public partial class database : System.Web.UI.Page
    {
        public void loadData()
        {
            string conStr = ConfigurationManager.ConnectionStrings["MySqlCon"].ConnectionString;
            using(MySqlConnection con = new MySqlConnection(conStr))
            {                
                string query = "SELECT * FROM student";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                loadData();
        }
    }
}